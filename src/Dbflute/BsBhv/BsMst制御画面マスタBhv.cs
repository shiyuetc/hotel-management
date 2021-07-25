
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
    public partial class Mst制御画面マスタBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mst制御画面マスタDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mst制御画面マスタBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst制御画面マスタ"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Mst制御画面マスタDbm.GetInstance(); } }
        public Mst制御画面マスタDbm MyDBMeta { get { return Mst制御画面マスタDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Mst制御画面マスタ NewMyEntity() { return new Mst制御画面マスタ(); }
        public virtual Mst制御画面マスタCB NewMyConditionBean() { return new Mst制御画面マスタCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Mst制御画面マスタCB cb) {
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
        public virtual Mst制御画面マスタ SelectEntity(Mst制御画面マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Mst制御画面マスタ> ls = null;
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
            return (Mst制御画面マスタ)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Mst制御画面マスタ SelectEntityWithDeletedCheck(Mst制御画面マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            Mst制御画面マスタ entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Mst制御画面マスタ SelectByPKValue(long? id) {
            return SelectEntity(BuildPKCB(id));
        }

        public virtual Mst制御画面マスタ SelectByPKValueWithDeletedCheck(long? id) {
            return SelectEntityWithDeletedCheck(BuildPKCB(id));
        }

        private Mst制御画面マスタCB BuildPKCB(long? id) {
            AssertObjectNotNull("id", id);
            Mst制御画面マスタCB cb = NewMyConditionBean();
            cb.Query().SetId_Equal(id);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Mst制御画面マスタ> SelectList(Mst制御画面マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Mst制御画面マスタ>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Mst制御画面マスタ> SelectPage(Mst制御画面マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Mst制御画面マスタ> invoker = new PagingInvoker<Mst制御画面マスタ>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Mst制御画面マスタ> {
            protected Mst制御画面マスタBhv _bhv; protected Mst制御画面マスタCB _cb;
            public InternalSelectPagingHandler(Mst制御画面マスタBhv bhv, Mst制御画面マスタCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Mst制御画面マスタ> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                        Sequence
        //                                                                        ========
        public long? SelectNextVal() {
            return DelegateSelectNextVal();
        }
        protected override void SetupNextValueToPrimaryKey(Entity entity) {// Very Internal
            Mst制御画面マスタ myEntity = (Mst制御画面マスタ)entity;
            myEntity.Id = SelectNextVal();
        }

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadMst権限マスタList(Mst制御画面マスタ mst制御画面マスタ, ConditionBeanSetupper<Mst権限マスタCB> conditionBeanSetupper) {
            AssertObjectNotNull("mst制御画面マスタ", mst制御画面マスタ); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMst権限マスタList(xnewLRLs<Mst制御画面マスタ>(mst制御画面マスタ), conditionBeanSetupper);
        }
        public virtual void LoadMst権限マスタList(IList<Mst制御画面マスタ> mst制御画面マスタList, ConditionBeanSetupper<Mst権限マスタCB> conditionBeanSetupper) {
            AssertObjectNotNull("mst制御画面マスタList", mst制御画面マスタList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMst権限マスタList(mst制御画面マスタList, new LoadReferrerOption<Mst権限マスタCB, Mst権限マスタ>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMst権限マスタList(Mst制御画面マスタ mst制御画面マスタ, LoadReferrerOption<Mst権限マスタCB, Mst権限マスタ> loadReferrerOption) {
            AssertObjectNotNull("mst制御画面マスタ", mst制御画面マスタ); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMst権限マスタList(xnewLRLs<Mst制御画面マスタ>(mst制御画面マスタ), loadReferrerOption);
        }
        public virtual void LoadMst権限マスタList(IList<Mst制御画面マスタ> mst制御画面マスタList, LoadReferrerOption<Mst権限マスタCB, Mst権限マスタ> loadReferrerOption) {
            AssertObjectNotNull("mst制御画面マスタList", mst制御画面マスタList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (mst制御画面マスタList.Count == 0) { return; }
            Mst権限マスタBhv referrerBhv = xgetBSFLR().Select<Mst権限マスタBhv>();
            HelpLoadReferrerInternally<Mst制御画面マスタ, long?, Mst権限マスタCB, Mst権限マスタ>
                    (mst制御画面マスタList, loadReferrerOption, new MyInternalLoadMst権限マスタListCallback(referrerBhv));
        }
        protected class MyInternalLoadMst権限マスタListCallback : InternalLoadReferrerCallback<Mst制御画面マスタ, long?, Mst権限マスタCB, Mst権限マスタ> {
            protected Mst権限マスタBhv referrerBhv;
            public MyInternalLoadMst権限マスタListCallback(Mst権限マスタBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(Mst制御画面マスタ e) { return e.Id; }
            public void setRfLs(Mst制御画面マスタ e, IList<Mst権限マスタ> ls) { e.Mst権限マスタList = ls; }
            public Mst権限マスタCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(Mst権限マスタCB cb, IList<long?> ls) { cb.Query().Set制御画面id_InScope(ls); }
            public void qyOdFKAsc(Mst権限マスタCB cb) { cb.Query().AddOrderBy_制御画面id_Asc(); }
            public void spFKCol(Mst権限マスタCB cb) { cb.Specify().Column制御画面id(); }
            public IList<Mst権限マスタ> selRfLs(Mst権限マスタCB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(Mst権限マスタ e) { return e.制御画面id; }
            public void setlcEt(Mst権限マスタ re, Mst制御画面マスタ be) { re.Mst制御画面マスタ = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<Kbnメニュー区分> PulloutKbnメニュー区分(IList<Mst制御画面マスタ> mst制御画面マスタList) {
            return HelpPulloutInternally<Mst制御画面マスタ, Kbnメニュー区分>(mst制御画面マスタList, new MyInternalPulloutKbnメニュー区分Callback());
        }
        protected class MyInternalPulloutKbnメニュー区分Callback : InternalPulloutCallback<Mst制御画面マスタ, Kbnメニュー区分> {
            public Kbnメニュー区分 getFr(Mst制御画面マスタ entity) { return entity.Kbnメニュー区分; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(Mst制御画面マスタ entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Mst制御画面マスタ entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Mst制御画面マスタ entity) {
            HelpInsertOrUpdateInternally<Mst制御画面マスタ, Mst制御画面マスタCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Mst制御画面マスタ, Mst制御画面マスタCB> {
            protected Mst制御画面マスタBhv _bhv;
            public MyInternalInsertOrUpdateCallback(Mst制御画面マスタBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Mst制御画面マスタ entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Mst制御画面マスタ entity) { _bhv.Update(entity); }
            public Mst制御画面マスタCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Mst制御画面マスタCB cb, Mst制御画面マスタ entity) {
                cb.Query().SetId_Equal(entity.Id);
            }
            public int CallbackSelectCount(Mst制御画面マスタCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Mst制御画面マスタ entity) {
            HelpDeleteInternally<Mst制御画面マスタ>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Mst制御画面マスタ> {
            protected Mst制御画面マスタBhv _bhv;
            public MyInternalDeleteCallback(Mst制御画面マスタBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Mst制御画面マスタ entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Mst制御画面マスタ mst制御画面マスタ, Mst制御画面マスタCB cb) {
            AssertObjectNotNull("mst制御画面マスタ", mst制御画面マスタ); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(mst制御画面マスタ);
            FilterEntityOfUpdate(mst制御画面マスタ); AssertEntityOfUpdate(mst制御画面マスタ);
            return this.Dao.UpdateByQuery(cb, mst制御画面マスタ);
        }

        public int QueryDelete(Mst制御画面マスタCB cb) {
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
        protected int DelegateSelectCount(Mst制御画面マスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Mst制御画面マスタ> DelegateSelectList(Mst制御画面マスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }
        protected long? DelegateSelectNextVal() { return this.Dao.SelectNextVal(); }

        protected int DelegateInsert(Mst制御画面マスタ e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Mst制御画面マスタ e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Mst制御画面マスタ e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Mst制御画面マスタ Downcast(Entity entity) {
            return (Mst制御画面マスタ)entity;
        }

        protected Mst制御画面マスタCB Downcast(ConditionBean cb) {
            return (Mst制御画面マスタCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Mst制御画面マスタDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
