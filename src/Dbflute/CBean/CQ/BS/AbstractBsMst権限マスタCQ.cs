
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
    public abstract class AbstractBsMst権限マスタCQ : AbstractConditionQuery {

        public AbstractBsMst権限マスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "mst権限マスタ"; }
        public override String getTableSqlName() { return "mst権限マスタ"; }

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

        public void Set職位code_Equal(String v) { DoSet職位code_Equal(fRES(v)); }
        /// <summary>
        /// Set the value of システム保守 of 職位code as equal. { = }
        /// システム保守: System Maintenancer
        /// </summary>
        public void Set職位code_Equal_システム保守() {
            DoSet職位code_Equal(CDef.職位区分.システム保守.Code);
        }
        /// <summary>
        /// Set the value of アシスタントマネージャー of 職位code as equal. { = }
        /// アシスタントマネージャー: Assistant Manager
        /// </summary>
        public void Set職位code_Equal_アシスタントマネージャー() {
            DoSet職位code_Equal(CDef.職位区分.アシスタントマネージャー.Code);
        }
        /// <summary>
        /// Set the value of ファイナンシャルコントローラー of 職位code as equal. { = }
        /// ファイナンシャルコントローラー: Financial Controller
        /// </summary>
        public void Set職位code_Equal_ファイナンシャルコントローラー() {
            DoSet職位code_Equal(CDef.職位区分.ファイナンシャルコントローラー.Code);
        }
        /// <summary>
        /// Set the value of フロントクラーク of 職位code as equal. { = }
        /// フロントクラーク: Front Clerk
        /// </summary>
        public void Set職位code_Equal_フロントクラーク() {
            DoSet職位code_Equal(CDef.職位区分.フロントクラーク.Code);
        }
        protected void DoSet職位code_Equal(String v) { reg職位code(CK_EQ, v); }
        public void Set職位code_NotEqual(String v) { DoSet職位code_NotEqual(fRES(v)); }
        /// <summary>
        /// Set the value of システム保守 of 職位code as notEqual. { &lt;&gt; }
        /// システム保守: System Maintenancer
        /// </summary>
        public void Set職位code_NotEqual_システム保守() {
            DoSet職位code_NotEqual(CDef.職位区分.システム保守.Code);
        }
        /// <summary>
        /// Set the value of アシスタントマネージャー of 職位code as notEqual. { &lt;&gt; }
        /// アシスタントマネージャー: Assistant Manager
        /// </summary>
        public void Set職位code_NotEqual_アシスタントマネージャー() {
            DoSet職位code_NotEqual(CDef.職位区分.アシスタントマネージャー.Code);
        }
        /// <summary>
        /// Set the value of ファイナンシャルコントローラー of 職位code as notEqual. { &lt;&gt; }
        /// ファイナンシャルコントローラー: Financial Controller
        /// </summary>
        public void Set職位code_NotEqual_ファイナンシャルコントローラー() {
            DoSet職位code_NotEqual(CDef.職位区分.ファイナンシャルコントローラー.Code);
        }
        /// <summary>
        /// Set the value of フロントクラーク of 職位code as notEqual. { &lt;&gt; }
        /// フロントクラーク: Front Clerk
        /// </summary>
        public void Set職位code_NotEqual_フロントクラーク() {
            DoSet職位code_NotEqual(CDef.職位区分.フロントクラーク.Code);
        }
        protected void DoSet職位code_NotEqual(String v) { reg職位code(CK_NES, v); }
        public void Set職位code_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue職位code(), "職位code"); }
        public void Set職位code_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue職位code(), "職位code"); }
        public void InScopeKbn職位区分(SubQuery<Kbn職位区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbn職位区分CB>", subQuery);
            Kbn職位区分CB cb = new Kbn職位区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位code_InScopeSubQuery_Kbn職位区分(cb.Query());
            registerInScopeSubQuery(cb.Query(), "職位code", "code", subQueryPropertyName);
        }
        public abstract String keep職位code_InScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery);
        public void NotInScopeKbn職位区分(SubQuery<Kbn職位区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbn職位区分CB>", subQuery);
            Kbn職位区分CB cb = new Kbn職位区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位code_NotInScopeSubQuery_Kbn職位区分(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "職位code", "code", subQueryPropertyName);
        }
        public abstract String keep職位code_NotInScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery);
        protected void reg職位code(ConditionKey k, Object v) { regQ(k, v, getCValue職位code(), "職位code"); }
        protected abstract ConditionValue getCValue職位code();

        public void Set制御画面id_Equal(long? v) { reg制御画面id(CK_EQ, v); }
        public void Set制御画面id_NotEqual(long? v) { reg制御画面id(CK_NES, v); }
        public void Set制御画面id_GreaterThan(long? v) { reg制御画面id(CK_GT, v); }
        public void Set制御画面id_LessThan(long? v) { reg制御画面id(CK_LT, v); }
        public void Set制御画面id_GreaterEqual(long? v) { reg制御画面id(CK_GE, v); }
        public void Set制御画面id_LessEqual(long? v) { reg制御画面id(CK_LE, v); }
        public void Set制御画面id_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValue制御画面id(), "制御画面id"); }
        public void Set制御画面id_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValue制御画面id(), "制御画面id"); }
        public void InScopeMst制御画面マスタ(SubQuery<Mst制御画面マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst制御画面マスタCB>", subQuery);
            Mst制御画面マスタCB cb = new Mst制御画面マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep制御画面id_InScopeSubQuery_Mst制御画面マスタ(cb.Query());
            registerInScopeSubQuery(cb.Query(), "制御画面id", "id", subQueryPropertyName);
        }
        public abstract String keep制御画面id_InScopeSubQuery_Mst制御画面マスタ(Mst制御画面マスタCQ subQuery);
        public void NotInScopeMst制御画面マスタ(SubQuery<Mst制御画面マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst制御画面マスタCB>", subQuery);
            Mst制御画面マスタCB cb = new Mst制御画面マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep制御画面id_NotInScopeSubQuery_Mst制御画面マスタ(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "制御画面id", "id", subQueryPropertyName);
        }
        public abstract String keep制御画面id_NotInScopeSubQuery_Mst制御画面マスタ(Mst制御画面マスタCQ subQuery);
        protected void reg制御画面id(ConditionKey k, Object v) { regQ(k, v, getCValue制御画面id(), "制御画面id"); }
        protected abstract ConditionValue getCValue制御画面id();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<Mst権限マスタCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Mst権限マスタCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Mst権限マスタCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Mst権限マスタCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Mst権限マスタCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Mst権限マスタCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Mst権限マスタCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Mst権限マスタCB>(delegate(String function, SubQuery<Mst権限マスタCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Mst権限マスタCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Mst権限マスタCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "id", "id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Mst権限マスタCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
