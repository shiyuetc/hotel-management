
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
    public class BsMst制御画面マスタCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mst制御画面マスタCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst制御画面マスタ"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? id) {
            assertObjectNotNull("id", id);
            BsMst制御画面マスタCB cb = this;
            cb.Query().SetId_Equal(id);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_Id_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_Id_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public Mst制御画面マスタCQ Query() {
            return this.ConditionQuery;
        }

        public Mst制御画面マスタCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Mst制御画面マスタCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Mst制御画面マスタCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Mst制御画面マスタCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Mst制御画面マスタCB> unionQuery) {
            Mst制御画面マスタCB cb = new Mst制御画面マスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mst制御画面マスタCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Mst制御画面マスタCB> unionQuery) {
            Mst制御画面マスタCB cb = new Mst制御画面マスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mst制御画面マスタCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected Mst制御画面マスタCBSpecification _specification;
        public Mst制御画面マスタCBSpecification Specify() {
            if (_specification == null) { _specification = new Mst制御画面マスタCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Mst制御画面マスタCQ> {
			protected BsMst制御画面マスタCB _myCB;
			public MySpQyCall(BsMst制御画面マスタCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Mst制御画面マスタCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Mst制御画面マスタCB> ColumnQuery(SpecifyQuery<Mst制御画面マスタCB> leftSpecifyQuery) {
            return new HpColQyOperand<Mst制御画面マスタCB>(delegate(SpecifyQuery<Mst制御画面マスタCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Mst制御画面マスタCB xcreateColumnQueryCB() {
            Mst制御画面マスタCB cb = new Mst制御画面マスタCB();
            cb.xsetupForColumnQuery((Mst制御画面マスタCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Mst制御画面マスタCB> orQuery) {
            xorQ((Mst制御画面マスタCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Mst制御画面マスタCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Mst制御画面マスタCBColQySpQyCall(mainCB));
        }
    }

    public class Mst制御画面マスタCBColQySpQyCall : HpSpQyCall<Mst制御画面マスタCQ> {
        protected Mst制御画面マスタCB _mainCB;
        public Mst制御画面マスタCBColQySpQyCall(Mst制御画面マスタCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Mst制御画面マスタCQ qy() { return _mainCB.Query(); } 
    }

    public class Mst制御画面マスタCBSpecification : AbstractSpecification<Mst制御画面マスタCQ> {
        public Mst制御画面マスタCBSpecification(ConditionBean baseCB, HpSpQyCall<Mst制御画面マスタCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnId() { doColumn("id"); }
        public void Column画面名() { doColumn("画面名"); }
        public void Column表示名() { doColumn("表示名"); }
        public void Column優先順位() { doColumn("優先順位"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnId(); // PK
        }
        protected override String getTableDbName() { return "mst制御画面マスタ"; }
        public RAFunction<Mstメニュー権限マスタCB, Mst制御画面マスタCQ> DerivedMstメニュー権限マスタList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Mstメニュー権限マスタCB, Mst制御画面マスタCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Mstメニュー権限マスタCB> subQuery, Mst制御画面マスタCQ cq, String aliasName)
                { cq.xsderiveMstメニュー権限マスタList(function, subQuery, aliasName); });
        }
    }
}
