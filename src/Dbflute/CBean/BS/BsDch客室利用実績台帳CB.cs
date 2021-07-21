
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
    public class BsDch客室利用実績台帳CB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Dch客室利用実績台帳CQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "dch客室利用実績台帳"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? id) {
            assertObjectNotNull("id", id);
            BsDch客室利用実績台帳CB cb = this;
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
        public Dch客室利用実績台帳CQ Query() {
            return this.ConditionQuery;
        }

        public Dch客室利用実績台帳CQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Dch客室利用実績台帳CQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Dch客室利用実績台帳CQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Dch客室利用実績台帳CQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Dch客室利用実績台帳CB> unionQuery) {
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Dch客室利用実績台帳CQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Dch客室利用実績台帳CB> unionQuery) {
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Dch客室利用実績台帳CQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected Mst客室マスタNss _nssMst客室マスタ;
        public Mst客室マスタNss NssMst客室マスタ { get {
            if (_nssMst客室マスタ == null) { _nssMst客室マスタ = new Mst客室マスタNss(null); }
            return _nssMst客室マスタ;
        }}
        public Mst客室マスタNss SetupSelect_Mst客室マスタ() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().Column客室マスタid();
            }
            doSetupSelect(delegate { return Query().QueryMst客室マスタ(); });
            if (_nssMst客室マスタ == null || !_nssMst客室マスタ.HasConditionQuery)
            { _nssMst客室マスタ = new Mst客室マスタNss(Query().QueryMst客室マスタ()); }
            return _nssMst客室マスタ;
        }
        protected Kbn客室利用区分Nss _nssKbn客室利用区分;
        public Kbn客室利用区分Nss NssKbn客室利用区分 { get {
            if (_nssKbn客室利用区分 == null) { _nssKbn客室利用区分 = new Kbn客室利用区分Nss(null); }
            return _nssKbn客室利用区分;
        }}
        public Kbn客室利用区分Nss SetupSelect_Kbn客室利用区分() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().Column客室利用code();
            }
            doSetupSelect(delegate { return Query().QueryKbn客室利用区分(); });
            if (_nssKbn客室利用区分 == null || !_nssKbn客室利用区分.HasConditionQuery)
            { _nssKbn客室利用区分 = new Kbn客室利用区分Nss(Query().QueryKbn客室利用区分()); }
            return _nssKbn客室利用区分;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected Dch客室利用実績台帳CBSpecification _specification;
        public Dch客室利用実績台帳CBSpecification Specify() {
            if (_specification == null) { _specification = new Dch客室利用実績台帳CBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Dch客室利用実績台帳CQ> {
			protected BsDch客室利用実績台帳CB _myCB;
			public MySpQyCall(BsDch客室利用実績台帳CB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Dch客室利用実績台帳CQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Dch客室利用実績台帳CB> ColumnQuery(SpecifyQuery<Dch客室利用実績台帳CB> leftSpecifyQuery) {
            return new HpColQyOperand<Dch客室利用実績台帳CB>(delegate(SpecifyQuery<Dch客室利用実績台帳CB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Dch客室利用実績台帳CB xcreateColumnQueryCB() {
            Dch客室利用実績台帳CB cb = new Dch客室利用実績台帳CB();
            cb.xsetupForColumnQuery((Dch客室利用実績台帳CB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Dch客室利用実績台帳CB> orQuery) {
            xorQ((Dch客室利用実績台帳CB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Dch客室利用実績台帳CB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Dch客室利用実績台帳CBColQySpQyCall(mainCB));
        }
    }

    public class Dch客室利用実績台帳CBColQySpQyCall : HpSpQyCall<Dch客室利用実績台帳CQ> {
        protected Dch客室利用実績台帳CB _mainCB;
        public Dch客室利用実績台帳CBColQySpQyCall(Dch客室利用実績台帳CB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Dch客室利用実績台帳CQ qy() { return _mainCB.Query(); } 
    }

    public class Dch客室利用実績台帳CBSpecification : AbstractSpecification<Dch客室利用実績台帳CQ> {
        protected Mst客室マスタCBSpecification _mst客室マスタ;
        protected Kbn客室利用区分CBSpecification _kbn客室利用区分;
        public Dch客室利用実績台帳CBSpecification(ConditionBean baseCB, HpSpQyCall<Dch客室利用実績台帳CQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnId() { doColumn("id"); }
        public void Column客室マスタid() { doColumn("客室マスタid"); }
        public void Column客室利用code() { doColumn("客室利用code"); }
        public void Column利用開始日時() { doColumn("利用開始日時"); }
        public void Column利用終了日時() { doColumn("利用終了日時"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnId(); // PK
            if (qyCall().qy().hasConditionQueryMst客室マスタ()
                    || qyCall().qy().xgetReferrerQuery() is Mst客室マスタCQ) {
                Column客室マスタid(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryKbn客室利用区分()
                    || qyCall().qy().xgetReferrerQuery() is Kbn客室利用区分CQ) {
                Column客室利用code(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "dch客室利用実績台帳"; }
        public Mst客室マスタCBSpecification SpecifyMst客室マスタ() {
            assertForeign("mst客室マスタ");
            if (_mst客室マスタ == null) {
                _mst客室マスタ = new Mst客室マスタCBSpecification(_baseCB, new Mst客室マスタSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _mst客室マスタ.xsetSyncQyCall(new Mst客室マスタSpQyCall(xsyncQyCall())); }
            }
            return _mst客室マスタ;
        }
		public class Mst客室マスタSpQyCall : HpSpQyCall<Mst客室マスタCQ> {
		    protected HpSpQyCall<Dch客室利用実績台帳CQ> _qyCall;
		    public Mst客室マスタSpQyCall(HpSpQyCall<Dch客室利用実績台帳CQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMst客室マスタ(); }
			public Mst客室マスタCQ qy() { return _qyCall.qy().QueryMst客室マスタ(); }
		}
        public Kbn客室利用区分CBSpecification SpecifyKbn客室利用区分() {
            assertForeign("kbn客室利用区分");
            if (_kbn客室利用区分 == null) {
                _kbn客室利用区分 = new Kbn客室利用区分CBSpecification(_baseCB, new Kbn客室利用区分SpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _kbn客室利用区分.xsetSyncQyCall(new Kbn客室利用区分SpQyCall(xsyncQyCall())); }
            }
            return _kbn客室利用区分;
        }
		public class Kbn客室利用区分SpQyCall : HpSpQyCall<Kbn客室利用区分CQ> {
		    protected HpSpQyCall<Dch客室利用実績台帳CQ> _qyCall;
		    public Kbn客室利用区分SpQyCall(HpSpQyCall<Dch客室利用実績台帳CQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryKbn客室利用区分(); }
			public Kbn客室利用区分CQ qy() { return _qyCall.qy().QueryKbn客室利用区分(); }
		}
        public RAFunction<Dchその他実績台帳CB, Dch客室利用実績台帳CQ> DerivedDchその他実績台帳List() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Dchその他実績台帳CB, Dch客室利用実績台帳CQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Dchその他実績台帳CB> subQuery, Dch客室利用実績台帳CQ cq, String aliasName)
                { cq.xsderiveDchその他実績台帳List(function, subQuery, aliasName); });
        }
        public RAFunction<Dch宿泊実績台帳CB, Dch客室利用実績台帳CQ> DerivedDch宿泊実績台帳List() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Dch宿泊実績台帳CB, Dch客室利用実績台帳CQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Dch宿泊実績台帳CB> subQuery, Dch客室利用実績台帳CQ cq, String aliasName)
                { cq.xsderiveDch宿泊実績台帳List(function, subQuery, aliasName); });
        }
        public RAFunction<Dch清掃実績台帳CB, Dch客室利用実績台帳CQ> DerivedDch清掃実績台帳List() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Dch清掃実績台帳CB, Dch客室利用実績台帳CQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Dch清掃実績台帳CB> subQuery, Dch客室利用実績台帳CQ cq, String aliasName)
                { cq.xsderiveDch清掃実績台帳List(function, subQuery, aliasName); });
        }
    }
}
