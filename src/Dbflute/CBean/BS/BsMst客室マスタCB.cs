
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
    public class BsMst客室マスタCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mst客室マスタCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst客室マスタ"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? id) {
            assertObjectNotNull("id", id);
            BsMst客室マスタCB cb = this;
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
        public Mst客室マスタCQ Query() {
            return this.ConditionQuery;
        }

        public Mst客室マスタCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Mst客室マスタCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Mst客室マスタCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Mst客室マスタCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Mst客室マスタCB> unionQuery) {
            Mst客室マスタCB cb = new Mst客室マスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mst客室マスタCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Mst客室マスタCB> unionQuery) {
            Mst客室マスタCB cb = new Mst客室マスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mst客室マスタCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected Mst客室タイプマスタNss _nssMst客室タイプマスタ;
        public Mst客室タイプマスタNss NssMst客室タイプマスタ { get {
            if (_nssMst客室タイプマスタ == null) { _nssMst客室タイプマスタ = new Mst客室タイプマスタNss(null); }
            return _nssMst客室タイプマスタ;
        }}
        public Mst客室タイプマスタNss SetupSelect_Mst客室タイプマスタ() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().Column客室タイプid();
            }
            doSetupSelect(delegate { return Query().QueryMst客室タイプマスタ(); });
            if (_nssMst客室タイプマスタ == null || !_nssMst客室タイプマスタ.HasConditionQuery)
            { _nssMst客室タイプマスタ = new Mst客室タイプマスタNss(Query().QueryMst客室タイプマスタ()); }
            return _nssMst客室タイプマスタ;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected Mst客室マスタCBSpecification _specification;
        public Mst客室マスタCBSpecification Specify() {
            if (_specification == null) { _specification = new Mst客室マスタCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Mst客室マスタCQ> {
			protected BsMst客室マスタCB _myCB;
			public MySpQyCall(BsMst客室マスタCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Mst客室マスタCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Mst客室マスタCB> ColumnQuery(SpecifyQuery<Mst客室マスタCB> leftSpecifyQuery) {
            return new HpColQyOperand<Mst客室マスタCB>(delegate(SpecifyQuery<Mst客室マスタCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Mst客室マスタCB xcreateColumnQueryCB() {
            Mst客室マスタCB cb = new Mst客室マスタCB();
            cb.xsetupForColumnQuery((Mst客室マスタCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Mst客室マスタCB> orQuery) {
            xorQ((Mst客室マスタCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Mst客室マスタCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Mst客室マスタCBColQySpQyCall(mainCB));
        }
    }

    public class Mst客室マスタCBColQySpQyCall : HpSpQyCall<Mst客室マスタCQ> {
        protected Mst客室マスタCB _mainCB;
        public Mst客室マスタCBColQySpQyCall(Mst客室マスタCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Mst客室マスタCQ qy() { return _mainCB.Query(); } 
    }

    public class Mst客室マスタCBSpecification : AbstractSpecification<Mst客室マスタCQ> {
        protected Mst客室タイプマスタCBSpecification _mst客室タイプマスタ;
        public Mst客室マスタCBSpecification(ConditionBean baseCB, HpSpQyCall<Mst客室マスタCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnId() { doColumn("id"); }
        public void Column客室番号() { doColumn("客室番号"); }
        public void Column客室タイプid() { doColumn("客室タイプid"); }
        public void Column喫煙() { doColumn("喫煙"); }
        public void Column備考() { doColumn("備考"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnId(); // PK
            if (qyCall().qy().hasConditionQueryMst客室タイプマスタ()
                    || qyCall().qy().xgetReferrerQuery() is Mst客室タイプマスタCQ) {
                Column客室タイプid(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "mst客室マスタ"; }
        public Mst客室タイプマスタCBSpecification SpecifyMst客室タイプマスタ() {
            assertForeign("mst客室タイプマスタ");
            if (_mst客室タイプマスタ == null) {
                _mst客室タイプマスタ = new Mst客室タイプマスタCBSpecification(_baseCB, new Mst客室タイプマスタSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _mst客室タイプマスタ.xsetSyncQyCall(new Mst客室タイプマスタSpQyCall(xsyncQyCall())); }
            }
            return _mst客室タイプマスタ;
        }
		public class Mst客室タイプマスタSpQyCall : HpSpQyCall<Mst客室タイプマスタCQ> {
		    protected HpSpQyCall<Mst客室マスタCQ> _qyCall;
		    public Mst客室タイプマスタSpQyCall(HpSpQyCall<Mst客室マスタCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMst客室タイプマスタ(); }
			public Mst客室タイプマスタCQ qy() { return _qyCall.qy().QueryMst客室タイプマスタ(); }
		}
        public RAFunction<Dch客室利用予定台帳CB, Mst客室マスタCQ> DerivedDch客室利用予定台帳List() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Dch客室利用予定台帳CB, Mst客室マスタCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Dch客室利用予定台帳CB> subQuery, Mst客室マスタCQ cq, String aliasName)
                { cq.xsderiveDch客室利用予定台帳List(function, subQuery, aliasName); });
        }
        public RAFunction<Dch客室利用実績台帳CB, Mst客室マスタCQ> DerivedDch客室利用実績台帳List() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Dch客室利用実績台帳CB, Mst客室マスタCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Dch客室利用実績台帳CB> subQuery, Mst客室マスタCQ cq, String aliasName)
                { cq.xsderiveDch客室利用実績台帳List(function, subQuery, aliasName); });
        }
    }
}
