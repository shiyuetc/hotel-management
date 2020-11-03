
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class KbnRankNss {

        protected KbnRankCQ _query;
        public KbnRankNss(KbnRankCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
