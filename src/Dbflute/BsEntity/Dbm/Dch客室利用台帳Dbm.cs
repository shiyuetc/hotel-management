
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

    public class Dch客室利用台帳Dbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Dch客室利用台帳);

        private static readonly Dch客室利用台帳Dbm _instance = new Dch客室利用台帳Dbm();
        private Dch客室利用台帳Dbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Dch客室利用台帳Dbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "dch客室利用台帳"; } }
        public override String TablePropertyName { get { return "Dch客室利用台帳"; } }
        public override String TableSqlName { get { return "dch客室利用台帳"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _column客室利用コード;
        protected ColumnInfo _column客室コード;
        protected ColumnInfo _column開始予定日時;
        protected ColumnInfo _column終了予定日時;
        protected ColumnInfo _column開始実績日時;
        protected ColumnInfo _column終了実績日時;
        protected ColumnInfo _column備考;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo Column客室利用コード { get { return _column客室利用コード; } }
        public ColumnInfo Column客室コード { get { return _column客室コード; } }
        public ColumnInfo Column開始予定日時 { get { return _column開始予定日時; } }
        public ColumnInfo Column終了予定日時 { get { return _column終了予定日時; } }
        public ColumnInfo Column開始実績日時 { get { return _column開始実績日時; } }
        public ColumnInfo Column終了実績日時 { get { return _column終了実績日時; } }
        public ColumnInfo Column備考 { get { return _column備考; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(long?), true, "bigserial", 19, 0, false, OptimisticLockType.NONE, null, null, "");
            _column客室利用コード = cci("客室利用コード", "客室利用コード", null, null, true, "客室利用コード", typeof(String), false, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, "kbn客室利用区分", null);
            _column客室コード = cci("客室コード", "客室コード", null, null, true, "客室コード", typeof(String), false, "bpchar", 6, 0, false, OptimisticLockType.NONE, null, "mst客室マスタ", null);
            _column開始予定日時 = cci("開始予定日時", "開始予定日時", null, null, true, "開始予定日時", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _column終了予定日時 = cci("終了予定日時", "終了予定日時", null, null, true, "終了予定日時", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _column開始実績日時 = cci("開始実績日時", "開始実績日時", null, null, false, "開始実績日時", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _column終了実績日時 = cci("終了実績日時", "終了実績日時", null, null, false, "終了実績日時", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _column備考 = cci("備考", "備考", null, null, false, "備考", typeof(String), false, "varchar", 255, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(Column客室利用コード);
            _columnInfoList.add(Column客室コード);
            _columnInfoList.add(Column開始予定日時);
            _columnInfoList.add(Column終了予定日時);
            _columnInfoList.add(Column開始実績日時);
            _columnInfoList.add(Column終了実績日時);
            _columnInfoList.add(Column備考);
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
        public ForeignInfo ForeignMst客室マスタ { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column客室コード, Mst客室マスタDbm.GetInstance().Column客室コード);
            return cfi("Mst客室マスタ", this, Mst客室マスタDbm.GetInstance(), map, 0, false, false);
        }}
        public ForeignInfo ForeignKbn客室利用区分 { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column客室利用コード, Kbn客室利用区分Dbm.GetInstance().Column客室利用コード);
            return cfi("Kbn客室利用区分", this, Kbn客室利用区分Dbm.GetInstance(), map, 1, false, false);
        }}

        public ForeignInfo ForeignDch宿泊利用台帳AsOne { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnId, Dch宿泊利用台帳Dbm.GetInstance().Column客室利用台帳id);
            return cfi("Dch宿泊利用台帳AsOne", this, Dch宿泊利用台帳Dbm.GetInstance(), map, 2, true, false);
        }}

        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasSequence { get { return true; } }
        public override String SequenceName { get { return "dch002_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('dch002_id_seq')"; } }
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
        public static readonly String TABLE_DB_NAME = "dch客室利用台帳";
        public static readonly String TABLE_PROPERTY_NAME = "Dch客室利用台帳";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_客室利用コード = "客室利用コード";
        public static readonly String DB_NAME_客室コード = "客室コード";
        public static readonly String DB_NAME_開始予定日時 = "開始予定日時";
        public static readonly String DB_NAME_終了予定日時 = "終了予定日時";
        public static readonly String DB_NAME_開始実績日時 = "開始実績日時";
        public static readonly String DB_NAME_終了実績日時 = "終了実績日時";
        public static readonly String DB_NAME_備考 = "備考";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_客室利用コード = "客室利用コード";
        public static readonly String PROPERTY_NAME_客室コード = "客室コード";
        public static readonly String PROPERTY_NAME_開始予定日時 = "開始予定日時";
        public static readonly String PROPERTY_NAME_終了予定日時 = "終了予定日時";
        public static readonly String PROPERTY_NAME_開始実績日時 = "開始実績日時";
        public static readonly String PROPERTY_NAME_終了実績日時 = "終了実績日時";
        public static readonly String PROPERTY_NAME_備考 = "備考";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_Mst客室マスタ = "Mst客室マスタ";
        public static readonly String FOREIGN_PROPERTY_NAME_Kbn客室利用区分 = "Kbn客室利用区分";
        public static readonly String FOREIGN_PROPERTY_NAME_Dch宿泊利用台帳AsOne = "$foreignKeys.foreignPropertyNameInitCap";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Dch客室利用台帳Dbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_客室利用コード.ToLower(), PROPERTY_NAME_客室利用コード);
                map.put(DB_NAME_客室コード.ToLower(), PROPERTY_NAME_客室コード);
                map.put(DB_NAME_開始予定日時.ToLower(), PROPERTY_NAME_開始予定日時);
                map.put(DB_NAME_終了予定日時.ToLower(), PROPERTY_NAME_終了予定日時);
                map.put(DB_NAME_開始実績日時.ToLower(), PROPERTY_NAME_開始実績日時);
                map.put(DB_NAME_終了実績日時.ToLower(), PROPERTY_NAME_終了実績日時);
                map.put(DB_NAME_備考.ToLower(), PROPERTY_NAME_備考);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_客室利用コード.ToLower(), DB_NAME_客室利用コード);
                map.put(PROPERTY_NAME_客室コード.ToLower(), DB_NAME_客室コード);
                map.put(PROPERTY_NAME_開始予定日時.ToLower(), DB_NAME_開始予定日時);
                map.put(PROPERTY_NAME_終了予定日時.ToLower(), DB_NAME_終了予定日時);
                map.put(PROPERTY_NAME_開始実績日時.ToLower(), DB_NAME_開始実績日時);
                map.put(PROPERTY_NAME_終了実績日時.ToLower(), DB_NAME_終了実績日時);
                map.put(PROPERTY_NAME_備考.ToLower(), DB_NAME_備考);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Dch客室利用台帳"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Dch客室利用台帳Dao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Dch客室利用台帳CB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Dch客室利用台帳Bhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Dch客室利用台帳 NewMyEntity() { return new Dch客室利用台帳(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Dch客室利用台帳CB NewMyConditionBean() { return new Dch客室利用台帳CB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Dch客室利用台帳>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Dch客室利用台帳>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("客室利用コード", "客室利用コード", new EntityProperty客室利用コードSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("客室コード", "客室コード", new EntityProperty客室コードSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("開始予定日時", "開始予定日時", new EntityProperty開始予定日時Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("終了予定日時", "終了予定日時", new EntityProperty終了予定日時Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("開始実績日時", "開始実績日時", new EntityProperty開始実績日時Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("終了実績日時", "終了実績日時", new EntityProperty終了実績日時Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("備考", "備考", new EntityProperty備考Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Dch客室利用台帳> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Dch客室利用台帳)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<Dch客室利用台帳> {
            public void Setup(Dch客室利用台帳 entity, Object value) { entity.Id = (value != null) ? (long?)value : null; }
        }
        public class EntityProperty客室利用コードSetupper : EntityPropertySetupper<Dch客室利用台帳> {
            public void Setup(Dch客室利用台帳 entity, Object value) { entity.客室利用コード = (value != null) ? (String)value : null; }
        }
        public class EntityProperty客室コードSetupper : EntityPropertySetupper<Dch客室利用台帳> {
            public void Setup(Dch客室利用台帳 entity, Object value) { entity.客室コード = (value != null) ? (String)value : null; }
        }
        public class EntityProperty開始予定日時Setupper : EntityPropertySetupper<Dch客室利用台帳> {
            public void Setup(Dch客室利用台帳 entity, Object value) { entity.開始予定日時 = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityProperty終了予定日時Setupper : EntityPropertySetupper<Dch客室利用台帳> {
            public void Setup(Dch客室利用台帳 entity, Object value) { entity.終了予定日時 = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityProperty開始実績日時Setupper : EntityPropertySetupper<Dch客室利用台帳> {
            public void Setup(Dch客室利用台帳 entity, Object value) { entity.開始実績日時 = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityProperty終了実績日時Setupper : EntityPropertySetupper<Dch客室利用台帳> {
            public void Setup(Dch客室利用台帳 entity, Object value) { entity.終了実績日時 = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityProperty備考Setupper : EntityPropertySetupper<Dch客室利用台帳> {
            public void Setup(Dch客室利用台帳 entity, Object value) { entity.備考 = (value != null) ? (String)value : null; }
        }
    }
}
