
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
    public class BsRankCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected RankCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "rank"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String code) {
            assertObjectNotNull("code", code);
            BsRankCB cb = this;
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
        public RankCQ Query() {
            return this.ConditionQuery;
        }

        public RankCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual RankCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual RankCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new RankCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<RankCB> unionQuery) {
            RankCB cb = new RankCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    RankCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<RankCB> unionQuery) {
            RankCB cb = new RankCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    RankCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected RankCBSpecification _specification;
        public RankCBSpecification Specify() {
            if (_specification == null) { _specification = new RankCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<RankCQ> {
			protected BsRankCB _myCB;
			public MySpQyCall(BsRankCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public RankCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<RankCB> ColumnQuery(SpecifyQuery<RankCB> leftSpecifyQuery) {
            return new HpColQyOperand<RankCB>(delegate(SpecifyQuery<RankCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected RankCB xcreateColumnQueryCB() {
            RankCB cb = new RankCB();
            cb.xsetupForColumnQuery((RankCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<RankCB> orQuery) {
            xorQ((RankCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(RankCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new RankCBColQySpQyCall(mainCB));
        }
    }

    public class RankCBColQySpQyCall : HpSpQyCall<RankCQ> {
        protected RankCB _mainCB;
        public RankCBColQySpQyCall(RankCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public RankCQ qy() { return _mainCB.Query(); } 
    }

    public class RankCBSpecification : AbstractSpecification<RankCQ> {
        public RankCBSpecification(ConditionBean baseCB, HpSpQyCall<RankCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnCode() { doColumn("code"); }
        public void ColumnEnglishName() { doColumn("english_name"); }
        public void ColumnJapaneseName() { doColumn("japanese_name"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnCode(); // PK
        }
        protected override String getTableDbName() { return "rank"; }
        public RAFunction<EmployeeCB, RankCQ> DerivedEmployeeList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<EmployeeCB, RankCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<EmployeeCB> subQuery, RankCQ cq, String aliasName)
                { cq.xsderiveEmployeeList(function, subQuery, aliasName); });
        }
    }
}
