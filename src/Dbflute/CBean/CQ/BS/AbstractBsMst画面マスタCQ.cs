
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
    public abstract class AbstractBsMst画面マスタCQ : AbstractConditionQuery {

        public AbstractBsMst画面マスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "mst画面マスタ"; }
        public override String getTableSqlName() { return "mst画面マスタ"; }

        public void Set画面コード_Equal(String v) { DoSet画面コード_Equal(fRES(v)); }
        protected void DoSet画面コード_Equal(String v) { reg画面コード(CK_EQ, v); }
        public void Set画面コード_NotEqual(String v) { DoSet画面コード_NotEqual(fRES(v)); }
        protected void DoSet画面コード_NotEqual(String v) { reg画面コード(CK_NES, v); }
        public void Set画面コード_GreaterThan(String v) { reg画面コード(CK_GT, fRES(v)); }
        public void Set画面コード_LessThan(String v) { reg画面コード(CK_LT, fRES(v)); }
        public void Set画面コード_GreaterEqual(String v) { reg画面コード(CK_GE, fRES(v)); }
        public void Set画面コード_LessEqual(String v) { reg画面コード(CK_LE, fRES(v)); }
        public void Set画面コード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue画面コード(), "画面コード"); }
        public void Set画面コード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue画面コード(), "画面コード"); }
        public void Set画面コード_PrefixSearch(String v) { Set画面コード_LikeSearch(v, cLSOP()); }
        public void Set画面コード_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue画面コード(), "画面コード", option); }
        public void Set画面コード_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue画面コード(), "画面コード", option); }
        public void ExistsMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep画面コード_ExistsSubQuery_Mst権限マスタList(cb.Query());
            registerExistsSubQuery(cb.Query(), "画面コード", "画面コード", subQueryPropertyName);
        }
        public abstract String keep画面コード_ExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void NotExistsMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep画面コード_NotExistsSubQuery_Mst権限マスタList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "画面コード", "画面コード", subQueryPropertyName);
        }
        public abstract String keep画面コード_NotExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void InScopeMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep画面コード_InScopeSubQuery_Mst権限マスタList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "画面コード", "画面コード", subQueryPropertyName);
        }
        public abstract String keep画面コード_InScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void NotInScopeMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep画面コード_NotInScopeSubQuery_Mst権限マスタList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "画面コード", "画面コード", subQueryPropertyName);
        }
        public abstract String keep画面コード_NotInScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void xsderiveMst権限マスタList(String function, SubQuery<Mst権限マスタCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep画面コード_SpecifyDerivedReferrer_Mst権限マスタList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "画面コード", "画面コード", subQueryPropertyName, aliasName);
        }
        abstract public String keep画面コード_SpecifyDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery);

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
            String subQueryPropertyName = keep画面コード_QueryDerivedReferrer_Mst権限マスタList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keep画面コード_QueryDerivedReferrer_Mst権限マスタListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "画面コード", "画面コード", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keep画面コード_QueryDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public abstract String keep画面コード_QueryDerivedReferrer_Mst権限マスタListParameter(Object parameterValue);
        public void Set画面コード_IsNull() { reg画面コード(CK_ISN, DUMMY_OBJECT); }
        public void Set画面コード_IsNotNull() { reg画面コード(CK_ISNN, DUMMY_OBJECT); }
        protected void reg画面コード(ConditionKey k, Object v) { regQ(k, v, getCValue画面コード(), "画面コード"); }
        protected abstract ConditionValue getCValue画面コード();

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
        public void InScopeKbnメニュー区分(SubQuery<Kbnメニュー区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbnメニュー区分CB>", subQuery);
            Kbnメニュー区分CB cb = new Kbnメニュー区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepメニューコード_InScopeSubQuery_Kbnメニュー区分(cb.Query());
            registerInScopeSubQuery(cb.Query(), "メニューコード", "メニューコード", subQueryPropertyName);
        }
        public abstract String keepメニューコード_InScopeSubQuery_Kbnメニュー区分(Kbnメニュー区分CQ subQuery);
        public void NotInScopeKbnメニュー区分(SubQuery<Kbnメニュー区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbnメニュー区分CB>", subQuery);
            Kbnメニュー区分CB cb = new Kbnメニュー区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepメニューコード_NotInScopeSubQuery_Kbnメニュー区分(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "メニューコード", "メニューコード", subQueryPropertyName);
        }
        public abstract String keepメニューコード_NotInScopeSubQuery_Kbnメニュー区分(Kbnメニュー区分CQ subQuery);
        protected void regメニューコード(ConditionKey k, Object v) { regQ(k, v, getCValueメニューコード(), "メニューコード"); }
        protected abstract ConditionValue getCValueメニューコード();

        public void Set画面名称_Equal(String v) { DoSet画面名称_Equal(fRES(v)); }
        protected void DoSet画面名称_Equal(String v) { reg画面名称(CK_EQ, v); }
        public void Set画面名称_NotEqual(String v) { DoSet画面名称_NotEqual(fRES(v)); }
        protected void DoSet画面名称_NotEqual(String v) { reg画面名称(CK_NES, v); }
        public void Set画面名称_GreaterThan(String v) { reg画面名称(CK_GT, fRES(v)); }
        public void Set画面名称_LessThan(String v) { reg画面名称(CK_LT, fRES(v)); }
        public void Set画面名称_GreaterEqual(String v) { reg画面名称(CK_GE, fRES(v)); }
        public void Set画面名称_LessEqual(String v) { reg画面名称(CK_LE, fRES(v)); }
        public void Set画面名称_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue画面名称(), "画面名称"); }
        public void Set画面名称_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue画面名称(), "画面名称"); }
        public void Set画面名称_PrefixSearch(String v) { Set画面名称_LikeSearch(v, cLSOP()); }
        public void Set画面名称_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue画面名称(), "画面名称", option); }
        public void Set画面名称_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue画面名称(), "画面名称", option); }
        protected void reg画面名称(ConditionKey k, Object v) { regQ(k, v, getCValue画面名称(), "画面名称"); }
        protected abstract ConditionValue getCValue画面名称();

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
        public SSQFunction<Mst画面マスタCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Mst画面マスタCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Mst画面マスタCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Mst画面マスタCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Mst画面マスタCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Mst画面マスタCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Mst画面マスタCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Mst画面マスタCB>(delegate(String function, SubQuery<Mst画面マスタCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Mst画面マスタCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Mst画面マスタCB>", subQuery);
            Mst画面マスタCB cb = new Mst画面マスタCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Mst画面マスタCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Mst画面マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst画面マスタCB>", subQuery);
            Mst画面マスタCB cb = new Mst画面マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "画面コード", "画面コード", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Mst画面マスタCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
