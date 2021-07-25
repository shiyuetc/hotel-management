
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
    public class BsDmyプロシージャCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected DmyプロシージャCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "dmyプロシージャ"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public override ConditionBean AddOrderBy_PK_Asc() {
            String msg = "This method is unsupported in this table that doesn't have primary key: ";
            throw new NotSupportedException(msg + ToString());
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            String msg = "This method is unsupported in this table that doesn't have primary key: ";
            throw new NotSupportedException(msg + ToString());
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public DmyプロシージャCQ Query() {
            return this.ConditionQuery;
        }

        public DmyプロシージャCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual DmyプロシージャCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual DmyプロシージャCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new DmyプロシージャCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<DmyプロシージャCB> unionQuery) {
            DmyプロシージャCB cb = new DmyプロシージャCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    DmyプロシージャCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<DmyプロシージャCB> unionQuery) {
            DmyプロシージャCB cb = new DmyプロシージャCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    DmyプロシージャCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected DmyプロシージャCBSpecification _specification;
        public DmyプロシージャCBSpecification Specify() {
            if (_specification == null) { _specification = new DmyプロシージャCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<DmyプロシージャCQ> {
			protected BsDmyプロシージャCB _myCB;
			public MySpQyCall(BsDmyプロシージャCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public DmyプロシージャCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<DmyプロシージャCB> ColumnQuery(SpecifyQuery<DmyプロシージャCB> leftSpecifyQuery) {
            return new HpColQyOperand<DmyプロシージャCB>(delegate(SpecifyQuery<DmyプロシージャCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected DmyプロシージャCB xcreateColumnQueryCB() {
            DmyプロシージャCB cb = new DmyプロシージャCB();
            cb.xsetupForColumnQuery((DmyプロシージャCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<DmyプロシージャCB> orQuery) {
            xorQ((DmyプロシージャCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(DmyプロシージャCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new DmyプロシージャCBColQySpQyCall(mainCB));
        }
    }

    public class DmyプロシージャCBColQySpQyCall : HpSpQyCall<DmyプロシージャCQ> {
        protected DmyプロシージャCB _mainCB;
        public DmyプロシージャCBColQySpQyCall(DmyプロシージャCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public DmyプロシージャCQ qy() { return _mainCB.Query(); } 
    }

    public class DmyプロシージャCBSpecification : AbstractSpecification<DmyプロシージャCQ> {
        public DmyプロシージャCBSpecification(ConditionBean baseCB, HpSpQyCall<DmyプロシージャCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnDummy() { doColumn("dummy"); }
        protected override void doSpecifyRequiredColumn() {
        }
        protected override String getTableDbName() { return "dmyプロシージャ"; }
    }
}
