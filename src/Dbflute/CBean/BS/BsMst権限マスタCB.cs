
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
        public void AcceptPrimaryKey(long? id) {
            assertObjectNotNull("id", id);
            BsMst権限マスタCB cb = this;
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
        protected Kbn権限区分Nss _nssKbn権限区分;
        public Kbn権限区分Nss NssKbn権限区分 { get {
            if (_nssKbn権限区分 == null) { _nssKbn権限区分 = new Kbn権限区分Nss(null); }
            return _nssKbn権限区分;
        }}
        public Kbn権限区分Nss SetupSelect_Kbn権限区分() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().Column権限コード();
            }
            doSetupSelect(delegate { return Query().QueryKbn権限区分(); });
            if (_nssKbn権限区分 == null || !_nssKbn権限区分.HasConditionQuery)
            { _nssKbn権限区分 = new Kbn権限区分Nss(Query().QueryKbn権限区分()); }
            return _nssKbn権限区分;
        }
        protected Kbn職位区分Nss _nssKbn職位区分;
        public Kbn職位区分Nss NssKbn職位区分 { get {
            if (_nssKbn職位区分 == null) { _nssKbn職位区分 = new Kbn職位区分Nss(null); }
            return _nssKbn職位区分;
        }}
        public Kbn職位区分Nss SetupSelect_Kbn職位区分() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().Column職位コード();
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
        protected Kbn権限区分CBSpecification _kbn権限区分;
        protected Kbn職位区分CBSpecification _kbn職位区分;
        public Mst権限マスタCBSpecification(ConditionBean baseCB, HpSpQyCall<Mst権限マスタCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnId() { doColumn("id"); }
        public void Column職位コード() { doColumn("職位コード"); }
        public void Column権限コード() { doColumn("権限コード"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnId(); // PK
            if (qyCall().qy().hasConditionQueryKbn権限区分()
                    || qyCall().qy().xgetReferrerQuery() is Kbn権限区分CQ) {
                Column権限コード(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryKbn職位区分()
                    || qyCall().qy().xgetReferrerQuery() is Kbn職位区分CQ) {
                Column職位コード(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "mst権限マスタ"; }
        public Kbn権限区分CBSpecification SpecifyKbn権限区分() {
            assertForeign("kbn権限区分");
            if (_kbn権限区分 == null) {
                _kbn権限区分 = new Kbn権限区分CBSpecification(_baseCB, new Kbn権限区分SpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _kbn権限区分.xsetSyncQyCall(new Kbn権限区分SpQyCall(xsyncQyCall())); }
            }
            return _kbn権限区分;
        }
		public class Kbn権限区分SpQyCall : HpSpQyCall<Kbn権限区分CQ> {
		    protected HpSpQyCall<Mst権限マスタCQ> _qyCall;
		    public Kbn権限区分SpQyCall(HpSpQyCall<Mst権限マスタCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryKbn権限区分(); }
			public Kbn権限区分CQ qy() { return _qyCall.qy().QueryKbn権限区分(); }
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
