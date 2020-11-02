
using System;

using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.CBean.SClause {

[System.Serializable]
public class SqlClauseDefault : AbstractSqlClause {

    public SqlClauseDefault(String tableName)
        : base(tableName) {}

	protected override OrderByNullsSetupper createOrderByNullsSetupper() {
	    return new OrderByNullsSetupperByCaseWhen();
	}
	
    protected override void doFetchFirst() {
    }

    protected override void doFetchPage() {
    }

    protected override void doClearFetchPageClause() {
    }

    public override bool isFetchStartIndexSupported() {
        return false; // Default
    }

    public override bool isFetchSizeSupported() {
        return false; // Default
    }

    public override SqlClause lockForUpdate() {
        String msg = "LockForUpdate-SQL is unsupported in the database. Sorry...: " + ToString();
        throw new UnsupportedOperationException(msg);
    }

    protected override String createSelectHint() {
        return "";
    }

    protected override String createFromBaseTableHint() {
        return "";
    }

    protected override String createFromHint() {
        return "";
    }

    protected override String createSqlSuffix() {
        return "";
    }
}

}
