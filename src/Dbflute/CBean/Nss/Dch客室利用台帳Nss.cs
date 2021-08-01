
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class Dch客室利用台帳Nss {

        protected Dch客室利用台帳CQ _query;
        public Dch客室利用台帳Nss(Dch客室利用台帳CQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public Mst客室マスタNss WithMst客室マスタ() {
            _query.doNss(delegate() { return _query.QueryMst客室マスタ(); });
            return new Mst客室マスタNss(_query.QueryMst客室マスタ());
        }

        public Kbn客室利用区分Nss WithKbn客室利用区分() {
            _query.doNss(delegate() { return _query.QueryKbn客室利用区分(); });
            return new Kbn客室利用区分Nss(_query.QueryKbn客室利用区分());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
        public Dch宿泊利用台帳Nss WithDch宿泊利用台帳AsOne() {
            _query.doNss(delegate() { return _query.QueryDch宿泊利用台帳AsOne(); });
            return new Dch宿泊利用台帳Nss(_query.QueryDch宿泊利用台帳AsOne());
        }

    }
}
