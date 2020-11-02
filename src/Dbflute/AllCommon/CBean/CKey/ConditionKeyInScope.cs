
using System;

using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.COption;
using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.CBean.CKey {

public class ConditionKeyInScope : ConditionKey {

    private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public ConditionKeyInScope() {
        _conditionKey = "inScope";
        _operand = "in";
    }

    public override bool isValidRegistration(ConditionValue conditionValue, Object value, String callerName) {
        if (value == null) {
            return false;
        }
        if (value is System.Collections.IList && ((System.Collections.IList)value).Count == 0) {
            return false;
        }
        return true;
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, ConditionValue value) {
        if (value.InScope == null) {
            return;
        }
        System.Collections.IList valueList = value.InScope;
        System.Collections.IList checkedValueList = new System.Collections.Generic.List<Object>();
        foreach (Object checkTargetValue in valueList) {
            if (checkTargetValue == null) {
                continue;
            }
            checkedValueList.Add(checkTargetValue);
        }
        if (checkedValueList.Count == 0) {
            return;
        }
        conditionList.add(buildBindClause(columnName, value.getInScopeLocation(), "('a1', 'a2')"));
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, ConditionValue value, ConditionOption option) {
        throw new UnsupportedOperationException("doAddWhereClause with condition-option is unsupported!!!");
    }

    protected override void doSetupConditionValue(ConditionValue conditionValue, Object value, String location) {
        conditionValue.InScope = (System.Collections.IList)value;
        conditionValue.setInScopeLocation(location);
    }

    protected override void doSetupConditionValue(ConditionValue conditionValue, Object value, String location, ConditionOption option) {
        throw new UnsupportedOperationException("doSetupConditionValue with condition-option is unsupported!!!");
    }
}

}
