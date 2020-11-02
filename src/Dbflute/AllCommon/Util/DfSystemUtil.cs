
using System;
using Dbflute.AllCommon.JavaLike;

namespace Dbflute.AllCommon.Util {

public class DfSystemUtil {

    // ===================================================================================
    //                                                                              System
    //                                                                              ======
    public static String getLineSeparator() {
        // /- - - - - - - - - - - - - - - - - - - - - -
        // Because 'CR + LF' caused many trouble!
		// And Now 'LF' have little trouble. 
		// 
        // return Environment.NewLine;
        // - - - - - - - - - -/
		return "\n";
    }
}

}
