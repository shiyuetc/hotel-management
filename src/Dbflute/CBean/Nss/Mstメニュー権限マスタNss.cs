
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class Mstメニュー権限マスタNss {

        protected Mstメニュー権限マスタCQ _query;
        public Mstメニュー権限マスタNss(Mstメニュー権限マスタCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public Mst制御画面マスタNss WithMst制御画面マスタ() {
            _query.doNss(delegate() { return _query.QueryMst制御画面マスタ(); });
            return new Mst制御画面マスタNss(_query.QueryMst制御画面マスタ());
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
