
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsEmployeeCQ : AbstractBsEmployeeCQ {

        protected EmployeeCIQ _inlineQuery;

        public BsEmployeeCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public EmployeeCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new EmployeeCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public EmployeeCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            EmployeeCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        public BsEmployeeCQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsEmployeeCQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _employeeNo;
        public ConditionValue EmployeeNo {
            get { if (_employeeNo == null) { _employeeNo = new ConditionValue(); } return _employeeNo; }
        }
        protected override ConditionValue getCValueEmployeeNo() { return this.EmployeeNo; }


        public BsEmployeeCQ AddOrderBy_EmployeeNo_Asc() { regOBA("employee_no");return this; }
        public BsEmployeeCQ AddOrderBy_EmployeeNo_Desc() { regOBD("employee_no");return this; }

        protected ConditionValue _lastName;
        public ConditionValue LastName {
            get { if (_lastName == null) { _lastName = new ConditionValue(); } return _lastName; }
        }
        protected override ConditionValue getCValueLastName() { return this.LastName; }


        public BsEmployeeCQ AddOrderBy_LastName_Asc() { regOBA("last_name");return this; }
        public BsEmployeeCQ AddOrderBy_LastName_Desc() { regOBD("last_name");return this; }

        protected ConditionValue _firstName;
        public ConditionValue FirstName {
            get { if (_firstName == null) { _firstName = new ConditionValue(); } return _firstName; }
        }
        protected override ConditionValue getCValueFirstName() { return this.FirstName; }


        public BsEmployeeCQ AddOrderBy_FirstName_Asc() { regOBA("first_name");return this; }
        public BsEmployeeCQ AddOrderBy_FirstName_Desc() { regOBD("first_name");return this; }

        protected ConditionValue _rubyName;
        public ConditionValue RubyName {
            get { if (_rubyName == null) { _rubyName = new ConditionValue(); } return _rubyName; }
        }
        protected override ConditionValue getCValueRubyName() { return this.RubyName; }


        public BsEmployeeCQ AddOrderBy_RubyName_Asc() { regOBA("ruby_name");return this; }
        public BsEmployeeCQ AddOrderBy_RubyName_Desc() { regOBD("ruby_name");return this; }

        protected ConditionValue _email;
        public ConditionValue Email {
            get { if (_email == null) { _email = new ConditionValue(); } return _email; }
        }
        protected override ConditionValue getCValueEmail() { return this.Email; }


        public BsEmployeeCQ AddOrderBy_Email_Asc() { regOBA("email");return this; }
        public BsEmployeeCQ AddOrderBy_Email_Desc() { regOBD("email");return this; }

        protected ConditionValue _password;
        public ConditionValue Password {
            get { if (_password == null) { _password = new ConditionValue(); } return _password; }
        }
        protected override ConditionValue getCValuePassword() { return this.Password; }


        public BsEmployeeCQ AddOrderBy_Password_Asc() { regOBA("password");return this; }
        public BsEmployeeCQ AddOrderBy_Password_Desc() { regOBD("password");return this; }

        protected ConditionValue _rankCode;
        public ConditionValue RankCode {
            get { if (_rankCode == null) { _rankCode = new ConditionValue(); } return _rankCode; }
        }
        protected override ConditionValue getCValueRankCode() { return this.RankCode; }


        protected Map<String, RankCQ> _rankCode_InScopeSubQuery_RankMap;
        public Map<String, RankCQ> RankCode_InScopeSubQuery_Rank { get { return _rankCode_InScopeSubQuery_RankMap; }}
        public override String keepRankCode_InScopeSubQuery_Rank(RankCQ subQuery) {
            if (_rankCode_InScopeSubQuery_RankMap == null) { _rankCode_InScopeSubQuery_RankMap = new LinkedHashMap<String, RankCQ>(); }
            String key = "subQueryMapKey" + (_rankCode_InScopeSubQuery_RankMap.size() + 1);
            _rankCode_InScopeSubQuery_RankMap.put(key, subQuery); return "RankCode_InScopeSubQuery_Rank." + key;
        }

        protected Map<String, RankCQ> _rankCode_NotInScopeSubQuery_RankMap;
        public Map<String, RankCQ> RankCode_NotInScopeSubQuery_Rank { get { return _rankCode_NotInScopeSubQuery_RankMap; }}
        public override String keepRankCode_NotInScopeSubQuery_Rank(RankCQ subQuery) {
            if (_rankCode_NotInScopeSubQuery_RankMap == null) { _rankCode_NotInScopeSubQuery_RankMap = new LinkedHashMap<String, RankCQ>(); }
            String key = "subQueryMapKey" + (_rankCode_NotInScopeSubQuery_RankMap.size() + 1);
            _rankCode_NotInScopeSubQuery_RankMap.put(key, subQuery); return "RankCode_NotInScopeSubQuery_Rank." + key;
        }

        public BsEmployeeCQ AddOrderBy_RankCode_Asc() { regOBA("rank_code");return this; }
        public BsEmployeeCQ AddOrderBy_RankCode_Desc() { regOBD("rank_code");return this; }

        protected ConditionValue _entryDate;
        public ConditionValue EntryDate {
            get { if (_entryDate == null) { _entryDate = new ConditionValue(); } return _entryDate; }
        }
        protected override ConditionValue getCValueEntryDate() { return this.EntryDate; }


        public BsEmployeeCQ AddOrderBy_EntryDate_Asc() { regOBA("entry_date");return this; }
        public BsEmployeeCQ AddOrderBy_EntryDate_Desc() { regOBD("entry_date");return this; }

        protected ConditionValue _leaveDate;
        public ConditionValue LeaveDate {
            get { if (_leaveDate == null) { _leaveDate = new ConditionValue(); } return _leaveDate; }
        }
        protected override ConditionValue getCValueLeaveDate() { return this.LeaveDate; }


        public BsEmployeeCQ AddOrderBy_LeaveDate_Asc() { regOBA("leave_date");return this; }
        public BsEmployeeCQ AddOrderBy_LeaveDate_Desc() { regOBD("leave_date");return this; }

        public BsEmployeeCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsEmployeeCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            EmployeeCQ baseQuery = (EmployeeCQ)baseQueryAsSuper;
            EmployeeCQ unionQuery = (EmployeeCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryRank()) {
                unionQuery.QueryRank().reflectRelationOnUnionQuery(baseQuery.QueryRank(), unionQuery.QueryRank());
            }

        }
    
        protected RankCQ _conditionQueryRank;
        public RankCQ QueryRank() {
            return this.ConditionQueryRank;
        }
        public RankCQ ConditionQueryRank {
            get {
                if (_conditionQueryRank == null) {
                    _conditionQueryRank = xcreateQueryRank();
                    xsetupOuterJoin_Rank();
                }
                return _conditionQueryRank;
            }
        }
        protected RankCQ xcreateQueryRank() {
            String nrp = resolveNextRelationPathRank();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            RankCQ cq = new RankCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("rank"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Rank() {
            RankCQ cq = ConditionQueryRank;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("rank_code", "code");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathRank() {
            return resolveNextRelationPath("employee", "rank");
        }
        public bool hasConditionQueryRank() {
            return _conditionQueryRank != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, EmployeeCQ> _scalarSubQueryMap;
	    public Map<String, EmployeeCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(EmployeeCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, EmployeeCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, EmployeeCQ> _myselfInScopeSubQueryMap;
        public Map<String, EmployeeCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(EmployeeCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, EmployeeCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
