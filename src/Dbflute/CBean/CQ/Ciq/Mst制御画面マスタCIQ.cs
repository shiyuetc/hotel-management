
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
    public class Mst制御画面マスタCIQ : AbstractBsMst制御画面マスタCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsMst制御画面マスタCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mst制御画面マスタCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsMst制御画面マスタCQ myCQ)
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


        public override String keepId_ExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepId_ExistsSubQuery_Mst権限マスタList(subQuery);
        }

        public override String keepId_NotExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepId_NotExistsSubQuery_Mst権限マスタList(subQuery);
        }

        public override String keepId_InScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            return _myCQ.keepId_InScopeSubQuery_Mst権限マスタList(subQuery);
        }

        public override String keepId_NotInScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            return _myCQ.keepId_NotInScopeSubQuery_Mst権限マスタList(subQuery);
        }
        public override String keepId_SpecifyDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepId_QueryDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepId_QueryDerivedReferrer_Mst権限マスタListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValueメニューcode() {
            return _myCQ.メニューcode;
        }


        public override String keepメニューcode_InScopeSubQuery_Kbnメニュー区分(Kbnメニュー区分CQ subQuery) {
            return _myCQ.keepメニューcode_InScopeSubQuery_Kbnメニュー区分(subQuery);
        }

        public override String keepメニューcode_NotInScopeSubQuery_Kbnメニュー区分(Kbnメニュー区分CQ subQuery) {
            return _myCQ.keepメニューcode_NotInScopeSubQuery_Kbnメニュー区分(subQuery);
        }

        protected override ConditionValue getCValue画面名() {
            return _myCQ.画面名;
        }


        protected override ConditionValue getCValue表示名() {
            return _myCQ.表示名;
        }


        protected override ConditionValue getCValue優先順位() {
            return _myCQ.優先順位;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(Mst制御画面マスタCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(Mst制御画面マスタCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
