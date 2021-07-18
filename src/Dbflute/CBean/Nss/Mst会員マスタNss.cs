
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class Mst会員マスタNss {

        protected Mst会員マスタCQ _query;
        public Mst会員マスタNss(Mst会員マスタCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
