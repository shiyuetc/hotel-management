
using System;

namespace Dbflute.AllCommon.Exp {

    /// <summary>
    /// The exception of when the entity has already been updated by other thread in batch update.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class BatchEntityAlreadyUpdatedException : EntityAlreadyUpdatedException {

        protected int? _batchUpdateCount;
        public BatchEntityAlreadyUpdatedException(Object bean, int rows, int? batchUpdateCount)
        : base(bean, rows) { this._batchUpdateCount = batchUpdateCount; }
        
        public int? BatchUpdateCount { get { return _batchUpdateCount; } }
    }
}
