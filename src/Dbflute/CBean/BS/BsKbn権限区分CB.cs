
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
    public class BsKbn権限区分CB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Kbn権限区分CQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "kbn権限区分"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String コード) {
            assertObjectNotNull("コード", コード);
            BsKbn権限区分CB cb = this;
            cb.Query().Setコード_Equal(コード);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_コード_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_コード_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public Kbn権限区分CQ Query() {
            return this.ConditionQuery;
        }

        public Kbn権限区分CQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Kbn権限区分CQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Kbn権限区分CQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Kbn権限区分CQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Kbn権限区分CB> unionQuery) {
            Kbn権限区分CB cb = new Kbn権限区分CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Kbn権限区分CQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Kbn権限区分CB> unionQuery) {
            Kbn権限区分CB cb = new Kbn権限区分CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Kbn権限区分CQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected Kbn権限区分CBSpecification _specification;
        public Kbn権限区分CBSpecification Specify() {
            if (_specification == null) { _specification = new Kbn権限区分CBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Kbn権限区分CQ> {
			protected BsKbn権限区分CB _myCB;
			public MySpQyCall(BsKbn権限区分CB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Kbn権限区分CQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Kbn権限区分CB> ColumnQuery(SpecifyQuery<Kbn権限区分CB> leftSpecifyQuery) {
            return new HpColQyOperand<Kbn権限区分CB>(delegate(SpecifyQuery<Kbn権限区分CB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Kbn権限区分CB xcreateColumnQueryCB() {
            Kbn権限区分CB cb = new Kbn権限区分CB();
            cb.xsetupForColumnQuery((Kbn権限区分CB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Kbn権限区分CB> orQuery) {
            xorQ((Kbn権限区分CB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Kbn権限区分CB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Kbn権限区分CBColQySpQyCall(mainCB));
        }
    }

    public class Kbn権限区分CBColQySpQyCall : HpSpQyCall<Kbn権限区分CQ> {
        protected Kbn権限区分CB _mainCB;
        public Kbn権限区分CBColQySpQyCall(Kbn権限区分CB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Kbn権限区分CQ qy() { return _mainCB.Query(); } 
    }

    public class Kbn権限区分CBSpecification : AbstractSpecification<Kbn権限区分CQ> {
        public Kbn権限区分CBSpecification(ConditionBean baseCB, HpSpQyCall<Kbn権限区分CQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void Columnコード() { doColumn("コード"); }
        public void Column名称() { doColumn("名称"); }
        protected override void doSpecifyRequiredColumn() {
            Columnコード(); // PK
        }
        protected override String getTableDbName() { return "kbn権限区分"; }
        public RAFunction<Mst権限マスタCB, Kbn権限区分CQ> DerivedMst権限マスタList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Mst権限マスタCB, Kbn権限区分CQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Mst権限マスタCB> subQuery, Kbn権限区分CQ cq, String aliasName)
                { cq.xsderiveMst権限マスタList(function, subQuery, aliasName); });
        }
    }
}
