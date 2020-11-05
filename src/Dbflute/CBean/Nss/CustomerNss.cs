
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class CustomerNss {

        protected CustomerCQ _query;
        public CustomerNss(CustomerCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
