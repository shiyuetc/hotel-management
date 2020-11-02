
using System;
using System.Collections;

namespace Dbflute.AllCommon.Exp {

    /// <summary>
    /// The exception of when the required option is not found.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class RequiredOptionNotFoundException : SystemException {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param="msg">Exception message.</param>
        public RequiredOptionNotFoundException(String msg)
        : base(msg) {}
    }
}
