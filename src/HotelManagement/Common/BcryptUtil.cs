
namespace HotelManagement.Common
{
    /// <summary>
    /// Bcrypt.Netのラッパー用クラス
    /// </summary>
    public static class BcryptUtil
    {
        /// <summary>
        /// 文字列をハッシュ化して返します。
        /// </summary>
        /// <param name="str">ハッシュ化する文字列</param>
        /// <returns>ハッシュ化した文字列を返す</returns>
        public static string GetHashedString(string str)
        {
            return BCrypt.Net.BCrypt.HashPassword(str);
        }

        /// <summary>
        /// ハッシュ化する前の文字列とハッシュが一致するか判定します。
        /// </summary>
        /// <param name="str">ハッシュ化する前の文字列</param>
        /// <param name="hash">ハッシュ化した文字列</param>
        /// <returns>判定した結果が一致したらtrueを返す</returns>
        public static bool Verify(string str, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(str, hash);
        }
    }
}
