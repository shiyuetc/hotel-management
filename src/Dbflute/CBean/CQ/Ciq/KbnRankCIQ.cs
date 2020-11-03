
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
    public class KbnRankCIQ : AbstractBsKbnRankCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsKbnRankCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public KbnRankCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsKbnRankCQ myCQ)
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


        protected override ConditionValue getCValueCode() {
            return _myCQ.Code;
        }


        public override String keepCode_ExistsSubQuery_MstEmployeeList(MstEmployeeCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepCode_ExistsSubQuery_MstEmployeeList(subQuery);
        }

        public override String keepCode_NotExistsSubQuery_MstEmployeeList(MstEmployeeCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepCode_NotExistsSubQuery_MstEmployeeList(subQuery);
        }

        public override String keepCode_InScopeSubQuery_MstEmployeeList(MstEmployeeCQ subQuery) {
            return _myCQ.keepCode_InScopeSubQuery_MstEmployeeList(subQuery);
        }

        public override String keepCode_NotInScopeSubQuery_MstEmployeeList(MstEmployeeCQ subQuery) {
            return _myCQ.keepCode_NotInScopeSubQuery_MstEmployeeList(subQuery);
        }
        public override String keepCode_SpecifyDerivedReferrer_MstEmployeeList(MstEmployeeCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepCode_QueryDerivedReferrer_MstEmployeeList(MstEmployeeCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepCode_QueryDerivedReferrer_MstEmployeeListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValueEnglishName() {
            return _myCQ.EnglishName;
        }


        protected override ConditionValue getCValueJapaneseName() {
            return _myCQ.JapaneseName;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(KbnRankCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(KbnRankCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
