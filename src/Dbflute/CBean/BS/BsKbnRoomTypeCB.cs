
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
    public class BsKbnRoomTypeCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected KbnRoomTypeCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "kbn_room_type"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String code) {
            assertObjectNotNull("code", code);
            BsKbnRoomTypeCB cb = this;
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
        public KbnRoomTypeCQ Query() {
            return this.ConditionQuery;
        }

        public KbnRoomTypeCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual KbnRoomTypeCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual KbnRoomTypeCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new KbnRoomTypeCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<KbnRoomTypeCB> unionQuery) {
            KbnRoomTypeCB cb = new KbnRoomTypeCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    KbnRoomTypeCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<KbnRoomTypeCB> unionQuery) {
            KbnRoomTypeCB cb = new KbnRoomTypeCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    KbnRoomTypeCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected KbnRoomTypeCBSpecification _specification;
        public KbnRoomTypeCBSpecification Specify() {
            if (_specification == null) { _specification = new KbnRoomTypeCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<KbnRoomTypeCQ> {
			protected BsKbnRoomTypeCB _myCB;
			public MySpQyCall(BsKbnRoomTypeCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public KbnRoomTypeCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<KbnRoomTypeCB> ColumnQuery(SpecifyQuery<KbnRoomTypeCB> leftSpecifyQuery) {
            return new HpColQyOperand<KbnRoomTypeCB>(delegate(SpecifyQuery<KbnRoomTypeCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected KbnRoomTypeCB xcreateColumnQueryCB() {
            KbnRoomTypeCB cb = new KbnRoomTypeCB();
            cb.xsetupForColumnQuery((KbnRoomTypeCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<KbnRoomTypeCB> orQuery) {
            xorQ((KbnRoomTypeCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(KbnRoomTypeCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new KbnRoomTypeCBColQySpQyCall(mainCB));
        }
    }

    public class KbnRoomTypeCBColQySpQyCall : HpSpQyCall<KbnRoomTypeCQ> {
        protected KbnRoomTypeCB _mainCB;
        public KbnRoomTypeCBColQySpQyCall(KbnRoomTypeCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public KbnRoomTypeCQ qy() { return _mainCB.Query(); } 
    }

    public class KbnRoomTypeCBSpecification : AbstractSpecification<KbnRoomTypeCQ> {
        public KbnRoomTypeCBSpecification(ConditionBean baseCB, HpSpQyCall<KbnRoomTypeCQ> qyCall
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
        protected override String getTableDbName() { return "kbn_room_type"; }
    }
}
