
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

    public class KbnRankDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(KbnRank);

        private static readonly KbnRankDbm _instance = new KbnRankDbm();
        private KbnRankDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static KbnRankDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "kbn_rank"; } }
        public override String TablePropertyName { get { return "KbnRank"; } }
        public override String TableSqlName { get { return "kbn_rank"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnCode;
        protected ColumnInfo _columnEnglishName;
        protected ColumnInfo _columnJapaneseName;

        public ColumnInfo ColumnCode { get { return _columnCode; } }
        public ColumnInfo ColumnEnglishName { get { return _columnEnglishName; } }
        public ColumnInfo ColumnJapaneseName { get { return _columnJapaneseName; } }

        protected void InitializeColumnInfo() {
            _columnCode = cci("code", "code", null, null, true, "Code", typeof(String), true, "varchar", 3, 0, false, OptimisticLockType.NONE, null, null, "mstEmployeeList");
            _columnEnglishName = cci("english_name", "english_name", null, null, true, "EnglishName", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnJapaneseName = cci("japanese_name", "japanese_name", null, null, true, "JapaneseName", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnCode);
            _columnInfoList.add(ColumnEnglishName);
            _columnInfoList.add(ColumnJapaneseName);
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
        public ReferrerInfo ReferrerMstEmployeeList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnCode, MstEmployeeDbm.GetInstance().ColumnRankCode);
            return cri("MstEmployeeList", this, MstEmployeeDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "kbn_rank";
        public static readonly String TABLE_PROPERTY_NAME = "KbnRank";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_code = "code";
        public static readonly String DB_NAME_english_name = "english_name";
        public static readonly String DB_NAME_japanese_name = "japanese_name";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_code = "Code";
        public static readonly String PROPERTY_NAME_english_name = "EnglishName";
        public static readonly String PROPERTY_NAME_japanese_name = "JapaneseName";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_MstEmployeeList = "MstEmployeeList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static KbnRankDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_code.ToLower(), PROPERTY_NAME_code);
                map.put(DB_NAME_english_name.ToLower(), PROPERTY_NAME_english_name);
                map.put(DB_NAME_japanese_name.ToLower(), PROPERTY_NAME_japanese_name);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_code.ToLower(), DB_NAME_code);
                map.put(PROPERTY_NAME_english_name.ToLower(), DB_NAME_english_name);
                map.put(PROPERTY_NAME_japanese_name.ToLower(), DB_NAME_japanese_name);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.KbnRank"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.KbnRankDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.KbnRankCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.KbnRankBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public KbnRank NewMyEntity() { return new KbnRank(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public KbnRankCB NewMyConditionBean() { return new KbnRankCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<KbnRank>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<KbnRank>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("code", "Code", new EntityPropertyCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("english_name", "EnglishName", new EntityPropertyEnglishNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("japanese_name", "JapaneseName", new EntityPropertyJapaneseNameSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<KbnRank> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((KbnRank)entity, value);
        }

        public class EntityPropertyCodeSetupper : EntityPropertySetupper<KbnRank> {
            public void Setup(KbnRank entity, Object value) { entity.Code = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyEnglishNameSetupper : EntityPropertySetupper<KbnRank> {
            public void Setup(KbnRank entity, Object value) { entity.EnglishName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyJapaneseNameSetupper : EntityPropertySetupper<KbnRank> {
            public void Setup(KbnRank entity, Object value) { entity.JapaneseName = (value != null) ? (String)value : null; }
        }
    }
}
