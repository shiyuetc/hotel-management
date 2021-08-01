
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

        public void Set客室コード_Equal(String v) { DoSet客室コード_Equal(fRES(v)); }
        protected void DoSet客室コード_Equal(String v) { reg客室コード(CK_EQ, v); }
        public void Set客室コード_NotEqual(String v) { DoSet客室コード_NotEqual(fRES(v)); }
        protected void DoSet客室コード_NotEqual(String v) { reg客室コード(CK_NES, v); }
        public void Set客室コード_GreaterThan(String v) { reg客室コード(CK_GT, fRES(v)); }
        public void Set客室コード_LessThan(String v) { reg客室コード(CK_LT, fRES(v)); }
        public void Set客室コード_GreaterEqual(String v) { reg客室コード(CK_GE, fRES(v)); }
        public void Set客室コード_LessEqual(String v) { reg客室コード(CK_LE, fRES(v)); }
        public void Set客室コード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue客室コード(), "客室コード"); }
        public void Set客室コード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue客室コード(), "客室コード"); }
        public void Set客室コード_PrefixSearch(String v) { Set客室コード_LikeSearch(v, cLSOP()); }
        public void Set客室コード_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue客室コード(), "客室コード", option); }
        public void Set客室コード_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue客室コード(), "客室コード", option); }
        public void ExistsDch客室利用台帳List(SubQuery<Dch客室利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用台帳CB>", subQuery);
            Dch客室利用台帳CB cb = new Dch客室利用台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室コード_ExistsSubQuery_Dch客室利用台帳List(cb.Query());
            registerExistsSubQuery(cb.Query(), "客室コード", "客室コード", subQueryPropertyName);
        }
        public abstract String keep客室コード_ExistsSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery);
        public void NotExistsDch客室利用台帳List(SubQuery<Dch客室利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用台帳CB>", subQuery);
            Dch客室利用台帳CB cb = new Dch客室利用台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室コード_NotExistsSubQuery_Dch客室利用台帳List(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "客室コード", "客室コード", subQueryPropertyName);
        }
        public abstract String keep客室コード_NotExistsSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery);
        public void InScopeDch客室利用台帳List(SubQuery<Dch客室利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用台帳CB>", subQuery);
            Dch客室利用台帳CB cb = new Dch客室利用台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室コード_InScopeSubQuery_Dch客室利用台帳List(cb.Query());
            registerInScopeSubQuery(cb.Query(), "客室コード", "客室コード", subQueryPropertyName);
        }
        public abstract String keep客室コード_InScopeSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery);
        public void NotInScopeDch客室利用台帳List(SubQuery<Dch客室利用台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用台帳CB>", subQuery);
            Dch客室利用台帳CB cb = new Dch客室利用台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室コード_NotInScopeSubQuery_Dch客室利用台帳List(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "客室コード", "客室コード", subQueryPropertyName);
        }
        public abstract String keep客室コード_NotInScopeSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery);
        public void xsderiveDch客室利用台帳List(String function, SubQuery<Dch客室利用台帳CB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Dch客室利用台帳CB>", subQuery);
            Dch客室利用台帳CB cb = new Dch客室利用台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室コード_SpecifyDerivedReferrer_Dch客室利用台帳List(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "客室コード", "客室コード", subQueryPropertyName, aliasName);
        }
        abstract public String keep客室コード_SpecifyDerivedReferrer_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery);

        public QDRFunction<Dch客室利用台帳CB> DerivedDch客室利用台帳List() {
            return xcreateQDRFunctionDch客室利用台帳List();
        }
        protected QDRFunction<Dch客室利用台帳CB> xcreateQDRFunctionDch客室利用台帳List() {
            return new QDRFunction<Dch客室利用台帳CB>(delegate(String function, SubQuery<Dch客室利用台帳CB> subQuery, String operand, Object value) {
                xqderiveDch客室利用台帳List(function, subQuery, operand, value);
            });
        }
        public void xqderiveDch客室利用台帳List(String function, SubQuery<Dch客室利用台帳CB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<Dch客室利用台帳CB>", subQuery);
            Dch客室利用台帳CB cb = new Dch客室利用台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室コード_QueryDerivedReferrer_Dch客室利用台帳List(cb.Query()); // for saving query-value.
            String parameterPropertyName = keep客室コード_QueryDerivedReferrer_Dch客室利用台帳ListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "客室コード", "客室コード", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keep客室コード_QueryDerivedReferrer_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery);
        public abstract String keep客室コード_QueryDerivedReferrer_Dch客室利用台帳ListParameter(Object parameterValue);
        public void Set客室コード_IsNull() { reg客室コード(CK_ISN, DUMMY_OBJECT); }
        public void Set客室コード_IsNotNull() { reg客室コード(CK_ISNN, DUMMY_OBJECT); }
        protected void reg客室コード(ConditionKey k, Object v) { regQ(k, v, getCValue客室コード(), "客室コード"); }
        protected abstract ConditionValue getCValue客室コード();

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

        public void Set客室タイプコード_Equal(String v) { DoSet客室タイプコード_Equal(fRES(v)); }
        protected void DoSet客室タイプコード_Equal(String v) { reg客室タイプコード(CK_EQ, v); }
        public void Set客室タイプコード_NotEqual(String v) { DoSet客室タイプコード_NotEqual(fRES(v)); }
        protected void DoSet客室タイプコード_NotEqual(String v) { reg客室タイプコード(CK_NES, v); }
        public void Set客室タイプコード_GreaterThan(String v) { reg客室タイプコード(CK_GT, fRES(v)); }
        public void Set客室タイプコード_LessThan(String v) { reg客室タイプコード(CK_LT, fRES(v)); }
        public void Set客室タイプコード_GreaterEqual(String v) { reg客室タイプコード(CK_GE, fRES(v)); }
        public void Set客室タイプコード_LessEqual(String v) { reg客室タイプコード(CK_LE, fRES(v)); }
        public void Set客室タイプコード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue客室タイプコード(), "客室タイプコード"); }
        public void Set客室タイプコード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue客室タイプコード(), "客室タイプコード"); }
        public void Set客室タイプコード_PrefixSearch(String v) { Set客室タイプコード_LikeSearch(v, cLSOP()); }
        public void Set客室タイプコード_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue客室タイプコード(), "客室タイプコード", option); }
        public void Set客室タイプコード_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue客室タイプコード(), "客室タイプコード", option); }
        public void InScopeMst客室タイプマスタ(SubQuery<Mst客室タイプマスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst客室タイプマスタCB>", subQuery);
            Mst客室タイプマスタCB cb = new Mst客室タイプマスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室タイプコード_InScopeSubQuery_Mst客室タイプマスタ(cb.Query());
            registerInScopeSubQuery(cb.Query(), "客室タイプコード", "客室タイプコード", subQueryPropertyName);
        }
        public abstract String keep客室タイプコード_InScopeSubQuery_Mst客室タイプマスタ(Mst客室タイプマスタCQ subQuery);
        public void NotInScopeMst客室タイプマスタ(SubQuery<Mst客室タイプマスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst客室タイプマスタCB>", subQuery);
            Mst客室タイプマスタCB cb = new Mst客室タイプマスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室タイプコード_NotInScopeSubQuery_Mst客室タイプマスタ(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "客室タイプコード", "客室タイプコード", subQueryPropertyName);
        }
        public abstract String keep客室タイプコード_NotInScopeSubQuery_Mst客室タイプマスタ(Mst客室タイプマスタCQ subQuery);
        protected void reg客室タイプコード(ConditionKey k, Object v) { regQ(k, v, getCValue客室タイプコード(), "客室タイプコード"); }
        protected abstract ConditionValue getCValue客室タイプコード();

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
            registerInScopeSubQuery(cb.Query(), "客室コード", "客室コード", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Mst客室マスタCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
