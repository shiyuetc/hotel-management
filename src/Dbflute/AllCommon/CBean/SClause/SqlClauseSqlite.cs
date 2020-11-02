
using System;

namespace Dbflute.AllCommon.CBean.SClause {

[System.Serializable]
public class SqlClauseSqlite : AbstractSqlClause {

    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    protected String _fetchScopeSqlSuffix = "";
    protected String _lockSqlSuffix = "";

    // ===================================================================================
    //                                                                         Constructor
    //                                                                         ===========
    public SqlClauseSqlite(String tableName)
        : base(tableName) {}

    // ===================================================================================
    //                                                                    OrderBy Override
    //                                                                    ================
	protected override OrderByNullsSetupper createOrderByNullsSetupper() {
	    return new OrderByNullsSetupperByCaseWhen();
	}

    // ===================================================================================
    //                                                                 FetchScope Override
    //                                                                 ===================
	protected override void doFetchFirst() {
        doFetchPage();
    }

    protected override void doFetchPage() {
        _fetchScopeSqlSuffix = " limit " + this.getFetchSize() + " offset " + this.getPageStartIndex();
    }

    protected override void doClearFetchPageClause() {
        _fetchScopeSqlSuffix = "";
    }

    // ===================================================================================
    //                                                                       Lock Override
    //                                                                       =============
    public override SqlClause lockForUpdate() {
        _lockSqlSuffix = " for update";
        return this;
    }

    // ===================================================================================
    //                                                                       Hint Override
    //                                                                       =============
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
        return _fetchScopeSqlSuffix + _lockSqlSuffix;
    }
}
	
}
