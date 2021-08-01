
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
    public class BsMst客室タイプマスタCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mst客室タイプマスタCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst客室タイプマスタ"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String 客室タイプコード) {
            assertObjectNotNull("客室タイプコード", 客室タイプコード);
            BsMst客室タイプマスタCB cb = this;
            cb.Query().Set客室タイプコード_Equal(客室タイプコード);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_客室タイプコード_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_客室タイプコード_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public Mst客室タイプマスタCQ Query() {
            return this.ConditionQuery;
        }

        public Mst客室タイプマスタCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Mst客室タイプマスタCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Mst客室タイプマスタCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Mst客室タイプマスタCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Mst客室タイプマスタCB> unionQuery) {
            Mst客室タイプマスタCB cb = new Mst客室タイプマスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mst客室タイプマスタCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Mst客室タイプマスタCB> unionQuery) {
            Mst客室タイプマスタCB cb = new Mst客室タイプマスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mst客室タイプマスタCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected Mst客室タイプマスタCBSpecification _specification;
        public Mst客室タイプマスタCBSpecification Specify() {
            if (_specification == null) { _specification = new Mst客室タイプマスタCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Mst客室タイプマスタCQ> {
			protected BsMst客室タイプマスタCB _myCB;
			public MySpQyCall(BsMst客室タイプマスタCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Mst客室タイプマスタCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Mst客室タイプマスタCB> ColumnQuery(SpecifyQuery<Mst客室タイプマスタCB> leftSpecifyQuery) {
            return new HpColQyOperand<Mst客室タイプマスタCB>(delegate(SpecifyQuery<Mst客室タイプマスタCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Mst客室タイプマスタCB xcreateColumnQueryCB() {
            Mst客室タイプマスタCB cb = new Mst客室タイプマスタCB();
            cb.xsetupForColumnQuery((Mst客室タイプマスタCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Mst客室タイプマスタCB> orQuery) {
            xorQ((Mst客室タイプマスタCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Mst客室タイプマスタCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Mst客室タイプマスタCBColQySpQyCall(mainCB));
        }
    }

    public class Mst客室タイプマスタCBColQySpQyCall : HpSpQyCall<Mst客室タイプマスタCQ> {
        protected Mst客室タイプマスタCB _mainCB;
        public Mst客室タイプマスタCBColQySpQyCall(Mst客室タイプマスタCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Mst客室タイプマスタCQ qy() { return _mainCB.Query(); } 
    }

    public class Mst客室タイプマスタCBSpecification : AbstractSpecification<Mst客室タイプマスタCQ> {
        public Mst客室タイプマスタCBSpecification(ConditionBean baseCB, HpSpQyCall<Mst客室タイプマスタCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void Column客室タイプコード() { doColumn("客室タイプコード"); }
        public void Column客室タイプ名称() { doColumn("客室タイプ名称"); }
        public void Column料金() { doColumn("料金"); }
        public void Column宿泊人数() { doColumn("宿泊人数"); }
        public void Column備考() { doColumn("備考"); }
        protected override void doSpecifyRequiredColumn() {
            Column客室タイプコード(); // PK
        }
        protected override String getTableDbName() { return "mst客室タイプマスタ"; }
        public RAFunction<Mst客室マスタCB, Mst客室タイプマスタCQ> DerivedMst客室マスタList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Mst客室マスタCB, Mst客室タイプマスタCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Mst客室マスタCB> subQuery, Mst客室タイプマスタCQ cq, String aliasName)
                { cq.xsderiveMst客室マスタList(function, subQuery, aliasName); });
        }
    }
}
