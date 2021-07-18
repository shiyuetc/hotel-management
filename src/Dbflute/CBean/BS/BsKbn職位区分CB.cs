
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
    public class BsKbn職位区分CB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Kbn職位区分CQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "kbn職位区分"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String コード) {
            assertObjectNotNull("コード", コード);
            BsKbn職位区分CB cb = this;
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
        public Kbn職位区分CQ Query() {
            return this.ConditionQuery;
        }

        public Kbn職位区分CQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Kbn職位区分CQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Kbn職位区分CQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Kbn職位区分CQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Kbn職位区分CB> unionQuery) {
            Kbn職位区分CB cb = new Kbn職位区分CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Kbn職位区分CQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Kbn職位区分CB> unionQuery) {
            Kbn職位区分CB cb = new Kbn職位区分CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Kbn職位区分CQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected Kbn職位区分CBSpecification _specification;
        public Kbn職位区分CBSpecification Specify() {
            if (_specification == null) { _specification = new Kbn職位区分CBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Kbn職位区分CQ> {
			protected BsKbn職位区分CB _myCB;
			public MySpQyCall(BsKbn職位区分CB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Kbn職位区分CQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Kbn職位区分CB> ColumnQuery(SpecifyQuery<Kbn職位区分CB> leftSpecifyQuery) {
            return new HpColQyOperand<Kbn職位区分CB>(delegate(SpecifyQuery<Kbn職位区分CB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Kbn職位区分CB xcreateColumnQueryCB() {
            Kbn職位区分CB cb = new Kbn職位区分CB();
            cb.xsetupForColumnQuery((Kbn職位区分CB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Kbn職位区分CB> orQuery) {
            xorQ((Kbn職位区分CB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Kbn職位区分CB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Kbn職位区分CBColQySpQyCall(mainCB));
        }
    }

    public class Kbn職位区分CBColQySpQyCall : HpSpQyCall<Kbn職位区分CQ> {
        protected Kbn職位区分CB _mainCB;
        public Kbn職位区分CBColQySpQyCall(Kbn職位区分CB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Kbn職位区分CQ qy() { return _mainCB.Query(); } 
    }

    public class Kbn職位区分CBSpecification : AbstractSpecification<Kbn職位区分CQ> {
        public Kbn職位区分CBSpecification(ConditionBean baseCB, HpSpQyCall<Kbn職位区分CQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void Columnコード() { doColumn("コード"); }
        public void Column名称() { doColumn("名称"); }
        public void Column名称英字() { doColumn("名称_英字"); }
        protected override void doSpecifyRequiredColumn() {
            Columnコード(); // PK
        }
        protected override String getTableDbName() { return "kbn職位区分"; }
        public RAFunction<Dch従業員職位履歴台帳CB, Kbn職位区分CQ> DerivedDch従業員職位履歴台帳List() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Dch従業員職位履歴台帳CB, Kbn職位区分CQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Dch従業員職位履歴台帳CB> subQuery, Kbn職位区分CQ cq, String aliasName)
                { cq.xsderiveDch従業員職位履歴台帳List(function, subQuery, aliasName); });
        }
        public RAFunction<Mst従業員マスタCB, Kbn職位区分CQ> DerivedMst従業員マスタList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Mst従業員マスタCB, Kbn職位区分CQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Mst従業員マスタCB> subQuery, Kbn職位区分CQ cq, String aliasName)
                { cq.xsderiveMst従業員マスタList(function, subQuery, aliasName); });
        }
        public RAFunction<Mst権限マスタCB, Kbn職位区分CQ> DerivedMst権限マスタList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Mst権限マスタCB, Kbn職位区分CQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Mst権限マスタCB> subQuery, Kbn職位区分CQ cq, String aliasName)
                { cq.xsderiveMst権限マスタList(function, subQuery, aliasName); });
        }
    }
}
