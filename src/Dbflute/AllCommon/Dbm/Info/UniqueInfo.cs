
using System;

using Dbflute.AllCommon.Dbm;
using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.Dbm.Info {

    public class UniqueInfo {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected DBMeta dbmeta;
        protected List<ColumnInfo> uniqueColumnList;
        protected bool primary;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public UniqueInfo(DBMeta dbmeta, List<ColumnInfo> uniqueColumnList, bool primary) {
            AssertObjectNotNull("dbmeta", dbmeta);
            AssertObjectNotNull("uniqueColumnList", uniqueColumnList);
            this.dbmeta = dbmeta;
            this.uniqueColumnList = uniqueColumnList;
            this.primary = primary;
        }

        // ===============================================================================
        //                                                                     Easy-to-Use
        //                                                                     ===========
        public bool ContainsColumn(ColumnInfo columnInfo) {
            return ContainsColumn(columnInfo.ColumnDbName);
        }

        protected bool ContainsColumn(String columnName) {
            foreach (ColumnInfo columnInfo in uniqueColumnList) {
                if (columnInfo.ColumnDbName.Equals(columnName)) {
                    return true;
                }
            }
            return false;
        }

        // ===============================================================================
        //                                                                  General Helper
        //                                                                  ==============
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
        //                                                                        Accessor
        //                                                                        ========
       public DBMeta DBMeta {
           get { return dbmeta; }
       }

        public List<ColumnInfo> UniqueColumnList {
            get { return uniqueColumnList; }
        }

        public ColumnInfo FirstColumn {
            get { return (ColumnInfo)this.uniqueColumnList.get(0); }
        }

        public bool IsTwoOrMore {
            get { return this.uniqueColumnList.size() > 1; }
        }

        public bool IsPrimary {
            get { return this.primary; }
        }
    }
}
