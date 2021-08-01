
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
    public abstract class AbstractBsMst客室タイプマスタCQ : AbstractConditionQuery {

        public AbstractBsMst客室タイプマスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "mst客室タイプマスタ"; }
        public override String getTableSqlName() { return "mst客室タイプマスタ"; }

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
        public void ExistsMst客室マスタList(SubQuery<Mst客室マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst客室マスタCB>", subQuery);
            Mst客室マスタCB cb = new Mst客室マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室タイプコード_ExistsSubQuery_Mst客室マスタList(cb.Query());
            registerExistsSubQuery(cb.Query(), "客室タイプコード", "客室タイプコード", subQueryPropertyName);
        }
        public abstract String keep客室タイプコード_ExistsSubQuery_Mst客室マスタList(Mst客室マスタCQ subQuery);
        public void NotExistsMst客室マスタList(SubQuery<Mst客室マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst客室マスタCB>", subQuery);
            Mst客室マスタCB cb = new Mst客室マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室タイプコード_NotExistsSubQuery_Mst客室マスタList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "客室タイプコード", "客室タイプコード", subQueryPropertyName);
        }
        public abstract String keep客室タイプコード_NotExistsSubQuery_Mst客室マスタList(Mst客室マスタCQ subQuery);
        public void InScopeMst客室マスタList(SubQuery<Mst客室マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst客室マスタCB>", subQuery);
            Mst客室マスタCB cb = new Mst客室マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室タイプコード_InScopeSubQuery_Mst客室マスタList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "客室タイプコード", "客室タイプコード", subQueryPropertyName);
        }
        public abstract String keep客室タイプコード_InScopeSubQuery_Mst客室マスタList(Mst客室マスタCQ subQuery);
        public void NotInScopeMst客室マスタList(SubQuery<Mst客室マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst客室マスタCB>", subQuery);
            Mst客室マスタCB cb = new Mst客室マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室タイプコード_NotInScopeSubQuery_Mst客室マスタList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "客室タイプコード", "客室タイプコード", subQueryPropertyName);
        }
        public abstract String keep客室タイプコード_NotInScopeSubQuery_Mst客室マスタList(Mst客室マスタCQ subQuery);
        public void xsderiveMst客室マスタList(String function, SubQuery<Mst客室マスタCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Mst客室マスタCB>", subQuery);
            Mst客室マスタCB cb = new Mst客室マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室タイプコード_SpecifyDerivedReferrer_Mst客室マスタList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "客室タイプコード", "客室タイプコード", subQueryPropertyName, aliasName);
        }
        abstract public String keep客室タイプコード_SpecifyDerivedReferrer_Mst客室マスタList(Mst客室マスタCQ subQuery);

        public QDRFunction<Mst客室マスタCB> DerivedMst客室マスタList() {
            return xcreateQDRFunctionMst客室マスタList();
        }
        protected QDRFunction<Mst客室マスタCB> xcreateQDRFunctionMst客室マスタList() {
            return new QDRFunction<Mst客室マスタCB>(delegate(String function, SubQuery<Mst客室マスタCB> subQuery, String operand, Object value) {
                xqderiveMst客室マスタList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMst客室マスタList(String function, SubQuery<Mst客室マスタCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<Mst客室マスタCB>", subQuery);
            Mst客室マスタCB cb = new Mst客室マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室タイプコード_QueryDerivedReferrer_Mst客室マスタList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keep客室タイプコード_QueryDerivedReferrer_Mst客室マスタListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "客室タイプコード", "客室タイプコード", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keep客室タイプコード_QueryDerivedReferrer_Mst客室マスタList(Mst客室マスタCQ subQuery);
        public abstract String keep客室タイプコード_QueryDerivedReferrer_Mst客室マスタListParameter(Object parameterValue);
        public void Set客室タイプコード_IsNull() { reg客室タイプコード(CK_ISN, DUMMY_OBJECT); }
        public void Set客室タイプコード_IsNotNull() { reg客室タイプコード(CK_ISNN, DUMMY_OBJECT); }
        protected void reg客室タイプコード(ConditionKey k, Object v) { regQ(k, v, getCValue客室タイプコード(), "客室タイプコード"); }
        protected abstract ConditionValue getCValue客室タイプコード();

        public void Set客室タイプ名称_Equal(String v) { DoSet客室タイプ名称_Equal(fRES(v)); }
        protected void DoSet客室タイプ名称_Equal(String v) { reg客室タイプ名称(CK_EQ, v); }
        public void Set客室タイプ名称_NotEqual(String v) { DoSet客室タイプ名称_NotEqual(fRES(v)); }
        protected void DoSet客室タイプ名称_NotEqual(String v) { reg客室タイプ名称(CK_NES, v); }
        public void Set客室タイプ名称_GreaterThan(String v) { reg客室タイプ名称(CK_GT, fRES(v)); }
        public void Set客室タイプ名称_LessThan(String v) { reg客室タイプ名称(CK_LT, fRES(v)); }
        public void Set客室タイプ名称_GreaterEqual(String v) { reg客室タイプ名称(CK_GE, fRES(v)); }
        public void Set客室タイプ名称_LessEqual(String v) { reg客室タイプ名称(CK_LE, fRES(v)); }
        public void Set客室タイプ名称_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue客室タイプ名称(), "客室タイプ名称"); }
        public void Set客室タイプ名称_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue客室タイプ名称(), "客室タイプ名称"); }
        public void Set客室タイプ名称_PrefixSearch(String v) { Set客室タイプ名称_LikeSearch(v, cLSOP()); }
        public void Set客室タイプ名称_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue客室タイプ名称(), "客室タイプ名称", option); }
        public void Set客室タイプ名称_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue客室タイプ名称(), "客室タイプ名称", option); }
        protected void reg客室タイプ名称(ConditionKey k, Object v) { regQ(k, v, getCValue客室タイプ名称(), "客室タイプ名称"); }
        protected abstract ConditionValue getCValue客室タイプ名称();

        public void Set料金_Equal(int? v) { reg料金(CK_EQ, v); }
        public void Set料金_NotEqual(int? v) { reg料金(CK_NES, v); }
        public void Set料金_GreaterThan(int? v) { reg料金(CK_GT, v); }
        public void Set料金_LessThan(int? v) { reg料金(CK_LT, v); }
        public void Set料金_GreaterEqual(int? v) { reg料金(CK_GE, v); }
        public void Set料金_LessEqual(int? v) { reg料金(CK_LE, v); }
        public void Set料金_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValue料金(), "料金"); }
        public void Set料金_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValue料金(), "料金"); }
        protected void reg料金(ConditionKey k, Object v) { regQ(k, v, getCValue料金(), "料金"); }
        protected abstract ConditionValue getCValue料金();

        public void Set宿泊人数_Equal(int? v) { reg宿泊人数(CK_EQ, v); }
        public void Set宿泊人数_NotEqual(int? v) { reg宿泊人数(CK_NES, v); }
        public void Set宿泊人数_GreaterThan(int? v) { reg宿泊人数(CK_GT, v); }
        public void Set宿泊人数_LessThan(int? v) { reg宿泊人数(CK_LT, v); }
        public void Set宿泊人数_GreaterEqual(int? v) { reg宿泊人数(CK_GE, v); }
        public void Set宿泊人数_LessEqual(int? v) { reg宿泊人数(CK_LE, v); }
        public void Set宿泊人数_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValue宿泊人数(), "宿泊人数"); }
        public void Set宿泊人数_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValue宿泊人数(), "宿泊人数"); }
        protected void reg宿泊人数(ConditionKey k, Object v) { regQ(k, v, getCValue宿泊人数(), "宿泊人数"); }
        protected abstract ConditionValue getCValue宿泊人数();

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
        public SSQFunction<Mst客室タイプマスタCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Mst客室タイプマスタCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Mst客室タイプマスタCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Mst客室タイプマスタCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Mst客室タイプマスタCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Mst客室タイプマスタCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Mst客室タイプマスタCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Mst客室タイプマスタCB>(delegate(String function, SubQuery<Mst客室タイプマスタCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Mst客室タイプマスタCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Mst客室タイプマスタCB>", subQuery);
            Mst客室タイプマスタCB cb = new Mst客室タイプマスタCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Mst客室タイプマスタCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Mst客室タイプマスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst客室タイプマスタCB>", subQuery);
            Mst客室タイプマスタCB cb = new Mst客室タイプマスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "客室タイプコード", "客室タイプコード", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Mst客室タイプマスタCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
