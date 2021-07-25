
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
        protected ColumnInfo _columnCode;
        protected ColumnInfo _columnメニュー名;
        protected ColumnInfo _column優先順位;

        public ColumnInfo ColumnCode { get { return _columnCode; } }
        public ColumnInfo Columnメニュー名 { get { return _columnメニュー名; } }
        public ColumnInfo Column優先順位 { get { return _column優先順位; } }

        protected void InitializeColumnInfo() {
            _columnCode = cci("code", "code", null, null, true, "Code", typeof(String), true, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, null, "mst制御画面マスタList");
            _columnメニュー名 = cci("メニュー名", "メニュー名", null, null, true, "メニュー名", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _column優先順位 = cci("優先順位", "優先順位", null, null, true, "優先順位", typeof(int?), false, "int4", 10, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnCode);
            _columnInfoList.add(Columnメニュー名);
            _columnInfoList.add(Column優先順位);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnCode);
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
        public ReferrerInfo ReferrerMst制御画面マスタList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnCode, Mst制御画面マスタDbm.GetInstance().Columnメニューcode);
            return cri("Mst制御画面マスタList", this, Mst制御画面マスタDbm.GetInstance(), map, false);
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
        public static readonly String DB_NAME_code = "code";
        public static readonly String DB_NAME_メニュー名 = "メニュー名";
        public static readonly String DB_NAME_優先順位 = "優先順位";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_code = "Code";
        public static readonly String PROPERTY_NAME_メニュー名 = "メニュー名";
        public static readonly String PROPERTY_NAME_優先順位 = "優先順位";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_Mst制御画面マスタList = "Mst制御画面マスタList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Kbnメニュー区分Dbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_code.ToLower(), PROPERTY_NAME_code);
                map.put(DB_NAME_メニュー名.ToLower(), PROPERTY_NAME_メニュー名);
                map.put(DB_NAME_優先順位.ToLower(), PROPERTY_NAME_優先順位);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_code.ToLower(), DB_NAME_code);
                map.put(PROPERTY_NAME_メニュー名.ToLower(), DB_NAME_メニュー名);
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
            RegisterEntityPropertySetupper("code", "Code", new EntityPropertyCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("メニュー名", "メニュー名", new EntityPropertyメニュー名Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("優先順位", "優先順位", new EntityProperty優先順位Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Kbnメニュー区分> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Kbnメニュー区分)entity, value);
        }

        public class EntityPropertyCodeSetupper : EntityPropertySetupper<Kbnメニュー区分> {
            public void Setup(Kbnメニュー区分 entity, Object value) { entity.Code = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyメニュー名Setupper : EntityPropertySetupper<Kbnメニュー区分> {
            public void Setup(Kbnメニュー区分 entity, Object value) { entity.メニュー名 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty優先順位Setupper : EntityPropertySetupper<Kbnメニュー区分> {
            public void Setup(Kbnメニュー区分 entity, Object value) { entity.優先順位 = (value != null) ? (int?)value : null; }
        }
    }
}
