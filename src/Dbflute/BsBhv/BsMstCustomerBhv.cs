
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
    public partial class MstCustomerBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MstCustomerDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MstCustomerBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst_customer"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return MstCustomerDbm.GetInstance(); } }
        public MstCustomerDbm MyDBMeta { get { return MstCustomerDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MstCustomer NewMyEntity() { return new MstCustomer(); }
        public virtual MstCustomerCB NewMyConditionBean() { return new MstCustomerCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MstCustomerCB cb) {
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
        public virtual MstCustomer SelectEntity(MstCustomerCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MstCustomer> ls = null;
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
            return (MstCustomer)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MstCustomer SelectEntityWithDeletedCheck(MstCustomerCB cb) {
            AssertConditionBeanNotNull(cb);
            MstCustomer entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MstCustomer SelectByPKValue(int? id) {
            return SelectEntity(BuildPKCB(id));
        }

        public virtual MstCustomer SelectByPKValueWithDeletedCheck(int? id) {
            return SelectEntityWithDeletedCheck(BuildPKCB(id));
        }

        private MstCustomerCB BuildPKCB(int? id) {
            AssertObjectNotNull("id", id);
            MstCustomerCB cb = NewMyConditionBean();
            cb.Query().SetId_Equal(id);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<MstCustomer> SelectList(MstCustomerCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<MstCustomer>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<MstCustomer> SelectPage(MstCustomerCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<MstCustomer> invoker = new PagingInvoker<MstCustomer>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<MstCustomer> {
            protected MstCustomerBhv _bhv; protected MstCustomerCB _cb;
            public InternalSelectPagingHandler(MstCustomerBhv bhv, MstCustomerCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MstCustomer> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                        Sequence
        //                                                                        ========
        public int? SelectNextVal() {
            return DelegateSelectNextVal();
        }
        protected override void SetupNextValueToPrimaryKey(Entity entity) {// Very Internal
            MstCustomer myEntity = (MstCustomer)entity;
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
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MstCustomer entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MstCustomer entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(MstCustomer entity) {
            HelpInsertOrUpdateInternally<MstCustomer, MstCustomerCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MstCustomer, MstCustomerCB> {
            protected MstCustomerBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MstCustomerBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MstCustomer entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MstCustomer entity) { _bhv.Update(entity); }
            public MstCustomerCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MstCustomerCB cb, MstCustomer entity) {
                cb.Query().SetId_Equal(entity.Id);
            }
            public int CallbackSelectCount(MstCustomerCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(MstCustomer entity) {
            HelpDeleteInternally<MstCustomer>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MstCustomer> {
            protected MstCustomerBhv _bhv;
            public MyInternalDeleteCallback(MstCustomerBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MstCustomer entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MstCustomer mstCustomer, MstCustomerCB cb) {
            AssertObjectNotNull("mstCustomer", mstCustomer); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(mstCustomer);
            FilterEntityOfUpdate(mstCustomer); AssertEntityOfUpdate(mstCustomer);
            return this.Dao.UpdateByQuery(cb, mstCustomer);
        }

        public int QueryDelete(MstCustomerCB cb) {
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
        protected int DelegateSelectCount(MstCustomerCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MstCustomer> DelegateSelectList(MstCustomerCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }
        protected int? DelegateSelectNextVal() { return this.Dao.SelectNextVal(); }

        protected int DelegateInsert(MstCustomer e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MstCustomer e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MstCustomer e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MstCustomer Downcast(Entity entity) {
            return (MstCustomer)entity;
        }

        protected MstCustomerCB Downcast(ConditionBean cb) {
            return (MstCustomerCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MstCustomerDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
