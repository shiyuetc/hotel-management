
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class RoomTypeNss {

        protected RoomTypeCQ _query;
        public RoomTypeNss(RoomTypeCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
