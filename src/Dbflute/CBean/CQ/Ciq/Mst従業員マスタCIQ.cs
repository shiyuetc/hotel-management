
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CKey;
using Dbflute.AllCommon.CBean.COption;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ.BS;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.CQ.Ciq {

    [System.Serializable]
    public class Mst従業員マスタCIQ : AbstractBsMst従業員マスタCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsMst従業員マスタCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mst従業員マスタCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsMst従業員マスタCQ myCQ)
            : base(childQuery, sqlClause, aliasName, nestLevel) {
            _myCQ = myCQ;
            _foreignPropertyName = _myCQ.xgetForeignPropertyName();// Accept foreign property name.
            _relationPath = _myCQ.xgetRelationPath();// Accept relation path.
        }

        // ===================================================================================
        //                                                             Override about Register
        //                                                             =======================
        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            throw new UnsupportedOperationException("InlineQuery must not need UNION method: " + baseQueryAsSuper + " : " + unionQueryAsSuper);
        }
    
        protected override void setupConditionValueAndRegisterWhereClause(ConditionKey key, Object value, ConditionValue cvalue, String colName) {
            regIQ(key, value, cvalue, colName);
        }
    
        protected override void setupConditionValueAndRegisterWhereClause(ConditionKey key, Object value, ConditionValue cvalue
                                                                        , String colName, ConditionOption option) {
            regIQ(key, value, cvalue, colName, option);
        }
    
        protected override void registerWhereClause(String whereClause) {
            registerInlineWhereClause(whereClause);
        }
    
        protected override String getInScopeSubQueryRealColumnName(String columnName) {
            if (_onClause) {
                throw new UnsupportedOperationException("InScopeSubQuery of on-clause is unsupported");
            }
            return _onClause ? xgetAliasName() + "." + columnName : columnName;
        }
    
        protected override void registerExistsSubQuery(ConditionQuery subQuery
                                     , String columnName, String relatedColumnName, String propertyName) {
            throw new UnsupportedOperationException("Sorry! ExistsSubQuery at inline view is unsupported. So please use InScopeSubQyery.");
        }


        protected override ConditionValue getCValueId() {
            return _myCQ.Id;
        }


        public override String keepId_ExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepId_ExistsSubQuery_Dch従業員職位履歴台帳List(subQuery);
        }

        public override String keepId_NotExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepId_NotExistsSubQuery_Dch従業員職位履歴台帳List(subQuery);
        }

        public override String keepId_InScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            return _myCQ.keepId_InScopeSubQuery_Dch従業員職位履歴台帳List(subQuery);
        }

        public override String keepId_NotInScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            return _myCQ.keepId_NotInScopeSubQuery_Dch従業員職位履歴台帳List(subQuery);
        }
        public override String keepId_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepId_QueryDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepId_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValue従業員番号() {
            return _myCQ.従業員番号;
        }


        protected override ConditionValue getCValue氏名姓() {
            return _myCQ.氏名姓;
        }


        protected override ConditionValue getCValue氏名名() {
            return _myCQ.氏名名;
        }


        protected override ConditionValue getCValue氏名カナ() {
            return _myCQ.氏名カナ;
        }


        protected override ConditionValue getCValueメールアドレス() {
            return _myCQ.メールアドレス;
        }


        protected override ConditionValue getCValueパスワード() {
            return _myCQ.パスワード;
        }


        protected override ConditionValue getCValue生年月日() {
            return _myCQ.生年月日;
        }


        protected override ConditionValue getCValue入社年月日() {
            return _myCQ.入社年月日;
        }


        protected override ConditionValue getCValue退社年月日() {
            return _myCQ.退社年月日;
        }


        protected override ConditionValue getCValue職位コード() {
            return _myCQ.職位コード;
        }


        public override String keep職位コード_InScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery) {
            return _myCQ.keep職位コード_InScopeSubQuery_Kbn職位区分(subQuery);
        }

        public override String keep職位コード_NotInScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery) {
            return _myCQ.keep職位コード_NotInScopeSubQuery_Kbn職位区分(subQuery);
        }

        protected override ConditionValue getCValue最終ログイン日時() {
            return _myCQ.最終ログイン日時;
        }


        protected override ConditionValue getCValue備考() {
            return _myCQ.備考;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(Mst従業員マスタCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(Mst従業員マスタCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
