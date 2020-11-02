
using System;
using Dbflute.AllCommon.CBean.SClause;

namespace Dbflute.AllCommon.CBean {

    /// <summary>
    /// The bean of paging.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public interface PagingBean : FetchNarrowingBean, OrderByBean {

        // ===============================================================================
        //                                                            Paging Determination
        //                                                            ====================
        // * * * * * * * *
        // For SQL Comment
        // * * * * * * * *
        bool IsPaging { get; }

        // * * * * * * * *
        // For Framework
        // * * * * * * * *
        bool IsCountLater { get; }

        // ===============================================================================
        //                                                                  Paging Setting
        //                                                                  ==============
		void Paging(int pageSize, int pageNumber);
        void XSetPaging(bool paging); // Very Internal!

        void DisablePagingReSelect();
        bool CanPagingReSelect { get; }

        // ===============================================================================
        //                                                                   Fetch Setting
        //                                                                   =============
        /// <summary>
        /// Fetch first.
        /// </summary>
        /// <remarks>
        /// If you invoke this, your SQL returns [fetch-size] records from first.
        /// </remarks>
        /// <param name="fetchSize">The size of fetch. (NotMinus & NotZero)</param>
        /// <returns>this. (NotNull)</returns>
        PagingBean FetchFirst(int fetchSize);

        /// <summary>
        /// Fetch scope.
        /// </summary>
        /// <remarks>
        /// If you invoke this, your SQL returns [fetch-size] records from [fetch-start-index].
        /// </remarks>
        /// <param name="fetchStartIndex">The start index of fetch. 0 origin. (NotMinus)</param>
        /// <param name="fetchSize">The size of fetch. (NotMinus & NotZero)</param>
        /// <returns>this. (NotNull)</returns>
        PagingBean FetchScope(int fetchStartIndex, int fetchSize);

        /// <summary>
        /// Fetch page.
        /// </summary>
        /// <remarks>
        /// When you invoke this, it is normally necessary to invoke 'fetchFirst()' or 'fetchScope()' ahead of that.
        /// But you also can use default-fetch-size without invoking 'fetchFirst()' or 'fetchScope()'.
        /// If you invoke this, your SQL returns [fetch-size] records from [fetch-start-index] calculated by [fetch-page-number].
        /// </remarks>
        /// <param name="fetchPageNumber">The page number of fetch. 1 origin. (NotMinus & NotZero)</param>
        /// <returns>this. (NotNull)</returns>
        PagingBean FetchPage(int fetchPageNumber);

        // ===============================================================================
        //                                                                 Paging Property
        //                                                                 ===============
        int FetchStartIndex { get; }
        int FetchSize { get; }
        int FetchPageNumber { get; }
        int PageStartIndex { get; }
        int PageEndIndex { get; }
        bool IsFetchScopeEffective { get; }

        // ===============================================================================
        //                                                                   Hint Property
        //                                                                   =============
        String SelectHint { get; }
        String FromHint { get; }
        String SqlSuffix { get; }
        new String OrderByClause { get; }
    }
}
