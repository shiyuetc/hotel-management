
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
    public abstract class AbstractBsMst会員マスタCQ : AbstractConditionQuery {

        public AbstractBsMst会員マスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "mst会員マスタ"; }
        public override String getTableSqlName() { return "mst会員マスタ"; }

        public void Set会員コード_Equal(String v) { DoSet会員コード_Equal(fRES(v)); }
        protected void DoSet会員コード_Equal(String v) { reg会員コード(CK_EQ, v); }
        public void Set会員コード_NotEqual(String v) { DoSet会員コード_NotEqual(fRES(v)); }
        protected void DoSet会員コード_NotEqual(String v) { reg会員コード(CK_NES, v); }
        public void Set会員コード_GreaterThan(String v) { reg会員コード(CK_GT, fRES(v)); }
        public void Set会員コード_LessThan(String v) { reg会員コード(CK_LT, fRES(v)); }
        public void Set会員コード_GreaterEqual(String v) { reg会員コード(CK_GE, fRES(v)); }
        public void Set会員コード_LessEqual(String v) { reg会員コード(CK_LE, fRES(v)); }
        public void Set会員コード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue会員コード(), "会員コード"); }
        public void Set会員コード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue会員コード(), "会員コード"); }
        public void Set会員コード_PrefixSearch(String v) { Set会員コード_LikeSearch(v, cLSOP()); }
        public void Set会員コード_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue会員コード(), "会員コード", option); }
        public void Set会員コード_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue会員コード(), "会員コード", option); }
        public void ExistsDch宿泊利用台帳List(SubQuery<Dch宿泊利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch宿泊利用台帳CB>", subQuery);
            Dch宿泊利用台帳CB cb = new Dch宿泊利用台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep会員コード_ExistsSubQuery_Dch宿泊利用台帳List(cb.Query());
            registerExistsSubQuery(cb.Query(), "会員コード", "会員コード", subQueryPropertyName);
        }
        public abstract String keep会員コード_ExistsSubQuery_Dch宿泊利用台帳List(Dch宿泊利用台帳CQ subQuery);
        public void NotExistsDch宿泊利用台帳List(SubQuery<Dch宿泊利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch宿泊利用台帳CB>", subQuery);
            Dch宿泊利用台帳CB cb = new Dch宿泊利用台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep会員コード_NotExistsSubQuery_Dch宿泊利用台帳List(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "会員コード", "会員コード", subQueryPropertyName);
        }
        public abstract String keep会員コード_NotExistsSubQuery_Dch宿泊利用台帳List(Dch宿泊利用台帳CQ subQuery);
        public void InScopeDch宿泊利用台帳List(SubQuery<Dch宿泊利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch宿泊利用台帳CB>", subQuery);
            Dch宿泊利用台帳CB cb = new Dch宿泊利用台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep会員コード_InScopeSubQuery_Dch宿泊利用台帳List(cb.Query());
            registerInScopeSubQuery(cb.Query(), "会員コード", "会員コード", subQueryPropertyName);
        }
        public abstract String keep会員コード_InScopeSubQuery_Dch宿泊利用台帳List(Dch宿泊利用台帳CQ subQuery);
        public void NotInScopeDch宿泊利用台帳List(SubQuery<Dch宿泊利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch宿泊利用台帳CB>", subQuery);
            Dch宿泊利用台帳CB cb = new Dch宿泊利用台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep会員コード_NotInScopeSubQuery_Dch宿泊利用台帳List(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "会員コード", "会員コード", subQueryPropertyName);
        }
        public abstract String keep会員コード_NotInScopeSubQuery_Dch宿泊利用台帳List(Dch宿泊利用台帳CQ subQuery);
        public void xsderiveDch宿泊利用台帳List(String function, SubQuery<Dch宿泊利用台帳CB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Dch宿泊利用台帳CB>", subQuery);
            Dch宿泊利用台帳CB cb = new Dch宿泊利用台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep会員コード_SpecifyDerivedReferrer_Dch宿泊利用台帳List(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "会員コード", "会員コード", subQueryPropertyName, aliasName);
        }
        abstract public String keep会員コード_SpecifyDerivedReferrer_Dch宿泊利用台帳List(Dch宿泊利用台帳CQ subQuery);

        public QDRFunction<Dch宿泊利用台帳CB> DerivedDch宿泊利用台帳List() {
            return xcreateQDRFunctionDch宿泊利用台帳List();
        }
        protected QDRFunction<Dch宿泊利用台帳CB> xcreateQDRFunctionDch宿泊利用台帳List() {
            return new QDRFunction<Dch宿泊利用台帳CB>(delegate(String function, SubQuery<Dch宿泊利用台帳CB> subQuery, String operand, Object value) {
                xqderiveDch宿泊利用台帳List(function, subQuery, operand, value);
            });
        }
        public void xqderiveDch宿泊利用台帳List(String function, SubQuery<Dch宿泊利用台帳CB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<Dch宿泊利用台帳CB>", subQuery);
            Dch宿泊利用台帳CB cb = new Dch宿泊利用台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep会員コード_QueryDerivedReferrer_Dch宿泊利用台帳List(cb.Query()); // for saving query-value.
            String parameterPropertyName = keep会員コード_QueryDerivedReferrer_Dch宿泊利用台帳ListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "会員コード", "会員コード", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keep会員コード_QueryDerivedReferrer_Dch宿泊利用台帳List(Dch宿泊利用台帳CQ subQuery);
        public abstract String keep会員コード_QueryDerivedReferrer_Dch宿泊利用台帳ListParameter(Object parameterValue);
        public void Set会員コード_IsNull() { reg会員コード(CK_ISN, DUMMY_OBJECT); }
        public void Set会員コード_IsNotNull() { reg会員コード(CK_ISNN, DUMMY_OBJECT); }
        protected void reg会員コード(ConditionKey k, Object v) { regQ(k, v, getCValue会員コード(), "会員コード"); }
        protected abstract ConditionValue getCValue会員コード();

        public void Set会員番号_Equal(String v) { DoSet会員番号_Equal(fRES(v)); }
        protected void DoSet会員番号_Equal(String v) { reg会員番号(CK_EQ, v); }
        public void Set会員番号_NotEqual(String v) { DoSet会員番号_NotEqual(fRES(v)); }
        protected void DoSet会員番号_NotEqual(String v) { reg会員番号(CK_NES, v); }
        public void Set会員番号_GreaterThan(String v) { reg会員番号(CK_GT, fRES(v)); }
        public void Set会員番号_LessThan(String v) { reg会員番号(CK_LT, fRES(v)); }
        public void Set会員番号_GreaterEqual(String v) { reg会員番号(CK_GE, fRES(v)); }
        public void Set会員番号_LessEqual(String v) { reg会員番号(CK_LE, fRES(v)); }
        public void Set会員番号_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue会員番号(), "会員番号"); }
        public void Set会員番号_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue会員番号(), "会員番号"); }
        public void Set会員番号_PrefixSearch(String v) { Set会員番号_LikeSearch(v, cLSOP()); }
        public void Set会員番号_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue会員番号(), "会員番号", option); }
        public void Set会員番号_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue会員番号(), "会員番号", option); }
        protected void reg会員番号(ConditionKey k, Object v) { regQ(k, v, getCValue会員番号(), "会員番号"); }
        protected abstract ConditionValue getCValue会員番号();

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

        public void Set会社名_Equal(String v) { DoSet会社名_Equal(fRES(v)); }
        protected void DoSet会社名_Equal(String v) { reg会社名(CK_EQ, v); }
        public void Set会社名_NotEqual(String v) { DoSet会社名_NotEqual(fRES(v)); }
        protected void DoSet会社名_NotEqual(String v) { reg会社名(CK_NES, v); }
        public void Set会社名_GreaterThan(String v) { reg会社名(CK_GT, fRES(v)); }
        public void Set会社名_LessThan(String v) { reg会社名(CK_LT, fRES(v)); }
        public void Set会社名_GreaterEqual(String v) { reg会社名(CK_GE, fRES(v)); }
        public void Set会社名_LessEqual(String v) { reg会社名(CK_LE, fRES(v)); }
        public void Set会社名_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue会社名(), "会社名"); }
        public void Set会社名_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue会社名(), "会社名"); }
        public void Set会社名_PrefixSearch(String v) { Set会社名_LikeSearch(v, cLSOP()); }
        public void Set会社名_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue会社名(), "会社名", option); }
        public void Set会社名_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue会社名(), "会社名", option); }
        public void Set会社名_IsNull() { reg会社名(CK_ISN, DUMMY_OBJECT); }
        public void Set会社名_IsNotNull() { reg会社名(CK_ISNN, DUMMY_OBJECT); }
        protected void reg会社名(ConditionKey k, Object v) { regQ(k, v, getCValue会社名(), "会社名"); }
        protected abstract ConditionValue getCValue会社名();

        public void Set会社名カナ_Equal(String v) { DoSet会社名カナ_Equal(fRES(v)); }
        protected void DoSet会社名カナ_Equal(String v) { reg会社名カナ(CK_EQ, v); }
        public void Set会社名カナ_NotEqual(String v) { DoSet会社名カナ_NotEqual(fRES(v)); }
        protected void DoSet会社名カナ_NotEqual(String v) { reg会社名カナ(CK_NES, v); }
        public void Set会社名カナ_GreaterThan(String v) { reg会社名カナ(CK_GT, fRES(v)); }
        public void Set会社名カナ_LessThan(String v) { reg会社名カナ(CK_LT, fRES(v)); }
        public void Set会社名カナ_GreaterEqual(String v) { reg会社名カナ(CK_GE, fRES(v)); }
        public void Set会社名カナ_LessEqual(String v) { reg会社名カナ(CK_LE, fRES(v)); }
        public void Set会社名カナ_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue会社名カナ(), "会社名カナ"); }
        public void Set会社名カナ_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue会社名カナ(), "会社名カナ"); }
        public void Set会社名カナ_PrefixSearch(String v) { Set会社名カナ_LikeSearch(v, cLSOP()); }
        public void Set会社名カナ_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue会社名カナ(), "会社名カナ", option); }
        public void Set会社名カナ_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue会社名カナ(), "会社名カナ", option); }
        public void Set会社名カナ_IsNull() { reg会社名カナ(CK_ISN, DUMMY_OBJECT); }
        public void Set会社名カナ_IsNotNull() { reg会社名カナ(CK_ISNN, DUMMY_OBJECT); }
        protected void reg会社名カナ(ConditionKey k, Object v) { regQ(k, v, getCValue会社名カナ(), "会社名カナ"); }
        protected abstract ConditionValue getCValue会社名カナ();

        public void Set電話番号_Equal(String v) { DoSet電話番号_Equal(fRES(v)); }
        protected void DoSet電話番号_Equal(String v) { reg電話番号(CK_EQ, v); }
        public void Set電話番号_NotEqual(String v) { DoSet電話番号_NotEqual(fRES(v)); }
        protected void DoSet電話番号_NotEqual(String v) { reg電話番号(CK_NES, v); }
        public void Set電話番号_GreaterThan(String v) { reg電話番号(CK_GT, fRES(v)); }
        public void Set電話番号_LessThan(String v) { reg電話番号(CK_LT, fRES(v)); }
        public void Set電話番号_GreaterEqual(String v) { reg電話番号(CK_GE, fRES(v)); }
        public void Set電話番号_LessEqual(String v) { reg電話番号(CK_LE, fRES(v)); }
        public void Set電話番号_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue電話番号(), "電話番号"); }
        public void Set電話番号_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue電話番号(), "電話番号"); }
        public void Set電話番号_PrefixSearch(String v) { Set電話番号_LikeSearch(v, cLSOP()); }
        public void Set電話番号_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue電話番号(), "電話番号", option); }
        public void Set電話番号_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue電話番号(), "電話番号", option); }
        public void Set電話番号_IsNull() { reg電話番号(CK_ISN, DUMMY_OBJECT); }
        public void Set電話番号_IsNotNull() { reg電話番号(CK_ISNN, DUMMY_OBJECT); }
        protected void reg電話番号(ConditionKey k, Object v) { regQ(k, v, getCValue電話番号(), "電話番号"); }
        protected abstract ConditionValue getCValue電話番号();

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

        public void Set入会年月日_Equal(DateTime? v) { reg入会年月日(CK_EQ, v); }
        public void Set入会年月日_GreaterThan(DateTime? v) { reg入会年月日(CK_GT, v); }
        public void Set入会年月日_LessThan(DateTime? v) { reg入会年月日(CK_LT, v); }
        public void Set入会年月日_GreaterEqual(DateTime? v) { reg入会年月日(CK_GE, v); }
        public void Set入会年月日_LessEqual(DateTime? v) { reg入会年月日(CK_LE, v); }
        public void Set入会年月日_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValue入会年月日(), "入会年月日", option); }
        public void Set入会年月日_DateFromTo(DateTime? from, DateTime? to) { Set入会年月日_FromTo(from, to, new DateFromToOption()); }
        protected void reg入会年月日(ConditionKey k, Object v) { regQ(k, v, getCValue入会年月日(), "入会年月日"); }
        protected abstract ConditionValue getCValue入会年月日();

        public void Set退会年月日_Equal(DateTime? v) { reg退会年月日(CK_EQ, v); }
        public void Set退会年月日_GreaterThan(DateTime? v) { reg退会年月日(CK_GT, v); }
        public void Set退会年月日_LessThan(DateTime? v) { reg退会年月日(CK_LT, v); }
        public void Set退会年月日_GreaterEqual(DateTime? v) { reg退会年月日(CK_GE, v); }
        public void Set退会年月日_LessEqual(DateTime? v) { reg退会年月日(CK_LE, v); }
        public void Set退会年月日_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValue退会年月日(), "退会年月日", option); }
        public void Set退会年月日_DateFromTo(DateTime? from, DateTime? to) { Set退会年月日_FromTo(from, to, new DateFromToOption()); }
        public void Set退会年月日_IsNull() { reg退会年月日(CK_ISN, DUMMY_OBJECT); }
        public void Set退会年月日_IsNotNull() { reg退会年月日(CK_ISNN, DUMMY_OBJECT); }
        protected void reg退会年月日(ConditionKey k, Object v) { regQ(k, v, getCValue退会年月日(), "退会年月日"); }
        protected abstract ConditionValue getCValue退会年月日();

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
        public SSQFunction<Mst会員マスタCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Mst会員マスタCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Mst会員マスタCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Mst会員マスタCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Mst会員マスタCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Mst会員マスタCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Mst会員マスタCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Mst会員マスタCB>(delegate(String function, SubQuery<Mst会員マスタCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Mst会員マスタCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Mst会員マスタCB>", subQuery);
            Mst会員マスタCB cb = new Mst会員マスタCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Mst会員マスタCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Mst会員マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst会員マスタCB>", subQuery);
            Mst会員マスタCB cb = new Mst会員マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "会員コード", "会員コード", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Mst会員マスタCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
