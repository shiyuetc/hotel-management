
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
    public partial class Mst権限マスタBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mst権限マスタDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mst権限マスタBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst権限マスタ"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Mst権限マスタDbm.GetInstance(); } }
        public Mst権限マスタDbm MyDBMeta { get { return Mst権限マスタDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Mst権限マスタ NewMyEntity() { return new Mst権限マスタ(); }
        public virtual Mst権限マスタCB NewMyConditionBean() { return new Mst権限マスタCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Mst権限マスタCB cb) {
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
        public virtual Mst権限マスタ SelectEntity(Mst権限マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Mst権限マスタ> ls = null;
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
            return (Mst権限マスタ)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Mst権限マスタ SelectEntityWithDeletedCheck(Mst権限マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            Mst権限マスタ entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Mst権限マスタ SelectByPKValue(long? id) {
            return SelectEntity(BuildPKCB(id));
        }

        public virtual Mst権限マスタ SelectByPKValueWithDeletedCheck(long? id) {
            return SelectEntityWithDeletedCheck(BuildPKCB(id));
        }

        private Mst権限マスタCB BuildPKCB(long? id) {
            AssertObjectNotNull("id", id);
            Mst権限マスタCB cb = NewMyConditionBean();
            cb.Query().SetId_Equal(id);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Mst権限マスタ> SelectList(Mst権限マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Mst権限マスタ>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Mst権限マスタ> SelectPage(Mst権限マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Mst権限マスタ> invoker = new PagingInvoker<Mst権限マスタ>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Mst権限マスタ> {
            protected Mst権限マスタBhv _bhv; protected Mst権限マスタCB _cb;
            public InternalSelectPagingHandler(Mst権限マスタBhv bhv, Mst権限マスタCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Mst権限マスタ> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                        Sequence
        //                                                                        ========
        public long? SelectNextVal() {
            return DelegateSelectNextVal();
        }
        protected override void SetupNextValueToPrimaryKey(Entity entity) {// Very Internal
            Mst権限マスタ myEntity = (Mst権限マスタ)entity;
            myEntity.Id = SelectNextVal();
        }

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<Mst制御画面マスタ> PulloutMst制御画面マスタ(IList<Mst権限マスタ> mst権限マスタList) {
            return HelpPulloutInternally<Mst権限マスタ, Mst制御画面マスタ>(mst権限マスタList, new MyInternalPulloutMst制御画面マスタCallback());
        }
        protected class MyInternalPulloutMst制御画面マスタCallback : InternalPulloutCallback<Mst権限マスタ, Mst制御画面マスタ> {
            public Mst制御画面マスタ getFr(Mst権限マスタ entity) { return entity.Mst制御画面マスタ; }
        }
        public IList<Kbn職位区分> PulloutKbn職位区分(IList<Mst権限マスタ> mst権限マスタList) {
            return HelpPulloutInternally<Mst権限マスタ, Kbn職位区分>(mst権限マスタList, new MyInternalPulloutKbn職位区分Callback());
        }
        protected class MyInternalPulloutKbn職位区分Callback : InternalPulloutCallback<Mst権限マスタ, Kbn職位区分> {
            public Kbn職位区分 getFr(Mst権限マスタ entity) { return entity.Kbn職位区分; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(Mst権限マスタ entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Mst権限マスタ entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Mst権限マスタ entity) {
            HelpInsertOrUpdateInternally<Mst権限マスタ, Mst権限マスタCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Mst権限マスタ, Mst権限マスタCB> {
            protected Mst権限マスタBhv _bhv;
            public MyInternalInsertOrUpdateCallback(Mst権限マスタBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Mst権限マスタ entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Mst権限マスタ entity) { _bhv.Update(entity); }
            public Mst権限マスタCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Mst権限マスタCB cb, Mst権限マスタ entity) {
                cb.Query().SetId_Equal(entity.Id);
            }
            public int CallbackSelectCount(Mst権限マスタCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Mst権限マスタ entity) {
            HelpDeleteInternally<Mst権限マスタ>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Mst権限マスタ> {
            protected Mst権限マスタBhv _bhv;
            public MyInternalDeleteCallback(Mst権限マスタBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Mst権限マスタ entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Mst権限マスタ mst権限マスタ, Mst権限マスタCB cb) {
            AssertObjectNotNull("mst権限マスタ", mst権限マスタ); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(mst権限マスタ);
            FilterEntityOfUpdate(mst権限マスタ); AssertEntityOfUpdate(mst権限マスタ);
            return this.Dao.UpdateByQuery(cb, mst権限マスタ);
        }

        public int QueryDelete(Mst権限マスタCB cb) {
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
        protected int DelegateSelectCount(Mst権限マスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Mst権限マスタ> DelegateSelectList(Mst権限マスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }
        protected long? DelegateSelectNextVal() { return this.Dao.SelectNextVal(); }

        protected int DelegateInsert(Mst権限マスタ e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Mst権限マスタ e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Mst権限マスタ e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Mst権限マスタ Downcast(Entity entity) {
            return (Mst権限マスタ)entity;
        }

        protected Mst権限マスタCB Downcast(ConditionBean cb) {
            return (Mst権限マスタCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Mst権限マスタDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
