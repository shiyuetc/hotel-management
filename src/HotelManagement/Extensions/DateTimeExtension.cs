using System;

namespace HotelManagement.Extensions
{
    /// <summary>
    /// DateTimeクラスの拡張クラス
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        /// 日付が、引数の日付より後の時刻かどうかを判断します。
        /// </summary>
        /// <param name="dt1">日付1</param>
        /// <param name="dt2">日付2</param>
        /// <returns></returns>
        public static bool GreaterThan(this DateTime dt1, DateTime dt2)
        {
            return dt1 > dt2;
        }

        /// <summary>
        /// 日付が、引数の日付以降の時刻かどうかを判断します。
        /// </summary>
        /// <param name="dt1">日付1</param>
        /// <param name="dt2">日付2</param>
        /// <returns></returns>
        public static bool GreaterThanEqual(this DateTime dt1, DateTime dt2)
        {
            return dt1 >= dt2;
        }

        /// <summary>
        /// 日付が、引数の日付より前の時刻かどうかを判断します。
        /// </summary>
        /// <param name="dt1">日付1</param>
        /// <param name="dt2">日付2</param>
        /// <returns></returns>
        public static bool LessThan(this DateTime dt1, DateTime dt2)
        {
            return dt1 < dt2;
        }

        /// <summary>
        /// 日付が、引数の日付以前の時刻かどうかを判断します。
        /// </summary>
        /// <param name="dt1">日付1</param>
        /// <param name="dt2">日付2</param>
        /// <returns></returns>
        public static bool LessThanEqual(this DateTime dt1, DateTime dt2)
        {
            return dt1 <= dt2;
        }

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
        /// 日付をyyyy年MM月dd日の形式に変換します。
        /// </summary>
        /// <param name="dt">日付</param>
        /// <returns>指定の形式で表した文字列</returns>
        public static string ToYYYYMMDD(this DateTime? dt)
        {
            if(dt == null)
            {
                return string.Empty;
            }

            return ((DateTime)dt).ToYYYYMMDD();
        }

        /// <summary>
        /// 日付をyyyy/MM/ddの形式に変換します。
        /// </summary>
        /// <param name="dt">日付</param>
        /// <returns>指定の形式で表した文字列</returns>
        public static string ToSlashYYYYMMDD(this DateTime dt)
        {
            return dt.ToString("yyyy年MM月dd日");
        }

        /// <summary>
        /// 日付をyyyy/MM/ddの形式に変換します。
        /// </summary>
        /// <param name="dt">日付</param>
        /// <returns>指定の形式で表した文字列</returns>
        public static string ToSlashYYYYMMDD(this DateTime? dt)
        {
            if (dt == null)
            {
                return string.Empty;
            }

            return ((DateTime)dt).ToSlashYYYYMMDD();
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

        /// <summary>
        /// 日付をHH時mm分の形式に変換します。
        /// </summary>
        /// <param name="dt">日付</param>
        /// <returns>指定の形式で表した文字列</returns>
        public static string ToHHMM(this DateTime? dt)
        {
            if (dt == null)
            {
                return string.Empty;
            }

            return ((DateTime)dt).ToHHMM();
        }

        /// <summary>
        /// 日付をHH:mmの形式に変換します。
        /// </summary>
        /// <param name="dt">日付</param>
        /// <returns>指定の形式で表した文字列</returns>
        public static string ToColonHHMM(this DateTime dt)
        {
            return dt.ToString("HH:mm");
        }

        /// <summary>
        /// 日付をHH:mmの形式に変換します。
        /// </summary>
        /// <param name="dt">日付</param>
        /// <returns>指定の形式で表した文字列</returns>
        public static string ToColonHHMM(this DateTime? dt)
        {
            if (dt == null)
            {
                return string.Empty;
            }

            return ((DateTime)dt).ToColonHHMM();
        }
    
    }
}
