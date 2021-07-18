
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class Dch清掃実績台帳Nss {

        protected Dch清掃実績台帳CQ _query;
        public Dch清掃実績台帳Nss(Dch清掃実績台帳CQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public Dch客室利用実績台帳Nss WithDch客室利用実績台帳() {
            _query.doNss(delegate() { return _query.QueryDch客室利用実績台帳(); });
            return new Dch客室利用実績台帳Nss(_query.QueryDch客室利用実績台帳());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
