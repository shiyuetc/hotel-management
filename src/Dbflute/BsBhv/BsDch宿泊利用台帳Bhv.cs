
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
    public partial class Dch宿泊利用台帳Bhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Dch宿泊利用台帳Dao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Dch宿泊利用台帳Bhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "dch宿泊利用台帳"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Dch宿泊利用台帳Dbm.GetInstance(); } }
        public Dch宿泊利用台帳Dbm MyDBMeta { get { return Dch宿泊利用台帳Dbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Dch宿泊利用台帳 NewMyEntity() { return new Dch宿泊利用台帳(); }
        public virtual Dch宿泊利用台帳CB NewMyConditionBean() { return new Dch宿泊利用台帳CB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Dch宿泊利用台帳CB cb) {
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
        public virtual Dch宿泊利用台帳 SelectEntity(Dch宿泊利用台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Dch宿泊利用台帳> ls = null;
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
            return (Dch宿泊利用台帳)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Dch宿泊利用台帳 SelectEntityWithDeletedCheck(Dch宿泊利用台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            Dch宿泊利用台帳 entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Dch宿泊利用台帳 SelectByPKValue(long? 客室利用台帳id) {
            return SelectEntity(BuildPKCB(客室利用台帳id));
        }

        public virtual Dch宿泊利用台帳 SelectByPKValueWithDeletedCheck(long? 客室利用台帳id) {
            return SelectEntityWithDeletedCheck(BuildPKCB(客室利用台帳id));
        }

        private Dch宿泊利用台帳CB BuildPKCB(long? 客室利用台帳id) {
            AssertObjectNotNull("客室利用台帳id", 客室利用台帳id);
            Dch宿泊利用台帳CB cb = NewMyConditionBean();
            cb.Query().Set客室利用台帳id_Equal(客室利用台帳id);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Dch宿泊利用台帳> SelectList(Dch宿泊利用台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Dch宿泊利用台帳>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Dch宿泊利用台帳> SelectPage(Dch宿泊利用台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Dch宿泊利用台帳> invoker = new PagingInvoker<Dch宿泊利用台帳>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Dch宿泊利用台帳> {
            protected Dch宿泊利用台帳Bhv _bhv; protected Dch宿泊利用台帳CB _cb;
            public InternalSelectPagingHandler(Dch宿泊利用台帳Bhv bhv, Dch宿泊利用台帳CB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Dch宿泊利用台帳> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<Mst会員マスタ> PulloutMst会員マスタ(IList<Dch宿泊利用台帳> dch宿泊利用台帳List) {
            return HelpPulloutInternally<Dch宿泊利用台帳, Mst会員マスタ>(dch宿泊利用台帳List, new MyInternalPulloutMst会員マスタCallback());
        }
        protected class MyInternalPulloutMst会員マスタCallback : InternalPulloutCallback<Dch宿泊利用台帳, Mst会員マスタ> {
            public Mst会員マスタ getFr(Dch宿泊利用台帳 entity) { return entity.Mst会員マスタ; }
        }
        public IList<Dch客室利用台帳> PulloutDch客室利用台帳(IList<Dch宿泊利用台帳> dch宿泊利用台帳List) {
            return HelpPulloutInternally<Dch宿泊利用台帳, Dch客室利用台帳>(dch宿泊利用台帳List, new MyInternalPulloutDch客室利用台帳Callback());
        }
        protected class MyInternalPulloutDch客室利用台帳Callback : InternalPulloutCallback<Dch宿泊利用台帳, Dch客室利用台帳> {
            public Dch客室利用台帳 getFr(Dch宿泊利用台帳 entity) { return entity.Dch客室利用台帳; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(Dch宿泊利用台帳 entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Dch宿泊利用台帳 entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Dch宿泊利用台帳 entity) {
            HelpInsertOrUpdateInternally<Dch宿泊利用台帳, Dch宿泊利用台帳CB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Dch宿泊利用台帳, Dch宿泊利用台帳CB> {
            protected Dch宿泊利用台帳Bhv _bhv;
            public MyInternalInsertOrUpdateCallback(Dch宿泊利用台帳Bhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Dch宿泊利用台帳 entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Dch宿泊利用台帳 entity) { _bhv.Update(entity); }
            public Dch宿泊利用台帳CB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Dch宿泊利用台帳CB cb, Dch宿泊利用台帳 entity) {
                cb.Query().Set客室利用台帳id_Equal(entity.客室利用台帳id);
            }
            public int CallbackSelectCount(Dch宿泊利用台帳CB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Dch宿泊利用台帳 entity) {
            HelpDeleteInternally<Dch宿泊利用台帳>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Dch宿泊利用台帳> {
            protected Dch宿泊利用台帳Bhv _bhv;
            public MyInternalDeleteCallback(Dch宿泊利用台帳Bhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Dch宿泊利用台帳 entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Dch宿泊利用台帳 dch宿泊利用台帳, Dch宿泊利用台帳CB cb) {
            AssertObjectNotNull("dch宿泊利用台帳", dch宿泊利用台帳); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(dch宿泊利用台帳);
            FilterEntityOfUpdate(dch宿泊利用台帳); AssertEntityOfUpdate(dch宿泊利用台帳);
            return this.Dao.UpdateByQuery(cb, dch宿泊利用台帳);
        }

        public int QueryDelete(Dch宿泊利用台帳CB cb) {
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
        protected int DelegateSelectCount(Dch宿泊利用台帳CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Dch宿泊利用台帳> DelegateSelectList(Dch宿泊利用台帳CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(Dch宿泊利用台帳 e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Dch宿泊利用台帳 e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Dch宿泊利用台帳 e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Dch宿泊利用台帳 Downcast(Entity entity) {
            return (Dch宿泊利用台帳)entity;
        }

        protected Dch宿泊利用台帳CB Downcast(ConditionBean cb) {
            return (Dch宿泊利用台帳CB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Dch宿泊利用台帳Dao Dao { get { return _dao; } set { _dao = value; } }
    }
}
