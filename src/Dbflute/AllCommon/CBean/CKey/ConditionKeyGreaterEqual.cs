
using System;

using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.COption;
using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.CBean.CKey {

public class ConditionKeyGreaterEqual : ConditionKey {

    private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public ConditionKeyGreaterEqual() {
        _conditionKey = "greaterEqual";
        _operand = ">=";
    }

    public override bool isValidRegistration(ConditionValue conditionValue, Object value, String callerName) {
        if (value == null) {
            return false;
        }
        if (conditionValue.HasGreaterEqual) {
            if (conditionValue.EqualGreaterEqual(value)) {
                _log.Debug("The value has already registered at " + callerName + ": value=" + value);
                return false;
            } else {
                conditionValue.OverrideGreaterEqual(value);
                return false;
            }
        }
        return true;
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, ConditionValue value) {
        if (value.GreaterEqual == null) {
            return;
        }
        Object valueObject = value.GreaterEqual;
        conditionList.add(buildBindClause(columnName, value.getGreaterEqualLocation()));
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, ConditionValue value, ConditionOption option) {
        throw new UnsupportedOperationException("doAddWhereClause that has ConditionOption is unsupported!!!");
    }

    protected override void doSetupConditionValue(ConditionValue conditionValue, Object value, String location) {
        conditionValue.GreaterEqual = value;
        conditionValue.setGreaterEqualLocation(location);
    }

    protected override void doSetupConditionValue(ConditionValue conditionValue, Object value, String location, ConditionOption option) {
        throw new UnsupportedOperationException("doSetupConditionValue with condition-option is unsupported!!!");
    }
}
	
}
