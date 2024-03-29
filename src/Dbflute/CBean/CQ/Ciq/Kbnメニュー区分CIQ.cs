
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
    public class Kbnメニュー区分CIQ : AbstractBsKbnメニュー区分CQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsKbnメニュー区分CQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Kbnメニュー区分CIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsKbnメニュー区分CQ myCQ)
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


        protected override ConditionValue getCValueメニューコード() {
            return _myCQ.メニューコード;
        }


        public override String keepメニューコード_ExistsSubQuery_Mst画面マスタList(Mst画面マスタCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepメニューコード_ExistsSubQuery_Mst画面マスタList(subQuery);
        }

        public override String keepメニューコード_NotExistsSubQuery_Mst画面マスタList(Mst画面マスタCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepメニューコード_NotExistsSubQuery_Mst画面マスタList(subQuery);
        }

        public override String keepメニューコード_InScopeSubQuery_Mst画面マスタList(Mst画面マスタCQ subQuery) {
            return _myCQ.keepメニューコード_InScopeSubQuery_Mst画面マスタList(subQuery);
        }

        public override String keepメニューコード_NotInScopeSubQuery_Mst画面マスタList(Mst画面マスタCQ subQuery) {
            return _myCQ.keepメニューコード_NotInScopeSubQuery_Mst画面マスタList(subQuery);
        }
        public override String keepメニューコード_SpecifyDerivedReferrer_Mst画面マスタList(Mst画面マスタCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepメニューコード_QueryDerivedReferrer_Mst画面マスタList(Mst画面マスタCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepメニューコード_QueryDerivedReferrer_Mst画面マスタListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValueメニュー名称() {
            return _myCQ.メニュー名称;
        }


        protected override ConditionValue getCValue優先順位() {
            return _myCQ.優先順位;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(Kbnメニュー区分CQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(Kbnメニュー区分CQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
