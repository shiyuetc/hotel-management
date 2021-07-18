
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMst会員マスタCQ : AbstractBsMst会員マスタCQ {

        protected Mst会員マスタCIQ _inlineQuery;

        public BsMst会員マスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Mst会員マスタCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Mst会員マスタCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Mst会員マスタCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Mst会員マスタCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        public BsMst会員マスタCQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsMst会員マスタCQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _会員番号;
        public ConditionValue 会員番号 {
            get { if (_会員番号 == null) { _会員番号 = new ConditionValue(); } return _会員番号; }
        }
        protected override ConditionValue getCValue会員番号() { return this.会員番号; }


        public BsMst会員マスタCQ AddOrderBy_会員番号_Asc() { regOBA("会員番号");return this; }
        public BsMst会員マスタCQ AddOrderBy_会員番号_Desc() { regOBD("会員番号");return this; }

        protected ConditionValue _氏名姓;
        public ConditionValue 氏名姓 {
            get { if (_氏名姓 == null) { _氏名姓 = new ConditionValue(); } return _氏名姓; }
        }
        protected override ConditionValue getCValue氏名姓() { return this.氏名姓; }


        public BsMst会員マスタCQ AddOrderBy_氏名姓_Asc() { regOBA("氏名_姓");return this; }
        public BsMst会員マスタCQ AddOrderBy_氏名姓_Desc() { regOBD("氏名_姓");return this; }

        protected ConditionValue _氏名名;
        public ConditionValue 氏名名 {
            get { if (_氏名名 == null) { _氏名名 = new ConditionValue(); } return _氏名名; }
        }
        protected override ConditionValue getCValue氏名名() { return this.氏名名; }


        public BsMst会員マスタCQ AddOrderBy_氏名名_Asc() { regOBA("氏名_名");return this; }
        public BsMst会員マスタCQ AddOrderBy_氏名名_Desc() { regOBD("氏名_名");return this; }

        protected ConditionValue _氏名カナ;
        public ConditionValue 氏名カナ {
            get { if (_氏名カナ == null) { _氏名カナ = new ConditionValue(); } return _氏名カナ; }
        }
        protected override ConditionValue getCValue氏名カナ() { return this.氏名カナ; }


        public BsMst会員マスタCQ AddOrderBy_氏名カナ_Asc() { regOBA("氏名_カナ");return this; }
        public BsMst会員マスタCQ AddOrderBy_氏名カナ_Desc() { regOBD("氏名_カナ");return this; }

        protected ConditionValue _会社名;
        public ConditionValue 会社名 {
            get { if (_会社名 == null) { _会社名 = new ConditionValue(); } return _会社名; }
        }
        protected override ConditionValue getCValue会社名() { return this.会社名; }


        public BsMst会員マスタCQ AddOrderBy_会社名_Asc() { regOBA("会社名");return this; }
        public BsMst会員マスタCQ AddOrderBy_会社名_Desc() { regOBD("会社名");return this; }

        protected ConditionValue _会社名カナ;
        public ConditionValue 会社名カナ {
            get { if (_会社名カナ == null) { _会社名カナ = new ConditionValue(); } return _会社名カナ; }
        }
        protected override ConditionValue getCValue会社名カナ() { return this.会社名カナ; }


        public BsMst会員マスタCQ AddOrderBy_会社名カナ_Asc() { regOBA("会社名_カナ");return this; }
        public BsMst会員マスタCQ AddOrderBy_会社名カナ_Desc() { regOBD("会社名_カナ");return this; }

        protected ConditionValue _電話番号;
        public ConditionValue 電話番号 {
            get { if (_電話番号 == null) { _電話番号 = new ConditionValue(); } return _電話番号; }
        }
        protected override ConditionValue getCValue電話番号() { return this.電話番号; }


        public BsMst会員マスタCQ AddOrderBy_電話番号_Asc() { regOBA("電話番号");return this; }
        public BsMst会員マスタCQ AddOrderBy_電話番号_Desc() { regOBD("電話番号");return this; }

        protected ConditionValue _メールアドレス;
        public ConditionValue メールアドレス {
            get { if (_メールアドレス == null) { _メールアドレス = new ConditionValue(); } return _メールアドレス; }
        }
        protected override ConditionValue getCValueメールアドレス() { return this.メールアドレス; }


        public BsMst会員マスタCQ AddOrderBy_メールアドレス_Asc() { regOBA("メールアドレス");return this; }
        public BsMst会員マスタCQ AddOrderBy_メールアドレス_Desc() { regOBD("メールアドレス");return this; }

        protected ConditionValue _入会年月日;
        public ConditionValue 入会年月日 {
            get { if (_入会年月日 == null) { _入会年月日 = new ConditionValue(); } return _入会年月日; }
        }
        protected override ConditionValue getCValue入会年月日() { return this.入会年月日; }


        public BsMst会員マスタCQ AddOrderBy_入会年月日_Asc() { regOBA("入会年月日");return this; }
        public BsMst会員マスタCQ AddOrderBy_入会年月日_Desc() { regOBD("入会年月日");return this; }

        protected ConditionValue _退会年月日;
        public ConditionValue 退会年月日 {
            get { if (_退会年月日 == null) { _退会年月日 = new ConditionValue(); } return _退会年月日; }
        }
        protected override ConditionValue getCValue退会年月日() { return this.退会年月日; }


        public BsMst会員マスタCQ AddOrderBy_退会年月日_Asc() { regOBA("退会年月日");return this; }
        public BsMst会員マスタCQ AddOrderBy_退会年月日_Desc() { regOBD("退会年月日");return this; }

        protected ConditionValue _備考;
        public ConditionValue 備考 {
            get { if (_備考 == null) { _備考 = new ConditionValue(); } return _備考; }
        }
        protected override ConditionValue getCValue備考() { return this.備考; }


        public BsMst会員マスタCQ AddOrderBy_備考_Asc() { regOBA("備考");return this; }
        public BsMst会員マスタCQ AddOrderBy_備考_Desc() { regOBD("備考");return this; }

        public BsMst会員マスタCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMst会員マスタCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Mst会員マスタCQ> _scalarSubQueryMap;
	    public Map<String, Mst会員マスタCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Mst会員マスタCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Mst会員マスタCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Mst会員マスタCQ> _myselfInScopeSubQueryMap;
        public Map<String, Mst会員マスタCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Mst会員マスタCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Mst会員マスタCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
