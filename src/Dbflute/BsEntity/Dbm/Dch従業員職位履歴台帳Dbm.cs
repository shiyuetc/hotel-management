
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

    public class Dch従業員職位履歴台帳Dbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Dch従業員職位履歴台帳);

        private static readonly Dch従業員職位履歴台帳Dbm _instance = new Dch従業員職位履歴台帳Dbm();
        private Dch従業員職位履歴台帳Dbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Dch従業員職位履歴台帳Dbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "dch従業員職位履歴台帳"; } }
        public override String TablePropertyName { get { return "Dch従業員職位履歴台帳"; } }
        public override String TableSqlName { get { return "dch従業員職位履歴台帳"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _column従業員id;
        protected ColumnInfo _column適用開始日;
        protected ColumnInfo _column適用終了日;
        protected ColumnInfo _column職位code;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo Column従業員id { get { return _column従業員id; } }
        public ColumnInfo Column適用開始日 { get { return _column適用開始日; } }
        public ColumnInfo Column適用終了日 { get { return _column適用終了日; } }
        public ColumnInfo Column職位code { get { return _column職位code; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(long?), true, "bigserial", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _column従業員id = cci("従業員id", "従業員id", null, null, true, "従業員id", typeof(long?), false, "int8", 19, 0, false, OptimisticLockType.NONE, null, "mst従業員マスタ", null);
            _column適用開始日 = cci("適用開始日", "適用開始日", null, null, true, "適用開始日", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _column適用終了日 = cci("適用終了日", "適用終了日", null, null, true, "適用終了日", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _column職位code = cci("職位code", "職位code", null, null, true, "職位code", typeof(String), false, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, "kbn職位区分", null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(Column従業員id);
            _columnInfoList.add(Column適用開始日);
            _columnInfoList.add(Column適用終了日);
            _columnInfoList.add(Column職位code);
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
        public ForeignInfo ForeignMst従業員マスタ { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column従業員id, Mst従業員マスタDbm.GetInstance().ColumnId);
            return cfi("Mst従業員マスタ", this, Mst従業員マスタDbm.GetInstance(), map, 0, false, false);
        }}
        public ForeignInfo ForeignKbn職位区分 { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column職位code, Kbn職位区分Dbm.GetInstance().ColumnCode);
            return cfi("Kbn職位区分", this, Kbn職位区分Dbm.GetInstance(), map, 1, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasSequence { get { return true; } }
        public override String SequenceName { get { return "dch001_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('dch001_id_seq')"; } }
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
        public static readonly String TABLE_DB_NAME = "dch従業員職位履歴台帳";
        public static readonly String TABLE_PROPERTY_NAME = "Dch従業員職位履歴台帳";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_従業員id = "従業員id";
        public static readonly String DB_NAME_適用開始日 = "適用開始日";
        public static readonly String DB_NAME_適用終了日 = "適用終了日";
        public static readonly String DB_NAME_職位code = "職位code";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_従業員id = "従業員id";
        public static readonly String PROPERTY_NAME_適用開始日 = "適用開始日";
        public static readonly String PROPERTY_NAME_適用終了日 = "適用終了日";
        public static readonly String PROPERTY_NAME_職位code = "職位code";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_Mst従業員マスタ = "Mst従業員マスタ";
        public static readonly String FOREIGN_PROPERTY_NAME_Kbn職位区分 = "Kbn職位区分";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Dch従業員職位履歴台帳Dbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_従業員id.ToLower(), PROPERTY_NAME_従業員id);
                map.put(DB_NAME_適用開始日.ToLower(), PROPERTY_NAME_適用開始日);
                map.put(DB_NAME_適用終了日.ToLower(), PROPERTY_NAME_適用終了日);
                map.put(DB_NAME_職位code.ToLower(), PROPERTY_NAME_職位code);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_従業員id.ToLower(), DB_NAME_従業員id);
                map.put(PROPERTY_NAME_適用開始日.ToLower(), DB_NAME_適用開始日);
                map.put(PROPERTY_NAME_適用終了日.ToLower(), DB_NAME_適用終了日);
                map.put(PROPERTY_NAME_職位code.ToLower(), DB_NAME_職位code);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Dch従業員職位履歴台帳"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Dch従業員職位履歴台帳Dao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Dch従業員職位履歴台帳CB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Dch従業員職位履歴台帳Bhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Dch従業員職位履歴台帳 NewMyEntity() { return new Dch従業員職位履歴台帳(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Dch従業員職位履歴台帳CB NewMyConditionBean() { return new Dch従業員職位履歴台帳CB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Dch従業員職位履歴台帳>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Dch従業員職位履歴台帳>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("従業員id", "従業員id", new EntityProperty従業員idSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("適用開始日", "適用開始日", new EntityProperty適用開始日Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("適用終了日", "適用終了日", new EntityProperty適用終了日Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("職位code", "職位code", new EntityProperty職位codeSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Dch従業員職位履歴台帳> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Dch従業員職位履歴台帳)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<Dch従業員職位履歴台帳> {
            public void Setup(Dch従業員職位履歴台帳 entity, Object value) { entity.Id = (value != null) ? (long?)value : null; }
        }
        public class EntityProperty従業員idSetupper : EntityPropertySetupper<Dch従業員職位履歴台帳> {
            public void Setup(Dch従業員職位履歴台帳 entity, Object value) { entity.従業員id = (value != null) ? (long?)value : null; }
        }
        public class EntityProperty適用開始日Setupper : EntityPropertySetupper<Dch従業員職位履歴台帳> {
            public void Setup(Dch従業員職位履歴台帳 entity, Object value) { entity.適用開始日 = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityProperty適用終了日Setupper : EntityPropertySetupper<Dch従業員職位履歴台帳> {
            public void Setup(Dch従業員職位履歴台帳 entity, Object value) { entity.適用終了日 = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityProperty職位codeSetupper : EntityPropertySetupper<Dch従業員職位履歴台帳> {
            public void Setup(Dch従業員職位履歴台帳 entity, Object value) { entity.職位code = (value != null) ? (String)value : null; }
        }
    }
}
