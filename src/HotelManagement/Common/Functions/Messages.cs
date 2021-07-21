using System.Windows.Forms;

namespace HotelManagement.Common
{
    /// <summary>
    /// 表示メッセージの制御を行うクラス
    /// </summary>
    public static class Messages
    {
        /// <summary>
        /// 【情報】のメッセージボックスを表示します。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void ShowInfo(string message, params string[] args)
        {
            MessageBox.Show(string.Format(message, args), "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 【確認】のメッセージボックスを表示します。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        /// <returns>「はい」を選択した場合はTrueを返します。</returns>
        public static bool ShowConfirm(string message, params string[] args)
        {
            return MessageBox.Show(string.Format(message, args), "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        /// <summary>
        /// 【警告】のメッセージボックスを表示します。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void ShowWarning(string message, params string[] args)
        {
            MessageBox.Show(string.Format(message, args), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 【エラー】のメッセージボックスを表示します。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void ShowError(string message, params string[] args)
        {
            MessageBox.Show(string.Format(message, args), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
