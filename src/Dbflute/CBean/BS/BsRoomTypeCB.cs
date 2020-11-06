
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
    public class BsRoomTypeCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected RoomTypeCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "room_type"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String code) {
            assertObjectNotNull("code", code);
            BsRoomTypeCB cb = this;
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
        public RoomTypeCQ Query() {
            return this.ConditionQuery;
        }

        public RoomTypeCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual RoomTypeCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual RoomTypeCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new RoomTypeCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<RoomTypeCB> unionQuery) {
            RoomTypeCB cb = new RoomTypeCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    RoomTypeCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<RoomTypeCB> unionQuery) {
            RoomTypeCB cb = new RoomTypeCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    RoomTypeCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected RoomTypeCBSpecification _specification;
        public RoomTypeCBSpecification Specify() {
            if (_specification == null) { _specification = new RoomTypeCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<RoomTypeCQ> {
			protected BsRoomTypeCB _myCB;
			public MySpQyCall(BsRoomTypeCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public RoomTypeCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<RoomTypeCB> ColumnQuery(SpecifyQuery<RoomTypeCB> leftSpecifyQuery) {
            return new HpColQyOperand<RoomTypeCB>(delegate(SpecifyQuery<RoomTypeCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected RoomTypeCB xcreateColumnQueryCB() {
            RoomTypeCB cb = new RoomTypeCB();
            cb.xsetupForColumnQuery((RoomTypeCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<RoomTypeCB> orQuery) {
            xorQ((RoomTypeCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(RoomTypeCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new RoomTypeCBColQySpQyCall(mainCB));
        }
    }

    public class RoomTypeCBColQySpQyCall : HpSpQyCall<RoomTypeCQ> {
        protected RoomTypeCB _mainCB;
        public RoomTypeCBColQySpQyCall(RoomTypeCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public RoomTypeCQ qy() { return _mainCB.Query(); } 
    }

    public class RoomTypeCBSpecification : AbstractSpecification<RoomTypeCQ> {
        public RoomTypeCBSpecification(ConditionBean baseCB, HpSpQyCall<RoomTypeCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnCode() { doColumn("code"); }
        public void ColumnName() { doColumn("name"); }
        public void ColumnPrice() { doColumn("price"); }
        public void ColumnCapacity() { doColumn("capacity"); }
        public void ColumnDescription() { doColumn("description"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnCode(); // PK
        }
        protected override String getTableDbName() { return "room_type"; }
        public RAFunction<RoomCB, RoomTypeCQ> DerivedRoomList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<RoomCB, RoomTypeCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<RoomCB> subQuery, RoomTypeCQ cq, String aliasName)
                { cq.xsderiveRoomList(function, subQuery, aliasName); });
        }
    }
}
