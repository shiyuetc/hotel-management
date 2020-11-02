
using System;

namespace Dbflute.AllCommon.Exp {

    /// <summary>
    /// The exception of when the value of embedded value is null.
    /// </summary>
    public class EmbeddedValueParameterNullValueException : SystemException {

        public EmbeddedValueParameterNullValueException(String msg)
        : base(msg) {}
    }
}
