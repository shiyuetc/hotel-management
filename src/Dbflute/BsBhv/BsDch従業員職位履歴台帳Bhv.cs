
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
    public partial class Dch従業員職位履歴台帳Bhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Dch従業員職位履歴台帳Dao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Dch従業員職位履歴台帳Bhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "dch従業員職位履歴台帳"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Dch従業員職位履歴台帳Dbm.GetInstance(); } }
        public Dch従業員職位履歴台帳Dbm MyDBMeta { get { return Dch従業員職位履歴台帳Dbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Dch従業員職位履歴台帳 NewMyEntity() { return new Dch従業員職位履歴台帳(); }
        public virtual Dch従業員職位履歴台帳CB NewMyConditionBean() { return new Dch従業員職位履歴台帳CB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Dch従業員職位履歴台帳CB cb) {
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
        public virtual Dch従業員職位履歴台帳 SelectEntity(Dch従業員職位履歴台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Dch従業員職位履歴台帳> ls = null;
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
            return (Dch従業員職位履歴台帳)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Dch従業員職位履歴台帳 SelectEntityWithDeletedCheck(Dch従業員職位履歴台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            Dch従業員職位履歴台帳 entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Dch従業員職位履歴台帳 SelectByPKValue(long? id) {
            return SelectEntity(BuildPKCB(id));
        }

        public virtual Dch従業員職位履歴台帳 SelectByPKValueWithDeletedCheck(long? id) {
            return SelectEntityWithDeletedCheck(BuildPKCB(id));
        }

        private Dch従業員職位履歴台帳CB BuildPKCB(long? id) {
            AssertObjectNotNull("id", id);
            Dch従業員職位履歴台帳CB cb = NewMyConditionBean();
            cb.Query().SetId_Equal(id);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Dch従業員職位履歴台帳> SelectList(Dch従業員職位履歴台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Dch従業員職位履歴台帳>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Dch従業員職位履歴台帳> SelectPage(Dch従業員職位履歴台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Dch従業員職位履歴台帳> invoker = new PagingInvoker<Dch従業員職位履歴台帳>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Dch従業員職位履歴台帳> {
            protected Dch従業員職位履歴台帳Bhv _bhv; protected Dch従業員職位履歴台帳CB _cb;
            public InternalSelectPagingHandler(Dch従業員職位履歴台帳Bhv bhv, Dch従業員職位履歴台帳CB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Dch従業員職位履歴台帳> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                        Sequence
        //                                                                        ========
        public long? SelectNextVal() {
            return DelegateSelectNextVal();
        }
        protected override void SetupNextValueToPrimaryKey(Entity entity) {// Very Internal
            Dch従業員職位履歴台帳 myEntity = (Dch従業員職位履歴台帳)entity;
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
        public IList<Mst従業員マスタ> PulloutMst従業員マスタ(IList<Dch従業員職位履歴台帳> dch従業員職位履歴台帳List) {
            return HelpPulloutInternally<Dch従業員職位履歴台帳, Mst従業員マスタ>(dch従業員職位履歴台帳List, new MyInternalPulloutMst従業員マスタCallback());
        }
        protected class MyInternalPulloutMst従業員マスタCallback : InternalPulloutCallback<Dch従業員職位履歴台帳, Mst従業員マスタ> {
            public Mst従業員マスタ getFr(Dch従業員職位履歴台帳 entity) { return entity.Mst従業員マスタ; }
        }
        public IList<Kbn職位区分> PulloutKbn職位区分(IList<Dch従業員職位履歴台帳> dch従業員職位履歴台帳List) {
            return HelpPulloutInternally<Dch従業員職位履歴台帳, Kbn職位区分>(dch従業員職位履歴台帳List, new MyInternalPulloutKbn職位区分Callback());
        }
        protected class MyInternalPulloutKbn職位区分Callback : InternalPulloutCallback<Dch従業員職位履歴台帳, Kbn職位区分> {
            public Kbn職位区分 getFr(Dch従業員職位履歴台帳 entity) { return entity.Kbn職位区分; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(Dch従業員職位履歴台帳 entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Dch従業員職位履歴台帳 entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Dch従業員職位履歴台帳 entity) {
            HelpInsertOrUpdateInternally<Dch従業員職位履歴台帳, Dch従業員職位履歴台帳CB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Dch従業員職位履歴台帳, Dch従業員職位履歴台帳CB> {
            protected Dch従業員職位履歴台帳Bhv _bhv;
            public MyInternalInsertOrUpdateCallback(Dch従業員職位履歴台帳Bhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Dch従業員職位履歴台帳 entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Dch従業員職位履歴台帳 entity) { _bhv.Update(entity); }
            public Dch従業員職位履歴台帳CB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Dch従業員職位履歴台帳CB cb, Dch従業員職位履歴台帳 entity) {
                cb.Query().SetId_Equal(entity.Id);
            }
            public int CallbackSelectCount(Dch従業員職位履歴台帳CB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Dch従業員職位履歴台帳 entity) {
            HelpDeleteInternally<Dch従業員職位履歴台帳>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Dch従業員職位履歴台帳> {
            protected Dch従業員職位履歴台帳Bhv _bhv;
            public MyInternalDeleteCallback(Dch従業員職位履歴台帳Bhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Dch従業員職位履歴台帳 entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Dch従業員職位履歴台帳 dch従業員職位履歴台帳, Dch従業員職位履歴台帳CB cb) {
            AssertObjectNotNull("dch従業員職位履歴台帳", dch従業員職位履歴台帳); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(dch従業員職位履歴台帳);
            FilterEntityOfUpdate(dch従業員職位履歴台帳); AssertEntityOfUpdate(dch従業員職位履歴台帳);
            return this.Dao.UpdateByQuery(cb, dch従業員職位履歴台帳);
        }

        public int QueryDelete(Dch従業員職位履歴台帳CB cb) {
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
        protected int DelegateSelectCount(Dch従業員職位履歴台帳CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Dch従業員職位履歴台帳> DelegateSelectList(Dch従業員職位履歴台帳CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }
        protected long? DelegateSelectNextVal() { return this.Dao.SelectNextVal(); }

        protected int DelegateInsert(Dch従業員職位履歴台帳 e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Dch従業員職位履歴台帳 e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Dch従業員職位履歴台帳 e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Dch従業員職位履歴台帳 Downcast(Entity entity) {
            return (Dch従業員職位履歴台帳)entity;
        }

        protected Dch従業員職位履歴台帳CB Downcast(ConditionBean cb) {
            return (Dch従業員職位履歴台帳CB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Dch従業員職位履歴台帳Dao Dao { get { return _dao; } set { _dao = value; } }
    }
}
