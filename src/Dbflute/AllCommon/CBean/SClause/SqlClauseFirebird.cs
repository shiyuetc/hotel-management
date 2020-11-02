
using System;

namespace Dbflute.AllCommon.CBean.SClause {

[System.Serializable]
public class SqlClauseFirebird : AbstractSqlClause {

    protected String _fetchScopeSelectHint = "";
    protected String _lockSqlSuffix = "";

    public SqlClauseFirebird(String tableName)
        : base(tableName) {}

    protected override void doFetchFirst() {
        if (this.isFetchSizeSupported()) {
            _fetchScopeSelectHint = " first " + this.getFetchSize();
        }
    }

    protected override void doFetchPage() {
        if (this.isFetchStartIndexSupported() && this.isFetchSizeSupported()) {
            _fetchScopeSelectHint = " first " + this.getFetchSize() + " skip " + this.getPageStartIndex();
        }
        if (this.isFetchStartIndexSupported() && !this.isFetchSizeSupported()) {
            _fetchScopeSelectHint = " skip " + this.getPageStartIndex();
        }
        if (!this.isFetchStartIndexSupported() && this.isFetchSizeSupported()) {
            _fetchScopeSelectHint = " first " + this.getPageEndIndex();
        }
    }

    protected override void doClearFetchPageClause() {
        _fetchScopeSelectHint = "";
    }

    public override SqlClause lockForUpdate() {
        _lockSqlSuffix = " for update with lock";
        return this;
    }

    protected override String createSelectHint() {
        return _fetchScopeSelectHint;
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
