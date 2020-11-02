
using System;

using Dbflute.AllCommon.CBean.COption;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.CBean.CKey {

public abstract class ConditionKey {

    // ===================================================================================
    //                                                                          Definition
    //                                                                          ==========
    /** The condition key of equal. */
    public static readonly ConditionKey CK_EQUAL = new ConditionKeyEqual();

    /** The condition key of notEqual as standard. */
    public static readonly ConditionKey CK_NOT_EQUAL_STANDARD = new ConditionKeyNotEqualStandard();

    /** The condition key of notEqual as tradition. */
    public static readonly ConditionKey CK_NOT_EQUAL_TRADITION = new ConditionKeyNotEqualTradition();

    /** The condition key of greaterThan. */
    public static readonly ConditionKey CK_GREATER_THAN = new ConditionKeyGreaterThan();

    /** The condition key of lessrThan. */
    public static readonly ConditionKey CK_LESS_THAN = new ConditionKeyLessThan();

    /** The condition key of greaterEqual. */
    public static readonly ConditionKey CK_GREATER_EQUAL = new ConditionKeyGreaterEqual();

    /** The condition key of lessEqual. */
    public static readonly ConditionKey CK_LESS_EQUAL = new ConditionKeyLessEqual();

    /** The condition key of prefixSearch. */
    public static readonly ConditionKey CK_PREFIX_SEARCH = new ConditionKeyPrefixSearch();

    /** The condition key of inScope. */
    public static readonly ConditionKey CK_IN_SCOPE = new ConditionKeyInScope();

    /** The condition key of notInScope. */
    public static readonly ConditionKey CK_NOT_IN_SCOPE = new ConditionKeyNotInScope();

    /** The condition key of likeSearch. */
    public static readonly ConditionKey CK_LIKE_SEARCH = new ConditionKeyLikeSearch();

    /** The condition key of notLikeSearch. */
    public static readonly ConditionKey CK_NOT_LIKE_SEARCH = new ConditionKeyNotLikeSearch();

    /** The condition key of isNull. */
    public static readonly ConditionKey CK_IS_NULL = new ConditionKeyIsNull();

    /** The condition key of isNotNull. */
    public static readonly ConditionKey CK_IS_NOT_NULL = new ConditionKeyIsNotNull();

    /** Dummy-object for IsNull and IsNotNull and so on... */
    protected static readonly Object DUMMY_OBJECT = new Object();

    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    /** Condition-key. */
    protected String _conditionKey;

    /** Operand. */
    protected String _operand;

    // ===================================================================================
    //                                                                         Main Method
    //                                                                         ===========
    public String getConditionKey() {
        // Because initial charactor of property name is capital in dotNet world.
        return (_conditionKey != null ? _conditionKey.Substring(0, 1).ToUpper() + _conditionKey.Substring(1) : null);
    }

    public String getOperand() {
        return _operand;
    }

    abstract public bool isValidRegistration(ConditionValue conditionValue, Object value, String callerName);

    public ConditionKey addWhereClause(List<String> conditionList, String columnName, ConditionValue value) {
        if (value == null) {
            String msg = "Argument[value] must not be null:";
            throw new IllegalArgumentException(msg + " value=" + value + " this.ToString()=" + ToString());
        }
        doAddWhereClause(conditionList, columnName, value);
        return this;
    }

    public ConditionKey addWhereClause(List<String> conditionList, String columnName, ConditionValue value, ConditionOption option) {
        if (value == null) {
            String msg = "Argument[value] must not be null:";
            throw new IllegalArgumentException(msg + " value=" + value + " this.ToString()=" + ToString());
        }
        doAddWhereClause(conditionList, columnName, value, option);
        return this;
    }
	
    abstract protected void doAddWhereClause(List<String> conditionList, String columnName, ConditionValue value);
    abstract protected void doAddWhereClause(List<String> conditionList, String columnName, ConditionValue value, ConditionOption option);

    public ConditionValue setupConditionValue(ConditionValue conditionValue, Object value, String location) {
        if (conditionValue == null) {
            String msg = "Argument[conditionValue] must not be null:";
            throw new IllegalArgumentException(msg + " value=" + value + " this.ToString()=" + ToString());
        }
        doSetupConditionValue(conditionValue, value, location);
        return conditionValue;
    }

    public ConditionValue setupConditionValue(ConditionValue conditionValue, Object value, String location, ConditionOption option) {
        if (conditionValue == null) {
            String msg = "Argument[conditionValue] must not be null:";
            throw new IllegalArgumentException(msg + " value=" + value + " this.ToString()=" + ToString());
        }
        doSetupConditionValue(conditionValue, value, location, option);
        return conditionValue;
    }
	
    abstract protected void doSetupConditionValue(ConditionValue conditionValue, Object value, String location);
    abstract protected void doSetupConditionValue(ConditionValue conditionValue, Object value, String location, ConditionOption option);

    protected String buildBindClause(String columnName, String location) {
        return columnName + " " + getOperand() + " " + "/*pmb." + location + "*/null";
    }

    protected String buildBindClauseWithRearOption(String columnName, String location, String rearOption) {
        return columnName + " " + getOperand() + " " + "/*pmb." + location + "*/null" + rearOption;
    }

    protected String buildBindClause(String columnName, String location, String dummyValue) {
        return columnName + " " + getOperand() + " " + "/*pmb." + location + "*/" + dummyValue;
    }

    protected String buildClauseWithoutValue(String columnName) {
        return columnName + " " + getOperand();
    }

    protected String getWildCard() {
        return "%";
    }

    // ===================================================================================
    //                                                                      Basic Override
    //                                                                      ==============
    public override int GetHashCode() {
        return getConditionKey().GetHashCode();
    }

    public override bool Equals(Object other) {
        if (other is ConditionKey) {
            if (this.getConditionKey().Equals(((ConditionKey)other).getConditionKey())) {
                return true;
            }
        }
        return false;
    }

    public override String ToString() {
        return "ConditionKey: " + getConditionKey() + " " + getOperand() + " wild-card=[" + getWildCard() + "]";
    }
}
}
