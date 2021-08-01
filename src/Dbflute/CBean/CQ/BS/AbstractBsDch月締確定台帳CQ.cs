
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

        public void Set対象年月_Equal(String v) { DoSet対象年月_Equal(fRES(v)); }
        protected void DoSet対象年月_Equal(String v) { reg対象年月(CK_EQ, v); }
        public void Set対象年月_NotEqual(String v) { DoSet対象年月_NotEqual(fRES(v)); }
        protected void DoSet対象年月_NotEqual(String v) { reg対象年月(CK_NES, v); }
        public void Set対象年月_GreaterThan(String v) { reg対象年月(CK_GT, fRES(v)); }
        public void Set対象年月_LessThan(String v) { reg対象年月(CK_LT, fRES(v)); }
        public void Set対象年月_GreaterEqual(String v) { reg対象年月(CK_GE, fRES(v)); }
        public void Set対象年月_LessEqual(String v) { reg対象年月(CK_LE, fRES(v)); }
        public void Set対象年月_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue対象年月(), "対象年月"); }
        public void Set対象年月_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue対象年月(), "対象年月"); }
        public void Set対象年月_PrefixSearch(String v) { Set対象年月_LikeSearch(v, cLSOP()); }
        public void Set対象年月_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue対象年月(), "対象年月", option); }
        public void Set対象年月_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue対象年月(), "対象年月", option); }
        public void Set対象年月_IsNull() { reg対象年月(CK_ISN, DUMMY_OBJECT); }
        public void Set対象年月_IsNotNull() { reg対象年月(CK_ISNN, DUMMY_OBJECT); }
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
            registerInScopeSubQuery(cb.Query(), "対象年月", "対象年月", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Dch月締確定台帳CQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
