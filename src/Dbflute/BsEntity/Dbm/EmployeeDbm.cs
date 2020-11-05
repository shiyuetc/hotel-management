
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

    public class EmployeeDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Employee);

        private static readonly EmployeeDbm _instance = new EmployeeDbm();
        private EmployeeDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static EmployeeDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "employee"; } }
        public override String TablePropertyName { get { return "Employee"; } }
        public override String TableSqlName { get { return "employee"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _columnEmployeeNo;
        protected ColumnInfo _columnPassword;
        protected ColumnInfo _columnRankCode;
        protected ColumnInfo _columnLastName;
        protected ColumnInfo _columnFirstName;
        protected ColumnInfo _columnEntryDate;
        protected ColumnInfo _columnLeaveDate;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo ColumnEmployeeNo { get { return _columnEmployeeNo; } }
        public ColumnInfo ColumnPassword { get { return _columnPassword; } }
        public ColumnInfo ColumnRankCode { get { return _columnRankCode; } }
        public ColumnInfo ColumnLastName { get { return _columnLastName; } }
        public ColumnInfo ColumnFirstName { get { return _columnFirstName; } }
        public ColumnInfo ColumnEntryDate { get { return _columnEntryDate; } }
        public ColumnInfo ColumnLeaveDate { get { return _columnLeaveDate; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(int?), true, "serial", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnEmployeeNo = cci("employee_no", "employee_no", null, null, true, "EmployeeNo", typeof(String), false, "varchar", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnPassword = cci("password", "password", null, null, true, "Password", typeof(String), false, "varchar", 255, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRankCode = cci("rank_code", "rank_code", null, null, true, "RankCode", typeof(String), false, "varchar", 3, 0, false, OptimisticLockType.NONE, null, "rank", null);
            _columnLastName = cci("last_name", "last_name", null, null, true, "LastName", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnFirstName = cci("first_name", "first_name", null, null, true, "FirstName", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnEntryDate = cci("entry_date", "entry_date", null, null, true, "EntryDate", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _columnLeaveDate = cci("leave_date", "leave_date", null, null, false, "LeaveDate", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(ColumnEmployeeNo);
            _columnInfoList.add(ColumnPassword);
            _columnInfoList.add(ColumnRankCode);
            _columnInfoList.add(ColumnLastName);
            _columnInfoList.add(ColumnFirstName);
            _columnInfoList.add(ColumnEntryDate);
            _columnInfoList.add(ColumnLeaveDate);
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
        public ForeignInfo ForeignRank { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnRankCode, RankDbm.GetInstance().ColumnCode);
            return cfi("Rank", this, RankDbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasSequence { get { return true; } }
        public override String SequenceName { get { return "employee_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('employee_id_seq')"; } }
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
        public static readonly String TABLE_DB_NAME = "employee";
        public static readonly String TABLE_PROPERTY_NAME = "Employee";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_employee_no = "employee_no";
        public static readonly String DB_NAME_password = "password";
        public static readonly String DB_NAME_rank_code = "rank_code";
        public static readonly String DB_NAME_last_name = "last_name";
        public static readonly String DB_NAME_first_name = "first_name";
        public static readonly String DB_NAME_entry_date = "entry_date";
        public static readonly String DB_NAME_leave_date = "leave_date";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_employee_no = "EmployeeNo";
        public static readonly String PROPERTY_NAME_password = "Password";
        public static readonly String PROPERTY_NAME_rank_code = "RankCode";
        public static readonly String PROPERTY_NAME_last_name = "LastName";
        public static readonly String PROPERTY_NAME_first_name = "FirstName";
        public static readonly String PROPERTY_NAME_entry_date = "EntryDate";
        public static readonly String PROPERTY_NAME_leave_date = "LeaveDate";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_Rank = "Rank";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static EmployeeDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_employee_no.ToLower(), PROPERTY_NAME_employee_no);
                map.put(DB_NAME_password.ToLower(), PROPERTY_NAME_password);
                map.put(DB_NAME_rank_code.ToLower(), PROPERTY_NAME_rank_code);
                map.put(DB_NAME_last_name.ToLower(), PROPERTY_NAME_last_name);
                map.put(DB_NAME_first_name.ToLower(), PROPERTY_NAME_first_name);
                map.put(DB_NAME_entry_date.ToLower(), PROPERTY_NAME_entry_date);
                map.put(DB_NAME_leave_date.ToLower(), PROPERTY_NAME_leave_date);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_employee_no.ToLower(), DB_NAME_employee_no);
                map.put(PROPERTY_NAME_password.ToLower(), DB_NAME_password);
                map.put(PROPERTY_NAME_rank_code.ToLower(), DB_NAME_rank_code);
                map.put(PROPERTY_NAME_last_name.ToLower(), DB_NAME_last_name);
                map.put(PROPERTY_NAME_first_name.ToLower(), DB_NAME_first_name);
                map.put(PROPERTY_NAME_entry_date.ToLower(), DB_NAME_entry_date);
                map.put(PROPERTY_NAME_leave_date.ToLower(), DB_NAME_leave_date);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Employee"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.EmployeeDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.EmployeeCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.EmployeeBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Employee NewMyEntity() { return new Employee(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public EmployeeCB NewMyConditionBean() { return new EmployeeCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Employee>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Employee>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("employee_no", "EmployeeNo", new EntityPropertyEmployeeNoSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("password", "Password", new EntityPropertyPasswordSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("rank_code", "RankCode", new EntityPropertyRankCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("last_name", "LastName", new EntityPropertyLastNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("first_name", "FirstName", new EntityPropertyFirstNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("entry_date", "EntryDate", new EntityPropertyEntryDateSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("leave_date", "LeaveDate", new EntityPropertyLeaveDateSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Employee> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Employee)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<Employee> {
            public void Setup(Employee entity, Object value) { entity.Id = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyEmployeeNoSetupper : EntityPropertySetupper<Employee> {
            public void Setup(Employee entity, Object value) { entity.EmployeeNo = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyPasswordSetupper : EntityPropertySetupper<Employee> {
            public void Setup(Employee entity, Object value) { entity.Password = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRankCodeSetupper : EntityPropertySetupper<Employee> {
            public void Setup(Employee entity, Object value) { entity.RankCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyLastNameSetupper : EntityPropertySetupper<Employee> {
            public void Setup(Employee entity, Object value) { entity.LastName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyFirstNameSetupper : EntityPropertySetupper<Employee> {
            public void Setup(Employee entity, Object value) { entity.FirstName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyEntryDateSetupper : EntityPropertySetupper<Employee> {
            public void Setup(Employee entity, Object value) { entity.EntryDate = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyLeaveDateSetupper : EntityPropertySetupper<Employee> {
            public void Setup(Employee entity, Object value) { entity.LeaveDate = (value != null) ? (DateTime?)value : null; }
        }
    }
}
