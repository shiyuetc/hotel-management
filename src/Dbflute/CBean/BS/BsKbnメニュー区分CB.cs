
using System;
using System.Collections;

using Dbflute.AllCommon;
using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.Helper;

using Dbflute.CBean;
using Dbflute.CBean.CQ;
using Dbflute.CBean.Nss;

namespace Dbflute.CBean.BS {

    [System.Serializable]
    public class BsKbnメニュー区分CB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Kbnメニュー区分CQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "kbnメニュー区分"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String code) {
            assertObjectNotNull("code", code);
            BsKbnメニュー区分CB cb = this;
            cb.Query().SetCode_Equal(code);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_Code_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_Code_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public Kbnメニュー区分CQ Query() {
            return this.ConditionQuery;
        }

        public Kbnメニュー区分CQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Kbnメニュー区分CQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Kbnメニュー区分CQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Kbnメニュー区分CQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Kbnメニュー区分CB> unionQuery) {
            Kbnメニュー区分CB cb = new Kbnメニュー区分CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Kbnメニュー区分CQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Kbnメニュー区分CB> unionQuery) {
            Kbnメニュー区分CB cb = new Kbnメニュー区分CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Kbnメニュー区分CQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected Kbnメニュー区分CBSpecification _specification;
        public Kbnメニュー区分CBSpecification Specify() {
            if (_specification == null) { _specification = new Kbnメニュー区分CBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Kbnメニュー区分CQ> {
			protected BsKbnメニュー区分CB _myCB;
			public MySpQyCall(BsKbnメニュー区分CB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Kbnメニュー区分CQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Kbnメニュー区分CB> ColumnQuery(SpecifyQuery<Kbnメニュー区分CB> leftSpecifyQuery) {
            return new HpColQyOperand<Kbnメニュー区分CB>(delegate(SpecifyQuery<Kbnメニュー区分CB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Kbnメニュー区分CB xcreateColumnQueryCB() {
            Kbnメニュー区分CB cb = new Kbnメニュー区分CB();
            cb.xsetupForColumnQuery((Kbnメニュー区分CB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Kbnメニュー区分CB> orQuery) {
            xorQ((Kbnメニュー区分CB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Kbnメニュー区分CB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Kbnメニュー区分CBColQySpQyCall(mainCB));
        }
    }

    public class Kbnメニュー区分CBColQySpQyCall : HpSpQyCall<Kbnメニュー区分CQ> {
        protected Kbnメニュー区分CB _mainCB;
        public Kbnメニュー区分CBColQySpQyCall(Kbnメニュー区分CB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Kbnメニュー区分CQ qy() { return _mainCB.Query(); } 
    }

    public class Kbnメニュー区分CBSpecification : AbstractSpecification<Kbnメニュー区分CQ> {
        public Kbnメニュー区分CBSpecification(ConditionBean baseCB, HpSpQyCall<Kbnメニュー区分CQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnCode() { doColumn("code"); }
        public void Columnメニュー名() { doColumn("メニュー名"); }
        public void Column優先順位() { doColumn("優先順位"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnCode(); // PK
        }
        protected override String getTableDbName() { return "kbnメニュー区分"; }
        public RAFunction<Mst制御画面マスタCB, Kbnメニュー区分CQ> DerivedMst制御画面マスタList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Mst制御画面マスタCB, Kbnメニュー区分CQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Mst制御画面マスタCB> subQuery, Kbnメニュー区分CQ cq, String aliasName)
                { cq.xsderiveMst制御画面マスタList(function, subQuery, aliasName); });
        }
    }
}
