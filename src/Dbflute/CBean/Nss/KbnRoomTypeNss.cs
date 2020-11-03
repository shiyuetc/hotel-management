
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class KbnRoomTypeNss {

        protected KbnRoomTypeCQ _query;
        public KbnRoomTypeNss(KbnRoomTypeCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
