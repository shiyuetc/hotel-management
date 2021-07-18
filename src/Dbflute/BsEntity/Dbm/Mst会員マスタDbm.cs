
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

    public class Mst会員マスタDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Mst会員マスタ);

        private static readonly Mst会員マスタDbm _instance = new Mst会員マスタDbm();
        private Mst会員マスタDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Mst会員マスタDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "mst会員マスタ"; } }
        public override String TablePropertyName { get { return "Mst会員マスタ"; } }
        public override String TableSqlName { get { return "mst会員マスタ"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _column会員番号;
        protected ColumnInfo _column氏名姓;
        protected ColumnInfo _column氏名名;
        protected ColumnInfo _column氏名カナ;
        protected ColumnInfo _column会社名;
        protected ColumnInfo _column会社名カナ;
        protected ColumnInfo _column電話番号;
        protected ColumnInfo _columnメールアドレス;
        protected ColumnInfo _column入会年月日;
        protected ColumnInfo _column退会年月日;
        protected ColumnInfo _column備考;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo Column会員番号 { get { return _column会員番号; } }
        public ColumnInfo Column氏名姓 { get { return _column氏名姓; } }
        public ColumnInfo Column氏名名 { get { return _column氏名名; } }
        public ColumnInfo Column氏名カナ { get { return _column氏名カナ; } }
        public ColumnInfo Column会社名 { get { return _column会社名; } }
        public ColumnInfo Column会社名カナ { get { return _column会社名カナ; } }
        public ColumnInfo Column電話番号 { get { return _column電話番号; } }
        public ColumnInfo Columnメールアドレス { get { return _columnメールアドレス; } }
        public ColumnInfo Column入会年月日 { get { return _column入会年月日; } }
        public ColumnInfo Column退会年月日 { get { return _column退会年月日; } }
        public ColumnInfo Column備考 { get { return _column備考; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(long?), true, "bigserial", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _column会員番号 = cci("会員番号", "会員番号", null, null, true, "会員番号", typeof(String), false, "varchar", 9, 0, false, OptimisticLockType.NONE, null, null, null);
            _column氏名姓 = cci("氏名_姓", "氏名_姓", null, null, true, "氏名姓", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _column氏名名 = cci("氏名_名", "氏名_名", null, null, true, "氏名名", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _column氏名カナ = cci("氏名_カナ", "氏名_カナ", null, null, true, "氏名カナ", typeof(String), false, "varchar", 50, 0, false, OptimisticLockType.NONE, null, null, null);
            _column会社名 = cci("会社名", "会社名", null, null, false, "会社名", typeof(String), false, "varchar", 50, 0, false, OptimisticLockType.NONE, null, null, null);
            _column会社名カナ = cci("会社名_カナ", "会社名_カナ", null, null, false, "会社名カナ", typeof(String), false, "varchar", 50, 0, false, OptimisticLockType.NONE, null, null, null);
            _column電話番号 = cci("電話番号", "電話番号", null, null, false, "電話番号", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnメールアドレス = cci("メールアドレス", "メールアドレス", null, null, false, "メールアドレス", typeof(String), false, "varchar", 255, 0, false, OptimisticLockType.NONE, null, null, null);
            _column入会年月日 = cci("入会年月日", "入会年月日", null, null, true, "入会年月日", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _column退会年月日 = cci("退会年月日", "退会年月日", null, null, false, "退会年月日", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _column備考 = cci("備考", "備考", null, null, false, "備考", typeof(String), false, "varchar", 255, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(Column会員番号);
            _columnInfoList.add(Column氏名姓);
            _columnInfoList.add(Column氏名名);
            _columnInfoList.add(Column氏名カナ);
            _columnInfoList.add(Column会社名);
            _columnInfoList.add(Column会社名カナ);
            _columnInfoList.add(Column電話番号);
            _columnInfoList.add(Columnメールアドレス);
            _columnInfoList.add(Column入会年月日);
            _columnInfoList.add(Column退会年月日);
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

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasSequence { get { return true; } }
        public override String SequenceName { get { return "mst003_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('mst003_id_seq')"; } }
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
        public static readonly String TABLE_DB_NAME = "mst会員マスタ";
        public static readonly String TABLE_PROPERTY_NAME = "Mst会員マスタ";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_会員番号 = "会員番号";
        public static readonly String DB_NAME_氏名_姓 = "氏名_姓";
        public static readonly String DB_NAME_氏名_名 = "氏名_名";
        public static readonly String DB_NAME_氏名_カナ = "氏名_カナ";
        public static readonly String DB_NAME_会社名 = "会社名";
        public static readonly String DB_NAME_会社名_カナ = "会社名_カナ";
        public static readonly String DB_NAME_電話番号 = "電話番号";
        public static readonly String DB_NAME_メールアドレス = "メールアドレス";
        public static readonly String DB_NAME_入会年月日 = "入会年月日";
        public static readonly String DB_NAME_退会年月日 = "退会年月日";
        public static readonly String DB_NAME_備考 = "備考";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_会員番号 = "会員番号";
        public static readonly String PROPERTY_NAME_氏名_姓 = "氏名姓";
        public static readonly String PROPERTY_NAME_氏名_名 = "氏名名";
        public static readonly String PROPERTY_NAME_氏名_カナ = "氏名カナ";
        public static readonly String PROPERTY_NAME_会社名 = "会社名";
        public static readonly String PROPERTY_NAME_会社名_カナ = "会社名カナ";
        public static readonly String PROPERTY_NAME_電話番号 = "電話番号";
        public static readonly String PROPERTY_NAME_メールアドレス = "メールアドレス";
        public static readonly String PROPERTY_NAME_入会年月日 = "入会年月日";
        public static readonly String PROPERTY_NAME_退会年月日 = "退会年月日";
        public static readonly String PROPERTY_NAME_備考 = "備考";

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

        static Mst会員マスタDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_会員番号.ToLower(), PROPERTY_NAME_会員番号);
                map.put(DB_NAME_氏名_姓.ToLower(), PROPERTY_NAME_氏名_姓);
                map.put(DB_NAME_氏名_名.ToLower(), PROPERTY_NAME_氏名_名);
                map.put(DB_NAME_氏名_カナ.ToLower(), PROPERTY_NAME_氏名_カナ);
                map.put(DB_NAME_会社名.ToLower(), PROPERTY_NAME_会社名);
                map.put(DB_NAME_会社名_カナ.ToLower(), PROPERTY_NAME_会社名_カナ);
                map.put(DB_NAME_電話番号.ToLower(), PROPERTY_NAME_電話番号);
                map.put(DB_NAME_メールアドレス.ToLower(), PROPERTY_NAME_メールアドレス);
                map.put(DB_NAME_入会年月日.ToLower(), PROPERTY_NAME_入会年月日);
                map.put(DB_NAME_退会年月日.ToLower(), PROPERTY_NAME_退会年月日);
                map.put(DB_NAME_備考.ToLower(), PROPERTY_NAME_備考);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_会員番号.ToLower(), DB_NAME_会員番号);
                map.put(PROPERTY_NAME_氏名_姓.ToLower(), DB_NAME_氏名_姓);
                map.put(PROPERTY_NAME_氏名_名.ToLower(), DB_NAME_氏名_名);
                map.put(PROPERTY_NAME_氏名_カナ.ToLower(), DB_NAME_氏名_カナ);
                map.put(PROPERTY_NAME_会社名.ToLower(), DB_NAME_会社名);
                map.put(PROPERTY_NAME_会社名_カナ.ToLower(), DB_NAME_会社名_カナ);
                map.put(PROPERTY_NAME_電話番号.ToLower(), DB_NAME_電話番号);
                map.put(PROPERTY_NAME_メールアドレス.ToLower(), DB_NAME_メールアドレス);
                map.put(PROPERTY_NAME_入会年月日.ToLower(), DB_NAME_入会年月日);
                map.put(PROPERTY_NAME_退会年月日.ToLower(), DB_NAME_退会年月日);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Mst会員マスタ"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Mst会員マスタDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Mst会員マスタCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Mst会員マスタBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Mst会員マスタ NewMyEntity() { return new Mst会員マスタ(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Mst会員マスタCB NewMyConditionBean() { return new Mst会員マスタCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Mst会員マスタ>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Mst会員マスタ>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("会員番号", "会員番号", new EntityProperty会員番号Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("氏名_姓", "氏名姓", new EntityProperty氏名姓Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("氏名_名", "氏名名", new EntityProperty氏名名Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("氏名_カナ", "氏名カナ", new EntityProperty氏名カナSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("会社名", "会社名", new EntityProperty会社名Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("会社名_カナ", "会社名カナ", new EntityProperty会社名カナSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("電話番号", "電話番号", new EntityProperty電話番号Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("メールアドレス", "メールアドレス", new EntityPropertyメールアドレスSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("入会年月日", "入会年月日", new EntityProperty入会年月日Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("退会年月日", "退会年月日", new EntityProperty退会年月日Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("備考", "備考", new EntityProperty備考Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Mst会員マスタ> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Mst会員マスタ)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<Mst会員マスタ> {
            public void Setup(Mst会員マスタ entity, Object value) { entity.Id = (value != null) ? (long?)value : null; }
        }
        public class EntityProperty会員番号Setupper : EntityPropertySetupper<Mst会員マスタ> {
            public void Setup(Mst会員マスタ entity, Object value) { entity.会員番号 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty氏名姓Setupper : EntityPropertySetupper<Mst会員マスタ> {
            public void Setup(Mst会員マスタ entity, Object value) { entity.氏名姓 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty氏名名Setupper : EntityPropertySetupper<Mst会員マスタ> {
            public void Setup(Mst会員マスタ entity, Object value) { entity.氏名名 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty氏名カナSetupper : EntityPropertySetupper<Mst会員マスタ> {
            public void Setup(Mst会員マスタ entity, Object value) { entity.氏名カナ = (value != null) ? (String)value : null; }
        }
        public class EntityProperty会社名Setupper : EntityPropertySetupper<Mst会員マスタ> {
            public void Setup(Mst会員マスタ entity, Object value) { entity.会社名 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty会社名カナSetupper : EntityPropertySetupper<Mst会員マスタ> {
            public void Setup(Mst会員マスタ entity, Object value) { entity.会社名カナ = (value != null) ? (String)value : null; }
        }
        public class EntityProperty電話番号Setupper : EntityPropertySetupper<Mst会員マスタ> {
            public void Setup(Mst会員マスタ entity, Object value) { entity.電話番号 = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyメールアドレスSetupper : EntityPropertySetupper<Mst会員マスタ> {
            public void Setup(Mst会員マスタ entity, Object value) { entity.メールアドレス = (value != null) ? (String)value : null; }
        }
        public class EntityProperty入会年月日Setupper : EntityPropertySetupper<Mst会員マスタ> {
            public void Setup(Mst会員マスタ entity, Object value) { entity.入会年月日 = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityProperty退会年月日Setupper : EntityPropertySetupper<Mst会員マスタ> {
            public void Setup(Mst会員マスタ entity, Object value) { entity.退会年月日 = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityProperty備考Setupper : EntityPropertySetupper<Mst会員マスタ> {
            public void Setup(Mst会員マスタ entity, Object value) { entity.備考 = (value != null) ? (String)value : null; }
        }
    }
}
