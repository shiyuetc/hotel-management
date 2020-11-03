
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class MstCustomerNss {

        protected MstCustomerCQ _query;
        public MstCustomerNss(MstCustomerCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
