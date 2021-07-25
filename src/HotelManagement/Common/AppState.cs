using Dbflute.ExEntity;
using System.Collections.Generic;

namespace HotelManagement.Common
{
    /// <summary>
    /// アプリケーションのステータスクラス
    /// </summary>
    public static class AppState
    {
        /// <summary>
        /// ログイン中の従業員
        /// </summary>
        public static Mst従業員マスタ ログイン従業員 { get; set; } = null;

    }
}
