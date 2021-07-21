using System.Drawing;

namespace HotelManagement.Common
{
    public static class ResourceUtil
    {
        /// <summary>
        /// メニューボタンのアイコンを取得します。
        /// </summary>
        /// <param name="画面名">画面名</param>
        /// <returns></returns>
        public static Bitmap GetMenuIcon(string 画面名)
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            return new Bitmap(
                myAssembly.GetManifestResourceStream($"{Constants.AppName}.Resources.Images.icon_{画面名}.png"));
        }
    }
}
