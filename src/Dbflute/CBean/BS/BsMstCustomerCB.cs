
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
    public class BsMstCustomerCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MstCustomerCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst_customer"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? id) {
            assertObjectNotNull("id", id);
            BsMstCustomerCB cb = this;
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
        public MstCustomerCQ Query() {
            return this.ConditionQuery;
        }

        public MstCustomerCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MstCustomerCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MstCustomerCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new MstCustomerCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<MstCustomerCB> unionQuery) {
            MstCustomerCB cb = new MstCustomerCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MstCustomerCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<MstCustomerCB> unionQuery) {
            MstCustomerCB cb = new MstCustomerCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MstCustomerCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected MstCustomerCBSpecification _specification;
        public MstCustomerCBSpecification Specify() {
            if (_specification == null) { _specification = new MstCustomerCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MstCustomerCQ> {
			protected BsMstCustomerCB _myCB;
			public MySpQyCall(BsMstCustomerCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MstCustomerCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MstCustomerCB> ColumnQuery(SpecifyQuery<MstCustomerCB> leftSpecifyQuery) {
            return new HpColQyOperand<MstCustomerCB>(delegate(SpecifyQuery<MstCustomerCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MstCustomerCB xcreateColumnQueryCB() {
            MstCustomerCB cb = new MstCustomerCB();
            cb.xsetupForColumnQuery((MstCustomerCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<MstCustomerCB> orQuery) {
            xorQ((MstCustomerCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MstCustomerCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MstCustomerCBColQySpQyCall(mainCB));
        }
    }

    public class MstCustomerCBColQySpQyCall : HpSpQyCall<MstCustomerCQ> {
        protected MstCustomerCB _mainCB;
        public MstCustomerCBColQySpQyCall(MstCustomerCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MstCustomerCQ qy() { return _mainCB.Query(); } 
    }

    public class MstCustomerCBSpecification : AbstractSpecification<MstCustomerCQ> {
        public MstCustomerCBSpecification(ConditionBean baseCB, HpSpQyCall<MstCustomerCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnId() { doColumn("id"); }
        public void ColumnName() { doColumn("name"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnId(); // PK
        }
        protected override String getTableDbName() { return "mst_customer"; }
    }
}
