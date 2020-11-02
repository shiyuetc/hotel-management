
using System;
using System.Data;

namespace Dbflute.AllCommon.Ado {

    public class StatementConfig {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
	    // -------------------------------------------------
        //                                  Statement Option
        //                                  ----------------
        protected int? _queryTimeout;

	    // ===============================================================================
        //                                                               Setting Interface
        //                                                               =================
    	// -------------------------------------------------
        //                                  Statement Option
        //                                  ----------------
        public StatementConfig QueryTimeout(int? queryTimeout) { _queryTimeout = queryTimeout; return this; }

	    // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
    	// -------------------------------------------------
        //                                  Statement Option
        //                                  ----------------
        public bool HasQueryTimeout() {
            return _queryTimeout != null;
        }

        // ===============================================================================
        //                                                                  Basic Override
        //                                                                  ==============
	    public override String ToString() {
	        return "{" + _queryTimeout + "}";
	    }
	
	    // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
    	// -------------------------------------------------
        //                                  Statement Option
        //                                  ----------------
        public int? GetQueryTimeout() {
            return _queryTimeout;
        }
    }
}
