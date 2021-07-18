
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
    public partial class Dch清掃実績台帳Bhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Dch清掃実績台帳Dao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Dch清掃実績台帳Bhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "dch清掃実績台帳"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Dch清掃実績台帳Dbm.GetInstance(); } }
        public Dch清掃実績台帳Dbm MyDBMeta { get { return Dch清掃実績台帳Dbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Dch清掃実績台帳 NewMyEntity() { return new Dch清掃実績台帳(); }
        public virtual Dch清掃実績台帳CB NewMyConditionBean() { return new Dch清掃実績台帳CB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Dch清掃実績台帳CB cb) {
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
        public virtual Dch清掃実績台帳 SelectEntity(Dch清掃実績台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Dch清掃実績台帳> ls = null;
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
            return (Dch清掃実績台帳)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Dch清掃実績台帳 SelectEntityWithDeletedCheck(Dch清掃実績台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            Dch清掃実績台帳 entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Dch清掃実績台帳 SelectByPKValue(long? id) {
            return SelectEntity(BuildPKCB(id));
        }

        public virtual Dch清掃実績台帳 SelectByPKValueWithDeletedCheck(long? id) {
            return SelectEntityWithDeletedCheck(BuildPKCB(id));
        }

        private Dch清掃実績台帳CB BuildPKCB(long? id) {
            AssertObjectNotNull("id", id);
            Dch清掃実績台帳CB cb = NewMyConditionBean();
            cb.Query().SetId_Equal(id);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Dch清掃実績台帳> SelectList(Dch清掃実績台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Dch清掃実績台帳>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Dch清掃実績台帳> SelectPage(Dch清掃実績台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Dch清掃実績台帳> invoker = new PagingInvoker<Dch清掃実績台帳>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Dch清掃実績台帳> {
            protected Dch清掃実績台帳Bhv _bhv; protected Dch清掃実績台帳CB _cb;
            public InternalSelectPagingHandler(Dch清掃実績台帳Bhv bhv, Dch清掃実績台帳CB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Dch清掃実績台帳> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                        Sequence
        //                                                                        ========
        public long? SelectNextVal() {
            return DelegateSelectNextVal();
        }
        protected override void SetupNextValueToPrimaryKey(Entity entity) {// Very Internal
            Dch清掃実績台帳 myEntity = (Dch清掃実績台帳)entity;
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
        public IList<Dch客室利用実績台帳> PulloutDch客室利用実績台帳(IList<Dch清掃実績台帳> dch清掃実績台帳List) {
            return HelpPulloutInternally<Dch清掃実績台帳, Dch客室利用実績台帳>(dch清掃実績台帳List, new MyInternalPulloutDch客室利用実績台帳Callback());
        }
        protected class MyInternalPulloutDch客室利用実績台帳Callback : InternalPulloutCallback<Dch清掃実績台帳, Dch客室利用実績台帳> {
            public Dch客室利用実績台帳 getFr(Dch清掃実績台帳 entity) { return entity.Dch客室利用実績台帳; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(Dch清掃実績台帳 entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Dch清掃実績台帳 entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Dch清掃実績台帳 entity) {
            HelpInsertOrUpdateInternally<Dch清掃実績台帳, Dch清掃実績台帳CB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Dch清掃実績台帳, Dch清掃実績台帳CB> {
            protected Dch清掃実績台帳Bhv _bhv;
            public MyInternalInsertOrUpdateCallback(Dch清掃実績台帳Bhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Dch清掃実績台帳 entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Dch清掃実績台帳 entity) { _bhv.Update(entity); }
            public Dch清掃実績台帳CB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Dch清掃実績台帳CB cb, Dch清掃実績台帳 entity) {
                cb.Query().SetId_Equal(entity.Id);
            }
            public int CallbackSelectCount(Dch清掃実績台帳CB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Dch清掃実績台帳 entity) {
            HelpDeleteInternally<Dch清掃実績台帳>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Dch清掃実績台帳> {
            protected Dch清掃実績台帳Bhv _bhv;
            public MyInternalDeleteCallback(Dch清掃実績台帳Bhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Dch清掃実績台帳 entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Dch清掃実績台帳 dch清掃実績台帳, Dch清掃実績台帳CB cb) {
            AssertObjectNotNull("dch清掃実績台帳", dch清掃実績台帳); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(dch清掃実績台帳);
            FilterEntityOfUpdate(dch清掃実績台帳); AssertEntityOfUpdate(dch清掃実績台帳);
            return this.Dao.UpdateByQuery(cb, dch清掃実績台帳);
        }

        public int QueryDelete(Dch清掃実績台帳CB cb) {
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
        protected int DelegateSelectCount(Dch清掃実績台帳CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Dch清掃実績台帳> DelegateSelectList(Dch清掃実績台帳CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }
        protected long? DelegateSelectNextVal() { return this.Dao.SelectNextVal(); }

        protected int DelegateInsert(Dch清掃実績台帳 e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Dch清掃実績台帳 e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Dch清掃実績台帳 e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Dch清掃実績台帳 Downcast(Entity entity) {
            return (Dch清掃実績台帳)entity;
        }

        protected Dch清掃実績台帳CB Downcast(ConditionBean cb) {
            return (Dch清掃実績台帳CB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Dch清掃実績台帳Dao Dao { get { return _dao; } set { _dao = value; } }
    }
}
