
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
    public class BsMstメニュー権限マスタCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mstメニュー権限マスタCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mstメニュー権限マスタ"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? id) {
            assertObjectNotNull("id", id);
            BsMstメニュー権限マスタCB cb = this;
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
        public Mstメニュー権限マスタCQ Query() {
            return this.ConditionQuery;
        }

        public Mstメニュー権限マスタCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Mstメニュー権限マスタCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Mstメニュー権限マスタCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Mstメニュー権限マスタCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Mstメニュー権限マスタCB> unionQuery) {
            Mstメニュー権限マスタCB cb = new Mstメニュー権限マスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mstメニュー権限マスタCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Mstメニュー権限マスタCB> unionQuery) {
            Mstメニュー権限マスタCB cb = new Mstメニュー権限マスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mstメニュー権限マスタCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected Mst制御画面マスタNss _nssMst制御画面マスタ;
        public Mst制御画面マスタNss NssMst制御画面マスタ { get {
            if (_nssMst制御画面マスタ == null) { _nssMst制御画面マスタ = new Mst制御画面マスタNss(null); }
            return _nssMst制御画面マスタ;
        }}
        public Mst制御画面マスタNss SetupSelect_Mst制御画面マスタ() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().Column制御画面id();
            }
            doSetupSelect(delegate { return Query().QueryMst制御画面マスタ(); });
            if (_nssMst制御画面マスタ == null || !_nssMst制御画面マスタ.HasConditionQuery)
            { _nssMst制御画面マスタ = new Mst制御画面マスタNss(Query().QueryMst制御画面マスタ()); }
            return _nssMst制御画面マスタ;
        }
        protected Kbn職位区分Nss _nssKbn職位区分;
        public Kbn職位区分Nss NssKbn職位区分 { get {
            if (_nssKbn職位区分 == null) { _nssKbn職位区分 = new Kbn職位区分Nss(null); }
            return _nssKbn職位区分;
        }}
        public Kbn職位区分Nss SetupSelect_Kbn職位区分() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().Column職位code();
            }
            doSetupSelect(delegate { return Query().QueryKbn職位区分(); });
            if (_nssKbn職位区分 == null || !_nssKbn職位区分.HasConditionQuery)
            { _nssKbn職位区分 = new Kbn職位区分Nss(Query().QueryKbn職位区分()); }
            return _nssKbn職位区分;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected Mstメニュー権限マスタCBSpecification _specification;
        public Mstメニュー権限マスタCBSpecification Specify() {
            if (_specification == null) { _specification = new Mstメニュー権限マスタCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Mstメニュー権限マスタCQ> {
			protected BsMstメニュー権限マスタCB _myCB;
			public MySpQyCall(BsMstメニュー権限マスタCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Mstメニュー権限マスタCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Mstメニュー権限マスタCB> ColumnQuery(SpecifyQuery<Mstメニュー権限マスタCB> leftSpecifyQuery) {
            return new HpColQyOperand<Mstメニュー権限マスタCB>(delegate(SpecifyQuery<Mstメニュー権限マスタCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Mstメニュー権限マスタCB xcreateColumnQueryCB() {
            Mstメニュー権限マスタCB cb = new Mstメニュー権限マスタCB();
            cb.xsetupForColumnQuery((Mstメニュー権限マスタCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Mstメニュー権限マスタCB> orQuery) {
            xorQ((Mstメニュー権限マスタCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Mstメニュー権限マスタCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Mstメニュー権限マスタCBColQySpQyCall(mainCB));
        }
    }

    public class Mstメニュー権限マスタCBColQySpQyCall : HpSpQyCall<Mstメニュー権限マスタCQ> {
        protected Mstメニュー権限マスタCB _mainCB;
        public Mstメニュー権限マスタCBColQySpQyCall(Mstメニュー権限マスタCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Mstメニュー権限マスタCQ qy() { return _mainCB.Query(); } 
    }

    public class Mstメニュー権限マスタCBSpecification : AbstractSpecification<Mstメニュー権限マスタCQ> {
        protected Mst制御画面マスタCBSpecification _mst制御画面マスタ;
        protected Kbn職位区分CBSpecification _kbn職位区分;
        public Mstメニュー権限マスタCBSpecification(ConditionBean baseCB, HpSpQyCall<Mstメニュー権限マスタCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnId() { doColumn("id"); }
        public void Column職位code() { doColumn("職位code"); }
        public void Column制御画面id() { doColumn("制御画面id"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnId(); // PK
            if (qyCall().qy().hasConditionQueryMst制御画面マスタ()
                    || qyCall().qy().xgetReferrerQuery() is Mst制御画面マスタCQ) {
                Column制御画面id(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryKbn職位区分()
                    || qyCall().qy().xgetReferrerQuery() is Kbn職位区分CQ) {
                Column職位code(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "mstメニュー権限マスタ"; }
        public Mst制御画面マスタCBSpecification SpecifyMst制御画面マスタ() {
            assertForeign("mst制御画面マスタ");
            if (_mst制御画面マスタ == null) {
                _mst制御画面マスタ = new Mst制御画面マスタCBSpecification(_baseCB, new Mst制御画面マスタSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _mst制御画面マスタ.xsetSyncQyCall(new Mst制御画面マスタSpQyCall(xsyncQyCall())); }
            }
            return _mst制御画面マスタ;
        }
		public class Mst制御画面マスタSpQyCall : HpSpQyCall<Mst制御画面マスタCQ> {
		    protected HpSpQyCall<Mstメニュー権限マスタCQ> _qyCall;
		    public Mst制御画面マスタSpQyCall(HpSpQyCall<Mstメニュー権限マスタCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMst制御画面マスタ(); }
			public Mst制御画面マスタCQ qy() { return _qyCall.qy().QueryMst制御画面マスタ(); }
		}
        public Kbn職位区分CBSpecification SpecifyKbn職位区分() {
            assertForeign("kbn職位区分");
            if (_kbn職位区分 == null) {
                _kbn職位区分 = new Kbn職位区分CBSpecification(_baseCB, new Kbn職位区分SpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _kbn職位区分.xsetSyncQyCall(new Kbn職位区分SpQyCall(xsyncQyCall())); }
            }
            return _kbn職位区分;
        }
		public class Kbn職位区分SpQyCall : HpSpQyCall<Kbn職位区分CQ> {
		    protected HpSpQyCall<Mstメニュー権限マスタCQ> _qyCall;
		    public Kbn職位区分SpQyCall(HpSpQyCall<Mstメニュー権限マスタCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryKbn職位区分(); }
			public Kbn職位区分CQ qy() { return _qyCall.qy().QueryKbn職位区分(); }
		}
    }
}
