
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
    public abstract class AbstractBsDch従業員職位履歴台帳CQ : AbstractConditionQuery {

        public AbstractBsDch従業員職位履歴台帳CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "dch従業員職位履歴台帳"; }
        public override String getTableSqlName() { return "dch従業員職位履歴台帳"; }

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

        public void Set従業員id_Equal(long? v) { reg従業員id(CK_EQ, v); }
        public void Set従業員id_NotEqual(long? v) { reg従業員id(CK_NES, v); }
        public void Set従業員id_GreaterThan(long? v) { reg従業員id(CK_GT, v); }
        public void Set従業員id_LessThan(long? v) { reg従業員id(CK_LT, v); }
        public void Set従業員id_GreaterEqual(long? v) { reg従業員id(CK_GE, v); }
        public void Set従業員id_LessEqual(long? v) { reg従業員id(CK_LE, v); }
        public void Set従業員id_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValue従業員id(), "従業員id"); }
        public void Set従業員id_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValue従業員id(), "従業員id"); }
        public void InScopeMst従業員マスタ(SubQuery<Mst従業員マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst従業員マスタCB>", subQuery);
            Mst従業員マスタCB cb = new Mst従業員マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep従業員id_InScopeSubQuery_Mst従業員マスタ(cb.Query());
            registerInScopeSubQuery(cb.Query(), "従業員id", "id", subQueryPropertyName);
        }
        public abstract String keep従業員id_InScopeSubQuery_Mst従業員マスタ(Mst従業員マスタCQ subQuery);
        public void NotInScopeMst従業員マスタ(SubQuery<Mst従業員マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst従業員マスタCB>", subQuery);
            Mst従業員マスタCB cb = new Mst従業員マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep従業員id_NotInScopeSubQuery_Mst従業員マスタ(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "従業員id", "id", subQueryPropertyName);
        }
        public abstract String keep従業員id_NotInScopeSubQuery_Mst従業員マスタ(Mst従業員マスタCQ subQuery);
        protected void reg従業員id(ConditionKey k, Object v) { regQ(k, v, getCValue従業員id(), "従業員id"); }
        protected abstract ConditionValue getCValue従業員id();

        public void Set適用開始日_Equal(DateTime? v) { reg適用開始日(CK_EQ, v); }
        public void Set適用開始日_GreaterThan(DateTime? v) { reg適用開始日(CK_GT, v); }
        public void Set適用開始日_LessThan(DateTime? v) { reg適用開始日(CK_LT, v); }
        public void Set適用開始日_GreaterEqual(DateTime? v) { reg適用開始日(CK_GE, v); }
        public void Set適用開始日_LessEqual(DateTime? v) { reg適用開始日(CK_LE, v); }
        public void Set適用開始日_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValue適用開始日(), "適用開始日", option); }
        public void Set適用開始日_DateFromTo(DateTime? from, DateTime? to) { Set適用開始日_FromTo(from, to, new DateFromToOption()); }
        protected void reg適用開始日(ConditionKey k, Object v) { regQ(k, v, getCValue適用開始日(), "適用開始日"); }
        protected abstract ConditionValue getCValue適用開始日();

        public void Set適用終了日_Equal(DateTime? v) { reg適用終了日(CK_EQ, v); }
        public void Set適用終了日_GreaterThan(DateTime? v) { reg適用終了日(CK_GT, v); }
        public void Set適用終了日_LessThan(DateTime? v) { reg適用終了日(CK_LT, v); }
        public void Set適用終了日_GreaterEqual(DateTime? v) { reg適用終了日(CK_GE, v); }
        public void Set適用終了日_LessEqual(DateTime? v) { reg適用終了日(CK_LE, v); }
        public void Set適用終了日_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValue適用終了日(), "適用終了日", option); }
        public void Set適用終了日_DateFromTo(DateTime? from, DateTime? to) { Set適用終了日_FromTo(from, to, new DateFromToOption()); }
        protected void reg適用終了日(ConditionKey k, Object v) { regQ(k, v, getCValue適用終了日(), "適用終了日"); }
        protected abstract ConditionValue getCValue適用終了日();

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

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<Dch従業員職位履歴台帳CB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Dch従業員職位履歴台帳CB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Dch従業員職位履歴台帳CB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Dch従業員職位履歴台帳CB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Dch従業員職位履歴台帳CB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Dch従業員職位履歴台帳CB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Dch従業員職位履歴台帳CB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Dch従業員職位履歴台帳CB>(delegate(String function, SubQuery<Dch従業員職位履歴台帳CB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Dch従業員職位履歴台帳CB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Dch従業員職位履歴台帳CQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Dch従業員職位履歴台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "id", "id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Dch従業員職位履歴台帳CQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
