
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
    public abstract class AbstractBsKbn職位区分CQ : AbstractConditionQuery {

        public AbstractBsKbn職位区分CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "kbn職位区分"; }
        public override String getTableSqlName() { return "kbn職位区分"; }

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
        public void ExistsDch従業員職位履歴台帳List(SubQuery<Dch従業員職位履歴台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_ExistsSubQuery_Dch従業員職位履歴台帳List(cb.Query());
            registerExistsSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_ExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public void ExistsMst従業員マスタList(SubQuery<Mst従業員マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst従業員マスタCB>", subQuery);
            Mst従業員マスタCB cb = new Mst従業員マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_ExistsSubQuery_Mst従業員マスタList(cb.Query());
            registerExistsSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_ExistsSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery);
        public void ExistsMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_ExistsSubQuery_Mst権限マスタList(cb.Query());
            registerExistsSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_ExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void NotExistsDch従業員職位履歴台帳List(SubQuery<Dch従業員職位履歴台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_NotExistsSubQuery_Dch従業員職位履歴台帳List(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_NotExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public void NotExistsMst従業員マスタList(SubQuery<Mst従業員マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst従業員マスタCB>", subQuery);
            Mst従業員マスタCB cb = new Mst従業員マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_NotExistsSubQuery_Mst従業員マスタList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_NotExistsSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery);
        public void NotExistsMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_NotExistsSubQuery_Mst権限マスタList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_NotExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void InScopeDch従業員職位履歴台帳List(SubQuery<Dch従業員職位履歴台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_InScopeSubQuery_Dch従業員職位履歴台帳List(cb.Query());
            registerInScopeSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_InScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public void InScopeMst従業員マスタList(SubQuery<Mst従業員マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst従業員マスタCB>", subQuery);
            Mst従業員マスタCB cb = new Mst従業員マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_InScopeSubQuery_Mst従業員マスタList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_InScopeSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery);
        public void InScopeMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_InScopeSubQuery_Mst権限マスタList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_InScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void NotInScopeDch従業員職位履歴台帳List(SubQuery<Dch従業員職位履歴台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_NotInScopeSubQuery_Dch従業員職位履歴台帳List(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_NotInScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public void NotInScopeMst従業員マスタList(SubQuery<Mst従業員マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst従業員マスタCB>", subQuery);
            Mst従業員マスタCB cb = new Mst従業員マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_NotInScopeSubQuery_Mst従業員マスタList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_NotInScopeSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery);
        public void NotInScopeMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_NotInScopeSubQuery_Mst権限マスタList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keep職位コード_NotInScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void xsderiveDch従業員職位履歴台帳List(String function, SubQuery<Dch従業員職位履歴台帳CB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "職位コード", "職位コード", subQueryPropertyName, aliasName);
        }
        abstract public String keep職位コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public void xsderiveMst従業員マスタList(String function, SubQuery<Mst従業員マスタCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Mst従業員マスタCB>", subQuery);
            Mst従業員マスタCB cb = new Mst従業員マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_SpecifyDerivedReferrer_Mst従業員マスタList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "職位コード", "職位コード", subQueryPropertyName, aliasName);
        }
        abstract public String keep職位コード_SpecifyDerivedReferrer_Mst従業員マスタList(Mst従業員マスタCQ subQuery);
        public void xsderiveMst権限マスタList(String function, SubQuery<Mst権限マスタCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_SpecifyDerivedReferrer_Mst権限マスタList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "職位コード", "職位コード", subQueryPropertyName, aliasName);
        }
        abstract public String keep職位コード_SpecifyDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery);

        public QDRFunction<Dch従業員職位履歴台帳CB> DerivedDch従業員職位履歴台帳List() {
            return xcreateQDRFunctionDch従業員職位履歴台帳List();
        }
        protected QDRFunction<Dch従業員職位履歴台帳CB> xcreateQDRFunctionDch従業員職位履歴台帳List() {
            return new QDRFunction<Dch従業員職位履歴台帳CB>(delegate(String function, SubQuery<Dch従業員職位履歴台帳CB> subQuery, String operand, Object value) {
                xqderiveDch従業員職位履歴台帳List(function, subQuery, operand, value);
            });
        }
        public void xqderiveDch従業員職位履歴台帳List(String function, SubQuery<Dch従業員職位履歴台帳CB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳List(cb.Query()); // for saving query-value.
            String parameterPropertyName = keep職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "職位コード", "職位コード", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keep職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public abstract String keep職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter(Object parameterValue);

        public QDRFunction<Mst従業員マスタCB> DerivedMst従業員マスタList() {
            return xcreateQDRFunctionMst従業員マスタList();
        }
        protected QDRFunction<Mst従業員マスタCB> xcreateQDRFunctionMst従業員マスタList() {
            return new QDRFunction<Mst従業員マスタCB>(delegate(String function, SubQuery<Mst従業員マスタCB> subQuery, String operand, Object value) {
                xqderiveMst従業員マスタList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMst従業員マスタList(String function, SubQuery<Mst従業員マスタCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<Mst従業員マスタCB>", subQuery);
            Mst従業員マスタCB cb = new Mst従業員マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep職位コード_QueryDerivedReferrer_Mst従業員マスタList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keep職位コード_QueryDerivedReferrer_Mst従業員マスタListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "職位コード", "職位コード", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keep職位コード_QueryDerivedReferrer_Mst従業員マスタList(Mst従業員マスタCQ subQuery);
        public abstract String keep職位コード_QueryDerivedReferrer_Mst従業員マスタListParameter(Object parameterValue);

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
            String subQueryPropertyName = keep職位コード_QueryDerivedReferrer_Mst権限マスタList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keep職位コード_QueryDerivedReferrer_Mst権限マスタListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "職位コード", "職位コード", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keep職位コード_QueryDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public abstract String keep職位コード_QueryDerivedReferrer_Mst権限マスタListParameter(Object parameterValue);
        public void Set職位コード_IsNull() { reg職位コード(CK_ISN, DUMMY_OBJECT); }
        public void Set職位コード_IsNotNull() { reg職位コード(CK_ISNN, DUMMY_OBJECT); }
        protected void reg職位コード(ConditionKey k, Object v) { regQ(k, v, getCValue職位コード(), "職位コード"); }
        protected abstract ConditionValue getCValue職位コード();

        public void Set職位名称_Equal(String v) { DoSet職位名称_Equal(fRES(v)); }
        protected void DoSet職位名称_Equal(String v) { reg職位名称(CK_EQ, v); }
        public void Set職位名称_NotEqual(String v) { DoSet職位名称_NotEqual(fRES(v)); }
        protected void DoSet職位名称_NotEqual(String v) { reg職位名称(CK_NES, v); }
        public void Set職位名称_GreaterThan(String v) { reg職位名称(CK_GT, fRES(v)); }
        public void Set職位名称_LessThan(String v) { reg職位名称(CK_LT, fRES(v)); }
        public void Set職位名称_GreaterEqual(String v) { reg職位名称(CK_GE, fRES(v)); }
        public void Set職位名称_LessEqual(String v) { reg職位名称(CK_LE, fRES(v)); }
        public void Set職位名称_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue職位名称(), "職位名称"); }
        public void Set職位名称_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue職位名称(), "職位名称"); }
        public void Set職位名称_PrefixSearch(String v) { Set職位名称_LikeSearch(v, cLSOP()); }
        public void Set職位名称_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue職位名称(), "職位名称", option); }
        public void Set職位名称_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue職位名称(), "職位名称", option); }
        protected void reg職位名称(ConditionKey k, Object v) { regQ(k, v, getCValue職位名称(), "職位名称"); }
        protected abstract ConditionValue getCValue職位名称();

        public void Set職位英字名称_Equal(String v) { DoSet職位英字名称_Equal(fRES(v)); }
        protected void DoSet職位英字名称_Equal(String v) { reg職位英字名称(CK_EQ, v); }
        public void Set職位英字名称_NotEqual(String v) { DoSet職位英字名称_NotEqual(fRES(v)); }
        protected void DoSet職位英字名称_NotEqual(String v) { reg職位英字名称(CK_NES, v); }
        public void Set職位英字名称_GreaterThan(String v) { reg職位英字名称(CK_GT, fRES(v)); }
        public void Set職位英字名称_LessThan(String v) { reg職位英字名称(CK_LT, fRES(v)); }
        public void Set職位英字名称_GreaterEqual(String v) { reg職位英字名称(CK_GE, fRES(v)); }
        public void Set職位英字名称_LessEqual(String v) { reg職位英字名称(CK_LE, fRES(v)); }
        public void Set職位英字名称_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue職位英字名称(), "職位英字名称"); }
        public void Set職位英字名称_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue職位英字名称(), "職位英字名称"); }
        public void Set職位英字名称_PrefixSearch(String v) { Set職位英字名称_LikeSearch(v, cLSOP()); }
        public void Set職位英字名称_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue職位英字名称(), "職位英字名称", option); }
        public void Set職位英字名称_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue職位英字名称(), "職位英字名称", option); }
        protected void reg職位英字名称(ConditionKey k, Object v) { regQ(k, v, getCValue職位英字名称(), "職位英字名称"); }
        protected abstract ConditionValue getCValue職位英字名称();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<Kbn職位区分CB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Kbn職位区分CB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Kbn職位区分CB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Kbn職位区分CB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Kbn職位区分CB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Kbn職位区分CB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Kbn職位区分CB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Kbn職位区分CB>(delegate(String function, SubQuery<Kbn職位区分CB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Kbn職位区分CB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Kbn職位区分CB>", subQuery);
            Kbn職位区分CB cb = new Kbn職位区分CB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Kbn職位区分CQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Kbn職位区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbn職位区分CB>", subQuery);
            Kbn職位区分CB cb = new Kbn職位区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "職位コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Kbn職位区分CQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
