
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
    public class BsDch客室利用台帳CB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Dch客室利用台帳CQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "dch客室利用台帳"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? id) {
            assertObjectNotNull("id", id);
            BsDch客室利用台帳CB cb = this;
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
        public Dch客室利用台帳CQ Query() {
            return this.ConditionQuery;
        }

        public Dch客室利用台帳CQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Dch客室利用台帳CQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Dch客室利用台帳CQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Dch客室利用台帳CQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Dch客室利用台帳CB> unionQuery) {
            Dch客室利用台帳CB cb = new Dch客室利用台帳CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Dch客室利用台帳CQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Dch客室利用台帳CB> unionQuery) {
            Dch客室利用台帳CB cb = new Dch客室利用台帳CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Dch客室利用台帳CQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
                Specify().Column客室コード();
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
                Specify().Column客室利用コード();
            }
            doSetupSelect(delegate { return Query().QueryKbn客室利用区分(); });
            if (_nssKbn客室利用区分 == null || !_nssKbn客室利用区分.HasConditionQuery)
            { _nssKbn客室利用区分 = new Kbn客室利用区分Nss(Query().QueryKbn客室利用区分()); }
            return _nssKbn客室利用区分;
        }

        protected Dch宿泊利用台帳Nss _nssDch宿泊利用台帳AsOne;
        public Dch宿泊利用台帳Nss NssDch宿泊利用台帳AsOne { get {
            if (_nssDch宿泊利用台帳AsOne == null) { _nssDch宿泊利用台帳AsOne = new Dch宿泊利用台帳Nss(null); }
            return _nssDch宿泊利用台帳AsOne;
        }}
        public Dch宿泊利用台帳Nss SetupSelect_Dch宿泊利用台帳AsOne() {
            doSetupSelect(delegate { return Query().QueryDch宿泊利用台帳AsOne(); });
            if (_nssDch宿泊利用台帳AsOne == null || !_nssDch宿泊利用台帳AsOne.HasConditionQuery)
            { _nssDch宿泊利用台帳AsOne = new Dch宿泊利用台帳Nss(Query().QueryDch宿泊利用台帳AsOne()); }
            return _nssDch宿泊利用台帳AsOne;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected Dch客室利用台帳CBSpecification _specification;
        public Dch客室利用台帳CBSpecification Specify() {
            if (_specification == null) { _specification = new Dch客室利用台帳CBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Dch客室利用台帳CQ> {
			protected BsDch客室利用台帳CB _myCB;
			public MySpQyCall(BsDch客室利用台帳CB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Dch客室利用台帳CQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Dch客室利用台帳CB> ColumnQuery(SpecifyQuery<Dch客室利用台帳CB> leftSpecifyQuery) {
            return new HpColQyOperand<Dch客室利用台帳CB>(delegate(SpecifyQuery<Dch客室利用台帳CB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Dch客室利用台帳CB xcreateColumnQueryCB() {
            Dch客室利用台帳CB cb = new Dch客室利用台帳CB();
            cb.xsetupForColumnQuery((Dch客室利用台帳CB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Dch客室利用台帳CB> orQuery) {
            xorQ((Dch客室利用台帳CB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Dch客室利用台帳CB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Dch客室利用台帳CBColQySpQyCall(mainCB));
        }
    }

    public class Dch客室利用台帳CBColQySpQyCall : HpSpQyCall<Dch客室利用台帳CQ> {
        protected Dch客室利用台帳CB _mainCB;
        public Dch客室利用台帳CBColQySpQyCall(Dch客室利用台帳CB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Dch客室利用台帳CQ qy() { return _mainCB.Query(); } 
    }

    public class Dch客室利用台帳CBSpecification : AbstractSpecification<Dch客室利用台帳CQ> {
        protected Mst客室マスタCBSpecification _mst客室マスタ;
        protected Kbn客室利用区分CBSpecification _kbn客室利用区分;
        protected Dch宿泊利用台帳CBSpecification _dch宿泊利用台帳AsOne;
        public Dch客室利用台帳CBSpecification(ConditionBean baseCB, HpSpQyCall<Dch客室利用台帳CQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnId() { doColumn("id"); }
        public void Column客室利用コード() { doColumn("客室利用コード"); }
        public void Column客室コード() { doColumn("客室コード"); }
        public void Column開始予定日時() { doColumn("開始予定日時"); }
        public void Column終了予定日時() { doColumn("終了予定日時"); }
        public void Column開始実績日時() { doColumn("開始実績日時"); }
        public void Column終了実績日時() { doColumn("終了実績日時"); }
        public void Column備考() { doColumn("備考"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnId(); // PK
            if (qyCall().qy().hasConditionQueryMst客室マスタ()
                    || qyCall().qy().xgetReferrerQuery() is Mst客室マスタCQ) {
                Column客室コード(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryKbn客室利用区分()
                    || qyCall().qy().xgetReferrerQuery() is Kbn客室利用区分CQ) {
                Column客室利用コード(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "dch客室利用台帳"; }
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
		    protected HpSpQyCall<Dch客室利用台帳CQ> _qyCall;
		    public Mst客室マスタSpQyCall(HpSpQyCall<Dch客室利用台帳CQ> myQyCall) { _qyCall = myQyCall; }
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
		    protected HpSpQyCall<Dch客室利用台帳CQ> _qyCall;
		    public Kbn客室利用区分SpQyCall(HpSpQyCall<Dch客室利用台帳CQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryKbn客室利用区分(); }
			public Kbn客室利用区分CQ qy() { return _qyCall.qy().QueryKbn客室利用区分(); }
		}
        public Dch宿泊利用台帳CBSpecification SpecifyDch宿泊利用台帳AsOne() {
            assertForeign("dch宿泊利用台帳AsOne");
            if (_dch宿泊利用台帳AsOne == null) {
                _dch宿泊利用台帳AsOne = new Dch宿泊利用台帳CBSpecification(_baseCB, new Dch宿泊利用台帳AsOneSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _dch宿泊利用台帳AsOne.xsetSyncQyCall(new Dch宿泊利用台帳AsOneSpQyCall(xsyncQyCall())); }
            }
            return _dch宿泊利用台帳AsOne;
        }
		public class Dch宿泊利用台帳AsOneSpQyCall : HpSpQyCall<Dch宿泊利用台帳CQ> {
		    protected HpSpQyCall<Dch客室利用台帳CQ> _qyCall;
		    public Dch宿泊利用台帳AsOneSpQyCall(HpSpQyCall<Dch客室利用台帳CQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryDch宿泊利用台帳AsOne(); }
			public Dch宿泊利用台帳CQ qy() { return _qyCall.qy().QueryDch宿泊利用台帳AsOne(); }
		}
    }
}
