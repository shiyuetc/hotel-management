using Dbflute.ExEntity;

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
        public static Employee LoginEmployee { get; set; } = null;
    }
}
