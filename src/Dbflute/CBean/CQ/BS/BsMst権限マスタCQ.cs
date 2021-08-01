
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMst権限マスタCQ : AbstractBsMst権限マスタCQ {

        protected Mst権限マスタCIQ _inlineQuery;

        public BsMst権限マスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Mst権限マスタCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Mst権限マスタCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Mst権限マスタCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Mst権限マスタCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _職位コード;
        public ConditionValue 職位コード {
            get { if (_職位コード == null) { _職位コード = new ConditionValue(); } return _職位コード; }
        }
        protected override ConditionValue getCValue職位コード() { return this.職位コード; }


        protected Map<String, Kbn職位区分CQ> _職位コード_InScopeSubQuery_Kbn職位区分Map;
        public Map<String, Kbn職位区分CQ> 職位コード_InScopeSubQuery_Kbn職位区分 { get { return _職位コード_InScopeSubQuery_Kbn職位区分Map; }}
        public override String keep職位コード_InScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery) {
            if (_職位コード_InScopeSubQuery_Kbn職位区分Map == null) { _職位コード_InScopeSubQuery_Kbn職位区分Map = new LinkedHashMap<String, Kbn職位区分CQ>(); }
            String key = "subQueryMapKey" + (_職位コード_InScopeSubQuery_Kbn職位区分Map.size() + 1);
            _職位コード_InScopeSubQuery_Kbn職位区分Map.put(key, subQuery); return "職位コード_InScopeSubQuery_Kbn職位区分." + key;
        }

        protected Map<String, Kbn職位区分CQ> _職位コード_NotInScopeSubQuery_Kbn職位区分Map;
        public Map<String, Kbn職位区分CQ> 職位コード_NotInScopeSubQuery_Kbn職位区分 { get { return _職位コード_NotInScopeSubQuery_Kbn職位区分Map; }}
        public override String keep職位コード_NotInScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery) {
            if (_職位コード_NotInScopeSubQuery_Kbn職位区分Map == null) { _職位コード_NotInScopeSubQuery_Kbn職位区分Map = new LinkedHashMap<String, Kbn職位区分CQ>(); }
            String key = "subQueryMapKey" + (_職位コード_NotInScopeSubQuery_Kbn職位区分Map.size() + 1);
            _職位コード_NotInScopeSubQuery_Kbn職位区分Map.put(key, subQuery); return "職位コード_NotInScopeSubQuery_Kbn職位区分." + key;
        }

        public BsMst権限マスタCQ AddOrderBy_職位コード_Asc() { regOBA("職位コード");return this; }
        public BsMst権限マスタCQ AddOrderBy_職位コード_Desc() { regOBD("職位コード");return this; }

        protected ConditionValue _画面コード;
        public ConditionValue 画面コード {
            get { if (_画面コード == null) { _画面コード = new ConditionValue(); } return _画面コード; }
        }
        protected override ConditionValue getCValue画面コード() { return this.画面コード; }


        protected Map<String, Mst画面マスタCQ> _画面コード_InScopeSubQuery_Mst画面マスタMap;
        public Map<String, Mst画面マスタCQ> 画面コード_InScopeSubQuery_Mst画面マスタ { get { return _画面コード_InScopeSubQuery_Mst画面マスタMap; }}
        public override String keep画面コード_InScopeSubQuery_Mst画面マスタ(Mst画面マスタCQ subQuery) {
            if (_画面コード_InScopeSubQuery_Mst画面マスタMap == null) { _画面コード_InScopeSubQuery_Mst画面マスタMap = new LinkedHashMap<String, Mst画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_画面コード_InScopeSubQuery_Mst画面マスタMap.size() + 1);
            _画面コード_InScopeSubQuery_Mst画面マスタMap.put(key, subQuery); return "画面コード_InScopeSubQuery_Mst画面マスタ." + key;
        }

        protected Map<String, Mst画面マスタCQ> _画面コード_NotInScopeSubQuery_Mst画面マスタMap;
        public Map<String, Mst画面マスタCQ> 画面コード_NotInScopeSubQuery_Mst画面マスタ { get { return _画面コード_NotInScopeSubQuery_Mst画面マスタMap; }}
        public override String keep画面コード_NotInScopeSubQuery_Mst画面マスタ(Mst画面マスタCQ subQuery) {
            if (_画面コード_NotInScopeSubQuery_Mst画面マスタMap == null) { _画面コード_NotInScopeSubQuery_Mst画面マスタMap = new LinkedHashMap<String, Mst画面マスタCQ>(); }
            String key = "subQueryMapKey" + (_画面コード_NotInScopeSubQuery_Mst画面マスタMap.size() + 1);
            _画面コード_NotInScopeSubQuery_Mst画面マスタMap.put(key, subQuery); return "画面コード_NotInScopeSubQuery_Mst画面マスタ." + key;
        }

        public BsMst権限マスタCQ AddOrderBy_画面コード_Asc() { regOBA("画面コード");return this; }
        public BsMst権限マスタCQ AddOrderBy_画面コード_Desc() { regOBD("画面コード");return this; }

        public BsMst権限マスタCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMst権限マスタCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            Mst権限マスタCQ baseQuery = (Mst権限マスタCQ)baseQueryAsSuper;
            Mst権限マスタCQ unionQuery = (Mst権限マスタCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMst画面マスタ()) {
                unionQuery.QueryMst画面マスタ().reflectRelationOnUnionQuery(baseQuery.QueryMst画面マスタ(), unionQuery.QueryMst画面マスタ());
            }
            if (baseQuery.hasConditionQueryKbn職位区分()) {
                unionQuery.QueryKbn職位区分().reflectRelationOnUnionQuery(baseQuery.QueryKbn職位区分(), unionQuery.QueryKbn職位区分());
            }

        }
    
        protected Mst画面マスタCQ _conditionQueryMst画面マスタ;
        public Mst画面マスタCQ QueryMst画面マスタ() {
            return this.ConditionQueryMst画面マスタ;
        }
        public Mst画面マスタCQ ConditionQueryMst画面マスタ {
            get {
                if (_conditionQueryMst画面マスタ == null) {
                    _conditionQueryMst画面マスタ = xcreateQueryMst画面マスタ();
                    xsetupOuterJoin_Mst画面マスタ();
                }
                return _conditionQueryMst画面マスタ;
            }
        }
        protected Mst画面マスタCQ xcreateQueryMst画面マスタ() {
            String nrp = resolveNextRelationPathMst画面マスタ();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Mst画面マスタCQ cq = new Mst画面マスタCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("mst画面マスタ"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Mst画面マスタ() {
            Mst画面マスタCQ cq = ConditionQueryMst画面マスタ;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("画面コード", "画面コード");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMst画面マスタ() {
            return resolveNextRelationPath("mst権限マスタ", "mst画面マスタ");
        }
        public bool hasConditionQueryMst画面マスタ() {
            return _conditionQueryMst画面マスタ != null;
        }
        protected Kbn職位区分CQ _conditionQueryKbn職位区分;
        public Kbn職位区分CQ QueryKbn職位区分() {
            return this.ConditionQueryKbn職位区分;
        }
        public Kbn職位区分CQ ConditionQueryKbn職位区分 {
            get {
                if (_conditionQueryKbn職位区分 == null) {
                    _conditionQueryKbn職位区分 = xcreateQueryKbn職位区分();
                    xsetupOuterJoin_Kbn職位区分();
                }
                return _conditionQueryKbn職位区分;
            }
        }
        protected Kbn職位区分CQ xcreateQueryKbn職位区分() {
            String nrp = resolveNextRelationPathKbn職位区分();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Kbn職位区分CQ cq = new Kbn職位区分CQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("kbn職位区分"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Kbn職位区分() {
            Kbn職位区分CQ cq = ConditionQueryKbn職位区分;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("職位コード", "職位コード");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathKbn職位区分() {
            return resolveNextRelationPath("mst権限マスタ", "kbn職位区分");
        }
        public bool hasConditionQueryKbn職位区分() {
            return _conditionQueryKbn職位区分 != null;
        }

    }
}
