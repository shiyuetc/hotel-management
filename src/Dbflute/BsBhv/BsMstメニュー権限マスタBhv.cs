
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
    public partial class Mstメニュー権限マスタBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mstメニュー権限マスタDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mstメニュー権限マスタBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mstメニュー権限マスタ"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Mstメニュー権限マスタDbm.GetInstance(); } }
        public Mstメニュー権限マスタDbm MyDBMeta { get { return Mstメニュー権限マスタDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Mstメニュー権限マスタ NewMyEntity() { return new Mstメニュー権限マスタ(); }
        public virtual Mstメニュー権限マスタCB NewMyConditionBean() { return new Mstメニュー権限マスタCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Mstメニュー権限マスタCB cb) {
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
        public virtual Mstメニュー権限マスタ SelectEntity(Mstメニュー権限マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Mstメニュー権限マスタ> ls = null;
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
            return (Mstメニュー権限マスタ)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Mstメニュー権限マスタ SelectEntityWithDeletedCheck(Mstメニュー権限マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            Mstメニュー権限マスタ entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Mstメニュー権限マスタ SelectByPKValue(long? id) {
            return SelectEntity(BuildPKCB(id));
        }

        public virtual Mstメニュー権限マスタ SelectByPKValueWithDeletedCheck(long? id) {
            return SelectEntityWithDeletedCheck(BuildPKCB(id));
        }

        private Mstメニュー権限マスタCB BuildPKCB(long? id) {
            AssertObjectNotNull("id", id);
            Mstメニュー権限マスタCB cb = NewMyConditionBean();
            cb.Query().SetId_Equal(id);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Mstメニュー権限マスタ> SelectList(Mstメニュー権限マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Mstメニュー権限マスタ>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Mstメニュー権限マスタ> SelectPage(Mstメニュー権限マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Mstメニュー権限マスタ> invoker = new PagingInvoker<Mstメニュー権限マスタ>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Mstメニュー権限マスタ> {
            protected Mstメニュー権限マスタBhv _bhv; protected Mstメニュー権限マスタCB _cb;
            public InternalSelectPagingHandler(Mstメニュー権限マスタBhv bhv, Mstメニュー権限マスタCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Mstメニュー権限マスタ> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                        Sequence
        //                                                                        ========
        public long? SelectNextVal() {
            return DelegateSelectNextVal();
        }
        protected override void SetupNextValueToPrimaryKey(Entity entity) {// Very Internal
            Mstメニュー権限マスタ myEntity = (Mstメニュー権限マスタ)entity;
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
        public IList<Mst制御画面マスタ> PulloutMst制御画面マスタ(IList<Mstメニュー権限マスタ> mstメニュー権限マスタList) {
            return HelpPulloutInternally<Mstメニュー権限マスタ, Mst制御画面マスタ>(mstメニュー権限マスタList, new MyInternalPulloutMst制御画面マスタCallback());
        }
        protected class MyInternalPulloutMst制御画面マスタCallback : InternalPulloutCallback<Mstメニュー権限マスタ, Mst制御画面マスタ> {
            public Mst制御画面マスタ getFr(Mstメニュー権限マスタ entity) { return entity.Mst制御画面マスタ; }
        }
        public IList<Kbn職位区分> PulloutKbn職位区分(IList<Mstメニュー権限マスタ> mstメニュー権限マスタList) {
            return HelpPulloutInternally<Mstメニュー権限マスタ, Kbn職位区分>(mstメニュー権限マスタList, new MyInternalPulloutKbn職位区分Callback());
        }
        protected class MyInternalPulloutKbn職位区分Callback : InternalPulloutCallback<Mstメニュー権限マスタ, Kbn職位区分> {
            public Kbn職位区分 getFr(Mstメニュー権限マスタ entity) { return entity.Kbn職位区分; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(Mstメニュー権限マスタ entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Mstメニュー権限マスタ entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Mstメニュー権限マスタ entity) {
            HelpInsertOrUpdateInternally<Mstメニュー権限マスタ, Mstメニュー権限マスタCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Mstメニュー権限マスタ, Mstメニュー権限マスタCB> {
            protected Mstメニュー権限マスタBhv _bhv;
            public MyInternalInsertOrUpdateCallback(Mstメニュー権限マスタBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Mstメニュー権限マスタ entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Mstメニュー権限マスタ entity) { _bhv.Update(entity); }
            public Mstメニュー権限マスタCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Mstメニュー権限マスタCB cb, Mstメニュー権限マスタ entity) {
                cb.Query().SetId_Equal(entity.Id);
            }
            public int CallbackSelectCount(Mstメニュー権限マスタCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Mstメニュー権限マスタ entity) {
            HelpDeleteInternally<Mstメニュー権限マスタ>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Mstメニュー権限マスタ> {
            protected Mstメニュー権限マスタBhv _bhv;
            public MyInternalDeleteCallback(Mstメニュー権限マスタBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Mstメニュー権限マスタ entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Mstメニュー権限マスタ mstメニュー権限マスタ, Mstメニュー権限マスタCB cb) {
            AssertObjectNotNull("mstメニュー権限マスタ", mstメニュー権限マスタ); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(mstメニュー権限マスタ);
            FilterEntityOfUpdate(mstメニュー権限マスタ); AssertEntityOfUpdate(mstメニュー権限マスタ);
            return this.Dao.UpdateByQuery(cb, mstメニュー権限マスタ);
        }

        public int QueryDelete(Mstメニュー権限マスタCB cb) {
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
        protected int DelegateSelectCount(Mstメニュー権限マスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Mstメニュー権限マスタ> DelegateSelectList(Mstメニュー権限マスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }
        protected long? DelegateSelectNextVal() { return this.Dao.SelectNextVal(); }

        protected int DelegateInsert(Mstメニュー権限マスタ e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Mstメニュー権限マスタ e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Mstメニュー権限マスタ e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Mstメニュー権限マスタ Downcast(Entity entity) {
            return (Mstメニュー権限マスタ)entity;
        }

        protected Mstメニュー権限マスタCB Downcast(ConditionBean cb) {
            return (Mstメニュー権限マスタCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Mstメニュー権限マスタDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
