using System.Drawing;
using System.Reflection;

namespace HotelManagement.Common
{
    /// <summary>
    /// リソースへの仲介を行うクラス
    /// </summary>
    public static class ResourceUtil
    {
        /// <summary>
        /// メニューボタンのアイコンを取得します。
        /// </summary>
        /// <param name="画面名">画面名</param>
        /// <returns></returns>
        public static Bitmap GetMenuIcon(string 画面名)
        {
            var assembly = Assembly.GetExecutingAssembly();
            return new Bitmap(
                assembly.GetManifestResourceStream($"{Constants.AppName}.Resources.Images.icon_{画面名}.png"));
        }
    }
}
