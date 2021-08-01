
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class Mst権限マスタNss {

        protected Mst権限マスタCQ _query;
        public Mst権限マスタNss(Mst権限マスタCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public Mst画面マスタNss WithMst画面マスタ() {
            _query.doNss(delegate() { return _query.QueryMst画面マスタ(); });
            return new Mst画面マスタNss(_query.QueryMst画面マスタ());
        }

        public Kbn職位区分Nss WithKbn職位区分() {
            _query.doNss(delegate() { return _query.QueryKbn職位区分(); });
            return new Kbn職位区分Nss(_query.QueryKbn職位区分());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
