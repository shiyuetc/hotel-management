
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
    public class Mst客室マスタCIQ : AbstractBsMst客室マスタCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsMst客室マスタCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mst客室マスタCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsMst客室マスタCQ myCQ)
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


        protected override ConditionValue getCValue客室コード() {
            return _myCQ.客室コード;
        }


        public override String keep客室コード_ExistsSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keep客室コード_ExistsSubQuery_Dch客室利用台帳List(subQuery);
        }

        public override String keep客室コード_NotExistsSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keep客室コード_NotExistsSubQuery_Dch客室利用台帳List(subQuery);
        }

        public override String keep客室コード_InScopeSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            return _myCQ.keep客室コード_InScopeSubQuery_Dch客室利用台帳List(subQuery);
        }

        public override String keep客室コード_NotInScopeSubQuery_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            return _myCQ.keep客室コード_NotInScopeSubQuery_Dch客室利用台帳List(subQuery);
        }
        public override String keep客室コード_SpecifyDerivedReferrer_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep客室コード_QueryDerivedReferrer_Dch客室利用台帳List(Dch客室利用台帳CQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keep客室コード_QueryDerivedReferrer_Dch客室利用台帳ListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValue客室番号() {
            return _myCQ.客室番号;
        }


        protected override ConditionValue getCValue客室タイプコード() {
            return _myCQ.客室タイプコード;
        }


        public override String keep客室タイプコード_InScopeSubQuery_Mst客室タイプマスタ(Mst客室タイプマスタCQ subQuery) {
            return _myCQ.keep客室タイプコード_InScopeSubQuery_Mst客室タイプマスタ(subQuery);
        }

        public override String keep客室タイプコード_NotInScopeSubQuery_Mst客室タイプマスタ(Mst客室タイプマスタCQ subQuery) {
            return _myCQ.keep客室タイプコード_NotInScopeSubQuery_Mst客室タイプマスタ(subQuery);
        }

        protected override ConditionValue getCValue喫煙() {
            return _myCQ.喫煙;
        }


        protected override ConditionValue getCValue備考() {
            return _myCQ.備考;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(Mst客室マスタCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(Mst客室マスタCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
