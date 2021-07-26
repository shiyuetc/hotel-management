
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
    public partial class Dch客室利用予定台帳Bhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Dch客室利用予定台帳Dao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Dch客室利用予定台帳Bhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "dch客室利用予定台帳"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Dch客室利用予定台帳Dbm.GetInstance(); } }
        public Dch客室利用予定台帳Dbm MyDBMeta { get { return Dch客室利用予定台帳Dbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Dch客室利用予定台帳 NewMyEntity() { return new Dch客室利用予定台帳(); }
        public virtual Dch客室利用予定台帳CB NewMyConditionBean() { return new Dch客室利用予定台帳CB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Dch客室利用予定台帳CB cb) {
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
        public virtual Dch客室利用予定台帳 SelectEntity(Dch客室利用予定台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Dch客室利用予定台帳> ls = null;
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
            return (Dch客室利用予定台帳)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Dch客室利用予定台帳 SelectEntityWithDeletedCheck(Dch客室利用予定台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            Dch客室利用予定台帳 entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Dch客室利用予定台帳 SelectByPKValue(long? id) {
            return SelectEntity(BuildPKCB(id));
        }

        public virtual Dch客室利用予定台帳 SelectByPKValueWithDeletedCheck(long? id) {
            return SelectEntityWithDeletedCheck(BuildPKCB(id));
        }

        private Dch客室利用予定台帳CB BuildPKCB(long? id) {
            AssertObjectNotNull("id", id);
            Dch客室利用予定台帳CB cb = NewMyConditionBean();
            cb.Query().SetId_Equal(id);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Dch客室利用予定台帳> SelectList(Dch客室利用予定台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Dch客室利用予定台帳>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Dch客室利用予定台帳> SelectPage(Dch客室利用予定台帳CB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Dch客室利用予定台帳> invoker = new PagingInvoker<Dch客室利用予定台帳>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Dch客室利用予定台帳> {
            protected Dch客室利用予定台帳Bhv _bhv; protected Dch客室利用予定台帳CB _cb;
            public InternalSelectPagingHandler(Dch客室利用予定台帳Bhv bhv, Dch客室利用予定台帳CB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Dch客室利用予定台帳> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                        Sequence
        //                                                                        ========
        public long? SelectNextVal() {
            return DelegateSelectNextVal();
        }
        protected override void SetupNextValueToPrimaryKey(Entity entity) {// Very Internal
            Dch客室利用予定台帳 myEntity = (Dch客室利用予定台帳)entity;
            myEntity.Id = SelectNextVal();
        }

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadDch宿泊予定台帳List(Dch客室利用予定台帳 dch客室利用予定台帳, ConditionBeanSetupper<Dch宿泊予定台帳CB> conditionBeanSetupper) {
            AssertObjectNotNull("dch客室利用予定台帳", dch客室利用予定台帳); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadDch宿泊予定台帳List(xnewLRLs<Dch客室利用予定台帳>(dch客室利用予定台帳), conditionBeanSetupper);
        }
        public virtual void LoadDch宿泊予定台帳List(IList<Dch客室利用予定台帳> dch客室利用予定台帳List, ConditionBeanSetupper<Dch宿泊予定台帳CB> conditionBeanSetupper) {
            AssertObjectNotNull("dch客室利用予定台帳List", dch客室利用予定台帳List); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadDch宿泊予定台帳List(dch客室利用予定台帳List, new LoadReferrerOption<Dch宿泊予定台帳CB, Dch宿泊予定台帳>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadDch宿泊予定台帳List(Dch客室利用予定台帳 dch客室利用予定台帳, LoadReferrerOption<Dch宿泊予定台帳CB, Dch宿泊予定台帳> loadReferrerOption) {
            AssertObjectNotNull("dch客室利用予定台帳", dch客室利用予定台帳); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadDch宿泊予定台帳List(xnewLRLs<Dch客室利用予定台帳>(dch客室利用予定台帳), loadReferrerOption);
        }
        public virtual void LoadDch宿泊予定台帳List(IList<Dch客室利用予定台帳> dch客室利用予定台帳List, LoadReferrerOption<Dch宿泊予定台帳CB, Dch宿泊予定台帳> loadReferrerOption) {
            AssertObjectNotNull("dch客室利用予定台帳List", dch客室利用予定台帳List); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (dch客室利用予定台帳List.Count == 0) { return; }
            Dch宿泊予定台帳Bhv referrerBhv = xgetBSFLR().Select<Dch宿泊予定台帳Bhv>();
            HelpLoadReferrerInternally<Dch客室利用予定台帳, long?, Dch宿泊予定台帳CB, Dch宿泊予定台帳>
                    (dch客室利用予定台帳List, loadReferrerOption, new MyInternalLoadDch宿泊予定台帳ListCallback(referrerBhv));
        }
        protected class MyInternalLoadDch宿泊予定台帳ListCallback : InternalLoadReferrerCallback<Dch客室利用予定台帳, long?, Dch宿泊予定台帳CB, Dch宿泊予定台帳> {
            protected Dch宿泊予定台帳Bhv referrerBhv;
            public MyInternalLoadDch宿泊予定台帳ListCallback(Dch宿泊予定台帳Bhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(Dch客室利用予定台帳 e) { return e.Id; }
            public void setRfLs(Dch客室利用予定台帳 e, IList<Dch宿泊予定台帳> ls) { e.Dch宿泊予定台帳List = ls; }
            public Dch宿泊予定台帳CB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(Dch宿泊予定台帳CB cb, IList<long?> ls) { cb.Query().Set客室利用予定台帳id_InScope(ls); }
            public void qyOdFKAsc(Dch宿泊予定台帳CB cb) { cb.Query().AddOrderBy_客室利用予定台帳id_Asc(); }
            public void spFKCol(Dch宿泊予定台帳CB cb) { cb.Specify().Column客室利用予定台帳id(); }
            public IList<Dch宿泊予定台帳> selRfLs(Dch宿泊予定台帳CB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(Dch宿泊予定台帳 e) { return e.客室利用予定台帳id; }
            public void setlcEt(Dch宿泊予定台帳 re, Dch客室利用予定台帳 be) { re.Dch客室利用予定台帳 = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<Mst客室マスタ> PulloutMst客室マスタ(IList<Dch客室利用予定台帳> dch客室利用予定台帳List) {
            return HelpPulloutInternally<Dch客室利用予定台帳, Mst客室マスタ>(dch客室利用予定台帳List, new MyInternalPulloutMst客室マスタCallback());
        }
        protected class MyInternalPulloutMst客室マスタCallback : InternalPulloutCallback<Dch客室利用予定台帳, Mst客室マスタ> {
            public Mst客室マスタ getFr(Dch客室利用予定台帳 entity) { return entity.Mst客室マスタ; }
        }
        public IList<Kbn客室利用区分> PulloutKbn客室利用区分(IList<Dch客室利用予定台帳> dch客室利用予定台帳List) {
            return HelpPulloutInternally<Dch客室利用予定台帳, Kbn客室利用区分>(dch客室利用予定台帳List, new MyInternalPulloutKbn客室利用区分Callback());
        }
        protected class MyInternalPulloutKbn客室利用区分Callback : InternalPulloutCallback<Dch客室利用予定台帳, Kbn客室利用区分> {
            public Kbn客室利用区分 getFr(Dch客室利用予定台帳 entity) { return entity.Kbn客室利用区分; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(Dch客室利用予定台帳 entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Dch客室利用予定台帳 entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Dch客室利用予定台帳 entity) {
            HelpInsertOrUpdateInternally<Dch客室利用予定台帳, Dch客室利用予定台帳CB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Dch客室利用予定台帳, Dch客室利用予定台帳CB> {
            protected Dch客室利用予定台帳Bhv _bhv;
            public MyInternalInsertOrUpdateCallback(Dch客室利用予定台帳Bhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Dch客室利用予定台帳 entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Dch客室利用予定台帳 entity) { _bhv.Update(entity); }
            public Dch客室利用予定台帳CB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Dch客室利用予定台帳CB cb, Dch客室利用予定台帳 entity) {
                cb.Query().SetId_Equal(entity.Id);
            }
            public int CallbackSelectCount(Dch客室利用予定台帳CB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Dch客室利用予定台帳 entity) {
            HelpDeleteInternally<Dch客室利用予定台帳>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Dch客室利用予定台帳> {
            protected Dch客室利用予定台帳Bhv _bhv;
            public MyInternalDeleteCallback(Dch客室利用予定台帳Bhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Dch客室利用予定台帳 entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Dch客室利用予定台帳 dch客室利用予定台帳, Dch客室利用予定台帳CB cb) {
            AssertObjectNotNull("dch客室利用予定台帳", dch客室利用予定台帳); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(dch客室利用予定台帳);
            FilterEntityOfUpdate(dch客室利用予定台帳); AssertEntityOfUpdate(dch客室利用予定台帳);
            return this.Dao.UpdateByQuery(cb, dch客室利用予定台帳);
        }

        public int QueryDelete(Dch客室利用予定台帳CB cb) {
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
        protected int DelegateSelectCount(Dch客室利用予定台帳CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Dch客室利用予定台帳> DelegateSelectList(Dch客室利用予定台帳CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }
        protected long? DelegateSelectNextVal() { return this.Dao.SelectNextVal(); }

        protected int DelegateInsert(Dch客室利用予定台帳 e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Dch客室利用予定台帳 e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Dch客室利用予定台帳 e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Dch客室利用予定台帳 Downcast(Entity entity) {
            return (Dch客室利用予定台帳)entity;
        }

        protected Dch客室利用予定台帳CB Downcast(ConditionBean cb) {
            return (Dch客室利用予定台帳CB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Dch客室利用予定台帳Dao Dao { get { return _dao; } set { _dao = value; } }
    }
}
