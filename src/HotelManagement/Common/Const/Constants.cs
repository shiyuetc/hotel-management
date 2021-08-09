using System;
using System.Drawing;

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

        /// <summary>
        /// システム上での日付
        /// </summary>
        public struct システム日付
        {
            public static DateTime 現在値 = new DateTime(2021, 6, 1, 20, 30, 0); //DateTime.Now;

            public static DateTime 最小値 = new DateTime(2000, 1, 1);

            public static DateTime 最大値 = new DateTime(2099, 12, 31);
        }

        /// <summary>
        /// 
        /// </summary>
        public struct 客室利用状態配色
        {
            public static Color チェックイン待機中 = ColorTranslator.FromHtml("#FFFF00");

            public static Color チェックアウト待機中 = ColorTranslator.FromHtml("#FF0000");

            public static Color 宿泊中 = ColorTranslator.FromHtml("#FF8000");

            public static Color 清掃中 = ColorTranslator.FromHtml("#00FFFF");

            public static Color 工事中 = ColorTranslator.FromHtml("#FF00FF");
        }
    }
}
