
using System;
using System.Collections;
using Dbflute.AllCommon.CBean.CKey;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.COption;
using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.CBean.SClause {

// JavaLike
public interface SqlClause {

    // ===================================================================================
    //                                                                      SubQuery Level
    //                                                                      ==============
    int getSubQueryLevel();
    void setupForSubQuery(int subQueryLevel);
    bool isForSubQuery();

    // ===================================================================================
    //                                                                              Clause
    //                                                                              ======
    String getClause();
    String getClauseFromWhereWithUnionTemplate();
    String getClauseFromWhereWithWhereUnionTemplate();

    // ===================================================================================
    //                                                                        Clause Parts
    //                                                                        ============
    String getSelectClause();
    Map<String, int?> getSelectIndexMap();
    Map<String, String> getSelectIndexReverseMap();
    String getSelectHint();
    String getFromClause();
    String getFromBaseTableHint();
    String getFromHint();
    String getWhereClause();
    String getOrderByClause();
    String getSqlSuffix();

    // ===================================================================================
    //                                                                SelectedSelectColumn
    //                                                                ====================
    void registerSelectedSelectColumn(String foreignTableAliasName
                                           , String localTableName
                                           , String foreignPropertyName
                                           , String localRelationPath);

    // ===================================================================================
    //                                                                           OuterJoin
    //                                                                           =========
    void registerOuterJoin(String baseTableDbName, String joinTableDbName, String aliasName,
            Map<String, String> joinOnMap, String fixedCondition, FixedConditionResolver fixedConditionResolver);
    void changeToInnerJoin(String aliasName);
    SqlClause makeInnerJoinEffective();
    SqlClause backToOuterJoin();
    
    // ===================================================================================
    //                                                                               Where
    //                                                                               =====
    void registerWhereClause(String columnFullName, ConditionKey key, ConditionValue value);
    void registerWhereClause(String columnFullName, ConditionKey key, ConditionValue value, ConditionOption option);
    void registerWhereClause(String clause);
    void exchangeFirstWhereClauseForLastOne();
    bool hasWhereClause();

    // ===================================================================================
    //                                                                         InlineWhere
    //                                                                         ===========
    void registerBaseTableInlineWhereClause(String columnName, ConditionKey key, ConditionValue value);
    void registerBaseTableInlineWhereClause(String columnName, ConditionKey key, ConditionValue value, ConditionOption option);
    void registerBaseTableInlineWhereClause(String value);
    void registerOuterJoinInlineWhereClause(String aliasName, String columnName, ConditionKey key, ConditionValue value, bool onClause);
    void registerOuterJoinInlineWhereClause(String aliasName, String columnName, ConditionKey key, ConditionValue value, ConditionOption option, bool onClause);
    void registerOuterJoinInlineWhereClause(String aliasName, String clause, bool onClause);

    // ===================================================================================
    //                                                                        OrScopeQuery
    //                                                                        ============
    void makeOrScopeQueryEffective();
    void closeOrScopeQuery();
    bool isOrScopeQueryEffective();
    void beginOrScopeQueryAndPart();
    void endOrScopeQueryAndPart();

    // ===================================================================================
    //                                                                             OrderBy
    //                                                                             =======
    OrderByClause getSqlComponentOfOrderByClause();
    SqlClause clearOrderBy();
    SqlClause ignoreOrderBy();
    SqlClause makeOrderByEffective();
    
    /**
     * @param orderByProperty Order-by-property. 'aliasName.columnName/aliasName.columnName/...' (NotNull)
     * @param registeredOrderByProperty Registered-order-by-property. ([table-name].[column-name]) (NullAllowed)
     * @param ascOrDesc Is it ascend or descend?
     */
    void registerOrderBy(String orderByProperty, String registeredOrderByProperty, bool ascOrDesc);
    
    /**
     * @param orderByProperty Order-by-property. 'aliasName.columnName/aliasName.columnName/...' (NotNull)
     * @param registeredOrderByProperty Registered-order-by-property. ([table-name].[column-name]) (NullAllowed)
     * @param ascOrDesc Is it ascend or descend?
     */
    void reverseOrderBy_Or_OverrideOrderBy(String orderByProperty, String registeredOrderByProperty, bool ascOrDesc);

    void addNullsFirstToPreviousOrderBy();
    void addNullsLastToPreviousOrderBy();
    bool hasOrderByClause();
    
    // ===================================================================================
    //                                                                               Union
    //                                                                               =====
    void registerUnionQuery(String unionClause, bool unionAll);
    bool hasUnionQuery();

    // ===================================================================================
    //                                                                          FetchScope
    //                                                                          ==========
    SqlClause fetchFirst(int fetchSize);
    SqlClause fetchScope(int fetchStartIndex, int fetchSize);
    SqlClause fetchPage(int fetchPageNumber);
    int getFetchStartIndex();
    int getFetchSize();
    int getFetchPageNumber();
    int getPageStartIndex();
    int getPageEndIndex();
    bool isFetchScopeEffective();
    SqlClause ignoreFetchScope();
    SqlClause makeFetchScopeEffective();
    bool isFetchStartIndexSupported();
    bool isFetchSizeSupported();

    // ===================================================================================
    //                                                                     Fetch Narrowing
    //                                                                     ===============
    bool isFetchNarrowingEffective();
    int getFetchNarrowingSkipStartIndex();
    int getFetchNarrowingLoopCount();

    // ===================================================================================
    //                                                                                Lock
    //                                                                                ====
    SqlClause lockForUpdate();

    // ===================================================================================
    //                                                                    Table Alias Info
    //                                                                    ================
    String getBasePointAliasName();
    String resolveJoinAliasName(String relationPath, int nestLevel);
    int resolveRelationNo(String localTableName, String foreignPropertyName);

    // ===================================================================================
    //                                                                       Template Mark
    //                                                                       =============
    String getWhereClauseMark();
    String getWhereFirstConditionMark();
    String getUnionSelectClauseMark();
    String getUnionWhereClauseMark();
    String getUnionWhereFirstConditionMark();

    // =====================================================================================
    //                                                            Where Clause Simple Filter
    //                                                            ==========================
    // void addWhereClauseSimpleFilter(WhereClauseSimpleFilter whereClauseSimpleFilter);

    // =====================================================================================
    //                                                                 Selected Foreign Info
    //                                                                 =====================
    bool isSelectedForeignInfoEmpty();
    bool hasSelectedForeignInfo(String relationPath);
    void registerSelectedForeignInfo(String relationPath, String foreignPropertyName);

    // ===================================================================================
    //                                                                    Sub Query Indent
    //                                                                    ================
    String resolveSubQueryBeginMark(String subQueryIdentity);
    String resolveSubQueryEndMark(String subQueryIdentity);
    String filterSubQueryIndent(String sql);

    // [DBFlute-0.7.4]
    // ===================================================================================
    //                                                                       Specification
    //                                                                       =============
    void specifySelectColumn(String tableAliasName, String columnName);
    bool hasSpecifiedSelectColumn(String tableAliasName);
    void specifyDeriveSubQuery(String aliasName, String deriveSubQuery);
    bool hasSpecifiedDeriveSubQuery(String aliasName);
    String getSpecifiedColumnNameAsOne();
    String getSpecifiedColumnRealNameAsOne();
    void clearSpecifiedSelectColumn();

    // ===================================================================================
    //                                                                  Invalid Query Info
    //                                                                  ==================
    bool isCheckInvalidQuery();
    void checkInvalidQuery();
    Map<String, ConditionKey> getInvalidQueryColumnMap();
    void registerInvalidQueryColumn(String columnFullName, ConditionKey key);

    // [DBFlute-0.7.9]
    // ===================================================================================
    //                                                                        Query Update
    //                                                                        ============
    String getClauseQueryUpdate(Map<String, String> columnParameterMap);
    String getClauseQueryDelete();

    // [DBFlute-0.8.6]
    // ===================================================================================
    //                                                                  Select Clause Type
    //                                                                  ==================
    void classifySelectClauseType(SelectClauseType selectClauseType);
    void rollbackSelectClauseType();

    // [DBFlute-0.8.9.9]
    // ===================================================================================
    //                                                                       InScope Limit
    //                                                                       =============
    int getInScopeLimit();

}

    public class SelectClauseType {
        public static readonly SelectClauseType COLUMNS = new SelectClauseType("columns");
        public static readonly SelectClauseType COUNT = new SelectClauseType("count");
        public static readonly SelectClauseType MAX = new SelectClauseType("max");
        public static readonly SelectClauseType MIN = new SelectClauseType("min");
        public static readonly SelectClauseType SUM = new SelectClauseType("sum");
        public static readonly SelectClauseType AVG = new SelectClauseType("avg");
        protected String _code;
        protected SelectClauseType(String code) {
            _code = code;
        }
        protected String Code { get { return _code; } }
        public bool equals(Object obj) {
            return Equals(obj);
        }
        public override bool Equals(Object obj) {
            if (!(obj is SelectClauseType)) {
                return false;
            }
            SelectClauseType targetType = (SelectClauseType)obj;
            return _code.Equals(targetType.Code);
        }
        public override int GetHashCode() {
            return 7 + _code.GetHashCode();
        }
        public String toString() {
            return ToString();
        }
        public override String ToString() {
            return _code;
        }
    }

    public interface FixedConditionResolver {
        String resolveVariable(String fixedCondition);
        String resolveFixedInlineView(String foreignTable);
    }
}
