
using System;
using System.Collections;

namespace Dbflute.AllCommon.Exp {

    /// <summary>
    /// The exception of when the property on bind variable comment is not found about outsideSql.
    /// </summary>
    public class BindVariableCommentNotFoundPropertyException : SystemException {

        public BindVariableCommentNotFoundPropertyException(String msg)
        : base(msg) {}
    }
}
