
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsRoomTypeCQ : AbstractBsRoomTypeCQ {

        protected RoomTypeCIQ _inlineQuery;

        public BsRoomTypeCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public RoomTypeCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new RoomTypeCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public RoomTypeCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            RoomTypeCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _code;
        public ConditionValue Code {
            get { if (_code == null) { _code = new ConditionValue(); } return _code; }
        }
        protected override ConditionValue getCValueCode() { return this.Code; }


        protected Map<String, RoomCQ> _code_ExistsSubQuery_RoomListMap;
        public Map<String, RoomCQ> Code_ExistsSubQuery_RoomList { get { return _code_ExistsSubQuery_RoomListMap; }}
        public override String keepCode_ExistsSubQuery_RoomList(RoomCQ subQuery) {
            if (_code_ExistsSubQuery_RoomListMap == null) { _code_ExistsSubQuery_RoomListMap = new LinkedHashMap<String, RoomCQ>(); }
            String key = "subQueryMapKey" + (_code_ExistsSubQuery_RoomListMap.size() + 1);
            _code_ExistsSubQuery_RoomListMap.put(key, subQuery); return "Code_ExistsSubQuery_RoomList." + key;
        }

        protected Map<String, RoomCQ> _code_NotExistsSubQuery_RoomListMap;
        public Map<String, RoomCQ> Code_NotExistsSubQuery_RoomList { get { return _code_NotExistsSubQuery_RoomListMap; }}
        public override String keepCode_NotExistsSubQuery_RoomList(RoomCQ subQuery) {
            if (_code_NotExistsSubQuery_RoomListMap == null) { _code_NotExistsSubQuery_RoomListMap = new LinkedHashMap<String, RoomCQ>(); }
            String key = "subQueryMapKey" + (_code_NotExistsSubQuery_RoomListMap.size() + 1);
            _code_NotExistsSubQuery_RoomListMap.put(key, subQuery); return "Code_NotExistsSubQuery_RoomList." + key;
        }

        protected Map<String, RoomCQ> _code_InScopeSubQuery_RoomListMap;
        public Map<String, RoomCQ> Code_InScopeSubQuery_RoomList { get { return _code_InScopeSubQuery_RoomListMap; }}
        public override String keepCode_InScopeSubQuery_RoomList(RoomCQ subQuery) {
            if (_code_InScopeSubQuery_RoomListMap == null) { _code_InScopeSubQuery_RoomListMap = new LinkedHashMap<String, RoomCQ>(); }
            String key = "subQueryMapKey" + (_code_InScopeSubQuery_RoomListMap.size() + 1);
            _code_InScopeSubQuery_RoomListMap.put(key, subQuery); return "Code_InScopeSubQuery_RoomList." + key;
        }

        protected Map<String, RoomCQ> _code_NotInScopeSubQuery_RoomListMap;
        public Map<String, RoomCQ> Code_NotInScopeSubQuery_RoomList { get { return _code_NotInScopeSubQuery_RoomListMap; }}
        public override String keepCode_NotInScopeSubQuery_RoomList(RoomCQ subQuery) {
            if (_code_NotInScopeSubQuery_RoomListMap == null) { _code_NotInScopeSubQuery_RoomListMap = new LinkedHashMap<String, RoomCQ>(); }
            String key = "subQueryMapKey" + (_code_NotInScopeSubQuery_RoomListMap.size() + 1);
            _code_NotInScopeSubQuery_RoomListMap.put(key, subQuery); return "Code_NotInScopeSubQuery_RoomList." + key;
        }

        protected Map<String, RoomCQ> _code_SpecifyDerivedReferrer_RoomListMap;
        public Map<String, RoomCQ> Code_SpecifyDerivedReferrer_RoomList { get { return _code_SpecifyDerivedReferrer_RoomListMap; }}
        public override String keepCode_SpecifyDerivedReferrer_RoomList(RoomCQ subQuery) {
            if (_code_SpecifyDerivedReferrer_RoomListMap == null) { _code_SpecifyDerivedReferrer_RoomListMap = new LinkedHashMap<String, RoomCQ>(); }
            String key = "subQueryMapKey" + (_code_SpecifyDerivedReferrer_RoomListMap.size() + 1);
           _code_SpecifyDerivedReferrer_RoomListMap.put(key, subQuery); return "Code_SpecifyDerivedReferrer_RoomList." + key;
        }

        protected Map<String, RoomCQ> _code_QueryDerivedReferrer_RoomListMap;
        public Map<String, RoomCQ> Code_QueryDerivedReferrer_RoomList { get { return _code_QueryDerivedReferrer_RoomListMap; } }
        public override String keepCode_QueryDerivedReferrer_RoomList(RoomCQ subQuery) {
            if (_code_QueryDerivedReferrer_RoomListMap == null) { _code_QueryDerivedReferrer_RoomListMap = new LinkedHashMap<String, RoomCQ>(); }
            String key = "subQueryMapKey" + (_code_QueryDerivedReferrer_RoomListMap.size() + 1);
            _code_QueryDerivedReferrer_RoomListMap.put(key, subQuery); return "Code_QueryDerivedReferrer_RoomList." + key;
        }
        protected Map<String, Object> _code_QueryDerivedReferrer_RoomListParameterMap;
        public Map<String, Object> Code_QueryDerivedReferrer_RoomListParameter { get { return _code_QueryDerivedReferrer_RoomListParameterMap; } }
        public override String keepCode_QueryDerivedReferrer_RoomListParameter(Object parameterValue) {
            if (_code_QueryDerivedReferrer_RoomListParameterMap == null) { _code_QueryDerivedReferrer_RoomListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_code_QueryDerivedReferrer_RoomListParameterMap.size() + 1);
            _code_QueryDerivedReferrer_RoomListParameterMap.put(key, parameterValue); return "Code_QueryDerivedReferrer_RoomListParameter." + key;
        }

        public BsRoomTypeCQ AddOrderBy_Code_Asc() { regOBA("code");return this; }
        public BsRoomTypeCQ AddOrderBy_Code_Desc() { regOBD("code");return this; }

        protected ConditionValue _name;
        public ConditionValue Name {
            get { if (_name == null) { _name = new ConditionValue(); } return _name; }
        }
        protected override ConditionValue getCValueName() { return this.Name; }


        public BsRoomTypeCQ AddOrderBy_Name_Asc() { regOBA("name");return this; }
        public BsRoomTypeCQ AddOrderBy_Name_Desc() { regOBD("name");return this; }

        protected ConditionValue _price;
        public ConditionValue Price {
            get { if (_price == null) { _price = new ConditionValue(); } return _price; }
        }
        protected override ConditionValue getCValuePrice() { return this.Price; }


        public BsRoomTypeCQ AddOrderBy_Price_Asc() { regOBA("price");return this; }
        public BsRoomTypeCQ AddOrderBy_Price_Desc() { regOBD("price");return this; }

        protected ConditionValue _capacity;
        public ConditionValue Capacity {
            get { if (_capacity == null) { _capacity = new ConditionValue(); } return _capacity; }
        }
        protected override ConditionValue getCValueCapacity() { return this.Capacity; }


        public BsRoomTypeCQ AddOrderBy_Capacity_Asc() { regOBA("capacity");return this; }
        public BsRoomTypeCQ AddOrderBy_Capacity_Desc() { regOBD("capacity");return this; }

        protected ConditionValue _description;
        public ConditionValue Description {
            get { if (_description == null) { _description = new ConditionValue(); } return _description; }
        }
        protected override ConditionValue getCValueDescription() { return this.Description; }


        public BsRoomTypeCQ AddOrderBy_Description_Asc() { regOBA("description");return this; }
        public BsRoomTypeCQ AddOrderBy_Description_Desc() { regOBD("description");return this; }

        public BsRoomTypeCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsRoomTypeCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, RoomTypeCQ> _scalarSubQueryMap;
	    public Map<String, RoomTypeCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(RoomTypeCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, RoomTypeCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, RoomTypeCQ> _myselfInScopeSubQueryMap;
        public Map<String, RoomTypeCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(RoomTypeCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, RoomTypeCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
