
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsRankCQ : AbstractBsRankCQ {

        protected RankCIQ _inlineQuery;

        public BsRankCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public RankCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new RankCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public RankCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            RankCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _code;
        public ConditionValue Code {
            get { if (_code == null) { _code = new ConditionValue(); } return _code; }
        }
        protected override ConditionValue getCValueCode() { return this.Code; }


        protected Map<String, EmployeeCQ> _code_ExistsSubQuery_EmployeeListMap;
        public Map<String, EmployeeCQ> Code_ExistsSubQuery_EmployeeList { get { return _code_ExistsSubQuery_EmployeeListMap; }}
        public override String keepCode_ExistsSubQuery_EmployeeList(EmployeeCQ subQuery) {
            if (_code_ExistsSubQuery_EmployeeListMap == null) { _code_ExistsSubQuery_EmployeeListMap = new LinkedHashMap<String, EmployeeCQ>(); }
            String key = "subQueryMapKey" + (_code_ExistsSubQuery_EmployeeListMap.size() + 1);
            _code_ExistsSubQuery_EmployeeListMap.put(key, subQuery); return "Code_ExistsSubQuery_EmployeeList." + key;
        }

        protected Map<String, EmployeeCQ> _code_NotExistsSubQuery_EmployeeListMap;
        public Map<String, EmployeeCQ> Code_NotExistsSubQuery_EmployeeList { get { return _code_NotExistsSubQuery_EmployeeListMap; }}
        public override String keepCode_NotExistsSubQuery_EmployeeList(EmployeeCQ subQuery) {
            if (_code_NotExistsSubQuery_EmployeeListMap == null) { _code_NotExistsSubQuery_EmployeeListMap = new LinkedHashMap<String, EmployeeCQ>(); }
            String key = "subQueryMapKey" + (_code_NotExistsSubQuery_EmployeeListMap.size() + 1);
            _code_NotExistsSubQuery_EmployeeListMap.put(key, subQuery); return "Code_NotExistsSubQuery_EmployeeList." + key;
        }

        protected Map<String, EmployeeCQ> _code_InScopeSubQuery_EmployeeListMap;
        public Map<String, EmployeeCQ> Code_InScopeSubQuery_EmployeeList { get { return _code_InScopeSubQuery_EmployeeListMap; }}
        public override String keepCode_InScopeSubQuery_EmployeeList(EmployeeCQ subQuery) {
            if (_code_InScopeSubQuery_EmployeeListMap == null) { _code_InScopeSubQuery_EmployeeListMap = new LinkedHashMap<String, EmployeeCQ>(); }
            String key = "subQueryMapKey" + (_code_InScopeSubQuery_EmployeeListMap.size() + 1);
            _code_InScopeSubQuery_EmployeeListMap.put(key, subQuery); return "Code_InScopeSubQuery_EmployeeList." + key;
        }

        protected Map<String, EmployeeCQ> _code_NotInScopeSubQuery_EmployeeListMap;
        public Map<String, EmployeeCQ> Code_NotInScopeSubQuery_EmployeeList { get { return _code_NotInScopeSubQuery_EmployeeListMap; }}
        public override String keepCode_NotInScopeSubQuery_EmployeeList(EmployeeCQ subQuery) {
            if (_code_NotInScopeSubQuery_EmployeeListMap == null) { _code_NotInScopeSubQuery_EmployeeListMap = new LinkedHashMap<String, EmployeeCQ>(); }
            String key = "subQueryMapKey" + (_code_NotInScopeSubQuery_EmployeeListMap.size() + 1);
            _code_NotInScopeSubQuery_EmployeeListMap.put(key, subQuery); return "Code_NotInScopeSubQuery_EmployeeList." + key;
        }

        protected Map<String, EmployeeCQ> _code_SpecifyDerivedReferrer_EmployeeListMap;
        public Map<String, EmployeeCQ> Code_SpecifyDerivedReferrer_EmployeeList { get { return _code_SpecifyDerivedReferrer_EmployeeListMap; }}
        public override String keepCode_SpecifyDerivedReferrer_EmployeeList(EmployeeCQ subQuery) {
            if (_code_SpecifyDerivedReferrer_EmployeeListMap == null) { _code_SpecifyDerivedReferrer_EmployeeListMap = new LinkedHashMap<String, EmployeeCQ>(); }
            String key = "subQueryMapKey" + (_code_SpecifyDerivedReferrer_EmployeeListMap.size() + 1);
           _code_SpecifyDerivedReferrer_EmployeeListMap.put(key, subQuery); return "Code_SpecifyDerivedReferrer_EmployeeList." + key;
        }

        protected Map<String, EmployeeCQ> _code_QueryDerivedReferrer_EmployeeListMap;
        public Map<String, EmployeeCQ> Code_QueryDerivedReferrer_EmployeeList { get { return _code_QueryDerivedReferrer_EmployeeListMap; } }
        public override String keepCode_QueryDerivedReferrer_EmployeeList(EmployeeCQ subQuery) {
            if (_code_QueryDerivedReferrer_EmployeeListMap == null) { _code_QueryDerivedReferrer_EmployeeListMap = new LinkedHashMap<String, EmployeeCQ>(); }
            String key = "subQueryMapKey" + (_code_QueryDerivedReferrer_EmployeeListMap.size() + 1);
            _code_QueryDerivedReferrer_EmployeeListMap.put(key, subQuery); return "Code_QueryDerivedReferrer_EmployeeList." + key;
        }
        protected Map<String, Object> _code_QueryDerivedReferrer_EmployeeListParameterMap;
        public Map<String, Object> Code_QueryDerivedReferrer_EmployeeListParameter { get { return _code_QueryDerivedReferrer_EmployeeListParameterMap; } }
        public override String keepCode_QueryDerivedReferrer_EmployeeListParameter(Object parameterValue) {
            if (_code_QueryDerivedReferrer_EmployeeListParameterMap == null) { _code_QueryDerivedReferrer_EmployeeListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_code_QueryDerivedReferrer_EmployeeListParameterMap.size() + 1);
            _code_QueryDerivedReferrer_EmployeeListParameterMap.put(key, parameterValue); return "Code_QueryDerivedReferrer_EmployeeListParameter." + key;
        }

        public BsRankCQ AddOrderBy_Code_Asc() { regOBA("code");return this; }
        public BsRankCQ AddOrderBy_Code_Desc() { regOBD("code");return this; }

        protected ConditionValue _englishName;
        public ConditionValue EnglishName {
            get { if (_englishName == null) { _englishName = new ConditionValue(); } return _englishName; }
        }
        protected override ConditionValue getCValueEnglishName() { return this.EnglishName; }


        public BsRankCQ AddOrderBy_EnglishName_Asc() { regOBA("english_name");return this; }
        public BsRankCQ AddOrderBy_EnglishName_Desc() { regOBD("english_name");return this; }

        protected ConditionValue _japaneseName;
        public ConditionValue JapaneseName {
            get { if (_japaneseName == null) { _japaneseName = new ConditionValue(); } return _japaneseName; }
        }
        protected override ConditionValue getCValueJapaneseName() { return this.JapaneseName; }


        public BsRankCQ AddOrderBy_JapaneseName_Asc() { regOBA("japanese_name");return this; }
        public BsRankCQ AddOrderBy_JapaneseName_Desc() { regOBD("japanese_name");return this; }

        public BsRankCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsRankCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, RankCQ> _scalarSubQueryMap;
	    public Map<String, RankCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(RankCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, RankCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, RankCQ> _myselfInScopeSubQueryMap;
        public Map<String, RankCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(RankCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, RankCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
