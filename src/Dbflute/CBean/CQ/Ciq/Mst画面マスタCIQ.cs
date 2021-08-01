
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
    public class Mst画面マスタCIQ : AbstractBsMst画面マスタCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsMst画面マスタCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mst画面マスタCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsMst画面マスタCQ myCQ)
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


        protected override ConditionValue getCValue画面コード() {
            return _myCQ.画面コード;
        }


        public override String keep画面コード_ExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keep画面コード_ExistsSubQuery_Mst権限マスタList(subQuery);
        }

        public override String keep画面コード_NotExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keep画面コード_NotExistsSubQuery_Mst権限マスタList(subQuery);
        }

        public override String keep画面コード_InScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            return _myCQ.keep画面コード_InScopeSubQuery_Mst権限マスタList(subQuery);
        }

        public override String keep画面コード_NotInScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            return _myCQ.keep画面コード_NotInScopeSubQuery_Mst権限マスタList(subQuery);
        }
        public override String keep画面コード_SpecifyDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep画面コード_QueryDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep画面コード_QueryDerivedReferrer_Mst権限マスタListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValueメニューコード() {
            return _myCQ.メニューコード;
        }


        public override String keepメニューコード_InScopeSubQuery_Kbnメニュー区分(Kbnメニュー区分CQ subQuery) {
            return _myCQ.keepメニューコード_InScopeSubQuery_Kbnメニュー区分(subQuery);
        }

        public override String keepメニューコード_NotInScopeSubQuery_Kbnメニュー区分(Kbnメニュー区分CQ subQuery) {
            return _myCQ.keepメニューコード_NotInScopeSubQuery_Kbnメニュー区分(subQuery);
        }

        protected override ConditionValue getCValue画面名称() {
            return _myCQ.画面名称;
        }


        protected override ConditionValue getCValue優先順位() {
            return _myCQ.優先順位;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(Mst画面マスタCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(Mst画面マスタCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
