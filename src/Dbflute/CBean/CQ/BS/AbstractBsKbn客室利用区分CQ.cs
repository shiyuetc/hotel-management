
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
    public abstract class AbstractBsKbn客室利用区分CQ : AbstractConditionQuery {

        public AbstractBsKbn客室利用区分CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "kbn客室利用区分"; }
        public override String getTableSqlName() { return "kbn客室利用区分"; }

        public void Setコード_Equal(String v) { DoSetコード_Equal(fRES(v)); }
        /// <summary>
        /// Set the value of 宿泊 of コード as equal. { = }
        /// 宿泊
        /// </summary>
        public void Setコード_Equal_宿泊() {
            DoSetコード_Equal(CDef.客室利用区分.宿泊.Code);
        }
        /// <summary>
        /// Set the value of 清掃 of コード as equal. { = }
        /// 清掃
        /// </summary>
        public void Setコード_Equal_清掃() {
            DoSetコード_Equal(CDef.客室利用区分.清掃.Code);
        }
        /// <summary>
        /// Set the value of その他 of コード as equal. { = }
        /// その他
        /// </summary>
        public void Setコード_Equal_その他() {
            DoSetコード_Equal(CDef.客室利用区分.その他.Code);
        }
        protected void DoSetコード_Equal(String v) { regコード(CK_EQ, v); }
        public void Setコード_NotEqual(String v) { DoSetコード_NotEqual(fRES(v)); }
        /// <summary>
        /// Set the value of 宿泊 of コード as notEqual. { &lt;&gt; }
        /// 宿泊
        /// </summary>
        public void Setコード_NotEqual_宿泊() {
            DoSetコード_NotEqual(CDef.客室利用区分.宿泊.Code);
        }
        /// <summary>
        /// Set the value of 清掃 of コード as notEqual. { &lt;&gt; }
        /// 清掃
        /// </summary>
        public void Setコード_NotEqual_清掃() {
            DoSetコード_NotEqual(CDef.客室利用区分.清掃.Code);
        }
        /// <summary>
        /// Set the value of その他 of コード as notEqual. { &lt;&gt; }
        /// その他
        /// </summary>
        public void Setコード_NotEqual_その他() {
            DoSetコード_NotEqual(CDef.客室利用区分.その他.Code);
        }
        protected void DoSetコード_NotEqual(String v) { regコード(CK_NES, v); }
        public void Setコード_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueコード(), "コード"); }
        public void Setコード_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueコード(), "コード"); }
        public void ExistsDch客室利用予定台帳List(SubQuery<Dch客室利用予定台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用予定台帳CB>", subQuery);
            Dch客室利用予定台帳CB cb = new Dch客室利用予定台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_ExistsSubQuery_Dch客室利用予定台帳List(cb.Query());
            registerExistsSubQuery(cb.Query(), "コード", "客室利用コード", subQueryPropertyName);
        }
        public abstract String keepコード_ExistsSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery);
        public void ExistsDch客室利用実績台帳List(SubQuery<Dch客室利用実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用実績台帳CB>", subQuery);
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_ExistsSubQuery_Dch客室利用実績台帳List(cb.Query());
            registerExistsSubQuery(cb.Query(), "コード", "客室利用コード", subQueryPropertyName);
        }
        public abstract String keepコード_ExistsSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery);
        public void NotExistsDch客室利用予定台帳List(SubQuery<Dch客室利用予定台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用予定台帳CB>", subQuery);
            Dch客室利用予定台帳CB cb = new Dch客室利用予定台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_NotExistsSubQuery_Dch客室利用予定台帳List(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "コード", "客室利用コード", subQueryPropertyName);
        }
        public abstract String keepコード_NotExistsSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery);
        public void NotExistsDch客室利用実績台帳List(SubQuery<Dch客室利用実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用実績台帳CB>", subQuery);
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_NotExistsSubQuery_Dch客室利用実績台帳List(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "コード", "客室利用コード", subQueryPropertyName);
        }
        public abstract String keepコード_NotExistsSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery);
        public void InScopeDch客室利用予定台帳List(SubQuery<Dch客室利用予定台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用予定台帳CB>", subQuery);
            Dch客室利用予定台帳CB cb = new Dch客室利用予定台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_InScopeSubQuery_Dch客室利用予定台帳List(cb.Query());
            registerInScopeSubQuery(cb.Query(), "コード", "客室利用コード", subQueryPropertyName);
        }
        public abstract String keepコード_InScopeSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery);
        public void InScopeDch客室利用実績台帳List(SubQuery<Dch客室利用実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用実績台帳CB>", subQuery);
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_InScopeSubQuery_Dch客室利用実績台帳List(cb.Query());
            registerInScopeSubQuery(cb.Query(), "コード", "客室利用コード", subQueryPropertyName);
        }
        public abstract String keepコード_InScopeSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery);
        public void NotInScopeDch客室利用予定台帳List(SubQuery<Dch客室利用予定台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用予定台帳CB>", subQuery);
            Dch客室利用予定台帳CB cb = new Dch客室利用予定台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_NotInScopeSubQuery_Dch客室利用予定台帳List(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "コード", "客室利用コード", subQueryPropertyName);
        }
        public abstract String keepコード_NotInScopeSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery);
        public void NotInScopeDch客室利用実績台帳List(SubQuery<Dch客室利用実績台帳CB> subQuery) {
            assertObjectNotNull("subQuery<Dch客室利用実績台帳CB>", subQuery);
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_NotInScopeSubQuery_Dch客室利用実績台帳List(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "コード", "客室利用コード", subQueryPropertyName);
        }
        public abstract String keepコード_NotInScopeSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery);
        public void xsderiveDch客室利用予定台帳List(String function, SubQuery<Dch客室利用予定台帳CB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Dch客室利用予定台帳CB>", subQuery);
            Dch客室利用予定台帳CB cb = new Dch客室利用予定台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_SpecifyDerivedReferrer_Dch客室利用予定台帳List(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "コード", "客室利用コード", subQueryPropertyName, aliasName);
        }
        abstract public String keepコード_SpecifyDerivedReferrer_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery);
        public void xsderiveDch客室利用実績台帳List(String function, SubQuery<Dch客室利用実績台帳CB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<Dch客室利用実績台帳CB>", subQuery);
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepコード_SpecifyDerivedReferrer_Dch客室利用実績台帳List(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "コード", "客室利用コード", subQueryPropertyName, aliasName);
        }
        abstract public String keepコード_SpecifyDerivedReferrer_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery);

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
            String subQueryPropertyName = keepコード_QueryDerivedReferrer_Dch客室利用予定台帳List(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepコード_QueryDerivedReferrer_Dch客室利用予定台帳ListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "コード", "客室利用コード", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepコード_QueryDerivedReferrer_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery);
        public abstract String keepコード_QueryDerivedReferrer_Dch客室利用予定台帳ListParameter(Object parameterValue);

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
            String subQueryPropertyName = keepコード_QueryDerivedReferrer_Dch客室利用実績台帳List(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepコード_QueryDerivedReferrer_Dch客室利用実績台帳ListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "コード", "客室利用コード", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepコード_QueryDerivedReferrer_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery);
        public abstract String keepコード_QueryDerivedReferrer_Dch客室利用実績台帳ListParameter(Object parameterValue);
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
        public SSQFunction<Kbn客室利用区分CB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<Kbn客室利用区分CB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<Kbn客室利用区分CB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<Kbn客室利用区分CB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<Kbn客室利用区分CB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<Kbn客室利用区分CB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<Kbn客室利用区分CB> xcreateSSQFunction(String operand) {
            return new SSQFunction<Kbn客室利用区分CB>(delegate(String function, SubQuery<Kbn客室利用区分CB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<Kbn客室利用区分CB> subQuery, String operand) {
            assertObjectNotNull("subQuery<Kbn客室利用区分CB>", subQuery);
            Kbn客室利用区分CB cb = new Kbn客室利用区分CB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(Kbn客室利用区分CQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<Kbn客室利用区分CB> subQuery) {
            assertObjectNotNull("subQuery<Kbn客室利用区分CB>", subQuery);
            Kbn客室利用区分CB cb = new Kbn客室利用区分CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "コード", "コード", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(Kbn客室利用区分CQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
