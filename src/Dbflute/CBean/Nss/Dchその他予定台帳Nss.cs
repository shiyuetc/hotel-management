
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class Dchその他予定台帳Nss {

        protected Dchその他予定台帳CQ _query;
        public Dchその他予定台帳Nss(Dchその他予定台帳CQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public Dch客室利用予定台帳Nss WithDch客室利用予定台帳() {
            _query.doNss(delegate() { return _query.QueryDch客室利用予定台帳(); });
            return new Dch客室利用予定台帳Nss(_query.QueryDch客室利用予定台帳());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
