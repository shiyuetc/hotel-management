
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
    public abstract class AbstractBsCustomerCQ : AbstractConditionQuery {

        public AbstractBsCustomerCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "customer"; }
        public override String getTableSqlName() { return "customer"; }

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

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<CustomerCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<CustomerCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<CustomerCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<CustomerCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<CustomerCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<CustomerCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<CustomerCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<CustomerCB>(delegate(String function, SubQuery<CustomerCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<CustomerCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<CustomerCB>", subQuery);
            CustomerCB cb = new CustomerCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(CustomerCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<CustomerCB> subQuery) {
            assertObjectNotNull("subQuery<CustomerCB>", subQuery);
            CustomerCB cb = new CustomerCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "id", "id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(CustomerCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
