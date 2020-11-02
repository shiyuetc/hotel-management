
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMstUserCQ : AbstractBsMstUserCQ {

        protected MstUserCIQ _inlineQuery;

        public BsMstUserCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MstUserCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MstUserCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MstUserCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MstUserCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        public BsMstUserCQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsMstUserCQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _loginId;
        public ConditionValue LoginId {
            get { if (_loginId == null) { _loginId = new ConditionValue(); } return _loginId; }
        }
        protected override ConditionValue getCValueLoginId() { return this.LoginId; }


        public BsMstUserCQ AddOrderBy_LoginId_Asc() { regOBA("login_id");return this; }
        public BsMstUserCQ AddOrderBy_LoginId_Desc() { regOBD("login_id");return this; }

        protected ConditionValue _name;
        public ConditionValue Name {
            get { if (_name == null) { _name = new ConditionValue(); } return _name; }
        }
        protected override ConditionValue getCValueName() { return this.Name; }


        public BsMstUserCQ AddOrderBy_Name_Asc() { regOBA("name");return this; }
        public BsMstUserCQ AddOrderBy_Name_Desc() { regOBD("name");return this; }

        protected ConditionValue _password;
        public ConditionValue Password {
            get { if (_password == null) { _password = new ConditionValue(); } return _password; }
        }
        protected override ConditionValue getCValuePassword() { return this.Password; }


        public BsMstUserCQ AddOrderBy_Password_Asc() { regOBA("password");return this; }
        public BsMstUserCQ AddOrderBy_Password_Desc() { regOBD("password");return this; }

        protected ConditionValue _updateTime;
        public ConditionValue UpdateTime {
            get { if (_updateTime == null) { _updateTime = new ConditionValue(); } return _updateTime; }
        }
        protected override ConditionValue getCValueUpdateTime() { return this.UpdateTime; }


        public BsMstUserCQ AddOrderBy_UpdateTime_Asc() { regOBA("update_time");return this; }
        public BsMstUserCQ AddOrderBy_UpdateTime_Desc() { regOBD("update_time");return this; }

        protected ConditionValue _updateUser;
        public ConditionValue UpdateUser {
            get { if (_updateUser == null) { _updateUser = new ConditionValue(); } return _updateUser; }
        }
        protected override ConditionValue getCValueUpdateUser() { return this.UpdateUser; }


        public BsMstUserCQ AddOrderBy_UpdateUser_Asc() { regOBA("update_user");return this; }
        public BsMstUserCQ AddOrderBy_UpdateUser_Desc() { regOBD("update_user");return this; }

        protected ConditionValue _versionNo;
        public ConditionValue VersionNo {
            get { if (_versionNo == null) { _versionNo = new ConditionValue(); } return _versionNo; }
        }
        protected override ConditionValue getCValueVersionNo() { return this.VersionNo; }


        public BsMstUserCQ AddOrderBy_VersionNo_Asc() { regOBA("version_no");return this; }
        public BsMstUserCQ AddOrderBy_VersionNo_Desc() { regOBD("version_no");return this; }

        public BsMstUserCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMstUserCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MstUserCQ> _scalarSubQueryMap;
	    public Map<String, MstUserCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MstUserCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MstUserCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MstUserCQ> _myselfInScopeSubQueryMap;
        public Map<String, MstUserCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MstUserCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MstUserCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
