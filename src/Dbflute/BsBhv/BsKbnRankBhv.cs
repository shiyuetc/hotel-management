
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
    public partial class KbnRankBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected KbnRankDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public KbnRankBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "kbn_rank"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return KbnRankDbm.GetInstance(); } }
        public KbnRankDbm MyDBMeta { get { return KbnRankDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual KbnRank NewMyEntity() { return new KbnRank(); }
        public virtual KbnRankCB NewMyConditionBean() { return new KbnRankCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(KbnRankCB cb) {
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
        public virtual KbnRank SelectEntity(KbnRankCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<KbnRank> ls = null;
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
            return (KbnRank)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual KbnRank SelectEntityWithDeletedCheck(KbnRankCB cb) {
            AssertConditionBeanNotNull(cb);
            KbnRank entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual KbnRank SelectByPKValue(String code) {
            return SelectEntity(BuildPKCB(code));
        }

        public virtual KbnRank SelectByPKValueWithDeletedCheck(String code) {
            return SelectEntityWithDeletedCheck(BuildPKCB(code));
        }

        private KbnRankCB BuildPKCB(String code) {
            AssertObjectNotNull("code", code);
            KbnRankCB cb = NewMyConditionBean();
            cb.Query().SetCode_Equal(code);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<KbnRank> SelectList(KbnRankCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<KbnRank>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<KbnRank> SelectPage(KbnRankCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<KbnRank> invoker = new PagingInvoker<KbnRank>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<KbnRank> {
            protected KbnRankBhv _bhv; protected KbnRankCB _cb;
            public InternalSelectPagingHandler(KbnRankBhv bhv, KbnRankCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<KbnRank> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadMstEmployeeList(KbnRank kbnRank, ConditionBeanSetupper<MstEmployeeCB> conditionBeanSetupper) {
            AssertObjectNotNull("kbnRank", kbnRank); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMstEmployeeList(xnewLRLs<KbnRank>(kbnRank), conditionBeanSetupper);
        }
        public virtual void LoadMstEmployeeList(IList<KbnRank> kbnRankList, ConditionBeanSetupper<MstEmployeeCB> conditionBeanSetupper) {
            AssertObjectNotNull("kbnRankList", kbnRankList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMstEmployeeList(kbnRankList, new LoadReferrerOption<MstEmployeeCB, MstEmployee>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMstEmployeeList(KbnRank kbnRank, LoadReferrerOption<MstEmployeeCB, MstEmployee> loadReferrerOption) {
            AssertObjectNotNull("kbnRank", kbnRank); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMstEmployeeList(xnewLRLs<KbnRank>(kbnRank), loadReferrerOption);
        }
        public virtual void LoadMstEmployeeList(IList<KbnRank> kbnRankList, LoadReferrerOption<MstEmployeeCB, MstEmployee> loadReferrerOption) {
            AssertObjectNotNull("kbnRankList", kbnRankList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (kbnRankList.Count == 0) { return; }
            MstEmployeeBhv referrerBhv = xgetBSFLR().Select<MstEmployeeBhv>();
            HelpLoadReferrerInternally<KbnRank, String, MstEmployeeCB, MstEmployee>
                    (kbnRankList, loadReferrerOption, new MyInternalLoadMstEmployeeListCallback(referrerBhv));
        }
        protected class MyInternalLoadMstEmployeeListCallback : InternalLoadReferrerCallback<KbnRank, String, MstEmployeeCB, MstEmployee> {
            protected MstEmployeeBhv referrerBhv;
            public MyInternalLoadMstEmployeeListCallback(MstEmployeeBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(KbnRank e) { return e.Code; }
            public void setRfLs(KbnRank e, IList<MstEmployee> ls) { e.MstEmployeeList = ls; }
            public MstEmployeeCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MstEmployeeCB cb, IList<String> ls) { cb.Query().SetRankCode_InScope(ls); }
            public void qyOdFKAsc(MstEmployeeCB cb) { cb.Query().AddOrderBy_RankCode_Asc(); }
            public void spFKCol(MstEmployeeCB cb) { cb.Specify().ColumnRankCode(); }
            public IList<MstEmployee> selRfLs(MstEmployeeCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(MstEmployee e) { return e.RankCode; }
            public void setlcEt(MstEmployee re, KbnRank be) { re.KbnRank = be; }
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
        public virtual void Insert(KbnRank entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(KbnRank entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(KbnRank entity) {
            HelpInsertOrUpdateInternally<KbnRank, KbnRankCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<KbnRank, KbnRankCB> {
            protected KbnRankBhv _bhv;
            public MyInternalInsertOrUpdateCallback(KbnRankBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(KbnRank entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(KbnRank entity) { _bhv.Update(entity); }
            public KbnRankCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(KbnRankCB cb, KbnRank entity) {
                cb.Query().SetCode_Equal(entity.Code);
            }
            public int CallbackSelectCount(KbnRankCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(KbnRank entity) {
            HelpDeleteInternally<KbnRank>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<KbnRank> {
            protected KbnRankBhv _bhv;
            public MyInternalDeleteCallback(KbnRankBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(KbnRank entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(KbnRank kbnRank, KbnRankCB cb) {
            AssertObjectNotNull("kbnRank", kbnRank); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(kbnRank);
            FilterEntityOfUpdate(kbnRank); AssertEntityOfUpdate(kbnRank);
            return this.Dao.UpdateByQuery(cb, kbnRank);
        }

        public int QueryDelete(KbnRankCB cb) {
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
        protected int DelegateSelectCount(KbnRankCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<KbnRank> DelegateSelectList(KbnRankCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(KbnRank e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(KbnRank e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(KbnRank e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected KbnRank Downcast(Entity entity) {
            return (KbnRank)entity;
        }

        protected KbnRankCB Downcast(ConditionBean cb) {
            return (KbnRankCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual KbnRankDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
