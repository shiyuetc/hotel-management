
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

        public void Setコード_Equal(String v) { DoSetコード_Equal(fRES(v)); }
        /// <summary>
        /// Set the value of システム保守 of コード as equal. { = }
        /// システム保守: System Maintenancer
        /// </summary>
        public void Setコード_Equal_システム保守() {
            DoSetコード_Equal(CDef.職位区分.システム保守.Code);
        }
        /// <summary>
        /// Set the value of アシスタントマネージャー of コード as equal. { = }
        /// アシスタントマネージャー: Assistant Manager
        /// </summary>
        public void Setコード_Equal_アシスタントマネージャー() {
            DoSetコード_Equal(CDef.職位区分.アシスタントマネージャー.Code);
        }
        /// <summary>
        /// Set the value of ファイナンシャルコントローラー of コード as equal. { = }
        /// ファイナンシャルコントローラー: Financial Controller
        /// </summary>
        public void Setコード_Equal_ファイナンシャルコントローラー() {
            DoSetコード_Equal(CDef.職位区分.ファイナンシャルコントローラー.Code);
        }
        /// <summary>
        /// Set the value of フロントクラーク of コード as equal. { = }
        /// フロントクラーク: Front Clerk
        /// </summary>
        public void Setコード_Equal_フロントクラーク() {
            DoSetコード_Equal(CDef.職位区分.フロントクラーク.Code);
        }
        protected void DoSetコード_Equal(String v) { regコード(CK_EQ, v); }
        public void Setコード_NotEqual(String v) { DoSetコード_NotEqual(fRES(v)); }
        /// <summary>
        /// Set the value of システム保守 of コード as notEqual. { &lt;&gt; }
        /// システム保守: System Maintenancer
        /// </summary>
        public void Setコード_NotEqual_システム保守() {
            DoSetコード_NotEqual(CDef.職位区分.システム保守.Code);
        }
        /// <summary>
        /// Set the value of アシスタントマネージャー of コード as notEqual. { &lt;&gt; }
        /// アシスタントマネージャー: Assistant Manager
        /// </summary>
        public void Setコード_NotEqual_アシスタントマネージャー() {
            DoSetコード_NotEqual(CDef.職位区分.アシスタントマネージャー.Code);
        }
        /// <summary>
        /// Set the value of ファイナンシャルコントローラー of コード as notEqual. { &lt;&gt; }
        /// ファイナンシャルコントローラー: Financial Controller
        /// </summary>
        public void Setコード_NotEqual_ファイナンシャルコントローラー() {
            DoSetコード_NotEqual(CDef.職位区分.ファイナンシャルコントローラー.Code);
        }
        /// <summary>
        /// Set the value of フロントクラーク of コード as notEqual. { &lt;&gt; }
        /// フロントクラーク: Front Clerk
        /// </summary>
        public void Setコード_NotEqual_フロントクラーク() {
            DoSetコード_NotEqual(CDef.職位区分.フロントクラーク.Code);
        }
        protected void DoSetコード_NotEqual(String v) { regコード(CK_NES, v); }
        public void Setコード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueコード(), "コード"); }
        public void Setコード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueコード(), "コード"); }
        public void ExistsDch従業員職位履歴台帳List(SubQuery<Dch従業員職位履歴台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_ExistsSubQuery_Dch従業員職位履歴台帳List(cb.Query());
            registerExistsSubQuery(cb.Query(), "コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keepコード_ExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public void ExistsMst従業員マスタList(SubQuery<Mst従業員マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst従業員マスタCB>", subQuery);
            Mst従業員マスタCB cb = new Mst従業員マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_ExistsSubQuery_Mst従業員マスタList(cb.Query());
            registerExistsSubQuery(cb.Query(), "コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keepコード_ExistsSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery);
        public void ExistsMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_ExistsSubQuery_Mst権限マスタList(cb.Query());
            registerExistsSubQuery(cb.Query(), "コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keepコード_ExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void NotExistsDch従業員職位履歴台帳List(SubQuery<Dch従業員職位履歴台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_NotExistsSubQuery_Dch従業員職位履歴台帳List(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keepコード_NotExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public void NotExistsMst従業員マスタList(SubQuery<Mst従業員マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst従業員マスタCB>", subQuery);
            Mst従業員マスタCB cb = new Mst従業員マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_NotExistsSubQuery_Mst従業員マスタList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keepコード_NotExistsSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery);
        public void NotExistsMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_NotExistsSubQuery_Mst権限マスタList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keepコード_NotExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void InScopeDch従業員職位履歴台帳List(SubQuery<Dch従業員職位履歴台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_InScopeSubQuery_Dch従業員職位履歴台帳List(cb.Query());
            registerInScopeSubQuery(cb.Query(), "コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keepコード_InScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public void InScopeMst従業員マスタList(SubQuery<Mst従業員マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst従業員マスタCB>", subQuery);
            Mst従業員マスタCB cb = new Mst従業員マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_InScopeSubQuery_Mst従業員マスタList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keepコード_InScopeSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery);
        public void InScopeMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_InScopeSubQuery_Mst権限マスタList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keepコード_InScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void NotInScopeDch従業員職位履歴台帳List(SubQuery<Dch従業員職位履歴台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_NotInScopeSubQuery_Dch従業員職位履歴台帳List(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keepコード_NotInScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public void NotInScopeMst従業員マスタList(SubQuery<Mst従業員マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst従業員マスタCB>", subQuery);
            Mst従業員マスタCB cb = new Mst従業員マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_NotInScopeSubQuery_Mst従業員マスタList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keepコード_NotInScopeSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery);
        public void NotInScopeMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_NotInScopeSubQuery_Mst権限マスタList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "コード", "職位コード", subQueryPropertyName);
        }
        public abstract String keepコード_NotInScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void xsderiveDch従業員職位履歴台帳List(String function, SubQuery<Dch従業員職位履歴台帳CB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Dch従業員職位履歴台帳CB>", subQuery);
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "コード", "職位コード", subQueryPropertyName, aliasName);
        }
        abstract public String keepコード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public void xsderiveMst従業員マスタList(String function, SubQuery<Mst従業員マスタCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Mst従業員マスタCB>", subQuery);
            Mst従業員マスタCB cb = new Mst従業員マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_SpecifyDerivedReferrer_Mst従業員マスタList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "コード", "職位コード", subQueryPropertyName, aliasName);
        }
        abstract public String keepコード_SpecifyDerivedReferrer_Mst従業員マスタList(Mst従業員マスタCQ subQuery);
        public void xsderiveMst権限マスタList(String function, SubQuery<Mst権限マスタCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_SpecifyDerivedReferrer_Mst権限マスタList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "コード", "職位コード", subQueryPropertyName, aliasName);
        }
        abstract public String keepコード_SpecifyDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery);

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
            String subQueryPropertyName = keepコード_QueryDerivedReferrer_Dch従業員職位履歴台帳List(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepコード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "コード", "職位コード", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepコード_QueryDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery);
        public abstract String keepコード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter(Object parameterValue);

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
            String subQueryPropertyName = keepコード_QueryDerivedReferrer_Mst従業員マスタList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepコード_QueryDerivedReferrer_Mst従業員マスタListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "コード", "職位コード", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepコード_QueryDerivedReferrer_Mst従業員マスタList(Mst従業員マスタCQ subQuery);
        public abstract String keepコード_QueryDerivedReferrer_Mst従業員マスタListParameter(Object parameterValue);

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
            String subQueryPropertyName = keepコード_QueryDerivedReferrer_Mst権限マスタList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepコード_QueryDerivedReferrer_Mst権限マスタListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "コード", "職位コード", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepコード_QueryDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public abstract String keepコード_QueryDerivedReferrer_Mst権限マスタListParameter(Object parameterValue);
        public void Setコード_IsNull() { regコード(CK_ISN, DUMMY_OBJECT); }
        public void Setコード_IsNotNull() { regコード(CK_ISNN, DUMMY_OBJECT); }
        protected void regコード(ConditionKey k, Object v) { regQ(k, v, getCValueコード(), "コード"); }
        protected abstract ConditionValue getCValueコード();

        public void Set名称_Equal(String v) { DoSet名称_Equal(fRES(v)); }
        protected void DoSet名称_Equal(String v) { reg名称(CK_EQ, v); }
        public void Set名称_NotEqual(String v) { DoSet名称_NotEqual(fRES(v)); }
        protected void DoSet名称_NotEqual(String v) { reg名称(CK_NES, v); }
        public void Set名称_GreaterThan(String v) { reg名称(CK_GT, fRES(v)); }
        public void Set名称_LessThan(String v) { reg名称(CK_LT, fRES(v)); }
        public void Set名称_GreaterEqual(String v) { reg名称(CK_GE, fRES(v)); }
        public void Set名称_LessEqual(String v) { reg名称(CK_LE, fRES(v)); }
        public void Set名称_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue名称(), "名称"); }
        public void Set名称_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue名称(), "名称"); }
        public void Set名称_PrefixSearch(String v) { Set名称_LikeSearch(v, cLSOP()); }
        public void Set名称_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue名称(), "名称", option); }
        public void Set名称_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue名称(), "名称", option); }
        protected void reg名称(ConditionKey k, Object v) { regQ(k, v, getCValue名称(), "名称"); }
        protected abstract ConditionValue getCValue名称();

        public void Set名称英字_Equal(String v) { DoSet名称英字_Equal(fRES(v)); }
        protected void DoSet名称英字_Equal(String v) { reg名称英字(CK_EQ, v); }
        public void Set名称英字_NotEqual(String v) { DoSet名称英字_NotEqual(fRES(v)); }
        protected void DoSet名称英字_NotEqual(String v) { reg名称英字(CK_NES, v); }
        public void Set名称英字_GreaterThan(String v) { reg名称英字(CK_GT, fRES(v)); }
        public void Set名称英字_LessThan(String v) { reg名称英字(CK_LT, fRES(v)); }
        public void Set名称英字_GreaterEqual(String v) { reg名称英字(CK_GE, fRES(v)); }
        public void Set名称英字_LessEqual(String v) { reg名称英字(CK_LE, fRES(v)); }
        public void Set名称英字_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue名称英字(), "名称_英字"); }
        public void Set名称英字_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue名称英字(), "名称_英字"); }
        public void Set名称英字_PrefixSearch(String v) { Set名称英字_LikeSearch(v, cLSOP()); }
        public void Set名称英字_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue名称英字(), "名称_英字", option); }
        public void Set名称英字_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue名称英字(), "名称_英字", option); }
        protected void reg名称英字(ConditionKey k, Object v) { regQ(k, v, getCValue名称英字(), "名称_英字"); }
        protected abstract ConditionValue getCValue名称英字();

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
            registerInScopeSubQuery(cb.Query(), "コード", "コード", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Kbn職位区分CQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
