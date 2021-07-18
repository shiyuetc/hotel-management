
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
    public class Mst権限マスタCIQ : AbstractBsMst権限マスタCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsMst権限マスタCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mst権限マスタCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsMst権限マスタCQ myCQ)
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


        protected override ConditionValue getCValue職位コード() {
            return _myCQ.職位コード;
        }


        public override String keep職位コード_InScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery) {
            return _myCQ.keep職位コード_InScopeSubQuery_Kbn職位区分(subQuery);
        }

        public override String keep職位コード_NotInScopeSubQuery_Kbn職位区分(Kbn職位区分CQ subQuery) {
            return _myCQ.keep職位コード_NotInScopeSubQuery_Kbn職位区分(subQuery);
        }

        protected override ConditionValue getCValue権限コード() {
            return _myCQ.権限コード;
        }


        public override String keep権限コード_InScopeSubQuery_Kbn権限区分(Kbn権限区分CQ subQuery) {
            return _myCQ.keep権限コード_InScopeSubQuery_Kbn権限区分(subQuery);
        }

        public override String keep権限コード_NotInScopeSubQuery_Kbn権限区分(Kbn権限区分CQ subQuery) {
            return _myCQ.keep権限コード_NotInScopeSubQuery_Kbn権限区分(subQuery);
        }

        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(Mst権限マスタCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(Mst権限マスタCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
