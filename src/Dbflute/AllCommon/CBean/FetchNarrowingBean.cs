
using System;
using System.Collections;
using Dbflute.AllCommon.CBean.SClause;

namespace Dbflute.AllCommon.CBean {

    /// <summary>
    /// The bean of fetch narrowing.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public interface FetchNarrowingBean {

        int FetchNarrowingSkipStartIndex { get; }
        int FetchNarrowingLoopCount { get; }
        bool IsFetchNarrowingSkipStartIndexEffective { get; }
        bool IsFetchNarrowingLoopCountEffective { get; }
        bool IsFetchNarrowingEffective { get; }

        /// <summary>
        /// Ignore fetch narrowing. Only checking safety result size is valid. {INTERNAL METHOD}
        /// </summary>
        void IgnoreFetchNarrowing();

        /// <summary>
        /// Restore ignored fetch narrowing. {INTERNAL METHOD}
        /// </summary>
        void RestoreIgnoredFetchNarrowing();

        void CheckSafetyResult(int safetyMaxResultSize);
        int SafetyMaxResultSize { get; }
    }
}
