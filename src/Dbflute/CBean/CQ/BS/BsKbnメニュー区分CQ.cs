
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsKbnメニュー区分CQ : AbstractBsKbnメニュー区分CQ {

        protected Kbnメニュー区分CIQ _inlineQuery;

        public BsKbnメニュー区分CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Kbnメニュー区分CIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Kbnメニュー区分CIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Kbnメニュー区分CIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Kbnメニュー区分CIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _code;
        public ConditionValue Code {
            get { if (_code == null) { _code = new ConditionValue(); } return _code; }
        }
        protected override ConditionValue getCValueCode() { return this.Code; }


        protected Map<String, Mst制御画面マスタCQ> _code_ExistsSubQuery_Mst制御画面マスタListMap;
        public Map<String, Mst制御画面マスタCQ> Code_ExistsSubQuery_Mst制御画面マスタList { get { return _code_ExistsSubQuery_Mst制御画面マスタListMap; }}
        public override String keepCode_ExistsSubQuery_Mst制御画面マスタList(Mst制御画面マスタCQ subQuery) {
            if (_code_ExistsSubQuery_Mst制御画面マスタListMap == null) { _code_ExistsSubQuery_Mst制御画面マスタListMap = new LinkedHashMap<String, Mst制御画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_code_ExistsSubQuery_Mst制御画面マスタListMap.size() + 1);
            _code_ExistsSubQuery_Mst制御画面マスタListMap.put(key, subQuery); return "Code_ExistsSubQuery_Mst制御画面マスタList." + key;
        }

        protected Map<String, Mst制御画面マスタCQ> _code_NotExistsSubQuery_Mst制御画面マスタListMap;
        public Map<String, Mst制御画面マスタCQ> Code_NotExistsSubQuery_Mst制御画面マスタList { get { return _code_NotExistsSubQuery_Mst制御画面マスタListMap; }}
        public override String keepCode_NotExistsSubQuery_Mst制御画面マスタList(Mst制御画面マスタCQ subQuery) {
            if (_code_NotExistsSubQuery_Mst制御画面マスタListMap == null) { _code_NotExistsSubQuery_Mst制御画面マスタListMap = new LinkedHashMap<String, Mst制御画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_code_NotExistsSubQuery_Mst制御画面マスタListMap.size() + 1);
            _code_NotExistsSubQuery_Mst制御画面マスタListMap.put(key, subQuery); return "Code_NotExistsSubQuery_Mst制御画面マスタList." + key;
        }

        protected Map<String, Mst制御画面マスタCQ> _code_InScopeSubQuery_Mst制御画面マスタListMap;
        public Map<String, Mst制御画面マスタCQ> Code_InScopeSubQuery_Mst制御画面マスタList { get { return _code_InScopeSubQuery_Mst制御画面マスタListMap; }}
        public override String keepCode_InScopeSubQuery_Mst制御画面マスタList(Mst制御画面マスタCQ subQuery) {
            if (_code_InScopeSubQuery_Mst制御画面マスタListMap == null) { _code_InScopeSubQuery_Mst制御画面マスタListMap = new LinkedHashMap<String, Mst制御画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_code_InScopeSubQuery_Mst制御画面マスタListMap.size() + 1);
            _code_InScopeSubQuery_Mst制御画面マスタListMap.put(key, subQuery); return "Code_InScopeSubQuery_Mst制御画面マスタList." + key;
        }

        protected Map<String, Mst制御画面マスタCQ> _code_NotInScopeSubQuery_Mst制御画面マスタListMap;
        public Map<String, Mst制御画面マスタCQ> Code_NotInScopeSubQuery_Mst制御画面マスタList { get { return _code_NotInScopeSubQuery_Mst制御画面マスタListMap; }}
        public override String keepCode_NotInScopeSubQuery_Mst制御画面マスタList(Mst制御画面マスタCQ subQuery) {
            if (_code_NotInScopeSubQuery_Mst制御画面マスタListMap == null) { _code_NotInScopeSubQuery_Mst制御画面マスタListMap = new LinkedHashMap<String, Mst制御画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_code_NotInScopeSubQuery_Mst制御画面マスタListMap.size() + 1);
            _code_NotInScopeSubQuery_Mst制御画面マスタListMap.put(key, subQuery); return "Code_NotInScopeSubQuery_Mst制御画面マスタList." + key;
        }

        protected Map<String, Mst制御画面マスタCQ> _code_SpecifyDerivedReferrer_Mst制御画面マスタListMap;
        public Map<String, Mst制御画面マスタCQ> Code_SpecifyDerivedReferrer_Mst制御画面マスタList { get { return _code_SpecifyDerivedReferrer_Mst制御画面マスタListMap; }}
        public override String keepCode_SpecifyDerivedReferrer_Mst制御画面マスタList(Mst制御画面マスタCQ subQuery) {
            if (_code_SpecifyDerivedReferrer_Mst制御画面マスタListMap == null) { _code_SpecifyDerivedReferrer_Mst制御画面マスタListMap = new LinkedHashMap<String, Mst制御画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_code_SpecifyDerivedReferrer_Mst制御画面マスタListMap.size() + 1);
           _code_SpecifyDerivedReferrer_Mst制御画面マスタListMap.put(key, subQuery); return "Code_SpecifyDerivedReferrer_Mst制御画面マスタList." + key;
        }

        protected Map<String, Mst制御画面マスタCQ> _code_QueryDerivedReferrer_Mst制御画面マスタListMap;
        public Map<String, Mst制御画面マスタCQ> Code_QueryDerivedReferrer_Mst制御画面マスタList { get { return _code_QueryDerivedReferrer_Mst制御画面マスタListMap; } }
        public override String keepCode_QueryDerivedReferrer_Mst制御画面マスタList(Mst制御画面マスタCQ subQuery) {
            if (_code_QueryDerivedReferrer_Mst制御画面マスタListMap == null) { _code_QueryDerivedReferrer_Mst制御画面マスタListMap = new LinkedHashMap<String, Mst制御画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_code_QueryDerivedReferrer_Mst制御画面マスタListMap.size() + 1);
            _code_QueryDerivedReferrer_Mst制御画面マスタListMap.put(key, subQuery); return "Code_QueryDerivedReferrer_Mst制御画面マスタList." + key;
        }
        protected Map<String, Object> _code_QueryDerivedReferrer_Mst制御画面マスタListParameterMap;
        public Map<String, Object> Code_QueryDerivedReferrer_Mst制御画面マスタListParameter { get { return _code_QueryDerivedReferrer_Mst制御画面マスタListParameterMap; } }
        public override String keepCode_QueryDerivedReferrer_Mst制御画面マスタListParameter(Object parameterValue) {
            if (_code_QueryDerivedReferrer_Mst制御画面マスタListParameterMap == null) { _code_QueryDerivedReferrer_Mst制御画面マスタListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_code_QueryDerivedReferrer_Mst制御画面マスタListParameterMap.size() + 1);
            _code_QueryDerivedReferrer_Mst制御画面マスタListParameterMap.put(key, parameterValue); return "Code_QueryDerivedReferrer_Mst制御画面マスタListParameter." + key;
        }

        public BsKbnメニュー区分CQ AddOrderBy_Code_Asc() { regOBA("code");return this; }
        public BsKbnメニュー区分CQ AddOrderBy_Code_Desc() { regOBD("code");return this; }

        protected ConditionValue _メニュー名;
        public ConditionValue メニュー名 {
            get { if (_メニュー名 == null) { _メニュー名 = new ConditionValue(); } return _メニュー名; }
        }
        protected override ConditionValue getCValueメニュー名() { return this.メニュー名; }


        public BsKbnメニュー区分CQ AddOrderBy_メニュー名_Asc() { regOBA("メニュー名");return this; }
        public BsKbnメニュー区分CQ AddOrderBy_メニュー名_Desc() { regOBD("メニュー名");return this; }

        protected ConditionValue _優先順位;
        public ConditionValue 優先順位 {
            get { if (_優先順位 == null) { _優先順位 = new ConditionValue(); } return _優先順位; }
        }
        protected override ConditionValue getCValue優先順位() { return this.優先順位; }


        public BsKbnメニュー区分CQ AddOrderBy_優先順位_Asc() { regOBA("優先順位");return this; }
        public BsKbnメニュー区分CQ AddOrderBy_優先順位_Desc() { regOBD("優先順位");return this; }

        public BsKbnメニュー区分CQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsKbnメニュー区分CQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Kbnメニュー区分CQ> _scalarSubQueryMap;
	    public Map<String, Kbnメニュー区分CQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Kbnメニュー区分CQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Kbnメニュー区分CQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Kbnメニュー区分CQ> _myselfInScopeSubQueryMap;
        public Map<String, Kbnメニュー区分CQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Kbnメニュー区分CQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Kbnメニュー区分CQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
