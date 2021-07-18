
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
    public abstract class AbstractBsMst客室マスタCQ : AbstractConditionQuery {

        public AbstractBsMst客室マスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "mst客室マスタ"; }
        public override String getTableSqlName() { return "mst客室マスタ"; }

        public void SetId_Equal(long? v) { regId(CK_EQ, v); }
        public void SetId_NotEqual(long? v) { regId(CK_NES, v); }
        public void SetId_GreaterThan(long? v) { regId(CK_GT, v); }
        public void SetId_LessThan(long? v) { regId(CK_LT, v); }
        public void SetId_GreaterEqual(long? v) { regId(CK_GE, v); }
        public void SetId_LessEqual(long? v) { regId(CK_LE, v); }
        public void SetId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueId(), "id"); }
        public void SetId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueId(), "id"); }
        public void ExistsDch客室利用予定台帳List(SubQuery<Dch客室利用予定台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用予定台帳CB>", subQuery);
            Dch客室利用予定台帳CB cb = new Dch客室利用予定台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_ExistsSubQuery_Dch客室利用予定台帳List(cb.Query());
            registerExistsSubQuery(cb.Query(), "id", "客室マスタid", subQueryPropertyName);
        }
        public abstract String keepId_ExistsSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery);
        public void ExistsDch客室利用実績台帳List(SubQuery<Dch客室利用実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用実績台帳CB>", subQuery);
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_ExistsSubQuery_Dch客室利用実績台帳List(cb.Query());
            registerExistsSubQuery(cb.Query(), "id", "客室マスタid", subQueryPropertyName);
        }
        public abstract String keepId_ExistsSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery);
        public void NotExistsDch客室利用予定台帳List(SubQuery<Dch客室利用予定台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用予定台帳CB>", subQuery);
            Dch客室利用予定台帳CB cb = new Dch客室利用予定台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_NotExistsSubQuery_Dch客室利用予定台帳List(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "id", "客室マスタid", subQueryPropertyName);
        }
        public abstract String keepId_NotExistsSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery);
        public void NotExistsDch客室利用実績台帳List(SubQuery<Dch客室利用実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用実績台帳CB>", subQuery);
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_NotExistsSubQuery_Dch客室利用実績台帳List(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "id", "客室マスタid", subQueryPropertyName);
        }
        public abstract String keepId_NotExistsSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery);
        public void InScopeDch客室利用予定台帳List(SubQuery<Dch客室利用予定台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用予定台帳CB>", subQuery);
            Dch客室利用予定台帳CB cb = new Dch客室利用予定台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_InScopeSubQuery_Dch客室利用予定台帳List(cb.Query());
            registerInScopeSubQuery(cb.Query(), "id", "客室マスタid", subQueryPropertyName);
        }
        public abstract String keepId_InScopeSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery);
        public void InScopeDch客室利用実績台帳List(SubQuery<Dch客室利用実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用実績台帳CB>", subQuery);
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_InScopeSubQuery_Dch客室利用実績台帳List(cb.Query());
            registerInScopeSubQuery(cb.Query(), "id", "客室マスタid", subQueryPropertyName);
        }
        public abstract String keepId_InScopeSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery);
        public void NotInScopeDch客室利用予定台帳List(SubQuery<Dch客室利用予定台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用予定台帳CB>", subQuery);
            Dch客室利用予定台帳CB cb = new Dch客室利用予定台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_NotInScopeSubQuery_Dch客室利用予定台帳List(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "id", "客室マスタid", subQueryPropertyName);
        }
        public abstract String keepId_NotInScopeSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery);
        public void NotInScopeDch客室利用実績台帳List(SubQuery<Dch客室利用実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用実績台帳CB>", subQuery);
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_NotInScopeSubQuery_Dch客室利用実績台帳List(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "id", "客室マスタid", subQueryPropertyName);
        }
        public abstract String keepId_NotInScopeSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery);
        public void xsderiveDch客室利用予定台帳List(String function, SubQuery<Dch客室利用予定台帳CB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Dch客室利用予定台帳CB>", subQuery);
            Dch客室利用予定台帳CB cb = new Dch客室利用予定台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_SpecifyDerivedReferrer_Dch客室利用予定台帳List(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "id", "客室マスタid", subQueryPropertyName, aliasName);
        }
        abstract public String keepId_SpecifyDerivedReferrer_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery);
        public void xsderiveDch客室利用実績台帳List(String function, SubQuery<Dch客室利用実績台帳CB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Dch客室利用実績台帳CB>", subQuery);
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_SpecifyDerivedReferrer_Dch客室利用実績台帳List(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "id", "客室マスタid", subQueryPropertyName, aliasName);
        }
        abstract public String keepId_SpecifyDerivedReferrer_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery);

        public QDRFunction<Dch客室利用予定台帳CB> DerivedDch客室利用予定台帳List() {
            return xcreateQDRFunctionDch客室利用予定台帳List();
        }
        protected QDRFunction<Dch客室利用予定台帳CB> xcreateQDRFunctionDch客室利用予定台帳List() {
            return new QDRFunction<Dch客室利用予定台帳CB>(delegate(String function, SubQuery<Dch客室利用予定台帳CB> subQuery, String operand, Object value) {
                xqderiveDch客室利用予定台帳List(function, subQuery, operand, value);
            });
        }
        public void xqderiveDch客室利用予定台帳List(String function, SubQuery<Dch客室利用予定台帳CB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<Dch客室利用予定台帳CB>", subQuery);
            Dch客室利用予定台帳CB cb = new Dch客室利用予定台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_QueryDerivedReferrer_Dch客室利用予定台帳List(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepId_QueryDerivedReferrer_Dch客室利用予定台帳ListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "id", "客室マスタid", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepId_QueryDerivedReferrer_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery);
        public abstract String keepId_QueryDerivedReferrer_Dch客室利用予定台帳ListParameter(Object parameterValue);

        public QDRFunction<Dch客室利用実績台帳CB> DerivedDch客室利用実績台帳List() {
            return xcreateQDRFunctionDch客室利用実績台帳List();
        }
        protected QDRFunction<Dch客室利用実績台帳CB> xcreateQDRFunctionDch客室利用実績台帳List() {
            return new QDRFunction<Dch客室利用実績台帳CB>(delegate(String function, SubQuery<Dch客室利用実績台帳CB> subQuery, String operand, Object value) {
                xqderiveDch客室利用実績台帳List(function, subQuery, operand, value);
            });
        }
        public void xqderiveDch客室利用実績台帳List(String function, SubQuery<Dch客室利用実績台帳CB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<Dch客室利用実績台帳CB>", subQuery);
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_QueryDerivedReferrer_Dch客室利用実績台帳List(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepId_QueryDerivedReferrer_Dch客室利用実績台帳ListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "id", "客室マスタid", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepId_QueryDerivedReferrer_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery);
        public abstract String keepId_QueryDerivedReferrer_Dch客室利用実績台帳ListParameter(Object parameterValue);
        public void SetId_IsNull() { regId(CK_ISN, DUMMY_OBJECT); }
        public void SetId_IsNotNull() { regId(CK_ISNN, DUMMY_OBJECT); }
        protected void regId(ConditionKey k, Object v) { regQ(k, v, getCValueId(), "id"); }
        protected abstract ConditionValue getCValueId();

        public void Set客室番号_Equal(String v) { DoSet客室番号_Equal(fRES(v)); }
        protected void DoSet客室番号_Equal(String v) { reg客室番号(CK_EQ, v); }
        public void Set客室番号_NotEqual(String v) { DoSet客室番号_NotEqual(fRES(v)); }
        protected void DoSet客室番号_NotEqual(String v) { reg客室番号(CK_NES, v); }
        public void Set客室番号_GreaterThan(String v) { reg客室番号(CK_GT, fRES(v)); }
        public void Set客室番号_LessThan(String v) { reg客室番号(CK_LT, fRES(v)); }
        public void Set客室番号_GreaterEqual(String v) { reg客室番号(CK_GE, fRES(v)); }
        public void Set客室番号_LessEqual(String v) { reg客室番号(CK_LE, fRES(v)); }
        public void Set客室番号_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue客室番号(), "客室番号"); }
        public void Set客室番号_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue客室番号(), "客室番号"); }
        public void Set客室番号_PrefixSearch(String v) { Set客室番号_LikeSearch(v, cLSOP()); }
        public void Set客室番号_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue客室番号(), "客室番号", option); }
        public void Set客室番号_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue客室番号(), "客室番号", option); }
        protected void reg客室番号(ConditionKey k, Object v) { regQ(k, v, getCValue客室番号(), "客室番号"); }
        protected abstract ConditionValue getCValue客室番号();

        public void Set客室タイプid_Equal(long? v) { reg客室タイプid(CK_EQ, v); }
        public void Set客室タイプid_NotEqual(long? v) { reg客室タイプid(CK_NES, v); }
        public void Set客室タイプid_GreaterThan(long? v) { reg客室タイプid(CK_GT, v); }
        public void Set客室タイプid_LessThan(long? v) { reg客室タイプid(CK_LT, v); }
        public void Set客室タイプid_GreaterEqual(long? v) { reg客室タイプid(CK_GE, v); }
        public void Set客室タイプid_LessEqual(long? v) { reg客室タイプid(CK_LE, v); }
        public void Set客室タイプid_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValue客室タイプid(), "客室タイプid"); }
        public void Set客室タイプid_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValue客室タイプid(), "客室タイプid"); }
        public void InScopeMst客室タイプマスタ(SubQuery<Mst客室タイプマスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst客室タイプマスタCB>", subQuery);
            Mst客室タイプマスタCB cb = new Mst客室タイプマスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室タイプid_InScopeSubQuery_Mst客室タイプマスタ(cb.Query());
            registerInScopeSubQuery(cb.Query(), "客室タイプid", "id", subQueryPropertyName);
        }
        public abstract String keep客室タイプid_InScopeSubQuery_Mst客室タイプマスタ(Mst客室タイプマスタCQ subQuery);
        public void NotInScopeMst客室タイプマスタ(SubQuery<Mst客室タイプマスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst客室タイプマスタCB>", subQuery);
            Mst客室タイプマスタCB cb = new Mst客室タイプマスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室タイプid_NotInScopeSubQuery_Mst客室タイプマスタ(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "客室タイプid", "id", subQueryPropertyName);
        }
        public abstract String keep客室タイプid_NotInScopeSubQuery_Mst客室タイプマスタ(Mst客室タイプマスタCQ subQuery);
        protected void reg客室タイプid(ConditionKey k, Object v) { regQ(k, v, getCValue客室タイプid(), "客室タイプid"); }
        protected abstract ConditionValue getCValue客室タイプid();

        public void Set喫煙_Equal(bool? v) { reg喫煙(CK_EQ, v); }
        protected void reg喫煙(ConditionKey k, Object v) { regQ(k, v, getCValue喫煙(), "喫煙"); }
        protected abstract ConditionValue getCValue喫煙();

        public void Set備考_Equal(String v) { DoSet備考_Equal(fRES(v)); }
        protected void DoSet備考_Equal(String v) { reg備考(CK_EQ, v); }
        public void Set備考_NotEqual(String v) { DoSet備考_NotEqual(fRES(v)); }
        protected void DoSet備考_NotEqual(String v) { reg備考(CK_NES, v); }
        public void Set備考_GreaterThan(String v) { reg備考(CK_GT, fRES(v)); }
        public void Set備考_LessThan(String v) { reg備考(CK_LT, fRES(v)); }
        public void Set備考_GreaterEqual(String v) { reg備考(CK_GE, fRES(v)); }
        public void Set備考_LessEqual(String v) { reg備考(CK_LE, fRES(v)); }
        public void Set備考_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue備考(), "備考"); }
        public void Set備考_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue備考(), "備考"); }
        public void Set備考_PrefixSearch(String v) { Set備考_LikeSearch(v, cLSOP()); }
        public void Set備考_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue備考(), "備考", option); }
        public void Set備考_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue備考(), "備考", option); }
        public void Set備考_IsNull() { reg備考(CK_ISN, DUMMY_OBJECT); }
        public void Set備考_IsNotNull() { reg備考(CK_ISNN, DUMMY_OBJECT); }
        protected void reg備考(ConditionKey k, Object v) { regQ(k, v, getCValue備考(), "備考"); }
        protected abstract ConditionValue getCValue備考();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<Mst客室マスタCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Mst客室マスタCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Mst客室マスタCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Mst客室マスタCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Mst客室マスタCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Mst客室マスタCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Mst客室マスタCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Mst客室マスタCB>(delegate(String function, SubQuery<Mst客室マスタCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Mst客室マスタCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Mst客室マスタCB>", subQuery);
            Mst客室マスタCB cb = new Mst客室マスタCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Mst客室マスタCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Mst客室マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst客室マスタCB>", subQuery);
            Mst客室マスタCB cb = new Mst客室マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "id", "id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Mst客室マスタCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
