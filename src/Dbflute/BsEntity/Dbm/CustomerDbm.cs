
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

    public class CustomerDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Customer);

        private static readonly CustomerDbm _instance = new CustomerDbm();
        private CustomerDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static CustomerDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "customer"; } }
        public override String TablePropertyName { get { return "Customer"; } }
        public override String TableSqlName { get { return "customer"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _columnLastName;
        protected ColumnInfo _columnFirstName;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo ColumnLastName { get { return _columnLastName; } }
        public ColumnInfo ColumnFirstName { get { return _columnFirstName; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(long?), true, "bigserial", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnLastName = cci("last_name", "last_name", null, null, true, "LastName", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnFirstName = cci("first_name", "first_name", null, null, true, "FirstName", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(ColumnLastName);
            _columnInfoList.add(ColumnFirstName);
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
        public override bool HasSequence { get { return true; } }
        public override String SequenceName { get { return "customer_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('customer_id_seq')"; } }
        public override int? SequenceIncrementSize { get { return 1; } }
        public override int? SequenceCacheSize { get { return null; } }
        public override bool HasCommonColumn { get { return false; } }

        // ===============================================================================
        //                                                                 Name Definition
        //                                                                 ===============
        #region Name

        // -------------------------------------------------
        //                                             Table
        //                                             -----
        public static readonly String TABLE_DB_NAME = "customer";
        public static readonly String TABLE_PROPERTY_NAME = "Customer";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_last_name = "last_name";
        public static readonly String DB_NAME_first_name = "first_name";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_last_name = "LastName";
        public static readonly String PROPERTY_NAME_first_name = "FirstName";

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

        static CustomerDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_last_name.ToLower(), PROPERTY_NAME_last_name);
                map.put(DB_NAME_first_name.ToLower(), PROPERTY_NAME_first_name);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_last_name.ToLower(), DB_NAME_last_name);
                map.put(PROPERTY_NAME_first_name.ToLower(), DB_NAME_first_name);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Customer"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.CustomerDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.CustomerCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.CustomerBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Customer NewMyEntity() { return new Customer(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public CustomerCB NewMyConditionBean() { return new CustomerCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Customer>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Customer>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("last_name", "LastName", new EntityPropertyLastNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("first_name", "FirstName", new EntityPropertyFirstNameSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Customer> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Customer)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<Customer> {
            public void Setup(Customer entity, Object value) { entity.Id = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyLastNameSetupper : EntityPropertySetupper<Customer> {
            public void Setup(Customer entity, Object value) { entity.LastName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyFirstNameSetupper : EntityPropertySetupper<Customer> {
            public void Setup(Customer entity, Object value) { entity.FirstName = (value != null) ? (String)value : null; }
        }
    }
}
