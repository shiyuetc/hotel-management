
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMst画面マスタCQ : AbstractBsMst画面マスタCQ {

        protected Mst画面マスタCIQ _inlineQuery;

        public BsMst画面マスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Mst画面マスタCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Mst画面マスタCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Mst画面マスタCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Mst画面マスタCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _画面コード;
        public ConditionValue 画面コード {
            get { if (_画面コード == null) { _画面コード = new ConditionValue(); } return _画面コード; }
        }
        protected override ConditionValue getCValue画面コード() { return this.画面コード; }


        protected Map<String, Mst権限マスタCQ> _画面コード_ExistsSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> 画面コード_ExistsSubQuery_Mst権限マスタList { get { return _画面コード_ExistsSubQuery_Mst権限マスタListMap; }}
        public override String keep画面コード_ExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_画面コード_ExistsSubQuery_Mst権限マスタListMap == null) { _画面コード_ExistsSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_画面コード_ExistsSubQuery_Mst権限マスタListMap.size() + 1);
            _画面コード_ExistsSubQuery_Mst権限マスタListMap.put(key, subQuery); return "画面コード_ExistsSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _画面コード_NotExistsSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> 画面コード_NotExistsSubQuery_Mst権限マスタList { get { return _画面コード_NotExistsSubQuery_Mst権限マスタListMap; }}
        public override String keep画面コード_NotExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_画面コード_NotExistsSubQuery_Mst権限マスタListMap == null) { _画面コード_NotExistsSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_画面コード_NotExistsSubQuery_Mst権限マスタListMap.size() + 1);
            _画面コード_NotExistsSubQuery_Mst権限マスタListMap.put(key, subQuery); return "画面コード_NotExistsSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _画面コード_InScopeSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> 画面コード_InScopeSubQuery_Mst権限マスタList { get { return _画面コード_InScopeSubQuery_Mst権限マスタListMap; }}
        public override String keep画面コード_InScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_画面コード_InScopeSubQuery_Mst権限マスタListMap == null) { _画面コード_InScopeSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_画面コード_InScopeSubQuery_Mst権限マスタListMap.size() + 1);
            _画面コード_InScopeSubQuery_Mst権限マスタListMap.put(key, subQuery); return "画面コード_InScopeSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _画面コード_NotInScopeSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> 画面コード_NotInScopeSubQuery_Mst権限マスタList { get { return _画面コード_NotInScopeSubQuery_Mst権限マスタListMap; }}
        public override String keep画面コード_NotInScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_画面コード_NotInScopeSubQuery_Mst権限マスタListMap == null) { _画面コード_NotInScopeSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_画面コード_NotInScopeSubQuery_Mst権限マスタListMap.size() + 1);
            _画面コード_NotInScopeSubQuery_Mst権限マスタListMap.put(key, subQuery); return "画面コード_NotInScopeSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _画面コード_SpecifyDerivedReferrer_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> 画面コード_SpecifyDerivedReferrer_Mst権限マスタList { get { return _画面コード_SpecifyDerivedReferrer_Mst権限マスタListMap; }}
        public override String keep画面コード_SpecifyDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_画面コード_SpecifyDerivedReferrer_Mst権限マスタListMap == null) { _画面コード_SpecifyDerivedReferrer_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_画面コード_SpecifyDerivedReferrer_Mst権限マスタListMap.size() + 1);
           _画面コード_SpecifyDerivedReferrer_Mst権限マスタListMap.put(key, subQuery); return "画面コード_SpecifyDerivedReferrer_Mst権限マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _画面コード_QueryDerivedReferrer_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> 画面コード_QueryDerivedReferrer_Mst権限マスタList { get { return _画面コード_QueryDerivedReferrer_Mst権限マスタListMap; } }
        public override String keep画面コード_QueryDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_画面コード_QueryDerivedReferrer_Mst権限マスタListMap == null) { _画面コード_QueryDerivedReferrer_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_画面コード_QueryDerivedReferrer_Mst権限マスタListMap.size() + 1);
            _画面コード_QueryDerivedReferrer_Mst権限マスタListMap.put(key, subQuery); return "画面コード_QueryDerivedReferrer_Mst権限マスタList." + key;
        }
        protected Map<String, Object> _画面コード_QueryDerivedReferrer_Mst権限マスタListParameterMap;
        public Map<String, Object> 画面コード_QueryDerivedReferrer_Mst権限マスタListParameter { get { return _画面コード_QueryDerivedReferrer_Mst権限マスタListParameterMap; } }
        public override String keep画面コード_QueryDerivedReferrer_Mst権限マスタListParameter(Object parameterValue) {
            if (_画面コード_QueryDerivedReferrer_Mst権限マスタListParameterMap == null) { _画面コード_QueryDerivedReferrer_Mst権限マスタListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_画面コード_QueryDerivedReferrer_Mst権限マスタListParameterMap.size() + 1);
            _画面コード_QueryDerivedReferrer_Mst権限マスタListParameterMap.put(key, parameterValue); return "画面コード_QueryDerivedReferrer_Mst権限マスタListParameter." + key;
        }

        public BsMst画面マスタCQ AddOrderBy_画面コード_Asc() { regOBA("画面コード");return this; }
        public BsMst画面マスタCQ AddOrderBy_画面コード_Desc() { regOBD("画面コード");return this; }

        protected ConditionValue _メニューコード;
        public ConditionValue メニューコード {
            get { if (_メニューコード == null) { _メニューコード = new ConditionValue(); } return _メニューコード; }
        }
        protected override ConditionValue getCValueメニューコード() { return this.メニューコード; }


        protected Map<String, Kbnメニュー区分CQ> _メニューコード_InScopeSubQuery_Kbnメニュー区分Map;
        public Map<String, Kbnメニュー区分CQ> メニューコード_InScopeSubQuery_Kbnメニュー区分 { get { return _メニューコード_InScopeSubQuery_Kbnメニュー区分Map; }}
        public override String keepメニューコード_InScopeSubQuery_Kbnメニュー区分(Kbnメニュー区分CQ subQuery) {
            if (_メニューコード_InScopeSubQuery_Kbnメニュー区分Map == null) { _メニューコード_InScopeSubQuery_Kbnメニュー区分Map = new LinkedHashMap<String, Kbnメニュー区分CQ>(); }
            String key = "subQueryMapKey" + (_メニューコード_InScopeSubQuery_Kbnメニュー区分Map.size() + 1);
            _メニューコード_InScopeSubQuery_Kbnメニュー区分Map.put(key, subQuery); return "メニューコード_InScopeSubQuery_Kbnメニュー区分." + key;
        }

        protected Map<String, Kbnメニュー区分CQ> _メニューコード_NotInScopeSubQuery_Kbnメニュー区分Map;
        public Map<String, Kbnメニュー区分CQ> メニューコード_NotInScopeSubQuery_Kbnメニュー区分 { get { return _メニューコード_NotInScopeSubQuery_Kbnメニュー区分Map; }}
        public override String keepメニューコード_NotInScopeSubQuery_Kbnメニュー区分(Kbnメニュー区分CQ subQuery) {
            if (_メニューコード_NotInScopeSubQuery_Kbnメニュー区分Map == null) { _メニューコード_NotInScopeSubQuery_Kbnメニュー区分Map = new LinkedHashMap<String, Kbnメニュー区分CQ>(); }
            String key = "subQueryMapKey" + (_メニューコード_NotInScopeSubQuery_Kbnメニュー区分Map.size() + 1);
            _メニューコード_NotInScopeSubQuery_Kbnメニュー区分Map.put(key, subQuery); return "メニューコード_NotInScopeSubQuery_Kbnメニュー区分." + key;
        }

        public BsMst画面マスタCQ AddOrderBy_メニューコード_Asc() { regOBA("メニューコード");return this; }
        public BsMst画面マスタCQ AddOrderBy_メニューコード_Desc() { regOBD("メニューコード");return this; }

        protected ConditionValue _画面名称;
        public ConditionValue 画面名称 {
            get { if (_画面名称 == null) { _画面名称 = new ConditionValue(); } return _画面名称; }
        }
        protected override ConditionValue getCValue画面名称() { return this.画面名称; }


        public BsMst画面マスタCQ AddOrderBy_画面名称_Asc() { regOBA("画面名称");return this; }
        public BsMst画面マスタCQ AddOrderBy_画面名称_Desc() { regOBD("画面名称");return this; }

        protected ConditionValue _優先順位;
        public ConditionValue 優先順位 {
            get { if (_優先順位 == null) { _優先順位 = new ConditionValue(); } return _優先順位; }
        }
        protected override ConditionValue getCValue優先順位() { return this.優先順位; }


        public BsMst画面マスタCQ AddOrderBy_優先順位_Asc() { regOBA("優先順位");return this; }
        public BsMst画面マスタCQ AddOrderBy_優先順位_Desc() { regOBD("優先順位");return this; }

        public BsMst画面マスタCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMst画面マスタCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            Mst画面マスタCQ baseQuery = (Mst画面マスタCQ)baseQueryAsSuper;
            Mst画面マスタCQ unionQuery = (Mst画面マスタCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryKbnメニュー区分()) {
                unionQuery.QueryKbnメニュー区分().reflectRelationOnUnionQuery(baseQuery.QueryKbnメニュー区分(), unionQuery.QueryKbnメニュー区分());
            }

        }
    
        protected Kbnメニュー区分CQ _conditionQueryKbnメニュー区分;
        public Kbnメニュー区分CQ QueryKbnメニュー区分() {
            return this.ConditionQueryKbnメニュー区分;
        }
        public Kbnメニュー区分CQ ConditionQueryKbnメニュー区分 {
            get {
                if (_conditionQueryKbnメニュー区分 == null) {
                    _conditionQueryKbnメニュー区分 = xcreateQueryKbnメニュー区分();
                    xsetupOuterJoin_Kbnメニュー区分();
                }
                return _conditionQueryKbnメニュー区分;
            }
        }
        protected Kbnメニュー区分CQ xcreateQueryKbnメニュー区分() {
            String nrp = resolveNextRelationPathKbnメニュー区分();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Kbnメニュー区分CQ cq = new Kbnメニュー区分CQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("kbnメニュー区分"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Kbnメニュー区分() {
            Kbnメニュー区分CQ cq = ConditionQueryKbnメニュー区分;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("メニューコード", "メニューコード");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathKbnメニュー区分() {
            return resolveNextRelationPath("mst画面マスタ", "kbnメニュー区分");
        }
        public bool hasConditionQueryKbnメニュー区分() {
            return _conditionQueryKbnメニュー区分 != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Mst画面マスタCQ> _scalarSubQueryMap;
	    public Map<String, Mst画面マスタCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Mst画面マスタCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Mst画面マスタCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Mst画面マスタCQ> _myselfInScopeSubQueryMap;
        public Map<String, Mst画面マスタCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Mst画面マスタCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Mst画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
