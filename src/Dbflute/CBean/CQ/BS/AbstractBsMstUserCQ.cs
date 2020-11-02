
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
    public abstract class AbstractBsMstUserCQ : AbstractConditionQuery {

        public AbstractBsMstUserCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "mst_user"; }
        public override String getTableSqlName() { return "mst_user"; }

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

        public void SetLoginId_Equal(String v) { DoSetLoginId_Equal(fRES(v)); }
        protected void DoSetLoginId_Equal(String v) { regLoginId(CK_EQ, v); }
        public void SetLoginId_NotEqual(String v) { DoSetLoginId_NotEqual(fRES(v)); }
        protected void DoSetLoginId_NotEqual(String v) { regLoginId(CK_NES, v); }
        public void SetLoginId_GreaterThan(String v) { regLoginId(CK_GT, fRES(v)); }
        public void SetLoginId_LessThan(String v) { regLoginId(CK_LT, fRES(v)); }
        public void SetLoginId_GreaterEqual(String v) { regLoginId(CK_GE, fRES(v)); }
        public void SetLoginId_LessEqual(String v) { regLoginId(CK_LE, fRES(v)); }
        public void SetLoginId_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueLoginId(), "login_id"); }
        public void SetLoginId_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueLoginId(), "login_id"); }
        public void SetLoginId_PrefixSearch(String v) { SetLoginId_LikeSearch(v, cLSOP()); }
        public void SetLoginId_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueLoginId(), "login_id", option); }
        public void SetLoginId_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueLoginId(), "login_id", option); }
        protected void regLoginId(ConditionKey k, Object v) { regQ(k, v, getCValueLoginId(), "login_id"); }
        protected abstract ConditionValue getCValueLoginId();

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

        public void SetUpdateTime_Equal(DateTime? v) { regUpdateTime(CK_EQ, v); }
        public void SetUpdateTime_GreaterThan(DateTime? v) { regUpdateTime(CK_GT, v); }
        public void SetUpdateTime_LessThan(DateTime? v) { regUpdateTime(CK_LT, v); }
        public void SetUpdateTime_GreaterEqual(DateTime? v) { regUpdateTime(CK_GE, v); }
        public void SetUpdateTime_LessEqual(DateTime? v) { regUpdateTime(CK_LE, v); }
        public void SetUpdateTime_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueUpdateTime(), "update_time", option); }
        public void SetUpdateTime_DateFromTo(DateTime? from, DateTime? to) { SetUpdateTime_FromTo(from, to, new DateFromToOption()); }
        protected void regUpdateTime(ConditionKey k, Object v) { regQ(k, v, getCValueUpdateTime(), "update_time"); }
        protected abstract ConditionValue getCValueUpdateTime();

        public void SetUpdateUser_Equal(String v) { DoSetUpdateUser_Equal(fRES(v)); }
        protected void DoSetUpdateUser_Equal(String v) { regUpdateUser(CK_EQ, v); }
        public void SetUpdateUser_NotEqual(String v) { DoSetUpdateUser_NotEqual(fRES(v)); }
        protected void DoSetUpdateUser_NotEqual(String v) { regUpdateUser(CK_NES, v); }
        public void SetUpdateUser_GreaterThan(String v) { regUpdateUser(CK_GT, fRES(v)); }
        public void SetUpdateUser_LessThan(String v) { regUpdateUser(CK_LT, fRES(v)); }
        public void SetUpdateUser_GreaterEqual(String v) { regUpdateUser(CK_GE, fRES(v)); }
        public void SetUpdateUser_LessEqual(String v) { regUpdateUser(CK_LE, fRES(v)); }
        public void SetUpdateUser_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueUpdateUser(), "update_user"); }
        public void SetUpdateUser_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueUpdateUser(), "update_user"); }
        public void SetUpdateUser_PrefixSearch(String v) { SetUpdateUser_LikeSearch(v, cLSOP()); }
        public void SetUpdateUser_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueUpdateUser(), "update_user", option); }
        public void SetUpdateUser_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueUpdateUser(), "update_user", option); }
        protected void regUpdateUser(ConditionKey k, Object v) { regQ(k, v, getCValueUpdateUser(), "update_user"); }
        protected abstract ConditionValue getCValueUpdateUser();

        public void SetVersionNo_Equal(long? v) { regVersionNo(CK_EQ, v); }
        public void SetVersionNo_NotEqual(long? v) { regVersionNo(CK_NES, v); }
        public void SetVersionNo_GreaterThan(long? v) { regVersionNo(CK_GT, v); }
        public void SetVersionNo_LessThan(long? v) { regVersionNo(CK_LT, v); }
        public void SetVersionNo_GreaterEqual(long? v) { regVersionNo(CK_GE, v); }
        public void SetVersionNo_LessEqual(long? v) { regVersionNo(CK_LE, v); }
        public void SetVersionNo_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVersionNo(), "version_no"); }
        public void SetVersionNo_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVersionNo(), "version_no"); }
        protected void regVersionNo(ConditionKey k, Object v) { regQ(k, v, getCValueVersionNo(), "version_no"); }
        protected abstract ConditionValue getCValueVersionNo();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<MstUserCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MstUserCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MstUserCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MstUserCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MstUserCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MstUserCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MstUserCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MstUserCB>(delegate(String function, SubQuery<MstUserCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<MstUserCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MstUserCB>", subQuery);
            MstUserCB cb = new MstUserCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MstUserCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<MstUserCB> subQuery) {
            assertObjectNotNull("subQuery<MstUserCB>", subQuery);
            MstUserCB cb = new MstUserCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "id", "id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MstUserCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
