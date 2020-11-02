
using System;

namespace Dbflute.AllCommon.Exp {

    /// <summary>
    /// The exception of when the entity has already been deleted (by other thread).
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class EntityAlreadyDeletedException : SystemException {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param="msg">Exception message. (NotNull)</param>
        public EntityAlreadyDeletedException(String msg)
        : base(msg) {}
    }
}
