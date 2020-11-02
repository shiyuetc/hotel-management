
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

    public class MstUserDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(MstUser);

        private static readonly MstUserDbm _instance = new MstUserDbm();
        private MstUserDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static MstUserDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "mst_user"; } }
        public override String TablePropertyName { get { return "MstUser"; } }
        public override String TableSqlName { get { return "mst_user"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _columnLoginName;
        protected ColumnInfo _columnName;
        protected ColumnInfo _columnPassword;
        protected ColumnInfo _columnUpdateTime;
        protected ColumnInfo _columnUpdateUser;
        protected ColumnInfo _columnVersionNo;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo ColumnLoginName { get { return _columnLoginName; } }
        public ColumnInfo ColumnName { get { return _columnName; } }
        public ColumnInfo ColumnPassword { get { return _columnPassword; } }
        public ColumnInfo ColumnUpdateTime { get { return _columnUpdateTime; } }
        public ColumnInfo ColumnUpdateUser { get { return _columnUpdateUser; } }
        public ColumnInfo ColumnVersionNo { get { return _columnVersionNo; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(int?), true, "serial", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnLoginName = cci("login_name", "login_name", null, null, true, "LoginName", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnName = cci("name", "name", null, null, true, "Name", typeof(String), false, "varchar", 40, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnPassword = cci("password", "password", null, null, true, "Password", typeof(String), false, "varchar", 255, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnUpdateTime = cci("update_time", "update_time", null, null, true, "UpdateTime", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _columnUpdateUser = cci("update_user", "update_user", null, null, true, "UpdateUser", typeof(String), false, "varchar", 100, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnVersionNo = cci("version_no", "version_no", null, null, true, "VersionNo", typeof(long?), false, "int8", 19, 0, false, OptimisticLockType.VERSION_NO, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(ColumnLoginName);
            _columnInfoList.add(ColumnName);
            _columnInfoList.add(ColumnPassword);
            _columnInfoList.add(ColumnUpdateTime);
            _columnInfoList.add(ColumnUpdateUser);
            _columnInfoList.add(ColumnVersionNo);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnId);
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
        public override bool HasIdentity { get { return true; } }
        public override bool HasVersionNo { get { return true; } }
        public override ColumnInfo VersionNoColumnInfo { get { return _columnVersionNo; } }
        public override bool HasCommonColumn { get { return false; } }

        // ===============================================================================
        //                                                                 Name Definition
        //                                                                 ===============
        #region Name

        // -------------------------------------------------
        //                                             Table
        //                                             -----
        public static readonly String TABLE_DB_NAME = "mst_user";
        public static readonly String TABLE_PROPERTY_NAME = "MstUser";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_login_name = "login_name";
        public static readonly String DB_NAME_name = "name";
        public static readonly String DB_NAME_password = "password";
        public static readonly String DB_NAME_update_time = "update_time";
        public static readonly String DB_NAME_update_user = "update_user";
        public static readonly String DB_NAME_version_no = "version_no";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_login_name = "LoginName";
        public static readonly String PROPERTY_NAME_name = "Name";
        public static readonly String PROPERTY_NAME_password = "Password";
        public static readonly String PROPERTY_NAME_update_time = "UpdateTime";
        public static readonly String PROPERTY_NAME_update_user = "UpdateUser";
        public static readonly String PROPERTY_NAME_version_no = "VersionNo";

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

        static MstUserDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_login_name.ToLower(), PROPERTY_NAME_login_name);
                map.put(DB_NAME_name.ToLower(), PROPERTY_NAME_name);
                map.put(DB_NAME_password.ToLower(), PROPERTY_NAME_password);
                map.put(DB_NAME_update_time.ToLower(), PROPERTY_NAME_update_time);
                map.put(DB_NAME_update_user.ToLower(), PROPERTY_NAME_update_user);
                map.put(DB_NAME_version_no.ToLower(), PROPERTY_NAME_version_no);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_login_name.ToLower(), DB_NAME_login_name);
                map.put(PROPERTY_NAME_name.ToLower(), DB_NAME_name);
                map.put(PROPERTY_NAME_password.ToLower(), DB_NAME_password);
                map.put(PROPERTY_NAME_update_time.ToLower(), DB_NAME_update_time);
                map.put(PROPERTY_NAME_update_user.ToLower(), DB_NAME_update_user);
                map.put(PROPERTY_NAME_version_no.ToLower(), DB_NAME_version_no);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.MstUser"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.MstUserDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.MstUserCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.MstUserBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public MstUser NewMyEntity() { return new MstUser(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public MstUserCB NewMyConditionBean() { return new MstUserCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<MstUser>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<MstUser>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("login_name", "LoginName", new EntityPropertyLoginNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("name", "Name", new EntityPropertyNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("password", "Password", new EntityPropertyPasswordSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("update_time", "UpdateTime", new EntityPropertyUpdateTimeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("update_user", "UpdateUser", new EntityPropertyUpdateUserSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("version_no", "VersionNo", new EntityPropertyVersionNoSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<MstUser> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((MstUser)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<MstUser> {
            public void Setup(MstUser entity, Object value) { entity.Id = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyLoginNameSetupper : EntityPropertySetupper<MstUser> {
            public void Setup(MstUser entity, Object value) { entity.LoginName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyNameSetupper : EntityPropertySetupper<MstUser> {
            public void Setup(MstUser entity, Object value) { entity.Name = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyPasswordSetupper : EntityPropertySetupper<MstUser> {
            public void Setup(MstUser entity, Object value) { entity.Password = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUpdateTimeSetupper : EntityPropertySetupper<MstUser> {
            public void Setup(MstUser entity, Object value) { entity.UpdateTime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUpdateUserSetupper : EntityPropertySetupper<MstUser> {
            public void Setup(MstUser entity, Object value) { entity.UpdateUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyVersionNoSetupper : EntityPropertySetupper<MstUser> {
            public void Setup(MstUser entity, Object value) { entity.VersionNo = (value != null) ? (long?)value : null; }
        }
    }
}
