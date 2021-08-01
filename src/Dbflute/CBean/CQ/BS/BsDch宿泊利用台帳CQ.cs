
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsDch宿泊利用台帳CQ : AbstractBsDch宿泊利用台帳CQ {

        protected Dch宿泊利用台帳CIQ _inlineQuery;

        public BsDch宿泊利用台帳CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Dch宿泊利用台帳CIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Dch宿泊利用台帳CIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Dch宿泊利用台帳CIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Dch宿泊利用台帳CIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _客室利用台帳id;
        public ConditionValue 客室利用台帳id {
            get { if (_客室利用台帳id == null) { _客室利用台帳id = new ConditionValue(); } return _客室利用台帳id; }
        }
        protected override ConditionValue getCValue客室利用台帳id() { return this.客室利用台帳id; }


        protected Map<String, Dch客室利用台帳CQ> _客室利用台帳id_InScopeSubQuery_Dch客室利用台帳Map;
        public Map<String, Dch客室利用台帳CQ> 客室利用台帳id_InScopeSubQuery_Dch客室利用台帳 { get { return _客室利用台帳id_InScopeSubQuery_Dch客室利用台帳Map; }}
        public override String keep客室利用台帳id_InScopeSubQuery_Dch客室利用台帳(Dch客室利用台帳CQ subQuery) {
            if (_客室利用台帳id_InScopeSubQuery_Dch客室利用台帳Map == null) { _客室利用台帳id_InScopeSubQuery_Dch客室利用台帳Map = new LinkedHashMap<String, Dch客室利用台帳CQ>(); }
            String key = "subQueryMapKey" + (_客室利用台帳id_InScopeSubQuery_Dch客室利用台帳Map.size() + 1);
            _客室利用台帳id_InScopeSubQuery_Dch客室利用台帳Map.put(key, subQuery); return "客室利用台帳id_InScopeSubQuery_Dch客室利用台帳." + key;
        }

        protected Map<String, Dch客室利用台帳CQ> _客室利用台帳id_NotInScopeSubQuery_Dch客室利用台帳Map;
        public Map<String, Dch客室利用台帳CQ> 客室利用台帳id_NotInScopeSubQuery_Dch客室利用台帳 { get { return _客室利用台帳id_NotInScopeSubQuery_Dch客室利用台帳Map; }}
        public override String keep客室利用台帳id_NotInScopeSubQuery_Dch客室利用台帳(Dch客室利用台帳CQ subQuery) {
            if (_客室利用台帳id_NotInScopeSubQuery_Dch客室利用台帳Map == null) { _客室利用台帳id_NotInScopeSubQuery_Dch客室利用台帳Map = new LinkedHashMap<String, Dch客室利用台帳CQ>(); }
            String key = "subQueryMapKey" + (_客室利用台帳id_NotInScopeSubQuery_Dch客室利用台帳Map.size() + 1);
            _客室利用台帳id_NotInScopeSubQuery_Dch客室利用台帳Map.put(key, subQuery); return "客室利用台帳id_NotInScopeSubQuery_Dch客室利用台帳." + key;
        }

        public BsDch宿泊利用台帳CQ AddOrderBy_客室利用台帳id_Asc() { regOBA("客室利用台帳id");return this; }
        public BsDch宿泊利用台帳CQ AddOrderBy_客室利用台帳id_Desc() { regOBD("客室利用台帳id");return this; }

        protected ConditionValue _会員コード;
        public ConditionValue 会員コード {
            get { if (_会員コード == null) { _会員コード = new ConditionValue(); } return _会員コード; }
        }
        protected override ConditionValue getCValue会員コード() { return this.会員コード; }


        protected Map<String, Mst会員マスタCQ> _会員コード_InScopeSubQuery_Mst会員マスタMap;
        public Map<String, Mst会員マスタCQ> 会員コード_InScopeSubQuery_Mst会員マスタ { get { return _会員コード_InScopeSubQuery_Mst会員マスタMap; }}
        public override String keep会員コード_InScopeSubQuery_Mst会員マスタ(Mst会員マスタCQ subQuery) {
            if (_会員コード_InScopeSubQuery_Mst会員マスタMap == null) { _会員コード_InScopeSubQuery_Mst会員マスタMap = new LinkedHashMap<String, Mst会員マスタCQ>(); }
            String key = "subQueryMapKey" + (_会員コード_InScopeSubQuery_Mst会員マスタMap.size() + 1);
            _会員コード_InScopeSubQuery_Mst会員マスタMap.put(key, subQuery); return "会員コード_InScopeSubQuery_Mst会員マスタ." + key;
        }

        protected Map<String, Mst会員マスタCQ> _会員コード_NotInScopeSubQuery_Mst会員マスタMap;
        public Map<String, Mst会員マスタCQ> 会員コード_NotInScopeSubQuery_Mst会員マスタ { get { return _会員コード_NotInScopeSubQuery_Mst会員マスタMap; }}
        public override String keep会員コード_NotInScopeSubQuery_Mst会員マスタ(Mst会員マスタCQ subQuery) {
            if (_会員コード_NotInScopeSubQuery_Mst会員マスタMap == null) { _会員コード_NotInScopeSubQuery_Mst会員マスタMap = new LinkedHashMap<String, Mst会員マスタCQ>(); }
            String key = "subQueryMapKey" + (_会員コード_NotInScopeSubQuery_Mst会員マスタMap.size() + 1);
            _会員コード_NotInScopeSubQuery_Mst会員マスタMap.put(key, subQuery); return "会員コード_NotInScopeSubQuery_Mst会員マスタ." + key;
        }

        public BsDch宿泊利用台帳CQ AddOrderBy_会員コード_Asc() { regOBA("会員コード");return this; }
        public BsDch宿泊利用台帳CQ AddOrderBy_会員コード_Desc() { regOBD("会員コード");return this; }

        protected ConditionValue _宿泊料金;
        public ConditionValue 宿泊料金 {
            get { if (_宿泊料金 == null) { _宿泊料金 = new ConditionValue(); } return _宿泊料金; }
        }
        protected override ConditionValue getCValue宿泊料金() { return this.宿泊料金; }


        public BsDch宿泊利用台帳CQ AddOrderBy_宿泊料金_Asc() { regOBA("宿泊料金");return this; }
        public BsDch宿泊利用台帳CQ AddOrderBy_宿泊料金_Desc() { regOBD("宿泊料金");return this; }

        public BsDch宿泊利用台帳CQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsDch宿泊利用台帳CQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            Dch宿泊利用台帳CQ baseQuery = (Dch宿泊利用台帳CQ)baseQueryAsSuper;
            Dch宿泊利用台帳CQ unionQuery = (Dch宿泊利用台帳CQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMst会員マスタ()) {
                unionQuery.QueryMst会員マスタ().reflectRelationOnUnionQuery(baseQuery.QueryMst会員マスタ(), unionQuery.QueryMst会員マスタ());
            }
            if (baseQuery.hasConditionQueryDch客室利用台帳()) {
                unionQuery.QueryDch客室利用台帳().reflectRelationOnUnionQuery(baseQuery.QueryDch客室利用台帳(), unionQuery.QueryDch客室利用台帳());
            }

        }
    
        protected Mst会員マスタCQ _conditionQueryMst会員マスタ;
        public Mst会員マスタCQ QueryMst会員マスタ() {
            return this.ConditionQueryMst会員マスタ;
        }
        public Mst会員マスタCQ ConditionQueryMst会員マスタ {
            get {
                if (_conditionQueryMst会員マスタ == null) {
                    _conditionQueryMst会員マスタ = xcreateQueryMst会員マスタ();
                    xsetupOuterJoin_Mst会員マスタ();
                }
                return _conditionQueryMst会員マスタ;
            }
        }
        protected Mst会員マスタCQ xcreateQueryMst会員マスタ() {
            String nrp = resolveNextRelationPathMst会員マスタ();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Mst会員マスタCQ cq = new Mst会員マスタCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("mst会員マスタ"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Mst会員マスタ() {
            Mst会員マスタCQ cq = ConditionQueryMst会員マスタ;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("会員コード", "会員コード");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMst会員マスタ() {
            return resolveNextRelationPath("dch宿泊利用台帳", "mst会員マスタ");
        }
        public bool hasConditionQueryMst会員マスタ() {
            return _conditionQueryMst会員マスタ != null;
        }
        protected Dch客室利用台帳CQ _conditionQueryDch客室利用台帳;
        public Dch客室利用台帳CQ QueryDch客室利用台帳() {
            return this.ConditionQueryDch客室利用台帳;
        }
        public Dch客室利用台帳CQ ConditionQueryDch客室利用台帳 {
            get {
                if (_conditionQueryDch客室利用台帳 == null) {
                    _conditionQueryDch客室利用台帳 = xcreateQueryDch客室利用台帳();
                    xsetupOuterJoin_Dch客室利用台帳();
                }
                return _conditionQueryDch客室利用台帳;
            }
        }
        protected Dch客室利用台帳CQ xcreateQueryDch客室利用台帳() {
            String nrp = resolveNextRelationPathDch客室利用台帳();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Dch客室利用台帳CQ cq = new Dch客室利用台帳CQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("dch客室利用台帳"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Dch客室利用台帳() {
            Dch客室利用台帳CQ cq = ConditionQueryDch客室利用台帳;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("客室利用台帳id", "id");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathDch客室利用台帳() {
            return resolveNextRelationPath("dch宿泊利用台帳", "dch客室利用台帳");
        }
        public bool hasConditionQueryDch客室利用台帳() {
            return _conditionQueryDch客室利用台帳 != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Dch宿泊利用台帳CQ> _scalarSubQueryMap;
	    public Map<String, Dch宿泊利用台帳CQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Dch宿泊利用台帳CQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Dch宿泊利用台帳CQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Dch宿泊利用台帳CQ> _myselfInScopeSubQueryMap;
        public Map<String, Dch宿泊利用台帳CQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Dch宿泊利用台帳CQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Dch宿泊利用台帳CQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
