
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
    public abstract class AbstractBsUSERCQ : AbstractConditionQuery {

        public AbstractBsUSERCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "USER"; }
        public override String getTableSqlName() { return "USER"; }

        public void SetID_Equal(int? v) { regID(CK_EQ, v); }
        public void SetID_NotEqual(int? v) { regID(CK_NES, v); }
        public void SetID_GreaterThan(int? v) { regID(CK_GT, v); }
        public void SetID_LessThan(int? v) { regID(CK_LT, v); }
        public void SetID_GreaterEqual(int? v) { regID(CK_GE, v); }
        public void SetID_LessEqual(int? v) { regID(CK_LE, v); }
        public void SetID_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueID(), "ID"); }
        public void SetID_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueID(), "ID"); }
        public void SetID_IsNull() { regID(CK_ISN, DUMMY_OBJECT); }
        public void SetID_IsNotNull() { regID(CK_ISNN, DUMMY_OBJECT); }
        protected void regID(ConditionKey k, Object v) { regQ(k, v, getCValueID(), "ID"); }
        protected abstract ConditionValue getCValueID();

        public void SetNAME_Equal(String v) { DoSetNAME_Equal(fRES(v)); }
        protected void DoSetNAME_Equal(String v) { regNAME(CK_EQ, v); }
        public void SetNAME_NotEqual(String v) { DoSetNAME_NotEqual(fRES(v)); }
        protected void DoSetNAME_NotEqual(String v) { regNAME(CK_NES, v); }
        public void SetNAME_GreaterThan(String v) { regNAME(CK_GT, fRES(v)); }
        public void SetNAME_LessThan(String v) { regNAME(CK_LT, fRES(v)); }
        public void SetNAME_GreaterEqual(String v) { regNAME(CK_GE, fRES(v)); }
        public void SetNAME_LessEqual(String v) { regNAME(CK_LE, fRES(v)); }
        public void SetNAME_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueNAME(), "NAME"); }
        public void SetNAME_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueNAME(), "NAME"); }
        public void SetNAME_PrefixSearch(String v) { SetNAME_LikeSearch(v, cLSOP()); }
        public void SetNAME_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueNAME(), "NAME", option); }
        public void SetNAME_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueNAME(), "NAME", option); }
        protected void regNAME(ConditionKey k, Object v) { regQ(k, v, getCValueNAME(), "NAME"); }
        protected abstract ConditionValue getCValueNAME();

        public void SetUPDATE_DATETIME_Equal(DateTime? v) { regUPDATE_DATETIME(CK_EQ, v); }
        public void SetUPDATE_DATETIME_GreaterThan(DateTime? v) { regUPDATE_DATETIME(CK_GT, v); }
        public void SetUPDATE_DATETIME_LessThan(DateTime? v) { regUPDATE_DATETIME(CK_LT, v); }
        public void SetUPDATE_DATETIME_GreaterEqual(DateTime? v) { regUPDATE_DATETIME(CK_GE, v); }
        public void SetUPDATE_DATETIME_LessEqual(DateTime? v) { regUPDATE_DATETIME(CK_LE, v); }
        public void SetUPDATE_DATETIME_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueUPDATE_DATETIME(), "UPDATE_DATETIME", option); }
        public void SetUPDATE_DATETIME_DateFromTo(DateTime? from, DateTime? to) { SetUPDATE_DATETIME_FromTo(from, to, new DateFromToOption()); }
        protected void regUPDATE_DATETIME(ConditionKey k, Object v) { regQ(k, v, getCValueUPDATE_DATETIME(), "UPDATE_DATETIME"); }
        protected abstract ConditionValue getCValueUPDATE_DATETIME();

        public void SetUPDATE_USER_Equal(String v) { DoSetUPDATE_USER_Equal(fRES(v)); }
        protected void DoSetUPDATE_USER_Equal(String v) { regUPDATE_USER(CK_EQ, v); }
        public void SetUPDATE_USER_NotEqual(String v) { DoSetUPDATE_USER_NotEqual(fRES(v)); }
        protected void DoSetUPDATE_USER_NotEqual(String v) { regUPDATE_USER(CK_NES, v); }
        public void SetUPDATE_USER_GreaterThan(String v) { regUPDATE_USER(CK_GT, fRES(v)); }
        public void SetUPDATE_USER_LessThan(String v) { regUPDATE_USER(CK_LT, fRES(v)); }
        public void SetUPDATE_USER_GreaterEqual(String v) { regUPDATE_USER(CK_GE, fRES(v)); }
        public void SetUPDATE_USER_LessEqual(String v) { regUPDATE_USER(CK_LE, fRES(v)); }
        public void SetUPDATE_USER_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueUPDATE_USER(), "UPDATE_USER"); }
        public void SetUPDATE_USER_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueUPDATE_USER(), "UPDATE_USER"); }
        public void SetUPDATE_USER_PrefixSearch(String v) { SetUPDATE_USER_LikeSearch(v, cLSOP()); }
        public void SetUPDATE_USER_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueUPDATE_USER(), "UPDATE_USER", option); }
        public void SetUPDATE_USER_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueUPDATE_USER(), "UPDATE_USER", option); }
        protected void regUPDATE_USER(ConditionKey k, Object v) { regQ(k, v, getCValueUPDATE_USER(), "UPDATE_USER"); }
        protected abstract ConditionValue getCValueUPDATE_USER();

        public void SetVERSION_NO_Equal(long? v) { regVERSION_NO(CK_EQ, v); }
        public void SetVERSION_NO_NotEqual(long? v) { regVERSION_NO(CK_NES, v); }
        public void SetVERSION_NO_GreaterThan(long? v) { regVERSION_NO(CK_GT, v); }
        public void SetVERSION_NO_LessThan(long? v) { regVERSION_NO(CK_LT, v); }
        public void SetVERSION_NO_GreaterEqual(long? v) { regVERSION_NO(CK_GE, v); }
        public void SetVERSION_NO_LessEqual(long? v) { regVERSION_NO(CK_LE, v); }
        public void SetVERSION_NO_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVERSION_NO(), "VERSION_NO"); }
        public void SetVERSION_NO_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVERSION_NO(), "VERSION_NO"); }
        protected void regVERSION_NO(ConditionKey k, Object v) { regQ(k, v, getCValueVERSION_NO(), "VERSION_NO"); }
        protected abstract ConditionValue getCValueVERSION_NO();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<USERCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<USERCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<USERCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<USERCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<USERCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<USERCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<USERCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<USERCB>(delegate(String function, SubQuery<USERCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<USERCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<USERCB>", subQuery);
            USERCB cb = new USERCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(USERCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<USERCB> subQuery) {
            assertObjectNotNull("subQuery<USERCB>", subQuery);
            USERCB cb = new USERCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "ID", "ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(USERCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
