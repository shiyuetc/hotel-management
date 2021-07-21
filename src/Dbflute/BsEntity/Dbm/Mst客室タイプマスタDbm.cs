
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

    public class Mst客室タイプマスタDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Mst客室タイプマスタ);

        private static readonly Mst客室タイプマスタDbm _instance = new Mst客室タイプマスタDbm();
        private Mst客室タイプマスタDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Mst客室タイプマスタDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "mst客室タイプマスタ"; } }
        public override String TablePropertyName { get { return "Mst客室タイプマスタ"; } }
        public override String TableSqlName { get { return "mst客室タイプマスタ"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _column名称;
        protected ColumnInfo _column料金;
        protected ColumnInfo _column宿泊人数;
        protected ColumnInfo _column備考;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo Column名称 { get { return _column名称; } }
        public ColumnInfo Column料金 { get { return _column料金; } }
        public ColumnInfo Column宿泊人数 { get { return _column宿泊人数; } }
        public ColumnInfo Column備考 { get { return _column備考; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(long?), true, "bigserial", 19, 0, false, OptimisticLockType.NONE, null, null, "mst客室マスタList");
            _column名称 = cci("名称", "名称", null, null, true, "名称", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _column料金 = cci("料金", "料金", null, null, true, "料金", typeof(int?), false, "int4", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _column宿泊人数 = cci("宿泊人数", "宿泊人数", null, null, true, "宿泊人数", typeof(int?), false, "int4", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _column備考 = cci("備考", "備考", null, null, false, "備考", typeof(String), false, "varchar", 255, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(Column名称);
            _columnInfoList.add(Column料金);
            _columnInfoList.add(Column宿泊人数);
            _columnInfoList.add(Column備考);
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
        public ReferrerInfo ReferrerMst客室マスタList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnId, Mst客室マスタDbm.GetInstance().Column客室タイプid);
            return cri("Mst客室マスタList", this, Mst客室マスタDbm.GetInstance(), map, false);
        }}

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasSequence { get { return true; } }
        public override String SequenceName { get { return "mst005_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('mst005_id_seq')"; } }
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
        public static readonly String TABLE_DB_NAME = "mst客室タイプマスタ";
        public static readonly String TABLE_PROPERTY_NAME = "Mst客室タイプマスタ";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_名称 = "名称";
        public static readonly String DB_NAME_料金 = "料金";
        public static readonly String DB_NAME_宿泊人数 = "宿泊人数";
        public static readonly String DB_NAME_備考 = "備考";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_名称 = "名称";
        public static readonly String PROPERTY_NAME_料金 = "料金";
        public static readonly String PROPERTY_NAME_宿泊人数 = "宿泊人数";
        public static readonly String PROPERTY_NAME_備考 = "備考";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_Mst客室マスタList = "Mst客室マスタList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Mst客室タイプマスタDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_名称.ToLower(), PROPERTY_NAME_名称);
                map.put(DB_NAME_料金.ToLower(), PROPERTY_NAME_料金);
                map.put(DB_NAME_宿泊人数.ToLower(), PROPERTY_NAME_宿泊人数);
                map.put(DB_NAME_備考.ToLower(), PROPERTY_NAME_備考);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_名称.ToLower(), DB_NAME_名称);
                map.put(PROPERTY_NAME_料金.ToLower(), DB_NAME_料金);
                map.put(PROPERTY_NAME_宿泊人数.ToLower(), DB_NAME_宿泊人数);
                map.put(PROPERTY_NAME_備考.ToLower(), DB_NAME_備考);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Mst客室タイプマスタ"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Mst客室タイプマスタDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Mst客室タイプマスタCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Mst客室タイプマスタBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Mst客室タイプマスタ NewMyEntity() { return new Mst客室タイプマスタ(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Mst客室タイプマスタCB NewMyConditionBean() { return new Mst客室タイプマスタCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Mst客室タイプマスタ>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Mst客室タイプマスタ>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("名称", "名称", new EntityProperty名称Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("料金", "料金", new EntityProperty料金Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("宿泊人数", "宿泊人数", new EntityProperty宿泊人数Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("備考", "備考", new EntityProperty備考Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Mst客室タイプマスタ> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Mst客室タイプマスタ)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<Mst客室タイプマスタ> {
            public void Setup(Mst客室タイプマスタ entity, Object value) { entity.Id = (value != null) ? (long?)value : null; }
        }
        public class EntityProperty名称Setupper : EntityPropertySetupper<Mst客室タイプマスタ> {
            public void Setup(Mst客室タイプマスタ entity, Object value) { entity.名称 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty料金Setupper : EntityPropertySetupper<Mst客室タイプマスタ> {
            public void Setup(Mst客室タイプマスタ entity, Object value) { entity.料金 = (value != null) ? (int?)value : null; }
        }
        public class EntityProperty宿泊人数Setupper : EntityPropertySetupper<Mst客室タイプマスタ> {
            public void Setup(Mst客室タイプマスタ entity, Object value) { entity.宿泊人数 = (value != null) ? (int?)value : null; }
        }
        public class EntityProperty備考Setupper : EntityPropertySetupper<Mst客室タイプマスタ> {
            public void Setup(Mst客室タイプマスタ entity, Object value) { entity.備考 = (value != null) ? (String)value : null; }
        }
    }
}
