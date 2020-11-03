
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMstRoomCQ : AbstractBsMstRoomCQ {

        protected MstRoomCIQ _inlineQuery;

        public BsMstRoomCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MstRoomCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MstRoomCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MstRoomCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MstRoomCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        public BsMstRoomCQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsMstRoomCQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _roomNo;
        public ConditionValue RoomNo {
            get { if (_roomNo == null) { _roomNo = new ConditionValue(); } return _roomNo; }
        }
        protected override ConditionValue getCValueRoomNo() { return this.RoomNo; }


        public BsMstRoomCQ AddOrderBy_RoomNo_Asc() { regOBA("room_no");return this; }
        public BsMstRoomCQ AddOrderBy_RoomNo_Desc() { regOBD("room_no");return this; }

        protected ConditionValue _roomTypeCode;
        public ConditionValue RoomTypeCode {
            get { if (_roomTypeCode == null) { _roomTypeCode = new ConditionValue(); } return _roomTypeCode; }
        }
        protected override ConditionValue getCValueRoomTypeCode() { return this.RoomTypeCode; }


        public BsMstRoomCQ AddOrderBy_RoomTypeCode_Asc() { regOBA("room_type_code");return this; }
        public BsMstRoomCQ AddOrderBy_RoomTypeCode_Desc() { regOBD("room_type_code");return this; }

        protected ConditionValue _canSmoke;
        public ConditionValue CanSmoke {
            get { if (_canSmoke == null) { _canSmoke = new ConditionValue(); } return _canSmoke; }
        }
        protected override ConditionValue getCValueCanSmoke() { return this.CanSmoke; }


        public BsMstRoomCQ AddOrderBy_CanSmoke_Asc() { regOBA("can_smoke");return this; }
        public BsMstRoomCQ AddOrderBy_CanSmoke_Desc() { regOBD("can_smoke");return this; }

        public BsMstRoomCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMstRoomCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MstRoomCQ> _scalarSubQueryMap;
	    public Map<String, MstRoomCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MstRoomCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MstRoomCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MstRoomCQ> _myselfInScopeSubQueryMap;
        public Map<String, MstRoomCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MstRoomCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MstRoomCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
