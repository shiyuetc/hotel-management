
using System;
using System.Reflection;

using Dbflute.AllCommon.Dbm;
using Dbflute.AllCommon.JavaLike;
using Dbflute.AllCommon.Util;

namespace Dbflute.AllCommon.Dbm.Info {

    public class ReferrerInfo : RelationInfo {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected String referrerPropertyName;
        protected DBMeta localDBMeta;
        protected DBMeta referrerDBMeta;
        protected Map<ColumnInfo, ColumnInfo> localReferrerColumnInfoMap;
        protected Map<ColumnInfo, ColumnInfo> referrerLocalColumnInfoMap;
        protected bool oneToOne;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public ReferrerInfo(String referrerPropertyName, DBMeta localDBMeta, DBMeta referrerDBMeta
                          , Map<ColumnInfo, ColumnInfo> localReferrerColumnInfoMap
                          , bool oneToOne) {
            AssertObjectNotNull("referrerPropertyName", referrerPropertyName);
            AssertObjectNotNull("localDBMeta", localDBMeta);
            AssertObjectNotNull("referrerDBMeta", referrerDBMeta);
            AssertObjectNotNull("localReferrerColumnInfoMap", localReferrerColumnInfoMap);
            this.referrerPropertyName = referrerPropertyName;
            this.localDBMeta = localDBMeta;
            this.referrerDBMeta = referrerDBMeta;
            this.localReferrerColumnInfoMap = localReferrerColumnInfoMap;
            Set<ColumnInfo> keySet = localReferrerColumnInfoMap.keySet();
            referrerLocalColumnInfoMap = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            foreach (ColumnInfo key in localReferrerColumnInfoMap.keySet()) {
                ColumnInfo value = localReferrerColumnInfoMap.get(key);
                referrerLocalColumnInfoMap.put(value, key);
            }
            this.oneToOne = oneToOne;
        }

        // ===============================================================================
        //                                                                          Finder
        //                                                                          ======
        public ColumnInfo FindLocalByReferrer(String referrerColumnDbName) {
            ColumnInfo keyColumnInfo = referrerDBMeta.FindColumnInfo(referrerColumnDbName);
            ColumnInfo resultColumnInfo = (ColumnInfo)referrerLocalColumnInfoMap.get(keyColumnInfo);
            if (resultColumnInfo == null) {
                String msg = "Not found by referrerColumnDbName in referrerLocalColumnInfoMap:";
                msg = msg + " referrerColumnDbName=" + referrerColumnDbName + " referrerLocalColumnInfoMap=" + referrerLocalColumnInfoMap;
                throw new ArgumentException(msg);
            }
            return resultColumnInfo;
        }

        public ColumnInfo FindReferrerByLocal(String localColumnDbName) {
            ColumnInfo keyColumnInfo = localDBMeta.FindColumnInfo(localColumnDbName);
            ColumnInfo resultColumnInfo = (ColumnInfo)localReferrerColumnInfoMap.get(keyColumnInfo);
            if (resultColumnInfo == null) {
                String msg = "Not found by localColumnDbName in localReferrerColumnInfoMap:";
                msg = msg + " localColumnDbName=" + localColumnDbName + " localReferrerColumnInfoMap=" + localReferrerColumnInfoMap;
                throw new ArgumentException(msg);
            }
            return resultColumnInfo;
        }

        public PropertyInfo FindAccessor() {
            return FindProperty(localDBMeta.EntityType, BuildInitCapPropertyName(), new Type[] { typeof(System.Collections.Generic.IList<>) });
        }

        // ===============================================================================
        //                                                                         Builder
        //                                                                         =======
        public String BuildInitCapPropertyName() {
            return InitCap(this.referrerPropertyName);
        }
        
        // ===============================================================================
        //                                                                  General Helper
        //                                                                  ==============
        protected static String InitCap(String str) {
            return SimpleStringUtil.InitCap(str);
        }

        protected static PropertyInfo FindProperty(Type clazz, String propertyName, Type[] argTypes) {
            return clazz.GetProperty(propertyName, argTypes);
        }
        
        protected void AssertObjectNotNull(String variableName, Object value) {
            if (variableName == null) {
                String msg = "The value should not be null: variableName=" + variableName + " value=" + value;
                throw new ArgumentException(msg);
            }
            if (value == null) {
                String msg = "The value should not be null: variableName=" + variableName;
                throw new ArgumentException(msg);
            }
        }

        // ===============================================================================
        //                                                                       Implement
        //                                                                       =========
        public String RelationPropertyName {
            get { return ReferrerPropertyName; }
        }

        public DBMeta TargetDBMeta {
            get { return ReferrerDBMeta; }
        }

        public Map<ColumnInfo, ColumnInfo> LocalTargetColumnInfoMap {
            get { return LocalReferrerColumnInfoMap; }
        }

        public bool IsReferrer {
            get { return true; }
        }

        // ===============================================================================
        //                                                                  Basic Override
        //                                                                  ==============
        public override String ToString() {
            return localDBMeta.TableDbName + "." + referrerPropertyName + "->" + referrerDBMeta.TableDbName;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public String ReferrerPropertyName {
            get { return referrerPropertyName; }
        }

        public DBMeta LocalDBMeta {
            get { return localDBMeta; }
        }

        public DBMeta ReferrerDBMeta {
            get { return referrerDBMeta; }
        }

        public Map<ColumnInfo, ColumnInfo> LocalReferrerColumnInfoMap {
            get { return localReferrerColumnInfoMap; }
        }

        public Map<ColumnInfo, ColumnInfo> ReferrerLocalColumnInfoMap {
            get { return referrerLocalColumnInfoMap; }
        }

        public bool IsOneToOne {
            get { return oneToOne; }
        }
    }
}
