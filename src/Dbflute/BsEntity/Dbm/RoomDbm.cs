
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

    public class RoomDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Room);

        private static readonly RoomDbm _instance = new RoomDbm();
        private RoomDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static RoomDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "room"; } }
        public override String TablePropertyName { get { return "Room"; } }
        public override String TableSqlName { get { return "room"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _columnRoomNo;
        protected ColumnInfo _columnRoomTypeCode;
        protected ColumnInfo _columnCanSmoke;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo ColumnRoomNo { get { return _columnRoomNo; } }
        public ColumnInfo ColumnRoomTypeCode { get { return _columnRoomTypeCode; } }
        public ColumnInfo ColumnCanSmoke { get { return _columnCanSmoke; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(long?), true, "bigserial", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRoomNo = cci("room_no", "room_no", null, null, true, "RoomNo", typeof(String), false, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRoomTypeCode = cci("room_type_code", "room_type_code", null, null, true, "RoomTypeCode", typeof(String), false, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, "roomType", null);
            _columnCanSmoke = cci("can_smoke", "can_smoke", null, null, false, "CanSmoke", typeof(bool?), false, "bool", 1, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(ColumnRoomNo);
            _columnInfoList.add(ColumnRoomTypeCode);
            _columnInfoList.add(ColumnCanSmoke);
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
        public ForeignInfo ForeignRoomType { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnRoomTypeCode, RoomTypeDbm.GetInstance().ColumnCode);
            return cfi("RoomType", this, RoomTypeDbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasSequence { get { return true; } }
        public override String SequenceName { get { return "room_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('room_id_seq')"; } }
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
        public static readonly String TABLE_DB_NAME = "room";
        public static readonly String TABLE_PROPERTY_NAME = "Room";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_room_no = "room_no";
        public static readonly String DB_NAME_room_type_code = "room_type_code";
        public static readonly String DB_NAME_can_smoke = "can_smoke";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_room_no = "RoomNo";
        public static readonly String PROPERTY_NAME_room_type_code = "RoomTypeCode";
        public static readonly String PROPERTY_NAME_can_smoke = "CanSmoke";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_RoomType = "RoomType";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static RoomDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_room_no.ToLower(), PROPERTY_NAME_room_no);
                map.put(DB_NAME_room_type_code.ToLower(), PROPERTY_NAME_room_type_code);
                map.put(DB_NAME_can_smoke.ToLower(), PROPERTY_NAME_can_smoke);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_room_no.ToLower(), DB_NAME_room_no);
                map.put(PROPERTY_NAME_room_type_code.ToLower(), DB_NAME_room_type_code);
                map.put(PROPERTY_NAME_can_smoke.ToLower(), DB_NAME_can_smoke);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Room"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.RoomDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.RoomCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.RoomBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Room NewMyEntity() { return new Room(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public RoomCB NewMyConditionBean() { return new RoomCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Room>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Room>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("room_no", "RoomNo", new EntityPropertyRoomNoSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("room_type_code", "RoomTypeCode", new EntityPropertyRoomTypeCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("can_smoke", "CanSmoke", new EntityPropertyCanSmokeSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Room> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Room)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<Room> {
            public void Setup(Room entity, Object value) { entity.Id = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyRoomNoSetupper : EntityPropertySetupper<Room> {
            public void Setup(Room entity, Object value) { entity.RoomNo = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRoomTypeCodeSetupper : EntityPropertySetupper<Room> {
            public void Setup(Room entity, Object value) { entity.RoomTypeCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyCanSmokeSetupper : EntityPropertySetupper<Room> {
            public void Setup(Room entity, Object value) { entity.CanSmoke = (value != null) ? (bool?)value : null; }
        }
    }
}
