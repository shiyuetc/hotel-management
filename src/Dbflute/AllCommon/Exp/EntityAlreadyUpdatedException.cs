
using System;
using Seasar.Dao;

namespace Dbflute.AllCommon.Exp {

    /// <summary>
    /// The exception of when the entity has already been updated by other thread.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class EntityAlreadyUpdatedException : NotSingleRowUpdatedRuntimeException {

        public EntityAlreadyUpdatedException(Object bean, int rows)
        : base(bean, rows) {}

        public EntityAlreadyUpdatedException(NotSingleRowUpdatedRuntimeException e)
        : base(e.Bean, e.Rows) {}
    }
}
