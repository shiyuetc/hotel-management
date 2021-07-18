
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
    public class BsDch従業員職位履歴台帳CB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Dch従業員職位履歴台帳CQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "dch従業員職位履歴台帳"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? id) {
            assertObjectNotNull("id", id);
            BsDch従業員職位履歴台帳CB cb = this;
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
        public Dch従業員職位履歴台帳CQ Query() {
            return this.ConditionQuery;
        }

        public Dch従業員職位履歴台帳CQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Dch従業員職位履歴台帳CQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Dch従業員職位履歴台帳CQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Dch従業員職位履歴台帳CQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Dch従業員職位履歴台帳CB> unionQuery) {
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Dch従業員職位履歴台帳CQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Dch従業員職位履歴台帳CB> unionQuery) {
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Dch従業員職位履歴台帳CQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected Mst従業員マスタNss _nssMst従業員マスタ;
        public Mst従業員マスタNss NssMst従業員マスタ { get {
            if (_nssMst従業員マスタ == null) { _nssMst従業員マスタ = new Mst従業員マスタNss(null); }
            return _nssMst従業員マスタ;
        }}
        public Mst従業員マスタNss SetupSelect_Mst従業員マスタ() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().Column従業員id();
            }
            doSetupSelect(delegate { return Query().QueryMst従業員マスタ(); });
            if (_nssMst従業員マスタ == null || !_nssMst従業員マスタ.HasConditionQuery)
            { _nssMst従業員マスタ = new Mst従業員マスタNss(Query().QueryMst従業員マスタ()); }
            return _nssMst従業員マスタ;
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
        protected Dch従業員職位履歴台帳CBSpecification _specification;
        public Dch従業員職位履歴台帳CBSpecification Specify() {
            if (_specification == null) { _specification = new Dch従業員職位履歴台帳CBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Dch従業員職位履歴台帳CQ> {
			protected BsDch従業員職位履歴台帳CB _myCB;
			public MySpQyCall(BsDch従業員職位履歴台帳CB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Dch従業員職位履歴台帳CQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Dch従業員職位履歴台帳CB> ColumnQuery(SpecifyQuery<Dch従業員職位履歴台帳CB> leftSpecifyQuery) {
            return new HpColQyOperand<Dch従業員職位履歴台帳CB>(delegate(SpecifyQuery<Dch従業員職位履歴台帳CB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Dch従業員職位履歴台帳CB xcreateColumnQueryCB() {
            Dch従業員職位履歴台帳CB cb = new Dch従業員職位履歴台帳CB();
            cb.xsetupForColumnQuery((Dch従業員職位履歴台帳CB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Dch従業員職位履歴台帳CB> orQuery) {
            xorQ((Dch従業員職位履歴台帳CB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Dch従業員職位履歴台帳CB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Dch従業員職位履歴台帳CBColQySpQyCall(mainCB));
        }
    }

    public class Dch従業員職位履歴台帳CBColQySpQyCall : HpSpQyCall<Dch従業員職位履歴台帳CQ> {
        protected Dch従業員職位履歴台帳CB _mainCB;
        public Dch従業員職位履歴台帳CBColQySpQyCall(Dch従業員職位履歴台帳CB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Dch従業員職位履歴台帳CQ qy() { return _mainCB.Query(); } 
    }

    public class Dch従業員職位履歴台帳CBSpecification : AbstractSpecification<Dch従業員職位履歴台帳CQ> {
        protected Mst従業員マスタCBSpecification _mst従業員マスタ;
        protected Kbn職位区分CBSpecification _kbn職位区分;
        public Dch従業員職位履歴台帳CBSpecification(ConditionBean baseCB, HpSpQyCall<Dch従業員職位履歴台帳CQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnId() { doColumn("id"); }
        public void Column従業員id() { doColumn("従業員id"); }
        public void Column適用開始日() { doColumn("適用開始日"); }
        public void Column適用終了日() { doColumn("適用終了日"); }
        public void Column職位コード() { doColumn("職位コード"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnId(); // PK
            if (qyCall().qy().hasConditionQueryMst従業員マスタ()
                    || qyCall().qy().xgetReferrerQuery() is Mst従業員マスタCQ) {
                Column従業員id(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryKbn職位区分()
                    || qyCall().qy().xgetReferrerQuery() is Kbn職位区分CQ) {
                Column職位コード(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "dch従業員職位履歴台帳"; }
        public Mst従業員マスタCBSpecification SpecifyMst従業員マスタ() {
            assertForeign("mst従業員マスタ");
            if (_mst従業員マスタ == null) {
                _mst従業員マスタ = new Mst従業員マスタCBSpecification(_baseCB, new Mst従業員マスタSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _mst従業員マスタ.xsetSyncQyCall(new Mst従業員マスタSpQyCall(xsyncQyCall())); }
            }
            return _mst従業員マスタ;
        }
		public class Mst従業員マスタSpQyCall : HpSpQyCall<Mst従業員マスタCQ> {
		    protected HpSpQyCall<Dch従業員職位履歴台帳CQ> _qyCall;
		    public Mst従業員マスタSpQyCall(HpSpQyCall<Dch従業員職位履歴台帳CQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMst従業員マスタ(); }
			public Mst従業員マスタCQ qy() { return _qyCall.qy().QueryMst従業員マスタ(); }
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
		    protected HpSpQyCall<Dch従業員職位履歴台帳CQ> _qyCall;
		    public Kbn職位区分SpQyCall(HpSpQyCall<Dch従業員職位履歴台帳CQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryKbn職位区分(); }
			public Kbn職位区分CQ qy() { return _qyCall.qy().QueryKbn職位区分(); }
		}
    }
}
