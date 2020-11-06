
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
    public class BsRoomCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected RoomCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "room"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? id) {
            assertObjectNotNull("id", id);
            BsRoomCB cb = this;
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
        public RoomCQ Query() {
            return this.ConditionQuery;
        }

        public RoomCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual RoomCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual RoomCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new RoomCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<RoomCB> unionQuery) {
            RoomCB cb = new RoomCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    RoomCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<RoomCB> unionQuery) {
            RoomCB cb = new RoomCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    RoomCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected RoomTypeNss _nssRoomType;
        public RoomTypeNss NssRoomType { get {
            if (_nssRoomType == null) { _nssRoomType = new RoomTypeNss(null); }
            return _nssRoomType;
        }}
        public RoomTypeNss SetupSelect_RoomType() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnRoomTypeCode();
            }
            doSetupSelect(delegate { return Query().QueryRoomType(); });
            if (_nssRoomType == null || !_nssRoomType.HasConditionQuery)
            { _nssRoomType = new RoomTypeNss(Query().QueryRoomType()); }
            return _nssRoomType;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected RoomCBSpecification _specification;
        public RoomCBSpecification Specify() {
            if (_specification == null) { _specification = new RoomCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<RoomCQ> {
			protected BsRoomCB _myCB;
			public MySpQyCall(BsRoomCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public RoomCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<RoomCB> ColumnQuery(SpecifyQuery<RoomCB> leftSpecifyQuery) {
            return new HpColQyOperand<RoomCB>(delegate(SpecifyQuery<RoomCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected RoomCB xcreateColumnQueryCB() {
            RoomCB cb = new RoomCB();
            cb.xsetupForColumnQuery((RoomCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<RoomCB> orQuery) {
            xorQ((RoomCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(RoomCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new RoomCBColQySpQyCall(mainCB));
        }
    }

    public class RoomCBColQySpQyCall : HpSpQyCall<RoomCQ> {
        protected RoomCB _mainCB;
        public RoomCBColQySpQyCall(RoomCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public RoomCQ qy() { return _mainCB.Query(); } 
    }

    public class RoomCBSpecification : AbstractSpecification<RoomCQ> {
        protected RoomTypeCBSpecification _roomType;
        public RoomCBSpecification(ConditionBean baseCB, HpSpQyCall<RoomCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnId() { doColumn("id"); }
        public void ColumnRoomNo() { doColumn("room_no"); }
        public void ColumnRoomTypeCode() { doColumn("room_type_code"); }
        public void ColumnCanSmoke() { doColumn("can_smoke"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnId(); // PK
            if (qyCall().qy().hasConditionQueryRoomType()
                    || qyCall().qy().xgetReferrerQuery() is RoomTypeCQ) {
                ColumnRoomTypeCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "room"; }
        public RoomTypeCBSpecification SpecifyRoomType() {
            assertForeign("roomType");
            if (_roomType == null) {
                _roomType = new RoomTypeCBSpecification(_baseCB, new RoomTypeSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _roomType.xsetSyncQyCall(new RoomTypeSpQyCall(xsyncQyCall())); }
            }
            return _roomType;
        }
		public class RoomTypeSpQyCall : HpSpQyCall<RoomTypeCQ> {
		    protected HpSpQyCall<RoomCQ> _qyCall;
		    public RoomTypeSpQyCall(HpSpQyCall<RoomCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryRoomType(); }
			public RoomTypeCQ qy() { return _qyCall.qy().QueryRoomType(); }
		}
    }
}
