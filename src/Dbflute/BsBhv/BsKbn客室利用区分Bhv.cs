
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
    public partial class Kbn客室利用区分Bhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Kbn客室利用区分Dao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Kbn客室利用区分Bhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "kbn客室利用区分"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Kbn客室利用区分Dbm.GetInstance(); } }
        public Kbn客室利用区分Dbm MyDBMeta { get { return Kbn客室利用区分Dbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Kbn客室利用区分 NewMyEntity() { return new Kbn客室利用区分(); }
        public virtual Kbn客室利用区分CB NewMyConditionBean() { return new Kbn客室利用区分CB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Kbn客室利用区分CB cb) {
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
        public virtual Kbn客室利用区分 SelectEntity(Kbn客室利用区分CB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Kbn客室利用区分> ls = null;
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
            return (Kbn客室利用区分)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Kbn客室利用区分 SelectEntityWithDeletedCheck(Kbn客室利用区分CB cb) {
            AssertConditionBeanNotNull(cb);
            Kbn客室利用区分 entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Kbn客室利用区分 SelectByPKValue(String コード) {
            return SelectEntity(BuildPKCB(コード));
        }

        public virtual Kbn客室利用区分 SelectByPKValueWithDeletedCheck(String コード) {
            return SelectEntityWithDeletedCheck(BuildPKCB(コード));
        }

        private Kbn客室利用区分CB BuildPKCB(String コード) {
            AssertObjectNotNull("コード", コード);
            Kbn客室利用区分CB cb = NewMyConditionBean();
            cb.Query().Setコード_Equal(コード);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Kbn客室利用区分> SelectList(Kbn客室利用区分CB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Kbn客室利用区分>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Kbn客室利用区分> SelectPage(Kbn客室利用区分CB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Kbn客室利用区分> invoker = new PagingInvoker<Kbn客室利用区分>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Kbn客室利用区分> {
            protected Kbn客室利用区分Bhv _bhv; protected Kbn客室利用区分CB _cb;
            public InternalSelectPagingHandler(Kbn客室利用区分Bhv bhv, Kbn客室利用区分CB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Kbn客室利用区分> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadDch客室利用予定台帳List(Kbn客室利用区分 kbn客室利用区分, ConditionBeanSetupper<Dch客室利用予定台帳CB> conditionBeanSetupper) {
            AssertObjectNotNull("kbn客室利用区分", kbn客室利用区分); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadDch客室利用予定台帳List(xnewLRLs<Kbn客室利用区分>(kbn客室利用区分), conditionBeanSetupper);
        }
        public virtual void LoadDch客室利用予定台帳List(IList<Kbn客室利用区分> kbn客室利用区分List, ConditionBeanSetupper<Dch客室利用予定台帳CB> conditionBeanSetupper) {
            AssertObjectNotNull("kbn客室利用区分List", kbn客室利用区分List); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadDch客室利用予定台帳List(kbn客室利用区分List, new LoadReferrerOption<Dch客室利用予定台帳CB, Dch客室利用予定台帳>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadDch客室利用予定台帳List(Kbn客室利用区分 kbn客室利用区分, LoadReferrerOption<Dch客室利用予定台帳CB, Dch客室利用予定台帳> loadReferrerOption) {
            AssertObjectNotNull("kbn客室利用区分", kbn客室利用区分); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadDch客室利用予定台帳List(xnewLRLs<Kbn客室利用区分>(kbn客室利用区分), loadReferrerOption);
        }
        public virtual void LoadDch客室利用予定台帳List(IList<Kbn客室利用区分> kbn客室利用区分List, LoadReferrerOption<Dch客室利用予定台帳CB, Dch客室利用予定台帳> loadReferrerOption) {
            AssertObjectNotNull("kbn客室利用区分List", kbn客室利用区分List); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (kbn客室利用区分List.Count == 0) { return; }
            Dch客室利用予定台帳Bhv referrerBhv = xgetBSFLR().Select<Dch客室利用予定台帳Bhv>();
            HelpLoadReferrerInternally<Kbn客室利用区分, String, Dch客室利用予定台帳CB, Dch客室利用予定台帳>
                    (kbn客室利用区分List, loadReferrerOption, new MyInternalLoadDch客室利用予定台帳ListCallback(referrerBhv));
        }
        protected class MyInternalLoadDch客室利用予定台帳ListCallback : InternalLoadReferrerCallback<Kbn客室利用区分, String, Dch客室利用予定台帳CB, Dch客室利用予定台帳> {
            protected Dch客室利用予定台帳Bhv referrerBhv;
            public MyInternalLoadDch客室利用予定台帳ListCallback(Dch客室利用予定台帳Bhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(Kbn客室利用区分 e) { return e.コード; }
            public void setRfLs(Kbn客室利用区分 e, IList<Dch客室利用予定台帳> ls) { e.Dch客室利用予定台帳List = ls; }
            public Dch客室利用予定台帳CB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(Dch客室利用予定台帳CB cb, IList<String> ls) { cb.Query().Set客室利用コード_InScope(ls); }
            public void qyOdFKAsc(Dch客室利用予定台帳CB cb) { cb.Query().AddOrderBy_客室利用コード_Asc(); }
            public void spFKCol(Dch客室利用予定台帳CB cb) { cb.Specify().Column客室利用コード(); }
            public IList<Dch客室利用予定台帳> selRfLs(Dch客室利用予定台帳CB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(Dch客室利用予定台帳 e) { return e.客室利用コード; }
            public void setlcEt(Dch客室利用予定台帳 re, Kbn客室利用区分 be) { re.Kbn客室利用区分 = be; }
        }
        public virtual void LoadDch客室利用実績台帳List(Kbn客室利用区分 kbn客室利用区分, ConditionBeanSetupper<Dch客室利用実績台帳CB> conditionBeanSetupper) {
            AssertObjectNotNull("kbn客室利用区分", kbn客室利用区分); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadDch客室利用実績台帳List(xnewLRLs<Kbn客室利用区分>(kbn客室利用区分), conditionBeanSetupper);
        }
        public virtual void LoadDch客室利用実績台帳List(IList<Kbn客室利用区分> kbn客室利用区分List, ConditionBeanSetupper<Dch客室利用実績台帳CB> conditionBeanSetupper) {
            AssertObjectNotNull("kbn客室利用区分List", kbn客室利用区分List); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadDch客室利用実績台帳List(kbn客室利用区分List, new LoadReferrerOption<Dch客室利用実績台帳CB, Dch客室利用実績台帳>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadDch客室利用実績台帳List(Kbn客室利用区分 kbn客室利用区分, LoadReferrerOption<Dch客室利用実績台帳CB, Dch客室利用実績台帳> loadReferrerOption) {
            AssertObjectNotNull("kbn客室利用区分", kbn客室利用区分); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadDch客室利用実績台帳List(xnewLRLs<Kbn客室利用区分>(kbn客室利用区分), loadReferrerOption);
        }
        public virtual void LoadDch客室利用実績台帳List(IList<Kbn客室利用区分> kbn客室利用区分List, LoadReferrerOption<Dch客室利用実績台帳CB, Dch客室利用実績台帳> loadReferrerOption) {
            AssertObjectNotNull("kbn客室利用区分List", kbn客室利用区分List); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (kbn客室利用区分List.Count == 0) { return; }
            Dch客室利用実績台帳Bhv referrerBhv = xgetBSFLR().Select<Dch客室利用実績台帳Bhv>();
            HelpLoadReferrerInternally<Kbn客室利用区分, String, Dch客室利用実績台帳CB, Dch客室利用実績台帳>
                    (kbn客室利用区分List, loadReferrerOption, new MyInternalLoadDch客室利用実績台帳ListCallback(referrerBhv));
        }
        protected class MyInternalLoadDch客室利用実績台帳ListCallback : InternalLoadReferrerCallback<Kbn客室利用区分, String, Dch客室利用実績台帳CB, Dch客室利用実績台帳> {
            protected Dch客室利用実績台帳Bhv referrerBhv;
            public MyInternalLoadDch客室利用実績台帳ListCallback(Dch客室利用実績台帳Bhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(Kbn客室利用区分 e) { return e.コード; }
            public void setRfLs(Kbn客室利用区分 e, IList<Dch客室利用実績台帳> ls) { e.Dch客室利用実績台帳List = ls; }
            public Dch客室利用実績台帳CB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(Dch客室利用実績台帳CB cb, IList<String> ls) { cb.Query().Set客室利用コード_InScope(ls); }
            public void qyOdFKAsc(Dch客室利用実績台帳CB cb) { cb.Query().AddOrderBy_客室利用コード_Asc(); }
            public void spFKCol(Dch客室利用実績台帳CB cb) { cb.Specify().Column客室利用コード(); }
            public IList<Dch客室利用実績台帳> selRfLs(Dch客室利用実績台帳CB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(Dch客室利用実績台帳 e) { return e.客室利用コード; }
            public void setlcEt(Dch客室利用実績台帳 re, Kbn客室利用区分 be) { re.Kbn客室利用区分 = be; }
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
        public virtual void Insert(Kbn客室利用区分 entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Kbn客室利用区分 entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Kbn客室利用区分 entity) {
            HelpInsertOrUpdateInternally<Kbn客室利用区分, Kbn客室利用区分CB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Kbn客室利用区分, Kbn客室利用区分CB> {
            protected Kbn客室利用区分Bhv _bhv;
            public MyInternalInsertOrUpdateCallback(Kbn客室利用区分Bhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Kbn客室利用区分 entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Kbn客室利用区分 entity) { _bhv.Update(entity); }
            public Kbn客室利用区分CB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Kbn客室利用区分CB cb, Kbn客室利用区分 entity) {
                cb.Query().Setコード_Equal(entity.コード);
            }
            public int CallbackSelectCount(Kbn客室利用区分CB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Kbn客室利用区分 entity) {
            HelpDeleteInternally<Kbn客室利用区分>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Kbn客室利用区分> {
            protected Kbn客室利用区分Bhv _bhv;
            public MyInternalDeleteCallback(Kbn客室利用区分Bhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Kbn客室利用区分 entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Kbn客室利用区分 kbn客室利用区分, Kbn客室利用区分CB cb) {
            AssertObjectNotNull("kbn客室利用区分", kbn客室利用区分); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(kbn客室利用区分);
            FilterEntityOfUpdate(kbn客室利用区分); AssertEntityOfUpdate(kbn客室利用区分);
            return this.Dao.UpdateByQuery(cb, kbn客室利用区分);
        }

        public int QueryDelete(Kbn客室利用区分CB cb) {
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
        protected int DelegateSelectCount(Kbn客室利用区分CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Kbn客室利用区分> DelegateSelectList(Kbn客室利用区分CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(Kbn客室利用区分 e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Kbn客室利用区分 e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Kbn客室利用区分 e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Kbn客室利用区分 Downcast(Entity entity) {
            return (Kbn客室利用区分)entity;
        }

        protected Kbn客室利用区分CB Downcast(ConditionBean cb) {
            return (Kbn客室利用区分CB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Kbn客室利用区分Dao Dao { get { return _dao; } set { _dao = value; } }
    }
}
