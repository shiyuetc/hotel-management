
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class Mst制御画面マスタNss {

        protected Mst制御画面マスタCQ _query;
        public Mst制御画面マスタNss(Mst制御画面マスタCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public Kbnメニュー区分Nss WithKbnメニュー区分() {
            _query.doNss(delegate() { return _query.QueryKbnメニュー区分(); });
            return new Kbnメニュー区分Nss(_query.QueryKbnメニュー区分());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
