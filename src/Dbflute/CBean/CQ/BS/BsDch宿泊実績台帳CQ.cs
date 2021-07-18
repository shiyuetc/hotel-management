
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsDch宿泊実績台帳CQ : AbstractBsDch宿泊実績台帳CQ {

        protected Dch宿泊実績台帳CIQ _inlineQuery;

        public BsDch宿泊実績台帳CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Dch宿泊実績台帳CIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Dch宿泊実績台帳CIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Dch宿泊実績台帳CIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Dch宿泊実績台帳CIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        public BsDch宿泊実績台帳CQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsDch宿泊実績台帳CQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _客室利用実績台帳id;
        public ConditionValue 客室利用実績台帳id {
            get { if (_客室利用実績台帳id == null) { _客室利用実績台帳id = new ConditionValue(); } return _客室利用実績台帳id; }
        }
        protected override ConditionValue getCValue客室利用実績台帳id() { return this.客室利用実績台帳id; }


        protected Map<String, Dch客室利用実績台帳CQ> _客室利用実績台帳id_InScopeSubQuery_Dch客室利用実績台帳Map;
        public Map<String, Dch客室利用実績台帳CQ> 客室利用実績台帳id_InScopeSubQuery_Dch客室利用実績台帳 { get { return _客室利用実績台帳id_InScopeSubQuery_Dch客室利用実績台帳Map; }}
        public override String keep客室利用実績台帳id_InScopeSubQuery_Dch客室利用実績台帳(Dch客室利用実績台帳CQ subQuery) {
            if (_客室利用実績台帳id_InScopeSubQuery_Dch客室利用実績台帳Map == null) { _客室利用実績台帳id_InScopeSubQuery_Dch客室利用実績台帳Map = new LinkedHashMap<String, Dch客室利用実績台帳CQ>(); }
            String key = "subQueryMapKey" + (_客室利用実績台帳id_InScopeSubQuery_Dch客室利用実績台帳Map.size() + 1);
            _客室利用実績台帳id_InScopeSubQuery_Dch客室利用実績台帳Map.put(key, subQuery); return "客室利用実績台帳id_InScopeSubQuery_Dch客室利用実績台帳." + key;
        }

        protected Map<String, Dch客室利用実績台帳CQ> _客室利用実績台帳id_NotInScopeSubQuery_Dch客室利用実績台帳Map;
        public Map<String, Dch客室利用実績台帳CQ> 客室利用実績台帳id_NotInScopeSubQuery_Dch客室利用実績台帳 { get { return _客室利用実績台帳id_NotInScopeSubQuery_Dch客室利用実績台帳Map; }}
        public override String keep客室利用実績台帳id_NotInScopeSubQuery_Dch客室利用実績台帳(Dch客室利用実績台帳CQ subQuery) {
            if (_客室利用実績台帳id_NotInScopeSubQuery_Dch客室利用実績台帳Map == null) { _客室利用実績台帳id_NotInScopeSubQuery_Dch客室利用実績台帳Map = new LinkedHashMap<String, Dch客室利用実績台帳CQ>(); }
            String key = "subQueryMapKey" + (_客室利用実績台帳id_NotInScopeSubQuery_Dch客室利用実績台帳Map.size() + 1);
            _客室利用実績台帳id_NotInScopeSubQuery_Dch客室利用実績台帳Map.put(key, subQuery); return "客室利用実績台帳id_NotInScopeSubQuery_Dch客室利用実績台帳." + key;
        }

        public BsDch宿泊実績台帳CQ AddOrderBy_客室利用実績台帳id_Asc() { regOBA("客室利用実績台帳id");return this; }
        public BsDch宿泊実績台帳CQ AddOrderBy_客室利用実績台帳id_Desc() { regOBD("客室利用実績台帳id");return this; }

        public BsDch宿泊実績台帳CQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsDch宿泊実績台帳CQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            Dch宿泊実績台帳CQ baseQuery = (Dch宿泊実績台帳CQ)baseQueryAsSuper;
            Dch宿泊実績台帳CQ unionQuery = (Dch宿泊実績台帳CQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryDch客室利用実績台帳()) {
                unionQuery.QueryDch客室利用実績台帳().reflectRelationOnUnionQuery(baseQuery.QueryDch客室利用実績台帳(), unionQuery.QueryDch客室利用実績台帳());
            }

        }
    
        protected Dch客室利用実績台帳CQ _conditionQueryDch客室利用実績台帳;
        public Dch客室利用実績台帳CQ QueryDch客室利用実績台帳() {
            return this.ConditionQueryDch客室利用実績台帳;
        }
        public Dch客室利用実績台帳CQ ConditionQueryDch客室利用実績台帳 {
            get {
                if (_conditionQueryDch客室利用実績台帳 == null) {
                    _conditionQueryDch客室利用実績台帳 = xcreateQueryDch客室利用実績台帳();
                    xsetupOuterJoin_Dch客室利用実績台帳();
                }
                return _conditionQueryDch客室利用実績台帳;
            }
        }
        protected Dch客室利用実績台帳CQ xcreateQueryDch客室利用実績台帳() {
            String nrp = resolveNextRelationPathDch客室利用実績台帳();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Dch客室利用実績台帳CQ cq = new Dch客室利用実績台帳CQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("dch客室利用実績台帳"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Dch客室利用実績台帳() {
            Dch客室利用実績台帳CQ cq = ConditionQueryDch客室利用実績台帳;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("客室利用実績台帳id", "id");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathDch客室利用実績台帳() {
            return resolveNextRelationPath("dch宿泊実績台帳", "dch客室利用実績台帳");
        }
        public bool hasConditionQueryDch客室利用実績台帳() {
            return _conditionQueryDch客室利用実績台帳 != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Dch宿泊実績台帳CQ> _scalarSubQueryMap;
	    public Map<String, Dch宿泊実績台帳CQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Dch宿泊実績台帳CQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Dch宿泊実績台帳CQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Dch宿泊実績台帳CQ> _myselfInScopeSubQueryMap;
        public Map<String, Dch宿泊実績台帳CQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Dch宿泊実績台帳CQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Dch宿泊実績台帳CQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
