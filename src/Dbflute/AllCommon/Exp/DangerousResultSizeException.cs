
using System;

namespace Dbflute.AllCommon.Exp {

    /// <summary>
    /// The exception of when the result size is dangerous.
    /// </summary>
    public class DangerousResultSizeException : SystemException {

        protected int _safetyMaxResultSize;

        public DangerousResultSizeException(String msg, int safetyMaxResultSize)
        : base(msg) { _safetyMaxResultSize = safetyMaxResultSize; }

        public int SafetyMaxResultSize {
            get { return _safetyMaxResultSize; }
        }
    }
}
