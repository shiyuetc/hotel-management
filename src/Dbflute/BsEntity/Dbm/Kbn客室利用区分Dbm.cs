
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

    public class Kbn客室利用区分Dbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Kbn客室利用区分);

        private static readonly Kbn客室利用区分Dbm _instance = new Kbn客室利用区分Dbm();
        private Kbn客室利用区分Dbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Kbn客室利用区分Dbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "kbn客室利用区分"; } }
        public override String TablePropertyName { get { return "Kbn客室利用区分"; } }
        public override String TableSqlName { get { return "kbn客室利用区分"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _column客室利用コード;
        protected ColumnInfo _column客室利用名称;

        public ColumnInfo Column客室利用コード { get { return _column客室利用コード; } }
        public ColumnInfo Column客室利用名称 { get { return _column客室利用名称; } }

        protected void InitializeColumnInfo() {
            _column客室利用コード = cci("客室利用コード", "客室利用コード", null, null, true, "客室利用コード", typeof(String), true, "bpchar", 2, 0, false, OptimisticLockType.NONE, null, null, "dch客室利用台帳List");
            _column客室利用名称 = cci("客室利用名称", "客室利用名称", null, null, true, "客室利用名称", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(Column客室利用コード);
            _columnInfoList.add(Column客室利用名称);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(Column客室利用コード);
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
        public ReferrerInfo ReferrerDch客室利用台帳List { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column客室利用コード, Dch客室利用台帳Dbm.GetInstance().Column客室利用コード);
            return cri("Dch客室利用台帳List", this, Dch客室利用台帳Dbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "kbn客室利用区分";
        public static readonly String TABLE_PROPERTY_NAME = "Kbn客室利用区分";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_客室利用コード = "客室利用コード";
        public static readonly String DB_NAME_客室利用名称 = "客室利用名称";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_客室利用コード = "客室利用コード";
        public static readonly String PROPERTY_NAME_客室利用名称 = "客室利用名称";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_Dch客室利用台帳List = "Dch客室利用台帳List";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Kbn客室利用区分Dbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_客室利用コード.ToLower(), PROPERTY_NAME_客室利用コード);
                map.put(DB_NAME_客室利用名称.ToLower(), PROPERTY_NAME_客室利用名称);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_客室利用コード.ToLower(), DB_NAME_客室利用コード);
                map.put(PROPERTY_NAME_客室利用名称.ToLower(), DB_NAME_客室利用名称);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Kbn客室利用区分"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Kbn客室利用区分Dao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Kbn客室利用区分CB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Kbn客室利用区分Bhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Kbn客室利用区分 NewMyEntity() { return new Kbn客室利用区分(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Kbn客室利用区分CB NewMyConditionBean() { return new Kbn客室利用区分CB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Kbn客室利用区分>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Kbn客室利用区分>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("客室利用コード", "客室利用コード", new EntityProperty客室利用コードSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("客室利用名称", "客室利用名称", new EntityProperty客室利用名称Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Kbn客室利用区分> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Kbn客室利用区分)entity, value);
        }

        public class EntityProperty客室利用コードSetupper : EntityPropertySetupper<Kbn客室利用区分> {
            public void Setup(Kbn客室利用区分 entity, Object value) { entity.客室利用コード = (value != null) ? (String)value : null; }
        }
        public class EntityProperty客室利用名称Setupper : EntityPropertySetupper<Kbn客室利用区分> {
            public void Setup(Kbn客室利用区分 entity, Object value) { entity.客室利用名称 = (value != null) ? (String)value : null; }
        }
    }
}
