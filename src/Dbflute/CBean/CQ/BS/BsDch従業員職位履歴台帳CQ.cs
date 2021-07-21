
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsDch従業員職位履歴台帳CQ : AbstractBsDch従業員職位履歴台帳CQ {

        protected Dch従業員職位履歴台帳CIQ _inlineQuery;

        public BsDch従業員職位履歴台帳CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Dch従業員職位履歴台帳CIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Dch従業員職位履歴台帳CIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Dch従業員職位履歴台帳CIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Dch従業員職位履歴台帳CIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        public BsDch従業員職位履歴台帳CQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsDch従業員職位履歴台帳CQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _従業員id;
        public ConditionValue 従業員id {
            get { if (_従業員id == null) { _従業員id = new ConditionValue(); } return _従業員id; }
        }
        protected override ConditionValue getCValue従業員id() { return this.従業員id; }


        protected Map<String, Mst従業員マスタCQ> _従業員id_InScopeSubQuery_Mst従業員マスタMap;
        public Map<String, Mst従業員マスタCQ> 従業員id_InScopeSubQuery_Mst従業員マスタ { get { return _従業員id_InScopeSubQuery_Mst従業員マスタMap; }}
        public override String keep従業員id_InScopeSubQuery_Mst従業員マスタ(Mst従業員マスタCQ subQuery) {
            if (_従業員id_InScopeSubQuery_Mst従業員マスタMap == null) { _従業員id_InScopeSubQuery_Mst従業員マスタMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
            String key = "subQueryMapKey" + (_従業員id_InScopeSubQuery_Mst従業員マスタMap.size() + 1);
            _従業員id_InScopeSubQuery_Mst従業員マスタMap.put(key, subQuery); return "従業員id_InScopeSubQuery_Mst従業員マスタ." + key;
        }

        protected Map<String, Mst従業員マスタCQ> _従業員id_NotInScopeSubQuery_Mst従業員マスタMap;
        public Map<String, Mst従業員マスタCQ> 従業員id_NotInScopeSubQuery_Mst従業員マスタ { get { return _従業員id_NotInScopeSubQuery_Mst従業員マスタMap; }}
        public override String keep従業員id_NotInScopeSubQuery_Mst従業員マスタ(Mst従業員マスタCQ subQuery) {
            if (_従業員id_NotInScopeSubQuery_Mst従業員マスタMap == null) { _従業員id_NotInScopeSubQuery_Mst従業員マスタMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
            String key = "subQueryMapKey" + (_従業員id_NotInScopeSubQuery_Mst従業員マスタMap.size() + 1);
            _従業員id_NotInScopeSubQuery_Mst従業員マスタMap.put(key, subQuery); return "従業員id_NotInScopeSubQuery_Mst従業員マスタ." + key;
        }

        public BsDch従業員職位履歴台帳CQ AddOrderBy_従業員id_Asc() { regOBA("従業員id");return this; }
        public BsDch従業員職位履歴台帳CQ AddOrderBy_従業員id_Desc() { regOBD("従業員id");return this; }

        protected ConditionValue _適用開始日;
        public ConditionValue 適用開始日 {
            get { if (_適用開始日 == null) { _適用開始日 = new ConditionValue(); } return _適用開始日; }
        }
        protected override ConditionValue getCValue適用開始日() { return this.適用開始日; }


        public BsDch従業員職位履歴台帳CQ AddOrderBy_適用開始日_Asc() { regOBA("適用開始日");return this; }
        public BsDch従業員職位履歴台帳CQ AddOrderBy_適用開始日_Desc() { regOBD("適用開始日");return this; }

        protected ConditionValue _適用終了日;
        public ConditionValue 適用終了日 {
            get { if (_適用終了日 == null) { _適用終了日 = new ConditionValue(); } return _適用終了日; }
        }
        protected override ConditionValue getCValue適用終了日() { return this.適用終了日; }


        public BsDch従業員職位履歴台帳CQ AddOrderBy_適用終了日_Asc() { regOBA("適用終了日");return this; }
        public BsDch従業員職位履歴台帳CQ AddOrderBy_適用終了日_Desc() { regOBD("適用終了日");return this; }

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

        public BsDch従業員職位履歴台帳CQ AddOrderBy_職位code_Asc() { regOBA("職位code");return this; }
        public BsDch従業員職位履歴台帳CQ AddOrderBy_職位code_Desc() { regOBD("職位code");return this; }

        public BsDch従業員職位履歴台帳CQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsDch従業員職位履歴台帳CQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            Dch従業員職位履歴台帳CQ baseQuery = (Dch従業員職位履歴台帳CQ)baseQueryAsSuper;
            Dch従業員職位履歴台帳CQ unionQuery = (Dch従業員職位履歴台帳CQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMst従業員マスタ()) {
                unionQuery.QueryMst従業員マスタ().reflectRelationOnUnionQuery(baseQuery.QueryMst従業員マスタ(), unionQuery.QueryMst従業員マスタ());
            }
            if (baseQuery.hasConditionQueryKbn職位区分()) {
                unionQuery.QueryKbn職位区分().reflectRelationOnUnionQuery(baseQuery.QueryKbn職位区分(), unionQuery.QueryKbn職位区分());
            }

        }
    
        protected Mst従業員マスタCQ _conditionQueryMst従業員マスタ;
        public Mst従業員マスタCQ QueryMst従業員マスタ() {
            return this.ConditionQueryMst従業員マスタ;
        }
        public Mst従業員マスタCQ ConditionQueryMst従業員マスタ {
            get {
                if (_conditionQueryMst従業員マスタ == null) {
                    _conditionQueryMst従業員マスタ = xcreateQueryMst従業員マスタ();
                    xsetupOuterJoin_Mst従業員マスタ();
                }
                return _conditionQueryMst従業員マスタ;
            }
        }
        protected Mst従業員マスタCQ xcreateQueryMst従業員マスタ() {
            String nrp = resolveNextRelationPathMst従業員マスタ();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Mst従業員マスタCQ cq = new Mst従業員マスタCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("mst従業員マスタ"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Mst従業員マスタ() {
            Mst従業員マスタCQ cq = ConditionQueryMst従業員マスタ;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("従業員id", "id");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMst従業員マスタ() {
            return resolveNextRelationPath("dch従業員職位履歴台帳", "mst従業員マスタ");
        }
        public bool hasConditionQueryMst従業員マスタ() {
            return _conditionQueryMst従業員マスタ != null;
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
            return resolveNextRelationPath("dch従業員職位履歴台帳", "kbn職位区分");
        }
        public bool hasConditionQueryKbn職位区分() {
            return _conditionQueryKbn職位区分 != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Dch従業員職位履歴台帳CQ> _scalarSubQueryMap;
	    public Map<String, Dch従業員職位履歴台帳CQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Dch従業員職位履歴台帳CQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Dch従業員職位履歴台帳CQ> _myselfInScopeSubQueryMap;
        public Map<String, Dch従業員職位履歴台帳CQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Dch従業員職位履歴台帳CQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
