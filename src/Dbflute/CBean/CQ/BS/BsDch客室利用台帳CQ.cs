
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsDch客室利用台帳CQ : AbstractBsDch客室利用台帳CQ {

        protected Dch客室利用台帳CIQ _inlineQuery;

        public BsDch客室利用台帳CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Dch客室利用台帳CIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Dch客室利用台帳CIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Dch客室利用台帳CIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Dch客室利用台帳CIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        protected Map<String, Dch宿泊利用台帳CQ> _id_ExistsSubQuery_Dch宿泊利用台帳AsOneMap;
        public Map<String, Dch宿泊利用台帳CQ> Id_ExistsSubQuery_Dch宿泊利用台帳AsOne { get { return _id_ExistsSubQuery_Dch宿泊利用台帳AsOneMap; }}
        public override String keepId_ExistsSubQuery_Dch宿泊利用台帳AsOne(Dch宿泊利用台帳CQ subQuery) {
            if (_id_ExistsSubQuery_Dch宿泊利用台帳AsOneMap == null) { _id_ExistsSubQuery_Dch宿泊利用台帳AsOneMap = new LinkedHashMap<String, Dch宿泊利用台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_ExistsSubQuery_Dch宿泊利用台帳AsOneMap.size() + 1);
            _id_ExistsSubQuery_Dch宿泊利用台帳AsOneMap.put(key, subQuery); return "Id_ExistsSubQuery_Dch宿泊利用台帳AsOne." + key;
        }

        protected Map<String, Dch宿泊利用台帳CQ> _id_NotExistsSubQuery_Dch宿泊利用台帳AsOneMap;
        public Map<String, Dch宿泊利用台帳CQ> Id_NotExistsSubQuery_Dch宿泊利用台帳AsOne { get { return _id_NotExistsSubQuery_Dch宿泊利用台帳AsOneMap; }}
        public override String keepId_NotExistsSubQuery_Dch宿泊利用台帳AsOne(Dch宿泊利用台帳CQ subQuery) {
            if (_id_NotExistsSubQuery_Dch宿泊利用台帳AsOneMap == null) { _id_NotExistsSubQuery_Dch宿泊利用台帳AsOneMap = new LinkedHashMap<String, Dch宿泊利用台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_NotExistsSubQuery_Dch宿泊利用台帳AsOneMap.size() + 1);
            _id_NotExistsSubQuery_Dch宿泊利用台帳AsOneMap.put(key, subQuery); return "Id_NotExistsSubQuery_Dch宿泊利用台帳AsOne." + key;
        }

        protected Map<String, Dch宿泊利用台帳CQ> _id_InScopeSubQuery_Dch宿泊利用台帳AsOneMap;
        public Map<String, Dch宿泊利用台帳CQ> Id_InScopeSubQuery_Dch宿泊利用台帳AsOne { get { return _id_InScopeSubQuery_Dch宿泊利用台帳AsOneMap; }}
        public override String keepId_InScopeSubQuery_Dch宿泊利用台帳AsOne(Dch宿泊利用台帳CQ subQuery) {
            if (_id_InScopeSubQuery_Dch宿泊利用台帳AsOneMap == null) { _id_InScopeSubQuery_Dch宿泊利用台帳AsOneMap = new LinkedHashMap<String, Dch宿泊利用台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_InScopeSubQuery_Dch宿泊利用台帳AsOneMap.size() + 1);
            _id_InScopeSubQuery_Dch宿泊利用台帳AsOneMap.put(key, subQuery); return "Id_InScopeSubQuery_Dch宿泊利用台帳AsOne." + key;
        }

        protected Map<String, Dch宿泊利用台帳CQ> _id_NotInScopeSubQuery_Dch宿泊利用台帳AsOneMap;
        public Map<String, Dch宿泊利用台帳CQ> Id_NotInScopeSubQuery_Dch宿泊利用台帳AsOne { get { return _id_NotInScopeSubQuery_Dch宿泊利用台帳AsOneMap; }}
        public override String keepId_NotInScopeSubQuery_Dch宿泊利用台帳AsOne(Dch宿泊利用台帳CQ subQuery) {
            if (_id_NotInScopeSubQuery_Dch宿泊利用台帳AsOneMap == null) { _id_NotInScopeSubQuery_Dch宿泊利用台帳AsOneMap = new LinkedHashMap<String, Dch宿泊利用台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_NotInScopeSubQuery_Dch宿泊利用台帳AsOneMap.size() + 1);
            _id_NotInScopeSubQuery_Dch宿泊利用台帳AsOneMap.put(key, subQuery); return "Id_NotInScopeSubQuery_Dch宿泊利用台帳AsOne." + key;
        }

        public BsDch客室利用台帳CQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsDch客室利用台帳CQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _客室利用コード;
        public ConditionValue 客室利用コード {
            get { if (_客室利用コード == null) { _客室利用コード = new ConditionValue(); } return _客室利用コード; }
        }
        protected override ConditionValue getCValue客室利用コード() { return this.客室利用コード; }


        protected Map<String, Kbn客室利用区分CQ> _客室利用コード_InScopeSubQuery_Kbn客室利用区分Map;
        public Map<String, Kbn客室利用区分CQ> 客室利用コード_InScopeSubQuery_Kbn客室利用区分 { get { return _客室利用コード_InScopeSubQuery_Kbn客室利用区分Map; }}
        public override String keep客室利用コード_InScopeSubQuery_Kbn客室利用区分(Kbn客室利用区分CQ subQuery) {
            if (_客室利用コード_InScopeSubQuery_Kbn客室利用区分Map == null) { _客室利用コード_InScopeSubQuery_Kbn客室利用区分Map = new LinkedHashMap<String, Kbn客室利用区分CQ>(); }
            String key = "subQueryMapKey" + (_客室利用コード_InScopeSubQuery_Kbn客室利用区分Map.size() + 1);
            _客室利用コード_InScopeSubQuery_Kbn客室利用区分Map.put(key, subQuery); return "客室利用コード_InScopeSubQuery_Kbn客室利用区分." + key;
        }

        protected Map<String, Kbn客室利用区分CQ> _客室利用コード_NotInScopeSubQuery_Kbn客室利用区分Map;
        public Map<String, Kbn客室利用区分CQ> 客室利用コード_NotInScopeSubQuery_Kbn客室利用区分 { get { return _客室利用コード_NotInScopeSubQuery_Kbn客室利用区分Map; }}
        public override String keep客室利用コード_NotInScopeSubQuery_Kbn客室利用区分(Kbn客室利用区分CQ subQuery) {
            if (_客室利用コード_NotInScopeSubQuery_Kbn客室利用区分Map == null) { _客室利用コード_NotInScopeSubQuery_Kbn客室利用区分Map = new LinkedHashMap<String, Kbn客室利用区分CQ>(); }
            String key = "subQueryMapKey" + (_客室利用コード_NotInScopeSubQuery_Kbn客室利用区分Map.size() + 1);
            _客室利用コード_NotInScopeSubQuery_Kbn客室利用区分Map.put(key, subQuery); return "客室利用コード_NotInScopeSubQuery_Kbn客室利用区分." + key;
        }

        public BsDch客室利用台帳CQ AddOrderBy_客室利用コード_Asc() { regOBA("客室利用コード");return this; }
        public BsDch客室利用台帳CQ AddOrderBy_客室利用コード_Desc() { regOBD("客室利用コード");return this; }

        protected ConditionValue _客室コード;
        public ConditionValue 客室コード {
            get { if (_客室コード == null) { _客室コード = new ConditionValue(); } return _客室コード; }
        }
        protected override ConditionValue getCValue客室コード() { return this.客室コード; }


        protected Map<String, Mst客室マスタCQ> _客室コード_InScopeSubQuery_Mst客室マスタMap;
        public Map<String, Mst客室マスタCQ> 客室コード_InScopeSubQuery_Mst客室マスタ { get { return _客室コード_InScopeSubQuery_Mst客室マスタMap; }}
        public override String keep客室コード_InScopeSubQuery_Mst客室マスタ(Mst客室マスタCQ subQuery) {
            if (_客室コード_InScopeSubQuery_Mst客室マスタMap == null) { _客室コード_InScopeSubQuery_Mst客室マスタMap = new LinkedHashMap<String, Mst客室マスタCQ>(); }
            String key = "subQueryMapKey" + (_客室コード_InScopeSubQuery_Mst客室マスタMap.size() + 1);
            _客室コード_InScopeSubQuery_Mst客室マスタMap.put(key, subQuery); return "客室コード_InScopeSubQuery_Mst客室マスタ." + key;
        }

        protected Map<String, Mst客室マスタCQ> _客室コード_NotInScopeSubQuery_Mst客室マスタMap;
        public Map<String, Mst客室マスタCQ> 客室コード_NotInScopeSubQuery_Mst客室マスタ { get { return _客室コード_NotInScopeSubQuery_Mst客室マスタMap; }}
        public override String keep客室コード_NotInScopeSubQuery_Mst客室マスタ(Mst客室マスタCQ subQuery) {
            if (_客室コード_NotInScopeSubQuery_Mst客室マスタMap == null) { _客室コード_NotInScopeSubQuery_Mst客室マスタMap = new LinkedHashMap<String, Mst客室マスタCQ>(); }
            String key = "subQueryMapKey" + (_客室コード_NotInScopeSubQuery_Mst客室マスタMap.size() + 1);
            _客室コード_NotInScopeSubQuery_Mst客室マスタMap.put(key, subQuery); return "客室コード_NotInScopeSubQuery_Mst客室マスタ." + key;
        }

        public BsDch客室利用台帳CQ AddOrderBy_客室コード_Asc() { regOBA("客室コード");return this; }
        public BsDch客室利用台帳CQ AddOrderBy_客室コード_Desc() { regOBD("客室コード");return this; }

        protected ConditionValue _開始予定日時;
        public ConditionValue 開始予定日時 {
            get { if (_開始予定日時 == null) { _開始予定日時 = new ConditionValue(); } return _開始予定日時; }
        }
        protected override ConditionValue getCValue開始予定日時() { return this.開始予定日時; }


        public BsDch客室利用台帳CQ AddOrderBy_開始予定日時_Asc() { regOBA("開始予定日時");return this; }
        public BsDch客室利用台帳CQ AddOrderBy_開始予定日時_Desc() { regOBD("開始予定日時");return this; }

        protected ConditionValue _終了予定日時;
        public ConditionValue 終了予定日時 {
            get { if (_終了予定日時 == null) { _終了予定日時 = new ConditionValue(); } return _終了予定日時; }
        }
        protected override ConditionValue getCValue終了予定日時() { return this.終了予定日時; }


        public BsDch客室利用台帳CQ AddOrderBy_終了予定日時_Asc() { regOBA("終了予定日時");return this; }
        public BsDch客室利用台帳CQ AddOrderBy_終了予定日時_Desc() { regOBD("終了予定日時");return this; }

        protected ConditionValue _開始実績日時;
        public ConditionValue 開始実績日時 {
            get { if (_開始実績日時 == null) { _開始実績日時 = new ConditionValue(); } return _開始実績日時; }
        }
        protected override ConditionValue getCValue開始実績日時() { return this.開始実績日時; }


        public BsDch客室利用台帳CQ AddOrderBy_開始実績日時_Asc() { regOBA("開始実績日時");return this; }
        public BsDch客室利用台帳CQ AddOrderBy_開始実績日時_Desc() { regOBD("開始実績日時");return this; }

        protected ConditionValue _終了実績日時;
        public ConditionValue 終了実績日時 {
            get { if (_終了実績日時 == null) { _終了実績日時 = new ConditionValue(); } return _終了実績日時; }
        }
        protected override ConditionValue getCValue終了実績日時() { return this.終了実績日時; }


        public BsDch客室利用台帳CQ AddOrderBy_終了実績日時_Asc() { regOBA("終了実績日時");return this; }
        public BsDch客室利用台帳CQ AddOrderBy_終了実績日時_Desc() { regOBD("終了実績日時");return this; }

        protected ConditionValue _備考;
        public ConditionValue 備考 {
            get { if (_備考 == null) { _備考 = new ConditionValue(); } return _備考; }
        }
        protected override ConditionValue getCValue備考() { return this.備考; }


        public BsDch客室利用台帳CQ AddOrderBy_備考_Asc() { regOBA("備考");return this; }
        public BsDch客室利用台帳CQ AddOrderBy_備考_Desc() { regOBD("備考");return this; }

        public BsDch客室利用台帳CQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsDch客室利用台帳CQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            Dch客室利用台帳CQ baseQuery = (Dch客室利用台帳CQ)baseQueryAsSuper;
            Dch客室利用台帳CQ unionQuery = (Dch客室利用台帳CQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMst客室マスタ()) {
                unionQuery.QueryMst客室マスタ().reflectRelationOnUnionQuery(baseQuery.QueryMst客室マスタ(), unionQuery.QueryMst客室マスタ());
            }
            if (baseQuery.hasConditionQueryKbn客室利用区分()) {
                unionQuery.QueryKbn客室利用区分().reflectRelationOnUnionQuery(baseQuery.QueryKbn客室利用区分(), unionQuery.QueryKbn客室利用区分());
            }
            if (baseQuery.hasConditionQueryDch宿泊利用台帳AsOne()) {
                unionQuery.QueryDch宿泊利用台帳AsOne().reflectRelationOnUnionQuery(baseQuery.QueryDch宿泊利用台帳AsOne(), unionQuery.QueryDch宿泊利用台帳AsOne());
            }

        }
    
        protected Mst客室マスタCQ _conditionQueryMst客室マスタ;
        public Mst客室マスタCQ QueryMst客室マスタ() {
            return this.ConditionQueryMst客室マスタ;
        }
        public Mst客室マスタCQ ConditionQueryMst客室マスタ {
            get {
                if (_conditionQueryMst客室マスタ == null) {
                    _conditionQueryMst客室マスタ = xcreateQueryMst客室マスタ();
                    xsetupOuterJoin_Mst客室マスタ();
                }
                return _conditionQueryMst客室マスタ;
            }
        }
        protected Mst客室マスタCQ xcreateQueryMst客室マスタ() {
            String nrp = resolveNextRelationPathMst客室マスタ();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Mst客室マスタCQ cq = new Mst客室マスタCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("mst客室マスタ"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Mst客室マスタ() {
            Mst客室マスタCQ cq = ConditionQueryMst客室マスタ;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("客室コード", "客室コード");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMst客室マスタ() {
            return resolveNextRelationPath("dch客室利用台帳", "mst客室マスタ");
        }
        public bool hasConditionQueryMst客室マスタ() {
            return _conditionQueryMst客室マスタ != null;
        }
        protected Kbn客室利用区分CQ _conditionQueryKbn客室利用区分;
        public Kbn客室利用区分CQ QueryKbn客室利用区分() {
            return this.ConditionQueryKbn客室利用区分;
        }
        public Kbn客室利用区分CQ ConditionQueryKbn客室利用区分 {
            get {
                if (_conditionQueryKbn客室利用区分 == null) {
                    _conditionQueryKbn客室利用区分 = xcreateQueryKbn客室利用区分();
                    xsetupOuterJoin_Kbn客室利用区分();
                }
                return _conditionQueryKbn客室利用区分;
            }
        }
        protected Kbn客室利用区分CQ xcreateQueryKbn客室利用区分() {
            String nrp = resolveNextRelationPathKbn客室利用区分();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Kbn客室利用区分CQ cq = new Kbn客室利用区分CQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("kbn客室利用区分"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Kbn客室利用区分() {
            Kbn客室利用区分CQ cq = ConditionQueryKbn客室利用区分;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("客室利用コード", "客室利用コード");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathKbn客室利用区分() {
            return resolveNextRelationPath("dch客室利用台帳", "kbn客室利用区分");
        }
        public bool hasConditionQueryKbn客室利用区分() {
            return _conditionQueryKbn客室利用区分 != null;
        }


        protected Dch宿泊利用台帳CQ _conditionQueryDch宿泊利用台帳AsOne;
        public Dch宿泊利用台帳CQ ConditionQueryDch宿泊利用台帳AsOne {
            get {
                if (_conditionQueryDch宿泊利用台帳AsOne == null) {
                    _conditionQueryDch宿泊利用台帳AsOne = createQueryDch宿泊利用台帳AsOne();
                    xsetupOuterJoin_Dch宿泊利用台帳AsOne();
                }
                return _conditionQueryDch宿泊利用台帳AsOne;
            }
        }
        public Dch宿泊利用台帳CQ QueryDch宿泊利用台帳AsOne() { return this.ConditionQueryDch宿泊利用台帳AsOne; }
        protected Dch宿泊利用台帳CQ createQueryDch宿泊利用台帳AsOne() {
            String nrp = resolveNextRelationPathDch宿泊利用台帳AsOne();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Dch宿泊利用台帳CQ cq = new Dch宿泊利用台帳CQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("dch宿泊利用台帳AsOne"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Dch宿泊利用台帳AsOne() {
            Dch宿泊利用台帳CQ cq = ConditionQueryDch宿泊利用台帳AsOne;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("id", "客室利用台帳id");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathDch宿泊利用台帳AsOne() {
            return resolveNextRelationPath("dch客室利用台帳", "dch宿泊利用台帳AsOne");
        }
        public bool hasConditionQueryDch宿泊利用台帳AsOne() {
            return _conditionQueryDch宿泊利用台帳AsOne != null;
        }

	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Dch客室利用台帳CQ> _scalarSubQueryMap;
	    public Map<String, Dch客室利用台帳CQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Dch客室利用台帳CQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Dch客室利用台帳CQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Dch客室利用台帳CQ> _myselfInScopeSubQueryMap;
        public Map<String, Dch客室利用台帳CQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Dch客室利用台帳CQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Dch客室利用台帳CQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
