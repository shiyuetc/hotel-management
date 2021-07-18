
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

        public void SetId_Equal(long? v) { regId(CK_EQ, v); }
        public void SetId_NotEqual(long? v) { regId(CK_NES, v); }
        public void SetId_GreaterThan(long? v) { regId(CK_GT, v); }
        public void SetId_LessThan(long? v) { regId(CK_LT, v); }
        public void SetId_GreaterEqual(long? v) { regId(CK_GE, v); }
        public void SetId_LessEqual(long? v) { regId(CK_LE, v); }
        public void SetId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueId(), "id"); }
        public void SetId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueId(), "id"); }
        public void SetId_IsNull() { regId(CK_ISN, DUMMY_OBJECT); }
        public void SetId_IsNotNull() { regId(CK_ISNN, DUMMY_OBJECT); }
        protected void regId(ConditionKey k, Object v) { regQ(k, v, getCValueId(), "id"); }
        protected abstract ConditionValue getCValueId();

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

        public void Set氏名姓_Equal(String v) { DoSet氏名姓_Equal(fRES(v)); }
        protected void DoSet氏名姓_Equal(String v) { reg氏名姓(CK_EQ, v); }
        public void Set氏名姓_NotEqual(String v) { DoSet氏名姓_NotEqual(fRES(v)); }
        protected void DoSet氏名姓_NotEqual(String v) { reg氏名姓(CK_NES, v); }
        public void Set氏名姓_GreaterThan(String v) { reg氏名姓(CK_GT, fRES(v)); }
        public void Set氏名姓_LessThan(String v) { reg氏名姓(CK_LT, fRES(v)); }
        public void Set氏名姓_GreaterEqual(String v) { reg氏名姓(CK_GE, fRES(v)); }
        public void Set氏名姓_LessEqual(String v) { reg氏名姓(CK_LE, fRES(v)); }
        public void Set氏名姓_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue氏名姓(), "氏名_姓"); }
        public void Set氏名姓_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue氏名姓(), "氏名_姓"); }
        public void Set氏名姓_PrefixSearch(String v) { Set氏名姓_LikeSearch(v, cLSOP()); }
        public void Set氏名姓_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue氏名姓(), "氏名_姓", option); }
        public void Set氏名姓_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue氏名姓(), "氏名_姓", option); }
        protected void reg氏名姓(ConditionKey k, Object v) { regQ(k, v, getCValue氏名姓(), "氏名_姓"); }
        protected abstract ConditionValue getCValue氏名姓();

        public void Set氏名名_Equal(String v) { DoSet氏名名_Equal(fRES(v)); }
        protected void DoSet氏名名_Equal(String v) { reg氏名名(CK_EQ, v); }
        public void Set氏名名_NotEqual(String v) { DoSet氏名名_NotEqual(fRES(v)); }
        protected void DoSet氏名名_NotEqual(String v) { reg氏名名(CK_NES, v); }
        public void Set氏名名_GreaterThan(String v) { reg氏名名(CK_GT, fRES(v)); }
        public void Set氏名名_LessThan(String v) { reg氏名名(CK_LT, fRES(v)); }
        public void Set氏名名_GreaterEqual(String v) { reg氏名名(CK_GE, fRES(v)); }
        public void Set氏名名_LessEqual(String v) { reg氏名名(CK_LE, fRES(v)); }
        public void Set氏名名_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue氏名名(), "氏名_名"); }
        public void Set氏名名_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue氏名名(), "氏名_名"); }
        public void Set氏名名_PrefixSearch(String v) { Set氏名名_LikeSearch(v, cLSOP()); }
        public void Set氏名名_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue氏名名(), "氏名_名", option); }
        public void Set氏名名_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue氏名名(), "氏名_名", option); }
        protected void reg氏名名(ConditionKey k, Object v) { regQ(k, v, getCValue氏名名(), "氏名_名"); }
        protected abstract ConditionValue getCValue氏名名();

        public void Set氏名カナ_Equal(String v) { DoSet氏名カナ_Equal(fRES(v)); }
        protected void DoSet氏名カナ_Equal(String v) { reg氏名カナ(CK_EQ, v); }
        public void Set氏名カナ_NotEqual(String v) { DoSet氏名カナ_NotEqual(fRES(v)); }
        protected void DoSet氏名カナ_NotEqual(String v) { reg氏名カナ(CK_NES, v); }
        public void Set氏名カナ_GreaterThan(String v) { reg氏名カナ(CK_GT, fRES(v)); }
        public void Set氏名カナ_LessThan(String v) { reg氏名カナ(CK_LT, fRES(v)); }
        public void Set氏名カナ_GreaterEqual(String v) { reg氏名カナ(CK_GE, fRES(v)); }
        public void Set氏名カナ_LessEqual(String v) { reg氏名カナ(CK_LE, fRES(v)); }
        public void Set氏名カナ_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue氏名カナ(), "氏名_カナ"); }
        public void Set氏名カナ_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue氏名カナ(), "氏名_カナ"); }
        public void Set氏名カナ_PrefixSearch(String v) { Set氏名カナ_LikeSearch(v, cLSOP()); }
        public void Set氏名カナ_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue氏名カナ(), "氏名_カナ", option); }
        public void Set氏名カナ_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue氏名カナ(), "氏名_カナ", option); }
        protected void reg氏名カナ(ConditionKey k, Object v) { regQ(k, v, getCValue氏名カナ(), "氏名_カナ"); }
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
        public void Set会社名カナ_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue会社名カナ(), "会社名_カナ"); }
        public void Set会社名カナ_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue会社名カナ(), "会社名_カナ"); }
        public void Set会社名カナ_PrefixSearch(String v) { Set会社名カナ_LikeSearch(v, cLSOP()); }
        public void Set会社名カナ_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue会社名カナ(), "会社名_カナ", option); }
        public void Set会社名カナ_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue会社名カナ(), "会社名_カナ", option); }
        public void Set会社名カナ_IsNull() { reg会社名カナ(CK_ISN, DUMMY_OBJECT); }
        public void Set会社名カナ_IsNotNull() { reg会社名カナ(CK_ISNN, DUMMY_OBJECT); }
        protected void reg会社名カナ(ConditionKey k, Object v) { regQ(k, v, getCValue会社名カナ(), "会社名_カナ"); }
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
            registerInScopeSubQuery(cb.Query(), "id", "id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Mst会員マスタCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
