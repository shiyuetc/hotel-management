
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
    public class BsMst会員マスタCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mst会員マスタCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst会員マスタ"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String 会員コード) {
            assertObjectNotNull("会員コード", 会員コード);
            BsMst会員マスタCB cb = this;
            cb.Query().Set会員コード_Equal(会員コード);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_会員コード_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_会員コード_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public Mst会員マスタCQ Query() {
            return this.ConditionQuery;
        }

        public Mst会員マスタCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual Mst会員マスタCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual Mst会員マスタCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new Mst会員マスタCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<Mst会員マスタCB> unionQuery) {
            Mst会員マスタCB cb = new Mst会員マスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mst会員マスタCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<Mst会員マスタCB> unionQuery) {
            Mst会員マスタCB cb = new Mst会員マスタCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    Mst会員マスタCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected Mst会員マスタCBSpecification _specification;
        public Mst会員マスタCBSpecification Specify() {
            if (_specification == null) { _specification = new Mst会員マスタCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<Mst会員マスタCQ> {
			protected BsMst会員マスタCB _myCB;
			public MySpQyCall(BsMst会員マスタCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public Mst会員マスタCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<Mst会員マスタCB> ColumnQuery(SpecifyQuery<Mst会員マスタCB> leftSpecifyQuery) {
            return new HpColQyOperand<Mst会員マスタCB>(delegate(SpecifyQuery<Mst会員マスタCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected Mst会員マスタCB xcreateColumnQueryCB() {
            Mst会員マスタCB cb = new Mst会員マスタCB();
            cb.xsetupForColumnQuery((Mst会員マスタCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<Mst会員マスタCB> orQuery) {
            xorQ((Mst会員マスタCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(Mst会員マスタCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new Mst会員マスタCBColQySpQyCall(mainCB));
        }
    }

    public class Mst会員マスタCBColQySpQyCall : HpSpQyCall<Mst会員マスタCQ> {
        protected Mst会員マスタCB _mainCB;
        public Mst会員マスタCBColQySpQyCall(Mst会員マスタCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public Mst会員マスタCQ qy() { return _mainCB.Query(); } 
    }

    public class Mst会員マスタCBSpecification : AbstractSpecification<Mst会員マスタCQ> {
        public Mst会員マスタCBSpecification(ConditionBean baseCB, HpSpQyCall<Mst会員マスタCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void Column会員コード() { doColumn("会員コード"); }
        public void Column会員番号() { doColumn("会員番号"); }
        public void Column名字() { doColumn("名字"); }
        public void Column名前() { doColumn("名前"); }
        public void Column氏名カナ() { doColumn("氏名カナ"); }
        public void Column会社名() { doColumn("会社名"); }
        public void Column会社名カナ() { doColumn("会社名カナ"); }
        public void Column電話番号() { doColumn("電話番号"); }
        public void Columnメールアドレス() { doColumn("メールアドレス"); }
        public void Column入会年月日() { doColumn("入会年月日"); }
        public void Column退会年月日() { doColumn("退会年月日"); }
        public void Column備考() { doColumn("備考"); }
        protected override void doSpecifyRequiredColumn() {
            Column会員コード(); // PK
        }
        protected override String getTableDbName() { return "mst会員マスタ"; }
        public RAFunction<Dch宿泊利用台帳CB, Mst会員マスタCQ> DerivedDch宿泊利用台帳List() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<Dch宿泊利用台帳CB, Mst会員マスタCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<Dch宿泊利用台帳CB> subQuery, Mst会員マスタCQ cq, String aliasName)
                { cq.xsderiveDch宿泊利用台帳List(function, subQuery, aliasName); });
        }
    }
}
