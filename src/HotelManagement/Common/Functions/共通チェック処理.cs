using System;

namespace HotelManagement.Common.Functions
{
    /// <summary>
    /// 共通チェック処理クラス
    /// </summary>
    public static class 共通チェック処理
    {
        /// <summary>
        /// 引数が入力可能な日付であるかを判定します。
        /// </summary>
        /// <param name="入力日付">入力日付</param>
        /// <returns>入力可能であればtrue</returns>
        public static bool Is入力可能日付(DateTime 入力日付)
        {
            // 最小値より小さい場合
            if(Constants.システム日付.最小値 > 入力日付)
            {
                return false;
            }

            // 最大値より大きい場合
            if(Constants.システム日付.最大値 < 入力日付)
            {
                return false;
            }

            return true;
        }
    }
}
