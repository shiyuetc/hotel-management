
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
    public abstract class AbstractBsKbnRoomTypeCQ : AbstractConditionQuery {

        public AbstractBsKbnRoomTypeCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "kbn_room_type"; }
        public override String getTableSqlName() { return "kbn_room_type"; }

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
        public void SetCode_IsNull() { regCode(CK_ISN, DUMMY_OBJECT); }
        public void SetCode_IsNotNull() { regCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regCode(ConditionKey k, Object v) { regQ(k, v, getCValueCode(), "code"); }
        protected abstract ConditionValue getCValueCode();

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

        public void SetPrice_Equal(int? v) { regPrice(CK_EQ, v); }
        public void SetPrice_NotEqual(int? v) { regPrice(CK_NES, v); }
        public void SetPrice_GreaterThan(int? v) { regPrice(CK_GT, v); }
        public void SetPrice_LessThan(int? v) { regPrice(CK_LT, v); }
        public void SetPrice_GreaterEqual(int? v) { regPrice(CK_GE, v); }
        public void SetPrice_LessEqual(int? v) { regPrice(CK_LE, v); }
        public void SetPrice_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValuePrice(), "price"); }
        public void SetPrice_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValuePrice(), "price"); }
        public void SetPrice_IsNull() { regPrice(CK_ISN, DUMMY_OBJECT); }
        public void SetPrice_IsNotNull() { regPrice(CK_ISNN, DUMMY_OBJECT); }
        protected void regPrice(ConditionKey k, Object v) { regQ(k, v, getCValuePrice(), "price"); }
        protected abstract ConditionValue getCValuePrice();

        public void SetCapacity_Equal(int? v) { regCapacity(CK_EQ, v); }
        public void SetCapacity_NotEqual(int? v) { regCapacity(CK_NES, v); }
        public void SetCapacity_GreaterThan(int? v) { regCapacity(CK_GT, v); }
        public void SetCapacity_LessThan(int? v) { regCapacity(CK_LT, v); }
        public void SetCapacity_GreaterEqual(int? v) { regCapacity(CK_GE, v); }
        public void SetCapacity_LessEqual(int? v) { regCapacity(CK_LE, v); }
        public void SetCapacity_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueCapacity(), "capacity"); }
        public void SetCapacity_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueCapacity(), "capacity"); }
        public void SetCapacity_IsNull() { regCapacity(CK_ISN, DUMMY_OBJECT); }
        public void SetCapacity_IsNotNull() { regCapacity(CK_ISNN, DUMMY_OBJECT); }
        protected void regCapacity(ConditionKey k, Object v) { regQ(k, v, getCValueCapacity(), "capacity"); }
        protected abstract ConditionValue getCValueCapacity();

        public void SetDescription_Equal(String v) { DoSetDescription_Equal(fRES(v)); }
        protected void DoSetDescription_Equal(String v) { regDescription(CK_EQ, v); }
        public void SetDescription_NotEqual(String v) { DoSetDescription_NotEqual(fRES(v)); }
        protected void DoSetDescription_NotEqual(String v) { regDescription(CK_NES, v); }
        public void SetDescription_GreaterThan(String v) { regDescription(CK_GT, fRES(v)); }
        public void SetDescription_LessThan(String v) { regDescription(CK_LT, fRES(v)); }
        public void SetDescription_GreaterEqual(String v) { regDescription(CK_GE, fRES(v)); }
        public void SetDescription_LessEqual(String v) { regDescription(CK_LE, fRES(v)); }
        public void SetDescription_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueDescription(), "description"); }
        public void SetDescription_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueDescription(), "description"); }
        public void SetDescription_PrefixSearch(String v) { SetDescription_LikeSearch(v, cLSOP()); }
        public void SetDescription_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueDescription(), "description", option); }
        public void SetDescription_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueDescription(), "description", option); }
        protected void regDescription(ConditionKey k, Object v) { regQ(k, v, getCValueDescription(), "description"); }
        protected abstract ConditionValue getCValueDescription();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<KbnRoomTypeCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<KbnRoomTypeCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<KbnRoomTypeCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<KbnRoomTypeCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<KbnRoomTypeCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<KbnRoomTypeCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<KbnRoomTypeCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<KbnRoomTypeCB>(delegate(String function, SubQuery<KbnRoomTypeCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<KbnRoomTypeCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<KbnRoomTypeCB>", subQuery);
            KbnRoomTypeCB cb = new KbnRoomTypeCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(KbnRoomTypeCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<KbnRoomTypeCB> subQuery) {
            assertObjectNotNull("subQuery<KbnRoomTypeCB>", subQuery);
            KbnRoomTypeCB cb = new KbnRoomTypeCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "code", "code", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(KbnRoomTypeCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
