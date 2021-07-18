
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class Mst客室マスタNss {

        protected Mst客室マスタCQ _query;
        public Mst客室マスタNss(Mst客室マスタCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public Mst客室タイプマスタNss WithMst客室タイプマスタ() {
            _query.doNss(delegate() { return _query.QueryMst客室タイプマスタ(); });
            return new Mst客室タイプマスタNss(_query.QueryMst客室タイプマスタ());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
