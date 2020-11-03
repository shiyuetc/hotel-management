
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsKbnRankCQ : AbstractBsKbnRankCQ {

        protected KbnRankCIQ _inlineQuery;

        public BsKbnRankCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public KbnRankCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new KbnRankCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public KbnRankCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            KbnRankCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _code;
        public ConditionValue Code {
            get { if (_code == null) { _code = new ConditionValue(); } return _code; }
        }
        protected override ConditionValue getCValueCode() { return this.Code; }


        protected Map<String, MstEmployeeCQ> _code_ExistsSubQuery_MstEmployeeListMap;
        public Map<String, MstEmployeeCQ> Code_ExistsSubQuery_MstEmployeeList { get { return _code_ExistsSubQuery_MstEmployeeListMap; }}
        public override String keepCode_ExistsSubQuery_MstEmployeeList(MstEmployeeCQ subQuery) {
            if (_code_ExistsSubQuery_MstEmployeeListMap == null) { _code_ExistsSubQuery_MstEmployeeListMap = new LinkedHashMap<String, MstEmployeeCQ>(); }
            String key = "subQueryMapKey" + (_code_ExistsSubQuery_MstEmployeeListMap.size() + 1);
            _code_ExistsSubQuery_MstEmployeeListMap.put(key, subQuery); return "Code_ExistsSubQuery_MstEmployeeList." + key;
        }

        protected Map<String, MstEmployeeCQ> _code_NotExistsSubQuery_MstEmployeeListMap;
        public Map<String, MstEmployeeCQ> Code_NotExistsSubQuery_MstEmployeeList { get { return _code_NotExistsSubQuery_MstEmployeeListMap; }}
        public override String keepCode_NotExistsSubQuery_MstEmployeeList(MstEmployeeCQ subQuery) {
            if (_code_NotExistsSubQuery_MstEmployeeListMap == null) { _code_NotExistsSubQuery_MstEmployeeListMap = new LinkedHashMap<String, MstEmployeeCQ>(); }
            String key = "subQueryMapKey" + (_code_NotExistsSubQuery_MstEmployeeListMap.size() + 1);
            _code_NotExistsSubQuery_MstEmployeeListMap.put(key, subQuery); return "Code_NotExistsSubQuery_MstEmployeeList." + key;
        }

        protected Map<String, MstEmployeeCQ> _code_InScopeSubQuery_MstEmployeeListMap;
        public Map<String, MstEmployeeCQ> Code_InScopeSubQuery_MstEmployeeList { get { return _code_InScopeSubQuery_MstEmployeeListMap; }}
        public override String keepCode_InScopeSubQuery_MstEmployeeList(MstEmployeeCQ subQuery) {
            if (_code_InScopeSubQuery_MstEmployeeListMap == null) { _code_InScopeSubQuery_MstEmployeeListMap = new LinkedHashMap<String, MstEmployeeCQ>(); }
            String key = "subQueryMapKey" + (_code_InScopeSubQuery_MstEmployeeListMap.size() + 1);
            _code_InScopeSubQuery_MstEmployeeListMap.put(key, subQuery); return "Code_InScopeSubQuery_MstEmployeeList." + key;
        }

        protected Map<String, MstEmployeeCQ> _code_NotInScopeSubQuery_MstEmployeeListMap;
        public Map<String, MstEmployeeCQ> Code_NotInScopeSubQuery_MstEmployeeList { get { return _code_NotInScopeSubQuery_MstEmployeeListMap; }}
        public override String keepCode_NotInScopeSubQuery_MstEmployeeList(MstEmployeeCQ subQuery) {
            if (_code_NotInScopeSubQuery_MstEmployeeListMap == null) { _code_NotInScopeSubQuery_MstEmployeeListMap = new LinkedHashMap<String, MstEmployeeCQ>(); }
            String key = "subQueryMapKey" + (_code_NotInScopeSubQuery_MstEmployeeListMap.size() + 1);
            _code_NotInScopeSubQuery_MstEmployeeListMap.put(key, subQuery); return "Code_NotInScopeSubQuery_MstEmployeeList." + key;
        }

        protected Map<String, MstEmployeeCQ> _code_SpecifyDerivedReferrer_MstEmployeeListMap;
        public Map<String, MstEmployeeCQ> Code_SpecifyDerivedReferrer_MstEmployeeList { get { return _code_SpecifyDerivedReferrer_MstEmployeeListMap; }}
        public override String keepCode_SpecifyDerivedReferrer_MstEmployeeList(MstEmployeeCQ subQuery) {
            if (_code_SpecifyDerivedReferrer_MstEmployeeListMap == null) { _code_SpecifyDerivedReferrer_MstEmployeeListMap = new LinkedHashMap<String, MstEmployeeCQ>(); }
            String key = "subQueryMapKey" + (_code_SpecifyDerivedReferrer_MstEmployeeListMap.size() + 1);
           _code_SpecifyDerivedReferrer_MstEmployeeListMap.put(key, subQuery); return "Code_SpecifyDerivedReferrer_MstEmployeeList." + key;
        }

        protected Map<String, MstEmployeeCQ> _code_QueryDerivedReferrer_MstEmployeeListMap;
        public Map<String, MstEmployeeCQ> Code_QueryDerivedReferrer_MstEmployeeList { get { return _code_QueryDerivedReferrer_MstEmployeeListMap; } }
        public override String keepCode_QueryDerivedReferrer_MstEmployeeList(MstEmployeeCQ subQuery) {
            if (_code_QueryDerivedReferrer_MstEmployeeListMap == null) { _code_QueryDerivedReferrer_MstEmployeeListMap = new LinkedHashMap<String, MstEmployeeCQ>(); }
            String key = "subQueryMapKey" + (_code_QueryDerivedReferrer_MstEmployeeListMap.size() + 1);
            _code_QueryDerivedReferrer_MstEmployeeListMap.put(key, subQuery); return "Code_QueryDerivedReferrer_MstEmployeeList." + key;
        }
        protected Map<String, Object> _code_QueryDerivedReferrer_MstEmployeeListParameterMap;
        public Map<String, Object> Code_QueryDerivedReferrer_MstEmployeeListParameter { get { return _code_QueryDerivedReferrer_MstEmployeeListParameterMap; } }
        public override String keepCode_QueryDerivedReferrer_MstEmployeeListParameter(Object parameterValue) {
            if (_code_QueryDerivedReferrer_MstEmployeeListParameterMap == null) { _code_QueryDerivedReferrer_MstEmployeeListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_code_QueryDerivedReferrer_MstEmployeeListParameterMap.size() + 1);
            _code_QueryDerivedReferrer_MstEmployeeListParameterMap.put(key, parameterValue); return "Code_QueryDerivedReferrer_MstEmployeeListParameter." + key;
        }

        public BsKbnRankCQ AddOrderBy_Code_Asc() { regOBA("code");return this; }
        public BsKbnRankCQ AddOrderBy_Code_Desc() { regOBD("code");return this; }

        protected ConditionValue _englishName;
        public ConditionValue EnglishName {
            get { if (_englishName == null) { _englishName = new ConditionValue(); } return _englishName; }
        }
        protected override ConditionValue getCValueEnglishName() { return this.EnglishName; }


        public BsKbnRankCQ AddOrderBy_EnglishName_Asc() { regOBA("english_name");return this; }
        public BsKbnRankCQ AddOrderBy_EnglishName_Desc() { regOBD("english_name");return this; }

        protected ConditionValue _japaneseName;
        public ConditionValue JapaneseName {
            get { if (_japaneseName == null) { _japaneseName = new ConditionValue(); } return _japaneseName; }
        }
        protected override ConditionValue getCValueJapaneseName() { return this.JapaneseName; }


        public BsKbnRankCQ AddOrderBy_JapaneseName_Asc() { regOBA("japanese_name");return this; }
        public BsKbnRankCQ AddOrderBy_JapaneseName_Desc() { regOBD("japanese_name");return this; }

        public BsKbnRankCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsKbnRankCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, KbnRankCQ> _scalarSubQueryMap;
	    public Map<String, KbnRankCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(KbnRankCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, KbnRankCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, KbnRankCQ> _myselfInScopeSubQueryMap;
        public Map<String, KbnRankCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(KbnRankCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, KbnRankCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
