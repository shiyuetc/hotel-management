
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
    public class BsKbnRankCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected KbnRankCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "kbn_rank"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String code) {
            assertObjectNotNull("code", code);
            BsKbnRankCB cb = this;
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
        public KbnRankCQ Query() {
            return this.ConditionQuery;
        }

        public KbnRankCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual KbnRankCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual KbnRankCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new KbnRankCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<KbnRankCB> unionQuery) {
            KbnRankCB cb = new KbnRankCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    KbnRankCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<KbnRankCB> unionQuery) {
            KbnRankCB cb = new KbnRankCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    KbnRankCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected KbnRankCBSpecification _specification;
        public KbnRankCBSpecification Specify() {
            if (_specification == null) { _specification = new KbnRankCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<KbnRankCQ> {
			protected BsKbnRankCB _myCB;
			public MySpQyCall(BsKbnRankCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public KbnRankCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<KbnRankCB> ColumnQuery(SpecifyQuery<KbnRankCB> leftSpecifyQuery) {
            return new HpColQyOperand<KbnRankCB>(delegate(SpecifyQuery<KbnRankCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected KbnRankCB xcreateColumnQueryCB() {
            KbnRankCB cb = new KbnRankCB();
            cb.xsetupForColumnQuery((KbnRankCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<KbnRankCB> orQuery) {
            xorQ((KbnRankCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(KbnRankCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new KbnRankCBColQySpQyCall(mainCB));
        }
    }

    public class KbnRankCBColQySpQyCall : HpSpQyCall<KbnRankCQ> {
        protected KbnRankCB _mainCB;
        public KbnRankCBColQySpQyCall(KbnRankCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public KbnRankCQ qy() { return _mainCB.Query(); } 
    }

    public class KbnRankCBSpecification : AbstractSpecification<KbnRankCQ> {
        public KbnRankCBSpecification(ConditionBean baseCB, HpSpQyCall<KbnRankCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnCode() { doColumn("code"); }
        public void ColumnEnglishName() { doColumn("english_name"); }
        public void ColumnJapaneseName() { doColumn("japanese_name"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnCode(); // PK
        }
        protected override String getTableDbName() { return "kbn_rank"; }
        public RAFunction<MstEmployeeCB, KbnRankCQ> DerivedMstEmployeeList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MstEmployeeCB, KbnRankCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<MstEmployeeCB> subQuery, KbnRankCQ cq, String aliasName)
                { cq.xsderiveMstEmployeeList(function, subQuery, aliasName); });
        }
    }
}
