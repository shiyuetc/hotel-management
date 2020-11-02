
using System;

using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.COption;
using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.CBean.CKey {

public abstract class ConditionKeyNotEqual : ConditionKey {

    private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public ConditionKeyNotEqual() {
        _conditionKey = "notEqual";
        _operand = defineOperand();
    }

    protected abstract String defineOperand();

    public override bool isValidRegistration(ConditionValue conditionValue, Object value, String callerName) {
        if (value == null) {
            return false;
        }
        if (conditionValue.HasNotEqual) {
            if (conditionValue.EqualNotEqual(value)) {
                _log.Debug("The value has already registered at " + callerName + ": value=" + value);
                return false;
            } else {
                conditionValue.OverrideNotEqual(value);
                return false;
            }
        }
        return true;
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, ConditionValue value) {
        if (value.NotEqual == null) {
            return;
        }
        Object valueObject = value.NotEqual;
        conditionList.add(buildBindClause(columnName, value.getNotEqualLocation()));
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, ConditionValue value, ConditionOption option) {
        throw new UnsupportedOperationException("doAddWhereClause with condition-option is unsupported!!!");
    }

    protected override void doSetupConditionValue(ConditionValue conditionValue, Object value, String location) {
        conditionValue.NotEqual = value;
        conditionValue.setNotEqualLocation(location);
    }

    protected override void doSetupConditionValue(ConditionValue conditionValue, Object value, String location, ConditionOption option) {
        throw new UnsupportedOperationException("doSetupConditionValue with condition-option is unsupported!!!");
    }
}
	
}
