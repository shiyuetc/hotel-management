
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
    public class BsMst画面マスタCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mst画面マスタCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst画面マスタ"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String 画面コード) {
            assertObjectNotNull("画面コード", 画面コード);
            BsMst画面マスタCB cb = this;
            cb.Query().Set画面コード_Equal(画面コード);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_画面コード_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_画面コード_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public Mst画面マスタCQ Query() {
            return this.ConditionQuery;
        }

        public Mst画面マスタCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Mst画面マスタCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Mst画面マスタCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Mst画面マスタCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Mst画面マスタCB> unionQuery) {
            Mst画面マスタCB cb = new Mst画面マスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mst画面マスタCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Mst画面マスタCB> unionQuery) {
            Mst画面マスタCB cb = new Mst画面マスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mst画面マスタCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected Kbnメニュー区分Nss _nssKbnメニュー区分;
        public Kbnメニュー区分Nss NssKbnメニュー区分 { get {
            if (_nssKbnメニュー区分 == null) { _nssKbnメニュー区分 = new Kbnメニュー区分Nss(null); }
            return _nssKbnメニュー区分;
        }}
        public Kbnメニュー区分Nss SetupSelect_Kbnメニュー区分() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().Columnメニューコード();
            }
            doSetupSelect(delegate { return Query().QueryKbnメニュー区分(); });
            if (_nssKbnメニュー区分 == null || !_nssKbnメニュー区分.HasConditionQuery)
            { _nssKbnメニュー区分 = new Kbnメニュー区分Nss(Query().QueryKbnメニュー区分()); }
            return _nssKbnメニュー区分;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected Mst画面マスタCBSpecification _specification;
        public Mst画面マスタCBSpecification Specify() {
            if (_specification == null) { _specification = new Mst画面マスタCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Mst画面マスタCQ> {
			protected BsMst画面マスタCB _myCB;
			public MySpQyCall(BsMst画面マスタCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Mst画面マスタCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Mst画面マスタCB> ColumnQuery(SpecifyQuery<Mst画面マスタCB> leftSpecifyQuery) {
            return new HpColQyOperand<Mst画面マスタCB>(delegate(SpecifyQuery<Mst画面マスタCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Mst画面マスタCB xcreateColumnQueryCB() {
            Mst画面マスタCB cb = new Mst画面マスタCB();
            cb.xsetupForColumnQuery((Mst画面マスタCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Mst画面マスタCB> orQuery) {
            xorQ((Mst画面マスタCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Mst画面マスタCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Mst画面マスタCBColQySpQyCall(mainCB));
        }
    }

    public class Mst画面マスタCBColQySpQyCall : HpSpQyCall<Mst画面マスタCQ> {
        protected Mst画面マスタCB _mainCB;
        public Mst画面マスタCBColQySpQyCall(Mst画面マスタCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Mst画面マスタCQ qy() { return _mainCB.Query(); } 
    }

    public class Mst画面マスタCBSpecification : AbstractSpecification<Mst画面マスタCQ> {
        protected Kbnメニュー区分CBSpecification _kbnメニュー区分;
        public Mst画面マスタCBSpecification(ConditionBean baseCB, HpSpQyCall<Mst画面マスタCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void Column画面コード() { doColumn("画面コード"); }
        public void Columnメニューコード() { doColumn("メニューコード"); }
        public void Column画面名称() { doColumn("画面名称"); }
        public void Column優先順位() { doColumn("優先順位"); }
        protected override void doSpecifyRequiredColumn() {
            Column画面コード(); // PK
            if (qyCall().qy().hasConditionQueryKbnメニュー区分()
                    || qyCall().qy().xgetReferrerQuery() is Kbnメニュー区分CQ) {
                Columnメニューコード(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "mst画面マスタ"; }
        public Kbnメニュー区分CBSpecification SpecifyKbnメニュー区分() {
            assertForeign("kbnメニュー区分");
            if (_kbnメニュー区分 == null) {
                _kbnメニュー区分 = new Kbnメニュー区分CBSpecification(_baseCB, new Kbnメニュー区分SpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _kbnメニュー区分.xsetSyncQyCall(new Kbnメニュー区分SpQyCall(xsyncQyCall())); }
            }
            return _kbnメニュー区分;
        }
		public class Kbnメニュー区分SpQyCall : HpSpQyCall<Kbnメニュー区分CQ> {
		    protected HpSpQyCall<Mst画面マスタCQ> _qyCall;
		    public Kbnメニュー区分SpQyCall(HpSpQyCall<Mst画面マスタCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryKbnメニュー区分(); }
			public Kbnメニュー区分CQ qy() { return _qyCall.qy().QueryKbnメニュー区分(); }
		}
        public RAFunction<Mst権限マスタCB, Mst画面マスタCQ> DerivedMst権限マスタList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Mst権限マスタCB, Mst画面マスタCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Mst権限マスタCB> subQuery, Mst画面マスタCQ cq, String aliasName)
                { cq.xsderiveMst権限マスタList(function, subQuery, aliasName); });
        }
    }
}
