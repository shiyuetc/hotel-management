
using System;
using System.Collections;

using Dbflute.AllCommon;
using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.CBean.CQ.BS;

namespace Dbflute.CBean.CQ {

    [System.Serializable]
    public class RoomCQ : BsRoomCQ {

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        // You should NOT touch with this constructor.
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="childQuery">Child query as interface. (NullAllowed: If null, this is base instance.)</param>
        /// <param name="sqlClause">SQL clause instance. (NotNull)</param>
        /// <param name="aliasName">My alias name. (NotNull)</param>
        /// <param name="nestLevel">Nest level.</param>
        public RoomCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        // ===============================================================================
        //                                                                   Arrange Query
        //                                                                   =============
        // You can make your arranged query methods here.
        //public void ArrangeXxx() {
        //    ...
        //}
    }
}
