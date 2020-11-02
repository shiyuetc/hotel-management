
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class USERNss {

        protected USERCQ _query;
        public USERNss(USERCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
