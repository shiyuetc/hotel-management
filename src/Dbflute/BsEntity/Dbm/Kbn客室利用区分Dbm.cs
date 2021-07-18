
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
        protected ColumnInfo _columnコード;
        protected ColumnInfo _column名称;

        public ColumnInfo Columnコード { get { return _columnコード; } }
        public ColumnInfo Column名称 { get { return _column名称; } }

        protected void InitializeColumnInfo() {
            _columnコード = cci("コード", "コード", null, null, true, "コード", typeof(String), true, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, null, "dch客室利用予定台帳List,dch客室利用実績台帳List");
            _column名称 = cci("名称", "名称", null, null, true, "名称", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(Columnコード);
            _columnInfoList.add(Column名称);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(Columnコード);
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
        public ReferrerInfo ReferrerDch客室利用予定台帳List { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Columnコード, Dch客室利用予定台帳Dbm.GetInstance().Column客室利用コード);
            return cri("Dch客室利用予定台帳List", this, Dch客室利用予定台帳Dbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerDch客室利用実績台帳List { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Columnコード, Dch客室利用実績台帳Dbm.GetInstance().Column客室利用コード);
            return cri("Dch客室利用実績台帳List", this, Dch客室利用実績台帳Dbm.GetInstance(), map, false);
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
        public static readonly String DB_NAME_コード = "コード";
        public static readonly String DB_NAME_名称 = "名称";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_コード = "コード";
        public static readonly String PROPERTY_NAME_名称 = "名称";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
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

        static Kbn客室利用区分Dbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_コード.ToLower(), PROPERTY_NAME_コード);
                map.put(DB_NAME_名称.ToLower(), PROPERTY_NAME_名称);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_コード.ToLower(), DB_NAME_コード);
                map.put(PROPERTY_NAME_名称.ToLower(), DB_NAME_名称);
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
            RegisterEntityPropertySetupper("コード", "コード", new EntityPropertyコードSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("名称", "名称", new EntityProperty名称Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Kbn客室利用区分> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Kbn客室利用区分)entity, value);
        }

        public class EntityPropertyコードSetupper : EntityPropertySetupper<Kbn客室利用区分> {
            public void Setup(Kbn客室利用区分 entity, Object value) { entity.コード = (value != null) ? (String)value : null; }
        }
        public class EntityProperty名称Setupper : EntityPropertySetupper<Kbn客室利用区分> {
            public void Setup(Kbn客室利用区分 entity, Object value) { entity.名称 = (value != null) ? (String)value : null; }
        }
    }
}
