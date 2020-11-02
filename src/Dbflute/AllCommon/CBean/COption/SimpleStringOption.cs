
using System;

// using Dbflute.AllCommon.CBean.COption.Parts;
// using Dbflute.AllCommon.CBean.COption.Parts.Local;
using Dbflute.AllCommon.Util;

namespace Dbflute.AllCommon.CBean.COption {

public class SimpleStringOption : ConditionOption {

    // protected SplitOptionParts _splitOptionParts;
    // protected ToUpperLowerCaseOptionParts _toUpperLowerCaseOptionParts;
    // protected ToSingleByteOptionParts _toSingleByteCaseOptionParts;
    // protected JapaneseOptionPartsAgent _japaneseOptionPartsAgent;

    // =====================================================================================
    //                                                                           Rear Option
    //                                                                           ===========
    public virtual String getRearOption() {
        return "";
    }

    // =====================================================================================
    //                                                                                 Split
    //                                                                                 =====
    public bool isSplit() {
        return false;
    }

    // =====================================================================================
    //                                                                   To Upper/Lower Case
    //                                                                   ===================

    // =====================================================================================
    //                                                                        To Single Byte
    //                                                                        ==============

    // =====================================================================================
    //                                                                        To Double Byte
    //                                                                        ==============

    // =====================================================================================
    //                                                                              Japanese
    //                                                                              ========

    // =====================================================================================
    //                                                                            Real Value
    //                                                                            ==========
    public virtual String generateRealValue(String value) {
        // value = getToUpperLowerCaseOptionParts().generateRealValue(value);
        // value = getToSingleByteOptionParts().generateRealValue(value);
        // value = getJapaneseOptionPartsAgent().generateRealValue(value);
        return value;
    }
	
    // =====================================================================================
    //                                                                        General Helper
    //                                                                        ==============
    protected String replaceString(String text, String fromText, String toText) {
	    return SimpleStringUtil.Replace(text, fromText, toText);
    }
}

}
