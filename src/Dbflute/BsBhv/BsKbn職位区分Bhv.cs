
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
    public partial class Kbn職位区分Bhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Kbn職位区分Dao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public Kbn職位区分Bhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "kbn職位区分"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return Kbn職位区分Dbm.GetInstance(); } }
        public Kbn職位区分Dbm MyDBMeta { get { return Kbn職位区分Dbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Kbn職位区分 NewMyEntity() { return new Kbn職位区分(); }
        public virtual Kbn職位区分CB NewMyConditionBean() { return new Kbn職位区分CB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(Kbn職位区分CB cb) {
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
        public virtual Kbn職位区分 SelectEntity(Kbn職位区分CB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Kbn職位区分> ls = null;
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
            return (Kbn職位区分)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Kbn職位区分 SelectEntityWithDeletedCheck(Kbn職位区分CB cb) {
            AssertConditionBeanNotNull(cb);
            Kbn職位区分 entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Kbn職位区分 SelectByPKValue(String 職位コード) {
            return SelectEntity(BuildPKCB(職位コード));
        }

        public virtual Kbn職位区分 SelectByPKValueWithDeletedCheck(String 職位コード) {
            return SelectEntityWithDeletedCheck(BuildPKCB(職位コード));
        }

        private Kbn職位区分CB BuildPKCB(String 職位コード) {
            AssertObjectNotNull("職位コード", 職位コード);
            Kbn職位区分CB cb = NewMyConditionBean();
            cb.Query().Set職位コード_Equal(職位コード);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Kbn職位区分> SelectList(Kbn職位区分CB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Kbn職位区分>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Kbn職位区分> SelectPage(Kbn職位区分CB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Kbn職位区分> invoker = new PagingInvoker<Kbn職位区分>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Kbn職位区分> {
            protected Kbn職位区分Bhv _bhv; protected Kbn職位区分CB _cb;
            public InternalSelectPagingHandler(Kbn職位区分Bhv bhv, Kbn職位区分CB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Kbn職位区分> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadDch従業員職位履歴台帳List(Kbn職位区分 kbn職位区分, ConditionBeanSetupper<Dch従業員職位履歴台帳CB> conditionBeanSetupper) {
            AssertObjectNotNull("kbn職位区分", kbn職位区分); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadDch従業員職位履歴台帳List(xnewLRLs<Kbn職位区分>(kbn職位区分), conditionBeanSetupper);
        }
        public virtual void LoadDch従業員職位履歴台帳List(IList<Kbn職位区分> kbn職位区分List, ConditionBeanSetupper<Dch従業員職位履歴台帳CB> conditionBeanSetupper) {
            AssertObjectNotNull("kbn職位区分List", kbn職位区分List); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadDch従業員職位履歴台帳List(kbn職位区分List, new LoadReferrerOption<Dch従業員職位履歴台帳CB, Dch従業員職位履歴台帳>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadDch従業員職位履歴台帳List(Kbn職位区分 kbn職位区分, LoadReferrerOption<Dch従業員職位履歴台帳CB, Dch従業員職位履歴台帳> loadReferrerOption) {
            AssertObjectNotNull("kbn職位区分", kbn職位区分); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadDch従業員職位履歴台帳List(xnewLRLs<Kbn職位区分>(kbn職位区分), loadReferrerOption);
        }
        public virtual void LoadDch従業員職位履歴台帳List(IList<Kbn職位区分> kbn職位区分List, LoadReferrerOption<Dch従業員職位履歴台帳CB, Dch従業員職位履歴台帳> loadReferrerOption) {
            AssertObjectNotNull("kbn職位区分List", kbn職位区分List); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (kbn職位区分List.Count == 0) { return; }
            Dch従業員職位履歴台帳Bhv referrerBhv = xgetBSFLR().Select<Dch従業員職位履歴台帳Bhv>();
            HelpLoadReferrerInternally<Kbn職位区分, String, Dch従業員職位履歴台帳CB, Dch従業員職位履歴台帳>
                    (kbn職位区分List, loadReferrerOption, new MyInternalLoadDch従業員職位履歴台帳ListCallback(referrerBhv));
        }
        protected class MyInternalLoadDch従業員職位履歴台帳ListCallback : InternalLoadReferrerCallback<Kbn職位区分, String, Dch従業員職位履歴台帳CB, Dch従業員職位履歴台帳> {
            protected Dch従業員職位履歴台帳Bhv referrerBhv;
            public MyInternalLoadDch従業員職位履歴台帳ListCallback(Dch従業員職位履歴台帳Bhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(Kbn職位区分 e) { return e.職位コード; }
            public void setRfLs(Kbn職位区分 e, IList<Dch従業員職位履歴台帳> ls) { e.Dch従業員職位履歴台帳List = ls; }
            public Dch従業員職位履歴台帳CB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(Dch従業員職位履歴台帳CB cb, IList<String> ls) { cb.Query().Set職位コード_InScope(ls); }
            public void qyOdFKAsc(Dch従業員職位履歴台帳CB cb) { cb.Query().AddOrderBy_職位コード_Asc(); }
            public void spFKCol(Dch従業員職位履歴台帳CB cb) { cb.Specify().Column職位コード(); }
            public IList<Dch従業員職位履歴台帳> selRfLs(Dch従業員職位履歴台帳CB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(Dch従業員職位履歴台帳 e) { return e.職位コード; }
            public void setlcEt(Dch従業員職位履歴台帳 re, Kbn職位区分 be) { re.Kbn職位区分 = be; }
        }
        public virtual void LoadMst従業員マスタList(Kbn職位区分 kbn職位区分, ConditionBeanSetupper<Mst従業員マスタCB> conditionBeanSetupper) {
            AssertObjectNotNull("kbn職位区分", kbn職位区分); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMst従業員マスタList(xnewLRLs<Kbn職位区分>(kbn職位区分), conditionBeanSetupper);
        }
        public virtual void LoadMst従業員マスタList(IList<Kbn職位区分> kbn職位区分List, ConditionBeanSetupper<Mst従業員マスタCB> conditionBeanSetupper) {
            AssertObjectNotNull("kbn職位区分List", kbn職位区分List); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMst従業員マスタList(kbn職位区分List, new LoadReferrerOption<Mst従業員マスタCB, Mst従業員マスタ>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMst従業員マスタList(Kbn職位区分 kbn職位区分, LoadReferrerOption<Mst従業員マスタCB, Mst従業員マスタ> loadReferrerOption) {
            AssertObjectNotNull("kbn職位区分", kbn職位区分); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMst従業員マスタList(xnewLRLs<Kbn職位区分>(kbn職位区分), loadReferrerOption);
        }
        public virtual void LoadMst従業員マスタList(IList<Kbn職位区分> kbn職位区分List, LoadReferrerOption<Mst従業員マスタCB, Mst従業員マスタ> loadReferrerOption) {
            AssertObjectNotNull("kbn職位区分List", kbn職位区分List); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (kbn職位区分List.Count == 0) { return; }
            Mst従業員マスタBhv referrerBhv = xgetBSFLR().Select<Mst従業員マスタBhv>();
            HelpLoadReferrerInternally<Kbn職位区分, String, Mst従業員マスタCB, Mst従業員マスタ>
                    (kbn職位区分List, loadReferrerOption, new MyInternalLoadMst従業員マスタListCallback(referrerBhv));
        }
        protected class MyInternalLoadMst従業員マスタListCallback : InternalLoadReferrerCallback<Kbn職位区分, String, Mst従業員マスタCB, Mst従業員マスタ> {
            protected Mst従業員マスタBhv referrerBhv;
            public MyInternalLoadMst従業員マスタListCallback(Mst従業員マスタBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(Kbn職位区分 e) { return e.職位コード; }
            public void setRfLs(Kbn職位区分 e, IList<Mst従業員マスタ> ls) { e.Mst従業員マスタList = ls; }
            public Mst従業員マスタCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(Mst従業員マスタCB cb, IList<String> ls) { cb.Query().Set職位コード_InScope(ls); }
            public void qyOdFKAsc(Mst従業員マスタCB cb) { cb.Query().AddOrderBy_職位コード_Asc(); }
            public void spFKCol(Mst従業員マスタCB cb) { cb.Specify().Column職位コード(); }
            public IList<Mst従業員マスタ> selRfLs(Mst従業員マスタCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(Mst従業員マスタ e) { return e.職位コード; }
            public void setlcEt(Mst従業員マスタ re, Kbn職位区分 be) { re.Kbn職位区分 = be; }
        }
        public virtual void LoadMst権限マスタList(Kbn職位区分 kbn職位区分, ConditionBeanSetupper<Mst権限マスタCB> conditionBeanSetupper) {
            AssertObjectNotNull("kbn職位区分", kbn職位区分); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMst権限マスタList(xnewLRLs<Kbn職位区分>(kbn職位区分), conditionBeanSetupper);
        }
        public virtual void LoadMst権限マスタList(IList<Kbn職位区分> kbn職位区分List, ConditionBeanSetupper<Mst権限マスタCB> conditionBeanSetupper) {
            AssertObjectNotNull("kbn職位区分List", kbn職位区分List); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMst権限マスタList(kbn職位区分List, new LoadReferrerOption<Mst権限マスタCB, Mst権限マスタ>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMst権限マスタList(Kbn職位区分 kbn職位区分, LoadReferrerOption<Mst権限マスタCB, Mst権限マスタ> loadReferrerOption) {
            AssertObjectNotNull("kbn職位区分", kbn職位区分); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMst権限マスタList(xnewLRLs<Kbn職位区分>(kbn職位区分), loadReferrerOption);
        }
        public virtual void LoadMst権限マスタList(IList<Kbn職位区分> kbn職位区分List, LoadReferrerOption<Mst権限マスタCB, Mst権限マスタ> loadReferrerOption) {
            AssertObjectNotNull("kbn職位区分List", kbn職位区分List); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (kbn職位区分List.Count == 0) { return; }
            Mst権限マスタBhv referrerBhv = xgetBSFLR().Select<Mst権限マスタBhv>();
            HelpLoadReferrerInternally<Kbn職位区分, String, Mst権限マスタCB, Mst権限マスタ>
                    (kbn職位区分List, loadReferrerOption, new MyInternalLoadMst権限マスタListCallback(referrerBhv));
        }
        protected class MyInternalLoadMst権限マスタListCallback : InternalLoadReferrerCallback<Kbn職位区分, String, Mst権限マスタCB, Mst権限マスタ> {
            protected Mst権限マスタBhv referrerBhv;
            public MyInternalLoadMst権限マスタListCallback(Mst権限マスタBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(Kbn職位区分 e) { return e.職位コード; }
            public void setRfLs(Kbn職位区分 e, IList<Mst権限マスタ> ls) { e.Mst権限マスタList = ls; }
            public Mst権限マスタCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(Mst権限マスタCB cb, IList<String> ls) { cb.Query().Set職位コード_InScope(ls); }
            public void qyOdFKAsc(Mst権限マスタCB cb) { cb.Query().AddOrderBy_職位コード_Asc(); }
            public void spFKCol(Mst権限マスタCB cb) { cb.Specify().Column職位コード(); }
            public IList<Mst権限マスタ> selRfLs(Mst権限マスタCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(Mst権限マスタ e) { return e.職位コード; }
            public void setlcEt(Mst権限マスタ re, Kbn職位区分 be) { re.Kbn職位区分 = be; }
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
        public virtual void Insert(Kbn職位区分 entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Kbn職位区分 entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Kbn職位区分 entity) {
            HelpInsertOrUpdateInternally<Kbn職位区分, Kbn職位区分CB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Kbn職位区分, Kbn職位区分CB> {
            protected Kbn職位区分Bhv _bhv;
            public MyInternalInsertOrUpdateCallback(Kbn職位区分Bhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Kbn職位区分 entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Kbn職位区分 entity) { _bhv.Update(entity); }
            public Kbn職位区分CB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(Kbn職位区分CB cb, Kbn職位区分 entity) {
                cb.Query().Set職位コード_Equal(entity.職位コード);
            }
            public int CallbackSelectCount(Kbn職位区分CB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Kbn職位区分 entity) {
            HelpDeleteInternally<Kbn職位区分>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Kbn職位区分> {
            protected Kbn職位区分Bhv _bhv;
            public MyInternalDeleteCallback(Kbn職位区分Bhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Kbn職位区分 entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Kbn職位区分 kbn職位区分, Kbn職位区分CB cb) {
            AssertObjectNotNull("kbn職位区分", kbn職位区分); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(kbn職位区分);
            FilterEntityOfUpdate(kbn職位区分); AssertEntityOfUpdate(kbn職位区分);
            return this.Dao.UpdateByQuery(cb, kbn職位区分);
        }

        public int QueryDelete(Kbn職位区分CB cb) {
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
        protected int DelegateSelectCount(Kbn職位区分CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Kbn職位区分> DelegateSelectList(Kbn職位区分CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(Kbn職位区分 e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Kbn職位区分 e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Kbn職位区分 e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Kbn職位区分 Downcast(Entity entity) {
            return (Kbn職位区分)entity;
        }

        protected Kbn職位区分CB Downcast(ConditionBean cb) {
            return (Kbn職位区分CB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual Kbn職位区分Dao Dao { get { return _dao; } set { _dao = value; } }
    }
}
