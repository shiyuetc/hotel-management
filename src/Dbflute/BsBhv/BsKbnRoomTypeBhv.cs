
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
    public partial class KbnRoomTypeBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected KbnRoomTypeDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public KbnRoomTypeBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "kbn_room_type"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return KbnRoomTypeDbm.GetInstance(); } }
        public KbnRoomTypeDbm MyDBMeta { get { return KbnRoomTypeDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual KbnRoomType NewMyEntity() { return new KbnRoomType(); }
        public virtual KbnRoomTypeCB NewMyConditionBean() { return new KbnRoomTypeCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(KbnRoomTypeCB cb) {
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
        public virtual KbnRoomType SelectEntity(KbnRoomTypeCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<KbnRoomType> ls = null;
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
            return (KbnRoomType)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual KbnRoomType SelectEntityWithDeletedCheck(KbnRoomTypeCB cb) {
            AssertConditionBeanNotNull(cb);
            KbnRoomType entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual KbnRoomType SelectByPKValue(String code) {
            return SelectEntity(BuildPKCB(code));
        }

        public virtual KbnRoomType SelectByPKValueWithDeletedCheck(String code) {
            return SelectEntityWithDeletedCheck(BuildPKCB(code));
        }

        private KbnRoomTypeCB BuildPKCB(String code) {
            AssertObjectNotNull("code", code);
            KbnRoomTypeCB cb = NewMyConditionBean();
            cb.Query().SetCode_Equal(code);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<KbnRoomType> SelectList(KbnRoomTypeCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<KbnRoomType>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<KbnRoomType> SelectPage(KbnRoomTypeCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<KbnRoomType> invoker = new PagingInvoker<KbnRoomType>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<KbnRoomType> {
            protected KbnRoomTypeBhv _bhv; protected KbnRoomTypeCB _cb;
            public InternalSelectPagingHandler(KbnRoomTypeBhv bhv, KbnRoomTypeCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<KbnRoomType> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
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
        public virtual void Insert(KbnRoomType entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(KbnRoomType entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(KbnRoomType entity) {
            HelpInsertOrUpdateInternally<KbnRoomType, KbnRoomTypeCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<KbnRoomType, KbnRoomTypeCB> {
            protected KbnRoomTypeBhv _bhv;
            public MyInternalInsertOrUpdateCallback(KbnRoomTypeBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(KbnRoomType entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(KbnRoomType entity) { _bhv.Update(entity); }
            public KbnRoomTypeCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(KbnRoomTypeCB cb, KbnRoomType entity) {
                cb.Query().SetCode_Equal(entity.Code);
            }
            public int CallbackSelectCount(KbnRoomTypeCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(KbnRoomType entity) {
            HelpDeleteInternally<KbnRoomType>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<KbnRoomType> {
            protected KbnRoomTypeBhv _bhv;
            public MyInternalDeleteCallback(KbnRoomTypeBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(KbnRoomType entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(KbnRoomType kbnRoomType, KbnRoomTypeCB cb) {
            AssertObjectNotNull("kbnRoomType", kbnRoomType); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(kbnRoomType);
            FilterEntityOfUpdate(kbnRoomType); AssertEntityOfUpdate(kbnRoomType);
            return this.Dao.UpdateByQuery(cb, kbnRoomType);
        }

        public int QueryDelete(KbnRoomTypeCB cb) {
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
        protected int DelegateSelectCount(KbnRoomTypeCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<KbnRoomType> DelegateSelectList(KbnRoomTypeCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(KbnRoomType e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(KbnRoomType e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(KbnRoomType e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected KbnRoomType Downcast(Entity entity) {
            return (KbnRoomType)entity;
        }

        protected KbnRoomTypeCB Downcast(ConditionBean cb) {
            return (KbnRoomTypeCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual KbnRoomTypeDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
