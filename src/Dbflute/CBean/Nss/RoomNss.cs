
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class RoomNss {

        protected RoomCQ _query;
        public RoomNss(RoomCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
