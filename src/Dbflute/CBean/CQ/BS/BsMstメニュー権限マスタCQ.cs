
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMstメニュー権限マスタCQ : AbstractBsMstメニュー権限マスタCQ {

        protected Mstメニュー権限マスタCIQ _inlineQuery;

        public BsMstメニュー権限マスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Mstメニュー権限マスタCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Mstメニュー権限マスタCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Mstメニュー権限マスタCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Mstメニュー権限マスタCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        public BsMstメニュー権限マスタCQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsMstメニュー権限マスタCQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _職位code;
        public ConditionValue 職位code {
            get { if (_職位code == null) { _職位code = new ConditionValue(); } return _職位code; }
        }
        protected override ConditionValue getCValue職位code() { return this.職位code; }


        protected Map<String, Kbn職位区分CQ> _職位code_InScopeSubQuery_Kbn職位区分Map;
        public Map<String, Kbn職位区分CQ> 職位code_InScopeSubQuery_Kbn職位区分 { get { return _職位code_InScopeSubQuery_Kbn職位区分Map; }}
        public override String keep職位code_InScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery) {
            if (_職位code_InScopeSubQuery_Kbn職位区分Map == null) { _職位code_InScopeSubQuery_Kbn職位区分Map = new LinkedHashMap<String, Kbn職位区分CQ>(); }
            String key = "subQueryMapKey" + (_職位code_InScopeSubQuery_Kbn職位区分Map.size() + 1);
            _職位code_InScopeSubQuery_Kbn職位区分Map.put(key, subQuery); return "職位code_InScopeSubQuery_Kbn職位区分." + key;
        }

        protected Map<String, Kbn職位区分CQ> _職位code_NotInScopeSubQuery_Kbn職位区分Map;
        public Map<String, Kbn職位区分CQ> 職位code_NotInScopeSubQuery_Kbn職位区分 { get { return _職位code_NotInScopeSubQuery_Kbn職位区分Map; }}
        public override String keep職位code_NotInScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery) {
            if (_職位code_NotInScopeSubQuery_Kbn職位区分Map == null) { _職位code_NotInScopeSubQuery_Kbn職位区分Map = new LinkedHashMap<String, Kbn職位区分CQ>(); }
            String key = "subQueryMapKey" + (_職位code_NotInScopeSubQuery_Kbn職位区分Map.size() + 1);
            _職位code_NotInScopeSubQuery_Kbn職位区分Map.put(key, subQuery); return "職位code_NotInScopeSubQuery_Kbn職位区分." + key;
        }

        public BsMstメニュー権限マスタCQ AddOrderBy_職位code_Asc() { regOBA("職位code");return this; }
        public BsMstメニュー権限マスタCQ AddOrderBy_職位code_Desc() { regOBD("職位code");return this; }

        protected ConditionValue _制御画面id;
        public ConditionValue 制御画面id {
            get { if (_制御画面id == null) { _制御画面id = new ConditionValue(); } return _制御画面id; }
        }
        protected override ConditionValue getCValue制御画面id() { return this.制御画面id; }


        protected Map<String, Mst制御画面マスタCQ> _制御画面id_InScopeSubQuery_Mst制御画面マスタMap;
        public Map<String, Mst制御画面マスタCQ> 制御画面id_InScopeSubQuery_Mst制御画面マスタ { get { return _制御画面id_InScopeSubQuery_Mst制御画面マスタMap; }}
        public override String keep制御画面id_InScopeSubQuery_Mst制御画面マスタ(Mst制御画面マスタCQ subQuery) {
            if (_制御画面id_InScopeSubQuery_Mst制御画面マスタMap == null) { _制御画面id_InScopeSubQuery_Mst制御画面マスタMap = new LinkedHashMap<String, Mst制御画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_制御画面id_InScopeSubQuery_Mst制御画面マスタMap.size() + 1);
            _制御画面id_InScopeSubQuery_Mst制御画面マスタMap.put(key, subQuery); return "制御画面id_InScopeSubQuery_Mst制御画面マスタ." + key;
        }

        protected Map<String, Mst制御画面マスタCQ> _制御画面id_NotInScopeSubQuery_Mst制御画面マスタMap;
        public Map<String, Mst制御画面マスタCQ> 制御画面id_NotInScopeSubQuery_Mst制御画面マスタ { get { return _制御画面id_NotInScopeSubQuery_Mst制御画面マスタMap; }}
        public override String keep制御画面id_NotInScopeSubQuery_Mst制御画面マスタ(Mst制御画面マスタCQ subQuery) {
            if (_制御画面id_NotInScopeSubQuery_Mst制御画面マスタMap == null) { _制御画面id_NotInScopeSubQuery_Mst制御画面マスタMap = new LinkedHashMap<String, Mst制御画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_制御画面id_NotInScopeSubQuery_Mst制御画面マスタMap.size() + 1);
            _制御画面id_NotInScopeSubQuery_Mst制御画面マスタMap.put(key, subQuery); return "制御画面id_NotInScopeSubQuery_Mst制御画面マスタ." + key;
        }

        public BsMstメニュー権限マスタCQ AddOrderBy_制御画面id_Asc() { regOBA("制御画面id");return this; }
        public BsMstメニュー権限マスタCQ AddOrderBy_制御画面id_Desc() { regOBD("制御画面id");return this; }

        public BsMstメニュー権限マスタCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMstメニュー権限マスタCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            Mstメニュー権限マスタCQ baseQuery = (Mstメニュー権限マスタCQ)baseQueryAsSuper;
            Mstメニュー権限マスタCQ unionQuery = (Mstメニュー権限マスタCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMst制御画面マスタ()) {
                unionQuery.QueryMst制御画面マスタ().reflectRelationOnUnionQuery(baseQuery.QueryMst制御画面マスタ(), unionQuery.QueryMst制御画面マスタ());
            }
            if (baseQuery.hasConditionQueryKbn職位区分()) {
                unionQuery.QueryKbn職位区分().reflectRelationOnUnionQuery(baseQuery.QueryKbn職位区分(), unionQuery.QueryKbn職位区分());
            }

        }
    
        protected Mst制御画面マスタCQ _conditionQueryMst制御画面マスタ;
        public Mst制御画面マスタCQ QueryMst制御画面マスタ() {
            return this.ConditionQueryMst制御画面マスタ;
        }
        public Mst制御画面マスタCQ ConditionQueryMst制御画面マスタ {
            get {
                if (_conditionQueryMst制御画面マスタ == null) {
                    _conditionQueryMst制御画面マスタ = xcreateQueryMst制御画面マスタ();
                    xsetupOuterJoin_Mst制御画面マスタ();
                }
                return _conditionQueryMst制御画面マスタ;
            }
        }
        protected Mst制御画面マスタCQ xcreateQueryMst制御画面マスタ() {
            String nrp = resolveNextRelationPathMst制御画面マスタ();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Mst制御画面マスタCQ cq = new Mst制御画面マスタCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("mst制御画面マスタ"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Mst制御画面マスタ() {
            Mst制御画面マスタCQ cq = ConditionQueryMst制御画面マスタ;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("制御画面id", "id");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMst制御画面マスタ() {
            return resolveNextRelationPath("mstメニュー権限マスタ", "mst制御画面マスタ");
        }
        public bool hasConditionQueryMst制御画面マスタ() {
            return _conditionQueryMst制御画面マスタ != null;
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
            joinOnMap.put("職位code", "code");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathKbn職位区分() {
            return resolveNextRelationPath("mstメニュー権限マスタ", "kbn職位区分");
        }
        public bool hasConditionQueryKbn職位区分() {
            return _conditionQueryKbn職位区分 != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Mstメニュー権限マスタCQ> _scalarSubQueryMap;
	    public Map<String, Mstメニュー権限マスタCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Mstメニュー権限マスタCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Mstメニュー権限マスタCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Mstメニュー権限マスタCQ> _myselfInScopeSubQueryMap;
        public Map<String, Mstメニュー権限マスタCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Mstメニュー権限マスタCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Mstメニュー権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
