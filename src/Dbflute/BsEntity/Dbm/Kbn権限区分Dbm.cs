
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

    public class Kbn権限区分Dbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Kbn権限区分);

        private static readonly Kbn権限区分Dbm _instance = new Kbn権限区分Dbm();
        private Kbn権限区分Dbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Kbn権限区分Dbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "kbn権限区分"; } }
        public override String TablePropertyName { get { return "Kbn権限区分"; } }
        public override String TableSqlName { get { return "kbn権限区分"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnコード;
        protected ColumnInfo _column名称;

        public ColumnInfo Columnコード { get { return _columnコード; } }
        public ColumnInfo Column名称 { get { return _column名称; } }

        protected void InitializeColumnInfo() {
            _columnコード = cci("コード", "コード", null, null, true, "コード", typeof(String), true, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, null, "mst権限マスタList");
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
        public ReferrerInfo ReferrerMst権限マスタList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Columnコード, Mst権限マスタDbm.GetInstance().Column権限コード);
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
        public static readonly String TABLE_DB_NAME = "kbn権限区分";
        public static readonly String TABLE_PROPERTY_NAME = "Kbn権限区分";

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
        public static readonly String REFERRER_PROPERTY_NAME_Mst権限マスタList = "Mst権限マスタList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Kbn権限区分Dbm() {
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Kbn権限区分"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Kbn権限区分Dao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Kbn権限区分CB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Kbn権限区分Bhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Kbn権限区分 NewMyEntity() { return new Kbn権限区分(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Kbn権限区分CB NewMyConditionBean() { return new Kbn権限区分CB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Kbn権限区分>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Kbn権限区分>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("コード", "コード", new EntityPropertyコードSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("名称", "名称", new EntityProperty名称Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Kbn権限区分> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Kbn権限区分)entity, value);
        }

        public class EntityPropertyコードSetupper : EntityPropertySetupper<Kbn権限区分> {
            public void Setup(Kbn権限区分 entity, Object value) { entity.コード = (value != null) ? (String)value : null; }
        }
        public class EntityProperty名称Setupper : EntityPropertySetupper<Kbn権限区分> {
            public void Setup(Kbn権限区分 entity, Object value) { entity.名称 = (value != null) ? (String)value : null; }
        }
    }
}
