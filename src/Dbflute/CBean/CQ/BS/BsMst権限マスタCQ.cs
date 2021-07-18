
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMst権限マスタCQ : AbstractBsMst権限マスタCQ {

        protected Mst権限マスタCIQ _inlineQuery;

        public BsMst権限マスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Mst権限マスタCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Mst権限マスタCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Mst権限マスタCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Mst権限マスタCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        public BsMst権限マスタCQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsMst権限マスタCQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _職位コード;
        public ConditionValue 職位コード {
            get { if (_職位コード == null) { _職位コード = new ConditionValue(); } return _職位コード; }
        }
        protected override ConditionValue getCValue職位コード() { return this.職位コード; }


        protected Map<String, Kbn職位区分CQ> _職位コード_InScopeSubQuery_Kbn職位区分Map;
        public Map<String, Kbn職位区分CQ> 職位コード_InScopeSubQuery_Kbn職位区分 { get { return _職位コード_InScopeSubQuery_Kbn職位区分Map; }}
        public override String keep職位コード_InScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery) {
            if (_職位コード_InScopeSubQuery_Kbn職位区分Map == null) { _職位コード_InScopeSubQuery_Kbn職位区分Map = new LinkedHashMap<String, Kbn職位区分CQ>(); }
            String key = "subQueryMapKey" + (_職位コード_InScopeSubQuery_Kbn職位区分Map.size() + 1);
            _職位コード_InScopeSubQuery_Kbn職位区分Map.put(key, subQuery); return "職位コード_InScopeSubQuery_Kbn職位区分." + key;
        }

        protected Map<String, Kbn職位区分CQ> _職位コード_NotInScopeSubQuery_Kbn職位区分Map;
        public Map<String, Kbn職位区分CQ> 職位コード_NotInScopeSubQuery_Kbn職位区分 { get { return _職位コード_NotInScopeSubQuery_Kbn職位区分Map; }}
        public override String keep職位コード_NotInScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery) {
            if (_職位コード_NotInScopeSubQuery_Kbn職位区分Map == null) { _職位コード_NotInScopeSubQuery_Kbn職位区分Map = new LinkedHashMap<String, Kbn職位区分CQ>(); }
            String key = "subQueryMapKey" + (_職位コード_NotInScopeSubQuery_Kbn職位区分Map.size() + 1);
            _職位コード_NotInScopeSubQuery_Kbn職位区分Map.put(key, subQuery); return "職位コード_NotInScopeSubQuery_Kbn職位区分." + key;
        }

        public BsMst権限マスタCQ AddOrderBy_職位コード_Asc() { regOBA("職位コード");return this; }
        public BsMst権限マスタCQ AddOrderBy_職位コード_Desc() { regOBD("職位コード");return this; }

        protected ConditionValue _権限コード;
        public ConditionValue 権限コード {
            get { if (_権限コード == null) { _権限コード = new ConditionValue(); } return _権限コード; }
        }
        protected override ConditionValue getCValue権限コード() { return this.権限コード; }


        protected Map<String, Kbn権限区分CQ> _権限コード_InScopeSubQuery_Kbn権限区分Map;
        public Map<String, Kbn権限区分CQ> 権限コード_InScopeSubQuery_Kbn権限区分 { get { return _権限コード_InScopeSubQuery_Kbn権限区分Map; }}
        public override String keep権限コード_InScopeSubQuery_Kbn権限区分(Kbn権限区分CQ subQuery) {
            if (_権限コード_InScopeSubQuery_Kbn権限区分Map == null) { _権限コード_InScopeSubQuery_Kbn権限区分Map = new LinkedHashMap<String, Kbn権限区分CQ>(); }
            String key = "subQueryMapKey" + (_権限コード_InScopeSubQuery_Kbn権限区分Map.size() + 1);
            _権限コード_InScopeSubQuery_Kbn権限区分Map.put(key, subQuery); return "権限コード_InScopeSubQuery_Kbn権限区分." + key;
        }

        protected Map<String, Kbn権限区分CQ> _権限コード_NotInScopeSubQuery_Kbn権限区分Map;
        public Map<String, Kbn権限区分CQ> 権限コード_NotInScopeSubQuery_Kbn権限区分 { get { return _権限コード_NotInScopeSubQuery_Kbn権限区分Map; }}
        public override String keep権限コード_NotInScopeSubQuery_Kbn権限区分(Kbn権限区分CQ subQuery) {
            if (_権限コード_NotInScopeSubQuery_Kbn権限区分Map == null) { _権限コード_NotInScopeSubQuery_Kbn権限区分Map = new LinkedHashMap<String, Kbn権限区分CQ>(); }
            String key = "subQueryMapKey" + (_権限コード_NotInScopeSubQuery_Kbn権限区分Map.size() + 1);
            _権限コード_NotInScopeSubQuery_Kbn権限区分Map.put(key, subQuery); return "権限コード_NotInScopeSubQuery_Kbn権限区分." + key;
        }

        public BsMst権限マスタCQ AddOrderBy_権限コード_Asc() { regOBA("権限コード");return this; }
        public BsMst権限マスタCQ AddOrderBy_権限コード_Desc() { regOBD("権限コード");return this; }

        public BsMst権限マスタCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMst権限マスタCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            Mst権限マスタCQ baseQuery = (Mst権限マスタCQ)baseQueryAsSuper;
            Mst権限マスタCQ unionQuery = (Mst権限マスタCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryKbn権限区分()) {
                unionQuery.QueryKbn権限区分().reflectRelationOnUnionQuery(baseQuery.QueryKbn権限区分(), unionQuery.QueryKbn権限区分());
            }
            if (baseQuery.hasConditionQueryKbn職位区分()) {
                unionQuery.QueryKbn職位区分().reflectRelationOnUnionQuery(baseQuery.QueryKbn職位区分(), unionQuery.QueryKbn職位区分());
            }

        }
    
        protected Kbn権限区分CQ _conditionQueryKbn権限区分;
        public Kbn権限区分CQ QueryKbn権限区分() {
            return this.ConditionQueryKbn権限区分;
        }
        public Kbn権限区分CQ ConditionQueryKbn権限区分 {
            get {
                if (_conditionQueryKbn権限区分 == null) {
                    _conditionQueryKbn権限区分 = xcreateQueryKbn権限区分();
                    xsetupOuterJoin_Kbn権限区分();
                }
                return _conditionQueryKbn権限区分;
            }
        }
        protected Kbn権限区分CQ xcreateQueryKbn権限区分() {
            String nrp = resolveNextRelationPathKbn権限区分();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Kbn権限区分CQ cq = new Kbn権限区分CQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("kbn権限区分"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Kbn権限区分() {
            Kbn権限区分CQ cq = ConditionQueryKbn権限区分;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("権限コード", "コード");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathKbn権限区分() {
            return resolveNextRelationPath("mst権限マスタ", "kbn権限区分");
        }
        public bool hasConditionQueryKbn権限区分() {
            return _conditionQueryKbn権限区分 != null;
        }
        protected Kbn職位区分CQ _conditionQueryKbn職位区分;
        public Kbn職位区分CQ QueryKbn職位区分() {
            return this.ConditionQueryKbn職位区分;
        }
        public Kbn職位区分CQ ConditionQueryKbn職位区分 {
            get {
                if (_conditionQueryKbn職位区分 == null) {
                    _conditionQueryKbn職位区分 = xcreateQueryKbn職位区分();
                    xsetupOuterJoin_Kbn職位区分();
                }
                return _conditionQueryKbn職位区分;
            }
        }
        protected Kbn職位区分CQ xcreateQueryKbn職位区分() {
            String nrp = resolveNextRelationPathKbn職位区分();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Kbn職位区分CQ cq = new Kbn職位区分CQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("kbn職位区分"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Kbn職位区分() {
            Kbn職位区分CQ cq = ConditionQueryKbn職位区分;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("職位コード", "コード");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathKbn職位区分() {
            return resolveNextRelationPath("mst権限マスタ", "kbn職位区分");
        }
        public bool hasConditionQueryKbn職位区分() {
            return _conditionQueryKbn職位区分 != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Mst権限マスタCQ> _scalarSubQueryMap;
	    public Map<String, Mst権限マスタCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Mst権限マスタCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Mst権限マスタCQ> _myselfInScopeSubQueryMap;
        public Map<String, Mst権限マスタCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Mst権限マスタCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
