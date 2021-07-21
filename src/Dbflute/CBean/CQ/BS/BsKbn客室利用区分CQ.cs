
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsKbn客室利用区分CQ : AbstractBsKbn客室利用区分CQ {

        protected Kbn客室利用区分CIQ _inlineQuery;

        public BsKbn客室利用区分CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Kbn客室利用区分CIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Kbn客室利用区分CIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Kbn客室利用区分CIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Kbn客室利用区分CIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _code;
        public ConditionValue Code {
            get { if (_code == null) { _code = new ConditionValue(); } return _code; }
        }
        protected override ConditionValue getCValueCode() { return this.Code; }


        protected Map<String, Dch客室利用予定台帳CQ> _code_ExistsSubQuery_Dch客室利用予定台帳ListMap;
        public Map<String, Dch客室利用予定台帳CQ> Code_ExistsSubQuery_Dch客室利用予定台帳List { get { return _code_ExistsSubQuery_Dch客室利用予定台帳ListMap; }}
        public override String keepCode_ExistsSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery) {
            if (_code_ExistsSubQuery_Dch客室利用予定台帳ListMap == null) { _code_ExistsSubQuery_Dch客室利用予定台帳ListMap = new LinkedHashMap<String, Dch客室利用予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_code_ExistsSubQuery_Dch客室利用予定台帳ListMap.size() + 1);
            _code_ExistsSubQuery_Dch客室利用予定台帳ListMap.put(key, subQuery); return "Code_ExistsSubQuery_Dch客室利用予定台帳List." + key;
        }

        protected Map<String, Dch客室利用実績台帳CQ> _code_ExistsSubQuery_Dch客室利用実績台帳ListMap;
        public Map<String, Dch客室利用実績台帳CQ> Code_ExistsSubQuery_Dch客室利用実績台帳List { get { return _code_ExistsSubQuery_Dch客室利用実績台帳ListMap; }}
        public override String keepCode_ExistsSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery) {
            if (_code_ExistsSubQuery_Dch客室利用実績台帳ListMap == null) { _code_ExistsSubQuery_Dch客室利用実績台帳ListMap = new LinkedHashMap<String, Dch客室利用実績台帳CQ>(); }
            String key = "subQueryMapKey" + (_code_ExistsSubQuery_Dch客室利用実績台帳ListMap.size() + 1);
            _code_ExistsSubQuery_Dch客室利用実績台帳ListMap.put(key, subQuery); return "Code_ExistsSubQuery_Dch客室利用実績台帳List." + key;
        }

        protected Map<String, Dch客室利用予定台帳CQ> _code_NotExistsSubQuery_Dch客室利用予定台帳ListMap;
        public Map<String, Dch客室利用予定台帳CQ> Code_NotExistsSubQuery_Dch客室利用予定台帳List { get { return _code_NotExistsSubQuery_Dch客室利用予定台帳ListMap; }}
        public override String keepCode_NotExistsSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery) {
            if (_code_NotExistsSubQuery_Dch客室利用予定台帳ListMap == null) { _code_NotExistsSubQuery_Dch客室利用予定台帳ListMap = new LinkedHashMap<String, Dch客室利用予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_code_NotExistsSubQuery_Dch客室利用予定台帳ListMap.size() + 1);
            _code_NotExistsSubQuery_Dch客室利用予定台帳ListMap.put(key, subQuery); return "Code_NotExistsSubQuery_Dch客室利用予定台帳List." + key;
        }

        protected Map<String, Dch客室利用実績台帳CQ> _code_NotExistsSubQuery_Dch客室利用実績台帳ListMap;
        public Map<String, Dch客室利用実績台帳CQ> Code_NotExistsSubQuery_Dch客室利用実績台帳List { get { return _code_NotExistsSubQuery_Dch客室利用実績台帳ListMap; }}
        public override String keepCode_NotExistsSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery) {
            if (_code_NotExistsSubQuery_Dch客室利用実績台帳ListMap == null) { _code_NotExistsSubQuery_Dch客室利用実績台帳ListMap = new LinkedHashMap<String, Dch客室利用実績台帳CQ>(); }
            String key = "subQueryMapKey" + (_code_NotExistsSubQuery_Dch客室利用実績台帳ListMap.size() + 1);
            _code_NotExistsSubQuery_Dch客室利用実績台帳ListMap.put(key, subQuery); return "Code_NotExistsSubQuery_Dch客室利用実績台帳List." + key;
        }

        protected Map<String, Dch客室利用予定台帳CQ> _code_InScopeSubQuery_Dch客室利用予定台帳ListMap;
        public Map<String, Dch客室利用予定台帳CQ> Code_InScopeSubQuery_Dch客室利用予定台帳List { get { return _code_InScopeSubQuery_Dch客室利用予定台帳ListMap; }}
        public override String keepCode_InScopeSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery) {
            if (_code_InScopeSubQuery_Dch客室利用予定台帳ListMap == null) { _code_InScopeSubQuery_Dch客室利用予定台帳ListMap = new LinkedHashMap<String, Dch客室利用予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_code_InScopeSubQuery_Dch客室利用予定台帳ListMap.size() + 1);
            _code_InScopeSubQuery_Dch客室利用予定台帳ListMap.put(key, subQuery); return "Code_InScopeSubQuery_Dch客室利用予定台帳List." + key;
        }

        protected Map<String, Dch客室利用実績台帳CQ> _code_InScopeSubQuery_Dch客室利用実績台帳ListMap;
        public Map<String, Dch客室利用実績台帳CQ> Code_InScopeSubQuery_Dch客室利用実績台帳List { get { return _code_InScopeSubQuery_Dch客室利用実績台帳ListMap; }}
        public override String keepCode_InScopeSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery) {
            if (_code_InScopeSubQuery_Dch客室利用実績台帳ListMap == null) { _code_InScopeSubQuery_Dch客室利用実績台帳ListMap = new LinkedHashMap<String, Dch客室利用実績台帳CQ>(); }
            String key = "subQueryMapKey" + (_code_InScopeSubQuery_Dch客室利用実績台帳ListMap.size() + 1);
            _code_InScopeSubQuery_Dch客室利用実績台帳ListMap.put(key, subQuery); return "Code_InScopeSubQuery_Dch客室利用実績台帳List." + key;
        }

        protected Map<String, Dch客室利用予定台帳CQ> _code_NotInScopeSubQuery_Dch客室利用予定台帳ListMap;
        public Map<String, Dch客室利用予定台帳CQ> Code_NotInScopeSubQuery_Dch客室利用予定台帳List { get { return _code_NotInScopeSubQuery_Dch客室利用予定台帳ListMap; }}
        public override String keepCode_NotInScopeSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery) {
            if (_code_NotInScopeSubQuery_Dch客室利用予定台帳ListMap == null) { _code_NotInScopeSubQuery_Dch客室利用予定台帳ListMap = new LinkedHashMap<String, Dch客室利用予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_code_NotInScopeSubQuery_Dch客室利用予定台帳ListMap.size() + 1);
            _code_NotInScopeSubQuery_Dch客室利用予定台帳ListMap.put(key, subQuery); return "Code_NotInScopeSubQuery_Dch客室利用予定台帳List." + key;
        }

        protected Map<String, Dch客室利用実績台帳CQ> _code_NotInScopeSubQuery_Dch客室利用実績台帳ListMap;
        public Map<String, Dch客室利用実績台帳CQ> Code_NotInScopeSubQuery_Dch客室利用実績台帳List { get { return _code_NotInScopeSubQuery_Dch客室利用実績台帳ListMap; }}
        public override String keepCode_NotInScopeSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery) {
            if (_code_NotInScopeSubQuery_Dch客室利用実績台帳ListMap == null) { _code_NotInScopeSubQuery_Dch客室利用実績台帳ListMap = new LinkedHashMap<String, Dch客室利用実績台帳CQ>(); }
            String key = "subQueryMapKey" + (_code_NotInScopeSubQuery_Dch客室利用実績台帳ListMap.size() + 1);
            _code_NotInScopeSubQuery_Dch客室利用実績台帳ListMap.put(key, subQuery); return "Code_NotInScopeSubQuery_Dch客室利用実績台帳List." + key;
        }

        protected Map<String, Dch客室利用予定台帳CQ> _code_SpecifyDerivedReferrer_Dch客室利用予定台帳ListMap;
        public Map<String, Dch客室利用予定台帳CQ> Code_SpecifyDerivedReferrer_Dch客室利用予定台帳List { get { return _code_SpecifyDerivedReferrer_Dch客室利用予定台帳ListMap; }}
        public override String keepCode_SpecifyDerivedReferrer_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery) {
            if (_code_SpecifyDerivedReferrer_Dch客室利用予定台帳ListMap == null) { _code_SpecifyDerivedReferrer_Dch客室利用予定台帳ListMap = new LinkedHashMap<String, Dch客室利用予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_code_SpecifyDerivedReferrer_Dch客室利用予定台帳ListMap.size() + 1);
           _code_SpecifyDerivedReferrer_Dch客室利用予定台帳ListMap.put(key, subQuery); return "Code_SpecifyDerivedReferrer_Dch客室利用予定台帳List." + key;
        }

        protected Map<String, Dch客室利用実績台帳CQ> _code_SpecifyDerivedReferrer_Dch客室利用実績台帳ListMap;
        public Map<String, Dch客室利用実績台帳CQ> Code_SpecifyDerivedReferrer_Dch客室利用実績台帳List { get { return _code_SpecifyDerivedReferrer_Dch客室利用実績台帳ListMap; }}
        public override String keepCode_SpecifyDerivedReferrer_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery) {
            if (_code_SpecifyDerivedReferrer_Dch客室利用実績台帳ListMap == null) { _code_SpecifyDerivedReferrer_Dch客室利用実績台帳ListMap = new LinkedHashMap<String, Dch客室利用実績台帳CQ>(); }
            String key = "subQueryMapKey" + (_code_SpecifyDerivedReferrer_Dch客室利用実績台帳ListMap.size() + 1);
           _code_SpecifyDerivedReferrer_Dch客室利用実績台帳ListMap.put(key, subQuery); return "Code_SpecifyDerivedReferrer_Dch客室利用実績台帳List." + key;
        }

        protected Map<String, Dch客室利用予定台帳CQ> _code_QueryDerivedReferrer_Dch客室利用予定台帳ListMap;
        public Map<String, Dch客室利用予定台帳CQ> Code_QueryDerivedReferrer_Dch客室利用予定台帳List { get { return _code_QueryDerivedReferrer_Dch客室利用予定台帳ListMap; } }
        public override String keepCode_QueryDerivedReferrer_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery) {
            if (_code_QueryDerivedReferrer_Dch客室利用予定台帳ListMap == null) { _code_QueryDerivedReferrer_Dch客室利用予定台帳ListMap = new LinkedHashMap<String, Dch客室利用予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_code_QueryDerivedReferrer_Dch客室利用予定台帳ListMap.size() + 1);
            _code_QueryDerivedReferrer_Dch客室利用予定台帳ListMap.put(key, subQuery); return "Code_QueryDerivedReferrer_Dch客室利用予定台帳List." + key;
        }
        protected Map<String, Object> _code_QueryDerivedReferrer_Dch客室利用予定台帳ListParameterMap;
        public Map<String, Object> Code_QueryDerivedReferrer_Dch客室利用予定台帳ListParameter { get { return _code_QueryDerivedReferrer_Dch客室利用予定台帳ListParameterMap; } }
        public override String keepCode_QueryDerivedReferrer_Dch客室利用予定台帳ListParameter(Object parameterValue) {
            if (_code_QueryDerivedReferrer_Dch客室利用予定台帳ListParameterMap == null) { _code_QueryDerivedReferrer_Dch客室利用予定台帳ListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_code_QueryDerivedReferrer_Dch客室利用予定台帳ListParameterMap.size() + 1);
            _code_QueryDerivedReferrer_Dch客室利用予定台帳ListParameterMap.put(key, parameterValue); return "Code_QueryDerivedReferrer_Dch客室利用予定台帳ListParameter." + key;
        }

        protected Map<String, Dch客室利用実績台帳CQ> _code_QueryDerivedReferrer_Dch客室利用実績台帳ListMap;
        public Map<String, Dch客室利用実績台帳CQ> Code_QueryDerivedReferrer_Dch客室利用実績台帳List { get { return _code_QueryDerivedReferrer_Dch客室利用実績台帳ListMap; } }
        public override String keepCode_QueryDerivedReferrer_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery) {
            if (_code_QueryDerivedReferrer_Dch客室利用実績台帳ListMap == null) { _code_QueryDerivedReferrer_Dch客室利用実績台帳ListMap = new LinkedHashMap<String, Dch客室利用実績台帳CQ>(); }
            String key = "subQueryMapKey" + (_code_QueryDerivedReferrer_Dch客室利用実績台帳ListMap.size() + 1);
            _code_QueryDerivedReferrer_Dch客室利用実績台帳ListMap.put(key, subQuery); return "Code_QueryDerivedReferrer_Dch客室利用実績台帳List." + key;
        }
        protected Map<String, Object> _code_QueryDerivedReferrer_Dch客室利用実績台帳ListParameterMap;
        public Map<String, Object> Code_QueryDerivedReferrer_Dch客室利用実績台帳ListParameter { get { return _code_QueryDerivedReferrer_Dch客室利用実績台帳ListParameterMap; } }
        public override String keepCode_QueryDerivedReferrer_Dch客室利用実績台帳ListParameter(Object parameterValue) {
            if (_code_QueryDerivedReferrer_Dch客室利用実績台帳ListParameterMap == null) { _code_QueryDerivedReferrer_Dch客室利用実績台帳ListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_code_QueryDerivedReferrer_Dch客室利用実績台帳ListParameterMap.size() + 1);
            _code_QueryDerivedReferrer_Dch客室利用実績台帳ListParameterMap.put(key, parameterValue); return "Code_QueryDerivedReferrer_Dch客室利用実績台帳ListParameter." + key;
        }

        public BsKbn客室利用区分CQ AddOrderBy_Code_Asc() { regOBA("code");return this; }
        public BsKbn客室利用区分CQ AddOrderBy_Code_Desc() { regOBD("code");return this; }

        protected ConditionValue _名称;
        public ConditionValue 名称 {
            get { if (_名称 == null) { _名称 = new ConditionValue(); } return _名称; }
        }
        protected override ConditionValue getCValue名称() { return this.名称; }


        public BsKbn客室利用区分CQ AddOrderBy_名称_Asc() { regOBA("名称");return this; }
        public BsKbn客室利用区分CQ AddOrderBy_名称_Desc() { regOBD("名称");return this; }

        public BsKbn客室利用区分CQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsKbn客室利用区分CQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Kbn客室利用区分CQ> _scalarSubQueryMap;
	    public Map<String, Kbn客室利用区分CQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Kbn客室利用区分CQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Kbn客室利用区分CQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Kbn客室利用区分CQ> _myselfInScopeSubQueryMap;
        public Map<String, Kbn客室利用区分CQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Kbn客室利用区分CQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Kbn客室利用区分CQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
