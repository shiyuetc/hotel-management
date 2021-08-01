
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

    public class Mst画面マスタDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Mst画面マスタ);

        private static readonly Mst画面マスタDbm _instance = new Mst画面マスタDbm();
        private Mst画面マスタDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Mst画面マスタDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "mst画面マスタ"; } }
        public override String TablePropertyName { get { return "Mst画面マスタ"; } }
        public override String TableSqlName { get { return "mst画面マスタ"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _column画面コード;
        protected ColumnInfo _columnメニューコード;
        protected ColumnInfo _column画面名称;
        protected ColumnInfo _column優先順位;

        public ColumnInfo Column画面コード { get { return _column画面コード; } }
        public ColumnInfo Columnメニューコード { get { return _columnメニューコード; } }
        public ColumnInfo Column画面名称 { get { return _column画面名称; } }
        public ColumnInfo Column優先順位 { get { return _column優先順位; } }

        protected void InitializeColumnInfo() {
            _column画面コード = cci("画面コード", "画面コード", null, null, true, "画面コード", typeof(String), true, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, null, "mst権限マスタList");
            _columnメニューコード = cci("メニューコード", "メニューコード", null, null, true, "メニューコード", typeof(String), false, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, "kbnメニュー区分", null);
            _column画面名称 = cci("画面名称", "画面名称", null, null, true, "画面名称", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _column優先順位 = cci("優先順位", "優先順位", null, null, true, "優先順位", typeof(int?), false, "int4", 10, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(Column画面コード);
            _columnInfoList.add(Columnメニューコード);
            _columnInfoList.add(Column画面名称);
            _columnInfoList.add(Column優先順位);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(Column画面コード);
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
        public ForeignInfo ForeignKbnメニュー区分 { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Columnメニューコード, Kbnメニュー区分Dbm.GetInstance().Columnメニューコード);
            return cfi("Kbnメニュー区分", this, Kbnメニュー区分Dbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public ReferrerInfo ReferrerMst権限マスタList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column画面コード, Mst権限マスタDbm.GetInstance().Column画面コード);
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
        public static readonly String TABLE_DB_NAME = "mst画面マスタ";
        public static readonly String TABLE_PROPERTY_NAME = "Mst画面マスタ";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_画面コード = "画面コード";
        public static readonly String DB_NAME_メニューコード = "メニューコード";
        public static readonly String DB_NAME_画面名称 = "画面名称";
        public static readonly String DB_NAME_優先順位 = "優先順位";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_画面コード = "画面コード";
        public static readonly String PROPERTY_NAME_メニューコード = "メニューコード";
        public static readonly String PROPERTY_NAME_画面名称 = "画面名称";
        public static readonly String PROPERTY_NAME_優先順位 = "優先順位";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_Kbnメニュー区分 = "Kbnメニュー区分";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_Mst権限マスタList = "Mst権限マスタList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Mst画面マスタDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_画面コード.ToLower(), PROPERTY_NAME_画面コード);
                map.put(DB_NAME_メニューコード.ToLower(), PROPERTY_NAME_メニューコード);
                map.put(DB_NAME_画面名称.ToLower(), PROPERTY_NAME_画面名称);
                map.put(DB_NAME_優先順位.ToLower(), PROPERTY_NAME_優先順位);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_画面コード.ToLower(), DB_NAME_画面コード);
                map.put(PROPERTY_NAME_メニューコード.ToLower(), DB_NAME_メニューコード);
                map.put(PROPERTY_NAME_画面名称.ToLower(), DB_NAME_画面名称);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Mst画面マスタ"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Mst画面マスタDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Mst画面マスタCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Mst画面マスタBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Mst画面マスタ NewMyEntity() { return new Mst画面マスタ(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Mst画面マスタCB NewMyConditionBean() { return new Mst画面マスタCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Mst画面マスタ>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Mst画面マスタ>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("画面コード", "画面コード", new EntityProperty画面コードSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("メニューコード", "メニューコード", new EntityPropertyメニューコードSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("画面名称", "画面名称", new EntityProperty画面名称Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("優先順位", "優先順位", new EntityProperty優先順位Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Mst画面マスタ> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Mst画面マスタ)entity, value);
        }

        public class EntityProperty画面コードSetupper : EntityPropertySetupper<Mst画面マスタ> {
            public void Setup(Mst画面マスタ entity, Object value) { entity.画面コード = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyメニューコードSetupper : EntityPropertySetupper<Mst画面マスタ> {
            public void Setup(Mst画面マスタ entity, Object value) { entity.メニューコード = (value != null) ? (String)value : null; }
        }
        public class EntityProperty画面名称Setupper : EntityPropertySetupper<Mst画面マスタ> {
            public void Setup(Mst画面マスタ entity, Object value) { entity.画面名称 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty優先順位Setupper : EntityPropertySetupper<Mst画面マスタ> {
            public void Setup(Mst画面マスタ entity, Object value) { entity.優先順位 = (value != null) ? (int?)value : null; }
        }
    }
}
