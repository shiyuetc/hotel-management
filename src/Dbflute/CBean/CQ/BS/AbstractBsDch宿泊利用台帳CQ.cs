
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
    public abstract class AbstractBsDch宿泊利用台帳CQ : AbstractConditionQuery {

        public AbstractBsDch宿泊利用台帳CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "dch宿泊利用台帳"; }
        public override String getTableSqlName() { return "dch宿泊利用台帳"; }

        public void Set客室利用台帳id_Equal(long? v) { reg客室利用台帳id(CK_EQ, v); }
        public void Set客室利用台帳id_NotEqual(long? v) { reg客室利用台帳id(CK_NES, v); }
        public void Set客室利用台帳id_GreaterThan(long? v) { reg客室利用台帳id(CK_GT, v); }
        public void Set客室利用台帳id_LessThan(long? v) { reg客室利用台帳id(CK_LT, v); }
        public void Set客室利用台帳id_GreaterEqual(long? v) { reg客室利用台帳id(CK_GE, v); }
        public void Set客室利用台帳id_LessEqual(long? v) { reg客室利用台帳id(CK_LE, v); }
        public void Set客室利用台帳id_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValue客室利用台帳id(), "客室利用台帳id"); }
        public void Set客室利用台帳id_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValue客室利用台帳id(), "客室利用台帳id"); }
        public void InScopeDch客室利用台帳(SubQuery<Dch客室利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用台帳CB>", subQuery);
            Dch客室利用台帳CB cb = new Dch客室利用台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室利用台帳id_InScopeSubQuery_Dch客室利用台帳(cb.Query());
            registerInScopeSubQuery(cb.Query(), "客室利用台帳id", "id", subQueryPropertyName);
        }
        public abstract String keep客室利用台帳id_InScopeSubQuery_Dch客室利用台帳(Dch客室利用台帳CQ subQuery);
        public void NotInScopeDch客室利用台帳(SubQuery<Dch客室利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用台帳CB>", subQuery);
            Dch客室利用台帳CB cb = new Dch客室利用台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室利用台帳id_NotInScopeSubQuery_Dch客室利用台帳(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "客室利用台帳id", "id", subQueryPropertyName);
        }
        public abstract String keep客室利用台帳id_NotInScopeSubQuery_Dch客室利用台帳(Dch客室利用台帳CQ subQuery);
        public void Set客室利用台帳id_IsNull() { reg客室利用台帳id(CK_ISN, DUMMY_OBJECT); }
        public void Set客室利用台帳id_IsNotNull() { reg客室利用台帳id(CK_ISNN, DUMMY_OBJECT); }
        protected void reg客室利用台帳id(ConditionKey k, Object v) { regQ(k, v, getCValue客室利用台帳id(), "客室利用台帳id"); }
        protected abstract ConditionValue getCValue客室利用台帳id();

        public void Set会員コード_Equal(String v) { DoSet会員コード_Equal(fRES(v)); }
        protected void DoSet会員コード_Equal(String v) { reg会員コード(CK_EQ, v); }
        public void Set会員コード_NotEqual(String v) { DoSet会員コード_NotEqual(fRES(v)); }
        protected void DoSet会員コード_NotEqual(String v) { reg会員コード(CK_NES, v); }
        public void Set会員コード_GreaterThan(String v) { reg会員コード(CK_GT, fRES(v)); }
        public void Set会員コード_LessThan(String v) { reg会員コード(CK_LT, fRES(v)); }
        public void Set会員コード_GreaterEqual(String v) { reg会員コード(CK_GE, fRES(v)); }
        public void Set会員コード_LessEqual(String v) { reg会員コード(CK_LE, fRES(v)); }
        public void Set会員コード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue会員コード(), "会員コード"); }
        public void Set会員コード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue会員コード(), "会員コード"); }
        public void Set会員コード_PrefixSearch(String v) { Set会員コード_LikeSearch(v, cLSOP()); }
        public void Set会員コード_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue会員コード(), "会員コード", option); }
        public void Set会員コード_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue会員コード(), "会員コード", option); }
        public void InScopeMst会員マスタ(SubQuery<Mst会員マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst会員マスタCB>", subQuery);
            Mst会員マスタCB cb = new Mst会員マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep会員コード_InScopeSubQuery_Mst会員マスタ(cb.Query());
            registerInScopeSubQuery(cb.Query(), "会員コード", "会員コード", subQueryPropertyName);
        }
        public abstract String keep会員コード_InScopeSubQuery_Mst会員マスタ(Mst会員マスタCQ subQuery);
        public void NotInScopeMst会員マスタ(SubQuery<Mst会員マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst会員マスタCB>", subQuery);
            Mst会員マスタCB cb = new Mst会員マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep会員コード_NotInScopeSubQuery_Mst会員マスタ(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "会員コード", "会員コード", subQueryPropertyName);
        }
        public abstract String keep会員コード_NotInScopeSubQuery_Mst会員マスタ(Mst会員マスタCQ subQuery);
        protected void reg会員コード(ConditionKey k, Object v) { regQ(k, v, getCValue会員コード(), "会員コード"); }
        protected abstract ConditionValue getCValue会員コード();

        public void Set宿泊料金_Equal(int? v) { reg宿泊料金(CK_EQ, v); }
        public void Set宿泊料金_NotEqual(int? v) { reg宿泊料金(CK_NES, v); }
        public void Set宿泊料金_GreaterThan(int? v) { reg宿泊料金(CK_GT, v); }
        public void Set宿泊料金_LessThan(int? v) { reg宿泊料金(CK_LT, v); }
        public void Set宿泊料金_GreaterEqual(int? v) { reg宿泊料金(CK_GE, v); }
        public void Set宿泊料金_LessEqual(int? v) { reg宿泊料金(CK_LE, v); }
        public void Set宿泊料金_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValue宿泊料金(), "宿泊料金"); }
        public void Set宿泊料金_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValue宿泊料金(), "宿泊料金"); }
        protected void reg宿泊料金(ConditionKey k, Object v) { regQ(k, v, getCValue宿泊料金(), "宿泊料金"); }
        protected abstract ConditionValue getCValue宿泊料金();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<Dch宿泊利用台帳CB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Dch宿泊利用台帳CB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Dch宿泊利用台帳CB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Dch宿泊利用台帳CB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Dch宿泊利用台帳CB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Dch宿泊利用台帳CB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Dch宿泊利用台帳CB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Dch宿泊利用台帳CB>(delegate(String function, SubQuery<Dch宿泊利用台帳CB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Dch宿泊利用台帳CB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Dch宿泊利用台帳CB>", subQuery);
            Dch宿泊利用台帳CB cb = new Dch宿泊利用台帳CB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Dch宿泊利用台帳CQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Dch宿泊利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch宿泊利用台帳CB>", subQuery);
            Dch宿泊利用台帳CB cb = new Dch宿泊利用台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "客室利用台帳id", "客室利用台帳id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Dch宿泊利用台帳CQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
