
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMst客室タイプマスタCQ : AbstractBsMst客室タイプマスタCQ {

        protected Mst客室タイプマスタCIQ _inlineQuery;

        public BsMst客室タイプマスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Mst客室タイプマスタCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Mst客室タイプマスタCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Mst客室タイプマスタCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Mst客室タイプマスタCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        protected Map<String, Mst客室マスタCQ> _id_ExistsSubQuery_Mst客室マスタListMap;
        public Map<String, Mst客室マスタCQ> Id_ExistsSubQuery_Mst客室マスタList { get { return _id_ExistsSubQuery_Mst客室マスタListMap; }}
        public override String keepId_ExistsSubQuery_Mst客室マスタList(Mst客室マスタCQ subQuery) {
            if (_id_ExistsSubQuery_Mst客室マスタListMap == null) { _id_ExistsSubQuery_Mst客室マスタListMap = new LinkedHashMap<String, Mst客室マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_ExistsSubQuery_Mst客室マスタListMap.size() + 1);
            _id_ExistsSubQuery_Mst客室マスタListMap.put(key, subQuery); return "Id_ExistsSubQuery_Mst客室マスタList." + key;
        }

        protected Map<String, Mst客室マスタCQ> _id_NotExistsSubQuery_Mst客室マスタListMap;
        public Map<String, Mst客室マスタCQ> Id_NotExistsSubQuery_Mst客室マスタList { get { return _id_NotExistsSubQuery_Mst客室マスタListMap; }}
        public override String keepId_NotExistsSubQuery_Mst客室マスタList(Mst客室マスタCQ subQuery) {
            if (_id_NotExistsSubQuery_Mst客室マスタListMap == null) { _id_NotExistsSubQuery_Mst客室マスタListMap = new LinkedHashMap<String, Mst客室マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_NotExistsSubQuery_Mst客室マスタListMap.size() + 1);
            _id_NotExistsSubQuery_Mst客室マスタListMap.put(key, subQuery); return "Id_NotExistsSubQuery_Mst客室マスタList." + key;
        }

        protected Map<String, Mst客室マスタCQ> _id_InScopeSubQuery_Mst客室マスタListMap;
        public Map<String, Mst客室マスタCQ> Id_InScopeSubQuery_Mst客室マスタList { get { return _id_InScopeSubQuery_Mst客室マスタListMap; }}
        public override String keepId_InScopeSubQuery_Mst客室マスタList(Mst客室マスタCQ subQuery) {
            if (_id_InScopeSubQuery_Mst客室マスタListMap == null) { _id_InScopeSubQuery_Mst客室マスタListMap = new LinkedHashMap<String, Mst客室マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_InScopeSubQuery_Mst客室マスタListMap.size() + 1);
            _id_InScopeSubQuery_Mst客室マスタListMap.put(key, subQuery); return "Id_InScopeSubQuery_Mst客室マスタList." + key;
        }

        protected Map<String, Mst客室マスタCQ> _id_NotInScopeSubQuery_Mst客室マスタListMap;
        public Map<String, Mst客室マスタCQ> Id_NotInScopeSubQuery_Mst客室マスタList { get { return _id_NotInScopeSubQuery_Mst客室マスタListMap; }}
        public override String keepId_NotInScopeSubQuery_Mst客室マスタList(Mst客室マスタCQ subQuery) {
            if (_id_NotInScopeSubQuery_Mst客室マスタListMap == null) { _id_NotInScopeSubQuery_Mst客室マスタListMap = new LinkedHashMap<String, Mst客室マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_NotInScopeSubQuery_Mst客室マスタListMap.size() + 1);
            _id_NotInScopeSubQuery_Mst客室マスタListMap.put(key, subQuery); return "Id_NotInScopeSubQuery_Mst客室マスタList." + key;
        }

        protected Map<String, Mst客室マスタCQ> _id_SpecifyDerivedReferrer_Mst客室マスタListMap;
        public Map<String, Mst客室マスタCQ> Id_SpecifyDerivedReferrer_Mst客室マスタList { get { return _id_SpecifyDerivedReferrer_Mst客室マスタListMap; }}
        public override String keepId_SpecifyDerivedReferrer_Mst客室マスタList(Mst客室マスタCQ subQuery) {
            if (_id_SpecifyDerivedReferrer_Mst客室マスタListMap == null) { _id_SpecifyDerivedReferrer_Mst客室マスタListMap = new LinkedHashMap<String, Mst客室マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_SpecifyDerivedReferrer_Mst客室マスタListMap.size() + 1);
            _id_SpecifyDerivedReferrer_Mst客室マスタListMap.put(key, subQuery); return "Id_SpecifyDerivedReferrer_Mst客室マスタList." + key;
        }

        protected Map<String, Mst客室マスタCQ> _id_QueryDerivedReferrer_Mst客室マスタListMap;
        public Map<String, Mst客室マスタCQ> Id_QueryDerivedReferrer_Mst客室マスタList { get { return _id_QueryDerivedReferrer_Mst客室マスタListMap; } }
        public override String keepId_QueryDerivedReferrer_Mst客室マスタList(Mst客室マスタCQ subQuery) {
            if (_id_QueryDerivedReferrer_Mst客室マスタListMap == null) { _id_QueryDerivedReferrer_Mst客室マスタListMap = new LinkedHashMap<String, Mst客室マスタCQ>(); }
            String key = "subQueryMapKey" + (_id_QueryDerivedReferrer_Mst客室マスタListMap.size() + 1);
            _id_QueryDerivedReferrer_Mst客室マスタListMap.put(key, subQuery); return "Id_QueryDerivedReferrer_Mst客室マスタList." + key;
        }
        protected Map<String, Object> _id_QueryDerivedReferrer_Mst客室マスタListParameterMap;
        public Map<String, Object> Id_QueryDerivedReferrer_Mst客室マスタListParameter { get { return _id_QueryDerivedReferrer_Mst客室マスタListParameterMap; } }
        public override String keepId_QueryDerivedReferrer_Mst客室マスタListParameter(Object parameterValue) {
            if (_id_QueryDerivedReferrer_Mst客室マスタListParameterMap == null) { _id_QueryDerivedReferrer_Mst客室マスタListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_id_QueryDerivedReferrer_Mst客室マスタListParameterMap.size() + 1);
            _id_QueryDerivedReferrer_Mst客室マスタListParameterMap.put(key, parameterValue); return "Id_QueryDerivedReferrer_Mst客室マスタListParameter." + key;
        }

        public BsMst客室タイプマスタCQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsMst客室タイプマスタCQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _名称;
        public ConditionValue 名称 {
            get { if (_名称 == null) { _名称 = new ConditionValue(); } return _名称; }
        }
        protected override ConditionValue getCValue名称() { return this.名称; }


        public BsMst客室タイプマスタCQ AddOrderBy_名称_Asc() { regOBA("名称");return this; }
        public BsMst客室タイプマスタCQ AddOrderBy_名称_Desc() { regOBD("名称");return this; }

        protected ConditionValue _料金;
        public ConditionValue 料金 {
            get { if (_料金 == null) { _料金 = new ConditionValue(); } return _料金; }
        }
        protected override ConditionValue getCValue料金() { return this.料金; }


        public BsMst客室タイプマスタCQ AddOrderBy_料金_Asc() { regOBA("料金");return this; }
        public BsMst客室タイプマスタCQ AddOrderBy_料金_Desc() { regOBD("料金");return this; }

        protected ConditionValue _宿泊人数;
        public ConditionValue 宿泊人数 {
            get { if (_宿泊人数 == null) { _宿泊人数 = new ConditionValue(); } return _宿泊人数; }
        }
        protected override ConditionValue getCValue宿泊人数() { return this.宿泊人数; }


        public BsMst客室タイプマスタCQ AddOrderBy_宿泊人数_Asc() { regOBA("宿泊人数");return this; }
        public BsMst客室タイプマスタCQ AddOrderBy_宿泊人数_Desc() { regOBD("宿泊人数");return this; }

        protected ConditionValue _備考;
        public ConditionValue 備考 {
            get { if (_備考 == null) { _備考 = new ConditionValue(); } return _備考; }
        }
        protected override ConditionValue getCValue備考() { return this.備考; }


        public BsMst客室タイプマスタCQ AddOrderBy_備考_Asc() { regOBA("備考");return this; }
        public BsMst客室タイプマスタCQ AddOrderBy_備考_Desc() { regOBD("備考");return this; }

        public BsMst客室タイプマスタCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMst客室タイプマスタCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Mst客室タイプマスタCQ> _scalarSubQueryMap;
	    public Map<String, Mst客室タイプマスタCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Mst客室タイプマスタCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Mst客室タイプマスタCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Mst客室タイプマスタCQ> _myselfInScopeSubQueryMap;
        public Map<String, Mst客室タイプマスタCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Mst客室タイプマスタCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Mst客室タイプマスタCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
