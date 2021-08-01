
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
    public class Kbn客室利用区分CIQ : AbstractBsKbn客室利用区分CQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsKbn客室利用区分CQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Kbn客室利用区分CIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsKbn客室利用区分CQ myCQ)
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


        protected override ConditionValue getCValue客室利用コード() {
            return _myCQ.客室利用コード;
        }


        public override String keep客室利用コード_ExistsSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keep客室利用コード_ExistsSubQuery_Dch客室利用台帳List(subQuery);
        }

        public override String keep客室利用コード_NotExistsSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keep客室利用コード_NotExistsSubQuery_Dch客室利用台帳List(subQuery);
        }

        public override String keep客室利用コード_InScopeSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            return _myCQ.keep客室利用コード_InScopeSubQuery_Dch客室利用台帳List(subQuery);
        }

        public override String keep客室利用コード_NotInScopeSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            return _myCQ.keep客室利用コード_NotInScopeSubQuery_Dch客室利用台帳List(subQuery);
        }
        public override String keep客室利用コード_SpecifyDerivedReferrer_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep客室利用コード_QueryDerivedReferrer_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep客室利用コード_QueryDerivedReferrer_Dch客室利用台帳ListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValue客室利用名称() {
            return _myCQ.客室利用名称;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(Kbn客室利用区分CQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(Kbn客室利用区分CQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
