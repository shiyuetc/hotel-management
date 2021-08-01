
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

        public void Setメニューコード_Equal(String v) { DoSetメニューコード_Equal(fRES(v)); }
        /// <summary>
        /// Set the value of ログアウト of メニューコード as equal. { = }
        /// ログアウト: 9999
        /// </summary>
        public void Setメニューコード_Equal_ログアウト() {
            DoSetメニューコード_Equal(CDef.メニュー区分.ログアウト.Code);
        }
        /// <summary>
        /// Set the value of 予約管理 of メニューコード as equal. { = }
        /// 予約管理: 10
        /// </summary>
        public void Setメニューコード_Equal_予約管理() {
            DoSetメニューコード_Equal(CDef.メニュー区分.予約管理.Code);
        }
        /// <summary>
        /// Set the value of 宿泊履歴 of メニューコード as equal. { = }
        /// 宿泊履歴: 20
        /// </summary>
        public void Setメニューコード_Equal_宿泊履歴() {
            DoSetメニューコード_Equal(CDef.メニュー区分.宿泊履歴.Code);
        }
        /// <summary>
        /// Set the value of 顧客管理 of メニューコード as equal. { = }
        /// 顧客管理: 30
        /// </summary>
        public void Setメニューコード_Equal_顧客管理() {
            DoSetメニューコード_Equal(CDef.メニュー区分.顧客管理.Code);
        }
        /// <summary>
        /// Set the value of 従業員管理 of メニューコード as equal. { = }
        /// 従業員管理: 40
        /// </summary>
        public void Setメニューコード_Equal_従業員管理() {
            DoSetメニューコード_Equal(CDef.メニュー区分.従業員管理.Code);
        }
        /// <summary>
        /// Set the value of 客室管理 of メニューコード as equal. { = }
        /// 客室管理: 50
        /// </summary>
        public void Setメニューコード_Equal_客室管理() {
            DoSetメニューコード_Equal(CDef.メニュー区分.客室管理.Code);
        }
        protected void DoSetメニューコード_Equal(String v) { regメニューコード(CK_EQ, v); }
        public void Setメニューコード_NotEqual(String v) { DoSetメニューコード_NotEqual(fRES(v)); }
        /// <summary>
        /// Set the value of ログアウト of メニューコード as notEqual. { &lt;&gt; }
        /// ログアウト: 9999
        /// </summary>
        public void Setメニューコード_NotEqual_ログアウト() {
            DoSetメニューコード_NotEqual(CDef.メニュー区分.ログアウト.Code);
        }
        /// <summary>
        /// Set the value of 予約管理 of メニューコード as notEqual. { &lt;&gt; }
        /// 予約管理: 10
        /// </summary>
        public void Setメニューコード_NotEqual_予約管理() {
            DoSetメニューコード_NotEqual(CDef.メニュー区分.予約管理.Code);
        }
        /// <summary>
        /// Set the value of 宿泊履歴 of メニューコード as notEqual. { &lt;&gt; }
        /// 宿泊履歴: 20
        /// </summary>
        public void Setメニューコード_NotEqual_宿泊履歴() {
            DoSetメニューコード_NotEqual(CDef.メニュー区分.宿泊履歴.Code);
        }
        /// <summary>
        /// Set the value of 顧客管理 of メニューコード as notEqual. { &lt;&gt; }
        /// 顧客管理: 30
        /// </summary>
        public void Setメニューコード_NotEqual_顧客管理() {
            DoSetメニューコード_NotEqual(CDef.メニュー区分.顧客管理.Code);
        }
        /// <summary>
        /// Set the value of 従業員管理 of メニューコード as notEqual. { &lt;&gt; }
        /// 従業員管理: 40
        /// </summary>
        public void Setメニューコード_NotEqual_従業員管理() {
            DoSetメニューコード_NotEqual(CDef.メニュー区分.従業員管理.Code);
        }
        /// <summary>
        /// Set the value of 客室管理 of メニューコード as notEqual. { &lt;&gt; }
        /// 客室管理: 50
        /// </summary>
        public void Setメニューコード_NotEqual_客室管理() {
            DoSetメニューコード_NotEqual(CDef.メニュー区分.客室管理.Code);
        }
        protected void DoSetメニューコード_NotEqual(String v) { regメニューコード(CK_NES, v); }
        public void Setメニューコード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueメニューコード(), "メニューコード"); }
        public void Setメニューコード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueメニューコード(), "メニューコード"); }
        public void ExistsMst画面マスタList(SubQuery<Mst画面マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst画面マスタCB>", subQuery);
            Mst画面マスタCB cb = new Mst画面マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepメニューコード_ExistsSubQuery_Mst画面マスタList(cb.Query());
            registerExistsSubQuery(cb.Query(), "メニューコード", "メニューコード", subQueryPropertyName);
        }
        public abstract String keepメニューコード_ExistsSubQuery_Mst画面マスタList(Mst画面マスタCQ subQuery);
        public void NotExistsMst画面マスタList(SubQuery<Mst画面マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst画面マスタCB>", subQuery);
            Mst画面マスタCB cb = new Mst画面マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepメニューコード_NotExistsSubQuery_Mst画面マスタList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "メニューコード", "メニューコード", subQueryPropertyName);
        }
        public abstract String keepメニューコード_NotExistsSubQuery_Mst画面マスタList(Mst画面マスタCQ subQuery);
        public void InScopeMst画面マスタList(SubQuery<Mst画面マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst画面マスタCB>", subQuery);
            Mst画面マスタCB cb = new Mst画面マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepメニューコード_InScopeSubQuery_Mst画面マスタList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "メニューコード", "メニューコード", subQueryPropertyName);
        }
        public abstract String keepメニューコード_InScopeSubQuery_Mst画面マスタList(Mst画面マスタCQ subQuery);
        public void NotInScopeMst画面マスタList(SubQuery<Mst画面マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst画面マスタCB>", subQuery);
            Mst画面マスタCB cb = new Mst画面マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepメニューコード_NotInScopeSubQuery_Mst画面マスタList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "メニューコード", "メニューコード", subQueryPropertyName);
        }
        public abstract String keepメニューコード_NotInScopeSubQuery_Mst画面マスタList(Mst画面マスタCQ subQuery);
        public void xsderiveMst画面マスタList(String function, SubQuery<Mst画面マスタCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Mst画面マスタCB>", subQuery);
            Mst画面マスタCB cb = new Mst画面マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepメニューコード_SpecifyDerivedReferrer_Mst画面マスタList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "メニューコード", "メニューコード", subQueryPropertyName, aliasName);
        }
        abstract public String keepメニューコード_SpecifyDerivedReferrer_Mst画面マスタList(Mst画面マスタCQ subQuery);

        public QDRFunction<Mst画面マスタCB> DerivedMst画面マスタList() {
            return xcreateQDRFunctionMst画面マスタList();
        }
        protected QDRFunction<Mst画面マスタCB> xcreateQDRFunctionMst画面マスタList() {
            return new QDRFunction<Mst画面マスタCB>(delegate(String function, SubQuery<Mst画面マスタCB> subQuery, String operand, Object value) {
                xqderiveMst画面マスタList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMst画面マスタList(String function, SubQuery<Mst画面マスタCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<Mst画面マスタCB>", subQuery);
            Mst画面マスタCB cb = new Mst画面マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepメニューコード_QueryDerivedReferrer_Mst画面マスタList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepメニューコード_QueryDerivedReferrer_Mst画面マスタListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "メニューコード", "メニューコード", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepメニューコード_QueryDerivedReferrer_Mst画面マスタList(Mst画面マスタCQ subQuery);
        public abstract String keepメニューコード_QueryDerivedReferrer_Mst画面マスタListParameter(Object parameterValue);
        public void Setメニューコード_IsNull() { regメニューコード(CK_ISN, DUMMY_OBJECT); }
        public void Setメニューコード_IsNotNull() { regメニューコード(CK_ISNN, DUMMY_OBJECT); }
        protected void regメニューコード(ConditionKey k, Object v) { regQ(k, v, getCValueメニューコード(), "メニューコード"); }
        protected abstract ConditionValue getCValueメニューコード();

        public void Setメニュー名称_Equal(String v) { DoSetメニュー名称_Equal(fRES(v)); }
        protected void DoSetメニュー名称_Equal(String v) { regメニュー名称(CK_EQ, v); }
        public void Setメニュー名称_NotEqual(String v) { DoSetメニュー名称_NotEqual(fRES(v)); }
        protected void DoSetメニュー名称_NotEqual(String v) { regメニュー名称(CK_NES, v); }
        public void Setメニュー名称_GreaterThan(String v) { regメニュー名称(CK_GT, fRES(v)); }
        public void Setメニュー名称_LessThan(String v) { regメニュー名称(CK_LT, fRES(v)); }
        public void Setメニュー名称_GreaterEqual(String v) { regメニュー名称(CK_GE, fRES(v)); }
        public void Setメニュー名称_LessEqual(String v) { regメニュー名称(CK_LE, fRES(v)); }
        public void Setメニュー名称_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueメニュー名称(), "メニュー名称"); }
        public void Setメニュー名称_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueメニュー名称(), "メニュー名称"); }
        public void Setメニュー名称_PrefixSearch(String v) { Setメニュー名称_LikeSearch(v, cLSOP()); }
        public void Setメニュー名称_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueメニュー名称(), "メニュー名称", option); }
        public void Setメニュー名称_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueメニュー名称(), "メニュー名称", option); }
        protected void regメニュー名称(ConditionKey k, Object v) { regQ(k, v, getCValueメニュー名称(), "メニュー名称"); }
        protected abstract ConditionValue getCValueメニュー名称();

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
            registerInScopeSubQuery(cb.Query(), "メニューコード", "メニューコード", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Kbnメニュー区分CQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
