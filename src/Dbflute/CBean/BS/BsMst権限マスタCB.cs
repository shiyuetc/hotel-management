
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
    public class BsMst権限マスタCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mst権限マスタCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst権限マスタ"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String 職位コード, String 画面コード) {
            assertObjectNotNull("職位コード", 職位コード);assertObjectNotNull("画面コード", 画面コード);
            BsMst権限マスタCB cb = this;
            cb.Query().Set職位コード_Equal(職位コード);cb.Query().Set画面コード_Equal(画面コード);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_職位コード_Asc();
            Query().AddOrderBy_画面コード_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_職位コード_Desc();
            Query().AddOrderBy_画面コード_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public Mst権限マスタCQ Query() {
            return this.ConditionQuery;
        }

        public Mst権限マスタCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Mst権限マスタCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Mst権限マスタCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Mst権限マスタCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Mst権限マスタCB> unionQuery) {
            Mst権限マスタCB cb = new Mst権限マスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mst権限マスタCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Mst権限マスタCB> unionQuery) {
            Mst権限マスタCB cb = new Mst権限マスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mst権限マスタCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected Mst画面マスタNss _nssMst画面マスタ;
        public Mst画面マスタNss NssMst画面マスタ { get {
            if (_nssMst画面マスタ == null) { _nssMst画面マスタ = new Mst画面マスタNss(null); }
            return _nssMst画面マスタ;
        }}
        public Mst画面マスタNss SetupSelect_Mst画面マスタ() {
            doSetupSelect(delegate { return Query().QueryMst画面マスタ(); });
            if (_nssMst画面マスタ == null || !_nssMst画面マスタ.HasConditionQuery)
            { _nssMst画面マスタ = new Mst画面マスタNss(Query().QueryMst画面マスタ()); }
            return _nssMst画面マスタ;
        }
        protected Kbn職位区分Nss _nssKbn職位区分;
        public Kbn職位区分Nss NssKbn職位区分 { get {
            if (_nssKbn職位区分 == null) { _nssKbn職位区分 = new Kbn職位区分Nss(null); }
            return _nssKbn職位区分;
        }}
        public Kbn職位区分Nss SetupSelect_Kbn職位区分() {
            doSetupSelect(delegate { return Query().QueryKbn職位区分(); });
            if (_nssKbn職位区分 == null || !_nssKbn職位区分.HasConditionQuery)
            { _nssKbn職位区分 = new Kbn職位区分Nss(Query().QueryKbn職位区分()); }
            return _nssKbn職位区分;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected Mst権限マスタCBSpecification _specification;
        public Mst権限マスタCBSpecification Specify() {
            if (_specification == null) { _specification = new Mst権限マスタCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Mst権限マスタCQ> {
			protected BsMst権限マスタCB _myCB;
			public MySpQyCall(BsMst権限マスタCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Mst権限マスタCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Mst権限マスタCB> ColumnQuery(SpecifyQuery<Mst権限マスタCB> leftSpecifyQuery) {
            return new HpColQyOperand<Mst権限マスタCB>(delegate(SpecifyQuery<Mst権限マスタCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Mst権限マスタCB xcreateColumnQueryCB() {
            Mst権限マスタCB cb = new Mst権限マスタCB();
            cb.xsetupForColumnQuery((Mst権限マスタCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Mst権限マスタCB> orQuery) {
            xorQ((Mst権限マスタCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Mst権限マスタCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Mst権限マスタCBColQySpQyCall(mainCB));
        }
    }

    public class Mst権限マスタCBColQySpQyCall : HpSpQyCall<Mst権限マスタCQ> {
        protected Mst権限マスタCB _mainCB;
        public Mst権限マスタCBColQySpQyCall(Mst権限マスタCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Mst権限マスタCQ qy() { return _mainCB.Query(); } 
    }

    public class Mst権限マスタCBSpecification : AbstractSpecification<Mst権限マスタCQ> {
        protected Mst画面マスタCBSpecification _mst画面マスタ;
        protected Kbn職位区分CBSpecification _kbn職位区分;
        public Mst権限マスタCBSpecification(ConditionBean baseCB, HpSpQyCall<Mst権限マスタCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void Column職位コード() { doColumn("職位コード"); }
        public void Column画面コード() { doColumn("画面コード"); }
        protected override void doSpecifyRequiredColumn() {
            Column職位コード(); // PK
            Column画面コード(); // PK
        }
        protected override String getTableDbName() { return "mst権限マスタ"; }
        public Mst画面マスタCBSpecification SpecifyMst画面マスタ() {
            assertForeign("mst画面マスタ");
            if (_mst画面マスタ == null) {
                _mst画面マスタ = new Mst画面マスタCBSpecification(_baseCB, new Mst画面マスタSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _mst画面マスタ.xsetSyncQyCall(new Mst画面マスタSpQyCall(xsyncQyCall())); }
            }
            return _mst画面マスタ;
        }
		public class Mst画面マスタSpQyCall : HpSpQyCall<Mst画面マスタCQ> {
		    protected HpSpQyCall<Mst権限マスタCQ> _qyCall;
		    public Mst画面マスタSpQyCall(HpSpQyCall<Mst権限マスタCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMst画面マスタ(); }
			public Mst画面マスタCQ qy() { return _qyCall.qy().QueryMst画面マスタ(); }
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
		    protected HpSpQyCall<Mst権限マスタCQ> _qyCall;
		    public Kbn職位区分SpQyCall(HpSpQyCall<Mst権限マスタCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryKbn職位区分(); }
			public Kbn職位区分CQ qy() { return _qyCall.qy().QueryKbn職位区分(); }
		}
    }
}
