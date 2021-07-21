
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

    public class Mstメニュー権限マスタDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Mstメニュー権限マスタ);

        private static readonly Mstメニュー権限マスタDbm _instance = new Mstメニュー権限マスタDbm();
        private Mstメニュー権限マスタDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Mstメニュー権限マスタDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "mstメニュー権限マスタ"; } }
        public override String TablePropertyName { get { return "Mstメニュー権限マスタ"; } }
        public override String TableSqlName { get { return "mstメニュー権限マスタ"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _column職位code;
        protected ColumnInfo _column制御画面id;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo Column職位code { get { return _column職位code; } }
        public ColumnInfo Column制御画面id { get { return _column制御画面id; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(long?), true, "bigserial", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _column職位code = cci("職位code", "職位code", null, null, true, "職位code", typeof(String), false, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, "kbn職位区分", null);
            _column制御画面id = cci("制御画面id", "制御画面id", null, null, true, "制御画面id", typeof(long?), false, "int8", 19, 0, false, OptimisticLockType.NONE, null, "mst制御画面マスタ", null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(Column職位code);
            _columnInfoList.add(Column制御画面id);
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
        public ForeignInfo ForeignMst制御画面マスタ { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column制御画面id, Mst制御画面マスタDbm.GetInstance().ColumnId);
            return cfi("Mst制御画面マスタ", this, Mst制御画面マスタDbm.GetInstance(), map, 0, false, false);
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
        public override String SequenceName { get { return "mst002_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('mst002_id_seq')"; } }
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
        public static readonly String TABLE_DB_NAME = "mstメニュー権限マスタ";
        public static readonly String TABLE_PROPERTY_NAME = "Mstメニュー権限マスタ";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_職位code = "職位code";
        public static readonly String DB_NAME_制御画面id = "制御画面id";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_職位code = "職位code";
        public static readonly String PROPERTY_NAME_制御画面id = "制御画面id";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_Mst制御画面マスタ = "Mst制御画面マスタ";
        public static readonly String FOREIGN_PROPERTY_NAME_Kbn職位区分 = "Kbn職位区分";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Mstメニュー権限マスタDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_職位code.ToLower(), PROPERTY_NAME_職位code);
                map.put(DB_NAME_制御画面id.ToLower(), PROPERTY_NAME_制御画面id);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_職位code.ToLower(), DB_NAME_職位code);
                map.put(PROPERTY_NAME_制御画面id.ToLower(), DB_NAME_制御画面id);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Mstメニュー権限マスタ"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Mstメニュー権限マスタDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Mstメニュー権限マスタCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Mstメニュー権限マスタBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Mstメニュー権限マスタ NewMyEntity() { return new Mstメニュー権限マスタ(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Mstメニュー権限マスタCB NewMyConditionBean() { return new Mstメニュー権限マスタCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Mstメニュー権限マスタ>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Mstメニュー権限マスタ>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("職位code", "職位code", new EntityProperty職位codeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("制御画面id", "制御画面id", new EntityProperty制御画面idSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Mstメニュー権限マスタ> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Mstメニュー権限マスタ)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<Mstメニュー権限マスタ> {
            public void Setup(Mstメニュー権限マスタ entity, Object value) { entity.Id = (value != null) ? (long?)value : null; }
        }
        public class EntityProperty職位codeSetupper : EntityPropertySetupper<Mstメニュー権限マスタ> {
            public void Setup(Mstメニュー権限マスタ entity, Object value) { entity.職位code = (value != null) ? (String)value : null; }
        }
        public class EntityProperty制御画面idSetupper : EntityPropertySetupper<Mstメニュー権限マスタ> {
            public void Setup(Mstメニュー権限マスタ entity, Object value) { entity.制御画面id = (value != null) ? (long?)value : null; }
        }
    }
}
