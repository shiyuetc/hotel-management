
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMst従業員マスタCQ : AbstractBsMst従業員マスタCQ {

        protected Mst従業員マスタCIQ _inlineQuery;

        public BsMst従業員マスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Mst従業員マスタCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Mst従業員マスタCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Mst従業員マスタCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Mst従業員マスタCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _従業員コード;
        public ConditionValue 従業員コード {
            get { if (_従業員コード == null) { _従業員コード = new ConditionValue(); } return _従業員コード; }
        }
        protected override ConditionValue getCValue従業員コード() { return this.従業員コード; }


        protected Map<String, Dch従業員職位履歴台帳CQ> _従業員コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> 従業員コード_ExistsSubQuery_Dch従業員職位履歴台帳List { get { return _従業員コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap; }}
        public override String keep従業員コード_ExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_従業員コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap == null) { _従業員コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_従業員コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap.size() + 1);
            _従業員コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "従業員コード_ExistsSubQuery_Dch従業員職位履歴台帳List." + key;
        }

        protected Map<String, Dch従業員職位履歴台帳CQ> _従業員コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> 従業員コード_NotExistsSubQuery_Dch従業員職位履歴台帳List { get { return _従業員コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap; }}
        public override String keep従業員コード_NotExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_従業員コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap == null) { _従業員コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_従業員コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap.size() + 1);
            _従業員コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "従業員コード_NotExistsSubQuery_Dch従業員職位履歴台帳List." + key;
        }

        protected Map<String, Dch従業員職位履歴台帳CQ> _従業員コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> 従業員コード_InScopeSubQuery_Dch従業員職位履歴台帳List { get { return _従業員コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap; }}
        public override String keep従業員コード_InScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_従業員コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap == null) { _従業員コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_従業員コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap.size() + 1);
            _従業員コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "従業員コード_InScopeSubQuery_Dch従業員職位履歴台帳List." + key;
        }

        protected Map<String, Dch従業員職位履歴台帳CQ> _従業員コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> 従業員コード_NotInScopeSubQuery_Dch従業員職位履歴台帳List { get { return _従業員コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap; }}
        public override String keep従業員コード_NotInScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_従業員コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap == null) { _従業員コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_従業員コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap.size() + 1);
            _従業員コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "従業員コード_NotInScopeSubQuery_Dch従業員職位履歴台帳List." + key;
        }

        protected Map<String, Dch従業員職位履歴台帳CQ> _従業員コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> 従業員コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List { get { return _従業員コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap; }}
        public override String keep従業員コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_従業員コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap == null) { _従業員コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_従業員コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap.size() + 1);
           _従業員コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "従業員コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List." + key;
        }

        protected Map<String, Dch従業員職位履歴台帳CQ> _従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> 従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳List { get { return _従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap; } }
        public override String keep従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap == null) { _従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap.size() + 1);
            _従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳List." + key;
        }
        protected Map<String, Object> _従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap;
        public Map<String, Object> 従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter { get { return _従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap; } }
        public override String keep従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter(Object parameterValue) {
            if (_従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap == null) { _従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap.size() + 1);
            _従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap.put(key, parameterValue); return "従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter." + key;
        }

        public BsMst従業員マスタCQ AddOrderBy_従業員コード_Asc() { regOBA("従業員コード");return this; }
        public BsMst従業員マスタCQ AddOrderBy_従業員コード_Desc() { regOBD("従業員コード");return this; }

        protected ConditionValue _従業員番号;
        public ConditionValue 従業員番号 {
            get { if (_従業員番号 == null) { _従業員番号 = new ConditionValue(); } return _従業員番号; }
        }
        protected override ConditionValue getCValue従業員番号() { return this.従業員番号; }


        public BsMst従業員マスタCQ AddOrderBy_従業員番号_Asc() { regOBA("従業員番号");return this; }
        public BsMst従業員マスタCQ AddOrderBy_従業員番号_Desc() { regOBD("従業員番号");return this; }

        protected ConditionValue _名字;
        public ConditionValue 名字 {
            get { if (_名字 == null) { _名字 = new ConditionValue(); } return _名字; }
        }
        protected override ConditionValue getCValue名字() { return this.名字; }


        public BsMst従業員マスタCQ AddOrderBy_名字_Asc() { regOBA("名字");return this; }
        public BsMst従業員マスタCQ AddOrderBy_名字_Desc() { regOBD("名字");return this; }

        protected ConditionValue _名前;
        public ConditionValue 名前 {
            get { if (_名前 == null) { _名前 = new ConditionValue(); } return _名前; }
        }
        protected override ConditionValue getCValue名前() { return this.名前; }


        public BsMst従業員マスタCQ AddOrderBy_名前_Asc() { regOBA("名前");return this; }
        public BsMst従業員マスタCQ AddOrderBy_名前_Desc() { regOBD("名前");return this; }

        protected ConditionValue _氏名カナ;
        public ConditionValue 氏名カナ {
            get { if (_氏名カナ == null) { _氏名カナ = new ConditionValue(); } return _氏名カナ; }
        }
        protected override ConditionValue getCValue氏名カナ() { return this.氏名カナ; }


        public BsMst従業員マスタCQ AddOrderBy_氏名カナ_Asc() { regOBA("氏名カナ");return this; }
        public BsMst従業員マスタCQ AddOrderBy_氏名カナ_Desc() { regOBD("氏名カナ");return this; }

        protected ConditionValue _メールアドレス;
        public ConditionValue メールアドレス {
            get { if (_メールアドレス == null) { _メールアドレス = new ConditionValue(); } return _メールアドレス; }
        }
        protected override ConditionValue getCValueメールアドレス() { return this.メールアドレス; }


        public BsMst従業員マスタCQ AddOrderBy_メールアドレス_Asc() { regOBA("メールアドレス");return this; }
        public BsMst従業員マスタCQ AddOrderBy_メールアドレス_Desc() { regOBD("メールアドレス");return this; }

        protected ConditionValue _パスワード;
        public ConditionValue パスワード {
            get { if (_パスワード == null) { _パスワード = new ConditionValue(); } return _パスワード; }
        }
        protected override ConditionValue getCValueパスワード() { return this.パスワード; }


        public BsMst従業員マスタCQ AddOrderBy_パスワード_Asc() { regOBA("パスワード");return this; }
        public BsMst従業員マスタCQ AddOrderBy_パスワード_Desc() { regOBD("パスワード");return this; }

        protected ConditionValue _生年月日;
        public ConditionValue 生年月日 {
            get { if (_生年月日 == null) { _生年月日 = new ConditionValue(); } return _生年月日; }
        }
        protected override ConditionValue getCValue生年月日() { return this.生年月日; }


        public BsMst従業員マスタCQ AddOrderBy_生年月日_Asc() { regOBA("生年月日");return this; }
        public BsMst従業員マスタCQ AddOrderBy_生年月日_Desc() { regOBD("生年月日");return this; }

        protected ConditionValue _入社年月日;
        public ConditionValue 入社年月日 {
            get { if (_入社年月日 == null) { _入社年月日 = new ConditionValue(); } return _入社年月日; }
        }
        protected override ConditionValue getCValue入社年月日() { return this.入社年月日; }


        public BsMst従業員マスタCQ AddOrderBy_入社年月日_Asc() { regOBA("入社年月日");return this; }
        public BsMst従業員マスタCQ AddOrderBy_入社年月日_Desc() { regOBD("入社年月日");return this; }

        protected ConditionValue _退社年月日;
        public ConditionValue 退社年月日 {
            get { if (_退社年月日 == null) { _退社年月日 = new ConditionValue(); } return _退社年月日; }
        }
        protected override ConditionValue getCValue退社年月日() { return this.退社年月日; }


        public BsMst従業員マスタCQ AddOrderBy_退社年月日_Asc() { regOBA("退社年月日");return this; }
        public BsMst従業員マスタCQ AddOrderBy_退社年月日_Desc() { regOBD("退社年月日");return this; }

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

        public BsMst従業員マスタCQ AddOrderBy_職位コード_Asc() { regOBA("職位コード");return this; }
        public BsMst従業員マスタCQ AddOrderBy_職位コード_Desc() { regOBD("職位コード");return this; }

        protected ConditionValue _最終ログイン日時;
        public ConditionValue 最終ログイン日時 {
            get { if (_最終ログイン日時 == null) { _最終ログイン日時 = new ConditionValue(); } return _最終ログイン日時; }
        }
        protected override ConditionValue getCValue最終ログイン日時() { return this.最終ログイン日時; }


        public BsMst従業員マスタCQ AddOrderBy_最終ログイン日時_Asc() { regOBA("最終ログイン日時");return this; }
        public BsMst従業員マスタCQ AddOrderBy_最終ログイン日時_Desc() { regOBD("最終ログイン日時");return this; }

        protected ConditionValue _備考;
        public ConditionValue 備考 {
            get { if (_備考 == null) { _備考 = new ConditionValue(); } return _備考; }
        }
        protected override ConditionValue getCValue備考() { return this.備考; }


        public BsMst従業員マスタCQ AddOrderBy_備考_Asc() { regOBA("備考");return this; }
        public BsMst従業員マスタCQ AddOrderBy_備考_Desc() { regOBD("備考");return this; }

        public BsMst従業員マスタCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMst従業員マスタCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            Mst従業員マスタCQ baseQuery = (Mst従業員マスタCQ)baseQueryAsSuper;
            Mst従業員マスタCQ unionQuery = (Mst従業員マスタCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryKbn職位区分()) {
                unionQuery.QueryKbn職位区分().reflectRelationOnUnionQuery(baseQuery.QueryKbn職位区分(), unionQuery.QueryKbn職位区分());
            }

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
            return resolveNextRelationPath("mst従業員マスタ", "kbn職位区分");
        }
        public bool hasConditionQueryKbn職位区分() {
            return _conditionQueryKbn職位区分 != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Mst従業員マスタCQ> _scalarSubQueryMap;
	    public Map<String, Mst従業員マスタCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Mst従業員マスタCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Mst従業員マスタCQ> _myselfInScopeSubQueryMap;
        public Map<String, Mst従業員マスタCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Mst従業員マスタCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
