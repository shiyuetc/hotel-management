
using System;
using System.Collections;

namespace Dbflute.AllCommon.Exp {

    /// <summary>
    /// The exception of when the value of bind variable is null about outsideSql.
    /// </summary>
    public class BindVariableParameterNullValueException : SystemException {

        public BindVariableParameterNullValueException(String msg)
        : base(msg) {}
    }
}
