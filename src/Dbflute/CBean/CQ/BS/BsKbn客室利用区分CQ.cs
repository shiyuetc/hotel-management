
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


        protected ConditionValue _客室利用コード;
        public ConditionValue 客室利用コード {
            get { if (_客室利用コード == null) { _客室利用コード = new ConditionValue(); } return _客室利用コード; }
        }
        protected override ConditionValue getCValue客室利用コード() { return this.客室利用コード; }


        protected Map<String, Dch客室利用台帳CQ> _客室利用コード_ExistsSubQuery_Dch客室利用台帳ListMap;
        public Map<String, Dch客室利用台帳CQ> 客室利用コード_ExistsSubQuery_Dch客室利用台帳List { get { return _客室利用コード_ExistsSubQuery_Dch客室利用台帳ListMap; }}
        public override String keep客室利用コード_ExistsSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            if (_客室利用コード_ExistsSubQuery_Dch客室利用台帳ListMap == null) { _客室利用コード_ExistsSubQuery_Dch客室利用台帳ListMap = new LinkedHashMap<String, Dch客室利用台帳CQ>(); }
            String key = "subQueryMapKey" + (_客室利用コード_ExistsSubQuery_Dch客室利用台帳ListMap.size() + 1);
            _客室利用コード_ExistsSubQuery_Dch客室利用台帳ListMap.put(key, subQuery); return "客室利用コード_ExistsSubQuery_Dch客室利用台帳List." + key;
        }

        protected Map<String, Dch客室利用台帳CQ> _客室利用コード_NotExistsSubQuery_Dch客室利用台帳ListMap;
        public Map<String, Dch客室利用台帳CQ> 客室利用コード_NotExistsSubQuery_Dch客室利用台帳List { get { return _客室利用コード_NotExistsSubQuery_Dch客室利用台帳ListMap; }}
        public override String keep客室利用コード_NotExistsSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            if (_客室利用コード_NotExistsSubQuery_Dch客室利用台帳ListMap == null) { _客室利用コード_NotExistsSubQuery_Dch客室利用台帳ListMap = new LinkedHashMap<String, Dch客室利用台帳CQ>(); }
            String key = "subQueryMapKey" + (_客室利用コード_NotExistsSubQuery_Dch客室利用台帳ListMap.size() + 1);
            _客室利用コード_NotExistsSubQuery_Dch客室利用台帳ListMap.put(key, subQuery); return "客室利用コード_NotExistsSubQuery_Dch客室利用台帳List." + key;
        }

        protected Map<String, Dch客室利用台帳CQ> _客室利用コード_InScopeSubQuery_Dch客室利用台帳ListMap;
        public Map<String, Dch客室利用台帳CQ> 客室利用コード_InScopeSubQuery_Dch客室利用台帳List { get { return _客室利用コード_InScopeSubQuery_Dch客室利用台帳ListMap; }}
        public override String keep客室利用コード_InScopeSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            if (_客室利用コード_InScopeSubQuery_Dch客室利用台帳ListMap == null) { _客室利用コード_InScopeSubQuery_Dch客室利用台帳ListMap = new LinkedHashMap<String, Dch客室利用台帳CQ>(); }
            String key = "subQueryMapKey" + (_客室利用コード_InScopeSubQuery_Dch客室利用台帳ListMap.size() + 1);
            _客室利用コード_InScopeSubQuery_Dch客室利用台帳ListMap.put(key, subQuery); return "客室利用コード_InScopeSubQuery_Dch客室利用台帳List." + key;
        }

        protected Map<String, Dch客室利用台帳CQ> _客室利用コード_NotInScopeSubQuery_Dch客室利用台帳ListMap;
        public Map<String, Dch客室利用台帳CQ> 客室利用コード_NotInScopeSubQuery_Dch客室利用台帳List { get { return _客室利用コード_NotInScopeSubQuery_Dch客室利用台帳ListMap; }}
        public override String keep客室利用コード_NotInScopeSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            if (_客室利用コード_NotInScopeSubQuery_Dch客室利用台帳ListMap == null) { _客室利用コード_NotInScopeSubQuery_Dch客室利用台帳ListMap = new LinkedHashMap<String, Dch客室利用台帳CQ>(); }
            String key = "subQueryMapKey" + (_客室利用コード_NotInScopeSubQuery_Dch客室利用台帳ListMap.size() + 1);
            _客室利用コード_NotInScopeSubQuery_Dch客室利用台帳ListMap.put(key, subQuery); return "客室利用コード_NotInScopeSubQuery_Dch客室利用台帳List." + key;
        }

        protected Map<String, Dch客室利用台帳CQ> _客室利用コード_SpecifyDerivedReferrer_Dch客室利用台帳ListMap;
        public Map<String, Dch客室利用台帳CQ> 客室利用コード_SpecifyDerivedReferrer_Dch客室利用台帳List { get { return _客室利用コード_SpecifyDerivedReferrer_Dch客室利用台帳ListMap; }}
        public override String keep客室利用コード_SpecifyDerivedReferrer_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            if (_客室利用コード_SpecifyDerivedReferrer_Dch客室利用台帳ListMap == null) { _客室利用コード_SpecifyDerivedReferrer_Dch客室利用台帳ListMap = new LinkedHashMap<String, Dch客室利用台帳CQ>(); }
            String key = "subQueryMapKey" + (_客室利用コード_SpecifyDerivedReferrer_Dch客室利用台帳ListMap.size() + 1);
           _客室利用コード_SpecifyDerivedReferrer_Dch客室利用台帳ListMap.put(key, subQuery); return "客室利用コード_SpecifyDerivedReferrer_Dch客室利用台帳List." + key;
        }

        protected Map<String, Dch客室利用台帳CQ> _客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListMap;
        public Map<String, Dch客室利用台帳CQ> 客室利用コード_QueryDerivedReferrer_Dch客室利用台帳List { get { return _客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListMap; } }
        public override String keep客室利用コード_QueryDerivedReferrer_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            if (_客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListMap == null) { _客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListMap = new LinkedHashMap<String, Dch客室利用台帳CQ>(); }
            String key = "subQueryMapKey" + (_客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListMap.size() + 1);
            _客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListMap.put(key, subQuery); return "客室利用コード_QueryDerivedReferrer_Dch客室利用台帳List." + key;
        }
        protected Map<String, Object> _客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListParameterMap;
        public Map<String, Object> 客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListParameter { get { return _客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListParameterMap; } }
        public override String keep客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListParameter(Object parameterValue) {
            if (_客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListParameterMap == null) { _客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListParameterMap.size() + 1);
            _客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListParameterMap.put(key, parameterValue); return "客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListParameter." + key;
        }

        public BsKbn客室利用区分CQ AddOrderBy_客室利用コード_Asc() { regOBA("客室利用コード");return this; }
        public BsKbn客室利用区分CQ AddOrderBy_客室利用コード_Desc() { regOBD("客室利用コード");return this; }

        protected ConditionValue _客室利用名称;
        public ConditionValue 客室利用名称 {
            get { if (_客室利用名称 == null) { _客室利用名称 = new ConditionValue(); } return _客室利用名称; }
        }
        protected override ConditionValue getCValue客室利用名称() { return this.客室利用名称; }


        public BsKbn客室利用区分CQ AddOrderBy_客室利用名称_Asc() { regOBA("客室利用名称");return this; }
        public BsKbn客室利用区分CQ AddOrderBy_客室利用名称_Desc() { regOBD("客室利用名称");return this; }

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
