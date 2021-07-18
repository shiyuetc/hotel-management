
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class Mst従業員マスタNss {

        protected Mst従業員マスタCQ _query;
        public Mst従業員マスタNss(Mst従業員マスタCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public Kbn職位区分Nss WithKbn職位区分() {
            _query.doNss(delegate() { return _query.QueryKbn職位区分(); });
            return new Kbn職位区分Nss(_query.QueryKbn職位区分());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
