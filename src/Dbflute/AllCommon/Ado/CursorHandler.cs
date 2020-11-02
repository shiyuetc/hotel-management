
using System;
using System.Data;

namespace Dbflute.AllCommon.Ado {

    /// <summary>
    /// The handler of cursor.
    /// Author : DBFlute(AutoGenerator)
    /// </summary>
    public interface CursorHandler {

        /// <summary>
        /// Handle dataReader.
        /// </summary>
        /// <param name="reader">The dataReader of handling target. (NotNull)</param>
        /// <returns>The result of handling. (NullAllowed)</returns>
        Object Handle(IDataReader reader);
    }

    /// <summary>
    /// The delegator of cursor fetcher.
    /// </summary>
    /// <typeparam name="CURSOR">The type of cursor.</typeparam>
    /// <param name="cursor">The cursor of fetch target. (NotNull)</param>
    /// <returns>the result of fetching. (NullAllowed)</returns>
    public delegate Object CursorFetcher<CURSOR>(CURSOR cursor);
}
