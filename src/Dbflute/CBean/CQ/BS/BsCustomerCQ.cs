
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsCustomerCQ : AbstractBsCustomerCQ {

        protected CustomerCIQ _inlineQuery;

        public BsCustomerCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public CustomerCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new CustomerCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public CustomerCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            CustomerCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        public BsCustomerCQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsCustomerCQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _lastName;
        public ConditionValue LastName {
            get { if (_lastName == null) { _lastName = new ConditionValue(); } return _lastName; }
        }
        protected override ConditionValue getCValueLastName() { return this.LastName; }


        public BsCustomerCQ AddOrderBy_LastName_Asc() { regOBA("last_name");return this; }
        public BsCustomerCQ AddOrderBy_LastName_Desc() { regOBD("last_name");return this; }

        protected ConditionValue _firstName;
        public ConditionValue FirstName {
            get { if (_firstName == null) { _firstName = new ConditionValue(); } return _firstName; }
        }
        protected override ConditionValue getCValueFirstName() { return this.FirstName; }


        public BsCustomerCQ AddOrderBy_FirstName_Asc() { regOBA("first_name");return this; }
        public BsCustomerCQ AddOrderBy_FirstName_Desc() { regOBD("first_name");return this; }

        public BsCustomerCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsCustomerCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, CustomerCQ> _scalarSubQueryMap;
	    public Map<String, CustomerCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(CustomerCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, CustomerCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, CustomerCQ> _myselfInScopeSubQueryMap;
        public Map<String, CustomerCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(CustomerCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, CustomerCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
