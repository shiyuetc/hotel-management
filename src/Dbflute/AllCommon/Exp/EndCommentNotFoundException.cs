
using System;

namespace Dbflute.AllCommon.Exp {

    /// <summary>
    /// The exception of when the end comment is not found about outsideSql.
    /// </summary>
    public class EndCommentNotFoundException : SystemException {

        public EndCommentNotFoundException(String msg)
        : base(msg) {}
    }
}
