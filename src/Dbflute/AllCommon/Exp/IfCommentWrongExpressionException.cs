
using System;
using System.Collections;

namespace Dbflute.AllCommon.Exp {

    /// <summary>
    /// The exception of when the IF comment has a wrong expression about outsideSql.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class IfCommentWrongExpressionException : SystemException {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param="msg">Exception message. (NotNull)</param>
        public IfCommentWrongExpressionException(String msg)
        : base(msg) {}

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param="msg">Exception message. (NotNull)</param>
        /// <param="cause">Exception. (NotNull)</param>
        public IfCommentWrongExpressionException(String msg, Exception cause)
        : base(msg, cause) {}
    }
}
