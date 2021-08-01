
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

    public class Kbn職位区分Dbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Kbn職位区分);

        private static readonly Kbn職位区分Dbm _instance = new Kbn職位区分Dbm();
        private Kbn職位区分Dbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Kbn職位区分Dbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "kbn職位区分"; } }
        public override String TablePropertyName { get { return "Kbn職位区分"; } }
        public override String TableSqlName { get { return "kbn職位区分"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _column職位コード;
        protected ColumnInfo _column職位名称;
        protected ColumnInfo _column職位英字名称;

        public ColumnInfo Column職位コード { get { return _column職位コード; } }
        public ColumnInfo Column職位名称 { get { return _column職位名称; } }
        public ColumnInfo Column職位英字名称 { get { return _column職位英字名称; } }

        protected void InitializeColumnInfo() {
            _column職位コード = cci("職位コード", "職位コード", null, null, true, "職位コード", typeof(String), true, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, null, "dch従業員職位履歴台帳List,mst従業員マスタList,mst権限マスタList");
            _column職位名称 = cci("職位名称", "職位名称", null, null, true, "職位名称", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _column職位英字名称 = cci("職位英字名称", "職位英字名称", null, null, true, "職位英字名称", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(Column職位コード);
            _columnInfoList.add(Column職位名称);
            _columnInfoList.add(Column職位英字名称);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(Column職位コード);
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
        public ReferrerInfo ReferrerDch従業員職位履歴台帳List { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column職位コード, Dch従業員職位履歴台帳Dbm.GetInstance().Column職位コード);
            return cri("Dch従業員職位履歴台帳List", this, Dch従業員職位履歴台帳Dbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerMst従業員マスタList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column職位コード, Mst従業員マスタDbm.GetInstance().Column職位コード);
            return cri("Mst従業員マスタList", this, Mst従業員マスタDbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerMst権限マスタList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column職位コード, Mst権限マスタDbm.GetInstance().Column職位コード);
            return cri("Mst権限マスタList", this, Mst権限マスタDbm.GetInstance(), map, false);
        }}

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
        public static readonly String TABLE_DB_NAME = "kbn職位区分";
        public static readonly String TABLE_PROPERTY_NAME = "Kbn職位区分";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_職位コード = "職位コード";
        public static readonly String DB_NAME_職位名称 = "職位名称";
        public static readonly String DB_NAME_職位英字名称 = "職位英字名称";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_職位コード = "職位コード";
        public static readonly String PROPERTY_NAME_職位名称 = "職位名称";
        public static readonly String PROPERTY_NAME_職位英字名称 = "職位英字名称";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_Dch従業員職位履歴台帳List = "Dch従業員職位履歴台帳List";
        public static readonly String REFERRER_PROPERTY_NAME_Mst従業員マスタList = "Mst従業員マスタList";
        public static readonly String REFERRER_PROPERTY_NAME_Mst権限マスタList = "Mst権限マスタList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Kbn職位区分Dbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_職位コード.ToLower(), PROPERTY_NAME_職位コード);
                map.put(DB_NAME_職位名称.ToLower(), PROPERTY_NAME_職位名称);
                map.put(DB_NAME_職位英字名称.ToLower(), PROPERTY_NAME_職位英字名称);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_職位コード.ToLower(), DB_NAME_職位コード);
                map.put(PROPERTY_NAME_職位名称.ToLower(), DB_NAME_職位名称);
                map.put(PROPERTY_NAME_職位英字名称.ToLower(), DB_NAME_職位英字名称);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Kbn職位区分"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Kbn職位区分Dao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Kbn職位区分CB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Kbn職位区分Bhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Kbn職位区分 NewMyEntity() { return new Kbn職位区分(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Kbn職位区分CB NewMyConditionBean() { return new Kbn職位区分CB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Kbn職位区分>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Kbn職位区分>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("職位コード", "職位コード", new EntityProperty職位コードSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("職位名称", "職位名称", new EntityProperty職位名称Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("職位英字名称", "職位英字名称", new EntityProperty職位英字名称Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Kbn職位区分> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Kbn職位区分)entity, value);
        }

        public class EntityProperty職位コードSetupper : EntityPropertySetupper<Kbn職位区分> {
            public void Setup(Kbn職位区分 entity, Object value) { entity.職位コード = (value != null) ? (String)value : null; }
        }
        public class EntityProperty職位名称Setupper : EntityPropertySetupper<Kbn職位区分> {
            public void Setup(Kbn職位区分 entity, Object value) { entity.職位名称 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty職位英字名称Setupper : EntityPropertySetupper<Kbn職位区分> {
            public void Setup(Kbn職位区分 entity, Object value) { entity.職位英字名称 = (value != null) ? (String)value : null; }
        }
    }
}
