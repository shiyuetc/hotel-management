
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
    public partial class Mst客室マスタBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mst客室マスタDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mst客室マスタBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst客室マスタ"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Mst客室マスタDbm.GetInstance(); } }
        public Mst客室マスタDbm MyDBMeta { get { return Mst客室マスタDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Mst客室マスタ NewMyEntity() { return new Mst客室マスタ(); }
        public virtual Mst客室マスタCB NewMyConditionBean() { return new Mst客室マスタCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Mst客室マスタCB cb) {
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
        public virtual Mst客室マスタ SelectEntity(Mst客室マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Mst客室マスタ> ls = null;
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
            return (Mst客室マスタ)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Mst客室マスタ SelectEntityWithDeletedCheck(Mst客室マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            Mst客室マスタ entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Mst客室マスタ SelectByPKValue(String 客室コード) {
            return SelectEntity(BuildPKCB(客室コード));
        }

        public virtual Mst客室マスタ SelectByPKValueWithDeletedCheck(String 客室コード) {
            return SelectEntityWithDeletedCheck(BuildPKCB(客室コード));
        }

        private Mst客室マスタCB BuildPKCB(String 客室コード) {
            AssertObjectNotNull("客室コード", 客室コード);
            Mst客室マスタCB cb = NewMyConditionBean();
            cb.Query().Set客室コード_Equal(客室コード);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Mst客室マスタ> SelectList(Mst客室マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Mst客室マスタ>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Mst客室マスタ> SelectPage(Mst客室マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Mst客室マスタ> invoker = new PagingInvoker<Mst客室マスタ>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Mst客室マスタ> {
            protected Mst客室マスタBhv _bhv; protected Mst客室マスタCB _cb;
            public InternalSelectPagingHandler(Mst客室マスタBhv bhv, Mst客室マスタCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Mst客室マスタ> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadDch客室利用台帳List(Mst客室マスタ mst客室マスタ, ConditionBeanSetupper<Dch客室利用台帳CB> conditionBeanSetupper) {
            AssertObjectNotNull("mst客室マスタ", mst客室マスタ); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadDch客室利用台帳List(xnewLRLs<Mst客室マスタ>(mst客室マスタ), conditionBeanSetupper);
        }
        public virtual void LoadDch客室利用台帳List(IList<Mst客室マスタ> mst客室マスタList, ConditionBeanSetupper<Dch客室利用台帳CB> conditionBeanSetupper) {
            AssertObjectNotNull("mst客室マスタList", mst客室マスタList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadDch客室利用台帳List(mst客室マスタList, new LoadReferrerOption<Dch客室利用台帳CB, Dch客室利用台帳>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadDch客室利用台帳List(Mst客室マスタ mst客室マスタ, LoadReferrerOption<Dch客室利用台帳CB, Dch客室利用台帳> loadReferrerOption) {
            AssertObjectNotNull("mst客室マスタ", mst客室マスタ); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadDch客室利用台帳List(xnewLRLs<Mst客室マスタ>(mst客室マスタ), loadReferrerOption);
        }
        public virtual void LoadDch客室利用台帳List(IList<Mst客室マスタ> mst客室マスタList, LoadReferrerOption<Dch客室利用台帳CB, Dch客室利用台帳> loadReferrerOption) {
            AssertObjectNotNull("mst客室マスタList", mst客室マスタList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (mst客室マスタList.Count == 0) { return; }
            Dch客室利用台帳Bhv referrerBhv = xgetBSFLR().Select<Dch客室利用台帳Bhv>();
            HelpLoadReferrerInternally<Mst客室マスタ, String, Dch客室利用台帳CB, Dch客室利用台帳>
                    (mst客室マスタList, loadReferrerOption, new MyInternalLoadDch客室利用台帳ListCallback(referrerBhv));
        }
        protected class MyInternalLoadDch客室利用台帳ListCallback : InternalLoadReferrerCallback<Mst客室マスタ, String, Dch客室利用台帳CB, Dch客室利用台帳> {
            protected Dch客室利用台帳Bhv referrerBhv;
            public MyInternalLoadDch客室利用台帳ListCallback(Dch客室利用台帳Bhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(Mst客室マスタ e) { return e.客室コード; }
            public void setRfLs(Mst客室マスタ e, IList<Dch客室利用台帳> ls) { e.Dch客室利用台帳List = ls; }
            public Dch客室利用台帳CB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(Dch客室利用台帳CB cb, IList<String> ls) { cb.Query().Set客室コード_InScope(ls); }
            public void qyOdFKAsc(Dch客室利用台帳CB cb) { cb.Query().AddOrderBy_客室コード_Asc(); }
            public void spFKCol(Dch客室利用台帳CB cb) { cb.Specify().Column客室コード(); }
            public IList<Dch客室利用台帳> selRfLs(Dch客室利用台帳CB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(Dch客室利用台帳 e) { return e.客室コード; }
            public void setlcEt(Dch客室利用台帳 re, Mst客室マスタ be) { re.Mst客室マスタ = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<Mst客室タイプマスタ> PulloutMst客室タイプマスタ(IList<Mst客室マスタ> mst客室マスタList) {
            return HelpPulloutInternally<Mst客室マスタ, Mst客室タイプマスタ>(mst客室マスタList, new MyInternalPulloutMst客室タイプマスタCallback());
        }
        protected class MyInternalPulloutMst客室タイプマスタCallback : InternalPulloutCallback<Mst客室マスタ, Mst客室タイプマスタ> {
            public Mst客室タイプマスタ getFr(Mst客室マスタ entity) { return entity.Mst客室タイプマスタ; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(Mst客室マスタ entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Mst客室マスタ entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Mst客室マスタ entity) {
            HelpInsertOrUpdateInternally<Mst客室マスタ, Mst客室マスタCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Mst客室マスタ, Mst客室マスタCB> {
            protected Mst客室マスタBhv _bhv;
            public MyInternalInsertOrUpdateCallback(Mst客室マスタBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Mst客室マスタ entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Mst客室マスタ entity) { _bhv.Update(entity); }
            public Mst客室マスタCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Mst客室マスタCB cb, Mst客室マスタ entity) {
                cb.Query().Set客室コード_Equal(entity.客室コード);
            }
            public int CallbackSelectCount(Mst客室マスタCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Mst客室マスタ entity) {
            HelpDeleteInternally<Mst客室マスタ>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Mst客室マスタ> {
            protected Mst客室マスタBhv _bhv;
            public MyInternalDeleteCallback(Mst客室マスタBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Mst客室マスタ entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Mst客室マスタ mst客室マスタ, Mst客室マスタCB cb) {
            AssertObjectNotNull("mst客室マスタ", mst客室マスタ); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(mst客室マスタ);
            FilterEntityOfUpdate(mst客室マスタ); AssertEntityOfUpdate(mst客室マスタ);
            return this.Dao.UpdateByQuery(cb, mst客室マスタ);
        }

        public int QueryDelete(Mst客室マスタCB cb) {
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
        protected int DelegateSelectCount(Mst客室マスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Mst客室マスタ> DelegateSelectList(Mst客室マスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(Mst客室マスタ e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Mst客室マスタ e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Mst客室マスタ e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Mst客室マスタ Downcast(Entity entity) {
            return (Mst客室マスタ)entity;
        }

        protected Mst客室マスタCB Downcast(ConditionBean cb) {
            return (Mst客室マスタCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Mst客室マスタDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
