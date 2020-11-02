
using System;

namespace Dbflute.AllCommon.Exp {

    /// <summary>
    /// The exception of when the property on embedded value comment is not found  about outsideSql.
    /// </summary>
    public class EmbeddedValueCommentNotFoundPropertyException : SystemException {

        public EmbeddedValueCommentNotFoundPropertyException(String msg)
        : base(msg) {}
    }
}
