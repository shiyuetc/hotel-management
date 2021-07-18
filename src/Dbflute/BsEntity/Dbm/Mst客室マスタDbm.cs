
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

    public class Mst客室マスタDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Mst客室マスタ);

        private static readonly Mst客室マスタDbm _instance = new Mst客室マスタDbm();
        private Mst客室マスタDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Mst客室マスタDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "mst客室マスタ"; } }
        public override String TablePropertyName { get { return "Mst客室マスタ"; } }
        public override String TableSqlName { get { return "mst客室マスタ"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _column客室番号;
        protected ColumnInfo _column客室タイプid;
        protected ColumnInfo _column喫煙;
        protected ColumnInfo _column備考;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo Column客室番号 { get { return _column客室番号; } }
        public ColumnInfo Column客室タイプid { get { return _column客室タイプid; } }
        public ColumnInfo Column喫煙 { get { return _column喫煙; } }
        public ColumnInfo Column備考 { get { return _column備考; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(long?), true, "bigserial", 19, 0, false, OptimisticLockType.NONE, null, null, "dch客室利用予定台帳List,dch客室利用実績台帳List");
            _column客室番号 = cci("客室番号", "客室番号", null, null, true, "客室番号", typeof(String), false, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, null, null);
            _column客室タイプid = cci("客室タイプid", "客室タイプid", null, null, true, "客室タイプid", typeof(long?), false, "int8", 19, 0, false, OptimisticLockType.NONE, null, "mst客室タイプマスタ", null);
            _column喫煙 = cci("喫煙", "喫煙", null, null, true, "喫煙", typeof(bool?), false, "bool", 1, 0, false, OptimisticLockType.NONE, null, null, null);
            _column備考 = cci("備考", "備考", null, null, false, "備考", typeof(String), false, "varchar", 255, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(Column客室番号);
            _columnInfoList.add(Column客室タイプid);
            _columnInfoList.add(Column喫煙);
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
        public ForeignInfo ForeignMst客室タイプマスタ { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column客室タイプid, Mst客室タイプマスタDbm.GetInstance().ColumnId);
            return cfi("Mst客室タイプマスタ", this, Mst客室タイプマスタDbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public ReferrerInfo ReferrerDch客室利用予定台帳List { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnId, Dch客室利用予定台帳Dbm.GetInstance().Column客室マスタid);
            return cri("Dch客室利用予定台帳List", this, Dch客室利用予定台帳Dbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerDch客室利用実績台帳List { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnId, Dch客室利用実績台帳Dbm.GetInstance().Column客室マスタid);
            return cri("Dch客室利用実績台帳List", this, Dch客室利用実績台帳Dbm.GetInstance(), map, false);
        }}

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasSequence { get { return true; } }
        public override String SequenceName { get { return "mst005_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('mst005_id_seq')"; } }
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
        public static readonly String TABLE_DB_NAME = "mst客室マスタ";
        public static readonly String TABLE_PROPERTY_NAME = "Mst客室マスタ";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_客室番号 = "客室番号";
        public static readonly String DB_NAME_客室タイプid = "客室タイプid";
        public static readonly String DB_NAME_喫煙 = "喫煙";
        public static readonly String DB_NAME_備考 = "備考";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_客室番号 = "客室番号";
        public static readonly String PROPERTY_NAME_客室タイプid = "客室タイプid";
        public static readonly String PROPERTY_NAME_喫煙 = "喫煙";
        public static readonly String PROPERTY_NAME_備考 = "備考";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_Mst客室タイプマスタ = "Mst客室タイプマスタ";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_Dch客室利用予定台帳List = "Dch客室利用予定台帳List";
        public static readonly String REFERRER_PROPERTY_NAME_Dch客室利用実績台帳List = "Dch客室利用実績台帳List";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Mst客室マスタDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_客室番号.ToLower(), PROPERTY_NAME_客室番号);
                map.put(DB_NAME_客室タイプid.ToLower(), PROPERTY_NAME_客室タイプid);
                map.put(DB_NAME_喫煙.ToLower(), PROPERTY_NAME_喫煙);
                map.put(DB_NAME_備考.ToLower(), PROPERTY_NAME_備考);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_客室番号.ToLower(), DB_NAME_客室番号);
                map.put(PROPERTY_NAME_客室タイプid.ToLower(), DB_NAME_客室タイプid);
                map.put(PROPERTY_NAME_喫煙.ToLower(), DB_NAME_喫煙);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Mst客室マスタ"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Mst客室マスタDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Mst客室マスタCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Mst客室マスタBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Mst客室マスタ NewMyEntity() { return new Mst客室マスタ(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Mst客室マスタCB NewMyConditionBean() { return new Mst客室マスタCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Mst客室マスタ>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Mst客室マスタ>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("客室番号", "客室番号", new EntityProperty客室番号Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("客室タイプid", "客室タイプid", new EntityProperty客室タイプidSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("喫煙", "喫煙", new EntityProperty喫煙Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("備考", "備考", new EntityProperty備考Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Mst客室マスタ> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Mst客室マスタ)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<Mst客室マスタ> {
            public void Setup(Mst客室マスタ entity, Object value) { entity.Id = (value != null) ? (long?)value : null; }
        }
        public class EntityProperty客室番号Setupper : EntityPropertySetupper<Mst客室マスタ> {
            public void Setup(Mst客室マスタ entity, Object value) { entity.客室番号 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty客室タイプidSetupper : EntityPropertySetupper<Mst客室マスタ> {
            public void Setup(Mst客室マスタ entity, Object value) { entity.客室タイプid = (value != null) ? (long?)value : null; }
        }
        public class EntityProperty喫煙Setupper : EntityPropertySetupper<Mst客室マスタ> {
            public void Setup(Mst客室マスタ entity, Object value) { entity.喫煙 = (value != null) ? (bool?)value : null; }
        }
        public class EntityProperty備考Setupper : EntityPropertySetupper<Mst客室マスタ> {
            public void Setup(Mst客室マスタ entity, Object value) { entity.備考 = (value != null) ? (String)value : null; }
        }
    }
}
