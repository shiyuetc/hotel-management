
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
    public abstract class AbstractBsDch月締確定台帳CQ : AbstractConditionQuery {

        public AbstractBsDch月締確定台帳CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "dch月締確定台帳"; }
        public override String getTableSqlName() { return "dch月締確定台帳"; }

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

        public void Set対象年月_Equal(DateTime? v) { reg対象年月(CK_EQ, v); }
        public void Set対象年月_GreaterThan(DateTime? v) { reg対象年月(CK_GT, v); }
        public void Set対象年月_LessThan(DateTime? v) { reg対象年月(CK_LT, v); }
        public void Set対象年月_GreaterEqual(DateTime? v) { reg対象年月(CK_GE, v); }
        public void Set対象年月_LessEqual(DateTime? v) { reg対象年月(CK_LE, v); }
        public void Set対象年月_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValue対象年月(), "対象年月", option); }
        public void Set対象年月_DateFromTo(DateTime? from, DateTime? to) { Set対象年月_FromTo(from, to, new DateFromToOption()); }
        protected void reg対象年月(ConditionKey k, Object v) { regQ(k, v, getCValue対象年月(), "対象年月"); }
        protected abstract ConditionValue getCValue対象年月();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<Dch月締確定台帳CB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Dch月締確定台帳CB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Dch月締確定台帳CB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Dch月締確定台帳CB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Dch月締確定台帳CB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Dch月締確定台帳CB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Dch月締確定台帳CB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Dch月締確定台帳CB>(delegate(String function, SubQuery<Dch月締確定台帳CB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Dch月締確定台帳CB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Dch月締確定台帳CB>", subQuery);
            Dch月締確定台帳CB cb = new Dch月締確定台帳CB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Dch月締確定台帳CQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Dch月締確定台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch月締確定台帳CB>", subQuery);
            Dch月締確定台帳CB cb = new Dch月締確定台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "id", "id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Dch月締確定台帳CQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
