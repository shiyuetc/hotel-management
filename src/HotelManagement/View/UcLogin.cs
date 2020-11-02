using HotelManagement.Common;
using HotelManagement.Models;
using System.Windows.Forms;

namespace HotelManagement.View
{
    /// <summary>
    /// ログイン画面のクラス
    /// </summary>
    public partial class UcLogin : UcBase
    {
        /// <summary>
        /// UcLoginを初期化します。
        /// </summary>
        public UcLogin(FmMain main) : base(main)
        {
            InitializeComponent();
        }

        /// <summary>
        /// ログインボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            if (this.EmployeeIDTextBox.TextLength == 0)
            {
                Messages.ShowError("{0}が入力されていません。", "従業員ID");
                return;
            }

            if (this.PasswordTextBox.TextLength == 0)
            {
                Messages.ShowError("{0}が入力されていません。", "パスワード");
                return;
            }

            var vm = new ModelQuillInjector<LoginModel>();
            var user = vm.Model.Login(this.EmployeeIDTextBox.Text, this.PasswordTextBox.Text);

            if (user == null)
            {
                Messages.ShowError("ログインに失敗しました。");
                return;
            }
            else
            {
                this.Main.SetLoginUser(user);
            }
        }

        /// <summary>
        /// 終了ボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            if(Messages.ShowConfirm("アプリケーションを終了しますか？"))
            {
                Application.Exit();
            }
        }
    }
}
