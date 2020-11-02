
using System;

namespace Dbflute.AllCommon.Exp {

    /// <summary>
    /// The exception of when an invalid query is registered.
    /// </summary>
    public class InvalidQueryRegisteredException : SystemException {

        public InvalidQueryRegisteredException(String msg)
        : base(msg) {}
    }
}
