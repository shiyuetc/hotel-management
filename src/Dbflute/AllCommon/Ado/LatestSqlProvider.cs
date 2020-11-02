
using System;
using System.Collections.Generic;

using Seasar.Quill.Attrs;

using Dbflute.AllCommon.S2Dao;

namespace Dbflute.AllCommon.Ado {

    [Implementation(typeof(SqlLogRegistryLatestSqlProvider))]
    public interface LatestSqlProvider {
        String GetDisplaySql();
        IList<String> ExtractDisplaySqlList();
	    void ClearSqlCache();
    }
}
