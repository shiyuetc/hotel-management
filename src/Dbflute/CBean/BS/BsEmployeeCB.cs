
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
    public class BsEmployeeCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected EmployeeCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "employee"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? id) {
            assertObjectNotNull("id", id);
            BsEmployeeCB cb = this;
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
        public EmployeeCQ Query() {
            return this.ConditionQuery;
        }

        public EmployeeCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual EmployeeCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual EmployeeCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new EmployeeCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<EmployeeCB> unionQuery) {
            EmployeeCB cb = new EmployeeCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    EmployeeCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<EmployeeCB> unionQuery) {
            EmployeeCB cb = new EmployeeCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    EmployeeCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected RankNss _nssRank;
        public RankNss NssRank { get {
            if (_nssRank == null) { _nssRank = new RankNss(null); }
            return _nssRank;
        }}
        public RankNss SetupSelect_Rank() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnRankCode();
            }
            doSetupSelect(delegate { return Query().QueryRank(); });
            if (_nssRank == null || !_nssRank.HasConditionQuery)
            { _nssRank = new RankNss(Query().QueryRank()); }
            return _nssRank;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected EmployeeCBSpecification _specification;
        public EmployeeCBSpecification Specify() {
            if (_specification == null) { _specification = new EmployeeCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<EmployeeCQ> {
			protected BsEmployeeCB _myCB;
			public MySpQyCall(BsEmployeeCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public EmployeeCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<EmployeeCB> ColumnQuery(SpecifyQuery<EmployeeCB> leftSpecifyQuery) {
            return new HpColQyOperand<EmployeeCB>(delegate(SpecifyQuery<EmployeeCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected EmployeeCB xcreateColumnQueryCB() {
            EmployeeCB cb = new EmployeeCB();
            cb.xsetupForColumnQuery((EmployeeCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<EmployeeCB> orQuery) {
            xorQ((EmployeeCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(EmployeeCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new EmployeeCBColQySpQyCall(mainCB));
        }
    }

    public class EmployeeCBColQySpQyCall : HpSpQyCall<EmployeeCQ> {
        protected EmployeeCB _mainCB;
        public EmployeeCBColQySpQyCall(EmployeeCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public EmployeeCQ qy() { return _mainCB.Query(); } 
    }

    public class EmployeeCBSpecification : AbstractSpecification<EmployeeCQ> {
        protected RankCBSpecification _rank;
        public EmployeeCBSpecification(ConditionBean baseCB, HpSpQyCall<EmployeeCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnId() { doColumn("id"); }
        public void ColumnEmployeeNo() { doColumn("employee_no"); }
        public void ColumnPassword() { doColumn("password"); }
        public void ColumnRankCode() { doColumn("rank_code"); }
        public void ColumnLastName() { doColumn("last_name"); }
        public void ColumnFirstName() { doColumn("first_name"); }
        public void ColumnEntryDate() { doColumn("entry_date"); }
        public void ColumnLeaveDate() { doColumn("leave_date"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnId(); // PK
            if (qyCall().qy().hasConditionQueryRank()
                    || qyCall().qy().xgetReferrerQuery() is RankCQ) {
                ColumnRankCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "employee"; }
        public RankCBSpecification SpecifyRank() {
            assertForeign("rank");
            if (_rank == null) {
                _rank = new RankCBSpecification(_baseCB, new RankSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _rank.xsetSyncQyCall(new RankSpQyCall(xsyncQyCall())); }
            }
            return _rank;
        }
		public class RankSpQyCall : HpSpQyCall<RankCQ> {
		    protected HpSpQyCall<EmployeeCQ> _qyCall;
		    public RankSpQyCall(HpSpQyCall<EmployeeCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryRank(); }
			public RankCQ qy() { return _qyCall.qy().QueryRank(); }
		}
    }
}
