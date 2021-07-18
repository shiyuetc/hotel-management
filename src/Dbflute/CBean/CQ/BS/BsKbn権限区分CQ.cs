
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsKbn権限区分CQ : AbstractBsKbn権限区分CQ {

        protected Kbn権限区分CIQ _inlineQuery;

        public BsKbn権限区分CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Kbn権限区分CIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Kbn権限区分CIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Kbn権限区分CIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Kbn権限区分CIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _コード;
        public ConditionValue コード {
            get { if (_コード == null) { _コード = new ConditionValue(); } return _コード; }
        }
        protected override ConditionValue getCValueコード() { return this.コード; }


        protected Map<String, Mst権限マスタCQ> _コード_ExistsSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> コード_ExistsSubQuery_Mst権限マスタList { get { return _コード_ExistsSubQuery_Mst権限マスタListMap; }}
        public override String keepコード_ExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_コード_ExistsSubQuery_Mst権限マスタListMap == null) { _コード_ExistsSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_ExistsSubQuery_Mst権限マスタListMap.size() + 1);
            _コード_ExistsSubQuery_Mst権限マスタListMap.put(key, subQuery); return "コード_ExistsSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _コード_NotExistsSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> コード_NotExistsSubQuery_Mst権限マスタList { get { return _コード_NotExistsSubQuery_Mst権限マスタListMap; }}
        public override String keepコード_NotExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_コード_NotExistsSubQuery_Mst権限マスタListMap == null) { _コード_NotExistsSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_NotExistsSubQuery_Mst権限マスタListMap.size() + 1);
            _コード_NotExistsSubQuery_Mst権限マスタListMap.put(key, subQuery); return "コード_NotExistsSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _コード_InScopeSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> コード_InScopeSubQuery_Mst権限マスタList { get { return _コード_InScopeSubQuery_Mst権限マスタListMap; }}
        public override String keepコード_InScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_コード_InScopeSubQuery_Mst権限マスタListMap == null) { _コード_InScopeSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_InScopeSubQuery_Mst権限マスタListMap.size() + 1);
            _コード_InScopeSubQuery_Mst権限マスタListMap.put(key, subQuery); return "コード_InScopeSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _コード_NotInScopeSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> コード_NotInScopeSubQuery_Mst権限マスタList { get { return _コード_NotInScopeSubQuery_Mst権限マスタListMap; }}
        public override String keepコード_NotInScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_コード_NotInScopeSubQuery_Mst権限マスタListMap == null) { _コード_NotInScopeSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_NotInScopeSubQuery_Mst権限マスタListMap.size() + 1);
            _コード_NotInScopeSubQuery_Mst権限マスタListMap.put(key, subQuery); return "コード_NotInScopeSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _コード_SpecifyDerivedReferrer_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> コード_SpecifyDerivedReferrer_Mst権限マスタList { get { return _コード_SpecifyDerivedReferrer_Mst権限マスタListMap; }}
        public override String keepコード_SpecifyDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_コード_SpecifyDerivedReferrer_Mst権限マスタListMap == null) { _コード_SpecifyDerivedReferrer_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_SpecifyDerivedReferrer_Mst権限マスタListMap.size() + 1);
           _コード_SpecifyDerivedReferrer_Mst権限マスタListMap.put(key, subQuery); return "コード_SpecifyDerivedReferrer_Mst権限マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _コード_QueryDerivedReferrer_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> コード_QueryDerivedReferrer_Mst権限マスタList { get { return _コード_QueryDerivedReferrer_Mst権限マスタListMap; } }
        public override String keepコード_QueryDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_コード_QueryDerivedReferrer_Mst権限マスタListMap == null) { _コード_QueryDerivedReferrer_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_QueryDerivedReferrer_Mst権限マスタListMap.size() + 1);
            _コード_QueryDerivedReferrer_Mst権限マスタListMap.put(key, subQuery); return "コード_QueryDerivedReferrer_Mst権限マスタList." + key;
        }
        protected Map<String, Object> _コード_QueryDerivedReferrer_Mst権限マスタListParameterMap;
        public Map<String, Object> コード_QueryDerivedReferrer_Mst権限マスタListParameter { get { return _コード_QueryDerivedReferrer_Mst権限マスタListParameterMap; } }
        public override String keepコード_QueryDerivedReferrer_Mst権限マスタListParameter(Object parameterValue) {
            if (_コード_QueryDerivedReferrer_Mst権限マスタListParameterMap == null) { _コード_QueryDerivedReferrer_Mst権限マスタListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_コード_QueryDerivedReferrer_Mst権限マスタListParameterMap.size() + 1);
            _コード_QueryDerivedReferrer_Mst権限マスタListParameterMap.put(key, parameterValue); return "コード_QueryDerivedReferrer_Mst権限マスタListParameter." + key;
        }

        public BsKbn権限区分CQ AddOrderBy_コード_Asc() { regOBA("コード");return this; }
        public BsKbn権限区分CQ AddOrderBy_コード_Desc() { regOBD("コード");return this; }

        protected ConditionValue _名称;
        public ConditionValue 名称 {
            get { if (_名称 == null) { _名称 = new ConditionValue(); } return _名称; }
        }
        protected override ConditionValue getCValue名称() { return this.名称; }


        public BsKbn権限区分CQ AddOrderBy_名称_Asc() { regOBA("名称");return this; }
        public BsKbn権限区分CQ AddOrderBy_名称_Desc() { regOBD("名称");return this; }

        public BsKbn権限区分CQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsKbn権限区分CQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Kbn権限区分CQ> _scalarSubQueryMap;
	    public Map<String, Kbn権限区分CQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Kbn権限区分CQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Kbn権限区分CQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Kbn権限区分CQ> _myselfInScopeSubQueryMap;
        public Map<String, Kbn権限区分CQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Kbn権限区分CQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Kbn権限区分CQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
