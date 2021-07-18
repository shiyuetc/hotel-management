
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
    public abstract class AbstractBsDch客室利用実績台帳CQ : AbstractConditionQuery {

        public AbstractBsDch客室利用実績台帳CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "dch客室利用実績台帳"; }
        public override String getTableSqlName() { return "dch客室利用実績台帳"; }

        public void SetId_Equal(long? v) { regId(CK_EQ, v); }
        public void SetId_NotEqual(long? v) { regId(CK_NES, v); }
        public void SetId_GreaterThan(long? v) { regId(CK_GT, v); }
        public void SetId_LessThan(long? v) { regId(CK_LT, v); }
        public void SetId_GreaterEqual(long? v) { regId(CK_GE, v); }
        public void SetId_LessEqual(long? v) { regId(CK_LE, v); }
        public void SetId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueId(), "id"); }
        public void SetId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueId(), "id"); }
        public void ExistsDchその他実績台帳List(SubQuery<Dchその他実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dchその他実績台帳CB>", subQuery);
            Dchその他実績台帳CB cb = new Dchその他実績台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_ExistsSubQuery_Dchその他実績台帳List(cb.Query());
            registerExistsSubQuery(cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName);
        }
        public abstract String keepId_ExistsSubQuery_Dchその他実績台帳List(Dchその他実績台帳CQ subQuery);
        public void ExistsDch宿泊実績台帳List(SubQuery<Dch宿泊実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch宿泊実績台帳CB>", subQuery);
            Dch宿泊実績台帳CB cb = new Dch宿泊実績台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_ExistsSubQuery_Dch宿泊実績台帳List(cb.Query());
            registerExistsSubQuery(cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName);
        }
        public abstract String keepId_ExistsSubQuery_Dch宿泊実績台帳List(Dch宿泊実績台帳CQ subQuery);
        public void ExistsDch清掃実績台帳List(SubQuery<Dch清掃実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch清掃実績台帳CB>", subQuery);
            Dch清掃実績台帳CB cb = new Dch清掃実績台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_ExistsSubQuery_Dch清掃実績台帳List(cb.Query());
            registerExistsSubQuery(cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName);
        }
        public abstract String keepId_ExistsSubQuery_Dch清掃実績台帳List(Dch清掃実績台帳CQ subQuery);
        public void NotExistsDchその他実績台帳List(SubQuery<Dchその他実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dchその他実績台帳CB>", subQuery);
            Dchその他実績台帳CB cb = new Dchその他実績台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_NotExistsSubQuery_Dchその他実績台帳List(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName);
        }
        public abstract String keepId_NotExistsSubQuery_Dchその他実績台帳List(Dchその他実績台帳CQ subQuery);
        public void NotExistsDch宿泊実績台帳List(SubQuery<Dch宿泊実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch宿泊実績台帳CB>", subQuery);
            Dch宿泊実績台帳CB cb = new Dch宿泊実績台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_NotExistsSubQuery_Dch宿泊実績台帳List(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName);
        }
        public abstract String keepId_NotExistsSubQuery_Dch宿泊実績台帳List(Dch宿泊実績台帳CQ subQuery);
        public void NotExistsDch清掃実績台帳List(SubQuery<Dch清掃実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch清掃実績台帳CB>", subQuery);
            Dch清掃実績台帳CB cb = new Dch清掃実績台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_NotExistsSubQuery_Dch清掃実績台帳List(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName);
        }
        public abstract String keepId_NotExistsSubQuery_Dch清掃実績台帳List(Dch清掃実績台帳CQ subQuery);
        public void InScopeDchその他実績台帳List(SubQuery<Dchその他実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dchその他実績台帳CB>", subQuery);
            Dchその他実績台帳CB cb = new Dchその他実績台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_InScopeSubQuery_Dchその他実績台帳List(cb.Query());
            registerInScopeSubQuery(cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName);
        }
        public abstract String keepId_InScopeSubQuery_Dchその他実績台帳List(Dchその他実績台帳CQ subQuery);
        public void InScopeDch宿泊実績台帳List(SubQuery<Dch宿泊実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch宿泊実績台帳CB>", subQuery);
            Dch宿泊実績台帳CB cb = new Dch宿泊実績台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_InScopeSubQuery_Dch宿泊実績台帳List(cb.Query());
            registerInScopeSubQuery(cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName);
        }
        public abstract String keepId_InScopeSubQuery_Dch宿泊実績台帳List(Dch宿泊実績台帳CQ subQuery);
        public void InScopeDch清掃実績台帳List(SubQuery<Dch清掃実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch清掃実績台帳CB>", subQuery);
            Dch清掃実績台帳CB cb = new Dch清掃実績台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_InScopeSubQuery_Dch清掃実績台帳List(cb.Query());
            registerInScopeSubQuery(cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName);
        }
        public abstract String keepId_InScopeSubQuery_Dch清掃実績台帳List(Dch清掃実績台帳CQ subQuery);
        public void NotInScopeDchその他実績台帳List(SubQuery<Dchその他実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dchその他実績台帳CB>", subQuery);
            Dchその他実績台帳CB cb = new Dchその他実績台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_NotInScopeSubQuery_Dchその他実績台帳List(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName);
        }
        public abstract String keepId_NotInScopeSubQuery_Dchその他実績台帳List(Dchその他実績台帳CQ subQuery);
        public void NotInScopeDch宿泊実績台帳List(SubQuery<Dch宿泊実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch宿泊実績台帳CB>", subQuery);
            Dch宿泊実績台帳CB cb = new Dch宿泊実績台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_NotInScopeSubQuery_Dch宿泊実績台帳List(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName);
        }
        public abstract String keepId_NotInScopeSubQuery_Dch宿泊実績台帳List(Dch宿泊実績台帳CQ subQuery);
        public void NotInScopeDch清掃実績台帳List(SubQuery<Dch清掃実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch清掃実績台帳CB>", subQuery);
            Dch清掃実績台帳CB cb = new Dch清掃実績台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_NotInScopeSubQuery_Dch清掃実績台帳List(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName);
        }
        public abstract String keepId_NotInScopeSubQuery_Dch清掃実績台帳List(Dch清掃実績台帳CQ subQuery);
        public void xsderiveDchその他実績台帳List(String function, SubQuery<Dchその他実績台帳CB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Dchその他実績台帳CB>", subQuery);
            Dchその他実績台帳CB cb = new Dchその他実績台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_SpecifyDerivedReferrer_Dchその他実績台帳List(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName, aliasName);
        }
        abstract public String keepId_SpecifyDerivedReferrer_Dchその他実績台帳List(Dchその他実績台帳CQ subQuery);
        public void xsderiveDch宿泊実績台帳List(String function, SubQuery<Dch宿泊実績台帳CB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Dch宿泊実績台帳CB>", subQuery);
            Dch宿泊実績台帳CB cb = new Dch宿泊実績台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_SpecifyDerivedReferrer_Dch宿泊実績台帳List(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName, aliasName);
        }
        abstract public String keepId_SpecifyDerivedReferrer_Dch宿泊実績台帳List(Dch宿泊実績台帳CQ subQuery);
        public void xsderiveDch清掃実績台帳List(String function, SubQuery<Dch清掃実績台帳CB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Dch清掃実績台帳CB>", subQuery);
            Dch清掃実績台帳CB cb = new Dch清掃実績台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_SpecifyDerivedReferrer_Dch清掃実績台帳List(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName, aliasName);
        }
        abstract public String keepId_SpecifyDerivedReferrer_Dch清掃実績台帳List(Dch清掃実績台帳CQ subQuery);

        public QDRFunction<Dchその他実績台帳CB> DerivedDchその他実績台帳List() {
            return xcreateQDRFunctionDchその他実績台帳List();
        }
        protected QDRFunction<Dchその他実績台帳CB> xcreateQDRFunctionDchその他実績台帳List() {
            return new QDRFunction<Dchその他実績台帳CB>(delegate(String function, SubQuery<Dchその他実績台帳CB> subQuery, String operand, Object value) {
                xqderiveDchその他実績台帳List(function, subQuery, operand, value);
            });
        }
        public void xqderiveDchその他実績台帳List(String function, SubQuery<Dchその他実績台帳CB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<Dchその他実績台帳CB>", subQuery);
            Dchその他実績台帳CB cb = new Dchその他実績台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_QueryDerivedReferrer_Dchその他実績台帳List(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepId_QueryDerivedReferrer_Dchその他実績台帳ListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepId_QueryDerivedReferrer_Dchその他実績台帳List(Dchその他実績台帳CQ subQuery);
        public abstract String keepId_QueryDerivedReferrer_Dchその他実績台帳ListParameter(Object parameterValue);

        public QDRFunction<Dch宿泊実績台帳CB> DerivedDch宿泊実績台帳List() {
            return xcreateQDRFunctionDch宿泊実績台帳List();
        }
        protected QDRFunction<Dch宿泊実績台帳CB> xcreateQDRFunctionDch宿泊実績台帳List() {
            return new QDRFunction<Dch宿泊実績台帳CB>(delegate(String function, SubQuery<Dch宿泊実績台帳CB> subQuery, String operand, Object value) {
                xqderiveDch宿泊実績台帳List(function, subQuery, operand, value);
            });
        }
        public void xqderiveDch宿泊実績台帳List(String function, SubQuery<Dch宿泊実績台帳CB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<Dch宿泊実績台帳CB>", subQuery);
            Dch宿泊実績台帳CB cb = new Dch宿泊実績台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_QueryDerivedReferrer_Dch宿泊実績台帳List(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepId_QueryDerivedReferrer_Dch宿泊実績台帳ListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepId_QueryDerivedReferrer_Dch宿泊実績台帳List(Dch宿泊実績台帳CQ subQuery);
        public abstract String keepId_QueryDerivedReferrer_Dch宿泊実績台帳ListParameter(Object parameterValue);

        public QDRFunction<Dch清掃実績台帳CB> DerivedDch清掃実績台帳List() {
            return xcreateQDRFunctionDch清掃実績台帳List();
        }
        protected QDRFunction<Dch清掃実績台帳CB> xcreateQDRFunctionDch清掃実績台帳List() {
            return new QDRFunction<Dch清掃実績台帳CB>(delegate(String function, SubQuery<Dch清掃実績台帳CB> subQuery, String operand, Object value) {
                xqderiveDch清掃実績台帳List(function, subQuery, operand, value);
            });
        }
        public void xqderiveDch清掃実績台帳List(String function, SubQuery<Dch清掃実績台帳CB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<Dch清掃実績台帳CB>", subQuery);
            Dch清掃実績台帳CB cb = new Dch清掃実績台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepId_QueryDerivedReferrer_Dch清掃実績台帳List(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepId_QueryDerivedReferrer_Dch清掃実績台帳ListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "id", "客室利用実績台帳id", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepId_QueryDerivedReferrer_Dch清掃実績台帳List(Dch清掃実績台帳CQ subQuery);
        public abstract String keepId_QueryDerivedReferrer_Dch清掃実績台帳ListParameter(Object parameterValue);
        public void SetId_IsNull() { regId(CK_ISN, DUMMY_OBJECT); }
        public void SetId_IsNotNull() { regId(CK_ISNN, DUMMY_OBJECT); }
        protected void regId(ConditionKey k, Object v) { regQ(k, v, getCValueId(), "id"); }
        protected abstract ConditionValue getCValueId();

        public void Set客室マスタid_Equal(long? v) { reg客室マスタid(CK_EQ, v); }
        public void Set客室マスタid_NotEqual(long? v) { reg客室マスタid(CK_NES, v); }
        public void Set客室マスタid_GreaterThan(long? v) { reg客室マスタid(CK_GT, v); }
        public void Set客室マスタid_LessThan(long? v) { reg客室マスタid(CK_LT, v); }
        public void Set客室マスタid_GreaterEqual(long? v) { reg客室マスタid(CK_GE, v); }
        public void Set客室マスタid_LessEqual(long? v) { reg客室マスタid(CK_LE, v); }
        public void Set客室マスタid_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValue客室マスタid(), "客室マスタid"); }
        public void Set客室マスタid_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValue客室マスタid(), "客室マスタid"); }
        public void InScopeMst客室マスタ(SubQuery<Mst客室マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst客室マスタCB>", subQuery);
            Mst客室マスタCB cb = new Mst客室マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室マスタid_InScopeSubQuery_Mst客室マスタ(cb.Query());
            registerInScopeSubQuery(cb.Query(), "客室マスタid", "id", subQueryPropertyName);
        }
        public abstract String keep客室マスタid_InScopeSubQuery_Mst客室マスタ(Mst客室マスタCQ subQuery);
        public void NotInScopeMst客室マスタ(SubQuery<Mst客室マスタCB> subQuery) {
            assertObjectNotNull("subQuery<Mst客室マスタCB>", subQuery);
            Mst客室マスタCB cb = new Mst客室マスタCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室マスタid_NotInScopeSubQuery_Mst客室マスタ(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "客室マスタid", "id", subQueryPropertyName);
        }
        public abstract String keep客室マスタid_NotInScopeSubQuery_Mst客室マスタ(Mst客室マスタCQ subQuery);
        protected void reg客室マスタid(ConditionKey k, Object v) { regQ(k, v, getCValue客室マスタid(), "客室マスタid"); }
        protected abstract ConditionValue getCValue客室マスタid();

        public void Set客室利用コード_Equal(String v) { DoSet客室利用コード_Equal(fRES(v)); }
        /// <summary>
        /// Set the value of 宿泊 of 客室利用コード as equal. { = }
        /// 宿泊
        /// </summary>
        public void Set客室利用コード_Equal_宿泊() {
            DoSet客室利用コード_Equal(CDef.客室利用区分.宿泊.Code);
        }
        /// <summary>
        /// Set the value of 清掃 of 客室利用コード as equal. { = }
        /// 清掃
        /// </summary>
        public void Set客室利用コード_Equal_清掃() {
            DoSet客室利用コード_Equal(CDef.客室利用区分.清掃.Code);
        }
        /// <summary>
        /// Set the value of その他 of 客室利用コード as equal. { = }
        /// その他
        /// </summary>
        public void Set客室利用コード_Equal_その他() {
            DoSet客室利用コード_Equal(CDef.客室利用区分.その他.Code);
        }
        protected void DoSet客室利用コード_Equal(String v) { reg客室利用コード(CK_EQ, v); }
        public void Set客室利用コード_NotEqual(String v) { DoSet客室利用コード_NotEqual(fRES(v)); }
        /// <summary>
        /// Set the value of 宿泊 of 客室利用コード as notEqual. { &lt;&gt; }
        /// 宿泊
        /// </summary>
        public void Set客室利用コード_NotEqual_宿泊() {
            DoSet客室利用コード_NotEqual(CDef.客室利用区分.宿泊.Code);
        }
        /// <summary>
        /// Set the value of 清掃 of 客室利用コード as notEqual. { &lt;&gt; }
        /// 清掃
        /// </summary>
        public void Set客室利用コード_NotEqual_清掃() {
            DoSet客室利用コード_NotEqual(CDef.客室利用区分.清掃.Code);
        }
        /// <summary>
        /// Set the value of その他 of 客室利用コード as notEqual. { &lt;&gt; }
        /// その他
        /// </summary>
        public void Set客室利用コード_NotEqual_その他() {
            DoSet客室利用コード_NotEqual(CDef.客室利用区分.その他.Code);
        }
        protected void DoSet客室利用コード_NotEqual(String v) { reg客室利用コード(CK_NES, v); }
        public void Set客室利用コード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValue客室利用コード(), "客室利用コード"); }
        public void Set客室利用コード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValue客室利用コード(), "客室利用コード"); }
        public void InScopeKbn客室利用区分(SubQuery<Kbn客室利用区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbn客室利用区分CB>", subQuery);
            Kbn客室利用区分CB cb = new Kbn客室利用区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室利用コード_InScopeSubQuery_Kbn客室利用区分(cb.Query());
            registerInScopeSubQuery(cb.Query(), "客室利用コード", "コード", subQueryPropertyName);
        }
        public abstract String keep客室利用コード_InScopeSubQuery_Kbn客室利用区分(Kbn客室利用区分CQ subQuery);
        public void NotInScopeKbn客室利用区分(SubQuery<Kbn客室利用区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbn客室利用区分CB>", subQuery);
            Kbn客室利用区分CB cb = new Kbn客室利用区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keep客室利用コード_NotInScopeSubQuery_Kbn客室利用区分(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "客室利用コード", "コード", subQueryPropertyName);
        }
        public abstract String keep客室利用コード_NotInScopeSubQuery_Kbn客室利用区分(Kbn客室利用区分CQ subQuery);
        protected void reg客室利用コード(ConditionKey k, Object v) { regQ(k, v, getCValue客室利用コード(), "客室利用コード"); }
        protected abstract ConditionValue getCValue客室利用コード();

        public void Set利用開始日時_Equal(DateTime? v) { reg利用開始日時(CK_EQ, v); }
        public void Set利用開始日時_GreaterThan(DateTime? v) { reg利用開始日時(CK_GT, v); }
        public void Set利用開始日時_LessThan(DateTime? v) { reg利用開始日時(CK_LT, v); }
        public void Set利用開始日時_GreaterEqual(DateTime? v) { reg利用開始日時(CK_GE, v); }
        public void Set利用開始日時_LessEqual(DateTime? v) { reg利用開始日時(CK_LE, v); }
        public void Set利用開始日時_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValue利用開始日時(), "利用開始日時", option); }
        public void Set利用開始日時_DateFromTo(DateTime? from, DateTime? to) { Set利用開始日時_FromTo(from, to, new DateFromToOption()); }
        protected void reg利用開始日時(ConditionKey k, Object v) { regQ(k, v, getCValue利用開始日時(), "利用開始日時"); }
        protected abstract ConditionValue getCValue利用開始日時();

        public void Set利用終了日時_Equal(DateTime? v) { reg利用終了日時(CK_EQ, v); }
        public void Set利用終了日時_GreaterThan(DateTime? v) { reg利用終了日時(CK_GT, v); }
        public void Set利用終了日時_LessThan(DateTime? v) { reg利用終了日時(CK_LT, v); }
        public void Set利用終了日時_GreaterEqual(DateTime? v) { reg利用終了日時(CK_GE, v); }
        public void Set利用終了日時_LessEqual(DateTime? v) { reg利用終了日時(CK_LE, v); }
        public void Set利用終了日時_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValue利用終了日時(), "利用終了日時", option); }
        public void Set利用終了日時_DateFromTo(DateTime? from, DateTime? to) { Set利用終了日時_FromTo(from, to, new DateFromToOption()); }
        protected void reg利用終了日時(ConditionKey k, Object v) { regQ(k, v, getCValue利用終了日時(), "利用終了日時"); }
        protected abstract ConditionValue getCValue利用終了日時();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<Dch客室利用実績台帳CB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Dch客室利用実績台帳CB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Dch客室利用実績台帳CB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Dch客室利用実績台帳CB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Dch客室利用実績台帳CB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Dch客室利用実績台帳CB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Dch客室利用実績台帳CB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Dch客室利用実績台帳CB>(delegate(String function, SubQuery<Dch客室利用実績台帳CB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Dch客室利用実績台帳CB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Dch客室利用実績台帳CB>", subQuery);
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Dch客室利用実績台帳CQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Dch客室利用実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用実績台帳CB>", subQuery);
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "id", "id", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Dch客室利用実績台帳CQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
