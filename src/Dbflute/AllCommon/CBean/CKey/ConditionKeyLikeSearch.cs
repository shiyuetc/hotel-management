
using System;

using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.COption;
using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.CBean.CKey {

public class ConditionKeyLikeSearch : ConditionKey {

    public ConditionKeyLikeSearch() {
        _conditionKey = "likeSearch";
        _operand = "like";
    }

    public override bool isValidRegistration(ConditionValue conditionValue, Object value, String callerName) {
        if (value == null) {
            return false;
        }
        return true;
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, ConditionValue value) {
        throw new UnsupportedOperationException("doAddWhereClause without condition-option is unsupported!!!");
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, ConditionValue value, ConditionOption option) {
        if (option == null) {
            String msg = "The argument[option] should not be null: columnName=" + columnName + " value=" + value;
            throw new IllegalArgumentException(msg);
        }
        if (!(option is LikeSearchOption)) {
            String msg = "The argument[option] should be LikeSearchOption: columnName=" + columnName + " value=" + value;
            throw new IllegalArgumentException(msg);
        }
        LikeSearchOption myOption = (LikeSearchOption)option;
        conditionList.add(buildBindClauseWithRearOption(columnName, value.getLikeSearchLocation(), myOption.getRearOption()));
    }

    protected override void doSetupConditionValue(ConditionValue conditionValue, Object value, String location) {
        throw new UnsupportedOperationException("doSetupConditionValue without condition-option is unsupported!!!");
    }

    protected override void doSetupConditionValue(ConditionValue conditionValue, Object value, String location, ConditionOption option) {
        conditionValue.setLikeSearch((String)value, (LikeSearchOption)option).setLikeSearchLocation(location);
    }
}
	
}
