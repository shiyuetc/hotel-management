
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
    public partial class Kbnメニュー区分Bhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Kbnメニュー区分Dao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Kbnメニュー区分Bhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "kbnメニュー区分"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Kbnメニュー区分Dbm.GetInstance(); } }
        public Kbnメニュー区分Dbm MyDBMeta { get { return Kbnメニュー区分Dbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Kbnメニュー区分 NewMyEntity() { return new Kbnメニュー区分(); }
        public virtual Kbnメニュー区分CB NewMyConditionBean() { return new Kbnメニュー区分CB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Kbnメニュー区分CB cb) {
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
        public virtual Kbnメニュー区分 SelectEntity(Kbnメニュー区分CB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Kbnメニュー区分> ls = null;
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
            return (Kbnメニュー区分)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Kbnメニュー区分 SelectEntityWithDeletedCheck(Kbnメニュー区分CB cb) {
            AssertConditionBeanNotNull(cb);
            Kbnメニュー区分 entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Kbnメニュー区分 SelectByPKValue(String メニューコード) {
            return SelectEntity(BuildPKCB(メニューコード));
        }

        public virtual Kbnメニュー区分 SelectByPKValueWithDeletedCheck(String メニューコード) {
            return SelectEntityWithDeletedCheck(BuildPKCB(メニューコード));
        }

        private Kbnメニュー区分CB BuildPKCB(String メニューコード) {
            AssertObjectNotNull("メニューコード", メニューコード);
            Kbnメニュー区分CB cb = NewMyConditionBean();
            cb.Query().Setメニューコード_Equal(メニューコード);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Kbnメニュー区分> SelectList(Kbnメニュー区分CB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Kbnメニュー区分>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Kbnメニュー区分> SelectPage(Kbnメニュー区分CB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Kbnメニュー区分> invoker = new PagingInvoker<Kbnメニュー区分>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Kbnメニュー区分> {
            protected Kbnメニュー区分Bhv _bhv; protected Kbnメニュー区分CB _cb;
            public InternalSelectPagingHandler(Kbnメニュー区分Bhv bhv, Kbnメニュー区分CB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Kbnメニュー区分> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadMst画面マスタList(Kbnメニュー区分 kbnメニュー区分, ConditionBeanSetupper<Mst画面マスタCB> conditionBeanSetupper) {
            AssertObjectNotNull("kbnメニュー区分", kbnメニュー区分); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMst画面マスタList(xnewLRLs<Kbnメニュー区分>(kbnメニュー区分), conditionBeanSetupper);
        }
        public virtual void LoadMst画面マスタList(IList<Kbnメニュー区分> kbnメニュー区分List, ConditionBeanSetupper<Mst画面マスタCB> conditionBeanSetupper) {
            AssertObjectNotNull("kbnメニュー区分List", kbnメニュー区分List); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMst画面マスタList(kbnメニュー区分List, new LoadReferrerOption<Mst画面マスタCB, Mst画面マスタ>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMst画面マスタList(Kbnメニュー区分 kbnメニュー区分, LoadReferrerOption<Mst画面マスタCB, Mst画面マスタ> loadReferrerOption) {
            AssertObjectNotNull("kbnメニュー区分", kbnメニュー区分); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMst画面マスタList(xnewLRLs<Kbnメニュー区分>(kbnメニュー区分), loadReferrerOption);
        }
        public virtual void LoadMst画面マスタList(IList<Kbnメニュー区分> kbnメニュー区分List, LoadReferrerOption<Mst画面マスタCB, Mst画面マスタ> loadReferrerOption) {
            AssertObjectNotNull("kbnメニュー区分List", kbnメニュー区分List); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (kbnメニュー区分List.Count == 0) { return; }
            Mst画面マスタBhv referrerBhv = xgetBSFLR().Select<Mst画面マスタBhv>();
            HelpLoadReferrerInternally<Kbnメニュー区分, String, Mst画面マスタCB, Mst画面マスタ>
                    (kbnメニュー区分List, loadReferrerOption, new MyInternalLoadMst画面マスタListCallback(referrerBhv));
        }
        protected class MyInternalLoadMst画面マスタListCallback : InternalLoadReferrerCallback<Kbnメニュー区分, String, Mst画面マスタCB, Mst画面マスタ> {
            protected Mst画面マスタBhv referrerBhv;
            public MyInternalLoadMst画面マスタListCallback(Mst画面マスタBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(Kbnメニュー区分 e) { return e.メニューコード; }
            public void setRfLs(Kbnメニュー区分 e, IList<Mst画面マスタ> ls) { e.Mst画面マスタList = ls; }
            public Mst画面マスタCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(Mst画面マスタCB cb, IList<String> ls) { cb.Query().Setメニューコード_InScope(ls); }
            public void qyOdFKAsc(Mst画面マスタCB cb) { cb.Query().AddOrderBy_メニューコード_Asc(); }
            public void spFKCol(Mst画面マスタCB cb) { cb.Specify().Columnメニューコード(); }
            public IList<Mst画面マスタ> selRfLs(Mst画面マスタCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(Mst画面マスタ e) { return e.メニューコード; }
            public void setlcEt(Mst画面マスタ re, Kbnメニュー区分 be) { re.Kbnメニュー区分 = be; }
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
        public virtual void Insert(Kbnメニュー区分 entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Kbnメニュー区分 entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Kbnメニュー区分 entity) {
            HelpInsertOrUpdateInternally<Kbnメニュー区分, Kbnメニュー区分CB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Kbnメニュー区分, Kbnメニュー区分CB> {
            protected Kbnメニュー区分Bhv _bhv;
            public MyInternalInsertOrUpdateCallback(Kbnメニュー区分Bhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Kbnメニュー区分 entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Kbnメニュー区分 entity) { _bhv.Update(entity); }
            public Kbnメニュー区分CB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Kbnメニュー区分CB cb, Kbnメニュー区分 entity) {
                cb.Query().Setメニューコード_Equal(entity.メニューコード);
            }
            public int CallbackSelectCount(Kbnメニュー区分CB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Kbnメニュー区分 entity) {
            HelpDeleteInternally<Kbnメニュー区分>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Kbnメニュー区分> {
            protected Kbnメニュー区分Bhv _bhv;
            public MyInternalDeleteCallback(Kbnメニュー区分Bhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Kbnメニュー区分 entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Kbnメニュー区分 kbnメニュー区分, Kbnメニュー区分CB cb) {
            AssertObjectNotNull("kbnメニュー区分", kbnメニュー区分); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(kbnメニュー区分);
            FilterEntityOfUpdate(kbnメニュー区分); AssertEntityOfUpdate(kbnメニュー区分);
            return this.Dao.UpdateByQuery(cb, kbnメニュー区分);
        }

        public int QueryDelete(Kbnメニュー区分CB cb) {
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
        protected int DelegateSelectCount(Kbnメニュー区分CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Kbnメニュー区分> DelegateSelectList(Kbnメニュー区分CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(Kbnメニュー区分 e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Kbnメニュー区分 e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Kbnメニュー区分 e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Kbnメニュー区分 Downcast(Entity entity) {
            return (Kbnメニュー区分)entity;
        }

        protected Kbnメニュー区分CB Downcast(ConditionBean cb) {
            return (Kbnメニュー区分CB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Kbnメニュー区分Dao Dao { get { return _dao; } set { _dao = value; } }
    }
}
