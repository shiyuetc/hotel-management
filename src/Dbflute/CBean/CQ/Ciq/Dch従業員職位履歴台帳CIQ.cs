
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
    public class Dch従業員職位履歴台帳CIQ : AbstractBsDch従業員職位履歴台帳CQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsDch従業員職位履歴台帳CQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Dch従業員職位履歴台帳CIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsDch従業員職位履歴台帳CQ myCQ)
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


        protected override ConditionValue getCValue従業員コード() {
            return _myCQ.従業員コード;
        }


        public override String keep従業員コード_InScopeSubQuery_Mst従業員マスタ(Mst従業員マスタCQ subQuery) {
            return _myCQ.keep従業員コード_InScopeSubQuery_Mst従業員マスタ(subQuery);
        }

        public override String keep従業員コード_NotInScopeSubQuery_Mst従業員マスタ(Mst従業員マスタCQ subQuery) {
            return _myCQ.keep従業員コード_NotInScopeSubQuery_Mst従業員マスタ(subQuery);
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

        protected override ConditionValue getCValue適用開始日() {
            return _myCQ.適用開始日;
        }


        protected override ConditionValue getCValue適用終了日() {
            return _myCQ.適用終了日;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(Dch従業員職位履歴台帳CQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(Dch従業員職位履歴台帳CQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
