
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
    public abstract class AbstractBsDch客室利用台帳CQ : AbstractConditionQuery {

        public AbstractBsDch客室利用台帳CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "dch客室利用台帳"; }
        public override String getTableSqlName() { return "dch客室利用台帳"; }

        public void SetId_Equal(long? v) { regId(CK_EQ, v); }
        public void SetId_NotEqual(long? v) { regId(CK_NES, v); }
        public void SetId_GreaterThan(long? v) { regId(CK_GT, v); }
        public void SetId_LessThan(long? v) { regId(CK_LT, v); }
        public void SetId_GreaterEqual(long? v) { regId(CK_GE, v); }
        public void SetId_LessEqual(long? v) { regId(CK_LE, v); }
        public void SetId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueId(), "id"); }
        public void SetId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueId(), "id"); }
        public void ExistsDch宿泊利用台帳AsOne(SubQuery<Dch宿泊利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch宿泊利用台帳CB>", subQuery);
            Dch宿泊利用台帳CB cb = new Dch宿泊利用台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_ExistsSubQuery_Dch宿泊利用台帳AsOne(cb.Query());
            registerExistsSubQuery(cb.Query(), "id", "客室利用台帳id", subQueryPropertyName);
        }
        public abstract String keepId_ExistsSubQuery_Dch宿泊利用台帳AsOne(Dch宿泊利用台帳CQ subQuery);
        public void NotExistsDch宿泊利用台帳AsOne(SubQuery<Dch宿泊利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch宿泊利用台帳CB>", subQuery);
            Dch宿泊利用台帳CB cb = new Dch宿泊利用台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_NotExistsSubQuery_Dch宿泊利用台帳AsOne(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "id", "客室利用台帳id", subQueryPropertyName);
        }
        public abstract String keepId_NotExistsSubQuery_Dch宿泊利用台帳AsOne(Dch宿泊利用台帳CQ subQuery);
        public void InScopeDch宿泊利用台帳AsOne(SubQuery<Dch宿泊利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch宿泊利用台帳CB>", subQuery);
            Dch宿泊利用台帳CB cb = new Dch宿泊利用台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_InScopeSubQuery_Dch宿泊利用台帳AsOne(cb.Query());
            registerInScopeSubQuery(cb.Query(), "id", "客室利用台帳id", subQueryPropertyName);
        }
        public abstract String keepId_InScopeSubQuery_Dch宿泊利用台帳AsOne(Dch宿泊利用台帳CQ subQuery);
        public void NotInScopeDch宿泊利用台帳AsOne(SubQuery<Dch宿泊利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch宿泊利用台帳CB>", subQuery);
            Dch宿泊利用台帳CB cb = new Dch宿泊利用台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_NotInScopeSubQuery_Dch宿泊利用台帳AsOne(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "id", "客室利用台帳id", subQueryPropertyName);
        }
        public abstract String keepId_NotInScopeSubQuery_Dch宿泊利用台帳AsOne(Dch宿泊利用台帳CQ subQuery);
        public void SetId_IsNull() { regId(CK_ISN, DUMMY_OBJECT); }
        public void SetId_IsNotNull() { regId(CK_ISNN, DUMMY_OBJECT); }
        protected void regId(ConditionKey k, Object v) { regQ(k, v, getCValueId(), "id"); }
        protected abstract ConditionValue getCValueId();

        public void Set客室利用コード_Equal(String v) { DoSet客室利用コード_Equal(fRES(v)); }
        /// <summary>
        /// Set the value of 宿泊 of 客室利用コード as equal. { = }
        /// 宿泊
        /// </summary>
        public void Set客室利用コード_Equal_宿泊() {
            DoSet客室利用コード_Equal(CDef.客室利用区分.宿泊.Code);
        }
        /// <summary>
        /// Set the value of 清掃 of 客室利用コード as equal. { = }
        /// 清掃
        /// </summary>
        public void Set客室利用コード_Equal_清掃() {
            DoSet客室利用コード_Equal(CDef.客室利用区分.清掃.Code);
        }
        /// <summary>
        /// Set the value of 工事 of 客室利用コード as equal. { = }
        /// 工事
        /// </summary>
        public void Set客室利用コード_Equal_工事() {
            DoSet客室利用コード_Equal(CDef.客室利用区分.工事.Code);
        }
        /// <summary>
        /// Set the value of その他 of 客室利用コード as equal. { = }
        /// その他
        /// </summary>
        public void Set客室利用コード_Equal_その他() {
            DoSet客室利用コード_Equal(CDef.客室利用区分.その他.Code);
        }
        protected void DoSet客室利用コード_Equal(String v) { reg客室利用コード(CK_EQ, v); }
        public void Set客室利用コード_NotEqual(String v) { DoSet客室利用コード_NotEqual(fRES(v)); }
        /// <summary>
        /// Set the value of 宿泊 of 客室利用コード as notEqual. { &lt;&gt; }
        /// 宿泊
        /// </summary>
        public void Set客室利用コード_NotEqual_宿泊() {
            DoSet客室利用コード_NotEqual(CDef.客室利用区分.宿泊.Code);
        }
        /// <summary>
        /// Set the value of 清掃 of 客室利用コード as notEqual. { &lt;&gt; }
        /// 清掃
        /// </summary>
        public void Set客室利用コード_NotEqual_清掃() {
            DoSet客室利用コード_NotEqual(CDef.客室利用区分.清掃.Code);
        }
        /// <summary>
        /// Set the value of 工事 of 客室利用コード as notEqual. { &lt;&gt; }
        /// 工事
        /// </summary>
        public void Set客室利用コード_NotEqual_工事() {
            DoSet客室利用コード_NotEqual(CDef.客室利用区分.工事.Code);
        }
        /// <summary>
        /// Set the value of その他 of 客室利用コード as notEqual. { &lt;&gt; }
        /// その他
        /// </summary>
        public void Set客室利用コード_NotEqual_その他() {
            DoSet客室利用コード_NotEqual(CDef.客室利用区分.その他.Code);
        }
        protected void DoSet客室利用コード_NotEqual(String v) { reg客室利用コード(CK_NES, v); }
        public void Set客室利用コード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue客室利用コード(), "客室利用コード"); }
        public void Set客室利用コード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue客室利用コード(), "客室利用コード"); }
        public void InScopeKbn客室利用区分(SubQuery<Kbn客室利用区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbn客室利用区分CB>", subQuery);
            Kbn客室利用区分CB cb = new Kbn客室利用区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室利用コード_InScopeSubQuery_Kbn客室利用区分(cb.Query());
            registerInScopeSubQuery(cb.Query(), "客室利用コード", "客室利用コード", subQueryPropertyName);
        }
        public abstract String keep客室利用コード_InScopeSubQuery_Kbn客室利用区分(Kbn客室利用区分CQ subQuery);
        public void NotInScopeKbn客室利用区分(SubQuery<Kbn客室利用区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbn客室利用区分CB>", subQuery);
            Kbn客室利用区分CB cb = new Kbn客室利用区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室利用コード_NotInScopeSubQuery_Kbn客室利用区分(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "客室利用コード", "客室利用コード", subQueryPropertyName);
        }
        public abstract String keep客室利用コード_NotInScopeSubQuery_Kbn客室利用区分(Kbn客室利用区分CQ subQuery);
        protected void reg客室利用コード(ConditionKey k, Object v) { regQ(k, v, getCValue客室利用コード(), "客室利用コード"); }
        protected abstract ConditionValue getCValue客室利用コード();

        public void Set客室コード_Equal(String v) { DoSet客室コード_Equal(fRES(v)); }
        protected void DoSet客室コード_Equal(String v) { reg客室コード(CK_EQ, v); }
        public void Set客室コード_NotEqual(String v) { DoSet客室コード_NotEqual(fRES(v)); }
        protected void DoSet客室コード_NotEqual(String v) { reg客室コード(CK_NES, v); }
        public void Set客室コード_GreaterThan(String v) { reg客室コード(CK_GT, fRES(v)); }
        public void Set客室コード_LessThan(String v) { reg客室コード(CK_LT, fRES(v)); }
        public void Set客室コード_GreaterEqual(String v) { reg客室コード(CK_GE, fRES(v)); }
        public void Set客室コード_LessEqual(String v) { reg客室コード(CK_LE, fRES(v)); }
        public void Set客室コード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue客室コード(), "客室コード"); }
        public void Set客室コード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue客室コード(), "客室コード"); }
        public void Set客室コード_PrefixSearch(String v) { Set客室コード_LikeSearch(v, cLSOP()); }
        public void Set客室コード_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue客室コード(), "客室コード", option); }
        public void Set客室コード_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue客室コード(), "客室コード", option); }
        public void InScopeMst客室マスタ(SubQuery<Mst客室マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst客室マスタCB>", subQuery);
            Mst客室マスタCB cb = new Mst客室マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室コード_InScopeSubQuery_Mst客室マスタ(cb.Query());
            registerInScopeSubQuery(cb.Query(), "客室コード", "客室コード", subQueryPropertyName);
        }
        public abstract String keep客室コード_InScopeSubQuery_Mst客室マスタ(Mst客室マスタCQ subQuery);
        public void NotInScopeMst客室マスタ(SubQuery<Mst客室マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst客室マスタCB>", subQuery);
            Mst客室マスタCB cb = new Mst客室マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室コード_NotInScopeSubQuery_Mst客室マスタ(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "客室コード", "客室コード", subQueryPropertyName);
        }
        public abstract String keep客室コード_NotInScopeSubQuery_Mst客室マスタ(Mst客室マスタCQ subQuery);
        protected void reg客室コード(ConditionKey k, Object v) { regQ(k, v, getCValue客室コード(), "客室コード"); }
        protected abstract ConditionValue getCValue客室コード();

        public void Set開始予定日時_Equal(DateTime? v) { reg開始予定日時(CK_EQ, v); }
        public void Set開始予定日時_GreaterThan(DateTime? v) { reg開始予定日時(CK_GT, v); }
        public void Set開始予定日時_LessThan(DateTime? v) { reg開始予定日時(CK_LT, v); }
        public void Set開始予定日時_GreaterEqual(DateTime? v) { reg開始予定日時(CK_GE, v); }
        public void Set開始予定日時_LessEqual(DateTime? v) { reg開始予定日時(CK_LE, v); }
        public void Set開始予定日時_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValue開始予定日時(), "開始予定日時", option); }
        public void Set開始予定日時_DateFromTo(DateTime? from, DateTime? to) { Set開始予定日時_FromTo(from, to, new DateFromToOption()); }
        protected void reg開始予定日時(ConditionKey k, Object v) { regQ(k, v, getCValue開始予定日時(), "開始予定日時"); }
        protected abstract ConditionValue getCValue開始予定日時();

        public void Set終了予定日時_Equal(DateTime? v) { reg終了予定日時(CK_EQ, v); }
        public void Set終了予定日時_GreaterThan(DateTime? v) { reg終了予定日時(CK_GT, v); }
        public void Set終了予定日時_LessThan(DateTime? v) { reg終了予定日時(CK_LT, v); }
        public void Set終了予定日時_GreaterEqual(DateTime? v) { reg終了予定日時(CK_GE, v); }
        public void Set終了予定日時_LessEqual(DateTime? v) { reg終了予定日時(CK_LE, v); }
        public void Set終了予定日時_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValue終了予定日時(), "終了予定日時", option); }
        public void Set終了予定日時_DateFromTo(DateTime? from, DateTime? to) { Set終了予定日時_FromTo(from, to, new DateFromToOption()); }
        protected void reg終了予定日時(ConditionKey k, Object v) { regQ(k, v, getCValue終了予定日時(), "終了予定日時"); }
        protected abstract ConditionValue getCValue終了予定日時();

        public void Set開始実績日時_Equal(DateTime? v) { reg開始実績日時(CK_EQ, v); }
        public void Set開始実績日時_GreaterThan(DateTime? v) { reg開始実績日時(CK_GT, v); }
        public void Set開始実績日時_LessThan(DateTime? v) { reg開始実績日時(CK_LT, v); }
        public void Set開始実績日時_GreaterEqual(DateTime? v) { reg開始実績日時(CK_GE, v); }
        public void Set開始実績日時_LessEqual(DateTime? v) { reg開始実績日時(CK_LE, v); }
        public void Set開始実績日時_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValue開始実績日時(), "開始実績日時", option); }
        public void Set開始実績日時_DateFromTo(DateTime? from, DateTime? to) { Set開始実績日時_FromTo(from, to, new DateFromToOption()); }
        public void Set開始実績日時_IsNull() { reg開始実績日時(CK_ISN, DUMMY_OBJECT); }
        public void Set開始実績日時_IsNotNull() { reg開始実績日時(CK_ISNN, DUMMY_OBJECT); }
        protected void reg開始実績日時(ConditionKey k, Object v) { regQ(k, v, getCValue開始実績日時(), "開始実績日時"); }
        protected abstract ConditionValue getCValue開始実績日時();

        public void Set終了実績日時_Equal(DateTime? v) { reg終了実績日時(CK_EQ, v); }
        public void Set終了実績日時_GreaterThan(DateTime? v) { reg終了実績日時(CK_GT, v); }
        public void Set終了実績日時_LessThan(DateTime? v) { reg終了実績日時(CK_LT, v); }
        public void Set終了実績日時_GreaterEqual(DateTime? v) { reg終了実績日時(CK_GE, v); }
        public void Set終了実績日時_LessEqual(DateTime? v) { reg終了実績日時(CK_LE, v); }
        public void Set終了実績日時_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValue終了実績日時(), "終了実績日時", option); }
        public void Set終了実績日時_DateFromTo(DateTime? from, DateTime? to) { Set終了実績日時_FromTo(from, to, new DateFromToOption()); }
        public void Set終了実績日時_IsNull() { reg終了実績日時(CK_ISN, DUMMY_OBJECT); }
        public void Set終了実績日時_IsNotNull() { reg終了実績日時(CK_ISNN, DUMMY_OBJECT); }
        protected void reg終了実績日時(ConditionKey k, Object v) { regQ(k, v, getCValue終了実績日時(), "終了実績日時"); }
        protected abstract ConditionValue getCValue終了実績日時();

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
        public SSQFunction<Dch客室利用台帳CB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Dch客室利用台帳CB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Dch客室利用台帳CB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Dch客室利用台帳CB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Dch客室利用台帳CB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Dch客室利用台帳CB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Dch客室利用台帳CB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Dch客室利用台帳CB>(delegate(String function, SubQuery<Dch客室利用台帳CB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Dch客室利用台帳CB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Dch客室利用台帳CB>", subQuery);
            Dch客室利用台帳CB cb = new Dch客室利用台帳CB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Dch客室利用台帳CQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Dch客室利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用台帳CB>", subQuery);
            Dch客室利用台帳CB cb = new Dch客室利用台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "id", "id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Dch客室利用台帳CQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
