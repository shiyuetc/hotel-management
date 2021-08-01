
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
    public partial class Mst会員マスタBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Mst会員マスタDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Mst会員マスタBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst会員マスタ"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Mst会員マスタDbm.GetInstance(); } }
        public Mst会員マスタDbm MyDBMeta { get { return Mst会員マスタDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Mst会員マスタ NewMyEntity() { return new Mst会員マスタ(); }
        public virtual Mst会員マスタCB NewMyConditionBean() { return new Mst会員マスタCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Mst会員マスタCB cb) {
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
        public virtual Mst会員マスタ SelectEntity(Mst会員マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Mst会員マスタ> ls = null;
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
            return (Mst会員マスタ)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Mst会員マスタ SelectEntityWithDeletedCheck(Mst会員マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            Mst会員マスタ entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Mst会員マスタ SelectByPKValue(String 会員コード) {
            return SelectEntity(BuildPKCB(会員コード));
        }

        public virtual Mst会員マスタ SelectByPKValueWithDeletedCheck(String 会員コード) {
            return SelectEntityWithDeletedCheck(BuildPKCB(会員コード));
        }

        private Mst会員マスタCB BuildPKCB(String 会員コード) {
            AssertObjectNotNull("会員コード", 会員コード);
            Mst会員マスタCB cb = NewMyConditionBean();
            cb.Query().Set会員コード_Equal(会員コード);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Mst会員マスタ> SelectList(Mst会員マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Mst会員マスタ>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Mst会員マスタ> SelectPage(Mst会員マスタCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Mst会員マスタ> invoker = new PagingInvoker<Mst会員マスタ>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Mst会員マスタ> {
            protected Mst会員マスタBhv _bhv; protected Mst会員マスタCB _cb;
            public InternalSelectPagingHandler(Mst会員マスタBhv bhv, Mst会員マスタCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Mst会員マスタ> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadDch宿泊利用台帳List(Mst会員マスタ mst会員マスタ, ConditionBeanSetupper<Dch宿泊利用台帳CB> conditionBeanSetupper) {
            AssertObjectNotNull("mst会員マスタ", mst会員マスタ); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadDch宿泊利用台帳List(xnewLRLs<Mst会員マスタ>(mst会員マスタ), conditionBeanSetupper);
        }
        public virtual void LoadDch宿泊利用台帳List(IList<Mst会員マスタ> mst会員マスタList, ConditionBeanSetupper<Dch宿泊利用台帳CB> conditionBeanSetupper) {
            AssertObjectNotNull("mst会員マスタList", mst会員マスタList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadDch宿泊利用台帳List(mst会員マスタList, new LoadReferrerOption<Dch宿泊利用台帳CB, Dch宿泊利用台帳>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadDch宿泊利用台帳List(Mst会員マスタ mst会員マスタ, LoadReferrerOption<Dch宿泊利用台帳CB, Dch宿泊利用台帳> loadReferrerOption) {
            AssertObjectNotNull("mst会員マスタ", mst会員マスタ); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadDch宿泊利用台帳List(xnewLRLs<Mst会員マスタ>(mst会員マスタ), loadReferrerOption);
        }
        public virtual void LoadDch宿泊利用台帳List(IList<Mst会員マスタ> mst会員マスタList, LoadReferrerOption<Dch宿泊利用台帳CB, Dch宿泊利用台帳> loadReferrerOption) {
            AssertObjectNotNull("mst会員マスタList", mst会員マスタList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (mst会員マスタList.Count == 0) { return; }
            Dch宿泊利用台帳Bhv referrerBhv = xgetBSFLR().Select<Dch宿泊利用台帳Bhv>();
            HelpLoadReferrerInternally<Mst会員マスタ, String, Dch宿泊利用台帳CB, Dch宿泊利用台帳>
                    (mst会員マスタList, loadReferrerOption, new MyInternalLoadDch宿泊利用台帳ListCallback(referrerBhv));
        }
        protected class MyInternalLoadDch宿泊利用台帳ListCallback : InternalLoadReferrerCallback<Mst会員マスタ, String, Dch宿泊利用台帳CB, Dch宿泊利用台帳> {
            protected Dch宿泊利用台帳Bhv referrerBhv;
            public MyInternalLoadDch宿泊利用台帳ListCallback(Dch宿泊利用台帳Bhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(Mst会員マスタ e) { return e.会員コード; }
            public void setRfLs(Mst会員マスタ e, IList<Dch宿泊利用台帳> ls) { e.Dch宿泊利用台帳List = ls; }
            public Dch宿泊利用台帳CB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(Dch宿泊利用台帳CB cb, IList<String> ls) { cb.Query().Set会員コード_InScope(ls); }
            public void qyOdFKAsc(Dch宿泊利用台帳CB cb) { cb.Query().AddOrderBy_会員コード_Asc(); }
            public void spFKCol(Dch宿泊利用台帳CB cb) { cb.Specify().Column会員コード(); }
            public IList<Dch宿泊利用台帳> selRfLs(Dch宿泊利用台帳CB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(Dch宿泊利用台帳 e) { return e.会員コード; }
            public void setlcEt(Dch宿泊利用台帳 re, Mst会員マスタ be) { re.Mst会員マスタ = be; }
        }
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
        public virtual void Insert(Mst会員マスタ entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Mst会員マスタ entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Mst会員マスタ entity) {
            HelpInsertOrUpdateInternally<Mst会員マスタ, Mst会員マスタCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Mst会員マスタ, Mst会員マスタCB> {
            protected Mst会員マスタBhv _bhv;
            public MyInternalInsertOrUpdateCallback(Mst会員マスタBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Mst会員マスタ entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Mst会員マスタ entity) { _bhv.Update(entity); }
            public Mst会員マスタCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Mst会員マスタCB cb, Mst会員マスタ entity) {
                cb.Query().Set会員コード_Equal(entity.会員コード);
            }
            public int CallbackSelectCount(Mst会員マスタCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Mst会員マスタ entity) {
            HelpDeleteInternally<Mst会員マスタ>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Mst会員マスタ> {
            protected Mst会員マスタBhv _bhv;
            public MyInternalDeleteCallback(Mst会員マスタBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Mst会員マスタ entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Mst会員マスタ mst会員マスタ, Mst会員マスタCB cb) {
            AssertObjectNotNull("mst会員マスタ", mst会員マスタ); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(mst会員マスタ);
            FilterEntityOfUpdate(mst会員マスタ); AssertEntityOfUpdate(mst会員マスタ);
            return this.Dao.UpdateByQuery(cb, mst会員マスタ);
        }

        public int QueryDelete(Mst会員マスタCB cb) {
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
        protected int DelegateSelectCount(Mst会員マスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Mst会員マスタ> DelegateSelectList(Mst会員マスタCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(Mst会員マスタ e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Mst会員マスタ e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Mst会員マスタ e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Mst会員マスタ Downcast(Entity entity) {
            return (Mst会員マスタ)entity;
        }

        protected Mst会員マスタCB Downcast(ConditionBean cb) {
            return (Mst会員マスタCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Mst会員マスタDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
