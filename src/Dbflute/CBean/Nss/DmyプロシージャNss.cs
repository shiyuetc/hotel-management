
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class DmyプロシージャNss {

        protected DmyプロシージャCQ _query;
        public DmyプロシージャNss(DmyプロシージャCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
