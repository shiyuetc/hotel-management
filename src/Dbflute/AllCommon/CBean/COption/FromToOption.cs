
using System;

using Dbflute.AllCommon.CBean.CKey;
using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.CBean.COption {

public class FromToOption : SimpleStringOption {

    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    protected bool _fromDateGreaterThan;
    protected bool _toDateLessThan;
    protected bool _compareAsDate;
    protected bool _toDateMaxValue; // CSharp Only

    // ===================================================================================
    //                                                                         Rear Option
    //                                                                         ===========
    public override String getRearOption() {
        String msg = "Thie option does not use getRearOption()!";
        throw new UnsupportedOperationException(msg);
    }

    // ===================================================================================
    //                                                                                Main
    //                                                                                ====
    public FromToOption GreaterThan() {
        _fromDateGreaterThan = true; return this;
    }

    public FromToOption LessThan() {
        _toDateLessThan = true; return this;
    }

    public FromToOption CompareAsDate() {
        _compareAsDate = true; return this;
    }

    // ===================================================================================
    //                                                                       Internal Main
    //                                                                       =============
    public DateTime? filterFromDate(DateTime? fromDate) {
        if (fromDate == null) {
            return null;
        }
        if (_compareAsDate) {
            DateTime cloneDate = new DateTime(fromDate.Value.Year, fromDate.Value.Month, fromDate.Value.Day);
            return cloneDate;
        }
        return fromDate;
    }

    public DateTime? filterToDate(DateTime? toDate) {
        if (toDate == null) {
            return null;
        }
        if (_compareAsDate) {
            DateTime cloneDate = new DateTime(toDate.Value.Year, toDate.Value.Month, toDate.Value.Day);
            if (cloneDate.Date.Equals(DateTime.MaxValue.Date)) { // CSharp Only
                _toDateMaxValue = true;
                return DateTime.MaxValue;
            }
            return cloneDate.AddDays(1);
        }
        return toDate;
    }

    public ConditionKey getFromDateConditionKey() {
        if (_compareAsDate) {
            return ConditionKey.CK_GREATER_EQUAL;
        }
        if (_fromDateGreaterThan) {
            return ConditionKey.CK_GREATER_THAN;// Default!
        } else {
            return ConditionKey.CK_GREATER_EQUAL;// Default!
        }
    }

    public ConditionKey getToDateConditionKey() {
        if (_compareAsDate) {
            return _toDateMaxValue ? ConditionKey.CK_LESS_EQUAL : ConditionKey.CK_LESS_THAN;
        }
        if (_toDateLessThan) {
            return ConditionKey.CK_LESS_THAN;// Default!
        } else {
            return ConditionKey.CK_LESS_EQUAL;// Default!
        }
    }
}

}
