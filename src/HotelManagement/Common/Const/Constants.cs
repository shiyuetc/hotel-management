using System;

namespace HotelManagement.Common
{
    /// <summary>
    /// 定数
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// ビルドバージョン
        /// </summary>
        public static readonly string Version = "α版";

        /// <summary>
        /// アプリケーション名
        /// </summary>
        public static readonly string AppName = "HotelManagement";

        /// <summary>
        /// DayOfWeek列挙体に対応した日本語
        /// </summary>
        public static readonly char[] WeekNames = { '日', '月', '火', '水', '木', '金', '土' };

        public struct システム日付
        {
            public static DateTime 現在値 = DateTime.Now;

            public static DateTime 最小値 = new DateTime(2000, 1, 1);

            public static DateTime 最大値 = new DateTime(2099, 12, 31);
        }
    }
}
