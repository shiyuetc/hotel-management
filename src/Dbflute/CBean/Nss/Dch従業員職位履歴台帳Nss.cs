
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class Dch従業員職位履歴台帳Nss {

        protected Dch従業員職位履歴台帳CQ _query;
        public Dch従業員職位履歴台帳Nss(Dch従業員職位履歴台帳CQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public Mst従業員マスタNss WithMst従業員マスタ() {
            _query.doNss(delegate() { return _query.QueryMst従業員マスタ(); });
            return new Mst従業員マスタNss(_query.QueryMst従業員マスタ());
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
