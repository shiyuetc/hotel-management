
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
    public partial class Mst画面マスタBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mst画面マスタDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mst画面マスタBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst画面マスタ"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Mst画面マスタDbm.GetInstance(); } }
        public Mst画面マスタDbm MyDBMeta { get { return Mst画面マスタDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Mst画面マスタ NewMyEntity() { return new Mst画面マスタ(); }
        public virtual Mst画面マスタCB NewMyConditionBean() { return new Mst画面マスタCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Mst画面マスタCB cb) {
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
        public virtual Mst画面マスタ SelectEntity(Mst画面マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Mst画面マスタ> ls = null;
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
            return (Mst画面マスタ)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Mst画面マスタ SelectEntityWithDeletedCheck(Mst画面マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            Mst画面マスタ entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Mst画面マスタ SelectByPKValue(String 画面コード) {
            return SelectEntity(BuildPKCB(画面コード));
        }

        public virtual Mst画面マスタ SelectByPKValueWithDeletedCheck(String 画面コード) {
            return SelectEntityWithDeletedCheck(BuildPKCB(画面コード));
        }

        private Mst画面マスタCB BuildPKCB(String 画面コード) {
            AssertObjectNotNull("画面コード", 画面コード);
            Mst画面マスタCB cb = NewMyConditionBean();
            cb.Query().Set画面コード_Equal(画面コード);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Mst画面マスタ> SelectList(Mst画面マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Mst画面マスタ>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Mst画面マスタ> SelectPage(Mst画面マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Mst画面マスタ> invoker = new PagingInvoker<Mst画面マスタ>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Mst画面マスタ> {
            protected Mst画面マスタBhv _bhv; protected Mst画面マスタCB _cb;
            public InternalSelectPagingHandler(Mst画面マスタBhv bhv, Mst画面マスタCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Mst画面マスタ> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadMst権限マスタList(Mst画面マスタ mst画面マスタ, ConditionBeanSetupper<Mst権限マスタCB> conditionBeanSetupper) {
            AssertObjectNotNull("mst画面マスタ", mst画面マスタ); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMst権限マスタList(xnewLRLs<Mst画面マスタ>(mst画面マスタ), conditionBeanSetupper);
        }
        public virtual void LoadMst権限マスタList(IList<Mst画面マスタ> mst画面マスタList, ConditionBeanSetupper<Mst権限マスタCB> conditionBeanSetupper) {
            AssertObjectNotNull("mst画面マスタList", mst画面マスタList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMst権限マスタList(mst画面マスタList, new LoadReferrerOption<Mst権限マスタCB, Mst権限マスタ>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMst権限マスタList(Mst画面マスタ mst画面マスタ, LoadReferrerOption<Mst権限マスタCB, Mst権限マスタ> loadReferrerOption) {
            AssertObjectNotNull("mst画面マスタ", mst画面マスタ); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMst権限マスタList(xnewLRLs<Mst画面マスタ>(mst画面マスタ), loadReferrerOption);
        }
        public virtual void LoadMst権限マスタList(IList<Mst画面マスタ> mst画面マスタList, LoadReferrerOption<Mst権限マスタCB, Mst権限マスタ> loadReferrerOption) {
            AssertObjectNotNull("mst画面マスタList", mst画面マスタList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (mst画面マスタList.Count == 0) { return; }
            Mst権限マスタBhv referrerBhv = xgetBSFLR().Select<Mst権限マスタBhv>();
            HelpLoadReferrerInternally<Mst画面マスタ, String, Mst権限マスタCB, Mst権限マスタ>
                    (mst画面マスタList, loadReferrerOption, new MyInternalLoadMst権限マスタListCallback(referrerBhv));
        }
        protected class MyInternalLoadMst権限マスタListCallback : InternalLoadReferrerCallback<Mst画面マスタ, String, Mst権限マスタCB, Mst権限マスタ> {
            protected Mst権限マスタBhv referrerBhv;
            public MyInternalLoadMst権限マスタListCallback(Mst権限マスタBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(Mst画面マスタ e) { return e.画面コード; }
            public void setRfLs(Mst画面マスタ e, IList<Mst権限マスタ> ls) { e.Mst権限マスタList = ls; }
            public Mst権限マスタCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(Mst権限マスタCB cb, IList<String> ls) { cb.Query().Set画面コード_InScope(ls); }
            public void qyOdFKAsc(Mst権限マスタCB cb) { cb.Query().AddOrderBy_画面コード_Asc(); }
            public void spFKCol(Mst権限マスタCB cb) { cb.Specify().Column画面コード(); }
            public IList<Mst権限マスタ> selRfLs(Mst権限マスタCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(Mst権限マスタ e) { return e.画面コード; }
            public void setlcEt(Mst権限マスタ re, Mst画面マスタ be) { re.Mst画面マスタ = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<Kbnメニュー区分> PulloutKbnメニュー区分(IList<Mst画面マスタ> mst画面マスタList) {
            return HelpPulloutInternally<Mst画面マスタ, Kbnメニュー区分>(mst画面マスタList, new MyInternalPulloutKbnメニュー区分Callback());
        }
        protected class MyInternalPulloutKbnメニュー区分Callback : InternalPulloutCallback<Mst画面マスタ, Kbnメニュー区分> {
            public Kbnメニュー区分 getFr(Mst画面マスタ entity) { return entity.Kbnメニュー区分; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(Mst画面マスタ entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Mst画面マスタ entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Mst画面マスタ entity) {
            HelpInsertOrUpdateInternally<Mst画面マスタ, Mst画面マスタCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Mst画面マスタ, Mst画面マスタCB> {
            protected Mst画面マスタBhv _bhv;
            public MyInternalInsertOrUpdateCallback(Mst画面マスタBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Mst画面マスタ entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Mst画面マスタ entity) { _bhv.Update(entity); }
            public Mst画面マスタCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Mst画面マスタCB cb, Mst画面マスタ entity) {
                cb.Query().Set画面コード_Equal(entity.画面コード);
            }
            public int CallbackSelectCount(Mst画面マスタCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Mst画面マスタ entity) {
            HelpDeleteInternally<Mst画面マスタ>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Mst画面マスタ> {
            protected Mst画面マスタBhv _bhv;
            public MyInternalDeleteCallback(Mst画面マスタBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Mst画面マスタ entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Mst画面マスタ mst画面マスタ, Mst画面マスタCB cb) {
            AssertObjectNotNull("mst画面マスタ", mst画面マスタ); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(mst画面マスタ);
            FilterEntityOfUpdate(mst画面マスタ); AssertEntityOfUpdate(mst画面マスタ);
            return this.Dao.UpdateByQuery(cb, mst画面マスタ);
        }

        public int QueryDelete(Mst画面マスタCB cb) {
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
        protected int DelegateSelectCount(Mst画面マスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Mst画面マスタ> DelegateSelectList(Mst画面マスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(Mst画面マスタ e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Mst画面マスタ e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Mst画面マスタ e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Mst画面マスタ Downcast(Entity entity) {
            return (Mst画面マスタ)entity;
        }

        protected Mst画面マスタCB Downcast(ConditionBean cb) {
            return (Mst画面マスタCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Mst画面マスタDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
