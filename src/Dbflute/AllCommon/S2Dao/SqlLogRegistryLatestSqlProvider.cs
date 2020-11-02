
using System;
using System.Collections.Generic;

using Dbflute.AllCommon.Ado;
using Dbflute.AllCommon.S2Dao.Internal.SqlLog;

namespace Dbflute.AllCommon.S2Dao {

    public class SqlLogRegistryLatestSqlProvider : LatestSqlProvider {

        public String GetDisplaySql() {
            return GetLastCompleteSql();
        }

        protected String GetLastCompleteSql() {
            try {
                InternalSqlLogRegistry sqlLogRegistry = FindInternalSqlLogRegistry();
                if (sqlLogRegistry == null) {
                    return null;
                }
                InternalSqlLog sqlLog = sqlLogRegistry.Last;
                if (sqlLog == null) {
                    return null;
                }
                return sqlLog.CompleteSql;
            } catch (Exception) {
                return null;
            }
        }

        public IList<String> ExtractDisplaySqlList() {
            InternalSqlLogRegistry sqlLogRegistry = FindInternalSqlLogRegistry();
            if (sqlLogRegistry == null) {
                return new List<String>();
            }
	        IList<String> sqlList = new List<String>();
	        foreach (InternalSqlLog sqlLog in sqlLogRegistry.SqlLogList) {
	            sqlList.Add(sqlLog.CompleteSql);
	        }
	        return sqlList;
	    }

    	public void ClearSqlCache() {
            InternalSqlLogRegistry sqlLogRegistry = FindInternalSqlLogRegistry();
            if (sqlLogRegistry == null) {
                return;
            }
            sqlLogRegistry.Clear();
        }

    	protected InternalSqlLogRegistry FindInternalSqlLogRegistry() {
            return InternalSqlLogRegistryLocator.Instance;
        }
    }
}
