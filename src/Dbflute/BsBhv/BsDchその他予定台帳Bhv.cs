
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
    public partial class Dchその他予定台帳Bhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Dchその他予定台帳Dao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Dchその他予定台帳Bhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "dchその他予定台帳"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Dchその他予定台帳Dbm.GetInstance(); } }
        public Dchその他予定台帳Dbm MyDBMeta { get { return Dchその他予定台帳Dbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Dchその他予定台帳 NewMyEntity() { return new Dchその他予定台帳(); }
        public virtual Dchその他予定台帳CB NewMyConditionBean() { return new Dchその他予定台帳CB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Dchその他予定台帳CB cb) {
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
        public virtual Dchその他予定台帳 SelectEntity(Dchその他予定台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Dchその他予定台帳> ls = null;
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
            return (Dchその他予定台帳)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Dchその他予定台帳 SelectEntityWithDeletedCheck(Dchその他予定台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            Dchその他予定台帳 entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Dchその他予定台帳 SelectByPKValue(long? id) {
            return SelectEntity(BuildPKCB(id));
        }

        public virtual Dchその他予定台帳 SelectByPKValueWithDeletedCheck(long? id) {
            return SelectEntityWithDeletedCheck(BuildPKCB(id));
        }

        private Dchその他予定台帳CB BuildPKCB(long? id) {
            AssertObjectNotNull("id", id);
            Dchその他予定台帳CB cb = NewMyConditionBean();
            cb.Query().SetId_Equal(id);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Dchその他予定台帳> SelectList(Dchその他予定台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Dchその他予定台帳>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Dchその他予定台帳> SelectPage(Dchその他予定台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Dchその他予定台帳> invoker = new PagingInvoker<Dchその他予定台帳>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Dchその他予定台帳> {
            protected Dchその他予定台帳Bhv _bhv; protected Dchその他予定台帳CB _cb;
            public InternalSelectPagingHandler(Dchその他予定台帳Bhv bhv, Dchその他予定台帳CB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Dchその他予定台帳> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                        Sequence
        //                                                                        ========
        public long? SelectNextVal() {
            return DelegateSelectNextVal();
        }
        protected override void SetupNextValueToPrimaryKey(Entity entity) {// Very Internal
            Dchその他予定台帳 myEntity = (Dchその他予定台帳)entity;
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
        public IList<Dch客室利用予定台帳> PulloutDch客室利用予定台帳(IList<Dchその他予定台帳> dchその他予定台帳List) {
            return HelpPulloutInternally<Dchその他予定台帳, Dch客室利用予定台帳>(dchその他予定台帳List, new MyInternalPulloutDch客室利用予定台帳Callback());
        }
        protected class MyInternalPulloutDch客室利用予定台帳Callback : InternalPulloutCallback<Dchその他予定台帳, Dch客室利用予定台帳> {
            public Dch客室利用予定台帳 getFr(Dchその他予定台帳 entity) { return entity.Dch客室利用予定台帳; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(Dchその他予定台帳 entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Dchその他予定台帳 entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Dchその他予定台帳 entity) {
            HelpInsertOrUpdateInternally<Dchその他予定台帳, Dchその他予定台帳CB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Dchその他予定台帳, Dchその他予定台帳CB> {
            protected Dchその他予定台帳Bhv _bhv;
            public MyInternalInsertOrUpdateCallback(Dchその他予定台帳Bhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Dchその他予定台帳 entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Dchその他予定台帳 entity) { _bhv.Update(entity); }
            public Dchその他予定台帳CB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Dchその他予定台帳CB cb, Dchその他予定台帳 entity) {
                cb.Query().SetId_Equal(entity.Id);
            }
            public int CallbackSelectCount(Dchその他予定台帳CB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Dchその他予定台帳 entity) {
            HelpDeleteInternally<Dchその他予定台帳>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Dchその他予定台帳> {
            protected Dchその他予定台帳Bhv _bhv;
            public MyInternalDeleteCallback(Dchその他予定台帳Bhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Dchその他予定台帳 entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Dchその他予定台帳 dchその他予定台帳, Dchその他予定台帳CB cb) {
            AssertObjectNotNull("dchその他予定台帳", dchその他予定台帳); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(dchその他予定台帳);
            FilterEntityOfUpdate(dchその他予定台帳); AssertEntityOfUpdate(dchその他予定台帳);
            return this.Dao.UpdateByQuery(cb, dchその他予定台帳);
        }

        public int QueryDelete(Dchその他予定台帳CB cb) {
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
        protected int DelegateSelectCount(Dchその他予定台帳CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Dchその他予定台帳> DelegateSelectList(Dchその他予定台帳CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }
        protected long? DelegateSelectNextVal() { return this.Dao.SelectNextVal(); }

        protected int DelegateInsert(Dchその他予定台帳 e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Dchその他予定台帳 e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Dchその他予定台帳 e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Dchその他予定台帳 Downcast(Entity entity) {
            return (Dchその他予定台帳)entity;
        }

        protected Dchその他予定台帳CB Downcast(ConditionBean cb) {
            return (Dchその他予定台帳CB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Dchその他予定台帳Dao Dao { get { return _dao; } set { _dao = value; } }
    }
}
