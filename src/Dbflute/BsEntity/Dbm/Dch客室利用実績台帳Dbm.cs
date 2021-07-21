
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

    public class Dch客室利用実績台帳Dbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Dch客室利用実績台帳);

        private static readonly Dch客室利用実績台帳Dbm _instance = new Dch客室利用実績台帳Dbm();
        private Dch客室利用実績台帳Dbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Dch客室利用実績台帳Dbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "dch客室利用実績台帳"; } }
        public override String TablePropertyName { get { return "Dch客室利用実績台帳"; } }
        public override String TableSqlName { get { return "dch客室利用実績台帳"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _column客室マスタid;
        protected ColumnInfo _column客室利用code;
        protected ColumnInfo _column利用開始日時;
        protected ColumnInfo _column利用終了日時;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo Column客室マスタid { get { return _column客室マスタid; } }
        public ColumnInfo Column客室利用code { get { return _column客室利用code; } }
        public ColumnInfo Column利用開始日時 { get { return _column利用開始日時; } }
        public ColumnInfo Column利用終了日時 { get { return _column利用終了日時; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(long?), true, "bigserial", 19, 0, false, OptimisticLockType.NONE, null, null, "dchその他実績台帳List,dch宿泊実績台帳List,dch清掃実績台帳List");
            _column客室マスタid = cci("客室マスタid", "客室マスタid", null, null, true, "客室マスタid", typeof(long?), false, "int8", 19, 0, false, OptimisticLockType.NONE, null, "mst客室マスタ", null);
            _column客室利用code = cci("客室利用code", "客室利用code", null, null, true, "客室利用code", typeof(String), false, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, "kbn客室利用区分", null);
            _column利用開始日時 = cci("利用開始日時", "利用開始日時", null, null, true, "利用開始日時", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _column利用終了日時 = cci("利用終了日時", "利用終了日時", null, null, true, "利用終了日時", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(Column客室マスタid);
            _columnInfoList.add(Column客室利用code);
            _columnInfoList.add(Column利用開始日時);
            _columnInfoList.add(Column利用終了日時);
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
            map.put(Column客室マスタid, Mst客室マスタDbm.GetInstance().ColumnId);
            return cfi("Mst客室マスタ", this, Mst客室マスタDbm.GetInstance(), map, 0, false, false);
        }}
        public ForeignInfo ForeignKbn客室利用区分 { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column客室利用code, Kbn客室利用区分Dbm.GetInstance().ColumnCode);
            return cfi("Kbn客室利用区分", this, Kbn客室利用区分Dbm.GetInstance(), map, 1, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public ReferrerInfo ReferrerDchその他実績台帳List { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnId, Dchその他実績台帳Dbm.GetInstance().Column客室利用実績台帳id);
            return cri("Dchその他実績台帳List", this, Dchその他実績台帳Dbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerDch宿泊実績台帳List { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnId, Dch宿泊実績台帳Dbm.GetInstance().Column客室利用実績台帳id);
            return cri("Dch宿泊実績台帳List", this, Dch宿泊実績台帳Dbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerDch清掃実績台帳List { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnId, Dch清掃実績台帳Dbm.GetInstance().Column客室利用実績台帳id);
            return cri("Dch清掃実績台帳List", this, Dch清掃実績台帳Dbm.GetInstance(), map, false);
        }}

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasSequence { get { return true; } }
        public override String SequenceName { get { return "dch004_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('dch004_id_seq')"; } }
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
        public static readonly String TABLE_DB_NAME = "dch客室利用実績台帳";
        public static readonly String TABLE_PROPERTY_NAME = "Dch客室利用実績台帳";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_客室マスタid = "客室マスタid";
        public static readonly String DB_NAME_客室利用code = "客室利用code";
        public static readonly String DB_NAME_利用開始日時 = "利用開始日時";
        public static readonly String DB_NAME_利用終了日時 = "利用終了日時";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_客室マスタid = "客室マスタid";
        public static readonly String PROPERTY_NAME_客室利用code = "客室利用code";
        public static readonly String PROPERTY_NAME_利用開始日時 = "利用開始日時";
        public static readonly String PROPERTY_NAME_利用終了日時 = "利用終了日時";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_Mst客室マスタ = "Mst客室マスタ";
        public static readonly String FOREIGN_PROPERTY_NAME_Kbn客室利用区分 = "Kbn客室利用区分";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_Dchその他実績台帳List = "Dchその他実績台帳List";
        public static readonly String REFERRER_PROPERTY_NAME_Dch宿泊実績台帳List = "Dch宿泊実績台帳List";
        public static readonly String REFERRER_PROPERTY_NAME_Dch清掃実績台帳List = "Dch清掃実績台帳List";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Dch客室利用実績台帳Dbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_客室マスタid.ToLower(), PROPERTY_NAME_客室マスタid);
                map.put(DB_NAME_客室利用code.ToLower(), PROPERTY_NAME_客室利用code);
                map.put(DB_NAME_利用開始日時.ToLower(), PROPERTY_NAME_利用開始日時);
                map.put(DB_NAME_利用終了日時.ToLower(), PROPERTY_NAME_利用終了日時);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_客室マスタid.ToLower(), DB_NAME_客室マスタid);
                map.put(PROPERTY_NAME_客室利用code.ToLower(), DB_NAME_客室利用code);
                map.put(PROPERTY_NAME_利用開始日時.ToLower(), DB_NAME_利用開始日時);
                map.put(PROPERTY_NAME_利用終了日時.ToLower(), DB_NAME_利用終了日時);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Dch客室利用実績台帳"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Dch客室利用実績台帳Dao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Dch客室利用実績台帳CB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Dch客室利用実績台帳Bhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Dch客室利用実績台帳 NewMyEntity() { return new Dch客室利用実績台帳(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Dch客室利用実績台帳CB NewMyConditionBean() { return new Dch客室利用実績台帳CB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Dch客室利用実績台帳>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Dch客室利用実績台帳>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("客室マスタid", "客室マスタid", new EntityProperty客室マスタidSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("客室利用code", "客室利用code", new EntityProperty客室利用codeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("利用開始日時", "利用開始日時", new EntityProperty利用開始日時Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("利用終了日時", "利用終了日時", new EntityProperty利用終了日時Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Dch客室利用実績台帳> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Dch客室利用実績台帳)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<Dch客室利用実績台帳> {
            public void Setup(Dch客室利用実績台帳 entity, Object value) { entity.Id = (value != null) ? (long?)value : null; }
        }
        public class EntityProperty客室マスタidSetupper : EntityPropertySetupper<Dch客室利用実績台帳> {
            public void Setup(Dch客室利用実績台帳 entity, Object value) { entity.客室マスタid = (value != null) ? (long?)value : null; }
        }
        public class EntityProperty客室利用codeSetupper : EntityPropertySetupper<Dch客室利用実績台帳> {
            public void Setup(Dch客室利用実績台帳 entity, Object value) { entity.客室利用code = (value != null) ? (String)value : null; }
        }
        public class EntityProperty利用開始日時Setupper : EntityPropertySetupper<Dch客室利用実績台帳> {
            public void Setup(Dch客室利用実績台帳 entity, Object value) { entity.利用開始日時 = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityProperty利用終了日時Setupper : EntityPropertySetupper<Dch客室利用実績台帳> {
            public void Setup(Dch客室利用実績台帳 entity, Object value) { entity.利用終了日時 = (value != null) ? (DateTime?)value : null; }
        }
    }
}
