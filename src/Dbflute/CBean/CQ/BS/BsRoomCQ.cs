
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsRoomCQ : AbstractBsRoomCQ {

        protected RoomCIQ _inlineQuery;

        public BsRoomCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public RoomCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new RoomCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public RoomCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            RoomCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        public BsRoomCQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsRoomCQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _roomNo;
        public ConditionValue RoomNo {
            get { if (_roomNo == null) { _roomNo = new ConditionValue(); } return _roomNo; }
        }
        protected override ConditionValue getCValueRoomNo() { return this.RoomNo; }


        public BsRoomCQ AddOrderBy_RoomNo_Asc() { regOBA("room_no");return this; }
        public BsRoomCQ AddOrderBy_RoomNo_Desc() { regOBD("room_no");return this; }

        protected ConditionValue _roomTypeCode;
        public ConditionValue RoomTypeCode {
            get { if (_roomTypeCode == null) { _roomTypeCode = new ConditionValue(); } return _roomTypeCode; }
        }
        protected override ConditionValue getCValueRoomTypeCode() { return this.RoomTypeCode; }


        public BsRoomCQ AddOrderBy_RoomTypeCode_Asc() { regOBA("room_type_code");return this; }
        public BsRoomCQ AddOrderBy_RoomTypeCode_Desc() { regOBD("room_type_code");return this; }

        protected ConditionValue _canSmoke;
        public ConditionValue CanSmoke {
            get { if (_canSmoke == null) { _canSmoke = new ConditionValue(); } return _canSmoke; }
        }
        protected override ConditionValue getCValueCanSmoke() { return this.CanSmoke; }


        public BsRoomCQ AddOrderBy_CanSmoke_Asc() { regOBA("can_smoke");return this; }
        public BsRoomCQ AddOrderBy_CanSmoke_Desc() { regOBD("can_smoke");return this; }

        public BsRoomCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsRoomCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, RoomCQ> _scalarSubQueryMap;
	    public Map<String, RoomCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(RoomCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, RoomCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, RoomCQ> _myselfInScopeSubQueryMap;
        public Map<String, RoomCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(RoomCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, RoomCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
