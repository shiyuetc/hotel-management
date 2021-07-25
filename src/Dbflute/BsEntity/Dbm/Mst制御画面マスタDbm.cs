
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

    public class Mst制御画面マスタDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Mst制御画面マスタ);

        private static readonly Mst制御画面マスタDbm _instance = new Mst制御画面マスタDbm();
        private Mst制御画面マスタDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Mst制御画面マスタDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "mst制御画面マスタ"; } }
        public override String TablePropertyName { get { return "Mst制御画面マスタ"; } }
        public override String TableSqlName { get { return "mst制御画面マスタ"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _columnメニューcode;
        protected ColumnInfo _column画面名;
        protected ColumnInfo _column表示名;
        protected ColumnInfo _column優先順位;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo Columnメニューcode { get { return _columnメニューcode; } }
        public ColumnInfo Column画面名 { get { return _column画面名; } }
        public ColumnInfo Column表示名 { get { return _column表示名; } }
        public ColumnInfo Column優先順位 { get { return _column優先順位; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(long?), true, "bigserial", 19, 0, false, OptimisticLockType.NONE, null, null, "mst権限マスタList");
            _columnメニューcode = cci("メニューcode", "メニューcode", null, null, true, "メニューcode", typeof(String), false, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, "kbnメニュー区分", null);
            _column画面名 = cci("画面名", "画面名", null, null, true, "画面名", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _column表示名 = cci("表示名", "表示名", null, null, true, "表示名", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _column優先順位 = cci("優先順位", "優先順位", null, null, true, "優先順位", typeof(int?), false, "int4", 10, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(Columnメニューcode);
            _columnInfoList.add(Column画面名);
            _columnInfoList.add(Column表示名);
            _columnInfoList.add(Column優先順位);
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
        public ForeignInfo ForeignKbnメニュー区分 { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Columnメニューcode, Kbnメニュー区分Dbm.GetInstance().ColumnCode);
            return cfi("Kbnメニュー区分", this, Kbnメニュー区分Dbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public ReferrerInfo ReferrerMst権限マスタList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnId, Mst権限マスタDbm.GetInstance().Column制御画面id);
            return cri("Mst権限マスタList", this, Mst権限マスタDbm.GetInstance(), map, false);
        }}

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasSequence { get { return true; } }
        public override String SequenceName { get { return "mst001_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('mst001_id_seq')"; } }
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
        public static readonly String TABLE_DB_NAME = "mst制御画面マスタ";
        public static readonly String TABLE_PROPERTY_NAME = "Mst制御画面マスタ";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_メニューcode = "メニューcode";
        public static readonly String DB_NAME_画面名 = "画面名";
        public static readonly String DB_NAME_表示名 = "表示名";
        public static readonly String DB_NAME_優先順位 = "優先順位";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_メニューcode = "メニューcode";
        public static readonly String PROPERTY_NAME_画面名 = "画面名";
        public static readonly String PROPERTY_NAME_表示名 = "表示名";
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

        static Mst制御画面マスタDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_メニューcode.ToLower(), PROPERTY_NAME_メニューcode);
                map.put(DB_NAME_画面名.ToLower(), PROPERTY_NAME_画面名);
                map.put(DB_NAME_表示名.ToLower(), PROPERTY_NAME_表示名);
                map.put(DB_NAME_優先順位.ToLower(), PROPERTY_NAME_優先順位);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_メニューcode.ToLower(), DB_NAME_メニューcode);
                map.put(PROPERTY_NAME_画面名.ToLower(), DB_NAME_画面名);
                map.put(PROPERTY_NAME_表示名.ToLower(), DB_NAME_表示名);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Mst制御画面マスタ"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Mst制御画面マスタDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Mst制御画面マスタCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Mst制御画面マスタBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Mst制御画面マスタ NewMyEntity() { return new Mst制御画面マスタ(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Mst制御画面マスタCB NewMyConditionBean() { return new Mst制御画面マスタCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Mst制御画面マスタ>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Mst制御画面マスタ>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("メニューcode", "メニューcode", new EntityPropertyメニューcodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("画面名", "画面名", new EntityProperty画面名Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("表示名", "表示名", new EntityProperty表示名Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("優先順位", "優先順位", new EntityProperty優先順位Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Mst制御画面マスタ> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Mst制御画面マスタ)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<Mst制御画面マスタ> {
            public void Setup(Mst制御画面マスタ entity, Object value) { entity.Id = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyメニューcodeSetupper : EntityPropertySetupper<Mst制御画面マスタ> {
            public void Setup(Mst制御画面マスタ entity, Object value) { entity.メニューcode = (value != null) ? (String)value : null; }
        }
        public class EntityProperty画面名Setupper : EntityPropertySetupper<Mst制御画面マスタ> {
            public void Setup(Mst制御画面マスタ entity, Object value) { entity.画面名 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty表示名Setupper : EntityPropertySetupper<Mst制御画面マスタ> {
            public void Setup(Mst制御画面マスタ entity, Object value) { entity.表示名 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty優先順位Setupper : EntityPropertySetupper<Mst制御画面マスタ> {
            public void Setup(Mst制御画面マスタ entity, Object value) { entity.優先順位 = (value != null) ? (int?)value : null; }
        }
    }
}
