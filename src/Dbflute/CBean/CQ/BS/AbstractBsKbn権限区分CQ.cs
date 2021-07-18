
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
    public abstract class AbstractBsKbn権限区分CQ : AbstractConditionQuery {

        public AbstractBsKbn権限区分CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "kbn権限区分"; }
        public override String getTableSqlName() { return "kbn権限区分"; }

        public void Setコード_Equal(String v) { DoSetコード_Equal(fRES(v)); }
        protected void DoSetコード_Equal(String v) { regコード(CK_EQ, v); }
        public void Setコード_NotEqual(String v) { DoSetコード_NotEqual(fRES(v)); }
        protected void DoSetコード_NotEqual(String v) { regコード(CK_NES, v); }
        public void Setコード_GreaterThan(String v) { regコード(CK_GT, fRES(v)); }
        public void Setコード_LessThan(String v) { regコード(CK_LT, fRES(v)); }
        public void Setコード_GreaterEqual(String v) { regコード(CK_GE, fRES(v)); }
        public void Setコード_LessEqual(String v) { regコード(CK_LE, fRES(v)); }
        public void Setコード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueコード(), "コード"); }
        public void Setコード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueコード(), "コード"); }
        public void Setコード_PrefixSearch(String v) { Setコード_LikeSearch(v, cLSOP()); }
        public void Setコード_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueコード(), "コード", option); }
        public void Setコード_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueコード(), "コード", option); }
        public void ExistsMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_ExistsSubQuery_Mst権限マスタList(cb.Query());
            registerExistsSubQuery(cb.Query(), "コード", "権限コード", subQueryPropertyName);
        }
        public abstract String keepコード_ExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void NotExistsMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_NotExistsSubQuery_Mst権限マスタList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "コード", "権限コード", subQueryPropertyName);
        }
        public abstract String keepコード_NotExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void InScopeMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_InScopeSubQuery_Mst権限マスタList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "コード", "権限コード", subQueryPropertyName);
        }
        public abstract String keepコード_InScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void NotInScopeMst権限マスタList(SubQuery<Mst権限マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_NotInScopeSubQuery_Mst権限マスタList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "コード", "権限コード", subQueryPropertyName);
        }
        public abstract String keepコード_NotInScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public void xsderiveMst権限マスタList(String function, SubQuery<Mst権限マスタCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_SpecifyDerivedReferrer_Mst権限マスタList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "コード", "権限コード", subQueryPropertyName, aliasName);
        }
        abstract public String keepコード_SpecifyDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery);

        public QDRFunction<Mst権限マスタCB> DerivedMst権限マスタList() {
            return xcreateQDRFunctionMst権限マスタList();
        }
        protected QDRFunction<Mst権限マスタCB> xcreateQDRFunctionMst権限マスタList() {
            return new QDRFunction<Mst権限マスタCB>(delegate(String function, SubQuery<Mst権限マスタCB> subQuery, String operand, Object value) {
                xqderiveMst権限マスタList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMst権限マスタList(String function, SubQuery<Mst権限マスタCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<Mst権限マスタCB>", subQuery);
            Mst権限マスタCB cb = new Mst権限マスタCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_QueryDerivedReferrer_Mst権限マスタList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepコード_QueryDerivedReferrer_Mst権限マスタListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "コード", "権限コード", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepコード_QueryDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery);
        public abstract String keepコード_QueryDerivedReferrer_Mst権限マスタListParameter(Object parameterValue);
        public void Setコード_IsNull() { regコード(CK_ISN, DUMMY_OBJECT); }
        public void Setコード_IsNotNull() { regコード(CK_ISNN, DUMMY_OBJECT); }
        protected void regコード(ConditionKey k, Object v) { regQ(k, v, getCValueコード(), "コード"); }
        protected abstract ConditionValue getCValueコード();

        public void Set名称_Equal(String v) { DoSet名称_Equal(fRES(v)); }
        protected void DoSet名称_Equal(String v) { reg名称(CK_EQ, v); }
        public void Set名称_NotEqual(String v) { DoSet名称_NotEqual(fRES(v)); }
        protected void DoSet名称_NotEqual(String v) { reg名称(CK_NES, v); }
        public void Set名称_GreaterThan(String v) { reg名称(CK_GT, fRES(v)); }
        public void Set名称_LessThan(String v) { reg名称(CK_LT, fRES(v)); }
        public void Set名称_GreaterEqual(String v) { reg名称(CK_GE, fRES(v)); }
        public void Set名称_LessEqual(String v) { reg名称(CK_LE, fRES(v)); }
        public void Set名称_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue名称(), "名称"); }
        public void Set名称_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue名称(), "名称"); }
        public void Set名称_PrefixSearch(String v) { Set名称_LikeSearch(v, cLSOP()); }
        public void Set名称_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValue名称(), "名称", option); }
        public void Set名称_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValue名称(), "名称", option); }
        protected void reg名称(ConditionKey k, Object v) { regQ(k, v, getCValue名称(), "名称"); }
        protected abstract ConditionValue getCValue名称();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<Kbn権限区分CB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Kbn権限区分CB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Kbn権限区分CB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Kbn権限区分CB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Kbn権限区分CB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Kbn権限区分CB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Kbn権限区分CB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Kbn権限区分CB>(delegate(String function, SubQuery<Kbn権限区分CB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Kbn権限区分CB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Kbn権限区分CB>", subQuery);
            Kbn権限区分CB cb = new Kbn権限区分CB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Kbn権限区分CQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Kbn権限区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbn権限区分CB>", subQuery);
            Kbn権限区分CB cb = new Kbn権限区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "コード", "コード", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Kbn権限区分CQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
