
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
    public class BsMst従業員マスタCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mst従業員マスタCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst従業員マスタ"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? id) {
            assertObjectNotNull("id", id);
            BsMst従業員マスタCB cb = this;
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
        public Mst従業員マスタCQ Query() {
            return this.ConditionQuery;
        }

        public Mst従業員マスタCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Mst従業員マスタCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Mst従業員マスタCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Mst従業員マスタCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Mst従業員マスタCB> unionQuery) {
            Mst従業員マスタCB cb = new Mst従業員マスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mst従業員マスタCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Mst従業員マスタCB> unionQuery) {
            Mst従業員マスタCB cb = new Mst従業員マスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mst従業員マスタCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
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
        protected Mst従業員マスタCBSpecification _specification;
        public Mst従業員マスタCBSpecification Specify() {
            if (_specification == null) { _specification = new Mst従業員マスタCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Mst従業員マスタCQ> {
			protected BsMst従業員マスタCB _myCB;
			public MySpQyCall(BsMst従業員マスタCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Mst従業員マスタCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Mst従業員マスタCB> ColumnQuery(SpecifyQuery<Mst従業員マスタCB> leftSpecifyQuery) {
            return new HpColQyOperand<Mst従業員マスタCB>(delegate(SpecifyQuery<Mst従業員マスタCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Mst従業員マスタCB xcreateColumnQueryCB() {
            Mst従業員マスタCB cb = new Mst従業員マスタCB();
            cb.xsetupForColumnQuery((Mst従業員マスタCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Mst従業員マスタCB> orQuery) {
            xorQ((Mst従業員マスタCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Mst従業員マスタCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Mst従業員マスタCBColQySpQyCall(mainCB));
        }
    }

    public class Mst従業員マスタCBColQySpQyCall : HpSpQyCall<Mst従業員マスタCQ> {
        protected Mst従業員マスタCB _mainCB;
        public Mst従業員マスタCBColQySpQyCall(Mst従業員マスタCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Mst従業員マスタCQ qy() { return _mainCB.Query(); } 
    }

    public class Mst従業員マスタCBSpecification : AbstractSpecification<Mst従業員マスタCQ> {
        protected Kbn職位区分CBSpecification _kbn職位区分;
        public Mst従業員マスタCBSpecification(ConditionBean baseCB, HpSpQyCall<Mst従業員マスタCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnId() { doColumn("id"); }
        public void Column従業員番号() { doColumn("従業員番号"); }
        public void Column氏名姓() { doColumn("氏名_姓"); }
        public void Column氏名名() { doColumn("氏名_名"); }
        public void Column氏名カナ() { doColumn("氏名_カナ"); }
        public void Columnメールアドレス() { doColumn("メールアドレス"); }
        public void Columnパスワード() { doColumn("パスワード"); }
        public void Column生年月日() { doColumn("生年月日"); }
        public void Column入社年月日() { doColumn("入社年月日"); }
        public void Column退社年月日() { doColumn("退社年月日"); }
        public void Column職位コード() { doColumn("職位コード"); }
        public void Column最終ログイン日時() { doColumn("最終ログイン日時"); }
        public void Column備考() { doColumn("備考"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnId(); // PK
            if (qyCall().qy().hasConditionQueryKbn職位区分()
                    || qyCall().qy().xgetReferrerQuery() is Kbn職位区分CQ) {
                Column職位コード(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "mst従業員マスタ"; }
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
		    protected HpSpQyCall<Mst従業員マスタCQ> _qyCall;
		    public Kbn職位区分SpQyCall(HpSpQyCall<Mst従業員マスタCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryKbn職位区分(); }
			public Kbn職位区分CQ qy() { return _qyCall.qy().QueryKbn職位区分(); }
		}
        public RAFunction<Dch従業員職位履歴台帳CB, Mst従業員マスタCQ> DerivedDch従業員職位履歴台帳List() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Dch従業員職位履歴台帳CB, Mst従業員マスタCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Dch従業員職位履歴台帳CB> subQuery, Mst従業員マスタCQ cq, String aliasName)
                { cq.xsderiveDch従業員職位履歴台帳List(function, subQuery, aliasName); });
        }
    }
}
