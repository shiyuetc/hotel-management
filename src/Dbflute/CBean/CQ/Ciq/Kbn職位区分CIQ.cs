
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
    public class Kbn職位区分CIQ : AbstractBsKbn職位区分CQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsKbn職位区分CQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Kbn職位区分CIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsKbn職位区分CQ myCQ)
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


        protected override ConditionValue getCValue職位コード() {
            return _myCQ.職位コード;
        }


        public override String keep職位コード_ExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keep職位コード_ExistsSubQuery_Dch従業員職位履歴台帳List(subQuery);
        }

        public override String keep職位コード_ExistsSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keep職位コード_ExistsSubQuery_Mst従業員マスタList(subQuery);
        }

        public override String keep職位コード_ExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keep職位コード_ExistsSubQuery_Mst権限マスタList(subQuery);
        }

        public override String keep職位コード_NotExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keep職位コード_NotExistsSubQuery_Dch従業員職位履歴台帳List(subQuery);
        }

        public override String keep職位コード_NotExistsSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keep職位コード_NotExistsSubQuery_Mst従業員マスタList(subQuery);
        }

        public override String keep職位コード_NotExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keep職位コード_NotExistsSubQuery_Mst権限マスタList(subQuery);
        }

        public override String keep職位コード_InScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            return _myCQ.keep職位コード_InScopeSubQuery_Dch従業員職位履歴台帳List(subQuery);
        }

        public override String keep職位コード_InScopeSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            return _myCQ.keep職位コード_InScopeSubQuery_Mst従業員マスタList(subQuery);
        }

        public override String keep職位コード_InScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            return _myCQ.keep職位コード_InScopeSubQuery_Mst権限マスタList(subQuery);
        }

        public override String keep職位コード_NotInScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            return _myCQ.keep職位コード_NotInScopeSubQuery_Dch従業員職位履歴台帳List(subQuery);
        }

        public override String keep職位コード_NotInScopeSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            return _myCQ.keep職位コード_NotInScopeSubQuery_Mst従業員マスタList(subQuery);
        }

        public override String keep職位コード_NotInScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            return _myCQ.keep職位コード_NotInScopeSubQuery_Mst権限マスタList(subQuery);
        }
        public override String keep職位コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep職位コード_SpecifyDerivedReferrer_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep職位コード_SpecifyDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep職位コード_QueryDerivedReferrer_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep職位コード_QueryDerivedReferrer_Mst従業員マスタListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep職位コード_QueryDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep職位コード_QueryDerivedReferrer_Mst権限マスタListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValue職位名称() {
            return _myCQ.職位名称;
        }


        protected override ConditionValue getCValue職位英字名称() {
            return _myCQ.職位英字名称;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(Kbn職位区分CQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(Kbn職位区分CQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
