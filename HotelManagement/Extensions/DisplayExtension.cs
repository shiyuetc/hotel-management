using HotelManagement.Enums;
using System;
using System.Reflection;

namespace HotelManagement.Extensions
{
    /// <summary>
    /// 拡張用の属性クラス
    /// </summary>
    public class DisplayNameAttribute : Attribute
    {
        /// <summary>
        /// 画面名
        /// </summary>
        public string DisplayName { get; private set; }

        /// <summary>
        /// 属性クラスを初期化します。
        /// </summary>
        /// <param name="displayName">画面名</param>
        public DisplayNameAttribute(string displayName)
        {
            this.DisplayName = displayName;
        }
    }

    /// <summary>
    /// Display列挙体の拡張クラス
    /// </summary>
    public static class DisplayExtension
    {
        /// <summary>
        /// 画面名を取得します。
        /// </summary>
        /// <param name="value">Display列挙体</param>
        /// <returns>画面名を返します。</returns>
        public static string GetDisplayName(this Display value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            if (fieldInfo == null) return null;

            DisplayNameAttribute[] attribs = fieldInfo.GetCustomAttributes(typeof(DisplayNameAttribute), false) as DisplayNameAttribute[];

            return attribs.Length > 0 ? attribs[0].DisplayName : null;
        }
    }
}
