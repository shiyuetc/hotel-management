using HotelManagement.Common;
using HotelManagement.Models;
using System.Windows.Forms;

namespace HotelManagement.View
{
    /// <summary>
    /// ログイン画面のクラス
    /// </summary>
    public partial class Ucログイン画面 : UcBase
    {
        #region コンストラクタ

        /// <summary>
        /// UcLoginを初期化します。
        /// </summary>
        public Ucログイン画面(FmMain main) : base(main)
        {
            InitializeComponent();

            this.バージョンLabel.Text = $"VER {Constants.Version}";
        }

        #endregion

        #region イベントハンドラ

        /// <summary>
        /// ログインボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ログインButton_Click(object sender, System.EventArgs e)
        {
            // 入力チェック
            if (string.IsNullOrEmpty(this.EmployeeIDTextBox.Text))
            {
                Messages.ShowError("{0}が入力されていません。", "従業員ID");
                return;
            }

            if (string.IsNullOrEmpty(this.PasswordTextBox.Text))
            {
                Messages.ShowError("{0}が入力されていません。", "パスワード");
                return;
            }
            
            // ログインを試行
            var vm = new ModelQuillInjector<ログイン画面処理Model>();
            var 従業員マスタ = vm.Model.ログイン処理(this.EmployeeIDTextBox.Text, this.PasswordTextBox.Text);

            if (従業員マスタ == null)
            {
                Messages.ShowError("ログインに失敗しました。");
                return;
            }

            // ログインが成功した場合はログイン情報を保持
            this.Main.Setログイン情報(従業員マスタ);
        }

        /// <summary>
        /// 終了ボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 終了Button_Click(object sender, System.EventArgs e)
        {
            if(Messages.ShowConfirm("アプリケーションを終了しますか？"))
            {
                Application.Exit();
            }
        }

        #endregion

    }
}
