
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
    public class BsUSERCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected USERCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "USER"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? iD) {
            assertObjectNotNull("iD", iD);
            BsUSERCB cb = this;
            cb.Query().SetID_Equal(iD);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_ID_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_ID_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public USERCQ Query() {
            return this.ConditionQuery;
        }

        public USERCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual USERCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual USERCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new USERCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<USERCB> unionQuery) {
            USERCB cb = new USERCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    USERCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<USERCB> unionQuery) {
            USERCB cb = new USERCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    USERCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected USERCBSpecification _specification;
        public USERCBSpecification Specify() {
            if (_specification == null) { _specification = new USERCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<USERCQ> {
			protected BsUSERCB _myCB;
			public MySpQyCall(BsUSERCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public USERCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<USERCB> ColumnQuery(SpecifyQuery<USERCB> leftSpecifyQuery) {
            return new HpColQyOperand<USERCB>(delegate(SpecifyQuery<USERCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected USERCB xcreateColumnQueryCB() {
            USERCB cb = new USERCB();
            cb.xsetupForColumnQuery((USERCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<USERCB> orQuery) {
            xorQ((USERCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(USERCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new USERCBColQySpQyCall(mainCB));
        }
    }

    public class USERCBColQySpQyCall : HpSpQyCall<USERCQ> {
        protected USERCB _mainCB;
        public USERCBColQySpQyCall(USERCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public USERCQ qy() { return _mainCB.Query(); } 
    }

    public class USERCBSpecification : AbstractSpecification<USERCQ> {
        public USERCBSpecification(ConditionBean baseCB, HpSpQyCall<USERCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnID() { doColumn("ID"); }
        public void ColumnNAME() { doColumn("NAME"); }
        public void ColumnUPDATE_DATETIME() { doColumn("UPDATE_DATETIME"); }
        public void ColumnUPDATE_USER() { doColumn("UPDATE_USER"); }
        public void ColumnVERSION_NO() { doColumn("VERSION_NO"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnID(); // PK
        }
        protected override String getTableDbName() { return "USER"; }
    }
}
