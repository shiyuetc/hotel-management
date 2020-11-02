
using System;

using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.COption;
using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.CBean.CKey {

public class ConditionKeyIsNotNull : ConditionKey {

    private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public ConditionKeyIsNotNull() {
        _conditionKey = "isNotNull";
        _operand = "is not null";
    }

    public override bool isValidRegistration(ConditionValue conditionValue, Object value, String callerName) {
        if (conditionValue.HasIsNotNull) {
            _log.Debug("The value has already registered at " + _conditionKey + ": " + value);
            return false;
        }
        return true;
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, ConditionValue value) {
        if (value.IsNotNull == null) {
            return;
        }
        conditionList.add(buildClauseWithoutValue(columnName));
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, ConditionValue value, ConditionOption option) {
        throw new UnsupportedOperationException("doAddWhereClause that has ConditionOption is unsupported!!!");
    }

    protected override void doSetupConditionValue(ConditionValue conditionValue, Object value, String location) {
        conditionValue.IsNotNull = DUMMY_OBJECT;
        conditionValue.setIsNotNullLocation(location);
    }

    protected override void doSetupConditionValue(ConditionValue conditionValue, Object value, String location, ConditionOption option) {
        throw new UnsupportedOperationException("doSetupConditionValue with condition-option is unsupported!!!");
    }
}

}
