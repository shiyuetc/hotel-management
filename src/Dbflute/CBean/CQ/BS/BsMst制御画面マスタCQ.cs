
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


        protected Map<String, Mst権限マスタCQ> _id_ExistsSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> Id_ExistsSubQuery_Mst権限マスタList { get { return _id_ExistsSubQuery_Mst権限マスタListMap; }}
        public override String keepId_ExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_id_ExistsSubQuery_Mst権限マスタListMap == null) { _id_ExistsSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_ExistsSubQuery_Mst権限マスタListMap.size() + 1);
            _id_ExistsSubQuery_Mst権限マスタListMap.put(key, subQuery); return "Id_ExistsSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _id_NotExistsSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> Id_NotExistsSubQuery_Mst権限マスタList { get { return _id_NotExistsSubQuery_Mst権限マスタListMap; }}
        public override String keepId_NotExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_id_NotExistsSubQuery_Mst権限マスタListMap == null) { _id_NotExistsSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_NotExistsSubQuery_Mst権限マスタListMap.size() + 1);
            _id_NotExistsSubQuery_Mst権限マスタListMap.put(key, subQuery); return "Id_NotExistsSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _id_InScopeSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> Id_InScopeSubQuery_Mst権限マスタList { get { return _id_InScopeSubQuery_Mst権限マスタListMap; }}
        public override String keepId_InScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_id_InScopeSubQuery_Mst権限マスタListMap == null) { _id_InScopeSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_InScopeSubQuery_Mst権限マスタListMap.size() + 1);
            _id_InScopeSubQuery_Mst権限マスタListMap.put(key, subQuery); return "Id_InScopeSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _id_NotInScopeSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> Id_NotInScopeSubQuery_Mst権限マスタList { get { return _id_NotInScopeSubQuery_Mst権限マスタListMap; }}
        public override String keepId_NotInScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_id_NotInScopeSubQuery_Mst権限マスタListMap == null) { _id_NotInScopeSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_NotInScopeSubQuery_Mst権限マスタListMap.size() + 1);
            _id_NotInScopeSubQuery_Mst権限マスタListMap.put(key, subQuery); return "Id_NotInScopeSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _id_SpecifyDerivedReferrer_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> Id_SpecifyDerivedReferrer_Mst権限マスタList { get { return _id_SpecifyDerivedReferrer_Mst権限マスタListMap; }}
        public override String keepId_SpecifyDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_id_SpecifyDerivedReferrer_Mst権限マスタListMap == null) { _id_SpecifyDerivedReferrer_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_SpecifyDerivedReferrer_Mst権限マスタListMap.size() + 1);
            _id_SpecifyDerivedReferrer_Mst権限マスタListMap.put(key, subQuery); return "Id_SpecifyDerivedReferrer_Mst権限マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _id_QueryDerivedReferrer_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> Id_QueryDerivedReferrer_Mst権限マスタList { get { return _id_QueryDerivedReferrer_Mst権限マスタListMap; } }
        public override String keepId_QueryDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_id_QueryDerivedReferrer_Mst権限マスタListMap == null) { _id_QueryDerivedReferrer_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_QueryDerivedReferrer_Mst権限マスタListMap.size() + 1);
            _id_QueryDerivedReferrer_Mst権限マスタListMap.put(key, subQuery); return "Id_QueryDerivedReferrer_Mst権限マスタList." + key;
        }
        protected Map<String, Object> _id_QueryDerivedReferrer_Mst権限マスタListParameterMap;
        public Map<String, Object> Id_QueryDerivedReferrer_Mst権限マスタListParameter { get { return _id_QueryDerivedReferrer_Mst権限マスタListParameterMap; } }
        public override String keepId_QueryDerivedReferrer_Mst権限マスタListParameter(Object parameterValue) {
            if (_id_QueryDerivedReferrer_Mst権限マスタListParameterMap == null) { _id_QueryDerivedReferrer_Mst権限マスタListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_id_QueryDerivedReferrer_Mst権限マスタListParameterMap.size() + 1);
            _id_QueryDerivedReferrer_Mst権限マスタListParameterMap.put(key, parameterValue); return "Id_QueryDerivedReferrer_Mst権限マスタListParameter." + key;
        }

        public BsMst制御画面マスタCQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsMst制御画面マスタCQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _メニューcode;
        public ConditionValue メニューcode {
            get { if (_メニューcode == null) { _メニューcode = new ConditionValue(); } return _メニューcode; }
        }
        protected override ConditionValue getCValueメニューcode() { return this.メニューcode; }


        protected Map<String, Kbnメニュー区分CQ> _メニューcode_InScopeSubQuery_Kbnメニュー区分Map;
        public Map<String, Kbnメニュー区分CQ> メニューcode_InScopeSubQuery_Kbnメニュー区分 { get { return _メニューcode_InScopeSubQuery_Kbnメニュー区分Map; }}
        public override String keepメニューcode_InScopeSubQuery_Kbnメニュー区分(Kbnメニュー区分CQ subQuery) {
            if (_メニューcode_InScopeSubQuery_Kbnメニュー区分Map == null) { _メニューcode_InScopeSubQuery_Kbnメニュー区分Map = new LinkedHashMap<String, Kbnメニュー区分CQ>(); }
            String key = "subQueryMapKey" + (_メニューcode_InScopeSubQuery_Kbnメニュー区分Map.size() + 1);
            _メニューcode_InScopeSubQuery_Kbnメニュー区分Map.put(key, subQuery); return "メニューcode_InScopeSubQuery_Kbnメニュー区分." + key;
        }

        protected Map<String, Kbnメニュー区分CQ> _メニューcode_NotInScopeSubQuery_Kbnメニュー区分Map;
        public Map<String, Kbnメニュー区分CQ> メニューcode_NotInScopeSubQuery_Kbnメニュー区分 { get { return _メニューcode_NotInScopeSubQuery_Kbnメニュー区分Map; }}
        public override String keepメニューcode_NotInScopeSubQuery_Kbnメニュー区分(Kbnメニュー区分CQ subQuery) {
            if (_メニューcode_NotInScopeSubQuery_Kbnメニュー区分Map == null) { _メニューcode_NotInScopeSubQuery_Kbnメニュー区分Map = new LinkedHashMap<String, Kbnメニュー区分CQ>(); }
            String key = "subQueryMapKey" + (_メニューcode_NotInScopeSubQuery_Kbnメニュー区分Map.size() + 1);
            _メニューcode_NotInScopeSubQuery_Kbnメニュー区分Map.put(key, subQuery); return "メニューcode_NotInScopeSubQuery_Kbnメニュー区分." + key;
        }

        public BsMst制御画面マスタCQ AddOrderBy_メニューcode_Asc() { regOBA("メニューcode");return this; }
        public BsMst制御画面マスタCQ AddOrderBy_メニューcode_Desc() { regOBD("メニューcode");return this; }

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
            Mst制御画面マスタCQ baseQuery = (Mst制御画面マスタCQ)baseQueryAsSuper;
            Mst制御画面マスタCQ unionQuery = (Mst制御画面マスタCQ)unionQueryAsSuper;
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
            joinOnMap.put("メニューcode", "code");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathKbnメニュー区分() {
            return resolveNextRelationPath("mst制御画面マスタ", "kbnメニュー区分");
        }
        public bool hasConditionQueryKbnメニュー区分() {
            return _conditionQueryKbnメニュー区分 != null;
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
