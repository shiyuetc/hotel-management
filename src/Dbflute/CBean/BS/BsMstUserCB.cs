
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
    public class BsMstUserCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MstUserCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst_user"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? id) {
            assertObjectNotNull("id", id);
            BsMstUserCB cb = this;
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
        public MstUserCQ Query() {
            return this.ConditionQuery;
        }

        public MstUserCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MstUserCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MstUserCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new MstUserCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<MstUserCB> unionQuery) {
            MstUserCB cb = new MstUserCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MstUserCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<MstUserCB> unionQuery) {
            MstUserCB cb = new MstUserCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MstUserCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected MstUserCBSpecification _specification;
        public MstUserCBSpecification Specify() {
            if (_specification == null) { _specification = new MstUserCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MstUserCQ> {
			protected BsMstUserCB _myCB;
			public MySpQyCall(BsMstUserCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MstUserCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MstUserCB> ColumnQuery(SpecifyQuery<MstUserCB> leftSpecifyQuery) {
            return new HpColQyOperand<MstUserCB>(delegate(SpecifyQuery<MstUserCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MstUserCB xcreateColumnQueryCB() {
            MstUserCB cb = new MstUserCB();
            cb.xsetupForColumnQuery((MstUserCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<MstUserCB> orQuery) {
            xorQ((MstUserCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MstUserCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MstUserCBColQySpQyCall(mainCB));
        }
    }

    public class MstUserCBColQySpQyCall : HpSpQyCall<MstUserCQ> {
        protected MstUserCB _mainCB;
        public MstUserCBColQySpQyCall(MstUserCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MstUserCQ qy() { return _mainCB.Query(); } 
    }

    public class MstUserCBSpecification : AbstractSpecification<MstUserCQ> {
        public MstUserCBSpecification(ConditionBean baseCB, HpSpQyCall<MstUserCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnId() { doColumn("id"); }
        public void ColumnName() { doColumn("name"); }
        public void ColumnPassword() { doColumn("password"); }
        public void ColumnUpdateTime() { doColumn("update_time"); }
        public void ColumnUpdateUser() { doColumn("update_user"); }
        public void ColumnVersionNo() { doColumn("version_no"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnId(); // PK
        }
        protected override String getTableDbName() { return "mst_user"; }
    }
}
