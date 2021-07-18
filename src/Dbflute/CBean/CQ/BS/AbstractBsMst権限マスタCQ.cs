
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
            registerInScopeSubQuery(cb.Query(), "職位コード", "コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_InScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery);
        public void NotInScopeKbn職位区分(SubQuery<Kbn職位区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbn職位区分CB>", subQuery);
            Kbn職位区分CB cb = new Kbn職位区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_NotInScopeSubQuery_Kbn職位区分(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "職位コード", "コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_NotInScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery);
        protected void reg職位コード(ConditionKey k, Object v) { regQ(k, v, getCValue職位コード(), "職位コード"); }
        protected abstract ConditionValue getCValue職位コード();

        public void Set権限コード_Equal(String v) { DoSet権限コード_Equal(fRES(v)); }
        protected void DoSet権限コード_Equal(String v) { reg権限コード(CK_EQ, v); }
        public void Set権限コード_NotEqual(String v) { DoSet権限コード_NotEqual(fRES(v)); }
        protected void DoSet権限コード_NotEqual(String v) { reg権限コード(CK_NES, v); }
        public void Set権限コード_GreaterThan(String v) { reg権限コード(CK_GT, fRES(v)); }
        public void Set権限コード_LessThan(String v) { reg権限コード(CK_LT, fRES(v)); }
        public void Set権限コード_GreaterEqual(String v) { reg権限コード(CK_GE, fRES(v)); }
        public void Set権限コード_LessEqual(String v) { reg権限コード(CK_LE, fRES(v)); }
        public void Set権限コード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue権限コード(), "権限コード"); }
        public void Set権限コード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue権限コード(), "権限コード"); }
        public void Set権限コード_PrefixSearch(String v) { Set権限コード_LikeSearch(v, cLSOP()); }
        public void Set権限コード_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue権限コード(), "権限コード", option); }
        public void Set権限コード_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue権限コード(), "権限コード", option); }
        public void InScopeKbn権限区分(SubQuery<Kbn権限区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbn権限区分CB>", subQuery);
            Kbn権限区分CB cb = new Kbn権限区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep権限コード_InScopeSubQuery_Kbn権限区分(cb.Query());
            registerInScopeSubQuery(cb.Query(), "権限コード", "コード", subQueryPropertyName);
        }
        public abstract String keep権限コード_InScopeSubQuery_Kbn権限区分(Kbn権限区分CQ subQuery);
        public void NotInScopeKbn権限区分(SubQuery<Kbn権限区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbn権限区分CB>", subQuery);
            Kbn権限区分CB cb = new Kbn権限区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep権限コード_NotInScopeSubQuery_Kbn権限区分(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "権限コード", "コード", subQueryPropertyName);
        }
        public abstract String keep権限コード_NotInScopeSubQuery_Kbn権限区分(Kbn権限区分CQ subQuery);
        protected void reg権限コード(ConditionKey k, Object v) { regQ(k, v, getCValue権限コード(), "権限コード"); }
        protected abstract ConditionValue getCValue権限コード();

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
