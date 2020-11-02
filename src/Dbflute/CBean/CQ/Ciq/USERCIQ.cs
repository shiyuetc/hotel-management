
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
    public class USERCIQ : AbstractBsUSERCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsUSERCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public USERCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsUSERCQ myCQ)
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


        protected override ConditionValue getCValueID() {
            return _myCQ.ID;
        }


        protected override ConditionValue getCValueNAME() {
            return _myCQ.NAME;
        }


        protected override ConditionValue getCValueUPDATE_DATETIME() {
            return _myCQ.UPDATE_DATETIME;
        }


        protected override ConditionValue getCValueUPDATE_USER() {
            return _myCQ.UPDATE_USER;
        }


        protected override ConditionValue getCValueVERSION_NO() {
            return _myCQ.VERSION_NO;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(USERCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(USERCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
