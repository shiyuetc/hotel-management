
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
    public class Mst会員マスタCIQ : AbstractBsMst会員マスタCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsMst会員マスタCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mst会員マスタCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsMst会員マスタCQ myCQ)
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


        protected override ConditionValue getCValue会員コード() {
            return _myCQ.会員コード;
        }


        public override String keep会員コード_ExistsSubQuery_Dch宿泊利用台帳List(Dch宿泊利用台帳CQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keep会員コード_ExistsSubQuery_Dch宿泊利用台帳List(subQuery);
        }

        public override String keep会員コード_NotExistsSubQuery_Dch宿泊利用台帳List(Dch宿泊利用台帳CQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keep会員コード_NotExistsSubQuery_Dch宿泊利用台帳List(subQuery);
        }

        public override String keep会員コード_InScopeSubQuery_Dch宿泊利用台帳List(Dch宿泊利用台帳CQ subQuery) {
            return _myCQ.keep会員コード_InScopeSubQuery_Dch宿泊利用台帳List(subQuery);
        }

        public override String keep会員コード_NotInScopeSubQuery_Dch宿泊利用台帳List(Dch宿泊利用台帳CQ subQuery) {
            return _myCQ.keep会員コード_NotInScopeSubQuery_Dch宿泊利用台帳List(subQuery);
        }
        public override String keep会員コード_SpecifyDerivedReferrer_Dch宿泊利用台帳List(Dch宿泊利用台帳CQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep会員コード_QueryDerivedReferrer_Dch宿泊利用台帳List(Dch宿泊利用台帳CQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep会員コード_QueryDerivedReferrer_Dch宿泊利用台帳ListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValue会員番号() {
            return _myCQ.会員番号;
        }


        protected override ConditionValue getCValue名字() {
            return _myCQ.名字;
        }


        protected override ConditionValue getCValue名前() {
            return _myCQ.名前;
        }


        protected override ConditionValue getCValue氏名カナ() {
            return _myCQ.氏名カナ;
        }


        protected override ConditionValue getCValue会社名() {
            return _myCQ.会社名;
        }


        protected override ConditionValue getCValue会社名カナ() {
            return _myCQ.会社名カナ;
        }


        protected override ConditionValue getCValue電話番号() {
            return _myCQ.電話番号;
        }


        protected override ConditionValue getCValueメールアドレス() {
            return _myCQ.メールアドレス;
        }


        protected override ConditionValue getCValue入会年月日() {
            return _myCQ.入会年月日;
        }


        protected override ConditionValue getCValue退会年月日() {
            return _myCQ.退会年月日;
        }


        protected override ConditionValue getCValue備考() {
            return _myCQ.備考;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(Mst会員マスタCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(Mst会員マスタCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
