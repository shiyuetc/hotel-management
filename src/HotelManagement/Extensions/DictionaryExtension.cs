using System.Collections.Generic;

namespace HotelManagement.Extensions
{
    /// <summary>
    /// Dictionaryクラスの拡張クラス
    /// </summary>
    public static class DictionaryExtension
    {
        /// <summary>
        /// ディクショナリの値だけを配列として取得します。
        /// </summary>
        /// <typeparam name="T1">ディクショナリのキー</typeparam>
        /// <typeparam name="T2">ディクショナリの値</typeparam>
        /// <param name="dictionary">対象のオブジェクト</param>
        /// <returns>ディクショナリから取得した配列</returns>
        public static T2[] GetValueArray<T1, T2>(this Dictionary<T1, T2> dictionary)
        {
            var values = new List<T2>();
            foreach (KeyValuePair<T1, T2> keyValuePair in dictionary)
            {
                values.Add(keyValuePair.Value);
            }
            return values.ToArray();
        }
    }
}
