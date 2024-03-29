
using System;
using System.Collections.Generic;

using Dbflute.AllCommon;
using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CKey;
using Dbflute.AllCommon.CBean.COption;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public abstract class AbstractBsMst従業員マスタCQ : AbstractConditionQuery {

        public AbstractBsMst従業員マスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "mst従業員マスタ"; }
        public override String getTableSqlName() { return "mst従業員マスタ"; }

        public void Set従業員コード_Equal(String v) { DoSet従業員コード_Equal(fRES(v)); }
        protected void DoSet従業員コード_Equal(String v) { reg従業員コード(CK_EQ, v); }
        public void Set従業員コード_NotEqual(String v) { DoSet従業員コード_NotEqual(fRES(v)); }
        protected void DoSet従業員コード_NotEqual(String v) { reg従業員コード(CK_NES, v); }
        public void Set従業員コード_GreaterThan(String v) { reg従業員コード(CK_GT, fRES(v)); }
        public void Set従業員コード_LessThan(String v) { reg従業員コード(CK_LT, fRES(v)); }
        public void Set従業員コード_GreaterEqual(String v) { reg従業員コード(CK_GE, fRES(v)); }
        public void Set従業員コード_LessEqual(String v) { reg従業員コード(CK_LE, fRES(v)); }
        public void Set従業員コード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue従業員コード(), "従業員コード"); }
        public void Set従業員コード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue従業員コード(), "従業員コード"); }
        public void Set従業員コード_PrefixSearch(String v) { Set従業員コード_LikeSearch(v, cLSOP()); }
        public void Set従業員コード_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue従業員コード(), "従業員コード", option); }
        public void Set従業員コード_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue従業員コード(), "従業員コード", option); }
        public void ExistsDch従業員職位履歴台帳List(SubQuery<Dch従業員職位履歴台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep従業員コード_ExistsSubQuery_Dch従業員職位履歴台帳List(cb.Query());
            registerExistsSubQuery(cb.Query(), "従業員コード", "従業員コード", subQueryPropertyName);
        }
        public abstract String keep従業員コード_ExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public void NotExistsDch従業員職位履歴台帳List(SubQuery<Dch従業員職位履歴台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep従業員コード_NotExistsSubQuery_Dch従業員職位履歴台帳List(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "従業員コード", "従業員コード", subQueryPropertyName);
        }
        public abstract String keep従業員コード_NotExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public void InScopeDch従業員職位履歴台帳List(SubQuery<Dch従業員職位履歴台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep従業員コード_InScopeSubQuery_Dch従業員職位履歴台帳List(cb.Query());
            registerInScopeSubQuery(cb.Query(), "従業員コード", "従業員コード", subQueryPropertyName);
        }
        public abstract String keep従業員コード_InScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public void NotInScopeDch従業員職位履歴台帳List(SubQuery<Dch従業員職位履歴台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep従業員コード_NotInScopeSubQuery_Dch従業員職位履歴台帳List(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "従業員コード", "従業員コード", subQueryPropertyName);
        }
        public abstract String keep従業員コード_NotInScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public void xsderiveDch従業員職位履歴台帳List(String function, SubQuery<Dch従業員職位履歴台帳CB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep従業員コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "従業員コード", "従業員コード", subQueryPropertyName, aliasName);
        }
        abstract public String keep従業員コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);

        public QDRFunction<Dch従業員職位履歴台帳CB> DerivedDch従業員職位履歴台帳List() {
            return xcreateQDRFunctionDch従業員職位履歴台帳List();
        }
        protected QDRFunction<Dch従業員職位履歴台帳CB> xcreateQDRFunctionDch従業員職位履歴台帳List() {
            return new QDRFunction<Dch従業員職位履歴台帳CB>(delegate(String function, SubQuery<Dch従業員職位履歴台帳CB> subQuery, String operand, Object value) {
                xqderiveDch従業員職位履歴台帳List(function, subQuery, operand, value);
            });
        }
        public void xqderiveDch従業員職位履歴台帳List(String function, SubQuery<Dch従業員職位履歴台帳CB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳List(cb.Query()); // for saving query-value.
            String parameterPropertyName = keep従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "従業員コード", "従業員コード", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keep従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public abstract String keep従業員コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter(Object parameterValue);
        public void Set従業員コード_IsNull() { reg従業員コード(CK_ISN, DUMMY_OBJECT); }
        public void Set従業員コード_IsNotNull() { reg従業員コード(CK_ISNN, DUMMY_OBJECT); }
        protected void reg従業員コード(ConditionKey k, Object v) { regQ(k, v, getCValue従業員コード(), "従業員コード"); }
        protected abstract ConditionValue getCValue従業員コード();

        public void Set従業員番号_Equal(String v) { DoSet従業員番号_Equal(fRES(v)); }
        protected void DoSet従業員番号_Equal(String v) { reg従業員番号(CK_EQ, v); }
        public void Set従業員番号_NotEqual(String v) { DoSet従業員番号_NotEqual(fRES(v)); }
        protected void DoSet従業員番号_NotEqual(String v) { reg従業員番号(CK_NES, v); }
        public void Set従業員番号_GreaterThan(String v) { reg従業員番号(CK_GT, fRES(v)); }
        public void Set従業員番号_LessThan(String v) { reg従業員番号(CK_LT, fRES(v)); }
        public void Set従業員番号_GreaterEqual(String v) { reg従業員番号(CK_GE, fRES(v)); }
        public void Set従業員番号_LessEqual(String v) { reg従業員番号(CK_LE, fRES(v)); }
        public void Set従業員番号_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue従業員番号(), "従業員番号"); }
        public void Set従業員番号_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue従業員番号(), "従業員番号"); }
        public void Set従業員番号_PrefixSearch(String v) { Set従業員番号_LikeSearch(v, cLSOP()); }
        public void Set従業員番号_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue従業員番号(), "従業員番号", option); }
        public void Set従業員番号_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue従業員番号(), "従業員番号", option); }
        protected void reg従業員番号(ConditionKey k, Object v) { regQ(k, v, getCValue従業員番号(), "従業員番号"); }
        protected abstract ConditionValue getCValue従業員番号();

        public void Set名字_Equal(String v) { DoSet名字_Equal(fRES(v)); }
        protected void DoSet名字_Equal(String v) { reg名字(CK_EQ, v); }
        public void Set名字_NotEqual(String v) { DoSet名字_NotEqual(fRES(v)); }
        protected void DoSet名字_NotEqual(String v) { reg名字(CK_NES, v); }
        public void Set名字_GreaterThan(String v) { reg名字(CK_GT, fRES(v)); }
        public void Set名字_LessThan(String v) { reg名字(CK_LT, fRES(v)); }
        public void Set名字_GreaterEqual(String v) { reg名字(CK_GE, fRES(v)); }
        public void Set名字_LessEqual(String v) { reg名字(CK_LE, fRES(v)); }
        public void Set名字_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue名字(), "名字"); }
        public void Set名字_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue名字(), "名字"); }
        public void Set名字_PrefixSearch(String v) { Set名字_LikeSearch(v, cLSOP()); }
        public void Set名字_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue名字(), "名字", option); }
        public void Set名字_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue名字(), "名字", option); }
        protected void reg名字(ConditionKey k, Object v) { regQ(k, v, getCValue名字(), "名字"); }
        protected abstract ConditionValue getCValue名字();

        public void Set名前_Equal(String v) { DoSet名前_Equal(fRES(v)); }
        protected void DoSet名前_Equal(String v) { reg名前(CK_EQ, v); }
        public void Set名前_NotEqual(String v) { DoSet名前_NotEqual(fRES(v)); }
        protected void DoSet名前_NotEqual(String v) { reg名前(CK_NES, v); }
        public void Set名前_GreaterThan(String v) { reg名前(CK_GT, fRES(v)); }
        public void Set名前_LessThan(String v) { reg名前(CK_LT, fRES(v)); }
        public void Set名前_GreaterEqual(String v) { reg名前(CK_GE, fRES(v)); }
        public void Set名前_LessEqual(String v) { reg名前(CK_LE, fRES(v)); }
        public void Set名前_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue名前(), "名前"); }
        public void Set名前_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue名前(), "名前"); }
        public void Set名前_PrefixSearch(String v) { Set名前_LikeSearch(v, cLSOP()); }
        public void Set名前_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue名前(), "名前", option); }
        public void Set名前_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue名前(), "名前", option); }
        protected void reg名前(ConditionKey k, Object v) { regQ(k, v, getCValue名前(), "名前"); }
        protected abstract ConditionValue getCValue名前();

        public void Set氏名カナ_Equal(String v) { DoSet氏名カナ_Equal(fRES(v)); }
        protected void DoSet氏名カナ_Equal(String v) { reg氏名カナ(CK_EQ, v); }
        public void Set氏名カナ_NotEqual(String v) { DoSet氏名カナ_NotEqual(fRES(v)); }
        protected void DoSet氏名カナ_NotEqual(String v) { reg氏名カナ(CK_NES, v); }
        public void Set氏名カナ_GreaterThan(String v) { reg氏名カナ(CK_GT, fRES(v)); }
        public void Set氏名カナ_LessThan(String v) { reg氏名カナ(CK_LT, fRES(v)); }
        public void Set氏名カナ_GreaterEqual(String v) { reg氏名カナ(CK_GE, fRES(v)); }
        public void Set氏名カナ_LessEqual(String v) { reg氏名カナ(CK_LE, fRES(v)); }
        public void Set氏名カナ_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue氏名カナ(), "氏名カナ"); }
        public void Set氏名カナ_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue氏名カナ(), "氏名カナ"); }
        public void Set氏名カナ_PrefixSearch(String v) { Set氏名カナ_LikeSearch(v, cLSOP()); }
        public void Set氏名カナ_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue氏名カナ(), "氏名カナ", option); }
        public void Set氏名カナ_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue氏名カナ(), "氏名カナ", option); }
        protected void reg氏名カナ(ConditionKey k, Object v) { regQ(k, v, getCValue氏名カナ(), "氏名カナ"); }
        protected abstract ConditionValue getCValue氏名カナ();

        public void Setメールアドレス_Equal(String v) { DoSetメールアドレス_Equal(fRES(v)); }
        protected void DoSetメールアドレス_Equal(String v) { regメールアドレス(CK_EQ, v); }
        public void Setメールアドレス_NotEqual(String v) { DoSetメールアドレス_NotEqual(fRES(v)); }
        protected void DoSetメールアドレス_NotEqual(String v) { regメールアドレス(CK_NES, v); }
        public void Setメールアドレス_GreaterThan(String v) { regメールアドレス(CK_GT, fRES(v)); }
        public void Setメールアドレス_LessThan(String v) { regメールアドレス(CK_LT, fRES(v)); }
        public void Setメールアドレス_GreaterEqual(String v) { regメールアドレス(CK_GE, fRES(v)); }
        public void Setメールアドレス_LessEqual(String v) { regメールアドレス(CK_LE, fRES(v)); }
        public void Setメールアドレス_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueメールアドレス(), "メールアドレス"); }
        public void Setメールアドレス_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueメールアドレス(), "メールアドレス"); }
        public void Setメールアドレス_PrefixSearch(String v) { Setメールアドレス_LikeSearch(v, cLSOP()); }
        public void Setメールアドレス_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueメールアドレス(), "メールアドレス", option); }
        public void Setメールアドレス_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueメールアドレス(), "メールアドレス", option); }
        public void Setメールアドレス_IsNull() { regメールアドレス(CK_ISN, DUMMY_OBJECT); }
        public void Setメールアドレス_IsNotNull() { regメールアドレス(CK_ISNN, DUMMY_OBJECT); }
        protected void regメールアドレス(ConditionKey k, Object v) { regQ(k, v, getCValueメールアドレス(), "メールアドレス"); }
        protected abstract ConditionValue getCValueメールアドレス();

        public void Setパスワード_Equal(String v) { DoSetパスワード_Equal(fRES(v)); }
        protected void DoSetパスワード_Equal(String v) { regパスワード(CK_EQ, v); }
        public void Setパスワード_NotEqual(String v) { DoSetパスワード_NotEqual(fRES(v)); }
        protected void DoSetパスワード_NotEqual(String v) { regパスワード(CK_NES, v); }
        public void Setパスワード_GreaterThan(String v) { regパスワード(CK_GT, fRES(v)); }
        public void Setパスワード_LessThan(String v) { regパスワード(CK_LT, fRES(v)); }
        public void Setパスワード_GreaterEqual(String v) { regパスワード(CK_GE, fRES(v)); }
        public void Setパスワード_LessEqual(String v) { regパスワード(CK_LE, fRES(v)); }
        public void Setパスワード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueパスワード(), "パスワード"); }
        public void Setパスワード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueパスワード(), "パスワード"); }
        public void Setパスワード_PrefixSearch(String v) { Setパスワード_LikeSearch(v, cLSOP()); }
        public void Setパスワード_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueパスワード(), "パスワード", option); }
        public void Setパスワード_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueパスワード(), "パスワード", option); }
        protected void regパスワード(ConditionKey k, Object v) { regQ(k, v, getCValueパスワード(), "パスワード"); }
        protected abstract ConditionValue getCValueパスワード();

        public void Set生年月日_Equal(DateTime? v) { reg生年月日(CK_EQ, v); }
        public void Set生年月日_GreaterThan(DateTime? v) { reg生年月日(CK_GT, v); }
        public void Set生年月日_LessThan(DateTime? v) { reg生年月日(CK_LT, v); }
        public void Set生年月日_GreaterEqual(DateTime? v) { reg生年月日(CK_GE, v); }
        public void Set生年月日_LessEqual(DateTime? v) { reg生年月日(CK_LE, v); }
        public void Set生年月日_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValue生年月日(), "生年月日", option); }
        public void Set生年月日_DateFromTo(DateTime? from, DateTime? to) { Set生年月日_FromTo(from, to, new DateFromToOption()); }
        protected void reg生年月日(ConditionKey k, Object v) { regQ(k, v, getCValue生年月日(), "生年月日"); }
        protected abstract ConditionValue getCValue生年月日();

        public void Set入社年月日_Equal(DateTime? v) { reg入社年月日(CK_EQ, v); }
        public void Set入社年月日_GreaterThan(DateTime? v) { reg入社年月日(CK_GT, v); }
        public void Set入社年月日_LessThan(DateTime? v) { reg入社年月日(CK_LT, v); }
        public void Set入社年月日_GreaterEqual(DateTime? v) { reg入社年月日(CK_GE, v); }
        public void Set入社年月日_LessEqual(DateTime? v) { reg入社年月日(CK_LE, v); }
        public void Set入社年月日_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValue入社年月日(), "入社年月日", option); }
        public void Set入社年月日_DateFromTo(DateTime? from, DateTime? to) { Set入社年月日_FromTo(from, to, new DateFromToOption()); }
        protected void reg入社年月日(ConditionKey k, Object v) { regQ(k, v, getCValue入社年月日(), "入社年月日"); }
        protected abstract ConditionValue getCValue入社年月日();

        public void Set退社年月日_Equal(DateTime? v) { reg退社年月日(CK_EQ, v); }
        public void Set退社年月日_GreaterThan(DateTime? v) { reg退社年月日(CK_GT, v); }
        public void Set退社年月日_LessThan(DateTime? v) { reg退社年月日(CK_LT, v); }
        public void Set退社年月日_GreaterEqual(DateTime? v) { reg退社年月日(CK_GE, v); }
        public void Set退社年月日_LessEqual(DateTime? v) { reg退社年月日(CK_LE, v); }
        public void Set退社年月日_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValue退社年月日(), "退社年月日", option); }
        public void Set退社年月日_DateFromTo(DateTime? from, DateTime? to) { Set退社年月日_FromTo(from, to, new DateFromToOption()); }
        public void Set退社年月日_IsNull() { reg退社年月日(CK_ISN, DUMMY_OBJECT); }
        public void Set退社年月日_IsNotNull() { reg退社年月日(CK_ISNN, DUMMY_OBJECT); }
        protected void reg退社年月日(ConditionKey k, Object v) { regQ(k, v, getCValue退社年月日(), "退社年月日"); }
        protected abstract ConditionValue getCValue退社年月日();

        public void Set職位コード_Equal(String v) { DoSet職位コード_Equal(fRES(v)); }
        /// <summary>
        /// Set the value of システム保守 of 職位コード as equal. { = }
        /// システム保守: System Maintenancer
        /// </summary>
        public void Set職位コード_Equal_システム保守() {
            DoSet職位コード_Equal(CDef.職位区分.システム保守.Code);
        }
        /// <summary>
        /// Set the value of アシスタントマネージャー of 職位コード as equal. { = }
        /// アシスタントマネージャー: Assistant Manager
        /// </summary>
        public void Set職位コード_Equal_アシスタントマネージャー() {
            DoSet職位コード_Equal(CDef.職位区分.アシスタントマネージャー.Code);
        }
        /// <summary>
        /// Set the value of ファイナンシャルコントローラー of 職位コード as equal. { = }
        /// ファイナンシャルコントローラー: Financial Controller
        /// </summary>
        public void Set職位コード_Equal_ファイナンシャルコントローラー() {
            DoSet職位コード_Equal(CDef.職位区分.ファイナンシャルコントローラー.Code);
        }
        /// <summary>
        /// Set the value of フロントクラーク of 職位コード as equal. { = }
        /// フロントクラーク: Front Clerk
        /// </summary>
        public void Set職位コード_Equal_フロントクラーク() {
            DoSet職位コード_Equal(CDef.職位区分.フロントクラーク.Code);
        }
        protected void DoSet職位コード_Equal(String v) { reg職位コード(CK_EQ, v); }
        public void Set職位コード_NotEqual(String v) { DoSet職位コード_NotEqual(fRES(v)); }
        /// <summary>
        /// Set the value of システム保守 of 職位コード as notEqual. { &lt;&gt; }
        /// システム保守: System Maintenancer
        /// </summary>
        public void Set職位コード_NotEqual_システム保守() {
            DoSet職位コード_NotEqual(CDef.職位区分.システム保守.Code);
        }
        /// <summary>
        /// Set the value of アシスタントマネージャー of 職位コード as notEqual. { &lt;&gt; }
        /// アシスタントマネージャー: Assistant Manager
        /// </summary>
        public void Set職位コード_NotEqual_アシスタントマネージャー() {
            DoSet職位コード_NotEqual(CDef.職位区分.アシスタントマネージャー.Code);
        }
        /// <summary>
        /// Set the value of ファイナンシャルコントローラー of 職位コード as notEqual. { &lt;&gt; }
        /// ファイナンシャルコントローラー: Financial Controller
        /// </summary>
        public void Set職位コード_NotEqual_ファイナンシャルコントローラー() {
            DoSet職位コード_NotEqual(CDef.職位区分.ファイナンシャルコントローラー.Code);
        }
        /// <summary>
        /// Set the value of フロントクラーク of 職位コード as notEqual. { &lt;&gt; }
        /// フロントクラーク: Front Clerk
        /// </summary>
        public void Set職位コード_NotEqual_フロントクラーク() {
            DoSet職位コード_NotEqual(CDef.職位区分.フロントクラーク.Code);
        }
        protected void DoSet職位コード_NotEqual(String v) { reg職位コード(CK_NES, v); }
        public void Set職位コード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue職位コード(), "職位コード"); }
        public void Set職位コード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue職位コード(), "職位コード"); }
        public void InScopeKbn職位区分(SubQuery<Kbn職位区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbn職位区分CB>", subQuery);
            Kbn職位区分CB cb = new Kbn職位区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_InScopeSubQuery_Kbn職位区分(cb.Query());
            registerInScopeSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_InScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery);
        public void NotInScopeKbn職位区分(SubQuery<Kbn職位区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbn職位区分CB>", subQuery);
            Kbn職位区分CB cb = new Kbn職位区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_NotInScopeSubQuery_Kbn職位区分(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_NotInScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery);
        protected void reg職位コード(ConditionKey k, Object v) { regQ(k, v, getCValue職位コード(), "職位コード"); }
        protected abstract ConditionValue getCValue職位コード();

        public void Set最終ログイン日時_Equal(DateTime? v) { reg最終ログイン日時(CK_EQ, v); }
        public void Set最終ログイン日時_GreaterThan(DateTime? v) { reg最終ログイン日時(CK_GT, v); }
        public void Set最終ログイン日時_LessThan(DateTime? v) { reg最終ログイン日時(CK_LT, v); }
        public void Set最終ログイン日時_GreaterEqual(DateTime? v) { reg最終ログイン日時(CK_GE, v); }
        public void Set最終ログイン日時_LessEqual(DateTime? v) { reg最終ログイン日時(CK_LE, v); }
        public void Set最終ログイン日時_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValue最終ログイン日時(), "最終ログイン日時", option); }
        public void Set最終ログイン日時_DateFromTo(DateTime? from, DateTime? to) { Set最終ログイン日時_FromTo(from, to, new DateFromToOption()); }
        public void Set最終ログイン日時_IsNull() { reg最終ログイン日時(CK_ISN, DUMMY_OBJECT); }
        public void Set最終ログイン日時_IsNotNull() { reg最終ログイン日時(CK_ISNN, DUMMY_OBJECT); }
        protected void reg最終ログイン日時(ConditionKey k, Object v) { regQ(k, v, getCValue最終ログイン日時(), "最終ログイン日時"); }
        protected abstract ConditionValue getCValue最終ログイン日時();

        public void Set備考_Equal(String v) { DoSet備考_Equal(fRES(v)); }
        protected void DoSet備考_Equal(String v) { reg備考(CK_EQ, v); }
        public void Set備考_NotEqual(String v) { DoSet備考_NotEqual(fRES(v)); }
        protected void DoSet備考_NotEqual(String v) { reg備考(CK_NES, v); }
        public void Set備考_GreaterThan(String v) { reg備考(CK_GT, fRES(v)); }
        public void Set備考_LessThan(String v) { reg備考(CK_LT, fRES(v)); }
        public void Set備考_GreaterEqual(String v) { reg備考(CK_GE, fRES(v)); }
        public void Set備考_LessEqual(String v) { reg備考(CK_LE, fRES(v)); }
        public void Set備考_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue備考(), "備考"); }
        public void Set備考_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue備考(), "備考"); }
        public void Set備考_PrefixSearch(String v) { Set備考_LikeSearch(v, cLSOP()); }
        public void Set備考_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue備考(), "備考", option); }
        public void Set備考_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue備考(), "備考", option); }
        public void Set備考_IsNull() { reg備考(CK_ISN, DUMMY_OBJECT); }
        public void Set備考_IsNotNull() { reg備考(CK_ISNN, DUMMY_OBJECT); }
        protected void reg備考(ConditionKey k, Object v) { regQ(k, v, getCValue備考(), "備考"); }
        protected abstract ConditionValue getCValue備考();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<Mst従業員マスタCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Mst従業員マスタCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Mst従業員マスタCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Mst従業員マスタCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Mst従業員マスタCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Mst従業員マスタCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Mst従業員マスタCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Mst従業員マスタCB>(delegate(String function, SubQuery<Mst従業員マスタCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Mst従業員マスタCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Mst従業員マスタCB>", subQuery);
            Mst従業員マスタCB cb = new Mst従業員マスタCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Mst従業員マスタCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Mst従業員マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst従業員マスタCB>", subQuery);
            Mst従業員マスタCB cb = new Mst従業員マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "従業員コード", "従業員コード", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Mst従業員マスタCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
