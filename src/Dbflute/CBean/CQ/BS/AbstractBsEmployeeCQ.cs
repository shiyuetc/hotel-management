
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
    public abstract class AbstractBsEmployeeCQ : AbstractConditionQuery {

        public AbstractBsEmployeeCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "employee"; }
        public override String getTableSqlName() { return "employee"; }

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

        public void SetEmployeeNo_Equal(String v) { DoSetEmployeeNo_Equal(fRES(v)); }
        protected void DoSetEmployeeNo_Equal(String v) { regEmployeeNo(CK_EQ, v); }
        public void SetEmployeeNo_NotEqual(String v) { DoSetEmployeeNo_NotEqual(fRES(v)); }
        protected void DoSetEmployeeNo_NotEqual(String v) { regEmployeeNo(CK_NES, v); }
        public void SetEmployeeNo_GreaterThan(String v) { regEmployeeNo(CK_GT, fRES(v)); }
        public void SetEmployeeNo_LessThan(String v) { regEmployeeNo(CK_LT, fRES(v)); }
        public void SetEmployeeNo_GreaterEqual(String v) { regEmployeeNo(CK_GE, fRES(v)); }
        public void SetEmployeeNo_LessEqual(String v) { regEmployeeNo(CK_LE, fRES(v)); }
        public void SetEmployeeNo_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueEmployeeNo(), "employee_no"); }
        public void SetEmployeeNo_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueEmployeeNo(), "employee_no"); }
        public void SetEmployeeNo_PrefixSearch(String v) { SetEmployeeNo_LikeSearch(v, cLSOP()); }
        public void SetEmployeeNo_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueEmployeeNo(), "employee_no", option); }
        public void SetEmployeeNo_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueEmployeeNo(), "employee_no", option); }
        protected void regEmployeeNo(ConditionKey k, Object v) { regQ(k, v, getCValueEmployeeNo(), "employee_no"); }
        protected abstract ConditionValue getCValueEmployeeNo();

        public void SetLastName_Equal(String v) { DoSetLastName_Equal(fRES(v)); }
        protected void DoSetLastName_Equal(String v) { regLastName(CK_EQ, v); }
        public void SetLastName_NotEqual(String v) { DoSetLastName_NotEqual(fRES(v)); }
        protected void DoSetLastName_NotEqual(String v) { regLastName(CK_NES, v); }
        public void SetLastName_GreaterThan(String v) { regLastName(CK_GT, fRES(v)); }
        public void SetLastName_LessThan(String v) { regLastName(CK_LT, fRES(v)); }
        public void SetLastName_GreaterEqual(String v) { regLastName(CK_GE, fRES(v)); }
        public void SetLastName_LessEqual(String v) { regLastName(CK_LE, fRES(v)); }
        public void SetLastName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueLastName(), "last_name"); }
        public void SetLastName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueLastName(), "last_name"); }
        public void SetLastName_PrefixSearch(String v) { SetLastName_LikeSearch(v, cLSOP()); }
        public void SetLastName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueLastName(), "last_name", option); }
        public void SetLastName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueLastName(), "last_name", option); }
        protected void regLastName(ConditionKey k, Object v) { regQ(k, v, getCValueLastName(), "last_name"); }
        protected abstract ConditionValue getCValueLastName();

        public void SetFirstName_Equal(String v) { DoSetFirstName_Equal(fRES(v)); }
        protected void DoSetFirstName_Equal(String v) { regFirstName(CK_EQ, v); }
        public void SetFirstName_NotEqual(String v) { DoSetFirstName_NotEqual(fRES(v)); }
        protected void DoSetFirstName_NotEqual(String v) { regFirstName(CK_NES, v); }
        public void SetFirstName_GreaterThan(String v) { regFirstName(CK_GT, fRES(v)); }
        public void SetFirstName_LessThan(String v) { regFirstName(CK_LT, fRES(v)); }
        public void SetFirstName_GreaterEqual(String v) { regFirstName(CK_GE, fRES(v)); }
        public void SetFirstName_LessEqual(String v) { regFirstName(CK_LE, fRES(v)); }
        public void SetFirstName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueFirstName(), "first_name"); }
        public void SetFirstName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueFirstName(), "first_name"); }
        public void SetFirstName_PrefixSearch(String v) { SetFirstName_LikeSearch(v, cLSOP()); }
        public void SetFirstName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueFirstName(), "first_name", option); }
        public void SetFirstName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueFirstName(), "first_name", option); }
        protected void regFirstName(ConditionKey k, Object v) { regQ(k, v, getCValueFirstName(), "first_name"); }
        protected abstract ConditionValue getCValueFirstName();

        public void SetRubyName_Equal(String v) { DoSetRubyName_Equal(fRES(v)); }
        protected void DoSetRubyName_Equal(String v) { regRubyName(CK_EQ, v); }
        public void SetRubyName_NotEqual(String v) { DoSetRubyName_NotEqual(fRES(v)); }
        protected void DoSetRubyName_NotEqual(String v) { regRubyName(CK_NES, v); }
        public void SetRubyName_GreaterThan(String v) { regRubyName(CK_GT, fRES(v)); }
        public void SetRubyName_LessThan(String v) { regRubyName(CK_LT, fRES(v)); }
        public void SetRubyName_GreaterEqual(String v) { regRubyName(CK_GE, fRES(v)); }
        public void SetRubyName_LessEqual(String v) { regRubyName(CK_LE, fRES(v)); }
        public void SetRubyName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRubyName(), "ruby_name"); }
        public void SetRubyName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRubyName(), "ruby_name"); }
        public void SetRubyName_PrefixSearch(String v) { SetRubyName_LikeSearch(v, cLSOP()); }
        public void SetRubyName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRubyName(), "ruby_name", option); }
        public void SetRubyName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRubyName(), "ruby_name", option); }
        protected void regRubyName(ConditionKey k, Object v) { regQ(k, v, getCValueRubyName(), "ruby_name"); }
        protected abstract ConditionValue getCValueRubyName();

        public void SetEmail_Equal(String v) { DoSetEmail_Equal(fRES(v)); }
        protected void DoSetEmail_Equal(String v) { regEmail(CK_EQ, v); }
        public void SetEmail_NotEqual(String v) { DoSetEmail_NotEqual(fRES(v)); }
        protected void DoSetEmail_NotEqual(String v) { regEmail(CK_NES, v); }
        public void SetEmail_GreaterThan(String v) { regEmail(CK_GT, fRES(v)); }
        public void SetEmail_LessThan(String v) { regEmail(CK_LT, fRES(v)); }
        public void SetEmail_GreaterEqual(String v) { regEmail(CK_GE, fRES(v)); }
        public void SetEmail_LessEqual(String v) { regEmail(CK_LE, fRES(v)); }
        public void SetEmail_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueEmail(), "email"); }
        public void SetEmail_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueEmail(), "email"); }
        public void SetEmail_PrefixSearch(String v) { SetEmail_LikeSearch(v, cLSOP()); }
        public void SetEmail_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueEmail(), "email", option); }
        public void SetEmail_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueEmail(), "email", option); }
        public void SetEmail_IsNull() { regEmail(CK_ISN, DUMMY_OBJECT); }
        public void SetEmail_IsNotNull() { regEmail(CK_ISNN, DUMMY_OBJECT); }
        protected void regEmail(ConditionKey k, Object v) { regQ(k, v, getCValueEmail(), "email"); }
        protected abstract ConditionValue getCValueEmail();

        public void SetPassword_Equal(String v) { DoSetPassword_Equal(fRES(v)); }
        protected void DoSetPassword_Equal(String v) { regPassword(CK_EQ, v); }
        public void SetPassword_NotEqual(String v) { DoSetPassword_NotEqual(fRES(v)); }
        protected void DoSetPassword_NotEqual(String v) { regPassword(CK_NES, v); }
        public void SetPassword_GreaterThan(String v) { regPassword(CK_GT, fRES(v)); }
        public void SetPassword_LessThan(String v) { regPassword(CK_LT, fRES(v)); }
        public void SetPassword_GreaterEqual(String v) { regPassword(CK_GE, fRES(v)); }
        public void SetPassword_LessEqual(String v) { regPassword(CK_LE, fRES(v)); }
        public void SetPassword_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValuePassword(), "password"); }
        public void SetPassword_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValuePassword(), "password"); }
        public void SetPassword_PrefixSearch(String v) { SetPassword_LikeSearch(v, cLSOP()); }
        public void SetPassword_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValuePassword(), "password", option); }
        public void SetPassword_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValuePassword(), "password", option); }
        protected void regPassword(ConditionKey k, Object v) { regQ(k, v, getCValuePassword(), "password"); }
        protected abstract ConditionValue getCValuePassword();

        public void SetRankCode_Equal(String v) { DoSetRankCode_Equal(fRES(v)); }
        /// <summary>
        /// Set the value of SystemMaintenancer of rankCode as equal. { = }
        /// システム保守: System Maintenancer
        /// </summary>
        public void SetRankCode_Equal_SystemMaintenancer() {
            DoSetRankCode_Equal(CDef.Rank.SystemMaintenancer.Code);
        }
        /// <summary>
        /// Set the value of AssistantManager of rankCode as equal. { = }
        /// アシスタントマネージャー: Assistant Manager
        /// </summary>
        public void SetRankCode_Equal_AssistantManager() {
            DoSetRankCode_Equal(CDef.Rank.AssistantManager.Code);
        }
        /// <summary>
        /// Set the value of FinancialController of rankCode as equal. { = }
        /// ファイナンシャルコントローラー: Financial Controller
        /// </summary>
        public void SetRankCode_Equal_FinancialController() {
            DoSetRankCode_Equal(CDef.Rank.FinancialController.Code);
        }
        /// <summary>
        /// Set the value of FrontClerk of rankCode as equal. { = }
        /// フロントクラーク: Front Clerk
        /// </summary>
        public void SetRankCode_Equal_FrontClerk() {
            DoSetRankCode_Equal(CDef.Rank.FrontClerk.Code);
        }
        protected void DoSetRankCode_Equal(String v) { regRankCode(CK_EQ, v); }
        public void SetRankCode_NotEqual(String v) { DoSetRankCode_NotEqual(fRES(v)); }
        /// <summary>
        /// Set the value of SystemMaintenancer of rankCode as notEqual. { &lt;&gt; }
        /// システム保守: System Maintenancer
        /// </summary>
        public void SetRankCode_NotEqual_SystemMaintenancer() {
            DoSetRankCode_NotEqual(CDef.Rank.SystemMaintenancer.Code);
        }
        /// <summary>
        /// Set the value of AssistantManager of rankCode as notEqual. { &lt;&gt; }
        /// アシスタントマネージャー: Assistant Manager
        /// </summary>
        public void SetRankCode_NotEqual_AssistantManager() {
            DoSetRankCode_NotEqual(CDef.Rank.AssistantManager.Code);
        }
        /// <summary>
        /// Set the value of FinancialController of rankCode as notEqual. { &lt;&gt; }
        /// ファイナンシャルコントローラー: Financial Controller
        /// </summary>
        public void SetRankCode_NotEqual_FinancialController() {
            DoSetRankCode_NotEqual(CDef.Rank.FinancialController.Code);
        }
        /// <summary>
        /// Set the value of FrontClerk of rankCode as notEqual. { &lt;&gt; }
        /// フロントクラーク: Front Clerk
        /// </summary>
        public void SetRankCode_NotEqual_FrontClerk() {
            DoSetRankCode_NotEqual(CDef.Rank.FrontClerk.Code);
        }
        protected void DoSetRankCode_NotEqual(String v) { regRankCode(CK_NES, v); }
        public void SetRankCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRankCode(), "rank_code"); }
        public void SetRankCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRankCode(), "rank_code"); }
        public void InScopeRank(SubQuery<RankCB> subQuery) {
            assertObjectNotNull("subQuery<RankCB>", subQuery);
            RankCB cb = new RankCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepRankCode_InScopeSubQuery_Rank(cb.Query());
            registerInScopeSubQuery(cb.Query(), "rank_code", "code", subQueryPropertyName);
        }
        public abstract String keepRankCode_InScopeSubQuery_Rank(RankCQ subQuery);
        public void NotInScopeRank(SubQuery<RankCB> subQuery) {
            assertObjectNotNull("subQuery<RankCB>", subQuery);
            RankCB cb = new RankCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepRankCode_NotInScopeSubQuery_Rank(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "rank_code", "code", subQueryPropertyName);
        }
        public abstract String keepRankCode_NotInScopeSubQuery_Rank(RankCQ subQuery);
        protected void regRankCode(ConditionKey k, Object v) { regQ(k, v, getCValueRankCode(), "rank_code"); }
        protected abstract ConditionValue getCValueRankCode();

        public void SetEntryDate_Equal(DateTime? v) { regEntryDate(CK_EQ, v); }
        public void SetEntryDate_GreaterThan(DateTime? v) { regEntryDate(CK_GT, v); }
        public void SetEntryDate_LessThan(DateTime? v) { regEntryDate(CK_LT, v); }
        public void SetEntryDate_GreaterEqual(DateTime? v) { regEntryDate(CK_GE, v); }
        public void SetEntryDate_LessEqual(DateTime? v) { regEntryDate(CK_LE, v); }
        public void SetEntryDate_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueEntryDate(), "entry_date", option); }
        public void SetEntryDate_DateFromTo(DateTime? from, DateTime? to) { SetEntryDate_FromTo(from, to, new DateFromToOption()); }
        protected void regEntryDate(ConditionKey k, Object v) { regQ(k, v, getCValueEntryDate(), "entry_date"); }
        protected abstract ConditionValue getCValueEntryDate();

        public void SetLeaveDate_Equal(DateTime? v) { regLeaveDate(CK_EQ, v); }
        public void SetLeaveDate_GreaterThan(DateTime? v) { regLeaveDate(CK_GT, v); }
        public void SetLeaveDate_LessThan(DateTime? v) { regLeaveDate(CK_LT, v); }
        public void SetLeaveDate_GreaterEqual(DateTime? v) { regLeaveDate(CK_GE, v); }
        public void SetLeaveDate_LessEqual(DateTime? v) { regLeaveDate(CK_LE, v); }
        public void SetLeaveDate_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueLeaveDate(), "leave_date", option); }
        public void SetLeaveDate_DateFromTo(DateTime? from, DateTime? to) { SetLeaveDate_FromTo(from, to, new DateFromToOption()); }
        public void SetLeaveDate_IsNull() { regLeaveDate(CK_ISN, DUMMY_OBJECT); }
        public void SetLeaveDate_IsNotNull() { regLeaveDate(CK_ISNN, DUMMY_OBJECT); }
        protected void regLeaveDate(ConditionKey k, Object v) { regQ(k, v, getCValueLeaveDate(), "leave_date"); }
        protected abstract ConditionValue getCValueLeaveDate();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<EmployeeCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<EmployeeCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<EmployeeCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<EmployeeCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<EmployeeCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<EmployeeCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<EmployeeCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<EmployeeCB>(delegate(String function, SubQuery<EmployeeCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<EmployeeCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<EmployeeCB>", subQuery);
            EmployeeCB cb = new EmployeeCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(EmployeeCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<EmployeeCB> subQuery) {
            assertObjectNotNull("subQuery<EmployeeCB>", subQuery);
            EmployeeCB cb = new EmployeeCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "id", "id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(EmployeeCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
