
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMstEmployeeCQ : AbstractBsMstEmployeeCQ {

        protected MstEmployeeCIQ _inlineQuery;

        public BsMstEmployeeCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MstEmployeeCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MstEmployeeCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MstEmployeeCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MstEmployeeCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        public BsMstEmployeeCQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsMstEmployeeCQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _employeeNo;
        public ConditionValue EmployeeNo {
            get { if (_employeeNo == null) { _employeeNo = new ConditionValue(); } return _employeeNo; }
        }
        protected override ConditionValue getCValueEmployeeNo() { return this.EmployeeNo; }


        public BsMstEmployeeCQ AddOrderBy_EmployeeNo_Asc() { regOBA("employee_no");return this; }
        public BsMstEmployeeCQ AddOrderBy_EmployeeNo_Desc() { regOBD("employee_no");return this; }

        protected ConditionValue _name;
        public ConditionValue Name {
            get { if (_name == null) { _name = new ConditionValue(); } return _name; }
        }
        protected override ConditionValue getCValueName() { return this.Name; }


        public BsMstEmployeeCQ AddOrderBy_Name_Asc() { regOBA("name");return this; }
        public BsMstEmployeeCQ AddOrderBy_Name_Desc() { regOBD("name");return this; }

        protected ConditionValue _password;
        public ConditionValue Password {
            get { if (_password == null) { _password = new ConditionValue(); } return _password; }
        }
        protected override ConditionValue getCValuePassword() { return this.Password; }


        public BsMstEmployeeCQ AddOrderBy_Password_Asc() { regOBA("password");return this; }
        public BsMstEmployeeCQ AddOrderBy_Password_Desc() { regOBD("password");return this; }

        protected ConditionValue _rankCode;
        public ConditionValue RankCode {
            get { if (_rankCode == null) { _rankCode = new ConditionValue(); } return _rankCode; }
        }
        protected override ConditionValue getCValueRankCode() { return this.RankCode; }


        protected Map<String, KbnRankCQ> _rankCode_InScopeSubQuery_KbnRankMap;
        public Map<String, KbnRankCQ> RankCode_InScopeSubQuery_KbnRank { get { return _rankCode_InScopeSubQuery_KbnRankMap; }}
        public override String keepRankCode_InScopeSubQuery_KbnRank(KbnRankCQ subQuery) {
            if (_rankCode_InScopeSubQuery_KbnRankMap == null) { _rankCode_InScopeSubQuery_KbnRankMap = new LinkedHashMap<String, KbnRankCQ>(); }
            String key = "subQueryMapKey" + (_rankCode_InScopeSubQuery_KbnRankMap.size() + 1);
            _rankCode_InScopeSubQuery_KbnRankMap.put(key, subQuery); return "RankCode_InScopeSubQuery_KbnRank." + key;
        }

        protected Map<String, KbnRankCQ> _rankCode_NotInScopeSubQuery_KbnRankMap;
        public Map<String, KbnRankCQ> RankCode_NotInScopeSubQuery_KbnRank { get { return _rankCode_NotInScopeSubQuery_KbnRankMap; }}
        public override String keepRankCode_NotInScopeSubQuery_KbnRank(KbnRankCQ subQuery) {
            if (_rankCode_NotInScopeSubQuery_KbnRankMap == null) { _rankCode_NotInScopeSubQuery_KbnRankMap = new LinkedHashMap<String, KbnRankCQ>(); }
            String key = "subQueryMapKey" + (_rankCode_NotInScopeSubQuery_KbnRankMap.size() + 1);
            _rankCode_NotInScopeSubQuery_KbnRankMap.put(key, subQuery); return "RankCode_NotInScopeSubQuery_KbnRank." + key;
        }

        public BsMstEmployeeCQ AddOrderBy_RankCode_Asc() { regOBA("rank_code");return this; }
        public BsMstEmployeeCQ AddOrderBy_RankCode_Desc() { regOBD("rank_code");return this; }

        protected ConditionValue _entryDate;
        public ConditionValue EntryDate {
            get { if (_entryDate == null) { _entryDate = new ConditionValue(); } return _entryDate; }
        }
        protected override ConditionValue getCValueEntryDate() { return this.EntryDate; }


        public BsMstEmployeeCQ AddOrderBy_EntryDate_Asc() { regOBA("entry_date");return this; }
        public BsMstEmployeeCQ AddOrderBy_EntryDate_Desc() { regOBD("entry_date");return this; }

        protected ConditionValue _leaveDate;
        public ConditionValue LeaveDate {
            get { if (_leaveDate == null) { _leaveDate = new ConditionValue(); } return _leaveDate; }
        }
        protected override ConditionValue getCValueLeaveDate() { return this.LeaveDate; }


        public BsMstEmployeeCQ AddOrderBy_LeaveDate_Asc() { regOBA("leave_date");return this; }
        public BsMstEmployeeCQ AddOrderBy_LeaveDate_Desc() { regOBD("leave_date");return this; }

        public BsMstEmployeeCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMstEmployeeCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            MstEmployeeCQ baseQuery = (MstEmployeeCQ)baseQueryAsSuper;
            MstEmployeeCQ unionQuery = (MstEmployeeCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryKbnRank()) {
                unionQuery.QueryKbnRank().reflectRelationOnUnionQuery(baseQuery.QueryKbnRank(), unionQuery.QueryKbnRank());
            }

        }
    
        protected KbnRankCQ _conditionQueryKbnRank;
        public KbnRankCQ QueryKbnRank() {
            return this.ConditionQueryKbnRank;
        }
        public KbnRankCQ ConditionQueryKbnRank {
            get {
                if (_conditionQueryKbnRank == null) {
                    _conditionQueryKbnRank = xcreateQueryKbnRank();
                    xsetupOuterJoin_KbnRank();
                }
                return _conditionQueryKbnRank;
            }
        }
        protected KbnRankCQ xcreateQueryKbnRank() {
            String nrp = resolveNextRelationPathKbnRank();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            KbnRankCQ cq = new KbnRankCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("kbnRank"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_KbnRank() {
            KbnRankCQ cq = ConditionQueryKbnRank;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("rank_code", "code");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathKbnRank() {
            return resolveNextRelationPath("mst_employee", "kbnRank");
        }
        public bool hasConditionQueryKbnRank() {
            return _conditionQueryKbnRank != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MstEmployeeCQ> _scalarSubQueryMap;
	    public Map<String, MstEmployeeCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MstEmployeeCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MstEmployeeCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MstEmployeeCQ> _myselfInScopeSubQueryMap;
        public Map<String, MstEmployeeCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MstEmployeeCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MstEmployeeCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
