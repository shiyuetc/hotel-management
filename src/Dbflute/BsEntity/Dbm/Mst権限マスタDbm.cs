
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

    public class Mst権限マスタDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Mst権限マスタ);

        private static readonly Mst権限マスタDbm _instance = new Mst権限マスタDbm();
        private Mst権限マスタDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Mst権限マスタDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "mst権限マスタ"; } }
        public override String TablePropertyName { get { return "Mst権限マスタ"; } }
        public override String TableSqlName { get { return "mst権限マスタ"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _column職位コード;
        protected ColumnInfo _column画面コード;

        public ColumnInfo Column職位コード { get { return _column職位コード; } }
        public ColumnInfo Column画面コード { get { return _column画面コード; } }

        protected void InitializeColumnInfo() {
            _column職位コード = cci("職位コード", "職位コード", null, null, true, "職位コード", typeof(String), true, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, "kbn職位区分", null);
            _column画面コード = cci("画面コード", "画面コード", null, null, true, "画面コード", typeof(String), true, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, "mst画面マスタ", null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(Column職位コード);
            _columnInfoList.add(Column画面コード);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            List<ColumnInfo> ls = new ArrayList<ColumnInfo>();
            ls.add(Column職位コード);
            ls.add(Column画面コード);
            return cpui(ls);
        }}

        // -------------------------------------------------
        //                                   Primary Element
        //                                   ---------------
        public override bool HasPrimaryKey { get { return true; } }
        public override bool HasCompoundPrimaryKey { get { return true; } }

        // ===============================================================================
        //                                                                   Relation Info
        //                                                                   =============
        // -------------------------------------------------
        //                                   Foreign Element
        //                                   ---------------
        public ForeignInfo ForeignMst画面マスタ { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column画面コード, Mst画面マスタDbm.GetInstance().Column画面コード);
            return cfi("Mst画面マスタ", this, Mst画面マスタDbm.GetInstance(), map, 0, false, false);
        }}
        public ForeignInfo ForeignKbn職位区分 { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column職位コード, Kbn職位区分Dbm.GetInstance().Column職位コード);
            return cfi("Kbn職位区分", this, Kbn職位区分Dbm.GetInstance(), map, 1, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------

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
        public static readonly String TABLE_DB_NAME = "mst権限マスタ";
        public static readonly String TABLE_PROPERTY_NAME = "Mst権限マスタ";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_職位コード = "職位コード";
        public static readonly String DB_NAME_画面コード = "画面コード";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_職位コード = "職位コード";
        public static readonly String PROPERTY_NAME_画面コード = "画面コード";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_Mst画面マスタ = "Mst画面マスタ";
        public static readonly String FOREIGN_PROPERTY_NAME_Kbn職位区分 = "Kbn職位区分";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Mst権限マスタDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_職位コード.ToLower(), PROPERTY_NAME_職位コード);
                map.put(DB_NAME_画面コード.ToLower(), PROPERTY_NAME_画面コード);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_職位コード.ToLower(), DB_NAME_職位コード);
                map.put(PROPERTY_NAME_画面コード.ToLower(), DB_NAME_画面コード);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Mst権限マスタ"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Mst権限マスタDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Mst権限マスタCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Mst権限マスタBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Mst権限マスタ NewMyEntity() { return new Mst権限マスタ(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Mst権限マスタCB NewMyConditionBean() { return new Mst権限マスタCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Mst権限マスタ>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Mst権限マスタ>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("職位コード", "職位コード", new EntityProperty職位コードSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("画面コード", "画面コード", new EntityProperty画面コードSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Mst権限マスタ> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Mst権限マスタ)entity, value);
        }

        public class EntityProperty職位コードSetupper : EntityPropertySetupper<Mst権限マスタ> {
            public void Setup(Mst権限マスタ entity, Object value) { entity.職位コード = (value != null) ? (String)value : null; }
        }
        public class EntityProperty画面コードSetupper : EntityPropertySetupper<Mst権限マスタ> {
            public void Setup(Mst権限マスタ entity, Object value) { entity.画面コード = (value != null) ? (String)value : null; }
        }
    }
}
