
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
    public abstract class AbstractBsKbnメニュー区分CQ : AbstractConditionQuery {

        public AbstractBsKbnメニュー区分CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "kbnメニュー区分"; }
        public override String getTableSqlName() { return "kbnメニュー区分"; }

        public void SetCode_Equal(String v) { DoSetCode_Equal(fRES(v)); }
        /// <summary>
        /// Set the value of ログアウト of code as equal. { = }
        /// ログアウト: 9999
        /// </summary>
        public void SetCode_Equal_ログアウト() {
            DoSetCode_Equal(CDef.メニュー区分.ログアウト.Code);
        }
        /// <summary>
        /// Set the value of 予約管理 of code as equal. { = }
        /// 予約管理: 10
        /// </summary>
        public void SetCode_Equal_予約管理() {
            DoSetCode_Equal(CDef.メニュー区分.予約管理.Code);
        }
        /// <summary>
        /// Set the value of 宿泊履歴 of code as equal. { = }
        /// 宿泊履歴: 20
        /// </summary>
        public void SetCode_Equal_宿泊履歴() {
            DoSetCode_Equal(CDef.メニュー区分.宿泊履歴.Code);
        }
        /// <summary>
        /// Set the value of 顧客管理 of code as equal. { = }
        /// 顧客管理: 30
        /// </summary>
        public void SetCode_Equal_顧客管理() {
            DoSetCode_Equal(CDef.メニュー区分.顧客管理.Code);
        }
        /// <summary>
        /// Set the value of 従業員管理 of code as equal. { = }
        /// 従業員管理: 40
        /// </summary>
        public void SetCode_Equal_従業員管理() {
            DoSetCode_Equal(CDef.メニュー区分.従業員管理.Code);
        }
        /// <summary>
        /// Set the value of 客室管理 of code as equal. { = }
        /// 客室管理: 50
        /// </summary>
        public void SetCode_Equal_客室管理() {
            DoSetCode_Equal(CDef.メニュー区分.客室管理.Code);
        }
        protected void DoSetCode_Equal(String v) { regCode(CK_EQ, v); }
        public void SetCode_NotEqual(String v) { DoSetCode_NotEqual(fRES(v)); }
        /// <summary>
        /// Set the value of ログアウト of code as notEqual. { &lt;&gt; }
        /// ログアウト: 9999
        /// </summary>
        public void SetCode_NotEqual_ログアウト() {
            DoSetCode_NotEqual(CDef.メニュー区分.ログアウト.Code);
        }
        /// <summary>
        /// Set the value of 予約管理 of code as notEqual. { &lt;&gt; }
        /// 予約管理: 10
        /// </summary>
        public void SetCode_NotEqual_予約管理() {
            DoSetCode_NotEqual(CDef.メニュー区分.予約管理.Code);
        }
        /// <summary>
        /// Set the value of 宿泊履歴 of code as notEqual. { &lt;&gt; }
        /// 宿泊履歴: 20
        /// </summary>
        public void SetCode_NotEqual_宿泊履歴() {
            DoSetCode_NotEqual(CDef.メニュー区分.宿泊履歴.Code);
        }
        /// <summary>
        /// Set the value of 顧客管理 of code as notEqual. { &lt;&gt; }
        /// 顧客管理: 30
        /// </summary>
        public void SetCode_NotEqual_顧客管理() {
            DoSetCode_NotEqual(CDef.メニュー区分.顧客管理.Code);
        }
        /// <summary>
        /// Set the value of 従業員管理 of code as notEqual. { &lt;&gt; }
        /// 従業員管理: 40
        /// </summary>
        public void SetCode_NotEqual_従業員管理() {
            DoSetCode_NotEqual(CDef.メニュー区分.従業員管理.Code);
        }
        /// <summary>
        /// Set the value of 客室管理 of code as notEqual. { &lt;&gt; }
        /// 客室管理: 50
        /// </summary>
        public void SetCode_NotEqual_客室管理() {
            DoSetCode_NotEqual(CDef.メニュー区分.客室管理.Code);
        }
        protected void DoSetCode_NotEqual(String v) { regCode(CK_NES, v); }
        public void SetCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueCode(), "code"); }
        public void SetCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueCode(), "code"); }
        public void ExistsMst制御画面マスタList(SubQuery<Mst制御画面マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst制御画面マスタCB>", subQuery);
            Mst制御画面マスタCB cb = new Mst制御画面マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_ExistsSubQuery_Mst制御画面マスタList(cb.Query());
            registerExistsSubQuery(cb.Query(), "code", "メニューcode", subQueryPropertyName);
        }
        public abstract String keepCode_ExistsSubQuery_Mst制御画面マスタList(Mst制御画面マスタCQ subQuery);
        public void NotExistsMst制御画面マスタList(SubQuery<Mst制御画面マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst制御画面マスタCB>", subQuery);
            Mst制御画面マスタCB cb = new Mst制御画面マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_NotExistsSubQuery_Mst制御画面マスタList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "code", "メニューcode", subQueryPropertyName);
        }
        public abstract String keepCode_NotExistsSubQuery_Mst制御画面マスタList(Mst制御画面マスタCQ subQuery);
        public void InScopeMst制御画面マスタList(SubQuery<Mst制御画面マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst制御画面マスタCB>", subQuery);
            Mst制御画面マスタCB cb = new Mst制御画面マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_InScopeSubQuery_Mst制御画面マスタList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "code", "メニューcode", subQueryPropertyName);
        }
        public abstract String keepCode_InScopeSubQuery_Mst制御画面マスタList(Mst制御画面マスタCQ subQuery);
        public void NotInScopeMst制御画面マスタList(SubQuery<Mst制御画面マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst制御画面マスタCB>", subQuery);
            Mst制御画面マスタCB cb = new Mst制御画面マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_NotInScopeSubQuery_Mst制御画面マスタList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "code", "メニューcode", subQueryPropertyName);
        }
        public abstract String keepCode_NotInScopeSubQuery_Mst制御画面マスタList(Mst制御画面マスタCQ subQuery);
        public void xsderiveMst制御画面マスタList(String function, SubQuery<Mst制御画面マスタCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Mst制御画面マスタCB>", subQuery);
            Mst制御画面マスタCB cb = new Mst制御画面マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_SpecifyDerivedReferrer_Mst制御画面マスタList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "code", "メニューcode", subQueryPropertyName, aliasName);
        }
        abstract public String keepCode_SpecifyDerivedReferrer_Mst制御画面マスタList(Mst制御画面マスタCQ subQuery);

        public QDRFunction<Mst制御画面マスタCB> DerivedMst制御画面マスタList() {
            return xcreateQDRFunctionMst制御画面マスタList();
        }
        protected QDRFunction<Mst制御画面マスタCB> xcreateQDRFunctionMst制御画面マスタList() {
            return new QDRFunction<Mst制御画面マスタCB>(delegate(String function, SubQuery<Mst制御画面マスタCB> subQuery, String operand, Object value) {
                xqderiveMst制御画面マスタList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMst制御画面マスタList(String function, SubQuery<Mst制御画面マスタCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<Mst制御画面マスタCB>", subQuery);
            Mst制御画面マスタCB cb = new Mst制御画面マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_QueryDerivedReferrer_Mst制御画面マスタList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepCode_QueryDerivedReferrer_Mst制御画面マスタListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "code", "メニューcode", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepCode_QueryDerivedReferrer_Mst制御画面マスタList(Mst制御画面マスタCQ subQuery);
        public abstract String keepCode_QueryDerivedReferrer_Mst制御画面マスタListParameter(Object parameterValue);
        public void SetCode_IsNull() { regCode(CK_ISN, DUMMY_OBJECT); }
        public void SetCode_IsNotNull() { regCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regCode(ConditionKey k, Object v) { regQ(k, v, getCValueCode(), "code"); }
        protected abstract ConditionValue getCValueCode();

        public void Setメニュー名_Equal(String v) { DoSetメニュー名_Equal(fRES(v)); }
        protected void DoSetメニュー名_Equal(String v) { regメニュー名(CK_EQ, v); }
        public void Setメニュー名_NotEqual(String v) { DoSetメニュー名_NotEqual(fRES(v)); }
        protected void DoSetメニュー名_NotEqual(String v) { regメニュー名(CK_NES, v); }
        public void Setメニュー名_GreaterThan(String v) { regメニュー名(CK_GT, fRES(v)); }
        public void Setメニュー名_LessThan(String v) { regメニュー名(CK_LT, fRES(v)); }
        public void Setメニュー名_GreaterEqual(String v) { regメニュー名(CK_GE, fRES(v)); }
        public void Setメニュー名_LessEqual(String v) { regメニュー名(CK_LE, fRES(v)); }
        public void Setメニュー名_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueメニュー名(), "メニュー名"); }
        public void Setメニュー名_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueメニュー名(), "メニュー名"); }
        public void Setメニュー名_PrefixSearch(String v) { Setメニュー名_LikeSearch(v, cLSOP()); }
        public void Setメニュー名_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueメニュー名(), "メニュー名", option); }
        public void Setメニュー名_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueメニュー名(), "メニュー名", option); }
        protected void regメニュー名(ConditionKey k, Object v) { regQ(k, v, getCValueメニュー名(), "メニュー名"); }
        protected abstract ConditionValue getCValueメニュー名();

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
        public SSQFunction<Kbnメニュー区分CB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Kbnメニュー区分CB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Kbnメニュー区分CB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Kbnメニュー区分CB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Kbnメニュー区分CB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Kbnメニュー区分CB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Kbnメニュー区分CB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Kbnメニュー区分CB>(delegate(String function, SubQuery<Kbnメニュー区分CB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Kbnメニュー区分CB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Kbnメニュー区分CB>", subQuery);
            Kbnメニュー区分CB cb = new Kbnメニュー区分CB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Kbnメニュー区分CQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Kbnメニュー区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbnメニュー区分CB>", subQuery);
            Kbnメニュー区分CB cb = new Kbnメニュー区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "code", "code", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Kbnメニュー区分CQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
