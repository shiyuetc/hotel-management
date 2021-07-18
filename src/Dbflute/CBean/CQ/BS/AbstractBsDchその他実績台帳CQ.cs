
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
    public abstract class AbstractBsDchその他実績台帳CQ : AbstractConditionQuery {

        public AbstractBsDchその他実績台帳CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "dchその他実績台帳"; }
        public override String getTableSqlName() { return "dchその他実績台帳"; }

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

        public void Set客室利用実績台帳id_Equal(long? v) { reg客室利用実績台帳id(CK_EQ, v); }
        public void Set客室利用実績台帳id_NotEqual(long? v) { reg客室利用実績台帳id(CK_NES, v); }
        public void Set客室利用実績台帳id_GreaterThan(long? v) { reg客室利用実績台帳id(CK_GT, v); }
        public void Set客室利用実績台帳id_LessThan(long? v) { reg客室利用実績台帳id(CK_LT, v); }
        public void Set客室利用実績台帳id_GreaterEqual(long? v) { reg客室利用実績台帳id(CK_GE, v); }
        public void Set客室利用実績台帳id_LessEqual(long? v) { reg客室利用実績台帳id(CK_LE, v); }
        public void Set客室利用実績台帳id_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValue客室利用実績台帳id(), "客室利用実績台帳id"); }
        public void Set客室利用実績台帳id_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValue客室利用実績台帳id(), "客室利用実績台帳id"); }
        public void InScopeDch客室利用実績台帳(SubQuery<Dch客室利用実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用実績台帳CB>", subQuery);
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室利用実績台帳id_InScopeSubQuery_Dch客室利用実績台帳(cb.Query());
            registerInScopeSubQuery(cb.Query(), "客室利用実績台帳id", "id", subQueryPropertyName);
        }
        public abstract String keep客室利用実績台帳id_InScopeSubQuery_Dch客室利用実績台帳(Dch客室利用実績台帳CQ subQuery);
        public void NotInScopeDch客室利用実績台帳(SubQuery<Dch客室利用実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用実績台帳CB>", subQuery);
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室利用実績台帳id_NotInScopeSubQuery_Dch客室利用実績台帳(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "客室利用実績台帳id", "id", subQueryPropertyName);
        }
        public abstract String keep客室利用実績台帳id_NotInScopeSubQuery_Dch客室利用実績台帳(Dch客室利用実績台帳CQ subQuery);
        protected void reg客室利用実績台帳id(ConditionKey k, Object v) { regQ(k, v, getCValue客室利用実績台帳id(), "客室利用実績台帳id"); }
        protected abstract ConditionValue getCValue客室利用実績台帳id();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<Dchその他実績台帳CB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Dchその他実績台帳CB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Dchその他実績台帳CB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Dchその他実績台帳CB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Dchその他実績台帳CB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Dchその他実績台帳CB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Dchその他実績台帳CB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Dchその他実績台帳CB>(delegate(String function, SubQuery<Dchその他実績台帳CB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Dchその他実績台帳CB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Dchその他実績台帳CB>", subQuery);
            Dchその他実績台帳CB cb = new Dchその他実績台帳CB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Dchその他実績台帳CQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Dchその他実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dchその他実績台帳CB>", subQuery);
            Dchその他実績台帳CB cb = new Dchその他実績台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "id", "id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Dchその他実績台帳CQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
