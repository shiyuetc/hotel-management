
using System;
using System.Reflection;

using Dbflute.AllCommon;
using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.Dbm;
using Dbflute.AllCommon.Dbm.Info;
using Dbflute.AllCommon.JavaLike;
using Dbflute.ExEntity;

using Dbflute.ExDao;
using Dbflute.CBean;

namespace Dbflute.BsEntity.Dbm {

    public class USERDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(USER);

        private static readonly USERDbm _instance = new USERDbm();
        private USERDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static USERDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "USER"; } }
        public override String TablePropertyName { get { return "USER"; } }
        public override String TableSqlName { get { return "USER"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnID;
        protected ColumnInfo _columnNAME;
        protected ColumnInfo _columnUPDATE_DATETIME;
        protected ColumnInfo _columnUPDATE_USER;
        protected ColumnInfo _columnVERSION_NO;

        public ColumnInfo ColumnID { get { return _columnID; } }
        public ColumnInfo ColumnNAME { get { return _columnNAME; } }
        public ColumnInfo ColumnUPDATE_DATETIME { get { return _columnUPDATE_DATETIME; } }
        public ColumnInfo ColumnUPDATE_USER { get { return _columnUPDATE_USER; } }
        public ColumnInfo ColumnVERSION_NO { get { return _columnVERSION_NO; } }

        protected void InitializeColumnInfo() {
            _columnID = cci("ID", "ID", null, null, true, "ID", typeof(int?), true, "INTEGER", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnNAME = cci("NAME", "NAME", null, null, true, "NAME", typeof(String), false, "VARCHAR", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnUPDATE_DATETIME = cci("UPDATE_DATETIME", "UPDATE_DATETIME", null, null, true, "UPDATE_DATETIME", typeof(DateTime?), false, "TIMESTAMP", 26, 6, false, OptimisticLockType.NONE, null, null, null);
            _columnUPDATE_USER = cci("UPDATE_USER", "UPDATE_USER", null, null, true, "UPDATE_USER", typeof(String), false, "VARCHAR", 200, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnVERSION_NO = cci("VERSION_NO", "VERSION_NO", null, null, true, "VERSION_NO", typeof(long?), false, "BIGINT", 19, 0, false, OptimisticLockType.VERSION_NO, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnID);
            _columnInfoList.add(ColumnNAME);
            _columnInfoList.add(ColumnUPDATE_DATETIME);
            _columnInfoList.add(ColumnUPDATE_USER);
            _columnInfoList.add(ColumnVERSION_NO);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnID);
        }}

        // -------------------------------------------------
        //                                   Primary Element
        //                                   ---------------
        public override bool HasPrimaryKey { get { return true; } }
        public override bool HasCompoundPrimaryKey { get { return false; } }

        // ===============================================================================
        //                                                                   Relation Info
        //                                                                   =============
        // -------------------------------------------------
        //                                   Foreign Element
        //                                   ---------------


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasVersionNo { get { return true; } }
        public override ColumnInfo VersionNoColumnInfo { get { return _columnVERSION_NO; } }
        public override bool HasCommonColumn { get { return false; } }

        // ===============================================================================
        //                                                                 Name Definition
        //                                                                 ===============
        #region Name

        // -------------------------------------------------
        //                                             Table
        //                                             -----
        public static readonly String TABLE_DB_NAME = "USER";
        public static readonly String TABLE_PROPERTY_NAME = "USER";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_ID = "ID";
        public static readonly String DB_NAME_NAME = "NAME";
        public static readonly String DB_NAME_UPDATE_DATETIME = "UPDATE_DATETIME";
        public static readonly String DB_NAME_UPDATE_USER = "UPDATE_USER";
        public static readonly String DB_NAME_VERSION_NO = "VERSION_NO";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_ID = "ID";
        public static readonly String PROPERTY_NAME_NAME = "NAME";
        public static readonly String PROPERTY_NAME_UPDATE_DATETIME = "UPDATE_DATETIME";
        public static readonly String PROPERTY_NAME_UPDATE_USER = "UPDATE_USER";
        public static readonly String PROPERTY_NAME_VERSION_NO = "VERSION_NO";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static USERDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_ID.ToLower(), PROPERTY_NAME_ID);
                map.put(DB_NAME_NAME.ToLower(), PROPERTY_NAME_NAME);
                map.put(DB_NAME_UPDATE_DATETIME.ToLower(), PROPERTY_NAME_UPDATE_DATETIME);
                map.put(DB_NAME_UPDATE_USER.ToLower(), PROPERTY_NAME_UPDATE_USER);
                map.put(DB_NAME_VERSION_NO.ToLower(), PROPERTY_NAME_VERSION_NO);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_ID.ToLower(), DB_NAME_ID);
                map.put(PROPERTY_NAME_NAME.ToLower(), DB_NAME_NAME);
                map.put(PROPERTY_NAME_UPDATE_DATETIME.ToLower(), DB_NAME_UPDATE_DATETIME);
                map.put(PROPERTY_NAME_UPDATE_USER.ToLower(), DB_NAME_UPDATE_USER);
                map.put(PROPERTY_NAME_VERSION_NO.ToLower(), DB_NAME_VERSION_NO);
                _propertyNameDbNameKeyToLowerMap = map;
            }
        }

        #endregion

        // ===============================================================================
        //                                                                        Name Map
        //                                                                        ========
        #region Name Map
        public override Map<String, String> DbNamePropertyNameKeyToLowerMap { get { return _dbNamePropertyNameKeyToLowerMap; } }
        public override Map<String, String> PropertyNameDbNameKeyToLowerMap { get { return _propertyNameDbNameKeyToLowerMap; } }
        #endregion

        // ===============================================================================
        //                                                                       Type Name
        //                                                                       =========
        public override String EntityTypeName { get { return "Dbflute.ExEntity.USER"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.USERDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.USERCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.USERBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public USER NewMyEntity() { return new USER(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public USERCB NewMyConditionBean() { return new USERCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<USER>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<USER>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("ID", "ID", new EntityPropertyIDSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("NAME", "NAME", new EntityPropertyNAMESetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("UPDATE_DATETIME", "UPDATE_DATETIME", new EntityPropertyUPDATE_DATETIMESetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("UPDATE_USER", "UPDATE_USER", new EntityPropertyUPDATE_USERSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("VERSION_NO", "VERSION_NO", new EntityPropertyVERSION_NOSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<USER> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((USER)entity, value);
        }

        public class EntityPropertyIDSetupper : EntityPropertySetupper<USER> {
            public void Setup(USER entity, Object value) { entity.ID = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyNAMESetupper : EntityPropertySetupper<USER> {
            public void Setup(USER entity, Object value) { entity.NAME = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUPDATE_DATETIMESetupper : EntityPropertySetupper<USER> {
            public void Setup(USER entity, Object value) { entity.UPDATE_DATETIME = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUPDATE_USERSetupper : EntityPropertySetupper<USER> {
            public void Setup(USER entity, Object value) { entity.UPDATE_USER = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyVERSION_NOSetupper : EntityPropertySetupper<USER> {
            public void Setup(USER entity, Object value) { entity.VERSION_NO = (value != null) ? (long?)value : null; }
        }
    }
}
