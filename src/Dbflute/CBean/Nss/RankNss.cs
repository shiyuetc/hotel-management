
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class RankNss {

        protected RankCQ _query;
        public RankNss(RankCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
