
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class MstUserNss {

        protected MstUserCQ _query;
        public MstUserNss(MstUserCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
