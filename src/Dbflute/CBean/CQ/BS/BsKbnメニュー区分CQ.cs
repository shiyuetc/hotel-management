
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


        protected ConditionValue _メニューコード;
        public ConditionValue メニューコード {
            get { if (_メニューコード == null) { _メニューコード = new ConditionValue(); } return _メニューコード; }
        }
        protected override ConditionValue getCValueメニューコード() { return this.メニューコード; }


        protected Map<String, Mst画面マスタCQ> _メニューコード_ExistsSubQuery_Mst画面マスタListMap;
        public Map<String, Mst画面マスタCQ> メニューコード_ExistsSubQuery_Mst画面マスタList { get { return _メニューコード_ExistsSubQuery_Mst画面マスタListMap; }}
        public override String keepメニューコード_ExistsSubQuery_Mst画面マスタList(Mst画面マスタCQ subQuery) {
            if (_メニューコード_ExistsSubQuery_Mst画面マスタListMap == null) { _メニューコード_ExistsSubQuery_Mst画面マスタListMap = new LinkedHashMap<String, Mst画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_メニューコード_ExistsSubQuery_Mst画面マスタListMap.size() + 1);
            _メニューコード_ExistsSubQuery_Mst画面マスタListMap.put(key, subQuery); return "メニューコード_ExistsSubQuery_Mst画面マスタList." + key;
        }

        protected Map<String, Mst画面マスタCQ> _メニューコード_NotExistsSubQuery_Mst画面マスタListMap;
        public Map<String, Mst画面マスタCQ> メニューコード_NotExistsSubQuery_Mst画面マスタList { get { return _メニューコード_NotExistsSubQuery_Mst画面マスタListMap; }}
        public override String keepメニューコード_NotExistsSubQuery_Mst画面マスタList(Mst画面マスタCQ subQuery) {
            if (_メニューコード_NotExistsSubQuery_Mst画面マスタListMap == null) { _メニューコード_NotExistsSubQuery_Mst画面マスタListMap = new LinkedHashMap<String, Mst画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_メニューコード_NotExistsSubQuery_Mst画面マスタListMap.size() + 1);
            _メニューコード_NotExistsSubQuery_Mst画面マスタListMap.put(key, subQuery); return "メニューコード_NotExistsSubQuery_Mst画面マスタList." + key;
        }

        protected Map<String, Mst画面マスタCQ> _メニューコード_InScopeSubQuery_Mst画面マスタListMap;
        public Map<String, Mst画面マスタCQ> メニューコード_InScopeSubQuery_Mst画面マスタList { get { return _メニューコード_InScopeSubQuery_Mst画面マスタListMap; }}
        public override String keepメニューコード_InScopeSubQuery_Mst画面マスタList(Mst画面マスタCQ subQuery) {
            if (_メニューコード_InScopeSubQuery_Mst画面マスタListMap == null) { _メニューコード_InScopeSubQuery_Mst画面マスタListMap = new LinkedHashMap<String, Mst画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_メニューコード_InScopeSubQuery_Mst画面マスタListMap.size() + 1);
            _メニューコード_InScopeSubQuery_Mst画面マスタListMap.put(key, subQuery); return "メニューコード_InScopeSubQuery_Mst画面マスタList." + key;
        }

        protected Map<String, Mst画面マスタCQ> _メニューコード_NotInScopeSubQuery_Mst画面マスタListMap;
        public Map<String, Mst画面マスタCQ> メニューコード_NotInScopeSubQuery_Mst画面マスタList { get { return _メニューコード_NotInScopeSubQuery_Mst画面マスタListMap; }}
        public override String keepメニューコード_NotInScopeSubQuery_Mst画面マスタList(Mst画面マスタCQ subQuery) {
            if (_メニューコード_NotInScopeSubQuery_Mst画面マスタListMap == null) { _メニューコード_NotInScopeSubQuery_Mst画面マスタListMap = new LinkedHashMap<String, Mst画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_メニューコード_NotInScopeSubQuery_Mst画面マスタListMap.size() + 1);
            _メニューコード_NotInScopeSubQuery_Mst画面マスタListMap.put(key, subQuery); return "メニューコード_NotInScopeSubQuery_Mst画面マスタList." + key;
        }

        protected Map<String, Mst画面マスタCQ> _メニューコード_SpecifyDerivedReferrer_Mst画面マスタListMap;
        public Map<String, Mst画面マスタCQ> メニューコード_SpecifyDerivedReferrer_Mst画面マスタList { get { return _メニューコード_SpecifyDerivedReferrer_Mst画面マスタListMap; }}
        public override String keepメニューコード_SpecifyDerivedReferrer_Mst画面マスタList(Mst画面マスタCQ subQuery) {
            if (_メニューコード_SpecifyDerivedReferrer_Mst画面マスタListMap == null) { _メニューコード_SpecifyDerivedReferrer_Mst画面マスタListMap = new LinkedHashMap<String, Mst画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_メニューコード_SpecifyDerivedReferrer_Mst画面マスタListMap.size() + 1);
           _メニューコード_SpecifyDerivedReferrer_Mst画面マスタListMap.put(key, subQuery); return "メニューコード_SpecifyDerivedReferrer_Mst画面マスタList." + key;
        }

        protected Map<String, Mst画面マスタCQ> _メニューコード_QueryDerivedReferrer_Mst画面マスタListMap;
        public Map<String, Mst画面マスタCQ> メニューコード_QueryDerivedReferrer_Mst画面マスタList { get { return _メニューコード_QueryDerivedReferrer_Mst画面マスタListMap; } }
        public override String keepメニューコード_QueryDerivedReferrer_Mst画面マスタList(Mst画面マスタCQ subQuery) {
            if (_メニューコード_QueryDerivedReferrer_Mst画面マスタListMap == null) { _メニューコード_QueryDerivedReferrer_Mst画面マスタListMap = new LinkedHashMap<String, Mst画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_メニューコード_QueryDerivedReferrer_Mst画面マスタListMap.size() + 1);
            _メニューコード_QueryDerivedReferrer_Mst画面マスタListMap.put(key, subQuery); return "メニューコード_QueryDerivedReferrer_Mst画面マスタList." + key;
        }
        protected Map<String, Object> _メニューコード_QueryDerivedReferrer_Mst画面マスタListParameterMap;
        public Map<String, Object> メニューコード_QueryDerivedReferrer_Mst画面マスタListParameter { get { return _メニューコード_QueryDerivedReferrer_Mst画面マスタListParameterMap; } }
        public override String keepメニューコード_QueryDerivedReferrer_Mst画面マスタListParameter(Object parameterValue) {
            if (_メニューコード_QueryDerivedReferrer_Mst画面マスタListParameterMap == null) { _メニューコード_QueryDerivedReferrer_Mst画面マスタListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_メニューコード_QueryDerivedReferrer_Mst画面マスタListParameterMap.size() + 1);
            _メニューコード_QueryDerivedReferrer_Mst画面マスタListParameterMap.put(key, parameterValue); return "メニューコード_QueryDerivedReferrer_Mst画面マスタListParameter." + key;
        }

        public BsKbnメニュー区分CQ AddOrderBy_メニューコード_Asc() { regOBA("メニューコード");return this; }
        public BsKbnメニュー区分CQ AddOrderBy_メニューコード_Desc() { regOBD("メニューコード");return this; }

        protected ConditionValue _メニュー名称;
        public ConditionValue メニュー名称 {
            get { if (_メニュー名称 == null) { _メニュー名称 = new ConditionValue(); } return _メニュー名称; }
        }
        protected override ConditionValue getCValueメニュー名称() { return this.メニュー名称; }


        public BsKbnメニュー区分CQ AddOrderBy_メニュー名称_Asc() { regOBA("メニュー名称");return this; }
        public BsKbnメニュー区分CQ AddOrderBy_メニュー名称_Desc() { regOBD("メニュー名称");return this; }

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
