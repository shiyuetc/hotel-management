
using System;

using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.COption;
using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.CBean.CKey {

public class ConditionKeyLessEqual : ConditionKey {

    private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public ConditionKeyLessEqual() {
        _conditionKey = "lessEqual";
        _operand = "<=";
    }

    public override bool isValidRegistration(ConditionValue conditionValue, Object value, String callerName) {
        if (value == null) {
            return false;
        }
        if (conditionValue.HasLessEqual) {
            if (conditionValue.EqualLessEqual(value)) {
                _log.Debug("The value has already registered at " + callerName + ": value=" + value);
                return false;
            } else {
                conditionValue.OverrideLessEqual(value);
                return false;
            }
        }
        return true;
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, ConditionValue value) {
        if (value.LessEqual == null) {
            return;
        }
        Object valueObject = value.LessEqual;
        conditionList.add(buildBindClause(columnName, value.getLessEqualLocation()));
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, ConditionValue value, ConditionOption option) {
        throw new UnsupportedOperationException("doAddWhereClause with condition-option is unsupported!!!");
    }

    protected override void doSetupConditionValue(ConditionValue conditionValue, Object value, String location) {
        conditionValue.LessEqual = value;
        conditionValue.setLessEqualLocation(location);
    }
	
    protected override void doSetupConditionValue(ConditionValue conditionValue, Object value, String location, ConditionOption option) {
        throw new UnsupportedOperationException("doSetupConditionValue with condition-option is unsupported!!!");
    }
}
	
}
