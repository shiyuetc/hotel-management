
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
    public partial class USERBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected USERDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public USERBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "USER"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return USERDbm.GetInstance(); } }
        public USERDbm MyDBMeta { get { return USERDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual USER NewMyEntity() { return new USER(); }
        public virtual USERCB NewMyConditionBean() { return new USERCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(USERCB cb) {
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
        public virtual USER SelectEntity(USERCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<USER> ls = null;
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
            return (USER)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual USER SelectEntityWithDeletedCheck(USERCB cb) {
            AssertConditionBeanNotNull(cb);
            USER entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual USER SelectByPKValue(int? iD) {
            return SelectEntity(BuildPKCB(iD));
        }

        public virtual USER SelectByPKValueWithDeletedCheck(int? iD) {
            return SelectEntityWithDeletedCheck(BuildPKCB(iD));
        }

        private USERCB BuildPKCB(int? iD) {
            AssertObjectNotNull("iD", iD);
            USERCB cb = NewMyConditionBean();
            cb.Query().SetID_Equal(iD);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<USER> SelectList(USERCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<USER>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<USER> SelectPage(USERCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<USER> invoker = new PagingInvoker<USER>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<USER> {
            protected USERBhv _bhv; protected USERCB _cb;
            public InternalSelectPagingHandler(USERBhv bhv, USERCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<USER> Paging() { return _bhv.SelectList(_cb); }
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
        public virtual void Insert(USER entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(USER entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(USER entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(USER entity) {
            HelpInsertOrUpdateInternally<USER, USERCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<USER, USERCB> {
            protected USERBhv _bhv;
            public MyInternalInsertOrUpdateCallback(USERBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(USER entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(USER entity) { _bhv.Update(entity); }
            public USERCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(USERCB cb, USER entity) {
                cb.Query().SetID_Equal(entity.ID);
            }
            public int CallbackSelectCount(USERCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(USER entity) {
            HelpInsertOrUpdateInternally<USER>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<USER> {
            protected USERBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(USERBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(USER entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(USER entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(USER entity) {
            HelpDeleteInternally<USER>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<USER> {
            protected USERBhv _bhv;
            public MyInternalDeleteCallback(USERBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(USER entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(USER entity) {
            HelpDeleteNonstrictInternally<USER>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<USER> {
            protected USERBhv _bhv;
            public MyInternalDeleteNonstrictCallback(USERBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(USER entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(USER entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<USER>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<USER> {
            protected USERBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(USERBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(USER entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(USER uSER, USERCB cb) {
            AssertObjectNotNull("uSER", uSER); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(uSER);
            FilterEntityOfUpdate(uSER); AssertEntityOfUpdate(uSER);
            return this.Dao.UpdateByQuery(cb, uSER);
        }

        public int QueryDelete(USERCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(Entity entity) {
            return Downcast(entity).VERSION_NO != null;
        }

        protected override bool HasUpdateDateValue(Entity entity) {
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(USERCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<USER> DelegateSelectList(USERCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(USER e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(USER e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(USER e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(USER e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(USER e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected USER Downcast(Entity entity) {
            return (USER)entity;
        }

        protected USERCB Downcast(ConditionBean cb) {
            return (USERCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual USERDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
