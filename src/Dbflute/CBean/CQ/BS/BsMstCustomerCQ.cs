
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMstCustomerCQ : AbstractBsMstCustomerCQ {

        protected MstCustomerCIQ _inlineQuery;

        public BsMstCustomerCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MstCustomerCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MstCustomerCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MstCustomerCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MstCustomerCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        public BsMstCustomerCQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsMstCustomerCQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _name;
        public ConditionValue Name {
            get { if (_name == null) { _name = new ConditionValue(); } return _name; }
        }
        protected override ConditionValue getCValueName() { return this.Name; }


        public BsMstCustomerCQ AddOrderBy_Name_Asc() { regOBA("name");return this; }
        public BsMstCustomerCQ AddOrderBy_Name_Desc() { regOBD("name");return this; }

        public BsMstCustomerCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMstCustomerCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MstCustomerCQ> _scalarSubQueryMap;
	    public Map<String, MstCustomerCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MstCustomerCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MstCustomerCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MstCustomerCQ> _myselfInScopeSubQueryMap;
        public Map<String, MstCustomerCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MstCustomerCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MstCustomerCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
