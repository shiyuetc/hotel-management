
using System;

using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.CBean.SClause {

[System.Serializable]
public class SqlClauseMsAccess : AbstractSqlClause {

    public SqlClauseMsAccess(String tableName)
        : base(tableName) {}

	protected override bool isJoinInParentheses() {
	    return true; // needs to join in parentheses at MS Access
	}

    public override void registerOuterJoin(String baseTableDbName, String joinTableDbName, String aliasName,
            Map<String, String> joinOnMap, String fixedCondition, FixedConditionResolver fixedConditionResolver) {
        base.registerOuterJoin(baseTableDbName, joinTableDbName, aliasName, joinOnMap, null, null);
        if (fixedCondition != null) {
            if (fixedConditionResolver != null) {
                fixedCondition = fixedConditionResolver.resolveVariable(fixedCondition);
            }
            String clause = replaceString(fixedCondition, aliasName + ".", "");
            registerOuterJoinInlineWhereClause(aliasName, clause, false);
        }
    }

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
