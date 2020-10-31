using System.Windows.Forms;

namespace HotelManagement.Functions
{
    public static class Messages
    {
        public static void ShowInfo(string message, params string[] args)
        {
            MessageBox.Show(string.Format(message, args), "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool ShowConfirm(string message, params string[] args)
        {
            return MessageBox.Show(string.Format(message, args), "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static void ShowWarning(string message, params string[] args)
        {
            MessageBox.Show(string.Format(message, args), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError(string message, params string[] args)
        {
            MessageBox.Show(string.Format(message, args), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
