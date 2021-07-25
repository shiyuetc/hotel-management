
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
    public abstract class AbstractBsMst制御画面マスタCQ : AbstractConditionQuery {

        public AbstractBsMst制御画面マスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "mst制御画面マスタ"; }
        public override String getTableSqlName() { return "mst制御画面マスタ"; }

        public void SetId_Equal(long? v) { regId(CK_EQ, v); }
        public void SetId_NotEqual(long? v) { regId(CK_NES, v); }
        public void SetId_GreaterThan(long? v) { regId(CK_GT, v); }
        public void SetId_LessThan(long? v) { regId(CK_LT, v); }
        public void SetId_GreaterEqual(long? v) { regId(CK_GE, v); }
        public void SetId_LessEqual(long? v) { regId(CK_LE, v); }
        public void SetId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueId(), "id"); }
        public void SetId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueId(), "id"); }
        public void ExistsMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_ExistsSubQuery_Mst権限マスタList(cb.Query());
            registerExistsSubQuery(cb.Query(), "id", "制御画面id", subQueryPropertyName);
        }
        public abstract String keepId_ExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void NotExistsMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_NotExistsSubQuery_Mst権限マスタList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "id", "制御画面id", subQueryPropertyName);
        }
        public abstract String keepId_NotExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void InScopeMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_InScopeSubQuery_Mst権限マスタList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "id", "制御画面id", subQueryPropertyName);
        }
        public abstract String keepId_InScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void NotInScopeMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_NotInScopeSubQuery_Mst権限マスタList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "id", "制御画面id", subQueryPropertyName);
        }
        public abstract String keepId_NotInScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void xsderiveMst権限マスタList(String function, SubQuery<Mst権限マスタCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_SpecifyDerivedReferrer_Mst権限マスタList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "id", "制御画面id", subQueryPropertyName, aliasName);
        }
        abstract public String keepId_SpecifyDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery);

        public QDRFunction<Mst権限マスタCB> DerivedMst権限マスタList() {
            return xcreateQDRFunctionMst権限マスタList();
        }
        protected QDRFunction<Mst権限マスタCB> xcreateQDRFunctionMst権限マスタList() {
            return new QDRFunction<Mst権限マスタCB>(delegate(String function, SubQuery<Mst権限マスタCB> subQuery, String operand, Object value) {
                xqderiveMst権限マスタList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMst権限マスタList(String function, SubQuery<Mst権限マスタCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_QueryDerivedReferrer_Mst権限マスタList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepId_QueryDerivedReferrer_Mst権限マスタListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "id", "制御画面id", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepId_QueryDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public abstract String keepId_QueryDerivedReferrer_Mst権限マスタListParameter(Object parameterValue);
        public void SetId_IsNull() { regId(CK_ISN, DUMMY_OBJECT); }
        public void SetId_IsNotNull() { regId(CK_ISNN, DUMMY_OBJECT); }
        protected void regId(ConditionKey k, Object v) { regQ(k, v, getCValueId(), "id"); }
        protected abstract ConditionValue getCValueId();

        public void Setメニューcode_Equal(String v) { DoSetメニューcode_Equal(fRES(v)); }
        /// <summary>
        /// Set the value of ログアウト of メニューcode as equal. { = }
        /// ログアウト: 9999
        /// </summary>
        public void Setメニューcode_Equal_ログアウト() {
            DoSetメニューcode_Equal(CDef.メニュー区分.ログアウト.Code);
        }
        /// <summary>
        /// Set the value of 予約管理 of メニューcode as equal. { = }
        /// 予約管理: 10
        /// </summary>
        public void Setメニューcode_Equal_予約管理() {
            DoSetメニューcode_Equal(CDef.メニュー区分.予約管理.Code);
        }
        /// <summary>
        /// Set the value of 宿泊履歴 of メニューcode as equal. { = }
        /// 宿泊履歴: 20
        /// </summary>
        public void Setメニューcode_Equal_宿泊履歴() {
            DoSetメニューcode_Equal(CDef.メニュー区分.宿泊履歴.Code);
        }
        /// <summary>
        /// Set the value of 顧客管理 of メニューcode as equal. { = }
        /// 顧客管理: 30
        /// </summary>
        public void Setメニューcode_Equal_顧客管理() {
            DoSetメニューcode_Equal(CDef.メニュー区分.顧客管理.Code);
        }
        /// <summary>
        /// Set the value of 従業員管理 of メニューcode as equal. { = }
        /// 従業員管理: 40
        /// </summary>
        public void Setメニューcode_Equal_従業員管理() {
            DoSetメニューcode_Equal(CDef.メニュー区分.従業員管理.Code);
        }
        /// <summary>
        /// Set the value of 客室管理 of メニューcode as equal. { = }
        /// 客室管理: 50
        /// </summary>
        public void Setメニューcode_Equal_客室管理() {
            DoSetメニューcode_Equal(CDef.メニュー区分.客室管理.Code);
        }
        protected void DoSetメニューcode_Equal(String v) { regメニューcode(CK_EQ, v); }
        public void Setメニューcode_NotEqual(String v) { DoSetメニューcode_NotEqual(fRES(v)); }
        /// <summary>
        /// Set the value of ログアウト of メニューcode as notEqual. { &lt;&gt; }
        /// ログアウト: 9999
        /// </summary>
        public void Setメニューcode_NotEqual_ログアウト() {
            DoSetメニューcode_NotEqual(CDef.メニュー区分.ログアウト.Code);
        }
        /// <summary>
        /// Set the value of 予約管理 of メニューcode as notEqual. { &lt;&gt; }
        /// 予約管理: 10
        /// </summary>
        public void Setメニューcode_NotEqual_予約管理() {
            DoSetメニューcode_NotEqual(CDef.メニュー区分.予約管理.Code);
        }
        /// <summary>
        /// Set the value of 宿泊履歴 of メニューcode as notEqual. { &lt;&gt; }
        /// 宿泊履歴: 20
        /// </summary>
        public void Setメニューcode_NotEqual_宿泊履歴() {
            DoSetメニューcode_NotEqual(CDef.メニュー区分.宿泊履歴.Code);
        }
        /// <summary>
        /// Set the value of 顧客管理 of メニューcode as notEqual. { &lt;&gt; }
        /// 顧客管理: 30
        /// </summary>
        public void Setメニューcode_NotEqual_顧客管理() {
            DoSetメニューcode_NotEqual(CDef.メニュー区分.顧客管理.Code);
        }
        /// <summary>
        /// Set the value of 従業員管理 of メニューcode as notEqual. { &lt;&gt; }
        /// 従業員管理: 40
        /// </summary>
        public void Setメニューcode_NotEqual_従業員管理() {
            DoSetメニューcode_NotEqual(CDef.メニュー区分.従業員管理.Code);
        }
        /// <summary>
        /// Set the value of 客室管理 of メニューcode as notEqual. { &lt;&gt; }
        /// 客室管理: 50
        /// </summary>
        public void Setメニューcode_NotEqual_客室管理() {
            DoSetメニューcode_NotEqual(CDef.メニュー区分.客室管理.Code);
        }
        protected void DoSetメニューcode_NotEqual(String v) { regメニューcode(CK_NES, v); }
        public void Setメニューcode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueメニューcode(), "メニューcode"); }
        public void Setメニューcode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueメニューcode(), "メニューcode"); }
        public void InScopeKbnメニュー区分(SubQuery<Kbnメニュー区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbnメニュー区分CB>", subQuery);
            Kbnメニュー区分CB cb = new Kbnメニュー区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepメニューcode_InScopeSubQuery_Kbnメニュー区分(cb.Query());
            registerInScopeSubQuery(cb.Query(), "メニューcode", "code", subQueryPropertyName);
        }
        public abstract String keepメニューcode_InScopeSubQuery_Kbnメニュー区分(Kbnメニュー区分CQ subQuery);
        public void NotInScopeKbnメニュー区分(SubQuery<Kbnメニュー区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbnメニュー区分CB>", subQuery);
            Kbnメニュー区分CB cb = new Kbnメニュー区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepメニューcode_NotInScopeSubQuery_Kbnメニュー区分(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "メニューcode", "code", subQueryPropertyName);
        }
        public abstract String keepメニューcode_NotInScopeSubQuery_Kbnメニュー区分(Kbnメニュー区分CQ subQuery);
        protected void regメニューcode(ConditionKey k, Object v) { regQ(k, v, getCValueメニューcode(), "メニューcode"); }
        protected abstract ConditionValue getCValueメニューcode();

        public void Set画面名_Equal(String v) { DoSet画面名_Equal(fRES(v)); }
        protected void DoSet画面名_Equal(String v) { reg画面名(CK_EQ, v); }
        public void Set画面名_NotEqual(String v) { DoSet画面名_NotEqual(fRES(v)); }
        protected void DoSet画面名_NotEqual(String v) { reg画面名(CK_NES, v); }
        public void Set画面名_GreaterThan(String v) { reg画面名(CK_GT, fRES(v)); }
        public void Set画面名_LessThan(String v) { reg画面名(CK_LT, fRES(v)); }
        public void Set画面名_GreaterEqual(String v) { reg画面名(CK_GE, fRES(v)); }
        public void Set画面名_LessEqual(String v) { reg画面名(CK_LE, fRES(v)); }
        public void Set画面名_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue画面名(), "画面名"); }
        public void Set画面名_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue画面名(), "画面名"); }
        public void Set画面名_PrefixSearch(String v) { Set画面名_LikeSearch(v, cLSOP()); }
        public void Set画面名_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue画面名(), "画面名", option); }
        public void Set画面名_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue画面名(), "画面名", option); }
        protected void reg画面名(ConditionKey k, Object v) { regQ(k, v, getCValue画面名(), "画面名"); }
        protected abstract ConditionValue getCValue画面名();

        public void Set表示名_Equal(String v) { DoSet表示名_Equal(fRES(v)); }
        protected void DoSet表示名_Equal(String v) { reg表示名(CK_EQ, v); }
        public void Set表示名_NotEqual(String v) { DoSet表示名_NotEqual(fRES(v)); }
        protected void DoSet表示名_NotEqual(String v) { reg表示名(CK_NES, v); }
        public void Set表示名_GreaterThan(String v) { reg表示名(CK_GT, fRES(v)); }
        public void Set表示名_LessThan(String v) { reg表示名(CK_LT, fRES(v)); }
        public void Set表示名_GreaterEqual(String v) { reg表示名(CK_GE, fRES(v)); }
        public void Set表示名_LessEqual(String v) { reg表示名(CK_LE, fRES(v)); }
        public void Set表示名_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue表示名(), "表示名"); }
        public void Set表示名_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue表示名(), "表示名"); }
        public void Set表示名_PrefixSearch(String v) { Set表示名_LikeSearch(v, cLSOP()); }
        public void Set表示名_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue表示名(), "表示名", option); }
        public void Set表示名_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue表示名(), "表示名", option); }
        protected void reg表示名(ConditionKey k, Object v) { regQ(k, v, getCValue表示名(), "表示名"); }
        protected abstract ConditionValue getCValue表示名();

        public void Set優先順位_Equal(int? v) { reg優先順位(CK_EQ, v); }
        public void Set優先順位_NotEqual(int? v) { reg優先順位(CK_NES, v); }
        public void Set優先順位_GreaterThan(int? v) { reg優先順位(CK_GT, v); }
        public void Set優先順位_LessThan(int? v) { reg優先順位(CK_LT, v); }
        public void Set優先順位_GreaterEqual(int? v) { reg優先順位(CK_GE, v); }
        public void Set優先順位_LessEqual(int? v) { reg優先順位(CK_LE, v); }
        public void Set優先順位_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValue優先順位(), "優先順位"); }
        public void Set優先順位_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValue優先順位(), "優先順位"); }
        protected void reg優先順位(ConditionKey k, Object v) { regQ(k, v, getCValue優先順位(), "優先順位"); }
        protected abstract ConditionValue getCValue優先順位();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<Mst制御画面マスタCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Mst制御画面マスタCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Mst制御画面マスタCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Mst制御画面マスタCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Mst制御画面マスタCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Mst制御画面マスタCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Mst制御画面マスタCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Mst制御画面マスタCB>(delegate(String function, SubQuery<Mst制御画面マスタCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Mst制御画面マスタCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Mst制御画面マスタCB>", subQuery);
            Mst制御画面マスタCB cb = new Mst制御画面マスタCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Mst制御画面マスタCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Mst制御画面マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst制御画面マスタCB>", subQuery);
            Mst制御画面マスタCB cb = new Mst制御画面マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "id", "id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Mst制御画面マスタCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
