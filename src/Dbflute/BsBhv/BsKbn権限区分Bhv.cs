
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
    public partial class Kbn権限区分Bhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Kbn権限区分Dao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Kbn権限区分Bhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "kbn権限区分"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Kbn権限区分Dbm.GetInstance(); } }
        public Kbn権限区分Dbm MyDBMeta { get { return Kbn権限区分Dbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Kbn権限区分 NewMyEntity() { return new Kbn権限区分(); }
        public virtual Kbn権限区分CB NewMyConditionBean() { return new Kbn権限区分CB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Kbn権限区分CB cb) {
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
        public virtual Kbn権限区分 SelectEntity(Kbn権限区分CB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Kbn権限区分> ls = null;
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
            return (Kbn権限区分)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Kbn権限区分 SelectEntityWithDeletedCheck(Kbn権限区分CB cb) {
            AssertConditionBeanNotNull(cb);
            Kbn権限区分 entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Kbn権限区分 SelectByPKValue(String コード) {
            return SelectEntity(BuildPKCB(コード));
        }

        public virtual Kbn権限区分 SelectByPKValueWithDeletedCheck(String コード) {
            return SelectEntityWithDeletedCheck(BuildPKCB(コード));
        }

        private Kbn権限区分CB BuildPKCB(String コード) {
            AssertObjectNotNull("コード", コード);
            Kbn権限区分CB cb = NewMyConditionBean();
            cb.Query().Setコード_Equal(コード);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Kbn権限区分> SelectList(Kbn権限区分CB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Kbn権限区分>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Kbn権限区分> SelectPage(Kbn権限区分CB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Kbn権限区分> invoker = new PagingInvoker<Kbn権限区分>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Kbn権限区分> {
            protected Kbn権限区分Bhv _bhv; protected Kbn権限区分CB _cb;
            public InternalSelectPagingHandler(Kbn権限区分Bhv bhv, Kbn権限区分CB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Kbn権限区分> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadMst権限マスタList(Kbn権限区分 kbn権限区分, ConditionBeanSetupper<Mst権限マスタCB> conditionBeanSetupper) {
            AssertObjectNotNull("kbn権限区分", kbn権限区分); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMst権限マスタList(xnewLRLs<Kbn権限区分>(kbn権限区分), conditionBeanSetupper);
        }
        public virtual void LoadMst権限マスタList(IList<Kbn権限区分> kbn権限区分List, ConditionBeanSetupper<Mst権限マスタCB> conditionBeanSetupper) {
            AssertObjectNotNull("kbn権限区分List", kbn権限区分List); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMst権限マスタList(kbn権限区分List, new LoadReferrerOption<Mst権限マスタCB, Mst権限マスタ>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMst権限マスタList(Kbn権限区分 kbn権限区分, LoadReferrerOption<Mst権限マスタCB, Mst権限マスタ> loadReferrerOption) {
            AssertObjectNotNull("kbn権限区分", kbn権限区分); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMst権限マスタList(xnewLRLs<Kbn権限区分>(kbn権限区分), loadReferrerOption);
        }
        public virtual void LoadMst権限マスタList(IList<Kbn権限区分> kbn権限区分List, LoadReferrerOption<Mst権限マスタCB, Mst権限マスタ> loadReferrerOption) {
            AssertObjectNotNull("kbn権限区分List", kbn権限区分List); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (kbn権限区分List.Count == 0) { return; }
            Mst権限マスタBhv referrerBhv = xgetBSFLR().Select<Mst権限マスタBhv>();
            HelpLoadReferrerInternally<Kbn権限区分, String, Mst権限マスタCB, Mst権限マスタ>
                    (kbn権限区分List, loadReferrerOption, new MyInternalLoadMst権限マスタListCallback(referrerBhv));
        }
        protected class MyInternalLoadMst権限マスタListCallback : InternalLoadReferrerCallback<Kbn権限区分, String, Mst権限マスタCB, Mst権限マスタ> {
            protected Mst権限マスタBhv referrerBhv;
            public MyInternalLoadMst権限マスタListCallback(Mst権限マスタBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(Kbn権限区分 e) { return e.コード; }
            public void setRfLs(Kbn権限区分 e, IList<Mst権限マスタ> ls) { e.Mst権限マスタList = ls; }
            public Mst権限マスタCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(Mst権限マスタCB cb, IList<String> ls) { cb.Query().Set権限コード_InScope(ls); }
            public void qyOdFKAsc(Mst権限マスタCB cb) { cb.Query().AddOrderBy_権限コード_Asc(); }
            public void spFKCol(Mst権限マスタCB cb) { cb.Specify().Column権限コード(); }
            public IList<Mst権限マスタ> selRfLs(Mst権限マスタCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(Mst権限マスタ e) { return e.権限コード; }
            public void setlcEt(Mst権限マスタ re, Kbn権限区分 be) { re.Kbn権限区分 = be; }
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
        public virtual void Insert(Kbn権限区分 entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Kbn権限区分 entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Kbn権限区分 entity) {
            HelpInsertOrUpdateInternally<Kbn権限区分, Kbn権限区分CB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Kbn権限区分, Kbn権限区分CB> {
            protected Kbn権限区分Bhv _bhv;
            public MyInternalInsertOrUpdateCallback(Kbn権限区分Bhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Kbn権限区分 entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Kbn権限区分 entity) { _bhv.Update(entity); }
            public Kbn権限区分CB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Kbn権限区分CB cb, Kbn権限区分 entity) {
                cb.Query().Setコード_Equal(entity.コード);
            }
            public int CallbackSelectCount(Kbn権限区分CB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Kbn権限区分 entity) {
            HelpDeleteInternally<Kbn権限区分>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Kbn権限区分> {
            protected Kbn権限区分Bhv _bhv;
            public MyInternalDeleteCallback(Kbn権限区分Bhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Kbn権限区分 entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Kbn権限区分 kbn権限区分, Kbn権限区分CB cb) {
            AssertObjectNotNull("kbn権限区分", kbn権限区分); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(kbn権限区分);
            FilterEntityOfUpdate(kbn権限区分); AssertEntityOfUpdate(kbn権限区分);
            return this.Dao.UpdateByQuery(cb, kbn権限区分);
        }

        public int QueryDelete(Kbn権限区分CB cb) {
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
        protected int DelegateSelectCount(Kbn権限区分CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Kbn権限区分> DelegateSelectList(Kbn権限区分CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(Kbn権限区分 e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Kbn権限区分 e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Kbn権限区分 e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Kbn権限区分 Downcast(Entity entity) {
            return (Kbn権限区分)entity;
        }

        protected Kbn権限区分CB Downcast(ConditionBean cb) {
            return (Kbn権限区分CB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Kbn権限区分Dao Dao { get { return _dao; } set { _dao = value; } }
    }
}
