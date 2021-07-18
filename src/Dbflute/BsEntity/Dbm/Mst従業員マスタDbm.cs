
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

    public class Mst従業員マスタDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Mst従業員マスタ);

        private static readonly Mst従業員マスタDbm _instance = new Mst従業員マスタDbm();
        private Mst従業員マスタDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static Mst従業員マスタDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "mst従業員マスタ"; } }
        public override String TablePropertyName { get { return "Mst従業員マスタ"; } }
        public override String TableSqlName { get { return "mst従業員マスタ"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnId;
        protected ColumnInfo _column従業員番号;
        protected ColumnInfo _column氏名姓;
        protected ColumnInfo _column氏名名;
        protected ColumnInfo _column氏名カナ;
        protected ColumnInfo _columnメールアドレス;
        protected ColumnInfo _columnパスワード;
        protected ColumnInfo _column生年月日;
        protected ColumnInfo _column入社年月日;
        protected ColumnInfo _column退社年月日;
        protected ColumnInfo _column職位コード;
        protected ColumnInfo _column最終ログイン日時;
        protected ColumnInfo _column備考;

        public ColumnInfo ColumnId { get { return _columnId; } }
        public ColumnInfo Column従業員番号 { get { return _column従業員番号; } }
        public ColumnInfo Column氏名姓 { get { return _column氏名姓; } }
        public ColumnInfo Column氏名名 { get { return _column氏名名; } }
        public ColumnInfo Column氏名カナ { get { return _column氏名カナ; } }
        public ColumnInfo Columnメールアドレス { get { return _columnメールアドレス; } }
        public ColumnInfo Columnパスワード { get { return _columnパスワード; } }
        public ColumnInfo Column生年月日 { get { return _column生年月日; } }
        public ColumnInfo Column入社年月日 { get { return _column入社年月日; } }
        public ColumnInfo Column退社年月日 { get { return _column退社年月日; } }
        public ColumnInfo Column職位コード { get { return _column職位コード; } }
        public ColumnInfo Column最終ログイン日時 { get { return _column最終ログイン日時; } }
        public ColumnInfo Column備考 { get { return _column備考; } }

        protected void InitializeColumnInfo() {
            _columnId = cci("id", "id", null, null, true, "Id", typeof(long?), true, "bigserial", 19, 0, false, OptimisticLockType.NONE, null, null, "dch従業員職位履歴台帳List");
            _column従業員番号 = cci("従業員番号", "従業員番号", null, null, true, "従業員番号", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _column氏名姓 = cci("氏名_姓", "氏名_姓", null, null, true, "氏名姓", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _column氏名名 = cci("氏名_名", "氏名_名", null, null, true, "氏名名", typeof(String), false, "varchar", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _column氏名カナ = cci("氏名_カナ", "氏名_カナ", null, null, true, "氏名カナ", typeof(String), false, "varchar", 50, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnメールアドレス = cci("メールアドレス", "メールアドレス", null, null, false, "メールアドレス", typeof(String), false, "varchar", 255, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnパスワード = cci("パスワード", "パスワード", null, null, true, "パスワード", typeof(String), false, "varchar", 255, 0, false, OptimisticLockType.NONE, null, null, null);
            _column生年月日 = cci("生年月日", "生年月日", null, null, true, "生年月日", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _column入社年月日 = cci("入社年月日", "入社年月日", null, null, true, "入社年月日", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _column退社年月日 = cci("退社年月日", "退社年月日", null, null, false, "退社年月日", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _column職位コード = cci("職位コード", "職位コード", null, null, true, "職位コード", typeof(String), false, "bpchar", 3, 0, false, OptimisticLockType.NONE, null, "kbn職位区分", null);
            _column最終ログイン日時 = cci("最終ログイン日時", "最終ログイン日時", null, null, false, "最終ログイン日時", typeof(DateTime?), false, "timestamp", 26, 3, false, OptimisticLockType.NONE, null, null, null);
            _column備考 = cci("備考", "備考", null, null, false, "備考", typeof(String), false, "varchar", 255, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnId);
            _columnInfoList.add(Column従業員番号);
            _columnInfoList.add(Column氏名姓);
            _columnInfoList.add(Column氏名名);
            _columnInfoList.add(Column氏名カナ);
            _columnInfoList.add(Columnメールアドレス);
            _columnInfoList.add(Columnパスワード);
            _columnInfoList.add(Column生年月日);
            _columnInfoList.add(Column入社年月日);
            _columnInfoList.add(Column退社年月日);
            _columnInfoList.add(Column職位コード);
            _columnInfoList.add(Column最終ログイン日時);
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
        public ForeignInfo ForeignKbn職位区分 { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(Column職位コード, Kbn職位区分Dbm.GetInstance().Columnコード);
            return cfi("Kbn職位区分", this, Kbn職位区分Dbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public ReferrerInfo ReferrerDch従業員職位履歴台帳List { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnId, Dch従業員職位履歴台帳Dbm.GetInstance().Column従業員id);
            return cri("Dch従業員職位履歴台帳List", this, Dch従業員職位履歴台帳Dbm.GetInstance(), map, false);
        }}

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasSequence { get { return true; } }
        public override String SequenceName { get { return "mst002_id_seq"; } }
        public override String SequenceNextValSql { get { return "select nextval ('mst002_id_seq')"; } }
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
        public static readonly String TABLE_DB_NAME = "mst従業員マスタ";
        public static readonly String TABLE_PROPERTY_NAME = "Mst従業員マスタ";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_id = "id";
        public static readonly String DB_NAME_従業員番号 = "従業員番号";
        public static readonly String DB_NAME_氏名_姓 = "氏名_姓";
        public static readonly String DB_NAME_氏名_名 = "氏名_名";
        public static readonly String DB_NAME_氏名_カナ = "氏名_カナ";
        public static readonly String DB_NAME_メールアドレス = "メールアドレス";
        public static readonly String DB_NAME_パスワード = "パスワード";
        public static readonly String DB_NAME_生年月日 = "生年月日";
        public static readonly String DB_NAME_入社年月日 = "入社年月日";
        public static readonly String DB_NAME_退社年月日 = "退社年月日";
        public static readonly String DB_NAME_職位コード = "職位コード";
        public static readonly String DB_NAME_最終ログイン日時 = "最終ログイン日時";
        public static readonly String DB_NAME_備考 = "備考";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_id = "Id";
        public static readonly String PROPERTY_NAME_従業員番号 = "従業員番号";
        public static readonly String PROPERTY_NAME_氏名_姓 = "氏名姓";
        public static readonly String PROPERTY_NAME_氏名_名 = "氏名名";
        public static readonly String PROPERTY_NAME_氏名_カナ = "氏名カナ";
        public static readonly String PROPERTY_NAME_メールアドレス = "メールアドレス";
        public static readonly String PROPERTY_NAME_パスワード = "パスワード";
        public static readonly String PROPERTY_NAME_生年月日 = "生年月日";
        public static readonly String PROPERTY_NAME_入社年月日 = "入社年月日";
        public static readonly String PROPERTY_NAME_退社年月日 = "退社年月日";
        public static readonly String PROPERTY_NAME_職位コード = "職位コード";
        public static readonly String PROPERTY_NAME_最終ログイン日時 = "最終ログイン日時";
        public static readonly String PROPERTY_NAME_備考 = "備考";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_Kbn職位区分 = "Kbn職位区分";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_Dch従業員職位履歴台帳List = "Dch従業員職位履歴台帳List";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static Mst従業員マスタDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_id.ToLower(), PROPERTY_NAME_id);
                map.put(DB_NAME_従業員番号.ToLower(), PROPERTY_NAME_従業員番号);
                map.put(DB_NAME_氏名_姓.ToLower(), PROPERTY_NAME_氏名_姓);
                map.put(DB_NAME_氏名_名.ToLower(), PROPERTY_NAME_氏名_名);
                map.put(DB_NAME_氏名_カナ.ToLower(), PROPERTY_NAME_氏名_カナ);
                map.put(DB_NAME_メールアドレス.ToLower(), PROPERTY_NAME_メールアドレス);
                map.put(DB_NAME_パスワード.ToLower(), PROPERTY_NAME_パスワード);
                map.put(DB_NAME_生年月日.ToLower(), PROPERTY_NAME_生年月日);
                map.put(DB_NAME_入社年月日.ToLower(), PROPERTY_NAME_入社年月日);
                map.put(DB_NAME_退社年月日.ToLower(), PROPERTY_NAME_退社年月日);
                map.put(DB_NAME_職位コード.ToLower(), PROPERTY_NAME_職位コード);
                map.put(DB_NAME_最終ログイン日時.ToLower(), PROPERTY_NAME_最終ログイン日時);
                map.put(DB_NAME_備考.ToLower(), PROPERTY_NAME_備考);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_id.ToLower(), DB_NAME_id);
                map.put(PROPERTY_NAME_従業員番号.ToLower(), DB_NAME_従業員番号);
                map.put(PROPERTY_NAME_氏名_姓.ToLower(), DB_NAME_氏名_姓);
                map.put(PROPERTY_NAME_氏名_名.ToLower(), DB_NAME_氏名_名);
                map.put(PROPERTY_NAME_氏名_カナ.ToLower(), DB_NAME_氏名_カナ);
                map.put(PROPERTY_NAME_メールアドレス.ToLower(), DB_NAME_メールアドレス);
                map.put(PROPERTY_NAME_パスワード.ToLower(), DB_NAME_パスワード);
                map.put(PROPERTY_NAME_生年月日.ToLower(), DB_NAME_生年月日);
                map.put(PROPERTY_NAME_入社年月日.ToLower(), DB_NAME_入社年月日);
                map.put(PROPERTY_NAME_退社年月日.ToLower(), DB_NAME_退社年月日);
                map.put(PROPERTY_NAME_職位コード.ToLower(), DB_NAME_職位コード);
                map.put(PROPERTY_NAME_最終ログイン日時.ToLower(), DB_NAME_最終ログイン日時);
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
        public override String EntityTypeName { get { return "Dbflute.ExEntity.Mst従業員マスタ"; } }
        public override String DaoTypeName { get { return "Dbflute.ExDao.Mst従業員マスタDao"; } }
        public override String ConditionBeanTypeName { get { return "Dbflute.CBean.Mst従業員マスタCB"; } }
        public override String BehaviorTypeName { get { return "Dbflute.ExBhv.Mst従業員マスタBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Mst従業員マスタ NewMyEntity() { return new Mst従業員マスタ(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public Mst従業員マスタCB NewMyConditionBean() { return new Mst従業員マスタCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Mst従業員マスタ>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Mst従業員マスタ>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("id", "Id", new EntityPropertyIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("従業員番号", "従業員番号", new EntityProperty従業員番号Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("氏名_姓", "氏名姓", new EntityProperty氏名姓Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("氏名_名", "氏名名", new EntityProperty氏名名Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("氏名_カナ", "氏名カナ", new EntityProperty氏名カナSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("メールアドレス", "メールアドレス", new EntityPropertyメールアドレスSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("パスワード", "パスワード", new EntityPropertyパスワードSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("生年月日", "生年月日", new EntityProperty生年月日Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("入社年月日", "入社年月日", new EntityProperty入社年月日Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("退社年月日", "退社年月日", new EntityProperty退社年月日Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("職位コード", "職位コード", new EntityProperty職位コードSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("最終ログイン日時", "最終ログイン日時", new EntityProperty最終ログイン日時Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("備考", "備考", new EntityProperty備考Setupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Mst従業員マスタ> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Mst従業員マスタ)entity, value);
        }

        public class EntityPropertyIdSetupper : EntityPropertySetupper<Mst従業員マスタ> {
            public void Setup(Mst従業員マスタ entity, Object value) { entity.Id = (value != null) ? (long?)value : null; }
        }
        public class EntityProperty従業員番号Setupper : EntityPropertySetupper<Mst従業員マスタ> {
            public void Setup(Mst従業員マスタ entity, Object value) { entity.従業員番号 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty氏名姓Setupper : EntityPropertySetupper<Mst従業員マスタ> {
            public void Setup(Mst従業員マスタ entity, Object value) { entity.氏名姓 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty氏名名Setupper : EntityPropertySetupper<Mst従業員マスタ> {
            public void Setup(Mst従業員マスタ entity, Object value) { entity.氏名名 = (value != null) ? (String)value : null; }
        }
        public class EntityProperty氏名カナSetupper : EntityPropertySetupper<Mst従業員マスタ> {
            public void Setup(Mst従業員マスタ entity, Object value) { entity.氏名カナ = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyメールアドレスSetupper : EntityPropertySetupper<Mst従業員マスタ> {
            public void Setup(Mst従業員マスタ entity, Object value) { entity.メールアドレス = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyパスワードSetupper : EntityPropertySetupper<Mst従業員マスタ> {
            public void Setup(Mst従業員マスタ entity, Object value) { entity.パスワード = (value != null) ? (String)value : null; }
        }
        public class EntityProperty生年月日Setupper : EntityPropertySetupper<Mst従業員マスタ> {
            public void Setup(Mst従業員マスタ entity, Object value) { entity.生年月日 = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityProperty入社年月日Setupper : EntityPropertySetupper<Mst従業員マスタ> {
            public void Setup(Mst従業員マスタ entity, Object value) { entity.入社年月日 = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityProperty退社年月日Setupper : EntityPropertySetupper<Mst従業員マスタ> {
            public void Setup(Mst従業員マスタ entity, Object value) { entity.退社年月日 = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityProperty職位コードSetupper : EntityPropertySetupper<Mst従業員マスタ> {
            public void Setup(Mst従業員マスタ entity, Object value) { entity.職位コード = (value != null) ? (String)value : null; }
        }
        public class EntityProperty最終ログイン日時Setupper : EntityPropertySetupper<Mst従業員マスタ> {
            public void Setup(Mst従業員マスタ entity, Object value) { entity.最終ログイン日時 = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityProperty備考Setupper : EntityPropertySetupper<Mst従業員マスタ> {
            public void Setup(Mst従業員マスタ entity, Object value) { entity.備考 = (value != null) ? (String)value : null; }
        }
    }
}
