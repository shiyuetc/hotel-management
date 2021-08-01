
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class Dch宿泊利用台帳Nss {

        protected Dch宿泊利用台帳CQ _query;
        public Dch宿泊利用台帳Nss(Dch宿泊利用台帳CQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public Mst会員マスタNss WithMst会員マスタ() {
            _query.doNss(delegate() { return _query.QueryMst会員マスタ(); });
            return new Mst会員マスタNss(_query.QueryMst会員マスタ());
        }

        public Dch客室利用台帳Nss WithDch客室利用台帳() {
            _query.doNss(delegate() { return _query.QueryDch客室利用台帳(); });
            return new Dch客室利用台帳Nss(_query.QueryDch客室利用台帳());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
