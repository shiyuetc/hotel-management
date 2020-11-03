
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
    public abstract class AbstractBsKbnRankCQ : AbstractConditionQuery {

        public AbstractBsKbnRankCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "kbn_rank"; }
        public override String getTableSqlName() { return "kbn_rank"; }

        public void SetCode_Equal(String v) { DoSetCode_Equal(fRES(v)); }
        protected void DoSetCode_Equal(String v) { regCode(CK_EQ, v); }
        public void SetCode_NotEqual(String v) { DoSetCode_NotEqual(fRES(v)); }
        protected void DoSetCode_NotEqual(String v) { regCode(CK_NES, v); }
        public void SetCode_GreaterThan(String v) { regCode(CK_GT, fRES(v)); }
        public void SetCode_LessThan(String v) { regCode(CK_LT, fRES(v)); }
        public void SetCode_GreaterEqual(String v) { regCode(CK_GE, fRES(v)); }
        public void SetCode_LessEqual(String v) { regCode(CK_LE, fRES(v)); }
        public void SetCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueCode(), "code"); }
        public void SetCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueCode(), "code"); }
        public void SetCode_PrefixSearch(String v) { SetCode_LikeSearch(v, cLSOP()); }
        public void SetCode_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueCode(), "code", option); }
        public void SetCode_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueCode(), "code", option); }
        public void ExistsMstEmployeeList(SubQuery<MstEmployeeCB> subQuery) {
            assertObjectNotNull("subQuery<MstEmployeeCB>", subQuery);
            MstEmployeeCB cb = new MstEmployeeCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_ExistsSubQuery_MstEmployeeList(cb.Query());
            registerExistsSubQuery(cb.Query(), "code", "rank_code", subQueryPropertyName);
        }
        public abstract String keepCode_ExistsSubQuery_MstEmployeeList(MstEmployeeCQ subQuery);
        public void NotExistsMstEmployeeList(SubQuery<MstEmployeeCB> subQuery) {
            assertObjectNotNull("subQuery<MstEmployeeCB>", subQuery);
            MstEmployeeCB cb = new MstEmployeeCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_NotExistsSubQuery_MstEmployeeList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "code", "rank_code", subQueryPropertyName);
        }
        public abstract String keepCode_NotExistsSubQuery_MstEmployeeList(MstEmployeeCQ subQuery);
        public void InScopeMstEmployeeList(SubQuery<MstEmployeeCB> subQuery) {
            assertObjectNotNull("subQuery<MstEmployeeCB>", subQuery);
            MstEmployeeCB cb = new MstEmployeeCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_InScopeSubQuery_MstEmployeeList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "code", "rank_code", subQueryPropertyName);
        }
        public abstract String keepCode_InScopeSubQuery_MstEmployeeList(MstEmployeeCQ subQuery);
        public void NotInScopeMstEmployeeList(SubQuery<MstEmployeeCB> subQuery) {
            assertObjectNotNull("subQuery<MstEmployeeCB>", subQuery);
            MstEmployeeCB cb = new MstEmployeeCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_NotInScopeSubQuery_MstEmployeeList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "code", "rank_code", subQueryPropertyName);
        }
        public abstract String keepCode_NotInScopeSubQuery_MstEmployeeList(MstEmployeeCQ subQuery);
        public void xsderiveMstEmployeeList(String function, SubQuery<MstEmployeeCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MstEmployeeCB>", subQuery);
            MstEmployeeCB cb = new MstEmployeeCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_SpecifyDerivedReferrer_MstEmployeeList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "code", "rank_code", subQueryPropertyName, aliasName);
        }
        abstract public String keepCode_SpecifyDerivedReferrer_MstEmployeeList(MstEmployeeCQ subQuery);

        public QDRFunction<MstEmployeeCB> DerivedMstEmployeeList() {
            return xcreateQDRFunctionMstEmployeeList();
        }
        protected QDRFunction<MstEmployeeCB> xcreateQDRFunctionMstEmployeeList() {
            return new QDRFunction<MstEmployeeCB>(delegate(String function, SubQuery<MstEmployeeCB> subQuery, String operand, Object value) {
                xqderiveMstEmployeeList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMstEmployeeList(String function, SubQuery<MstEmployeeCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<MstEmployeeCB>", subQuery);
            MstEmployeeCB cb = new MstEmployeeCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCode_QueryDerivedReferrer_MstEmployeeList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepCode_QueryDerivedReferrer_MstEmployeeListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "code", "rank_code", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepCode_QueryDerivedReferrer_MstEmployeeList(MstEmployeeCQ subQuery);
        public abstract String keepCode_QueryDerivedReferrer_MstEmployeeListParameter(Object parameterValue);
        public void SetCode_IsNull() { regCode(CK_ISN, DUMMY_OBJECT); }
        public void SetCode_IsNotNull() { regCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regCode(ConditionKey k, Object v) { regQ(k, v, getCValueCode(), "code"); }
        protected abstract ConditionValue getCValueCode();

        public void SetEnglishName_Equal(String v) { DoSetEnglishName_Equal(fRES(v)); }
        protected void DoSetEnglishName_Equal(String v) { regEnglishName(CK_EQ, v); }
        public void SetEnglishName_NotEqual(String v) { DoSetEnglishName_NotEqual(fRES(v)); }
        protected void DoSetEnglishName_NotEqual(String v) { regEnglishName(CK_NES, v); }
        public void SetEnglishName_GreaterThan(String v) { regEnglishName(CK_GT, fRES(v)); }
        public void SetEnglishName_LessThan(String v) { regEnglishName(CK_LT, fRES(v)); }
        public void SetEnglishName_GreaterEqual(String v) { regEnglishName(CK_GE, fRES(v)); }
        public void SetEnglishName_LessEqual(String v) { regEnglishName(CK_LE, fRES(v)); }
        public void SetEnglishName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueEnglishName(), "english_name"); }
        public void SetEnglishName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueEnglishName(), "english_name"); }
        public void SetEnglishName_PrefixSearch(String v) { SetEnglishName_LikeSearch(v, cLSOP()); }
        public void SetEnglishName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueEnglishName(), "english_name", option); }
        public void SetEnglishName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueEnglishName(), "english_name", option); }
        protected void regEnglishName(ConditionKey k, Object v) { regQ(k, v, getCValueEnglishName(), "english_name"); }
        protected abstract ConditionValue getCValueEnglishName();

        public void SetJapaneseName_Equal(String v) { DoSetJapaneseName_Equal(fRES(v)); }
        protected void DoSetJapaneseName_Equal(String v) { regJapaneseName(CK_EQ, v); }
        public void SetJapaneseName_NotEqual(String v) { DoSetJapaneseName_NotEqual(fRES(v)); }
        protected void DoSetJapaneseName_NotEqual(String v) { regJapaneseName(CK_NES, v); }
        public void SetJapaneseName_GreaterThan(String v) { regJapaneseName(CK_GT, fRES(v)); }
        public void SetJapaneseName_LessThan(String v) { regJapaneseName(CK_LT, fRES(v)); }
        public void SetJapaneseName_GreaterEqual(String v) { regJapaneseName(CK_GE, fRES(v)); }
        public void SetJapaneseName_LessEqual(String v) { regJapaneseName(CK_LE, fRES(v)); }
        public void SetJapaneseName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueJapaneseName(), "japanese_name"); }
        public void SetJapaneseName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueJapaneseName(), "japanese_name"); }
        public void SetJapaneseName_PrefixSearch(String v) { SetJapaneseName_LikeSearch(v, cLSOP()); }
        public void SetJapaneseName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueJapaneseName(), "japanese_name", option); }
        public void SetJapaneseName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueJapaneseName(), "japanese_name", option); }
        protected void regJapaneseName(ConditionKey k, Object v) { regQ(k, v, getCValueJapaneseName(), "japanese_name"); }
        protected abstract ConditionValue getCValueJapaneseName();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<KbnRankCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<KbnRankCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<KbnRankCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<KbnRankCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<KbnRankCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<KbnRankCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<KbnRankCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<KbnRankCB>(delegate(String function, SubQuery<KbnRankCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<KbnRankCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<KbnRankCB>", subQuery);
            KbnRankCB cb = new KbnRankCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(KbnRankCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<KbnRankCB> subQuery) {
            assertObjectNotNull("subQuery<KbnRankCB>", subQuery);
            KbnRankCB cb = new KbnRankCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "code", "code", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(KbnRankCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
