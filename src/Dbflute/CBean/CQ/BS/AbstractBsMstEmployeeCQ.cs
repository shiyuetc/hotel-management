
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
    public abstract class AbstractBsMstEmployeeCQ : AbstractConditionQuery {

        public AbstractBsMstEmployeeCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "mst_employee"; }
        public override String getTableSqlName() { return "mst_employee"; }

        public void SetId_Equal(int? v) { regId(CK_EQ, v); }
        public void SetId_NotEqual(int? v) { regId(CK_NES, v); }
        public void SetId_GreaterThan(int? v) { regId(CK_GT, v); }
        public void SetId_LessThan(int? v) { regId(CK_LT, v); }
        public void SetId_GreaterEqual(int? v) { regId(CK_GE, v); }
        public void SetId_LessEqual(int? v) { regId(CK_LE, v); }
        public void SetId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueId(), "id"); }
        public void SetId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueId(), "id"); }
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

        public void SetName_Equal(String v) { DoSetName_Equal(fRES(v)); }
        protected void DoSetName_Equal(String v) { regName(CK_EQ, v); }
        public void SetName_NotEqual(String v) { DoSetName_NotEqual(fRES(v)); }
        protected void DoSetName_NotEqual(String v) { regName(CK_NES, v); }
        public void SetName_GreaterThan(String v) { regName(CK_GT, fRES(v)); }
        public void SetName_LessThan(String v) { regName(CK_LT, fRES(v)); }
        public void SetName_GreaterEqual(String v) { regName(CK_GE, fRES(v)); }
        public void SetName_LessEqual(String v) { regName(CK_LE, fRES(v)); }
        public void SetName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueName(), "name"); }
        public void SetName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueName(), "name"); }
        public void SetName_PrefixSearch(String v) { SetName_LikeSearch(v, cLSOP()); }
        public void SetName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueName(), "name", option); }
        public void SetName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueName(), "name", option); }
        protected void regName(ConditionKey k, Object v) { regQ(k, v, getCValueName(), "name"); }
        protected abstract ConditionValue getCValueName();

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
        protected void DoSetRankCode_Equal(String v) { regRankCode(CK_EQ, v); }
        public void SetRankCode_NotEqual(String v) { DoSetRankCode_NotEqual(fRES(v)); }
        protected void DoSetRankCode_NotEqual(String v) { regRankCode(CK_NES, v); }
        public void SetRankCode_GreaterThan(String v) { regRankCode(CK_GT, fRES(v)); }
        public void SetRankCode_LessThan(String v) { regRankCode(CK_LT, fRES(v)); }
        public void SetRankCode_GreaterEqual(String v) { regRankCode(CK_GE, fRES(v)); }
        public void SetRankCode_LessEqual(String v) { regRankCode(CK_LE, fRES(v)); }
        public void SetRankCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRankCode(), "rank_code"); }
        public void SetRankCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRankCode(), "rank_code"); }
        public void SetRankCode_PrefixSearch(String v) { SetRankCode_LikeSearch(v, cLSOP()); }
        public void SetRankCode_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRankCode(), "rank_code", option); }
        public void SetRankCode_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRankCode(), "rank_code", option); }
        public void InScopeKbnRank(SubQuery<KbnRankCB> subQuery) {
            assertObjectNotNull("subQuery<KbnRankCB>", subQuery);
            KbnRankCB cb = new KbnRankCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepRankCode_InScopeSubQuery_KbnRank(cb.Query());
            registerInScopeSubQuery(cb.Query(), "rank_code", "code", subQueryPropertyName);
        }
        public abstract String keepRankCode_InScopeSubQuery_KbnRank(KbnRankCQ subQuery);
        public void NotInScopeKbnRank(SubQuery<KbnRankCB> subQuery) {
            assertObjectNotNull("subQuery<KbnRankCB>", subQuery);
            KbnRankCB cb = new KbnRankCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepRankCode_NotInScopeSubQuery_KbnRank(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "rank_code", "code", subQueryPropertyName);
        }
        public abstract String keepRankCode_NotInScopeSubQuery_KbnRank(KbnRankCQ subQuery);
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
        public SSQFunction<MstEmployeeCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MstEmployeeCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MstEmployeeCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MstEmployeeCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MstEmployeeCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MstEmployeeCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MstEmployeeCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MstEmployeeCB>(delegate(String function, SubQuery<MstEmployeeCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<MstEmployeeCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MstEmployeeCB>", subQuery);
            MstEmployeeCB cb = new MstEmployeeCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MstEmployeeCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<MstEmployeeCB> subQuery) {
            assertObjectNotNull("subQuery<MstEmployeeCB>", subQuery);
            MstEmployeeCB cb = new MstEmployeeCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "id", "id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MstEmployeeCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
