
using System;

using Dbflute.AllCommon;
using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.Dbm.Info;
using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.Dbm {

    public interface DBMeta {

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        String TableDbName { get; }
        String TablePropertyName { get; }
        String TableSqlName { get; }
        String TableAlias { get; }
        String TableComment { get; }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        List<ColumnInfo> ColumnInfoList { get; }
        bool HasColumn(String columnFlexibleName);
        ColumnInfo FindColumnInfo(String columnFlexibleName);

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        UniqueInfo PrimaryUniqueInfo { get; }
        bool HasPrimaryKey { get; }
        bool HasCompoundPrimaryKey { get; }

        // ===============================================================================
        //                                                                   Relation Info
        //                                                                   =============
        // -------------------------------------------------
        //                                  Relation Element
        //                                  ----------------
        RelationInfo FindRelationInfo(String relationPropertyName);

        // -------------------------------------------------
        //                                   Foreign Element
        //                                   ---------------
        bool HasForeign(String foreignPropName);
        DBMeta FindForeignDBMeta(String foreignPropName);
        ForeignInfo FindForeignInfo(String foreignPropName);
        List<ForeignInfo> ForeignInfoList { get; }

        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        bool HasReferrer(String referrerPropertyName);
        DBMeta FindReferrerDBMeta(String referrerPropertyName);
        ReferrerInfo FindReferrerInfo(String referrerPropertyName);
        List<ReferrerInfo> ReferrerInfoList { get; }

        // ===============================================================================
        //                                                                   Identity Info
        //                                                                   =============
        bool HasIdentity { get; }

        // ===============================================================================
        //                                                                   Sequence Info
        //                                                                   =============
        bool HasSequence { get; }
        String SequenceName { get; }
        String SequenceNextValSql { get; }
        int? SequenceIncrementSize { get; }
        int? SequenceCacheSize { get; }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        bool HasVersionNo { get; }
        ColumnInfo VersionNoColumnInfo { get; }
        bool HasUpdateDate { get; }
        ColumnInfo UpdateDateColumnInfo { get; }

        // ===============================================================================
        //                                                              Common Column Info
        //                                                              ==================
        bool HasCommonColumn { get; }

        // ===============================================================================
        //                                                                   Name Handling
        //                                                                   =============
        bool HasFlexibleName(String flexibleName);
        String FindDbName(String flexibleName);
        String FindPropertyName(String flexibleName);

        // ===============================================================================
        //                                                                        Name Map
        //                                                                        ========
        Map<String, String> DbNamePropertyNameKeyToLowerMap { get; }
        Map<String, String> PropertyNameDbNameKeyToLowerMap { get; }

        // ===============================================================================
        //                                                                       Type Name
        //                                                                       =========
        String EntityTypeName { get; }
        String DaoTypeName { get; }
        String ConditionBeanTypeName { get; }
        String BehaviorTypeName { get; }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        Type EntityType { get; }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        Entity NewEntity();
        ConditionBean NewConditionBean();

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
		bool HasEntityPropertySetupper(String propertyName);
        void SetupEntityProperty(String propertyName, Object entity, Object value);
    }

    public interface EntityPropertySetupper<ENTITY> where ENTITY : Entity {
        void Setup(ENTITY entity, Object value);
    }

    public enum OptimisticLockType {
        NONE, VERSION_NO, UPDATE_DATE
    }
}
