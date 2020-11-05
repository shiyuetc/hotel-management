
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsKbnRoomTypeCQ : AbstractBsKbnRoomTypeCQ {

        protected KbnRoomTypeCIQ _inlineQuery;

        public BsKbnRoomTypeCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public KbnRoomTypeCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new KbnRoomTypeCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public KbnRoomTypeCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            KbnRoomTypeCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _code;
        public ConditionValue Code {
            get { if (_code == null) { _code = new ConditionValue(); } return _code; }
        }
        protected override ConditionValue getCValueCode() { return this.Code; }


        public BsKbnRoomTypeCQ AddOrderBy_Code_Asc() { regOBA("code");return this; }
        public BsKbnRoomTypeCQ AddOrderBy_Code_Desc() { regOBD("code");return this; }

        protected ConditionValue _name;
        public ConditionValue Name {
            get { if (_name == null) { _name = new ConditionValue(); } return _name; }
        }
        protected override ConditionValue getCValueName() { return this.Name; }


        public BsKbnRoomTypeCQ AddOrderBy_Name_Asc() { regOBA("name");return this; }
        public BsKbnRoomTypeCQ AddOrderBy_Name_Desc() { regOBD("name");return this; }

        protected ConditionValue _price;
        public ConditionValue Price {
            get { if (_price == null) { _price = new ConditionValue(); } return _price; }
        }
        protected override ConditionValue getCValuePrice() { return this.Price; }


        public BsKbnRoomTypeCQ AddOrderBy_Price_Asc() { regOBA("price");return this; }
        public BsKbnRoomTypeCQ AddOrderBy_Price_Desc() { regOBD("price");return this; }

        protected ConditionValue _capacity;
        public ConditionValue Capacity {
            get { if (_capacity == null) { _capacity = new ConditionValue(); } return _capacity; }
        }
        protected override ConditionValue getCValueCapacity() { return this.Capacity; }


        public BsKbnRoomTypeCQ AddOrderBy_Capacity_Asc() { regOBA("capacity");return this; }
        public BsKbnRoomTypeCQ AddOrderBy_Capacity_Desc() { regOBD("capacity");return this; }

        protected ConditionValue _description;
        public ConditionValue Description {
            get { if (_description == null) { _description = new ConditionValue(); } return _description; }
        }
        protected override ConditionValue getCValueDescription() { return this.Description; }


        public BsKbnRoomTypeCQ AddOrderBy_Description_Asc() { regOBA("description");return this; }
        public BsKbnRoomTypeCQ AddOrderBy_Description_Desc() { regOBD("description");return this; }

        public BsKbnRoomTypeCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsKbnRoomTypeCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, KbnRoomTypeCQ> _scalarSubQueryMap;
	    public Map<String, KbnRoomTypeCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(KbnRoomTypeCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, KbnRoomTypeCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, KbnRoomTypeCQ> _myselfInScopeSubQueryMap;
        public Map<String, KbnRoomTypeCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(KbnRoomTypeCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, KbnRoomTypeCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}