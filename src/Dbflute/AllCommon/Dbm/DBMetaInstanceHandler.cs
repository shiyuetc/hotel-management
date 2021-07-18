
using System;
using System.Reflection;

using Dbflute.AllCommon.JavaLike;
using Dbflute.AllCommon.Util;

namespace Dbflute.AllCommon.Dbm {

    public interface DBMetaProvider {
        DBMeta provideDBMeta(String tableFlexibleName);
        DBMeta provideDBMetaChecked(String tableFlexibleName);
    }

    public class DBMetaInstanceHandler : DBMetaProvider {

        // ===============================================================================
        //                                                                    Resource Map
        //                                                                    ============
        protected static readonly Map<String, DBMeta> _tableDbNameInstanceMap = new HashMap<String, DBMeta>();
        protected static readonly Map<String, String> _tableDbNameClassNameMap;
        protected static readonly Map<String, String> _tableDbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _tablePropertyNameDbNameKeyToLowerMap;

        static DBMetaInstanceHandler() {
            {
                Map<String, String> tmpMap = new HashMap<String, String>();
                tmpMap.put("dchその他予定台帳", "Dbflute.BsEntity.Dbm.Dchその他予定台帳Dbm");
                tmpMap.put("dchその他実績台帳", "Dbflute.BsEntity.Dbm.Dchその他実績台帳Dbm");
                tmpMap.put("dch客室利用予定台帳", "Dbflute.BsEntity.Dbm.Dch客室利用予定台帳Dbm");
                tmpMap.put("dch客室利用実績台帳", "Dbflute.BsEntity.Dbm.Dch客室利用実績台帳Dbm");
                tmpMap.put("dch宿泊予定台帳", "Dbflute.BsEntity.Dbm.Dch宿泊予定台帳Dbm");
                tmpMap.put("dch宿泊実績台帳", "Dbflute.BsEntity.Dbm.Dch宿泊実績台帳Dbm");
                tmpMap.put("dch従業員職位履歴台帳", "Dbflute.BsEntity.Dbm.Dch従業員職位履歴台帳Dbm");
                tmpMap.put("dch月締確定台帳", "Dbflute.BsEntity.Dbm.Dch月締確定台帳Dbm");
                tmpMap.put("dch清掃予定台帳", "Dbflute.BsEntity.Dbm.Dch清掃予定台帳Dbm");
                tmpMap.put("dch清掃実績台帳", "Dbflute.BsEntity.Dbm.Dch清掃実績台帳Dbm");
                tmpMap.put("kbn客室利用区分", "Dbflute.BsEntity.Dbm.Kbn客室利用区分Dbm");
                tmpMap.put("kbn権限区分", "Dbflute.BsEntity.Dbm.Kbn権限区分Dbm");
                tmpMap.put("kbn職位区分", "Dbflute.BsEntity.Dbm.Kbn職位区分Dbm");
                tmpMap.put("mst会員マスタ", "Dbflute.BsEntity.Dbm.Mst会員マスタDbm");
                tmpMap.put("mst客室タイプマスタ", "Dbflute.BsEntity.Dbm.Mst客室タイプマスタDbm");
                tmpMap.put("mst客室マスタ", "Dbflute.BsEntity.Dbm.Mst客室マスタDbm");
                tmpMap.put("mst従業員マスタ", "Dbflute.BsEntity.Dbm.Mst従業員マスタDbm");
                tmpMap.put("mst権限マスタ", "Dbflute.BsEntity.Dbm.Mst権限マスタDbm");
                _tableDbNameClassNameMap = tmpMap;//java.util.Collections.unmodifiableMap(tmpMap);
            }

            {
                Map<String, String> tmpMap = new HashMap<String, String>();
                tmpMap.put("dchその他予定台帳".ToLower(), "dchその他予定台帳");
                tmpMap.put("dchその他実績台帳".ToLower(), "dchその他実績台帳");
                tmpMap.put("dch客室利用予定台帳".ToLower(), "dch客室利用予定台帳");
                tmpMap.put("dch客室利用実績台帳".ToLower(), "dch客室利用実績台帳");
                tmpMap.put("dch宿泊予定台帳".ToLower(), "dch宿泊予定台帳");
                tmpMap.put("dch宿泊実績台帳".ToLower(), "dch宿泊実績台帳");
                tmpMap.put("dch従業員職位履歴台帳".ToLower(), "dch従業員職位履歴台帳");
                tmpMap.put("dch月締確定台帳".ToLower(), "dch月締確定台帳");
                tmpMap.put("dch清掃予定台帳".ToLower(), "dch清掃予定台帳");
                tmpMap.put("dch清掃実績台帳".ToLower(), "dch清掃実績台帳");
                tmpMap.put("kbn客室利用区分".ToLower(), "kbn客室利用区分");
                tmpMap.put("kbn権限区分".ToLower(), "kbn権限区分");
                tmpMap.put("kbn職位区分".ToLower(), "kbn職位区分");
                tmpMap.put("mst会員マスタ".ToLower(), "mst会員マスタ");
                tmpMap.put("mst客室タイプマスタ".ToLower(), "mst客室タイプマスタ");
                tmpMap.put("mst客室マスタ".ToLower(), "mst客室マスタ");
                tmpMap.put("mst従業員マスタ".ToLower(), "mst従業員マスタ");
                tmpMap.put("mst権限マスタ".ToLower(), "mst権限マスタ");
                _tableDbNamePropertyNameKeyToLowerMap = tmpMap;//java.util.Collections.unmodifiableMap(tmpMap);
            }

            {
                Map<String, String> tmpMap = new HashMap<String, String>();
                tmpMap.put("Dchその他予定台帳".ToLower(), "dchその他予定台帳");
                tmpMap.put("Dchその他実績台帳".ToLower(), "dchその他実績台帳");
                tmpMap.put("Dch客室利用予定台帳".ToLower(), "dch客室利用予定台帳");
                tmpMap.put("Dch客室利用実績台帳".ToLower(), "dch客室利用実績台帳");
                tmpMap.put("Dch宿泊予定台帳".ToLower(), "dch宿泊予定台帳");
                tmpMap.put("Dch宿泊実績台帳".ToLower(), "dch宿泊実績台帳");
                tmpMap.put("Dch従業員職位履歴台帳".ToLower(), "dch従業員職位履歴台帳");
                tmpMap.put("Dch月締確定台帳".ToLower(), "dch月締確定台帳");
                tmpMap.put("Dch清掃予定台帳".ToLower(), "dch清掃予定台帳");
                tmpMap.put("Dch清掃実績台帳".ToLower(), "dch清掃実績台帳");
                tmpMap.put("Kbn客室利用区分".ToLower(), "kbn客室利用区分");
                tmpMap.put("Kbn権限区分".ToLower(), "kbn権限区分");
                tmpMap.put("Kbn職位区分".ToLower(), "kbn職位区分");
                tmpMap.put("Mst会員マスタ".ToLower(), "mst会員マスタ");
                tmpMap.put("Mst客室タイプマスタ".ToLower(), "mst客室タイプマスタ");
                tmpMap.put("Mst客室マスタ".ToLower(), "mst客室マスタ");
                tmpMap.put("Mst従業員マスタ".ToLower(), "mst従業員マスタ");
                tmpMap.put("Mst権限マスタ".ToLower(), "mst権限マスタ");
                _tablePropertyNameDbNameKeyToLowerMap = tmpMap;//java.util.Collections.unmodifiableMap(tmpMap);
            }
        }

        protected static DBMeta GetDBMeta(String className) {
			Type clazz = ForName(className, AppDomain.CurrentDomain.GetAssemblies());
            if (clazz == null) {
                String msg = "The className was not found: " + className + " assemblys=";
                msg = msg + Seasar.Framework.Util.ToStringUtil.ToString(AppDomain.CurrentDomain.GetAssemblies());
                throw new SystemException(msg);
            }
            System.Reflection.MethodInfo method = clazz.GetMethod("GetInstance");
            return (DBMeta)method.Invoke(null, null);
        }

        protected static Type ForName(string className, Assembly[] assemblys) {
            Type type = Type.GetType(className);
            if(type != null) return type;
            foreach(Assembly assembly in assemblys) {
                type = assembly.GetType(className);
                if(type != null) return type;
            }
            return type;
        }

        // Returns the unmodifiable map that contains all instances of DB meta. (NotNull & NotEmpty)
        public static Map<String, DBMeta> GetUnmodifiableDBMetaMap() {
            InitializeDBMetaMap();
            lock (_tableDbNameInstanceMap) {
                Map<String, DBMeta> copiedMap = new HashMap<String, DBMeta>();
                foreach (String tableDbName in _tableDbNameInstanceMap.keySet()) {
                    copiedMap.put(tableDbName, _tableDbNameInstanceMap.get(tableDbName));
                }
                return copiedMap;
            }
        }

        protected static void InitializeDBMetaMap() {
            if (IsInitialized) {
                return;
            }
            lock (_tableDbNameInstanceMap) {
                Set<String> tableDbNameSet = _tableDbNameClassNameMap.keySet();
                foreach (String tableDbName in tableDbNameSet) {
                    FindDBMeta(tableDbName); // Initialize!
                }
                if (!IsInitialized) {
                    String msg = "Failed to initialize tableDbNameInstanceMap:";
                    msg = msg + " tableDbNameInstanceMap=" + _tableDbNameInstanceMap;
                    throw new IllegalStateException(msg);
                }
            }
        }

        protected static bool IsInitialized { get {
            return _tableDbNameInstanceMap.size() == _tableDbNameClassNameMap.size();
        }}

        // ===============================================================================
        //                                                              Provider Singleton
        //                                                              ==================
        protected static readonly DBMetaProvider _provider = new DBMetaInstanceHandler();

        public static DBMetaProvider getProvider() {
            return _provider;
        }

        public DBMeta provideDBMeta(String tableFlexibleName) {
            return ByTableFlexibleName(tableFlexibleName);
        }

        public DBMeta provideDBMetaChecked(String tableFlexibleName) {
            return FindDBMeta(tableFlexibleName);
        }

        // ===============================================================================
        //                                                                     Find DBMeta
        //                                                                     ===========
        public static DBMeta FindDBMeta(String tableFlexibleName) { // accept quoted name and schema prefix
            DBMeta dbmeta = ByTableFlexibleName(tableFlexibleName);
            if (dbmeta == null) {
                String msg = "The DB meta was not found by the table flexible name: " + tableFlexibleName;
                msg = msg + " key=" + tableFlexibleName + " instanceMap=" + _tableDbNameInstanceMap;
                throw new DBMetaNotFoundException(msg);
            }
            return dbmeta;
        }

        // ===============================================================================
        //                                                                   By Table Name
        //                                                                   =============
        protected static DBMeta ByTableFlexibleName(String tableFlexibleName) {
            AssertStringNotNullAndNotTrimmedEmpty("tableFlexibleName", tableFlexibleName);
            tableFlexibleName = RemoveSchemaIfExists(tableFlexibleName);
            tableFlexibleName = RemoveQuoteIfExists(tableFlexibleName);
            if (_tableDbNameInstanceMap.containsKey(tableFlexibleName)) {
                return ByTableDbName(tableFlexibleName);
            }
            String toLowerKey = tableFlexibleName.ToLower();
            if (_tableDbNamePropertyNameKeyToLowerMap.containsKey(toLowerKey)) {
                String propertyName = (String)_tableDbNamePropertyNameKeyToLowerMap.get(toLowerKey);
                String dbName = (String)_tablePropertyNameDbNameKeyToLowerMap.get(propertyName.ToLower());
                return ByTableDbName(dbName);
            }
            if (_tablePropertyNameDbNameKeyToLowerMap.containsKey(toLowerKey)) {
                String dbName = (String)_tablePropertyNameDbNameKeyToLowerMap.get(toLowerKey);
                return ByTableDbName(dbName);
            }
            return null;
        }

        protected static String RemoveSchemaIfExists(String name) {
            int dotLastIndex = name.LastIndexOf(".");
            if (dotLastIndex >= 0) {
                name = name.Substring(dotLastIndex + 1);
            }
            return name;
        }

        protected static String RemoveQuoteIfExists(String name) {
            if (name.StartsWith("\"") && name.EndsWith("\"")) {
                name = name.Substring(1);
                name = name.Substring(0, name.Length - 1);
            } else if (name.StartsWith("[") && name.EndsWith("]")) {
                name = name.Substring(1);
                name = name.Substring(0, name.Length - 1);
            }
            return name;
        }

        protected static DBMeta ByTableDbName(String tableDbName) {
            AssertStringNotNullAndNotTrimmedEmpty("tableDbName", tableDbName);
            return GetCachedDBMeta(tableDbName);
        }

        // ===============================================================================
        //                                                                   Cached DBMeta
        //                                                                   =============
        protected static DBMeta GetCachedDBMeta(String tableDbName) { // lazy-load (thank you koyak!)
            DBMeta dbmeta = _tableDbNameInstanceMap.get(tableDbName);
            if (dbmeta != null) {
                return dbmeta;
            }
            lock (_tableDbNameInstanceMap) {
                dbmeta = _tableDbNameInstanceMap.get(tableDbName);
                if (dbmeta != null) {
                    return dbmeta;
                }
                String entityName = _tableDbNameClassNameMap.get(tableDbName);
                _tableDbNameInstanceMap.put(tableDbName, GetDBMeta(entityName));
                return _tableDbNameInstanceMap.get(tableDbName);
            }
        }

        // ===============================================================================
        //                                                                  General Helper
        //                                                                  ==============
        // -------------------------------------------------
        //                                     Assert Object
        //                                     -------------
        protected static void AssertObjectNotNull(String variableName, Object value) {
		    SimpleAssertUtil.AssertObjectNotNull(variableName, value);
        }

        // -------------------------------------------------
        //                                     Assert String
        //                                     -------------
        protected static void AssertStringNotNullAndNotTrimmedEmpty(String variableName, String value) {
            SimpleAssertUtil.AssertStringNotNullAndNotTrimmedEmpty(variableName, value);
        }
    }

    public class DBMetaNotFoundException : SystemException {

        public DBMetaNotFoundException(String msg)
        : base(msg) {}
    }
}
