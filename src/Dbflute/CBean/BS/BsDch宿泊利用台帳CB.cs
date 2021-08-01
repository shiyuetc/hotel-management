
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
    public class BsDch宿泊利用台帳CB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Dch宿泊利用台帳CQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "dch宿泊利用台帳"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? 客室利用台帳id) {
            assertObjectNotNull("客室利用台帳id", 客室利用台帳id);
            BsDch宿泊利用台帳CB cb = this;
            cb.Query().Set客室利用台帳id_Equal(客室利用台帳id);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_客室利用台帳id_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_客室利用台帳id_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public Dch宿泊利用台帳CQ Query() {
            return this.ConditionQuery;
        }

        public Dch宿泊利用台帳CQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Dch宿泊利用台帳CQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Dch宿泊利用台帳CQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Dch宿泊利用台帳CQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Dch宿泊利用台帳CB> unionQuery) {
            Dch宿泊利用台帳CB cb = new Dch宿泊利用台帳CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Dch宿泊利用台帳CQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Dch宿泊利用台帳CB> unionQuery) {
            Dch宿泊利用台帳CB cb = new Dch宿泊利用台帳CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Dch宿泊利用台帳CQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected Mst会員マスタNss _nssMst会員マスタ;
        public Mst会員マスタNss NssMst会員マスタ { get {
            if (_nssMst会員マスタ == null) { _nssMst会員マスタ = new Mst会員マスタNss(null); }
            return _nssMst会員マスタ;
        }}
        public Mst会員マスタNss SetupSelect_Mst会員マスタ() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().Column会員コード();
            }
            doSetupSelect(delegate { return Query().QueryMst会員マスタ(); });
            if (_nssMst会員マスタ == null || !_nssMst会員マスタ.HasConditionQuery)
            { _nssMst会員マスタ = new Mst会員マスタNss(Query().QueryMst会員マスタ()); }
            return _nssMst会員マスタ;
        }
        protected Dch客室利用台帳Nss _nssDch客室利用台帳;
        public Dch客室利用台帳Nss NssDch客室利用台帳 { get {
            if (_nssDch客室利用台帳 == null) { _nssDch客室利用台帳 = new Dch客室利用台帳Nss(null); }
            return _nssDch客室利用台帳;
        }}
        public Dch客室利用台帳Nss SetupSelect_Dch客室利用台帳() {
            doSetupSelect(delegate { return Query().QueryDch客室利用台帳(); });
            if (_nssDch客室利用台帳 == null || !_nssDch客室利用台帳.HasConditionQuery)
            { _nssDch客室利用台帳 = new Dch客室利用台帳Nss(Query().QueryDch客室利用台帳()); }
            return _nssDch客室利用台帳;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected Dch宿泊利用台帳CBSpecification _specification;
        public Dch宿泊利用台帳CBSpecification Specify() {
            if (_specification == null) { _specification = new Dch宿泊利用台帳CBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Dch宿泊利用台帳CQ> {
			protected BsDch宿泊利用台帳CB _myCB;
			public MySpQyCall(BsDch宿泊利用台帳CB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Dch宿泊利用台帳CQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Dch宿泊利用台帳CB> ColumnQuery(SpecifyQuery<Dch宿泊利用台帳CB> leftSpecifyQuery) {
            return new HpColQyOperand<Dch宿泊利用台帳CB>(delegate(SpecifyQuery<Dch宿泊利用台帳CB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Dch宿泊利用台帳CB xcreateColumnQueryCB() {
            Dch宿泊利用台帳CB cb = new Dch宿泊利用台帳CB();
            cb.xsetupForColumnQuery((Dch宿泊利用台帳CB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Dch宿泊利用台帳CB> orQuery) {
            xorQ((Dch宿泊利用台帳CB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Dch宿泊利用台帳CB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Dch宿泊利用台帳CBColQySpQyCall(mainCB));
        }
    }

    public class Dch宿泊利用台帳CBColQySpQyCall : HpSpQyCall<Dch宿泊利用台帳CQ> {
        protected Dch宿泊利用台帳CB _mainCB;
        public Dch宿泊利用台帳CBColQySpQyCall(Dch宿泊利用台帳CB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Dch宿泊利用台帳CQ qy() { return _mainCB.Query(); } 
    }

    public class Dch宿泊利用台帳CBSpecification : AbstractSpecification<Dch宿泊利用台帳CQ> {
        protected Mst会員マスタCBSpecification _mst会員マスタ;
        protected Dch客室利用台帳CBSpecification _dch客室利用台帳;
        public Dch宿泊利用台帳CBSpecification(ConditionBean baseCB, HpSpQyCall<Dch宿泊利用台帳CQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void Column客室利用台帳id() { doColumn("客室利用台帳id"); }
        public void Column会員コード() { doColumn("会員コード"); }
        public void Column宿泊料金() { doColumn("宿泊料金"); }
        protected override void doSpecifyRequiredColumn() {
            Column客室利用台帳id(); // PK
            if (qyCall().qy().hasConditionQueryMst会員マスタ()
                    || qyCall().qy().xgetReferrerQuery() is Mst会員マスタCQ) {
                Column会員コード(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "dch宿泊利用台帳"; }
        public Mst会員マスタCBSpecification SpecifyMst会員マスタ() {
            assertForeign("mst会員マスタ");
            if (_mst会員マスタ == null) {
                _mst会員マスタ = new Mst会員マスタCBSpecification(_baseCB, new Mst会員マスタSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _mst会員マスタ.xsetSyncQyCall(new Mst会員マスタSpQyCall(xsyncQyCall())); }
            }
            return _mst会員マスタ;
        }
		public class Mst会員マスタSpQyCall : HpSpQyCall<Mst会員マスタCQ> {
		    protected HpSpQyCall<Dch宿泊利用台帳CQ> _qyCall;
		    public Mst会員マスタSpQyCall(HpSpQyCall<Dch宿泊利用台帳CQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMst会員マスタ(); }
			public Mst会員マスタCQ qy() { return _qyCall.qy().QueryMst会員マスタ(); }
		}
        public Dch客室利用台帳CBSpecification SpecifyDch客室利用台帳() {
            assertForeign("dch客室利用台帳");
            if (_dch客室利用台帳 == null) {
                _dch客室利用台帳 = new Dch客室利用台帳CBSpecification(_baseCB, new Dch客室利用台帳SpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _dch客室利用台帳.xsetSyncQyCall(new Dch客室利用台帳SpQyCall(xsyncQyCall())); }
            }
            return _dch客室利用台帳;
        }
		public class Dch客室利用台帳SpQyCall : HpSpQyCall<Dch客室利用台帳CQ> {
		    protected HpSpQyCall<Dch宿泊利用台帳CQ> _qyCall;
		    public Dch客室利用台帳SpQyCall(HpSpQyCall<Dch宿泊利用台帳CQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryDch客室利用台帳(); }
			public Dch客室利用台帳CQ qy() { return _qyCall.qy().QueryDch客室利用台帳(); }
		}
    }
}
