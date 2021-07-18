
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
    public partial class Mst客室タイプマスタBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mst客室タイプマスタDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mst客室タイプマスタBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst客室タイプマスタ"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Mst客室タイプマスタDbm.GetInstance(); } }
        public Mst客室タイプマスタDbm MyDBMeta { get { return Mst客室タイプマスタDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Mst客室タイプマスタ NewMyEntity() { return new Mst客室タイプマスタ(); }
        public virtual Mst客室タイプマスタCB NewMyConditionBean() { return new Mst客室タイプマスタCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Mst客室タイプマスタCB cb) {
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
        public virtual Mst客室タイプマスタ SelectEntity(Mst客室タイプマスタCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Mst客室タイプマスタ> ls = null;
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
            return (Mst客室タイプマスタ)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Mst客室タイプマスタ SelectEntityWithDeletedCheck(Mst客室タイプマスタCB cb) {
            AssertConditionBeanNotNull(cb);
            Mst客室タイプマスタ entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Mst客室タイプマスタ SelectByPKValue(long? id) {
            return SelectEntity(BuildPKCB(id));
        }

        public virtual Mst客室タイプマスタ SelectByPKValueWithDeletedCheck(long? id) {
            return SelectEntityWithDeletedCheck(BuildPKCB(id));
        }

        private Mst客室タイプマスタCB BuildPKCB(long? id) {
            AssertObjectNotNull("id", id);
            Mst客室タイプマスタCB cb = NewMyConditionBean();
            cb.Query().SetId_Equal(id);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Mst客室タイプマスタ> SelectList(Mst客室タイプマスタCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Mst客室タイプマスタ>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Mst客室タイプマスタ> SelectPage(Mst客室タイプマスタCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Mst客室タイプマスタ> invoker = new PagingInvoker<Mst客室タイプマスタ>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Mst客室タイプマスタ> {
            protected Mst客室タイプマスタBhv _bhv; protected Mst客室タイプマスタCB _cb;
            public InternalSelectPagingHandler(Mst客室タイプマスタBhv bhv, Mst客室タイプマスタCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Mst客室タイプマスタ> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                        Sequence
        //                                                                        ========
        public long? SelectNextVal() {
            return DelegateSelectNextVal();
        }
        protected override void SetupNextValueToPrimaryKey(Entity entity) {// Very Internal
            Mst客室タイプマスタ myEntity = (Mst客室タイプマスタ)entity;
            myEntity.Id = SelectNextVal();
        }

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadMst客室マスタList(Mst客室タイプマスタ mst客室タイプマスタ, ConditionBeanSetupper<Mst客室マスタCB> conditionBeanSetupper) {
            AssertObjectNotNull("mst客室タイプマスタ", mst客室タイプマスタ); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMst客室マスタList(xnewLRLs<Mst客室タイプマスタ>(mst客室タイプマスタ), conditionBeanSetupper);
        }
        public virtual void LoadMst客室マスタList(IList<Mst客室タイプマスタ> mst客室タイプマスタList, ConditionBeanSetupper<Mst客室マスタCB> conditionBeanSetupper) {
            AssertObjectNotNull("mst客室タイプマスタList", mst客室タイプマスタList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMst客室マスタList(mst客室タイプマスタList, new LoadReferrerOption<Mst客室マスタCB, Mst客室マスタ>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMst客室マスタList(Mst客室タイプマスタ mst客室タイプマスタ, LoadReferrerOption<Mst客室マスタCB, Mst客室マスタ> loadReferrerOption) {
            AssertObjectNotNull("mst客室タイプマスタ", mst客室タイプマスタ); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMst客室マスタList(xnewLRLs<Mst客室タイプマスタ>(mst客室タイプマスタ), loadReferrerOption);
        }
        public virtual void LoadMst客室マスタList(IList<Mst客室タイプマスタ> mst客室タイプマスタList, LoadReferrerOption<Mst客室マスタCB, Mst客室マスタ> loadReferrerOption) {
            AssertObjectNotNull("mst客室タイプマスタList", mst客室タイプマスタList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (mst客室タイプマスタList.Count == 0) { return; }
            Mst客室マスタBhv referrerBhv = xgetBSFLR().Select<Mst客室マスタBhv>();
            HelpLoadReferrerInternally<Mst客室タイプマスタ, long?, Mst客室マスタCB, Mst客室マスタ>
                    (mst客室タイプマスタList, loadReferrerOption, new MyInternalLoadMst客室マスタListCallback(referrerBhv));
        }
        protected class MyInternalLoadMst客室マスタListCallback : InternalLoadReferrerCallback<Mst客室タイプマスタ, long?, Mst客室マスタCB, Mst客室マスタ> {
            protected Mst客室マスタBhv referrerBhv;
            public MyInternalLoadMst客室マスタListCallback(Mst客室マスタBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(Mst客室タイプマスタ e) { return e.Id; }
            public void setRfLs(Mst客室タイプマスタ e, IList<Mst客室マスタ> ls) { e.Mst客室マスタList = ls; }
            public Mst客室マスタCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(Mst客室マスタCB cb, IList<long?> ls) { cb.Query().Set客室タイプid_InScope(ls); }
            public void qyOdFKAsc(Mst客室マスタCB cb) { cb.Query().AddOrderBy_客室タイプid_Asc(); }
            public void spFKCol(Mst客室マスタCB cb) { cb.Specify().Column客室タイプid(); }
            public IList<Mst客室マスタ> selRfLs(Mst客室マスタCB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(Mst客室マスタ e) { return e.客室タイプid; }
            public void setlcEt(Mst客室マスタ re, Mst客室タイプマスタ be) { re.Mst客室タイプマスタ = be; }
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
        public virtual void Insert(Mst客室タイプマスタ entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Mst客室タイプマスタ entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Mst客室タイプマスタ entity) {
            HelpInsertOrUpdateInternally<Mst客室タイプマスタ, Mst客室タイプマスタCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Mst客室タイプマスタ, Mst客室タイプマスタCB> {
            protected Mst客室タイプマスタBhv _bhv;
            public MyInternalInsertOrUpdateCallback(Mst客室タイプマスタBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Mst客室タイプマスタ entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Mst客室タイプマスタ entity) { _bhv.Update(entity); }
            public Mst客室タイプマスタCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Mst客室タイプマスタCB cb, Mst客室タイプマスタ entity) {
                cb.Query().SetId_Equal(entity.Id);
            }
            public int CallbackSelectCount(Mst客室タイプマスタCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Mst客室タイプマスタ entity) {
            HelpDeleteInternally<Mst客室タイプマスタ>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Mst客室タイプマスタ> {
            protected Mst客室タイプマスタBhv _bhv;
            public MyInternalDeleteCallback(Mst客室タイプマスタBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Mst客室タイプマスタ entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Mst客室タイプマスタ mst客室タイプマスタ, Mst客室タイプマスタCB cb) {
            AssertObjectNotNull("mst客室タイプマスタ", mst客室タイプマスタ); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(mst客室タイプマスタ);
            FilterEntityOfUpdate(mst客室タイプマスタ); AssertEntityOfUpdate(mst客室タイプマスタ);
            return this.Dao.UpdateByQuery(cb, mst客室タイプマスタ);
        }

        public int QueryDelete(Mst客室タイプマスタCB cb) {
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
        protected int DelegateSelectCount(Mst客室タイプマスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Mst客室タイプマスタ> DelegateSelectList(Mst客室タイプマスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }
        protected long? DelegateSelectNextVal() { return this.Dao.SelectNextVal(); }

        protected int DelegateInsert(Mst客室タイプマスタ e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Mst客室タイプマスタ e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Mst客室タイプマスタ e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Mst客室タイプマスタ Downcast(Entity entity) {
            return (Mst客室タイプマスタ)entity;
        }

        protected Mst客室タイプマスタCB Downcast(ConditionBean cb) {
            return (Mst客室タイプマスタCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Mst客室タイプマスタDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
