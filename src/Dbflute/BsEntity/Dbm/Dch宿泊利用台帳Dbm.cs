
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

    public class Dch宿泊利用台帳Dbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Dch宿泊利用台帳);

        private static readonly Dch宿泊利用台帳Dbm _instance = new Dch宿泊利用台帳Dbm();
        private Dch宿泊利用台帳Dbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Dch宿泊利用台帳Dbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "dch宿泊利用台帳"; } }
        public override String TablePropertyName { get { return "Dch宿泊利用台帳"; } }
        public override String TableSqlName { get { return "dch宿泊利用台帳"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _column客室利用台帳id;
        protected ColumnInfo _column会員コード;
        protected ColumnInfo _column宿泊料金;

        public ColumnInfo Column客室利用台帳id { get { return _column客室利用台帳id; } }
        public ColumnInfo Column会員コード { get { return _column会員コード; } }
        public ColumnInfo Column宿泊料金 { get { return _column宿泊料金; } }

        protected void InitializeColumnInfo() {
            _column客室利用台帳id = cci("客室利用台帳id", "客室利用台帳id", null, null, true, "客室利用台帳id", typeof(long?), true, "int8", 19, 0, false, OptimisticLockType.NONE, null, "dch客室利用台帳", null);
            _column会員コード = cci("会員コード", "会員コード", null, null, true, "会員コード", typeof(String), false, "bpchar", 10, 0, false, OptimisticLockType.NONE, null, "mst会員マスタ", null);
            _column宿泊料金 = cci("宿泊料金", "宿泊料金", null, null, true, "宿泊料金", typeof(int?), false, "int4", 10, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(Column客室利用台帳id);
            _columnInfoList.add(Column会員コード);
            _columnInfoList.add(Column宿泊料金);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(Column客室利用台帳id);
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
        public ForeignInfo ForeignMst会員マスタ { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column会員コード, Mst会員マスタDbm.GetInstance().Column会員コード);
            return cfi("Mst会員マスタ", this, Mst会員マスタDbm.GetInstance(), map, 0, false, false);
        }}
        public ForeignInfo ForeignDch客室利用台帳 { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column客室利用台帳id, Dch客室利用台帳Dbm.GetInstance().ColumnId);
            return cfi("Dch客室利用台帳", this, Dch客室利用台帳Dbm.GetInstance(), map, 1, true, false);
        }}


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
        public static readonly String TABLE_DB_NAME = "dch宿泊利用台帳";
        public static readonly String TABLE_PROPERTY_NAME = "Dch宿泊利用台帳";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_客室利用台帳id = "客室利用台帳id";
        public static readonly String DB_NAME_会員コード = "会員コード";
        public static readonly String DB_NAME_宿泊料金 = "宿泊料金";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_客室利用台帳id = "客室利用台帳id";
        public static readonly String PROPERTY_NAME_会員コード = "会員コード";
        public static readonly String PROPERTY_NAME_宿泊料金 = "宿泊料金";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_Mst会員マスタ = "Mst会員マスタ";
        public static readonly String FOREIGN_PROPERTY_NAME_Dch客室利用台帳 = "Dch客室利用台帳";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Dch宿泊利用台帳Dbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_客室利用台帳id.ToLower(), PROPERTY_NAME_客室利用台帳id);
                map.put(DB_NAME_会員コード.ToLower(), PROPERTY_NAME_会員コード);
                map.put(DB_NAME_宿泊料金.ToLower(), PROPERTY_NAME_宿泊料金);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_客室利用台帳id.ToLower(), DB_NAME_客室利用台帳id);
                map.put(PROPERTY_NAME_会員コード.ToLower(), DB_NAME_会員コード);
                map.put(PROPERTY_NAME_宿泊料金.ToLower(), DB_NAME_宿泊料金);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Dch宿泊利用台帳"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Dch宿泊利用台帳Dao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Dch宿泊利用台帳CB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Dch宿泊利用台帳Bhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Dch宿泊利用台帳 NewMyEntity() { return new Dch宿泊利用台帳(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Dch宿泊利用台帳CB NewMyConditionBean() { return new Dch宿泊利用台帳CB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Dch宿泊利用台帳>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Dch宿泊利用台帳>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("客室利用台帳id", "客室利用台帳id", new EntityProperty客室利用台帳idSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("会員コード", "会員コード", new EntityProperty会員コードSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("宿泊料金", "宿泊料金", new EntityProperty宿泊料金Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Dch宿泊利用台帳> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Dch宿泊利用台帳)entity, value);
        }

        public class EntityProperty客室利用台帳idSetupper : EntityPropertySetupper<Dch宿泊利用台帳> {
            public void Setup(Dch宿泊利用台帳 entity, Object value) { entity.客室利用台帳id = (value != null) ? (long?)value : null; }
        }
        public class EntityProperty会員コードSetupper : EntityPropertySetupper<Dch宿泊利用台帳> {
            public void Setup(Dch宿泊利用台帳 entity, Object value) { entity.会員コード = (value != null) ? (String)value : null; }
        }
        public class EntityProperty宿泊料金Setupper : EntityPropertySetupper<Dch宿泊利用台帳> {
            public void Setup(Dch宿泊利用台帳 entity, Object value) { entity.宿泊料金 = (value != null) ? (int?)value : null; }
        }
    }
}
