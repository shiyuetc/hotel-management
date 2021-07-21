
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
    public class Mstメニュー権限マスタCIQ : AbstractBsMstメニュー権限マスタCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsMstメニュー権限マスタCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mstメニュー権限マスタCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsMstメニュー権限マスタCQ myCQ)
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


        protected override ConditionValue getCValue職位code() {
            return _myCQ.職位code;
        }


        public override String keep職位code_InScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery) {
            return _myCQ.keep職位code_InScopeSubQuery_Kbn職位区分(subQuery);
        }

        public override String keep職位code_NotInScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery) {
            return _myCQ.keep職位code_NotInScopeSubQuery_Kbn職位区分(subQuery);
        }

        protected override ConditionValue getCValue制御画面id() {
            return _myCQ.制御画面id;
        }


        public override String keep制御画面id_InScopeSubQuery_Mst制御画面マスタ(Mst制御画面マスタCQ subQuery) {
            return _myCQ.keep制御画面id_InScopeSubQuery_Mst制御画面マスタ(subQuery);
        }

        public override String keep制御画面id_NotInScopeSubQuery_Mst制御画面マスタ(Mst制御画面マスタCQ subQuery) {
            return _myCQ.keep制御画面id_NotInScopeSubQuery_Mst制御画面マスタ(subQuery);
        }

        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(Mstメニュー権限マスタCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(Mstメニュー権限マスタCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
