
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
    public class BsKbn客室利用区分CB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Kbn客室利用区分CQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "kbn客室利用区分"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String 客室利用コード) {
            assertObjectNotNull("客室利用コード", 客室利用コード);
            BsKbn客室利用区分CB cb = this;
            cb.Query().Set客室利用コード_Equal(客室利用コード);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_客室利用コード_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_客室利用コード_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public Kbn客室利用区分CQ Query() {
            return this.ConditionQuery;
        }

        public Kbn客室利用区分CQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Kbn客室利用区分CQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Kbn客室利用区分CQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Kbn客室利用区分CQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Kbn客室利用区分CB> unionQuery) {
            Kbn客室利用区分CB cb = new Kbn客室利用区分CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Kbn客室利用区分CQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Kbn客室利用区分CB> unionQuery) {
            Kbn客室利用区分CB cb = new Kbn客室利用区分CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Kbn客室利用区分CQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected Kbn客室利用区分CBSpecification _specification;
        public Kbn客室利用区分CBSpecification Specify() {
            if (_specification == null) { _specification = new Kbn客室利用区分CBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Kbn客室利用区分CQ> {
			protected BsKbn客室利用区分CB _myCB;
			public MySpQyCall(BsKbn客室利用区分CB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Kbn客室利用区分CQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Kbn客室利用区分CB> ColumnQuery(SpecifyQuery<Kbn客室利用区分CB> leftSpecifyQuery) {
            return new HpColQyOperand<Kbn客室利用区分CB>(delegate(SpecifyQuery<Kbn客室利用区分CB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Kbn客室利用区分CB xcreateColumnQueryCB() {
            Kbn客室利用区分CB cb = new Kbn客室利用区分CB();
            cb.xsetupForColumnQuery((Kbn客室利用区分CB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Kbn客室利用区分CB> orQuery) {
            xorQ((Kbn客室利用区分CB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Kbn客室利用区分CB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Kbn客室利用区分CBColQySpQyCall(mainCB));
        }
    }

    public class Kbn客室利用区分CBColQySpQyCall : HpSpQyCall<Kbn客室利用区分CQ> {
        protected Kbn客室利用区分CB _mainCB;
        public Kbn客室利用区分CBColQySpQyCall(Kbn客室利用区分CB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Kbn客室利用区分CQ qy() { return _mainCB.Query(); } 
    }

    public class Kbn客室利用区分CBSpecification : AbstractSpecification<Kbn客室利用区分CQ> {
        public Kbn客室利用区分CBSpecification(ConditionBean baseCB, HpSpQyCall<Kbn客室利用区分CQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void Column客室利用コード() { doColumn("客室利用コード"); }
        public void Column客室利用名称() { doColumn("客室利用名称"); }
        protected override void doSpecifyRequiredColumn() {
            Column客室利用コード(); // PK
        }
        protected override String getTableDbName() { return "kbn客室利用区分"; }
        public RAFunction<Dch客室利用台帳CB, Kbn客室利用区分CQ> DerivedDch客室利用台帳List() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Dch客室利用台帳CB, Kbn客室利用区分CQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Dch客室利用台帳CB> subQuery, Kbn客室利用区分CQ cq, String aliasName)
                { cq.xsderiveDch客室利用台帳List(function, subQuery, aliasName); });
        }
    }
}
