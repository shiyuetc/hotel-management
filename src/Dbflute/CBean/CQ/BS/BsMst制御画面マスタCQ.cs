
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMst制御画面マスタCQ : AbstractBsMst制御画面マスタCQ {

        protected Mst制御画面マスタCIQ _inlineQuery;

        public BsMst制御画面マスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Mst制御画面マスタCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Mst制御画面マスタCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Mst制御画面マスタCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Mst制御画面マスタCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        protected Map<String, Mstメニュー権限マスタCQ> _id_ExistsSubQuery_Mstメニュー権限マスタListMap;
        public Map<String, Mstメニュー権限マスタCQ> Id_ExistsSubQuery_Mstメニュー権限マスタList { get { return _id_ExistsSubQuery_Mstメニュー権限マスタListMap; }}
        public override String keepId_ExistsSubQuery_Mstメニュー権限マスタList(Mstメニュー権限マスタCQ subQuery) {
            if (_id_ExistsSubQuery_Mstメニュー権限マスタListMap == null) { _id_ExistsSubQuery_Mstメニュー権限マスタListMap = new LinkedHashMap<String, Mstメニュー権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_ExistsSubQuery_Mstメニュー権限マスタListMap.size() + 1);
            _id_ExistsSubQuery_Mstメニュー権限マスタListMap.put(key, subQuery); return "Id_ExistsSubQuery_Mstメニュー権限マスタList." + key;
        }

        protected Map<String, Mstメニュー権限マスタCQ> _id_NotExistsSubQuery_Mstメニュー権限マスタListMap;
        public Map<String, Mstメニュー権限マスタCQ> Id_NotExistsSubQuery_Mstメニュー権限マスタList { get { return _id_NotExistsSubQuery_Mstメニュー権限マスタListMap; }}
        public override String keepId_NotExistsSubQuery_Mstメニュー権限マスタList(Mstメニュー権限マスタCQ subQuery) {
            if (_id_NotExistsSubQuery_Mstメニュー権限マスタListMap == null) { _id_NotExistsSubQuery_Mstメニュー権限マスタListMap = new LinkedHashMap<String, Mstメニュー権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_NotExistsSubQuery_Mstメニュー権限マスタListMap.size() + 1);
            _id_NotExistsSubQuery_Mstメニュー権限マスタListMap.put(key, subQuery); return "Id_NotExistsSubQuery_Mstメニュー権限マスタList." + key;
        }

        protected Map<String, Mstメニュー権限マスタCQ> _id_InScopeSubQuery_Mstメニュー権限マスタListMap;
        public Map<String, Mstメニュー権限マスタCQ> Id_InScopeSubQuery_Mstメニュー権限マスタList { get { return _id_InScopeSubQuery_Mstメニュー権限マスタListMap; }}
        public override String keepId_InScopeSubQuery_Mstメニュー権限マスタList(Mstメニュー権限マスタCQ subQuery) {
            if (_id_InScopeSubQuery_Mstメニュー権限マスタListMap == null) { _id_InScopeSubQuery_Mstメニュー権限マスタListMap = new LinkedHashMap<String, Mstメニュー権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_InScopeSubQuery_Mstメニュー権限マスタListMap.size() + 1);
            _id_InScopeSubQuery_Mstメニュー権限マスタListMap.put(key, subQuery); return "Id_InScopeSubQuery_Mstメニュー権限マスタList." + key;
        }

        protected Map<String, Mstメニュー権限マスタCQ> _id_NotInScopeSubQuery_Mstメニュー権限マスタListMap;
        public Map<String, Mstメニュー権限マスタCQ> Id_NotInScopeSubQuery_Mstメニュー権限マスタList { get { return _id_NotInScopeSubQuery_Mstメニュー権限マスタListMap; }}
        public override String keepId_NotInScopeSubQuery_Mstメニュー権限マスタList(Mstメニュー権限マスタCQ subQuery) {
            if (_id_NotInScopeSubQuery_Mstメニュー権限マスタListMap == null) { _id_NotInScopeSubQuery_Mstメニュー権限マスタListMap = new LinkedHashMap<String, Mstメニュー権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_NotInScopeSubQuery_Mstメニュー権限マスタListMap.size() + 1);
            _id_NotInScopeSubQuery_Mstメニュー権限マスタListMap.put(key, subQuery); return "Id_NotInScopeSubQuery_Mstメニュー権限マスタList." + key;
        }

        protected Map<String, Mstメニュー権限マスタCQ> _id_SpecifyDerivedReferrer_Mstメニュー権限マスタListMap;
        public Map<String, Mstメニュー権限マスタCQ> Id_SpecifyDerivedReferrer_Mstメニュー権限マスタList { get { return _id_SpecifyDerivedReferrer_Mstメニュー権限マスタListMap; }}
        public override String keepId_SpecifyDerivedReferrer_Mstメニュー権限マスタList(Mstメニュー権限マスタCQ subQuery) {
            if (_id_SpecifyDerivedReferrer_Mstメニュー権限マスタListMap == null) { _id_SpecifyDerivedReferrer_Mstメニュー権限マスタListMap = new LinkedHashMap<String, Mstメニュー権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_SpecifyDerivedReferrer_Mstメニュー権限マスタListMap.size() + 1);
            _id_SpecifyDerivedReferrer_Mstメニュー権限マスタListMap.put(key, subQuery); return "Id_SpecifyDerivedReferrer_Mstメニュー権限マスタList." + key;
        }

        protected Map<String, Mstメニュー権限マスタCQ> _id_QueryDerivedReferrer_Mstメニュー権限マスタListMap;
        public Map<String, Mstメニュー権限マスタCQ> Id_QueryDerivedReferrer_Mstメニュー権限マスタList { get { return _id_QueryDerivedReferrer_Mstメニュー権限マスタListMap; } }
        public override String keepId_QueryDerivedReferrer_Mstメニュー権限マスタList(Mstメニュー権限マスタCQ subQuery) {
            if (_id_QueryDerivedReferrer_Mstメニュー権限マスタListMap == null) { _id_QueryDerivedReferrer_Mstメニュー権限マスタListMap = new LinkedHashMap<String, Mstメニュー権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_QueryDerivedReferrer_Mstメニュー権限マスタListMap.size() + 1);
            _id_QueryDerivedReferrer_Mstメニュー権限マスタListMap.put(key, subQuery); return "Id_QueryDerivedReferrer_Mstメニュー権限マスタList." + key;
        }
        protected Map<String, Object> _id_QueryDerivedReferrer_Mstメニュー権限マスタListParameterMap;
        public Map<String, Object> Id_QueryDerivedReferrer_Mstメニュー権限マスタListParameter { get { return _id_QueryDerivedReferrer_Mstメニュー権限マスタListParameterMap; } }
        public override String keepId_QueryDerivedReferrer_Mstメニュー権限マスタListParameter(Object parameterValue) {
            if (_id_QueryDerivedReferrer_Mstメニュー権限マスタListParameterMap == null) { _id_QueryDerivedReferrer_Mstメニュー権限マスタListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_id_QueryDerivedReferrer_Mstメニュー権限マスタListParameterMap.size() + 1);
            _id_QueryDerivedReferrer_Mstメニュー権限マスタListParameterMap.put(key, parameterValue); return "Id_QueryDerivedReferrer_Mstメニュー権限マスタListParameter." + key;
        }

        public BsMst制御画面マスタCQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsMst制御画面マスタCQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _画面名;
        public ConditionValue 画面名 {
            get { if (_画面名 == null) { _画面名 = new ConditionValue(); } return _画面名; }
        }
        protected override ConditionValue getCValue画面名() { return this.画面名; }


        public BsMst制御画面マスタCQ AddOrderBy_画面名_Asc() { regOBA("画面名");return this; }
        public BsMst制御画面マスタCQ AddOrderBy_画面名_Desc() { regOBD("画面名");return this; }

        protected ConditionValue _表示名;
        public ConditionValue 表示名 {
            get { if (_表示名 == null) { _表示名 = new ConditionValue(); } return _表示名; }
        }
        protected override ConditionValue getCValue表示名() { return this.表示名; }


        public BsMst制御画面マスタCQ AddOrderBy_表示名_Asc() { regOBA("表示名");return this; }
        public BsMst制御画面マスタCQ AddOrderBy_表示名_Desc() { regOBD("表示名");return this; }

        protected ConditionValue _優先順位;
        public ConditionValue 優先順位 {
            get { if (_優先順位 == null) { _優先順位 = new ConditionValue(); } return _優先順位; }
        }
        protected override ConditionValue getCValue優先順位() { return this.優先順位; }


        public BsMst制御画面マスタCQ AddOrderBy_優先順位_Asc() { regOBA("優先順位");return this; }
        public BsMst制御画面マスタCQ AddOrderBy_優先順位_Desc() { regOBD("優先順位");return this; }

        public BsMst制御画面マスタCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMst制御画面マスタCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Mst制御画面マスタCQ> _scalarSubQueryMap;
	    public Map<String, Mst制御画面マスタCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Mst制御画面マスタCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Mst制御画面マスタCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Mst制御画面マスタCQ> _myselfInScopeSubQueryMap;
        public Map<String, Mst制御画面マスタCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Mst制御画面マスタCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Mst制御画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
