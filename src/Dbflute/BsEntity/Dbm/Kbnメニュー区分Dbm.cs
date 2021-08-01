
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

    public class Kbnメニュー区分Dbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Kbnメニュー区分);

        private static readonly Kbnメニュー区分Dbm _instance = new Kbnメニュー区分Dbm();
        private Kbnメニュー区分Dbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Kbnメニュー区分Dbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "kbnメニュー区分"; } }
        public override String TablePropertyName { get { return "Kbnメニュー区分"; } }
        public override String TableSqlName { get { return "kbnメニュー区分"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnメニューコード;
        protected ColumnInfo _columnメニュー名称;
        protected ColumnInfo _column優先順位;

        public ColumnInfo Columnメニューコード { get { return _columnメニューコード; } }
        public ColumnInfo Columnメニュー名称 { get { return _columnメニュー名称; } }
        public ColumnInfo Column優先順位 { get { return _column優先順位; } }

        protected void InitializeColumnInfo() {
            _columnメニューコード = cci("メニューコード", "メニューコード", null, null, true, "メニューコード", typeof(String), true, "bpchar", 2, 0, false, OptimisticLockType.NONE, null, null, "mst画面マスタList");
            _columnメニュー名称 = cci("メニュー名称", "メニュー名称", null, null, true, "メニュー名称", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _column優先順位 = cci("優先順位", "優先順位", null, null, true, "優先順位", typeof(int?), false, "int4", 10, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(Columnメニューコード);
            _columnInfoList.add(Columnメニュー名称);
            _columnInfoList.add(Column優先順位);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(Columnメニューコード);
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
        public ReferrerInfo ReferrerMst画面マスタList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Columnメニューコード, Mst画面マスタDbm.GetInstance().Columnメニューコード);
            return cri("Mst画面マスタList", this, Mst画面マスタDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "kbnメニュー区分";
        public static readonly String TABLE_PROPERTY_NAME = "Kbnメニュー区分";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_メニューコード = "メニューコード";
        public static readonly String DB_NAME_メニュー名称 = "メニュー名称";
        public static readonly String DB_NAME_優先順位 = "優先順位";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_メニューコード = "メニューコード";
        public static readonly String PROPERTY_NAME_メニュー名称 = "メニュー名称";
        public static readonly String PROPERTY_NAME_優先順位 = "優先順位";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_Mst画面マスタList = "Mst画面マスタList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Kbnメニュー区分Dbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_メニューコード.ToLower(), PROPERTY_NAME_メニューコード);
                map.put(DB_NAME_メニュー名称.ToLower(), PROPERTY_NAME_メニュー名称);
                map.put(DB_NAME_優先順位.ToLower(), PROPERTY_NAME_優先順位);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_メニューコード.ToLower(), DB_NAME_メニューコード);
                map.put(PROPERTY_NAME_メニュー名称.ToLower(), DB_NAME_メニュー名称);
                map.put(PROPERTY_NAME_優先順位.ToLower(), DB_NAME_優先順位);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Kbnメニュー区分"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Kbnメニュー区分Dao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Kbnメニュー区分CB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Kbnメニュー区分Bhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Kbnメニュー区分 NewMyEntity() { return new Kbnメニュー区分(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Kbnメニュー区分CB NewMyConditionBean() { return new Kbnメニュー区分CB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Kbnメニュー区分>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Kbnメニュー区分>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("メニューコード", "メニューコード", new EntityPropertyメニューコードSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("メニュー名称", "メニュー名称", new EntityPropertyメニュー名称Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("優先順位", "優先順位", new EntityProperty優先順位Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Kbnメニュー区分> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Kbnメニュー区分)entity, value);
        }

        public class EntityPropertyメニューコードSetupper : EntityPropertySetupper<Kbnメニュー区分> {
            public void Setup(Kbnメニュー区分 entity, Object value) { entity.メニューコード = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyメニュー名称Setupper : EntityPropertySetupper<Kbnメニュー区分> {
            public void Setup(Kbnメニュー区分 entity, Object value) { entity.メニュー名称 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty優先順位Setupper : EntityPropertySetupper<Kbnメニュー区分> {
            public void Setup(Kbnメニュー区分 entity, Object value) { entity.優先順位 = (value != null) ? (int?)value : null; }
        }
    }
}
