
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

    public class Dch月締確定台帳Dbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Dch月締確定台帳);

        private static readonly Dch月締確定台帳Dbm _instance = new Dch月締確定台帳Dbm();
        private Dch月締確定台帳Dbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Dch月締確定台帳Dbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "dch月締確定台帳"; } }
        public override String TablePropertyName { get { return "Dch月締確定台帳"; } }
        public override String TableSqlName { get { return "dch月締確定台帳"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _column対象年月;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo Column対象年月 { get { return _column対象年月; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(long?), true, "bigserial", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _column対象年月 = cci("対象年月", "対象年月", null, null, true, "対象年月", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(Column対象年月);
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


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasSequence { get { return true; } }
        public override String SequenceName { get { return "dch002_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('dch002_id_seq')"; } }
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
        public static readonly String TABLE_DB_NAME = "dch月締確定台帳";
        public static readonly String TABLE_PROPERTY_NAME = "Dch月締確定台帳";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_対象年月 = "対象年月";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_対象年月 = "対象年月";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Dch月締確定台帳Dbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_対象年月.ToLower(), PROPERTY_NAME_対象年月);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_対象年月.ToLower(), DB_NAME_対象年月);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Dch月締確定台帳"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Dch月締確定台帳Dao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Dch月締確定台帳CB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Dch月締確定台帳Bhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Dch月締確定台帳 NewMyEntity() { return new Dch月締確定台帳(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Dch月締確定台帳CB NewMyConditionBean() { return new Dch月締確定台帳CB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Dch月締確定台帳>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Dch月締確定台帳>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("対象年月", "対象年月", new EntityProperty対象年月Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Dch月締確定台帳> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Dch月締確定台帳)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<Dch月締確定台帳> {
            public void Setup(Dch月締確定台帳 entity, Object value) { entity.Id = (value != null) ? (long?)value : null; }
        }
        public class EntityProperty対象年月Setupper : EntityPropertySetupper<Dch月締確定台帳> {
            public void Setup(Dch月締確定台帳 entity, Object value) { entity.対象年月 = (value != null) ? (DateTime?)value : null; }
        }
    }
}
