
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

    public class DmyプロシージャDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Dmyプロシージャ);

        private static readonly DmyプロシージャDbm _instance = new DmyプロシージャDbm();
        private DmyプロシージャDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static DmyプロシージャDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "dmyプロシージャ"; } }
        public override String TablePropertyName { get { return "Dmyプロシージャ"; } }
        public override String TableSqlName { get { return "dmyプロシージャ"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnDummy;

        public ColumnInfo ColumnDummy { get { return _columnDummy; } }

        protected void InitializeColumnInfo() {
            _columnDummy = cci("dummy", "dummy", null, null, false, "Dummy", typeof(String), false, "bpchar", 1, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnDummy);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            throw new NotSupportedException("The table does not have primary key: " + TableDbName);
        }}

        // -------------------------------------------------
        //                                   Primary Element
        //                                   ---------------
        public override bool HasPrimaryKey { get { return false; } }
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
        public override bool HasCommonColumn { get { return false; } }

        // ===============================================================================
        //                                                                 Name Definition
        //                                                                 ===============
        #region Name

        // -------------------------------------------------
        //                                             Table
        //                                             -----
        public static readonly String TABLE_DB_NAME = "dmyプロシージャ";
        public static readonly String TABLE_PROPERTY_NAME = "Dmyプロシージャ";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_dummy = "dummy";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_dummy = "Dummy";

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

        static DmyプロシージャDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_dummy.ToLower(), PROPERTY_NAME_dummy);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_dummy.ToLower(), DB_NAME_dummy);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Dmyプロシージャ"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.DmyプロシージャDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.DmyプロシージャCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.DmyプロシージャBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Dmyプロシージャ NewMyEntity() { return new Dmyプロシージャ(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public DmyプロシージャCB NewMyConditionBean() { return new DmyプロシージャCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Dmyプロシージャ>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Dmyプロシージャ>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("dummy", "Dummy", new EntityPropertyDummySetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Dmyプロシージャ> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Dmyプロシージャ)entity, value);
        }

        public class EntityPropertyDummySetupper : EntityPropertySetupper<Dmyプロシージャ> {
            public void Setup(Dmyプロシージャ entity, Object value) { entity.Dummy = (value != null) ? (String)value : null; }
        }
    }
}
