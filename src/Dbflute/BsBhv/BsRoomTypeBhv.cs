
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
    public partial class RoomTypeBhv : Dbflute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected RoomTypeDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public RoomTypeBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "room_type"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return RoomTypeDbm.GetInstance(); } }
        public RoomTypeDbm MyDBMeta { get { return RoomTypeDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual RoomType NewMyEntity() { return new RoomType(); }
        public virtual RoomTypeCB NewMyConditionBean() { return new RoomTypeCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(RoomTypeCB cb) {
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
        public virtual RoomType SelectEntity(RoomTypeCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<RoomType> ls = null;
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
            return (RoomType)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual RoomType SelectEntityWithDeletedCheck(RoomTypeCB cb) {
            AssertConditionBeanNotNull(cb);
            RoomType entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual RoomType SelectByPKValue(String code) {
            return SelectEntity(BuildPKCB(code));
        }

        public virtual RoomType SelectByPKValueWithDeletedCheck(String code) {
            return SelectEntityWithDeletedCheck(BuildPKCB(code));
        }

        private RoomTypeCB BuildPKCB(String code) {
            AssertObjectNotNull("code", code);
            RoomTypeCB cb = NewMyConditionBean();
            cb.Query().SetCode_Equal(code);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<RoomType> SelectList(RoomTypeCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<RoomType>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<RoomType> SelectPage(RoomTypeCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<RoomType> invoker = new PagingInvoker<RoomType>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<RoomType> {
            protected RoomTypeBhv _bhv; protected RoomTypeCB _cb;
            public InternalSelectPagingHandler(RoomTypeBhv bhv, RoomTypeCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<RoomType> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadRoomList(RoomType roomType, ConditionBeanSetupper<RoomCB> conditionBeanSetupper) {
            AssertObjectNotNull("roomType", roomType); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadRoomList(xnewLRLs<RoomType>(roomType), conditionBeanSetupper);
        }
        public virtual void LoadRoomList(IList<RoomType> roomTypeList, ConditionBeanSetupper<RoomCB> conditionBeanSetupper) {
            AssertObjectNotNull("roomTypeList", roomTypeList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadRoomList(roomTypeList, new LoadReferrerOption<RoomCB, Room>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadRoomList(RoomType roomType, LoadReferrerOption<RoomCB, Room> loadReferrerOption) {
            AssertObjectNotNull("roomType", roomType); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadRoomList(xnewLRLs<RoomType>(roomType), loadReferrerOption);
        }
        public virtual void LoadRoomList(IList<RoomType> roomTypeList, LoadReferrerOption<RoomCB, Room> loadReferrerOption) {
            AssertObjectNotNull("roomTypeList", roomTypeList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (roomTypeList.Count == 0) { return; }
            RoomBhv referrerBhv = xgetBSFLR().Select<RoomBhv>();
            HelpLoadReferrerInternally<RoomType, String, RoomCB, Room>
                    (roomTypeList, loadReferrerOption, new MyInternalLoadRoomListCallback(referrerBhv));
        }
        protected class MyInternalLoadRoomListCallback : InternalLoadReferrerCallback<RoomType, String, RoomCB, Room> {
            protected RoomBhv referrerBhv;
            public MyInternalLoadRoomListCallback(RoomBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(RoomType e) { return e.Code; }
            public void setRfLs(RoomType e, IList<Room> ls) { e.RoomList = ls; }
            public RoomCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(RoomCB cb, IList<String> ls) { cb.Query().SetRoomTypeCode_InScope(ls); }
            public void qyOdFKAsc(RoomCB cb) { cb.Query().AddOrderBy_RoomTypeCode_Asc(); }
            public void spFKCol(RoomCB cb) { cb.Specify().ColumnRoomTypeCode(); }
            public IList<Room> selRfLs(RoomCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(Room e) { return e.RoomTypeCode; }
            public void setlcEt(Room re, RoomType be) { re.RoomType = be; }
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
        public virtual void Insert(RoomType entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(RoomType entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(RoomType entity) {
            HelpInsertOrUpdateInternally<RoomType, RoomTypeCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<RoomType, RoomTypeCB> {
            protected RoomTypeBhv _bhv;
            public MyInternalInsertOrUpdateCallback(RoomTypeBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(RoomType entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(RoomType entity) { _bhv.Update(entity); }
            public RoomTypeCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(RoomTypeCB cb, RoomType entity) {
                cb.Query().SetCode_Equal(entity.Code);
            }
            public int CallbackSelectCount(RoomTypeCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(RoomType entity) {
            HelpDeleteInternally<RoomType>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<RoomType> {
            protected RoomTypeBhv _bhv;
            public MyInternalDeleteCallback(RoomTypeBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(RoomType entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(RoomType roomType, RoomTypeCB cb) {
            AssertObjectNotNull("roomType", roomType); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(roomType);
            FilterEntityOfUpdate(roomType); AssertEntityOfUpdate(roomType);
            return this.Dao.UpdateByQuery(cb, roomType);
        }

        public int QueryDelete(RoomTypeCB cb) {
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
        protected int DelegateSelectCount(RoomTypeCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<RoomType> DelegateSelectList(RoomTypeCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(RoomType e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(RoomType e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(RoomType e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected RoomType Downcast(Entity entity) {
            return (RoomType)entity;
        }

        protected RoomTypeCB Downcast(ConditionBean cb) {
            return (RoomTypeCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual RoomTypeDao Dao { get { return _dao; } set { _dao = value; } }
    }
}
