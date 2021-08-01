
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
    public class Dch宿泊利用台帳CIQ : AbstractBsDch宿泊利用台帳CQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsDch宿泊利用台帳CQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Dch宿泊利用台帳CIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsDch宿泊利用台帳CQ myCQ)
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


        protected override ConditionValue getCValue客室利用台帳id() {
            return _myCQ.客室利用台帳id;
        }


        public override String keep客室利用台帳id_InScopeSubQuery_Dch客室利用台帳(Dch客室利用台帳CQ subQuery) {
            return _myCQ.keep客室利用台帳id_InScopeSubQuery_Dch客室利用台帳(subQuery);
        }

        public override String keep客室利用台帳id_NotInScopeSubQuery_Dch客室利用台帳(Dch客室利用台帳CQ subQuery) {
            return _myCQ.keep客室利用台帳id_NotInScopeSubQuery_Dch客室利用台帳(subQuery);
        }

        protected override ConditionValue getCValue会員コード() {
            return _myCQ.会員コード;
        }


        public override String keep会員コード_InScopeSubQuery_Mst会員マスタ(Mst会員マスタCQ subQuery) {
            return _myCQ.keep会員コード_InScopeSubQuery_Mst会員マスタ(subQuery);
        }

        public override String keep会員コード_NotInScopeSubQuery_Mst会員マスタ(Mst会員マスタCQ subQuery) {
            return _myCQ.keep会員コード_NotInScopeSubQuery_Mst会員マスタ(subQuery);
        }

        protected override ConditionValue getCValue宿泊料金() {
            return _myCQ.宿泊料金;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(Dch宿泊利用台帳CQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(Dch宿泊利用台帳CQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
