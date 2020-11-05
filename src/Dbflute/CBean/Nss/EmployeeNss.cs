
using System;
using Dbflute.CBean.CQ;

namespace Dbflute.CBean.Nss {

    public class EmployeeNss {

        protected EmployeeCQ _query;
        public EmployeeNss(EmployeeCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public RankNss WithRank() {
            _query.doNss(delegate() { return _query.QueryRank(); });
            return new RankNss(_query.QueryRank());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
