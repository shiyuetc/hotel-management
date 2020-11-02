
using System;
using System.Reflection;

using Dbflute.AllCommon.Dbm;
using Dbflute.AllCommon.JavaLike;
using Dbflute.AllCommon.Util;

namespace Dbflute.AllCommon.Dbm.Info {

    public class ForeignInfo : RelationInfo {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected String _foreignPropertyName;
        protected DBMeta _localDBMeta;
        protected DBMeta _foreignDBMeta;
        protected Map<ColumnInfo, ColumnInfo> _localForeignColumnInfoMap;
        protected Map<ColumnInfo, ColumnInfo> _foreignLocalColumnInfoMap;
        protected int _relationNo;
        protected bool _oneToOne;
        protected bool _bizOneToOne;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public ForeignInfo(String foreignPropertyName, DBMeta localDBMeta, DBMeta foreignDBMeta
                         , Map<ColumnInfo, ColumnInfo> localForeignColumnInfoMap
                         , int relationNo, bool oneToOne, bool bizOneToOne) {
            AssertObjectNotNull("foreignPropertyName", foreignPropertyName);
            AssertObjectNotNull("localDBMeta", localDBMeta);
            AssertObjectNotNull("foreignDBMeta", foreignDBMeta);
            AssertObjectNotNull("localForeignColumnInfoMap", localForeignColumnInfoMap);
            _foreignPropertyName = foreignPropertyName;
            _localDBMeta = localDBMeta;
            _foreignDBMeta = foreignDBMeta;
            _localForeignColumnInfoMap = localForeignColumnInfoMap;
            Set<ColumnInfo> keySet = localForeignColumnInfoMap.keySet();
            _foreignLocalColumnInfoMap = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            foreach (ColumnInfo key in localForeignColumnInfoMap.keySet()) {
                ColumnInfo value = localForeignColumnInfoMap.get(key);
                _foreignLocalColumnInfoMap.put(value, key);
            }
            _relationNo = relationNo;
            _oneToOne = oneToOne;
            _bizOneToOne = bizOneToOne;
        }
        
        // ===============================================================================
        //                                                                          Finder
        //                                                                          ======
        public ColumnInfo FindLocalByForeign(String foreignColumnDbName) {
            ColumnInfo keyColumnInfo = _foreignDBMeta.FindColumnInfo(foreignColumnDbName);
            ColumnInfo resultColumnInfo = _foreignLocalColumnInfoMap.get(keyColumnInfo);
            if (resultColumnInfo == null) {
                String msg = "Not found by foreignColumnDbName in _foreignLocalColumnInfoMap:";
                msg = msg + " foreignColumnDbName=" + foreignColumnDbName + " foreignLocalColumnInfoMap=" + _foreignLocalColumnInfoMap;
                throw new ArgumentException(msg);
            }
            return resultColumnInfo;
        }

        public PropertyInfo FindAccessor() {
            return FindProperty(_localDBMeta.EntityType, BuildInitCapPropertyName(), new Type[] { typeof(System.Collections.Generic.IList<>) });
        }

        // ===============================================================================
        //                                                                         Builder
        //                                                                         =======
        public String BuildInitCapPropertyName() {
            return InitCap(_foreignPropertyName);
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
            get { return ForeignPropertyName; }
        }

        public DBMeta TargetDBMeta {
            get { return ForeignDBMeta; }
        }

        public Map<ColumnInfo, ColumnInfo> LocalTargetColumnInfoMap {
            get { return LocalForeignColumnInfoMap; }
        }

        public bool IsReferrer {
            get { return false; }
        }

        // ===============================================================================
        //                                                                  Basic Override
        //                                                                  ==============
        public override int GetHashCode() {
            return _foreignPropertyName.GetHashCode() + _localDBMeta.GetHashCode() + _foreignDBMeta.GetHashCode();
        }

        public override bool Equals(Object obj) {
            if (obj == null || !(obj is ForeignInfo)) {
                return false;
            }
            ForeignInfo target = (ForeignInfo) obj;
            if (!this._foreignPropertyName.Equals(target.ForeignPropertyName)) {
                return false;
            }
            if (!this._localDBMeta.Equals(target.LocalDBMeta)) {
                return false;
            }
            if (!this._foreignDBMeta.Equals(target.ForeignDBMeta)) {
                return false;
            }
            return true;
        }

        public override String ToString() {
            return _localDBMeta.TableDbName + "." + _foreignPropertyName + "->" + _foreignDBMeta.TableDbName;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public String ForeignPropertyName {
            get { return _foreignPropertyName; }
        }

        public DBMeta LocalDBMeta {
            get { return _localDBMeta; }
        }

        public DBMeta ForeignDBMeta {
            get { return _foreignDBMeta; }
        }

        public Map<ColumnInfo, ColumnInfo> LocalForeignColumnInfoMap {
            get { return _localForeignColumnInfoMap; }
        }

        public Map<ColumnInfo, ColumnInfo> ForeignLocalColumnInfoMap {
            get { return _foreignLocalColumnInfoMap; }
        }

        public int RelationNo {
            get { return _relationNo; }
        }

        public bool IsOneToOne {
            get { return _oneToOne; }
        }

        public bool IsBizOneToOne {
            get { return _bizOneToOne; }
        }
    }
}
