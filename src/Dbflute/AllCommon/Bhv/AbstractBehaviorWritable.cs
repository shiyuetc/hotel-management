
using System;
using System.Collections;

using Dbflute.AllCommon;
using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.Dbm;
using Dbflute.AllCommon.Exp;

namespace Dbflute.AllCommon.Bhv {

    public abstract class AbstractBehaviorWritable : AbstractBehaviorReadable, BehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        public virtual void Create(Entity entity) {
            AssertEntityNotNull(entity);
            DoCreate(entity);
        }

        protected abstract void DoCreate(Entity entity);

        public virtual void Modify(Entity entity) {
            AssertEntityNotNull(entity);
            DoModify(entity);
        }

        protected abstract void DoModify(Entity entity);

        protected static void AssertUpdatedEntity(Entity entity, int updatedCount) {
            if (updatedCount == 0) {
                String msg = "The entity was not found! it has already been deleted: entity=" + entity;
                throw new EntityAlreadyDeletedException(msg);
            }
            if (updatedCount > 1) {
                String msg = "The entity was too many! it has been duplicated.";
                msg = msg + " It should be the only one!";
                msg = msg + " But the updatedCount=" + updatedCount;
                msg = msg + ": entity=" + entity;
                throw new EntityDuplicatedException(msg);
            }
        }

        public virtual void Remove(Entity entity) {
            AssertEntityNotNull(entity);
            DoRemove(entity);
        }

        protected abstract void DoRemove(Entity entity);

        protected static void AssertDeletedEntity(Entity entity, int deletedCount) {
            if (deletedCount == 0) {
                String msg = "The entity was Not Found! it has already been deleted: entity=" + entity;
                throw new EntityAlreadyDeletedException(msg);
            }
            if (deletedCount > 1) {
                String msg = "The entity was Too Many! it has been duplicated. It should be the only one! But the deletedCount=" + deletedCount;
                msg = msg + ": entity=" + entity;
                throw new EntityDuplicatedException(msg);
            }
        }

        // -------------------------------------------------
        //                                    InsertOrUpdate
        //                                    --------------
        protected void HelpInsertOrUpdateInternally<ENTITY_TYPE, CB_TYPE>(ENTITY_TYPE entity, InternalInsertOrUpdateCallback<ENTITY_TYPE, CB_TYPE> callback)
                    where ENTITY_TYPE : Entity where CB_TYPE : ConditionBean {
            AssertEntityNotNull(entity);
            if (!entity.HasPrimaryKeyValue) {
                callback.CallbackInsert(entity);
            } else {
                Exception exception = null;
                try {
                   callback.CallbackUpdate(entity);
                } catch (EntityAlreadyUpdatedException e) {
                    if (e.Rows == 0) {
                        exception = e;
                    }
                } catch (EntityAlreadyDeletedException e) {
                    exception = e;
                } catch (OptimisticLockColumnValueNullException e) {
                    exception = e;
                }
                if (exception != null) {
                    CB_TYPE cb = callback.CallbackNewMyConditionBean();
                    callback.CallbackSetupPrimaryKeyCondition(cb, entity);
                    if (callback.CallbackSelectCount(cb) == 0) {
                        callback.CallbackInsert(entity);
                    } else {
                        throw exception;
                    }
                }
            }
        }

        protected interface InternalInsertOrUpdateCallback<ENTITY_TYPE, CB_TYPE> where ENTITY_TYPE : Entity where CB_TYPE : ConditionBean {
            void CallbackInsert(ENTITY_TYPE entity);
            void CallbackUpdate(ENTITY_TYPE entity);
            CB_TYPE CallbackNewMyConditionBean();
            void CallbackSetupPrimaryKeyCondition(CB_TYPE cb, ENTITY_TYPE entity);
            int CallbackSelectCount(CB_TYPE cb);
        }

        protected void HelpInsertOrUpdateInternally<ENTITY_TYPE>(ENTITY_TYPE entity, InternalInsertOrUpdateNonstrictCallback<ENTITY_TYPE> callback)
                where ENTITY_TYPE : Entity {
            AssertEntityNotNull(entity);
            if (!entity.HasPrimaryKeyValue) {
                callback.CallbackInsert(entity);
            } else {
                try {
                    callback.CallbackUpdateNonstrict(entity);
                } catch (EntityAlreadyUpdatedException) {
                    callback.CallbackInsert(entity);
                } catch (EntityAlreadyDeletedException) {
                    callback.CallbackInsert(entity);
                }
            }
        }

        protected interface InternalInsertOrUpdateNonstrictCallback<ENTITY_TYPE> where ENTITY_TYPE : Entity {
            void CallbackInsert(ENTITY_TYPE entity);
            void CallbackUpdateNonstrict(ENTITY_TYPE entity);
        }

        // -------------------------------------------------
        //                                            Delete
        //                                            ------
        protected void HelpDeleteInternally<ENTITY_TYPE>(ENTITY_TYPE entity, InternalDeleteCallback<ENTITY_TYPE> callback) where ENTITY_TYPE : Entity {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int deletedCount = callback.CallbackDelegateDelete(entity);
            AssertUpdatedEntity(entity, deletedCount);
        }

        protected interface InternalDeleteCallback<ENTITY_TYPE> where ENTITY_TYPE : Entity {
            int CallbackDelegateDelete(ENTITY_TYPE entity);
        }

        protected void HelpDeleteNonstrictInternally<ENTITY_TYPE>(ENTITY_TYPE entity, InternalDeleteNonstrictCallback<ENTITY_TYPE> callback) where ENTITY_TYPE : Entity {
            AssertEntityNotNull(entity);
            int deletedCount = callback.CallbackDelegateDeleteNonstrict(entity);
            if (deletedCount == 0) {
                String msg = "The entity was Not Found! The entity has already been deleted: entity=" + entity;
                throw new EntityAlreadyDeletedException(msg);
            } else if (deletedCount > 1) {
                String msg = "The deleted entity was duplicated. It should be the only one! But the deletedCount=" + deletedCount;
                msg = msg + ": entity=" + entity;
                throw new EntityDuplicatedException(msg);
            }
        }

        protected interface InternalDeleteNonstrictCallback<ENTITY_TYPE> where ENTITY_TYPE : Entity {
            int CallbackDelegateDeleteNonstrict(ENTITY_TYPE entity);
        }

        protected void HelpDeleteNonstrictIgnoreDeletedInternally<ENTITY_TYPE>(ENTITY_TYPE entity, InternalDeleteNonstrictIgnoreDeletedCallback<ENTITY_TYPE> callback) where ENTITY_TYPE : Entity {
            AssertEntityNotNull(entity);
            int deletedCount = callback.CallbackDelegateDeleteNonstrict(entity);
            if (deletedCount == 0) {
                return;
            } else if (deletedCount > 1) {
                String msg = "The deleted entity was duplicated. It should be the only one! But the deletedCount=" + deletedCount;
                msg = msg + ": entity=" + entity;
                throw new EntityDuplicatedException(msg);
            }
       }

        protected interface InternalDeleteNonstrictIgnoreDeletedCallback<ENTITY_TYPE> where ENTITY_TYPE : Entity {
            int CallbackDelegateDeleteNonstrict(ENTITY_TYPE entity);
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        // -------------------------------------------------
        //                                            Create
        //                                            ------
        protected virtual bool ProcessBeforeInsert(Entity entity) {
            AssertEntityNotNull(entity);// If this table use identity, the entity does not have primary-key.
            FrameworkFilterEntityOfInsert(entity);
            FilterEntityOfInsert(entity);
            AssertEntityOfInsert(entity);
            return true;
        }

        protected virtual void FrameworkFilterEntityOfInsert(Entity targetEntity) {
            InjectSequenceToPrimaryKeyIfNeeds(targetEntity);
            SetupCommonColumnOfInsertIfNeeds(targetEntity);
        }
		
        protected void InjectSequenceToPrimaryKeyIfNeeds(Entity entity) {
            DBMeta dbmeta = entity.DBMeta;
            if (!dbmeta.HasSequence || dbmeta.HasCompoundPrimaryKey || entity.HasPrimaryKeyValue) {
                return;
            }
            SetupNextValueToPrimaryKey(entity);
        }
        protected virtual void SetupNextValueToPrimaryKey(Entity entity) {// Expect Override of Sub Class!
        }

        protected virtual void SetupCommonColumnOfInsertIfNeeds(Entity targetEntity) {

        }

        protected override void FilterEntityOfInsert(Entity targetEntity) {
        }

        protected virtual void AssertEntityOfInsert(Entity entity) {
        }

        // -------------------------------------------------
        //                                            Modify
        //                                            ------
        protected virtual bool ProcessBeforeUpdate(Entity entity) {
            AssertEntityNotNullAndHasPrimaryKeyValue(entity);
            FrameworkFilterEntityOfUpdate(entity);
            FilterEntityOfUpdate(entity);
            AssertEntityOfUpdate(entity);
            return true;
        }

        protected virtual void FrameworkFilterEntityOfUpdate(Entity targetEntity) {
            SetupCommonColumnOfUpdateIfNeeds(targetEntity);
        }

        protected virtual void SetupCommonColumnOfUpdateIfNeeds(Entity targetEntity) {
        }

        protected virtual void FilterEntityOfUpdate(Dbflute.AllCommon.Entity targetEntity) {
        }

        protected virtual void AssertEntityOfUpdate(Dbflute.AllCommon.Entity entity) {
        }

        // -------------------------------------------------
        //                                            Remove
        //                                            ------
        protected virtual bool ProcessBeforeDelete(Entity entity) {
            AssertEntityNotNullAndHasPrimaryKeyValue(entity);
            FrameworkFilterEntityOfDelete(entity);
            FilterEntityOfDelete(entity);
            AssertEntityOfDelete(entity);
            return true;
        }

        protected virtual void FrameworkFilterEntityOfDelete(Entity targetEntity) {
        }

        protected virtual void FilterEntityOfDelete(Entity targetEntity) {
        }

        protected virtual void AssertEntityOfDelete(Entity entity) {
        }

        // -------------------------------------------------
        //                                            Helper
        //                                            ------
        protected virtual bool IsEntityDefinedCommonColumn(Object obj) {
            if (obj == null) {
                return false;
            }
            if (obj is EntityDefinedCommonColumn) {
                return true;
            } else {
                return false;
            }
        }

        protected void AssertEntityHasVersionNoValue(Entity entity) {
            if (!DBMeta.HasVersionNo) {
                return;
            }
            if (HasVersionNoValue(entity)) {
                return;
            }
            String msg = "Look! Read the message below." + GetLineSeparator();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + GetLineSeparator();
            msg = msg + "The value of 'version no' on the entity was not found!" + GetLineSeparator() + GetLineSeparator();
            msg = msg + "[Advice]" + GetLineSeparator();
            msg = msg + "Please confirm the existence of the value of 'version no' on the entity." + GetLineSeparator();
            msg = msg + "You called the method in which the check for optimistic lock is indispensable. " + GetLineSeparator();
            msg = msg + "So 'version no' is required on the entity. " + GetLineSeparator();
            msg = msg + "In addition, please confirm the necessity of optimistic lock. It might possibly be unnecessary." + GetLineSeparator() + GetLineSeparator();
            msg = msg + "[Entity]" + GetLineSeparator();
            msg = msg + "entity to string = " + entity + GetLineSeparator();
            msg = msg + "* * * * * * * * * */" + GetLineSeparator();
            throw new OptimisticLockColumnValueNullException(msg);
        }

        protected void AssertEntityHasUpdateDateValue(Entity entity) {
            if (!DBMeta.HasUpdateDate) {
                return;
            }
            if (HasUpdateDateValue(entity)) {
                return;
            }
            String msg = "Look! Read the message below." + GetLineSeparator();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + GetLineSeparator();
            msg = msg + "The value of 'update date' on the entity was not found!" + GetLineSeparator() + GetLineSeparator();
            msg = msg + "[Advice]" + GetLineSeparator();
            msg = msg + "Please confirm the existence of the value of 'update date' on the entity." + GetLineSeparator();
            msg = msg + "You called the method in which the check for optimistic lock is indispensable. " + GetLineSeparator();
            msg = msg + "So 'update date' is required on the entity. " + GetLineSeparator();
            msg = msg + "In addition, please confirm the necessity of optimistic lock. It might possibly be unnecessary." + GetLineSeparator() + GetLineSeparator();
            msg = msg + "[Entity]" + GetLineSeparator();
            msg = msg + "entity to string = " + entity + GetLineSeparator();
            msg = msg + "* * * * * * * * * */" + GetLineSeparator();
            throw new OptimisticLockColumnValueNullException(msg);
        }

        public class OptimisticLockColumnValueNullException : SystemException {
            public OptimisticLockColumnValueNullException(String msg) : base(msg) {
            }
        }
    }
}
