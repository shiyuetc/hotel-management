
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

    public class MstCustomerDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(MstCustomer);

        private static readonly MstCustomerDbm _instance = new MstCustomerDbm();
        private MstCustomerDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static MstCustomerDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "mst_customer"; } }
        public override String TablePropertyName { get { return "MstCustomer"; } }
        public override String TableSqlName { get { return "mst_customer"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _columnName;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo ColumnName { get { return _columnName; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(int?), true, "serial", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnName = cci("name", "name", null, null, true, "Name", typeof(String), false, "varchar", 50, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(ColumnName);
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
        public override String SequenceName { get { return "mst_customer_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('mst_customer_id_seq')"; } }
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
        public static readonly String TABLE_DB_NAME = "mst_customer";
        public static readonly String TABLE_PROPERTY_NAME = "MstCustomer";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_name = "name";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_name = "Name";

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

        static MstCustomerDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_name.ToLower(), PROPERTY_NAME_name);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_name.ToLower(), DB_NAME_name);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.MstCustomer"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.MstCustomerDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.MstCustomerCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.MstCustomerBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public MstCustomer NewMyEntity() { return new MstCustomer(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public MstCustomerCB NewMyConditionBean() { return new MstCustomerCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<MstCustomer>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<MstCustomer>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("name", "Name", new EntityPropertyNameSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<MstCustomer> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((MstCustomer)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<MstCustomer> {
            public void Setup(MstCustomer entity, Object value) { entity.Id = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyNameSetupper : EntityPropertySetupper<MstCustomer> {
            public void Setup(MstCustomer entity, Object value) { entity.Name = (value != null) ? (String)value : null; }
        }
    }
}
