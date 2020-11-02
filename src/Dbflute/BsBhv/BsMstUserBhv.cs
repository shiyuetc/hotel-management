
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
    public partial class MstUserBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MstUserDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MstUserBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst_user"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return MstUserDbm.GetInstance(); } }
        public MstUserDbm MyDBMeta { get { return MstUserDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MstUser NewMyEntity() { return new MstUser(); }
        public virtual MstUserCB NewMyConditionBean() { return new MstUserCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MstUserCB cb) {
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
        public virtual MstUser SelectEntity(MstUserCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MstUser> ls = null;
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
            return (MstUser)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MstUser SelectEntityWithDeletedCheck(MstUserCB cb) {
            AssertConditionBeanNotNull(cb);
            MstUser entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MstUser SelectByPKValue(int? id) {
            return SelectEntity(BuildPKCB(id));
        }

        public virtual MstUser SelectByPKValueWithDeletedCheck(int? id) {
            return SelectEntityWithDeletedCheck(BuildPKCB(id));
        }

        private MstUserCB BuildPKCB(int? id) {
            AssertObjectNotNull("id", id);
            MstUserCB cb = NewMyConditionBean();
            cb.Query().SetId_Equal(id);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<MstUser> SelectList(MstUserCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<MstUser>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<MstUser> SelectPage(MstUserCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<MstUser> invoker = new PagingInvoker<MstUser>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<MstUser> {
            protected MstUserBhv _bhv; protected MstUserCB _cb;
            public InternalSelectPagingHandler(MstUserBhv bhv, MstUserCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MstUser> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
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
        public virtual void Insert(MstUser entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MstUser entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(MstUser entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(MstUser entity) {
            HelpInsertOrUpdateInternally<MstUser, MstUserCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MstUser, MstUserCB> {
            protected MstUserBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MstUserBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MstUser entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MstUser entity) { _bhv.Update(entity); }
            public MstUserCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MstUserCB cb, MstUser entity) {
                cb.Query().SetId_Equal(entity.Id);
            }
            public int CallbackSelectCount(MstUserCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(MstUser entity) {
            HelpInsertOrUpdateInternally<MstUser>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<MstUser> {
            protected MstUserBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(MstUserBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MstUser entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(MstUser entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(MstUser entity) {
            HelpDeleteInternally<MstUser>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MstUser> {
            protected MstUserBhv _bhv;
            public MyInternalDeleteCallback(MstUserBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MstUser entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(MstUser entity) {
            HelpDeleteNonstrictInternally<MstUser>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<MstUser> {
            protected MstUserBhv _bhv;
            public MyInternalDeleteNonstrictCallback(MstUserBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MstUser entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(MstUser entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<MstUser>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<MstUser> {
            protected MstUserBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(MstUserBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MstUser entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MstUser mstUser, MstUserCB cb) {
            AssertObjectNotNull("mstUser", mstUser); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(mstUser);
            FilterEntityOfUpdate(mstUser); AssertEntityOfUpdate(mstUser);
            return this.Dao.UpdateByQuery(cb, mstUser);
        }

        public int QueryDelete(MstUserCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(Entity entity) {
            return Downcast(entity).VersionNo != null;
        }

        protected override bool HasUpdateDateValue(Entity entity) {
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(MstUserCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MstUser> DelegateSelectList(MstUserCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MstUser e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MstUser e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(MstUser e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MstUser e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(MstUser e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MstUser Downcast(Entity entity) {
            return (MstUser)entity;
        }

        protected MstUserCB Downcast(ConditionBean cb) {
            return (MstUserCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MstUserDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
