using System;

namespace Dbflute.AllCommon {

public class XLog {

    // ===================================================================================
    //                                                                          Definition
    //                                                                          ==========
    private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    // ===================================================================================
    //                                                                             Logging
    //                                                                             =======
	public static void Log(String msg) {// Very Internal
		if (IsExecuteStatusLogLevelInfo()) {
	        _log.Info(msg);
		} else {
	        _log.Debug(msg);
		}
	}
	
    public static bool IsLogEnabled() {// Very Internal
		if (IsExecuteStatusLogLevelInfo()) {
	        return _log.IsInfoEnabled;
		} else {
	        return _log.IsDebugEnabled;
		}
	}
	
	protected static bool IsExecuteStatusLogLevelInfo() {
	    return DBFluteConfig.GetInstance().IsExecuteStatusLogLevelInfo;
	}
}

}
