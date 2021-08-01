
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
    public class BsDch月締確定台帳CB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Dch月締確定台帳CQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "dch月締確定台帳"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String 対象年月) {
            assertObjectNotNull("対象年月", 対象年月);
            BsDch月締確定台帳CB cb = this;
            cb.Query().Set対象年月_Equal(対象年月);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_対象年月_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_対象年月_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public Dch月締確定台帳CQ Query() {
            return this.ConditionQuery;
        }

        public Dch月締確定台帳CQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Dch月締確定台帳CQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Dch月締確定台帳CQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Dch月締確定台帳CQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Dch月締確定台帳CB> unionQuery) {
            Dch月締確定台帳CB cb = new Dch月締確定台帳CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Dch月締確定台帳CQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Dch月締確定台帳CB> unionQuery) {
            Dch月締確定台帳CB cb = new Dch月締確定台帳CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Dch月締確定台帳CQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected Dch月締確定台帳CBSpecification _specification;
        public Dch月締確定台帳CBSpecification Specify() {
            if (_specification == null) { _specification = new Dch月締確定台帳CBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Dch月締確定台帳CQ> {
			protected BsDch月締確定台帳CB _myCB;
			public MySpQyCall(BsDch月締確定台帳CB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Dch月締確定台帳CQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Dch月締確定台帳CB> ColumnQuery(SpecifyQuery<Dch月締確定台帳CB> leftSpecifyQuery) {
            return new HpColQyOperand<Dch月締確定台帳CB>(delegate(SpecifyQuery<Dch月締確定台帳CB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Dch月締確定台帳CB xcreateColumnQueryCB() {
            Dch月締確定台帳CB cb = new Dch月締確定台帳CB();
            cb.xsetupForColumnQuery((Dch月締確定台帳CB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Dch月締確定台帳CB> orQuery) {
            xorQ((Dch月締確定台帳CB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Dch月締確定台帳CB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Dch月締確定台帳CBColQySpQyCall(mainCB));
        }
    }

    public class Dch月締確定台帳CBColQySpQyCall : HpSpQyCall<Dch月締確定台帳CQ> {
        protected Dch月締確定台帳CB _mainCB;
        public Dch月締確定台帳CBColQySpQyCall(Dch月締確定台帳CB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Dch月締確定台帳CQ qy() { return _mainCB.Query(); } 
    }

    public class Dch月締確定台帳CBSpecification : AbstractSpecification<Dch月締確定台帳CQ> {
        public Dch月締確定台帳CBSpecification(ConditionBean baseCB, HpSpQyCall<Dch月締確定台帳CQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void Column対象年月() { doColumn("対象年月"); }
        protected override void doSpecifyRequiredColumn() {
            Column対象年月(); // PK
        }
        protected override String getTableDbName() { return "dch月締確定台帳"; }
    }
}
