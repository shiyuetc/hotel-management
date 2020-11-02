
using System;
using System.Collections;

namespace Dbflute.AllCommon.Exp {

    /// <summary>
    /// The exception when the entity has been duplicated.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class EntityDuplicatedException : SystemException {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param="msg">Exception message.</param>
        public EntityDuplicatedException(String msg)
        : base(msg) {}

        public EntityDuplicatedException(String msg, Exception e)
        : base(msg, e) {}
    }
}
