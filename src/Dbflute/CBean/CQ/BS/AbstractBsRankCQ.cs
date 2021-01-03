
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
    public abstract class AbstractBsRankCQ : AbstractConditionQuery {

        public AbstractBsRankCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "rank"; }
        public override String getTableSqlName() { return "rank"; }

        public void SetCode_Equal(String v) { DoSetCode_Equal(fRES(v)); }
        /// <summary>
        /// Set the value of SystemMaintenancer of code as equal. { = }
        /// システム保守: System Maintenancer
        /// </summary>
        public void SetCode_Equal_SystemMaintenancer() {
            DoSetCode_Equal(CDef.Rank.SystemMaintenancer.Code);
        }
        /// <summary>
        /// Set the value of AssistantManager of code as equal. { = }
        /// アシスタントマネージャー: Assistant Manager
        /// </summary>
        public void SetCode_Equal_AssistantManager() {
            DoSetCode_Equal(CDef.Rank.AssistantManager.Code);
        }
        /// <summary>
        /// Set the value of FinancialController of code as equal. { = }
        /// ファイナンシャルコントローラー: Financial Controller
        /// </summary>
        public void SetCode_Equal_FinancialController() {
            DoSetCode_Equal(CDef.Rank.FinancialController.Code);
        }
        /// <summary>
        /// Set the value of FrontClerk of code as equal. { = }
        /// フロントクラーク: Front Clerk
        /// </summary>
        public void SetCode_Equal_FrontClerk() {
            DoSetCode_Equal(CDef.Rank.FrontClerk.Code);
        }
        protected void DoSetCode_Equal(String v) { regCode(CK_EQ, v); }
        public void SetCode_NotEqual(String v) { DoSetCode_NotEqual(fRES(v)); }
        /// <summary>
        /// Set the value of SystemMaintenancer of code as notEqual. { &lt;&gt; }
        /// システム保守: System Maintenancer
        /// </summary>
        public void SetCode_NotEqual_SystemMaintenancer() {
            DoSetCode_NotEqual(CDef.Rank.SystemMaintenancer.Code);
        }
        /// <summary>
        /// Set the value of AssistantManager of code as notEqual. { &lt;&gt; }
        /// アシスタントマネージャー: Assistant Manager
        /// </summary>
        public void SetCode_NotEqual_AssistantManager() {
            DoSetCode_NotEqual(CDef.Rank.AssistantManager.Code);
        }
        /// <summary>
        /// Set the value of FinancialController of code as notEqual. { &lt;&gt; }
        /// ファイナンシャルコントローラー: Financial Controller
        /// </summary>
        public void SetCode_NotEqual_FinancialController() {
            DoSetCode_NotEqual(CDef.Rank.FinancialController.Code);
        }
        /// <summary>
        /// Set the value of FrontClerk of code as notEqual. { &lt;&gt; }
        /// フロントクラーク: Front Clerk
        /// </summary>
        public void SetCode_NotEqual_FrontClerk() {
            DoSetCode_NotEqual(CDef.Rank.FrontClerk.Code);
        }
        protected void DoSetCode_NotEqual(String v) { regCode(CK_NES, v); }
        public void SetCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueCode(), "code"); }
        public void SetCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueCode(), "code"); }
        public void ExistsEmployeeList(SubQuery<EmployeeCB> subQuery) {
            assertObjectNotNull("subQuery<EmployeeCB>", subQuery);
            EmployeeCB cb = new EmployeeCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_ExistsSubQuery_EmployeeList(cb.Query());
            registerExistsSubQuery(cb.Query(), "code", "rank_code", subQueryPropertyName);
        }
        public abstract String keepCode_ExistsSubQuery_EmployeeList(EmployeeCQ subQuery);
        public void NotExistsEmployeeList(SubQuery<EmployeeCB> subQuery) {
            assertObjectNotNull("subQuery<EmployeeCB>", subQuery);
            EmployeeCB cb = new EmployeeCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_NotExistsSubQuery_EmployeeList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "code", "rank_code", subQueryPropertyName);
        }
        public abstract String keepCode_NotExistsSubQuery_EmployeeList(EmployeeCQ subQuery);
        public void InScopeEmployeeList(SubQuery<EmployeeCB> subQuery) {
            assertObjectNotNull("subQuery<EmployeeCB>", subQuery);
            EmployeeCB cb = new EmployeeCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_InScopeSubQuery_EmployeeList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "code", "rank_code", subQueryPropertyName);
        }
        public abstract String keepCode_InScopeSubQuery_EmployeeList(EmployeeCQ subQuery);
        public void NotInScopeEmployeeList(SubQuery<EmployeeCB> subQuery) {
            assertObjectNotNull("subQuery<EmployeeCB>", subQuery);
            EmployeeCB cb = new EmployeeCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_NotInScopeSubQuery_EmployeeList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "code", "rank_code", subQueryPropertyName);
        }
        public abstract String keepCode_NotInScopeSubQuery_EmployeeList(EmployeeCQ subQuery);
        public void xsderiveEmployeeList(String function, SubQuery<EmployeeCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<EmployeeCB>", subQuery);
            EmployeeCB cb = new EmployeeCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_SpecifyDerivedReferrer_EmployeeList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "code", "rank_code", subQueryPropertyName, aliasName);
        }
        abstract public String keepCode_SpecifyDerivedReferrer_EmployeeList(EmployeeCQ subQuery);

        public QDRFunction<EmployeeCB> DerivedEmployeeList() {
            return xcreateQDRFunctionEmployeeList();
        }
        protected QDRFunction<EmployeeCB> xcreateQDRFunctionEmployeeList() {
            return new QDRFunction<EmployeeCB>(delegate(String function, SubQuery<EmployeeCB> subQuery, String operand, Object value) {
                xqderiveEmployeeList(function, subQuery, operand, value);
            });
        }
        public void xqderiveEmployeeList(String function, SubQuery<EmployeeCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<EmployeeCB>", subQuery);
            EmployeeCB cb = new EmployeeCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_QueryDerivedReferrer_EmployeeList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepCode_QueryDerivedReferrer_EmployeeListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "code", "rank_code", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepCode_QueryDerivedReferrer_EmployeeList(EmployeeCQ subQuery);
        public abstract String keepCode_QueryDerivedReferrer_EmployeeListParameter(Object parameterValue);
        public void SetCode_IsNull() { regCode(CK_ISN, DUMMY_OBJECT); }
        public void SetCode_IsNotNull() { regCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regCode(ConditionKey k, Object v) { regQ(k, v, getCValueCode(), "code"); }
        protected abstract ConditionValue getCValueCode();

        public void SetEnglishName_Equal(String v) { DoSetEnglishName_Equal(fRES(v)); }
        protected void DoSetEnglishName_Equal(String v) { regEnglishName(CK_EQ, v); }
        public void SetEnglishName_NotEqual(String v) { DoSetEnglishName_NotEqual(fRES(v)); }
        protected void DoSetEnglishName_NotEqual(String v) { regEnglishName(CK_NES, v); }
        public void SetEnglishName_GreaterThan(String v) { regEnglishName(CK_GT, fRES(v)); }
        public void SetEnglishName_LessThan(String v) { regEnglishName(CK_LT, fRES(v)); }
        public void SetEnglishName_GreaterEqual(String v) { regEnglishName(CK_GE, fRES(v)); }
        public void SetEnglishName_LessEqual(String v) { regEnglishName(CK_LE, fRES(v)); }
        public void SetEnglishName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueEnglishName(), "english_name"); }
        public void SetEnglishName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueEnglishName(), "english_name"); }
        public void SetEnglishName_PrefixSearch(String v) { SetEnglishName_LikeSearch(v, cLSOP()); }
        public void SetEnglishName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueEnglishName(), "english_name", option); }
        public void SetEnglishName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueEnglishName(), "english_name", option); }
        protected void regEnglishName(ConditionKey k, Object v) { regQ(k, v, getCValueEnglishName(), "english_name"); }
        protected abstract ConditionValue getCValueEnglishName();

        public void SetJapaneseName_Equal(String v) { DoSetJapaneseName_Equal(fRES(v)); }
        protected void DoSetJapaneseName_Equal(String v) { regJapaneseName(CK_EQ, v); }
        public void SetJapaneseName_NotEqual(String v) { DoSetJapaneseName_NotEqual(fRES(v)); }
        protected void DoSetJapaneseName_NotEqual(String v) { regJapaneseName(CK_NES, v); }
        public void SetJapaneseName_GreaterThan(String v) { regJapaneseName(CK_GT, fRES(v)); }
        public void SetJapaneseName_LessThan(String v) { regJapaneseName(CK_LT, fRES(v)); }
        public void SetJapaneseName_GreaterEqual(String v) { regJapaneseName(CK_GE, fRES(v)); }
        public void SetJapaneseName_LessEqual(String v) { regJapaneseName(CK_LE, fRES(v)); }
        public void SetJapaneseName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueJapaneseName(), "japanese_name"); }
        public void SetJapaneseName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueJapaneseName(), "japanese_name"); }
        public void SetJapaneseName_PrefixSearch(String v) { SetJapaneseName_LikeSearch(v, cLSOP()); }
        public void SetJapaneseName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueJapaneseName(), "japanese_name", option); }
        public void SetJapaneseName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueJapaneseName(), "japanese_name", option); }
        protected void regJapaneseName(ConditionKey k, Object v) { regQ(k, v, getCValueJapaneseName(), "japanese_name"); }
        protected abstract ConditionValue getCValueJapaneseName();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<RankCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<RankCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<RankCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<RankCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<RankCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<RankCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<RankCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<RankCB>(delegate(String function, SubQuery<RankCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<RankCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<RankCB>", subQuery);
            RankCB cb = new RankCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(RankCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<RankCB> subQuery) {
            assertObjectNotNull("subQuery<RankCB>", subQuery);
            RankCB cb = new RankCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "code", "code", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(RankCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
