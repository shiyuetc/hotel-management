
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class MstEmployeeNss {

        protected MstEmployeeCQ _query;
        public MstEmployeeNss(MstEmployeeCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public KbnRankNss WithKbnRank() {
            _query.doNss(delegate() { return _query.QueryKbnRank(); });
            return new KbnRankNss(_query.QueryKbnRank());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
