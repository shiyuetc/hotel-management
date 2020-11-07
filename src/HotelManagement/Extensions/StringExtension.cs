using System.Linq;

namespace HotelManagement.Extensions
{
    /// <summary>
    /// stringの拡張クラス
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// 文字列の値が指定された文字列群と等しいものがあるか判定します。
        /// </summary>
        /// <param name="value">比較する文字列</param>
        /// <param name="parameters">含まれているか比較する文字列群</param>
        /// <returns>等しい文字列が存在すればtrueを返す。</returns>
        public static bool EqualsAny(this string value, params string[] parameters)
        {
            return parameters.Contains(value);
        }

        /// <summary>
        /// 文字列をlong型に変換します。
        /// </summary>
        /// <param name="value">対象の文字列</param>
        /// <returns>long型に変換したオブジェクト</returns>
        public static long ToLong(this string value)
        {
            return long.Parse(value);
        }
    }
}
