
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

    public class Dch清掃予定台帳Dbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Dch清掃予定台帳);

        private static readonly Dch清掃予定台帳Dbm _instance = new Dch清掃予定台帳Dbm();
        private Dch清掃予定台帳Dbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Dch清掃予定台帳Dbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "dch清掃予定台帳"; } }
        public override String TablePropertyName { get { return "Dch清掃予定台帳"; } }
        public override String TableSqlName { get { return "dch清掃予定台帳"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _column客室利用予定台帳id;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo Column客室利用予定台帳id { get { return _column客室利用予定台帳id; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(long?), true, "bigserial", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _column客室利用予定台帳id = cci("客室利用予定台帳id", "客室利用予定台帳id", null, null, true, "客室利用予定台帳id", typeof(long?), false, "int8", 19, 0, false, OptimisticLockType.NONE, null, "dch客室利用予定台帳", null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(Column客室利用予定台帳id);
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
        public ForeignInfo ForeignDch客室利用予定台帳 { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column客室利用予定台帳id, Dch客室利用予定台帳Dbm.GetInstance().ColumnId);
            return cfi("Dch客室利用予定台帳", this, Dch客室利用予定台帳Dbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasSequence { get { return true; } }
        public override String SequenceName { get { return "dch007_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('dch007_id_seq')"; } }
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
        public static readonly String TABLE_DB_NAME = "dch清掃予定台帳";
        public static readonly String TABLE_PROPERTY_NAME = "Dch清掃予定台帳";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_客室利用予定台帳id = "客室利用予定台帳id";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_客室利用予定台帳id = "客室利用予定台帳id";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_Dch客室利用予定台帳 = "Dch客室利用予定台帳";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Dch清掃予定台帳Dbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_客室利用予定台帳id.ToLower(), PROPERTY_NAME_客室利用予定台帳id);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_客室利用予定台帳id.ToLower(), DB_NAME_客室利用予定台帳id);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Dch清掃予定台帳"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Dch清掃予定台帳Dao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Dch清掃予定台帳CB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Dch清掃予定台帳Bhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Dch清掃予定台帳 NewMyEntity() { return new Dch清掃予定台帳(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Dch清掃予定台帳CB NewMyConditionBean() { return new Dch清掃予定台帳CB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Dch清掃予定台帳>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Dch清掃予定台帳>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("客室利用予定台帳id", "客室利用予定台帳id", new EntityProperty客室利用予定台帳idSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Dch清掃予定台帳> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Dch清掃予定台帳)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<Dch清掃予定台帳> {
            public void Setup(Dch清掃予定台帳 entity, Object value) { entity.Id = (value != null) ? (long?)value : null; }
        }
        public class EntityProperty客室利用予定台帳idSetupper : EntityPropertySetupper<Dch清掃予定台帳> {
            public void Setup(Dch清掃予定台帳 entity, Object value) { entity.客室利用予定台帳id = (value != null) ? (long?)value : null; }
        }
    }
}
