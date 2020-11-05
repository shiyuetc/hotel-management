
using System;
using System.Collections.Generic;

using Seasar.Quill;
using Seasar.Quill.Attrs;

using Dbflute.AllCommon;
using Dbflute.AllCommon.Bhv;
using Dbflute.AllCommon.Bhv.Load;
using Dbflute.AllCommon.Bhv.Setup;
using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.Dbm;
using Dbflute.AllCommon.Exp;
using Dbflute.BsEntity.Dbm;
using Dbflute.ExDao;
using Dbflute.ExEntity;
using Dbflute.CBean;


namespace Dbflute.ExBhv {

    [Implementation]
    public partial class RankBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected RankDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public RankBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "rank"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return RankDbm.GetInstance(); } }
        public RankDbm MyDBMeta { get { return RankDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Rank NewMyEntity() { return new Rank(); }
        public virtual RankCB NewMyConditionBean() { return new RankCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(RankCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.DelegateSelectCount(cb);
        }

        protected override int DoReadCount(ConditionBean cb) {
            return SelectCount(Downcast(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                   Entity Select
        //                                                                   =============
        #region Entity Select
        public virtual Rank SelectEntity(RankCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Rank> ls = null;
            try {
                ls = this.DelegateSelectList(cb);
            } catch (DangerousResultSizeException e) {
                ThrowEntityDuplicatedException("{over safetyMaxResultSize '1'}", cb, e);
                return null; // unreachable
            } finally {
                xrestoreSafetyResult(cb, preSafetyMaxResultSize);
            }
            if (ls.Count == 0) { return null; }
            AssertEntitySelectedAsOne(ls, cb);
            return (Rank)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Rank SelectEntityWithDeletedCheck(RankCB cb) {
            AssertConditionBeanNotNull(cb);
            Rank entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Rank SelectByPKValue(String code) {
            return SelectEntity(BuildPKCB(code));
        }

        public virtual Rank SelectByPKValueWithDeletedCheck(String code) {
            return SelectEntityWithDeletedCheck(BuildPKCB(code));
        }

        private RankCB BuildPKCB(String code) {
            AssertObjectNotNull("code", code);
            RankCB cb = NewMyConditionBean();
            cb.Query().SetCode_Equal(code);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Rank> SelectList(RankCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Rank>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Rank> SelectPage(RankCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Rank> invoker = new PagingInvoker<Rank>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Rank> {
            protected RankBhv _bhv; protected RankCB _cb;
            public InternalSelectPagingHandler(RankBhv bhv, RankCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Rank> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadEmployeeList(Rank rank, ConditionBeanSetupper<EmployeeCB> conditionBeanSetupper) {
            AssertObjectNotNull("rank", rank); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadEmployeeList(xnewLRLs<Rank>(rank), conditionBeanSetupper);
        }
        public virtual void LoadEmployeeList(IList<Rank> rankList, ConditionBeanSetupper<EmployeeCB> conditionBeanSetupper) {
            AssertObjectNotNull("rankList", rankList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadEmployeeList(rankList, new LoadReferrerOption<EmployeeCB, Employee>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadEmployeeList(Rank rank, LoadReferrerOption<EmployeeCB, Employee> loadReferrerOption) {
            AssertObjectNotNull("rank", rank); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadEmployeeList(xnewLRLs<Rank>(rank), loadReferrerOption);
        }
        public virtual void LoadEmployeeList(IList<Rank> rankList, LoadReferrerOption<EmployeeCB, Employee> loadReferrerOption) {
            AssertObjectNotNull("rankList", rankList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (rankList.Count == 0) { return; }
            EmployeeBhv referrerBhv = xgetBSFLR().Select<EmployeeBhv>();
            HelpLoadReferrerInternally<Rank, String, EmployeeCB, Employee>
                    (rankList, loadReferrerOption, new MyInternalLoadEmployeeListCallback(referrerBhv));
        }
        protected class MyInternalLoadEmployeeListCallback : InternalLoadReferrerCallback<Rank, String, EmployeeCB, Employee> {
            protected EmployeeBhv referrerBhv;
            public MyInternalLoadEmployeeListCallback(EmployeeBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(Rank e) { return e.Code; }
            public void setRfLs(Rank e, IList<Employee> ls) { e.EmployeeList = ls; }
            public EmployeeCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(EmployeeCB cb, IList<String> ls) { cb.Query().SetRankCode_InScope(ls); }
            public void qyOdFKAsc(EmployeeCB cb) { cb.Query().AddOrderBy_RankCode_Asc(); }
            public void spFKCol(EmployeeCB cb) { cb.Specify().ColumnRankCode(); }
            public IList<Employee> selRfLs(EmployeeCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(Employee e) { return e.RankCode; }
            public void setlcEt(Employee re, Rank be) { re.Rank = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(Rank entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Rank entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Rank entity) {
            HelpInsertOrUpdateInternally<Rank, RankCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Rank, RankCB> {
            protected RankBhv _bhv;
            public MyInternalInsertOrUpdateCallback(RankBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Rank entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Rank entity) { _bhv.Update(entity); }
            public RankCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(RankCB cb, Rank entity) {
                cb.Query().SetCode_Equal(entity.Code);
            }
            public int CallbackSelectCount(RankCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Rank entity) {
            HelpDeleteInternally<Rank>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Rank> {
            protected RankBhv _bhv;
            public MyInternalDeleteCallback(RankBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Rank entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Rank rank, RankCB cb) {
            AssertObjectNotNull("rank", rank); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(rank);
            FilterEntityOfUpdate(rank); AssertEntityOfUpdate(rank);
            return this.Dao.UpdateByQuery(cb, rank);
        }

        public int QueryDelete(RankCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(Entity entity) {
            return false;
        }

        protected override bool HasUpdateDateValue(Entity entity) {
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(RankCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Rank> DelegateSelectList(RankCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(Rank e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Rank e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Rank e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Rank Downcast(Entity entity) {
            return (Rank)entity;
        }

        protected RankCB Downcast(ConditionBean cb) {
            return (RankCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual RankDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
