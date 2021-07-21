
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
        protected ColumnInfo _columnCode;
        protected ColumnInfo _column名称;
        protected ColumnInfo _column名称英字;

        public ColumnInfo ColumnCode { get { return _columnCode; } }
        public ColumnInfo Column名称 { get { return _column名称; } }
        public ColumnInfo Column名称英字 { get { return _column名称英字; } }

        protected void InitializeColumnInfo() {
            _columnCode = cci("code", "code", null, null, true, "Code", typeof(String), true, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, null, "dch従業員職位履歴台帳List,mstメニュー権限マスタList,mst従業員マスタList");
            _column名称 = cci("名称", "名称", null, null, true, "名称", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _column名称英字 = cci("名称_英字", "名称_英字", null, null, true, "名称英字", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnCode);
            _columnInfoList.add(Column名称);
            _columnInfoList.add(Column名称英字);
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
        public ReferrerInfo ReferrerDch従業員職位履歴台帳List { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnCode, Dch従業員職位履歴台帳Dbm.GetInstance().Column職位code);
            return cri("Dch従業員職位履歴台帳List", this, Dch従業員職位履歴台帳Dbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerMstメニュー権限マスタList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnCode, Mstメニュー権限マスタDbm.GetInstance().Column職位code);
            return cri("Mstメニュー権限マスタList", this, Mstメニュー権限マスタDbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerMst従業員マスタList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnCode, Mst従業員マスタDbm.GetInstance().Column職位code);
            return cri("Mst従業員マスタList", this, Mst従業員マスタDbm.GetInstance(), map, false);
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
        public static readonly String DB_NAME_code = "code";
        public static readonly String DB_NAME_名称 = "名称";
        public static readonly String DB_NAME_名称_英字 = "名称_英字";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_code = "Code";
        public static readonly String PROPERTY_NAME_名称 = "名称";
        public static readonly String PROPERTY_NAME_名称_英字 = "名称英字";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_Dch従業員職位履歴台帳List = "Dch従業員職位履歴台帳List";
        public static readonly String REFERRER_PROPERTY_NAME_Mstメニュー権限マスタList = "Mstメニュー権限マスタList";
        public static readonly String REFERRER_PROPERTY_NAME_Mst従業員マスタList = "Mst従業員マスタList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Kbn職位区分Dbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_code.ToLower(), PROPERTY_NAME_code);
                map.put(DB_NAME_名称.ToLower(), PROPERTY_NAME_名称);
                map.put(DB_NAME_名称_英字.ToLower(), PROPERTY_NAME_名称_英字);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_code.ToLower(), DB_NAME_code);
                map.put(PROPERTY_NAME_名称.ToLower(), DB_NAME_名称);
                map.put(PROPERTY_NAME_名称_英字.ToLower(), DB_NAME_名称_英字);
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
            RegisterEntityPropertySetupper("code", "Code", new EntityPropertyCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("名称", "名称", new EntityProperty名称Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("名称_英字", "名称英字", new EntityProperty名称英字Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Kbn職位区分> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Kbn職位区分)entity, value);
        }

        public class EntityPropertyCodeSetupper : EntityPropertySetupper<Kbn職位区分> {
            public void Setup(Kbn職位区分 entity, Object value) { entity.Code = (value != null) ? (String)value : null; }
        }
        public class EntityProperty名称Setupper : EntityPropertySetupper<Kbn職位区分> {
            public void Setup(Kbn職位区分 entity, Object value) { entity.名称 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty名称英字Setupper : EntityPropertySetupper<Kbn職位区分> {
            public void Setup(Kbn職位区分 entity, Object value) { entity.名称英字 = (value != null) ? (String)value : null; }
        }
    }
}
