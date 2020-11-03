
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

    public class MstEmployeeDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(MstEmployee);

        private static readonly MstEmployeeDbm _instance = new MstEmployeeDbm();
        private MstEmployeeDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static MstEmployeeDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "mst_employee"; } }
        public override String TablePropertyName { get { return "MstEmployee"; } }
        public override String TableSqlName { get { return "mst_employee"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _columnEmployeeNo;
        protected ColumnInfo _columnName;
        protected ColumnInfo _columnPassword;
        protected ColumnInfo _columnRankCode;
        protected ColumnInfo _columnEntryDate;
        protected ColumnInfo _columnLeaveDate;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo ColumnEmployeeNo { get { return _columnEmployeeNo; } }
        public ColumnInfo ColumnName { get { return _columnName; } }
        public ColumnInfo ColumnPassword { get { return _columnPassword; } }
        public ColumnInfo ColumnRankCode { get { return _columnRankCode; } }
        public ColumnInfo ColumnEntryDate { get { return _columnEntryDate; } }
        public ColumnInfo ColumnLeaveDate { get { return _columnLeaveDate; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(int?), true, "serial", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnEmployeeNo = cci("employee_no", "employee_no", null, null, true, "EmployeeNo", typeof(String), false, "varchar", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnName = cci("name", "name", null, null, true, "Name", typeof(String), false, "varchar", 50, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnPassword = cci("password", "password", null, null, true, "Password", typeof(String), false, "varchar", 255, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRankCode = cci("rank_code", "rank_code", null, null, true, "RankCode", typeof(String), false, "varchar", 3, 0, false, OptimisticLockType.NONE, null, "kbnRank", null);
            _columnEntryDate = cci("entry_date", "entry_date", null, null, true, "EntryDate", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _columnLeaveDate = cci("leave_date", "leave_date", null, null, false, "LeaveDate", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(ColumnEmployeeNo);
            _columnInfoList.add(ColumnName);
            _columnInfoList.add(ColumnPassword);
            _columnInfoList.add(ColumnRankCode);
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
        public ForeignInfo ForeignKbnRank { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnRankCode, KbnRankDbm.GetInstance().ColumnCode);
            return cfi("KbnRank", this, KbnRankDbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasSequence { get { return true; } }
        public override String SequenceName { get { return "mst_employee_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('mst_employee_id_seq')"; } }
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
        public static readonly String TABLE_DB_NAME = "mst_employee";
        public static readonly String TABLE_PROPERTY_NAME = "MstEmployee";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_employee_no = "employee_no";
        public static readonly String DB_NAME_name = "name";
        public static readonly String DB_NAME_password = "password";
        public static readonly String DB_NAME_rank_code = "rank_code";
        public static readonly String DB_NAME_entry_date = "entry_date";
        public static readonly String DB_NAME_leave_date = "leave_date";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_employee_no = "EmployeeNo";
        public static readonly String PROPERTY_NAME_name = "Name";
        public static readonly String PROPERTY_NAME_password = "Password";
        public static readonly String PROPERTY_NAME_rank_code = "RankCode";
        public static readonly String PROPERTY_NAME_entry_date = "EntryDate";
        public static readonly String PROPERTY_NAME_leave_date = "LeaveDate";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_KbnRank = "KbnRank";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static MstEmployeeDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_employee_no.ToLower(), PROPERTY_NAME_employee_no);
                map.put(DB_NAME_name.ToLower(), PROPERTY_NAME_name);
                map.put(DB_NAME_password.ToLower(), PROPERTY_NAME_password);
                map.put(DB_NAME_rank_code.ToLower(), PROPERTY_NAME_rank_code);
                map.put(DB_NAME_entry_date.ToLower(), PROPERTY_NAME_entry_date);
                map.put(DB_NAME_leave_date.ToLower(), PROPERTY_NAME_leave_date);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_employee_no.ToLower(), DB_NAME_employee_no);
                map.put(PROPERTY_NAME_name.ToLower(), DB_NAME_name);
                map.put(PROPERTY_NAME_password.ToLower(), DB_NAME_password);
                map.put(PROPERTY_NAME_rank_code.ToLower(), DB_NAME_rank_code);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.MstEmployee"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.MstEmployeeDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.MstEmployeeCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.MstEmployeeBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public MstEmployee NewMyEntity() { return new MstEmployee(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public MstEmployeeCB NewMyConditionBean() { return new MstEmployeeCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<MstEmployee>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<MstEmployee>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("employee_no", "EmployeeNo", new EntityPropertyEmployeeNoSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("name", "Name", new EntityPropertyNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("password", "Password", new EntityPropertyPasswordSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("rank_code", "RankCode", new EntityPropertyRankCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("entry_date", "EntryDate", new EntityPropertyEntryDateSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("leave_date", "LeaveDate", new EntityPropertyLeaveDateSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<MstEmployee> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((MstEmployee)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<MstEmployee> {
            public void Setup(MstEmployee entity, Object value) { entity.Id = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyEmployeeNoSetupper : EntityPropertySetupper<MstEmployee> {
            public void Setup(MstEmployee entity, Object value) { entity.EmployeeNo = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyNameSetupper : EntityPropertySetupper<MstEmployee> {
            public void Setup(MstEmployee entity, Object value) { entity.Name = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyPasswordSetupper : EntityPropertySetupper<MstEmployee> {
            public void Setup(MstEmployee entity, Object value) { entity.Password = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRankCodeSetupper : EntityPropertySetupper<MstEmployee> {
            public void Setup(MstEmployee entity, Object value) { entity.RankCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyEntryDateSetupper : EntityPropertySetupper<MstEmployee> {
            public void Setup(MstEmployee entity, Object value) { entity.EntryDate = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyLeaveDateSetupper : EntityPropertySetupper<MstEmployee> {
            public void Setup(MstEmployee entity, Object value) { entity.LeaveDate = (value != null) ? (DateTime?)value : null; }
        }
    }
}
