
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
    public class BsMstRoomCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MstRoomCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst_room"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? id) {
            assertObjectNotNull("id", id);
            BsMstRoomCB cb = this;
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
        public MstRoomCQ Query() {
            return this.ConditionQuery;
        }

        public MstRoomCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MstRoomCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MstRoomCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new MstRoomCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<MstRoomCB> unionQuery) {
            MstRoomCB cb = new MstRoomCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MstRoomCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<MstRoomCB> unionQuery) {
            MstRoomCB cb = new MstRoomCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MstRoomCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected MstRoomCBSpecification _specification;
        public MstRoomCBSpecification Specify() {
            if (_specification == null) { _specification = new MstRoomCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MstRoomCQ> {
			protected BsMstRoomCB _myCB;
			public MySpQyCall(BsMstRoomCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MstRoomCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MstRoomCB> ColumnQuery(SpecifyQuery<MstRoomCB> leftSpecifyQuery) {
            return new HpColQyOperand<MstRoomCB>(delegate(SpecifyQuery<MstRoomCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MstRoomCB xcreateColumnQueryCB() {
            MstRoomCB cb = new MstRoomCB();
            cb.xsetupForColumnQuery((MstRoomCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<MstRoomCB> orQuery) {
            xorQ((MstRoomCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MstRoomCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MstRoomCBColQySpQyCall(mainCB));
        }
    }

    public class MstRoomCBColQySpQyCall : HpSpQyCall<MstRoomCQ> {
        protected MstRoomCB _mainCB;
        public MstRoomCBColQySpQyCall(MstRoomCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MstRoomCQ qy() { return _mainCB.Query(); } 
    }

    public class MstRoomCBSpecification : AbstractSpecification<MstRoomCQ> {
        public MstRoomCBSpecification(ConditionBean baseCB, HpSpQyCall<MstRoomCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnId() { doColumn("id"); }
        public void ColumnRoomNo() { doColumn("room_no"); }
        public void ColumnRoomTypeCode() { doColumn("room_type_code"); }
        public void ColumnCanSmoke() { doColumn("can_smoke"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnId(); // PK
        }
        protected override String getTableDbName() { return "mst_room"; }
    }
}
