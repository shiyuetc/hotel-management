
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.Dbm;
using Dbflute.AllCommon.Dbm.Info;
using Dbflute.AllCommon.JavaLike;
using Dbflute.AllCommon.Util;

namespace Dbflute.AllCommon.CBean.CHelper {

public class HpFixedConditionQueryResolver : FixedConditionResolver {

    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    protected readonly ConditionQuery _localCQ;
    protected readonly ConditionQuery _foreignCQ;
    protected readonly DBMetaProvider _dbmetaProvider;
    protected Map<String, InlineViewResource> _inlineViewResourceMap; // internal bridge container

    // ===================================================================================
    //                                                                         Constructor
    //                                                                         ===========
    public HpFixedConditionQueryResolver(ConditionQuery localCQ, ConditionQuery foreignCQ, DBMetaProvider dbmetaProvider) {
        _localCQ = localCQ;
        _foreignCQ = foreignCQ;
        _dbmetaProvider = dbmetaProvider;
    }

    // ===================================================================================
    //                                                                    Resolve Variable
    //                                                                    ================
    /**
     * Resolve variables on fixed condition.
     * @param fixedCondition The plain fixed condition. (NotNull: if null, this is not called)
     * @return The resolved fixed condition. (NotNull)
     */
    public String resolveVariable(String fixedCondition) {
        String localAliasName = _localCQ.xgetAliasName();
        String foreignAliasName = _foreignCQ.xgetAliasName();
        fixedCondition = replaceString(fixedCondition, "$$alias$$", foreignAliasName); // for compatible
        fixedCondition = replaceString(fixedCondition, getLocalAliasMark(), localAliasName);
        fixedCondition = replaceString(fixedCondition, getForeignAliasMark(), foreignAliasName);
        String locationBase = _localCQ.xgetLocationBase();
        fixedCondition = replaceString(fixedCondition, getLocationBaseMark() + ".", "pmb." + locationBase);
        fixedCondition = resolveFixedConditionOverRelation(fixedCondition);
        return fixedCondition;
    }

    protected String resolveFixedConditionOverRelation(String fixedCondition) {
        String relationBeginMark = getRelationBeginMark();
        String relationEndMark = getRelationEndMark();
        String remainder = fixedCondition;
        while (true) {
            IndexOfInfo relationBeginIndex = Srl.indexOfFirst(remainder, relationBeginMark);
            if (relationBeginIndex == null) {
                break;
            }
            remainder = relationBeginIndex.substringRear();
            IndexOfInfo relationEndIndex = Srl.indexOfFirst(remainder, relationEndMark);
            if (relationEndIndex == null) {
                break;
            }

            // analyze:
            // - $$over($$localTable$$.memberStatus)$$
            // - $$over($$foreignTable$$.memberStatus, DISPLAY_ORDER)$$
            // - $$over(PURCHASE.product.productStatus)$$
            String relationExp = relationEndIndex.substringFront();
            String pointTable;
            String targetRelation;
            String secondArg;
            {
                IndexOfInfo separatorIndex = Srl.indexOfFirst(relationExp, ".");
                if (separatorIndex != null) {
                    pointTable = separatorIndex.substringFrontTrimmed();
                    IndexOfInfo argIndex = Srl.indexOfFirst(separatorIndex.substringRearTrimmed(), ",");
                    targetRelation = argIndex != null ? argIndex.substringFrontTrimmed() : separatorIndex
                            .substringRearTrimmed();
                    secondArg = argIndex != null ? argIndex.substringRearTrimmed() : null;
                } else {
                    IndexOfInfo argIndex = Srl.indexOfFirst(relationExp, ",");
                    pointTable = argIndex != null ? argIndex.substringFrontTrimmed() : Srl.trim(relationExp);
                    targetRelation = null;
                    secondArg = argIndex != null ? argIndex.substringRearTrimmed() : null;
                }
            }

            ConditionQuery relationPointCQ;
            ConditionQuery columnTargetCQ;
            if (Srl.equalsPlain(pointTable, getLocalTableMark())) {
                relationPointCQ = _localCQ;
                if (targetRelation != null) {
                    columnTargetCQ = invokeColumnTargetCQ(relationPointCQ, targetRelation);
                } else {
                    String notice = "The relation on fixed condition is required if the table is not referrer.";
                    throwIllegalFixedConditionOverRelationException(notice, pointTable, null, fixedCondition);
                    return null; // unreachable
                }
            } else if (Srl.equalsPlain(pointTable, getForeignTableMark())) {
                relationPointCQ = _foreignCQ;
                columnTargetCQ = relationPointCQ;
                if (targetRelation == null) {
                    String notice = "The relation on fixed condition is required if the table is not referrer.";
                    throwIllegalFixedConditionOverRelationException(notice, pointTable, null, fixedCondition);
                    return null; // unreachable
                }
                // prepare fixed InlineView
                if (_inlineViewResourceMap == null) {
                    _inlineViewResourceMap = new LinkedHashMap<String, InlineViewResource>();
                }
                InlineViewResource resource;
                if (_inlineViewResourceMap.containsKey(targetRelation)) {
                    resource = _inlineViewResourceMap.get(targetRelation);
                } else {
                    resource = new InlineViewResource();
                    _inlineViewResourceMap.put(targetRelation, resource);
                }
                String columnName;
                {
                    IndexOfInfo rearIndex = Srl.indexOfFirst(relationEndIndex.substringRearTrimmed(), ".");
                    if (rearIndex == null || rearIndex.getIndex() > 0) {
                        String notice = "The OverRelation variable should continue to column after the variable.";
                        throwIllegalFixedConditionOverRelationException(notice, pointTable, targetRelation,
                                fixedCondition);
                        return null; // unreachable
                    }
                    String columnStart = rearIndex.substringRear();
                    IndexOfInfo indexInfo = Srl.indexOfFirst(columnStart, " ", ",", ")", "\n", "\t");
                    columnName = indexInfo != null ? indexInfo.substringFront() : columnStart;
                }
                // the secondArg should be a column DB name, and then rear column is alias name
                String resolvedColumn = secondArg != null ? secondArg + " as " + columnName : columnName;
                resource.addAdditionalColumn(resolvedColumn);
                List<String> splitList = Srl.splitList(targetRelation, ".");
                DBMeta currentDBMeta = _dbmetaProvider.provideDBMeta(_foreignCQ.getTableDbName());
                foreach (String element in splitList) {
                    ForeignInfo foreignInfo = currentDBMeta.FindForeignInfo(element);
                    resource.addJoinInfo(foreignInfo);
                    currentDBMeta = foreignInfo.ForeignDBMeta;
                }
            } else {
                DBMeta pointDBMeta;
                try {
                    pointDBMeta = _dbmetaProvider.provideDBMeta(pointTable);
                } catch (DBMetaNotFoundException e) {
                    String notice = "The table for relation on fixed condition does not exist.";
                    throwIllegalFixedConditionOverRelationException(notice, pointTable, targetRelation, fixedCondition,
                            e);
                    return null; // unreachable
                }
                ConditionQuery referrerQuery = _localCQ.xgetReferrerQuery();
                while (true) {
                    if (referrerQuery == null) { // means not found
                        break;
                    }
                    if (Srl.equalsPlain(pointDBMeta.TableDbName, referrerQuery.getTableDbName())) {
                        break;
                    }
                    referrerQuery = referrerQuery.xgetReferrerQuery();
                }
                relationPointCQ = referrerQuery;
                if (relationPointCQ == null) {
                    String notice = "The table for relation on fixed condition was not found in the scope.";
                    throwIllegalFixedConditionOverRelationException(notice, pointTable, targetRelation, fixedCondition);
                    return null; // unreachable
                }
                if (targetRelation != null) {
                    columnTargetCQ = invokeColumnTargetCQ(relationPointCQ, targetRelation);
                } else {
                    columnTargetCQ = relationPointCQ;
                }
            }

            String relationVariable = relationBeginMark + relationExp + relationEndMark;
            String relationAlias = columnTargetCQ.xgetAliasName();
            fixedCondition = replaceString(fixedCondition, relationVariable, relationAlias);

            // after case for loop
            remainder = relationEndIndex.substringRear();

            // for prevent from processing same one
            remainder = replaceString(remainder, relationVariable, relationAlias);
        }
        return fixedCondition;
    }

    protected ConditionQuery invokeColumnTargetCQ(ConditionQuery relationPointCQ, String targetRelation) {
        return relationPointCQ.invokeForeignCQ(targetRelation);
    }

    // ===================================================================================
    //                                                            Resolve Fixed InlineView
    //                                                            ========================
    public String resolveFixedInlineView(String foreignTableSqlName) {
        if (_inlineViewResourceMap == null || _inlineViewResourceMap.isEmpty()) {
            return foreignTableSqlName; // not uses InlineView
        }
        // alias is required because foreignTableSqlName may be (normal) InlineView
        String baseAlias = "dffixedbase";
        String baseIndent = "                    ";
        StringBuilder joinSb = new StringBuilder();
        Map<ForeignInfo, String> relationMap = new HashMap<ForeignInfo, String>();
        List<String> additionalRealColumnList = new ArrayList<String>();
        int groupIndex = 0;
        foreach (InlineViewResource resource in _inlineViewResourceMap.values()) {
            List<ForeignInfo> joinInfoList = resource.getJoinInfoList();
            String aliasBase = "dffixedjoin";
            String preForeignAlias = null;
            String foreignAlias = null;
            int joinIndex = 0;
            foreach (ForeignInfo joinInfo in joinInfoList) {
                if (relationMap.containsKey(joinInfo)) { // already joined
                    preForeignAlias = relationMap.get(joinInfo); // update previous alias
                    continue;
                }
                String foreignTable;
                String localAlias;
                {
                    DBMeta foreignDBMeta = joinInfo.ForeignDBMeta;
                    foreignTable = foreignDBMeta.TableSqlName;
                    localAlias = (preForeignAlias != null ? preForeignAlias : baseAlias);
                    foreignAlias = aliasBase + "_" + groupIndex + "_" + joinIndex;
                    preForeignAlias = foreignAlias;
                }
                joinSb.append(ln()).append(baseIndent);
                joinSb.append("     left outer join ").append(foreignTable).append(" ").append(foreignAlias);
                joinSb.append(" on ");
                Map<ColumnInfo, ColumnInfo> columnInfoMap = joinInfo.LocalForeignColumnInfoMap;
                int columnIndex = 0;
                foreach (Entry<ColumnInfo, ColumnInfo> localForeignEntry in columnInfoMap.entrySet()) {
                    ColumnInfo localColumnInfo = localForeignEntry.getKey();
                    ColumnInfo foreignColumninfo = localForeignEntry.getValue();
                    if (columnIndex > 0) {
                        joinSb.append(" and ");
                    }
                    joinSb.append(localAlias).append(".").append(localColumnInfo.ColumnDbName);
                    joinSb.append(" = ").append(foreignAlias).append(".").append(foreignColumninfo.ColumnDbName);
                    ++columnIndex;
                }
                relationMap.put(joinInfo, foreignAlias);
                ++joinIndex;
            }
            Set<String> additionalColumnSet = resource.getAdditionalColumnSet();
            foreach (String columnName in additionalColumnSet) {
                additionalRealColumnList.add(foreignAlias + "." + columnName); // latest alias is target
            }
            ++groupIndex;
        }
        StringBuilder sqlSb = new StringBuilder();
        sqlSb.append("(select ").append(baseAlias).append(".*");
        foreach (String columnName in additionalRealColumnList) {
            sqlSb.append(", ").append(columnName);
        }
        sqlSb.append(ln()).append(baseIndent);
        sqlSb.append("   from ").append(foreignTableSqlName).append(" ").append(baseAlias);
        sqlSb.append(joinSb);
        sqlSb.append(ln()).append(baseIndent);
        sqlSb.append(")");
        return sqlSb.toString();
    }

    // ===================================================================================
    //                                                                    InlineView Class
    //                                                                    ================
    protected class InlineViewResource {
        protected Set<String> _additionalColumnSet;
        protected List<ForeignInfo> _joinInfoList;

        public Set<String> getAdditionalColumnSet() {
            return _additionalColumnSet;
        }

        public void addAdditionalColumn(String additionalColumn) {
            if (_additionalColumnSet == null) {
                _additionalColumnSet = new LinkedHashSet<String>();
            }
            _additionalColumnSet.add(additionalColumn);
        }

        public List<ForeignInfo> getJoinInfoList() {
            return _joinInfoList;
        }

        public void addJoinInfo(ForeignInfo joinInfo) {
            if (_joinInfoList == null) {
                _joinInfoList = new ArrayList<ForeignInfo>();
            }
            _joinInfoList.add(joinInfo);
        }
    }

    // ===================================================================================
    //                                                                  Exception Handling
    //                                                                  ==================
    protected void throwIllegalFixedConditionOverRelationException(String notice, String tableName,
            String relationName, String fixedCondition) {
        throwIllegalFixedConditionOverRelationException(notice, tableName, relationName, fixedCondition, null);
    }

    protected void throwIllegalFixedConditionOverRelationException(String notice, String tableName
            , String relationName, String fixedCondition, Exception e) {
        String msg = notice;
        msg = msg + " pointTable=" + tableName + " targetRelation=" + relationName;
        msg = msg + " fixedCondition=" + fixedCondition;
        msg = msg + " BizOneToOne's local=" + _localCQ.getTableDbName();
        throw new IllegalStateException(msg, e);
    }

    // ===================================================================================
    //                                                                       Variable Mark
    //                                                                       =============
    protected String getLocalAliasMark() {
        return "$$localAlias$$";
    }

    protected String getForeignAliasMark() {
        return "$$foreignAlias$$";
    }

    protected String getLocationBaseMark() {
        return "$$locationBase$$";
    }

    protected String getRelationBeginMark() {
        return "$$over(";
    }

    protected String getRelationEndMark() {
        return ")$$";
    }

    protected String getLocalTableMark() {
        return "$localTable";
    }

    protected String getForeignTableMark() {
        return "$foreignTable";
    }

    // ===================================================================================
    //                                                                      General Helper
    //                                                                      ==============
    protected String replaceString(String text, String fromText, String toText) {
        return Srl.replace(text, fromText, toText);
    }

    protected String ln() {
        return DfSystemUtil.getLineSeparator();
    }
}

}