
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
    public partial class MstEmployeeBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MstEmployeeDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MstEmployeeBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "mst_employee"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return MstEmployeeDbm.GetInstance(); } }
        public MstEmployeeDbm MyDBMeta { get { return MstEmployeeDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MstEmployee NewMyEntity() { return new MstEmployee(); }
        public virtual MstEmployeeCB NewMyConditionBean() { return new MstEmployeeCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MstEmployeeCB cb) {
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
        public virtual MstEmployee SelectEntity(MstEmployeeCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MstEmployee> ls = null;
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
            return (MstEmployee)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MstEmployee SelectEntityWithDeletedCheck(MstEmployeeCB cb) {
            AssertConditionBeanNotNull(cb);
            MstEmployee entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MstEmployee SelectByPKValue(int? id) {
            return SelectEntity(BuildPKCB(id));
        }

        public virtual MstEmployee SelectByPKValueWithDeletedCheck(int? id) {
            return SelectEntityWithDeletedCheck(BuildPKCB(id));
        }

        private MstEmployeeCB BuildPKCB(int? id) {
            AssertObjectNotNull("id", id);
            MstEmployeeCB cb = NewMyConditionBean();
            cb.Query().SetId_Equal(id);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<MstEmployee> SelectList(MstEmployeeCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<MstEmployee>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<MstEmployee> SelectPage(MstEmployeeCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<MstEmployee> invoker = new PagingInvoker<MstEmployee>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<MstEmployee> {
            protected MstEmployeeBhv _bhv; protected MstEmployeeCB _cb;
            public InternalSelectPagingHandler(MstEmployeeBhv bhv, MstEmployeeCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MstEmployee> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                        Sequence
        //                                                                        ========
        public int? SelectNextVal() {
            return DelegateSelectNextVal();
        }
        protected override void SetupNextValueToPrimaryKey(Entity entity) {// Very Internal
            MstEmployee myEntity = (MstEmployee)entity;
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
        public IList<KbnRank> PulloutKbnRank(IList<MstEmployee> mstEmployeeList) {
            return HelpPulloutInternally<MstEmployee, KbnRank>(mstEmployeeList, new MyInternalPulloutKbnRankCallback());
        }
        protected class MyInternalPulloutKbnRankCallback : InternalPulloutCallback<MstEmployee, KbnRank> {
            public KbnRank getFr(MstEmployee entity) { return entity.KbnRank; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MstEmployee entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MstEmployee entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(MstEmployee entity) {
            HelpInsertOrUpdateInternally<MstEmployee, MstEmployeeCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MstEmployee, MstEmployeeCB> {
            protected MstEmployeeBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MstEmployeeBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MstEmployee entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MstEmployee entity) { _bhv.Update(entity); }
            public MstEmployeeCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MstEmployeeCB cb, MstEmployee entity) {
                cb.Query().SetId_Equal(entity.Id);
            }
            public int CallbackSelectCount(MstEmployeeCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(MstEmployee entity) {
            HelpDeleteInternally<MstEmployee>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MstEmployee> {
            protected MstEmployeeBhv _bhv;
            public MyInternalDeleteCallback(MstEmployeeBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MstEmployee entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MstEmployee mstEmployee, MstEmployeeCB cb) {
            AssertObjectNotNull("mstEmployee", mstEmployee); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(mstEmployee);
            FilterEntityOfUpdate(mstEmployee); AssertEntityOfUpdate(mstEmployee);
            return this.Dao.UpdateByQuery(cb, mstEmployee);
        }

        public int QueryDelete(MstEmployeeCB cb) {
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
        protected int DelegateSelectCount(MstEmployeeCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MstEmployee> DelegateSelectList(MstEmployeeCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }
        protected int? DelegateSelectNextVal() { return this.Dao.SelectNextVal(); }

        protected int DelegateInsert(MstEmployee e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MstEmployee e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MstEmployee e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MstEmployee Downcast(Entity entity) {
            return (MstEmployee)entity;
        }

        protected MstEmployeeCB Downcast(ConditionBean cb) {
            return (MstEmployeeCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MstEmployeeDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
