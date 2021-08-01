
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
            registerInScopeSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_InScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery);
        public void NotInScopeKbn職位区分(SubQuery<Kbn職位区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbn職位区分CB>", subQuery);
            Kbn職位区分CB cb = new Kbn職位区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_NotInScopeSubQuery_Kbn職位区分(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_NotInScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery);
        public void Set職位コード_IsNull() { reg職位コード(CK_ISN, DUMMY_OBJECT); }
        public void Set職位コード_IsNotNull() { reg職位コード(CK_ISNN, DUMMY_OBJECT); }
        protected void reg職位コード(ConditionKey k, Object v) { regQ(k, v, getCValue職位コード(), "職位コード"); }
        protected abstract ConditionValue getCValue職位コード();

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
        public void InScopeMst画面マスタ(SubQuery<Mst画面マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst画面マスタCB>", subQuery);
            Mst画面マスタCB cb = new Mst画面マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep画面コード_InScopeSubQuery_Mst画面マスタ(cb.Query());
            registerInScopeSubQuery(cb.Query(), "画面コード", "画面コード", subQueryPropertyName);
        }
        public abstract String keep画面コード_InScopeSubQuery_Mst画面マスタ(Mst画面マスタCQ subQuery);
        public void NotInScopeMst画面マスタ(SubQuery<Mst画面マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst画面マスタCB>", subQuery);
            Mst画面マスタCB cb = new Mst画面マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep画面コード_NotInScopeSubQuery_Mst画面マスタ(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "画面コード", "画面コード", subQueryPropertyName);
        }
        public abstract String keep画面コード_NotInScopeSubQuery_Mst画面マスタ(Mst画面マスタCQ subQuery);
        public void Set画面コード_IsNull() { reg画面コード(CK_ISN, DUMMY_OBJECT); }
        public void Set画面コード_IsNotNull() { reg画面コード(CK_ISNN, DUMMY_OBJECT); }
        protected void reg画面コード(ConditionKey k, Object v) { regQ(k, v, getCValue画面コード(), "画面コード"); }
        protected abstract ConditionValue getCValue画面コード();

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
