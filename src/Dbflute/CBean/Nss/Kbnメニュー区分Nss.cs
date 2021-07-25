
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class Kbnメニュー区分Nss {

        protected Kbnメニュー区分CQ _query;
        public Kbnメニュー区分Nss(Kbnメニュー区分CQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
