
using System;
using System.Collections.Generic;
using System.Threading;

namespace Dbflute.AllCommon.S2Dao.Internal.SqlLog {

    public class InternalSqlLogRegistry {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        private static readonly int DEFAULT_LIMIT_SIZE = 3;

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        [ThreadStatic]
        private LinkedList<InternalSqlLog> _sqlLogList = new LinkedList<InternalSqlLog>();
        private int limitSize;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public InternalSqlLogRegistry() {
            this.limitSize = DEFAULT_LIMIT_SIZE;
        }

        public InternalSqlLogRegistry(int limitSize) {
            this.limitSize = limitSize;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public int LimitSize { get {
            return limitSize;
        }}

        public int Size { get {
            return SqlLogList.Count;
        }}

        public bool IsEmpty { get {
            return Size == 0;
        }}

        public InternalSqlLog Last { get {
            return IsEmpty ? null : SqlLogList.Last.Value;
        }}

        public void Add(InternalSqlLog sqlLog) {
            if (limitSize <= 0) {
                return;
            }
            LinkedList<InternalSqlLog> list = SqlLogList;
            list.AddLast(sqlLog);
            if (list.Count > limitSize) {
                list.RemoveFirst();
            }
        }

        public void Clear() {
            SqlLogList.Clear();
        }

        public LinkedList<InternalSqlLog> SqlLogList { get {
            return _sqlLogList;
        }}
    }
}
