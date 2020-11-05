
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

    public class RoomTypeDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(RoomType);

        private static readonly RoomTypeDbm _instance = new RoomTypeDbm();
        private RoomTypeDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static RoomTypeDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "room_type"; } }
        public override String TablePropertyName { get { return "RoomType"; } }
        public override String TableSqlName { get { return "room_type"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnCode;
        protected ColumnInfo _columnName;
        protected ColumnInfo _columnPrice;
        protected ColumnInfo _columnCapacity;
        protected ColumnInfo _columnDescription;

        public ColumnInfo ColumnCode { get { return _columnCode; } }
        public ColumnInfo ColumnName { get { return _columnName; } }
        public ColumnInfo ColumnPrice { get { return _columnPrice; } }
        public ColumnInfo ColumnCapacity { get { return _columnCapacity; } }
        public ColumnInfo ColumnDescription { get { return _columnDescription; } }

        protected void InitializeColumnInfo() {
            _columnCode = cci("code", "code", null, null, true, "Code", typeof(String), true, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnName = cci("name", "name", null, null, true, "Name", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnPrice = cci("price", "price", null, null, false, "Price", typeof(int?), false, "int4", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnCapacity = cci("capacity", "capacity", null, null, false, "Capacity", typeof(int?), false, "int4", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnDescription = cci("description", "description", null, null, true, "Description", typeof(String), false, "varchar", 255, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnCode);
            _columnInfoList.add(ColumnName);
            _columnInfoList.add(ColumnPrice);
            _columnInfoList.add(ColumnCapacity);
            _columnInfoList.add(ColumnDescription);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnCode);
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
        public override bool HasCommonColumn { get { return false; } }

        // ===============================================================================
        //                                                                 Name Definition
        //                                                                 ===============
        #region Name

        // -------------------------------------------------
        //                                             Table
        //                                             -----
        public static readonly String TABLE_DB_NAME = "room_type";
        public static readonly String TABLE_PROPERTY_NAME = "RoomType";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_code = "code";
        public static readonly String DB_NAME_name = "name";
        public static readonly String DB_NAME_price = "price";
        public static readonly String DB_NAME_capacity = "capacity";
        public static readonly String DB_NAME_description = "description";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_code = "Code";
        public static readonly String PROPERTY_NAME_name = "Name";
        public static readonly String PROPERTY_NAME_price = "Price";
        public static readonly String PROPERTY_NAME_capacity = "Capacity";
        public static readonly String PROPERTY_NAME_description = "Description";

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

        static RoomTypeDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_code.ToLower(), PROPERTY_NAME_code);
                map.put(DB_NAME_name.ToLower(), PROPERTY_NAME_name);
                map.put(DB_NAME_price.ToLower(), PROPERTY_NAME_price);
                map.put(DB_NAME_capacity.ToLower(), PROPERTY_NAME_capacity);
                map.put(DB_NAME_description.ToLower(), PROPERTY_NAME_description);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_code.ToLower(), DB_NAME_code);
                map.put(PROPERTY_NAME_name.ToLower(), DB_NAME_name);
                map.put(PROPERTY_NAME_price.ToLower(), DB_NAME_price);
                map.put(PROPERTY_NAME_capacity.ToLower(), DB_NAME_capacity);
                map.put(PROPERTY_NAME_description.ToLower(), DB_NAME_description);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.RoomType"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.RoomTypeDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.RoomTypeCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.RoomTypeBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public RoomType NewMyEntity() { return new RoomType(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public RoomTypeCB NewMyConditionBean() { return new RoomTypeCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<RoomType>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<RoomType>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("code", "Code", new EntityPropertyCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("name", "Name", new EntityPropertyNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("price", "Price", new EntityPropertyPriceSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("capacity", "Capacity", new EntityPropertyCapacitySetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("description", "Description", new EntityPropertyDescriptionSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<RoomType> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((RoomType)entity, value);
        }

        public class EntityPropertyCodeSetupper : EntityPropertySetupper<RoomType> {
            public void Setup(RoomType entity, Object value) { entity.Code = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyNameSetupper : EntityPropertySetupper<RoomType> {
            public void Setup(RoomType entity, Object value) { entity.Name = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyPriceSetupper : EntityPropertySetupper<RoomType> {
            public void Setup(RoomType entity, Object value) { entity.Price = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyCapacitySetupper : EntityPropertySetupper<RoomType> {
            public void Setup(RoomType entity, Object value) { entity.Capacity = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyDescriptionSetupper : EntityPropertySetupper<RoomType> {
            public void Setup(RoomType entity, Object value) { entity.Description = (value != null) ? (String)value : null; }
        }
    }
}
