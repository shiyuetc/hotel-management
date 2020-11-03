
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class MstRoomNss {

        protected MstRoomCQ _query;
        public MstRoomNss(MstRoomCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
