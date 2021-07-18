
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
    public partial class Mst従業員マスタBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mst従業員マスタDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mst従業員マスタBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst従業員マスタ"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Mst従業員マスタDbm.GetInstance(); } }
        public Mst従業員マスタDbm MyDBMeta { get { return Mst従業員マスタDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Mst従業員マスタ NewMyEntity() { return new Mst従業員マスタ(); }
        public virtual Mst従業員マスタCB NewMyConditionBean() { return new Mst従業員マスタCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Mst従業員マスタCB cb) {
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
        public virtual Mst従業員マスタ SelectEntity(Mst従業員マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Mst従業員マスタ> ls = null;
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
            return (Mst従業員マスタ)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Mst従業員マスタ SelectEntityWithDeletedCheck(Mst従業員マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            Mst従業員マスタ entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Mst従業員マスタ SelectByPKValue(long? id) {
            return SelectEntity(BuildPKCB(id));
        }

        public virtual Mst従業員マスタ SelectByPKValueWithDeletedCheck(long? id) {
            return SelectEntityWithDeletedCheck(BuildPKCB(id));
        }

        private Mst従業員マスタCB BuildPKCB(long? id) {
            AssertObjectNotNull("id", id);
            Mst従業員マスタCB cb = NewMyConditionBean();
            cb.Query().SetId_Equal(id);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Mst従業員マスタ> SelectList(Mst従業員マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Mst従業員マスタ>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Mst従業員マスタ> SelectPage(Mst従業員マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Mst従業員マスタ> invoker = new PagingInvoker<Mst従業員マスタ>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Mst従業員マスタ> {
            protected Mst従業員マスタBhv _bhv; protected Mst従業員マスタCB _cb;
            public InternalSelectPagingHandler(Mst従業員マスタBhv bhv, Mst従業員マスタCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Mst従業員マスタ> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                        Sequence
        //                                                                        ========
        public long? SelectNextVal() {
            return DelegateSelectNextVal();
        }
        protected override void SetupNextValueToPrimaryKey(Entity entity) {// Very Internal
            Mst従業員マスタ myEntity = (Mst従業員マスタ)entity;
            myEntity.Id = SelectNextVal();
        }

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadDch従業員職位履歴台帳List(Mst従業員マスタ mst従業員マスタ, ConditionBeanSetupper<Dch従業員職位履歴台帳CB> conditionBeanSetupper) {
            AssertObjectNotNull("mst従業員マスタ", mst従業員マスタ); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadDch従業員職位履歴台帳List(xnewLRLs<Mst従業員マスタ>(mst従業員マスタ), conditionBeanSetupper);
        }
        public virtual void LoadDch従業員職位履歴台帳List(IList<Mst従業員マスタ> mst従業員マスタList, ConditionBeanSetupper<Dch従業員職位履歴台帳CB> conditionBeanSetupper) {
            AssertObjectNotNull("mst従業員マスタList", mst従業員マスタList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadDch従業員職位履歴台帳List(mst従業員マスタList, new LoadReferrerOption<Dch従業員職位履歴台帳CB, Dch従業員職位履歴台帳>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadDch従業員職位履歴台帳List(Mst従業員マスタ mst従業員マスタ, LoadReferrerOption<Dch従業員職位履歴台帳CB, Dch従業員職位履歴台帳> loadReferrerOption) {
            AssertObjectNotNull("mst従業員マスタ", mst従業員マスタ); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadDch従業員職位履歴台帳List(xnewLRLs<Mst従業員マスタ>(mst従業員マスタ), loadReferrerOption);
        }
        public virtual void LoadDch従業員職位履歴台帳List(IList<Mst従業員マスタ> mst従業員マスタList, LoadReferrerOption<Dch従業員職位履歴台帳CB, Dch従業員職位履歴台帳> loadReferrerOption) {
            AssertObjectNotNull("mst従業員マスタList", mst従業員マスタList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (mst従業員マスタList.Count == 0) { return; }
            Dch従業員職位履歴台帳Bhv referrerBhv = xgetBSFLR().Select<Dch従業員職位履歴台帳Bhv>();
            HelpLoadReferrerInternally<Mst従業員マスタ, long?, Dch従業員職位履歴台帳CB, Dch従業員職位履歴台帳>
                    (mst従業員マスタList, loadReferrerOption, new MyInternalLoadDch従業員職位履歴台帳ListCallback(referrerBhv));
        }
        protected class MyInternalLoadDch従業員職位履歴台帳ListCallback : InternalLoadReferrerCallback<Mst従業員マスタ, long?, Dch従業員職位履歴台帳CB, Dch従業員職位履歴台帳> {
            protected Dch従業員職位履歴台帳Bhv referrerBhv;
            public MyInternalLoadDch従業員職位履歴台帳ListCallback(Dch従業員職位履歴台帳Bhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(Mst従業員マスタ e) { return e.Id; }
            public void setRfLs(Mst従業員マスタ e, IList<Dch従業員職位履歴台帳> ls) { e.Dch従業員職位履歴台帳List = ls; }
            public Dch従業員職位履歴台帳CB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(Dch従業員職位履歴台帳CB cb, IList<long?> ls) { cb.Query().Set従業員id_InScope(ls); }
            public void qyOdFKAsc(Dch従業員職位履歴台帳CB cb) { cb.Query().AddOrderBy_従業員id_Asc(); }
            public void spFKCol(Dch従業員職位履歴台帳CB cb) { cb.Specify().Column従業員id(); }
            public IList<Dch従業員職位履歴台帳> selRfLs(Dch従業員職位履歴台帳CB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(Dch従業員職位履歴台帳 e) { return e.従業員id; }
            public void setlcEt(Dch従業員職位履歴台帳 re, Mst従業員マスタ be) { re.Mst従業員マスタ = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<Kbn職位区分> PulloutKbn職位区分(IList<Mst従業員マスタ> mst従業員マスタList) {
            return HelpPulloutInternally<Mst従業員マスタ, Kbn職位区分>(mst従業員マスタList, new MyInternalPulloutKbn職位区分Callback());
        }
        protected class MyInternalPulloutKbn職位区分Callback : InternalPulloutCallback<Mst従業員マスタ, Kbn職位区分> {
            public Kbn職位区分 getFr(Mst従業員マスタ entity) { return entity.Kbn職位区分; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(Mst従業員マスタ entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Mst従業員マスタ entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Mst従業員マスタ entity) {
            HelpInsertOrUpdateInternally<Mst従業員マスタ, Mst従業員マスタCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Mst従業員マスタ, Mst従業員マスタCB> {
            protected Mst従業員マスタBhv _bhv;
            public MyInternalInsertOrUpdateCallback(Mst従業員マスタBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Mst従業員マスタ entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Mst従業員マスタ entity) { _bhv.Update(entity); }
            public Mst従業員マスタCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Mst従業員マスタCB cb, Mst従業員マスタ entity) {
                cb.Query().SetId_Equal(entity.Id);
            }
            public int CallbackSelectCount(Mst従業員マスタCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Mst従業員マスタ entity) {
            HelpDeleteInternally<Mst従業員マスタ>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Mst従業員マスタ> {
            protected Mst従業員マスタBhv _bhv;
            public MyInternalDeleteCallback(Mst従業員マスタBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Mst従業員マスタ entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Mst従業員マスタ mst従業員マスタ, Mst従業員マスタCB cb) {
            AssertObjectNotNull("mst従業員マスタ", mst従業員マスタ); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(mst従業員マスタ);
            FilterEntityOfUpdate(mst従業員マスタ); AssertEntityOfUpdate(mst従業員マスタ);
            return this.Dao.UpdateByQuery(cb, mst従業員マスタ);
        }

        public int QueryDelete(Mst従業員マスタCB cb) {
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
        protected int DelegateSelectCount(Mst従業員マスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Mst従業員マスタ> DelegateSelectList(Mst従業員マスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }
        protected long? DelegateSelectNextVal() { return this.Dao.SelectNextVal(); }

        protected int DelegateInsert(Mst従業員マスタ e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Mst従業員マスタ e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Mst従業員マスタ e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Mst従業員マスタ Downcast(Entity entity) {
            return (Mst従業員マスタ)entity;
        }

        protected Mst従業員マスタCB Downcast(ConditionBean cb) {
            return (Mst従業員マスタCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Mst従業員マスタDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
