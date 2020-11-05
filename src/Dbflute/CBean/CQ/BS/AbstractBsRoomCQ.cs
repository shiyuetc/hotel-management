
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
    public abstract class AbstractBsRoomCQ : AbstractConditionQuery {

        public AbstractBsRoomCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "room"; }
        public override String getTableSqlName() { return "room"; }

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

        public void SetRoomNo_Equal(String v) { DoSetRoomNo_Equal(fRES(v)); }
        protected void DoSetRoomNo_Equal(String v) { regRoomNo(CK_EQ, v); }
        public void SetRoomNo_NotEqual(String v) { DoSetRoomNo_NotEqual(fRES(v)); }
        protected void DoSetRoomNo_NotEqual(String v) { regRoomNo(CK_NES, v); }
        public void SetRoomNo_GreaterThan(String v) { regRoomNo(CK_GT, fRES(v)); }
        public void SetRoomNo_LessThan(String v) { regRoomNo(CK_LT, fRES(v)); }
        public void SetRoomNo_GreaterEqual(String v) { regRoomNo(CK_GE, fRES(v)); }
        public void SetRoomNo_LessEqual(String v) { regRoomNo(CK_LE, fRES(v)); }
        public void SetRoomNo_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRoomNo(), "room_no"); }
        public void SetRoomNo_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRoomNo(), "room_no"); }
        public void SetRoomNo_PrefixSearch(String v) { SetRoomNo_LikeSearch(v, cLSOP()); }
        public void SetRoomNo_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRoomNo(), "room_no", option); }
        public void SetRoomNo_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRoomNo(), "room_no", option); }
        protected void regRoomNo(ConditionKey k, Object v) { regQ(k, v, getCValueRoomNo(), "room_no"); }
        protected abstract ConditionValue getCValueRoomNo();

        public void SetRoomTypeCode_Equal(String v) { DoSetRoomTypeCode_Equal(fRES(v)); }
        protected void DoSetRoomTypeCode_Equal(String v) { regRoomTypeCode(CK_EQ, v); }
        public void SetRoomTypeCode_NotEqual(String v) { DoSetRoomTypeCode_NotEqual(fRES(v)); }
        protected void DoSetRoomTypeCode_NotEqual(String v) { regRoomTypeCode(CK_NES, v); }
        public void SetRoomTypeCode_GreaterThan(String v) { regRoomTypeCode(CK_GT, fRES(v)); }
        public void SetRoomTypeCode_LessThan(String v) { regRoomTypeCode(CK_LT, fRES(v)); }
        public void SetRoomTypeCode_GreaterEqual(String v) { regRoomTypeCode(CK_GE, fRES(v)); }
        public void SetRoomTypeCode_LessEqual(String v) { regRoomTypeCode(CK_LE, fRES(v)); }
        public void SetRoomTypeCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRoomTypeCode(), "room_type_code"); }
        public void SetRoomTypeCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRoomTypeCode(), "room_type_code"); }
        public void SetRoomTypeCode_PrefixSearch(String v) { SetRoomTypeCode_LikeSearch(v, cLSOP()); }
        public void SetRoomTypeCode_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRoomTypeCode(), "room_type_code", option); }
        public void SetRoomTypeCode_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRoomTypeCode(), "room_type_code", option); }
        protected void regRoomTypeCode(ConditionKey k, Object v) { regQ(k, v, getCValueRoomTypeCode(), "room_type_code"); }
        protected abstract ConditionValue getCValueRoomTypeCode();

        public void SetCanSmoke_Equal(bool? v) { regCanSmoke(CK_EQ, v); }
        public void SetCanSmoke_IsNull() { regCanSmoke(CK_ISN, DUMMY_OBJECT); }
        public void SetCanSmoke_IsNotNull() { regCanSmoke(CK_ISNN, DUMMY_OBJECT); }
        protected void regCanSmoke(ConditionKey k, Object v) { regQ(k, v, getCValueCanSmoke(), "can_smoke"); }
        protected abstract ConditionValue getCValueCanSmoke();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<RoomCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<RoomCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<RoomCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<RoomCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<RoomCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<RoomCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<RoomCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<RoomCB>(delegate(String function, SubQuery<RoomCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<RoomCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<RoomCB>", subQuery);
            RoomCB cb = new RoomCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(RoomCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<RoomCB> subQuery) {
            assertObjectNotNull("subQuery<RoomCB>", subQuery);
            RoomCB cb = new RoomCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "id", "id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(RoomCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
