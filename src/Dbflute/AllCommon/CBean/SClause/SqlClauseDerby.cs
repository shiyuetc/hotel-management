
using System;

namespace Dbflute.AllCommon.CBean.SClause {

[System.Serializable]
public class SqlClauseDerby : AbstractSqlClause {

    protected String _lockSqlSuffix = "";

    public SqlClauseDerby(String tableName)
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
        _lockSqlSuffix = " for update";
        return this;
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
        return _lockSqlSuffix;
    }
}

}
