
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
    public class BsMstEmployeeCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MstEmployeeCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst_employee"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? id) {
            assertObjectNotNull("id", id);
            BsMstEmployeeCB cb = this;
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
        public MstEmployeeCQ Query() {
            return this.ConditionQuery;
        }

        public MstEmployeeCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MstEmployeeCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MstEmployeeCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new MstEmployeeCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<MstEmployeeCB> unionQuery) {
            MstEmployeeCB cb = new MstEmployeeCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MstEmployeeCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<MstEmployeeCB> unionQuery) {
            MstEmployeeCB cb = new MstEmployeeCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MstEmployeeCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected KbnRankNss _nssKbnRank;
        public KbnRankNss NssKbnRank { get {
            if (_nssKbnRank == null) { _nssKbnRank = new KbnRankNss(null); }
            return _nssKbnRank;
        }}
        public KbnRankNss SetupSelect_KbnRank() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnRankCode();
            }
            doSetupSelect(delegate { return Query().QueryKbnRank(); });
            if (_nssKbnRank == null || !_nssKbnRank.HasConditionQuery)
            { _nssKbnRank = new KbnRankNss(Query().QueryKbnRank()); }
            return _nssKbnRank;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MstEmployeeCBSpecification _specification;
        public MstEmployeeCBSpecification Specify() {
            if (_specification == null) { _specification = new MstEmployeeCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MstEmployeeCQ> {
			protected BsMstEmployeeCB _myCB;
			public MySpQyCall(BsMstEmployeeCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MstEmployeeCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MstEmployeeCB> ColumnQuery(SpecifyQuery<MstEmployeeCB> leftSpecifyQuery) {
            return new HpColQyOperand<MstEmployeeCB>(delegate(SpecifyQuery<MstEmployeeCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MstEmployeeCB xcreateColumnQueryCB() {
            MstEmployeeCB cb = new MstEmployeeCB();
            cb.xsetupForColumnQuery((MstEmployeeCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<MstEmployeeCB> orQuery) {
            xorQ((MstEmployeeCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MstEmployeeCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MstEmployeeCBColQySpQyCall(mainCB));
        }
    }

    public class MstEmployeeCBColQySpQyCall : HpSpQyCall<MstEmployeeCQ> {
        protected MstEmployeeCB _mainCB;
        public MstEmployeeCBColQySpQyCall(MstEmployeeCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MstEmployeeCQ qy() { return _mainCB.Query(); } 
    }

    public class MstEmployeeCBSpecification : AbstractSpecification<MstEmployeeCQ> {
        protected KbnRankCBSpecification _kbnRank;
        public MstEmployeeCBSpecification(ConditionBean baseCB, HpSpQyCall<MstEmployeeCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnId() { doColumn("id"); }
        public void ColumnEmployeeNo() { doColumn("employee_no"); }
        public void ColumnName() { doColumn("name"); }
        public void ColumnPassword() { doColumn("password"); }
        public void ColumnRankCode() { doColumn("rank_code"); }
        public void ColumnEntryDate() { doColumn("entry_date"); }
        public void ColumnLeaveDate() { doColumn("leave_date"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnId(); // PK
            if (qyCall().qy().hasConditionQueryKbnRank()
                    || qyCall().qy().xgetReferrerQuery() is KbnRankCQ) {
                ColumnRankCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "mst_employee"; }
        public KbnRankCBSpecification SpecifyKbnRank() {
            assertForeign("kbnRank");
            if (_kbnRank == null) {
                _kbnRank = new KbnRankCBSpecification(_baseCB, new KbnRankSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _kbnRank.xsetSyncQyCall(new KbnRankSpQyCall(xsyncQyCall())); }
            }
            return _kbnRank;
        }
		public class KbnRankSpQyCall : HpSpQyCall<KbnRankCQ> {
		    protected HpSpQyCall<MstEmployeeCQ> _qyCall;
		    public KbnRankSpQyCall(HpSpQyCall<MstEmployeeCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryKbnRank(); }
			public KbnRankCQ qy() { return _qyCall.qy().QueryKbnRank(); }
		}
    }
}
