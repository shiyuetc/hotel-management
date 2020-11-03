
namespace HotelManagement.Const
{
    /// <summary>
    /// 定数
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// DayOfWeek列挙体に対応した日本語
        /// </summary>
        public static char[] WeekNames = { '日', '月', '火', '水', '木', '金', '土' };

        /// <summary>
        /// 従業員の職位を表す構造体
        /// </summary>
        public struct Rank
        {
            /// <summary>
            /// システム保守
            /// </summary>
            public static readonly string SystemMaintenancer = "000";

            /// <summary>
            /// アシスタントマネージャー
            /// </summary>
            public static readonly string AssistantManager = "001";

            /// <summary>
            /// ファイナンシャルコントローラー
            /// </summary>
            public static readonly string FinancialController = "002";

            /// <summary>
            /// フロントクラーク
            /// </summary>
            public static readonly string FrontClerk = "003";
        }
    }
}
