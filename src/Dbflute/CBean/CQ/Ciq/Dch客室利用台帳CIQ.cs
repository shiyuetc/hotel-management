
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
    public class Dch客室利用台帳CIQ : AbstractBsDch客室利用台帳CQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsDch客室利用台帳CQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Dch客室利用台帳CIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsDch客室利用台帳CQ myCQ)
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


        public override String keepId_ExistsSubQuery_Dch宿泊利用台帳AsOne(Dch宿泊利用台帳CQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepId_ExistsSubQuery_Dch宿泊利用台帳AsOne(subQuery);
        }

        public override String keepId_NotExistsSubQuery_Dch宿泊利用台帳AsOne(Dch宿泊利用台帳CQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepId_NotExistsSubQuery_Dch宿泊利用台帳AsOne(subQuery);
        }

        public override String keepId_InScopeSubQuery_Dch宿泊利用台帳AsOne(Dch宿泊利用台帳CQ subQuery) {
            return _myCQ.keepId_InScopeSubQuery_Dch宿泊利用台帳AsOne(subQuery);
        }

        public override String keepId_NotInScopeSubQuery_Dch宿泊利用台帳AsOne(Dch宿泊利用台帳CQ subQuery) {
            return _myCQ.keepId_NotInScopeSubQuery_Dch宿泊利用台帳AsOne(subQuery);
        }

        protected override ConditionValue getCValue客室利用コード() {
            return _myCQ.客室利用コード;
        }


        public override String keep客室利用コード_InScopeSubQuery_Kbn客室利用区分(Kbn客室利用区分CQ subQuery) {
            return _myCQ.keep客室利用コード_InScopeSubQuery_Kbn客室利用区分(subQuery);
        }

        public override String keep客室利用コード_NotInScopeSubQuery_Kbn客室利用区分(Kbn客室利用区分CQ subQuery) {
            return _myCQ.keep客室利用コード_NotInScopeSubQuery_Kbn客室利用区分(subQuery);
        }

        protected override ConditionValue getCValue客室コード() {
            return _myCQ.客室コード;
        }


        public override String keep客室コード_InScopeSubQuery_Mst客室マスタ(Mst客室マスタCQ subQuery) {
            return _myCQ.keep客室コード_InScopeSubQuery_Mst客室マスタ(subQuery);
        }

        public override String keep客室コード_NotInScopeSubQuery_Mst客室マスタ(Mst客室マスタCQ subQuery) {
            return _myCQ.keep客室コード_NotInScopeSubQuery_Mst客室マスタ(subQuery);
        }

        protected override ConditionValue getCValue開始予定日時() {
            return _myCQ.開始予定日時;
        }


        protected override ConditionValue getCValue終了予定日時() {
            return _myCQ.終了予定日時;
        }


        protected override ConditionValue getCValue開始実績日時() {
            return _myCQ.開始実績日時;
        }


        protected override ConditionValue getCValue終了実績日時() {
            return _myCQ.終了実績日時;
        }


        protected override ConditionValue getCValue備考() {
            return _myCQ.備考;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(Dch客室利用台帳CQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(Dch客室利用台帳CQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
