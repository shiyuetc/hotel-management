
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
    public class BsDch清掃予定台帳CB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Dch清掃予定台帳CQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "dch清掃予定台帳"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? id) {
            assertObjectNotNull("id", id);
            BsDch清掃予定台帳CB cb = this;
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
        public Dch清掃予定台帳CQ Query() {
            return this.ConditionQuery;
        }

        public Dch清掃予定台帳CQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Dch清掃予定台帳CQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Dch清掃予定台帳CQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Dch清掃予定台帳CQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Dch清掃予定台帳CB> unionQuery) {
            Dch清掃予定台帳CB cb = new Dch清掃予定台帳CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Dch清掃予定台帳CQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Dch清掃予定台帳CB> unionQuery) {
            Dch清掃予定台帳CB cb = new Dch清掃予定台帳CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Dch清掃予定台帳CQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected Dch客室利用予定台帳Nss _nssDch客室利用予定台帳;
        public Dch客室利用予定台帳Nss NssDch客室利用予定台帳 { get {
            if (_nssDch客室利用予定台帳 == null) { _nssDch客室利用予定台帳 = new Dch客室利用予定台帳Nss(null); }
            return _nssDch客室利用予定台帳;
        }}
        public Dch客室利用予定台帳Nss SetupSelect_Dch客室利用予定台帳() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().Column客室利用予定台帳id();
            }
            doSetupSelect(delegate { return Query().QueryDch客室利用予定台帳(); });
            if (_nssDch客室利用予定台帳 == null || !_nssDch客室利用予定台帳.HasConditionQuery)
            { _nssDch客室利用予定台帳 = new Dch客室利用予定台帳Nss(Query().QueryDch客室利用予定台帳()); }
            return _nssDch客室利用予定台帳;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected Dch清掃予定台帳CBSpecification _specification;
        public Dch清掃予定台帳CBSpecification Specify() {
            if (_specification == null) { _specification = new Dch清掃予定台帳CBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Dch清掃予定台帳CQ> {
			protected BsDch清掃予定台帳CB _myCB;
			public MySpQyCall(BsDch清掃予定台帳CB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Dch清掃予定台帳CQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Dch清掃予定台帳CB> ColumnQuery(SpecifyQuery<Dch清掃予定台帳CB> leftSpecifyQuery) {
            return new HpColQyOperand<Dch清掃予定台帳CB>(delegate(SpecifyQuery<Dch清掃予定台帳CB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Dch清掃予定台帳CB xcreateColumnQueryCB() {
            Dch清掃予定台帳CB cb = new Dch清掃予定台帳CB();
            cb.xsetupForColumnQuery((Dch清掃予定台帳CB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Dch清掃予定台帳CB> orQuery) {
            xorQ((Dch清掃予定台帳CB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Dch清掃予定台帳CB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Dch清掃予定台帳CBColQySpQyCall(mainCB));
        }
    }

    public class Dch清掃予定台帳CBColQySpQyCall : HpSpQyCall<Dch清掃予定台帳CQ> {
        protected Dch清掃予定台帳CB _mainCB;
        public Dch清掃予定台帳CBColQySpQyCall(Dch清掃予定台帳CB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Dch清掃予定台帳CQ qy() { return _mainCB.Query(); } 
    }

    public class Dch清掃予定台帳CBSpecification : AbstractSpecification<Dch清掃予定台帳CQ> {
        protected Dch客室利用予定台帳CBSpecification _dch客室利用予定台帳;
        public Dch清掃予定台帳CBSpecification(ConditionBean baseCB, HpSpQyCall<Dch清掃予定台帳CQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnId() { doColumn("id"); }
        public void Column客室利用予定台帳id() { doColumn("客室利用予定台帳id"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnId(); // PK
            if (qyCall().qy().hasConditionQueryDch客室利用予定台帳()
                    || qyCall().qy().xgetReferrerQuery() is Dch客室利用予定台帳CQ) {
                Column客室利用予定台帳id(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "dch清掃予定台帳"; }
        public Dch客室利用予定台帳CBSpecification SpecifyDch客室利用予定台帳() {
            assertForeign("dch客室利用予定台帳");
            if (_dch客室利用予定台帳 == null) {
                _dch客室利用予定台帳 = new Dch客室利用予定台帳CBSpecification(_baseCB, new Dch客室利用予定台帳SpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _dch客室利用予定台帳.xsetSyncQyCall(new Dch客室利用予定台帳SpQyCall(xsyncQyCall())); }
            }
            return _dch客室利用予定台帳;
        }
		public class Dch客室利用予定台帳SpQyCall : HpSpQyCall<Dch客室利用予定台帳CQ> {
		    protected HpSpQyCall<Dch清掃予定台帳CQ> _qyCall;
		    public Dch客室利用予定台帳SpQyCall(HpSpQyCall<Dch清掃予定台帳CQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryDch客室利用予定台帳(); }
			public Dch客室利用予定台帳CQ qy() { return _qyCall.qy().QueryDch客室利用予定台帳(); }
		}
    }
}
