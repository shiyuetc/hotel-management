using System;

namespace HotelManagement.Extensions
{
    /// <summary>
    /// DateTimeクラスの拡張クラス
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        /// 日付をyyyy年MM月dd日の形式に変換します。
        /// </summary>
        /// <param name="dt">日付</param>
        /// <returns>指定の形式で表した文字列</returns>
        public static string ToYYYYMMDD(this DateTime dt)
        {
            return dt.ToString("yyyy年MM月dd日");
        }

        /// <summary>
        /// 日付をHH時mm分の形式に変換します。
        /// </summary>
        /// <param name="dt">日付</param>
        /// <returns>指定の形式で表した文字列</returns>
        public static string ToHHMM(this DateTime dt)
        {
            return dt.ToString("HH時mm分");
        }
    }
}
