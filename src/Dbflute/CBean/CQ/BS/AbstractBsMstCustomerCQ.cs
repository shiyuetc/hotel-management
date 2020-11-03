
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
    public abstract class AbstractBsMstCustomerCQ : AbstractConditionQuery {

        public AbstractBsMstCustomerCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "mst_customer"; }
        public override String getTableSqlName() { return "mst_customer"; }

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

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<MstCustomerCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MstCustomerCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MstCustomerCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MstCustomerCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MstCustomerCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MstCustomerCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MstCustomerCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MstCustomerCB>(delegate(String function, SubQuery<MstCustomerCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<MstCustomerCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MstCustomerCB>", subQuery);
            MstCustomerCB cb = new MstCustomerCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MstCustomerCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<MstCustomerCB> subQuery) {
            assertObjectNotNull("subQuery<MstCustomerCB>", subQuery);
            MstCustomerCB cb = new MstCustomerCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "id", "id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MstCustomerCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
