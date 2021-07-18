
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
    public class Mst客室タイプマスタCIQ : AbstractBsMst客室タイプマスタCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsMst客室タイプマスタCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mst客室タイプマスタCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsMst客室タイプマスタCQ myCQ)
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


        public override String keepId_ExistsSubQuery_Mst客室マスタList(Mst客室マスタCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepId_ExistsSubQuery_Mst客室マスタList(subQuery);
        }

        public override String keepId_NotExistsSubQuery_Mst客室マスタList(Mst客室マスタCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepId_NotExistsSubQuery_Mst客室マスタList(subQuery);
        }

        public override String keepId_InScopeSubQuery_Mst客室マスタList(Mst客室マスタCQ subQuery) {
            return _myCQ.keepId_InScopeSubQuery_Mst客室マスタList(subQuery);
        }

        public override String keepId_NotInScopeSubQuery_Mst客室マスタList(Mst客室マスタCQ subQuery) {
            return _myCQ.keepId_NotInScopeSubQuery_Mst客室マスタList(subQuery);
        }
        public override String keepId_SpecifyDerivedReferrer_Mst客室マスタList(Mst客室マスタCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepId_QueryDerivedReferrer_Mst客室マスタList(Mst客室マスタCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepId_QueryDerivedReferrer_Mst客室マスタListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValue名称() {
            return _myCQ.名称;
        }


        protected override ConditionValue getCValue料金() {
            return _myCQ.料金;
        }


        protected override ConditionValue getCValue宿泊人数() {
            return _myCQ.宿泊人数;
        }


        protected override ConditionValue getCValue備考() {
            return _myCQ.備考;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(Mst客室タイプマスタCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(Mst客室タイプマスタCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
