using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.CustomControls;
using HotelManagement.Enums;
using HotelManagement.Extensions;
using System;
using System.Windows.Forms;

namespace HotelManagement.View
{
    /// <summary>
    /// メインフォームのクラス
    /// </summary>
    public partial class FmMain : Form
    {
        #region コンストラクタ

        /// <summary>
        /// FmMainを初期化します。
        /// </summary>
        public FmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region イベンドハンドラ

        /// <summary>
        /// FmMainのロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FmMain_Load(object sender, EventArgs e)
        {
            // メニューボタンを初期化
            this.MenuBar.InitMenuButtons(MenuItems_Click);

            // ログイン画面に遷移
            this.MoveDisplay(Display.Login);
        }

        /// <summary>
        /// メニューボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItems_Click(object sender, EventArgs e)
        {
            // Tagから押下されたボタンを特定
            Display? targetDisplay = ((MenuButton)sender).Display;

            // ログアウトボタンが押下された
            if(targetDisplay == Display.Login)
            {
                if (!Messages.ShowConfirm("ログアウトしますか？"))
                {
                    return;
                }
                this.SetLogout();
            }

            // 指定の画面に遷移
            this.MoveDisplay((Display)targetDisplay);
        }

        #endregion

        #region メインイベント

        /// <summary>
        /// 画面を遷移します。
        /// </summary>
        /// <param name="display">Display列挙体</param>
        private void MoveDisplay(Display display)
        {
            this.UcPanel.Controls.Clear();
            UcBase uc = (UcBase)Activator.CreateInstance(Type.GetType($"{this.GetType().Namespace}.Uc{display}"), this);
            this.UcPanel.Controls.Add(uc);
            this.DisplayNameLabel.Text = display.GetDisplayName();
        }

        /// <summary>
        /// ログイン情報を設定します。
        /// </summary>
        /// <param name="employee">設定する従業員</param>
        private void SetLoginInfomation(Employee employee)
        {
            AppState.LoginEmployee = employee;
            this.LoginInfoLabel.Text = "ユーザー情報：" +
                (employee == null ? "ログインなし" : $"{employee.FullName}｜" +
                $"職位：{employee.Rank.JapaneseName}({employee.Rank.EnglishName})");
        }

        /// <summary>
        /// ログイン処理を実行します。
        /// </summary>
        /// <param name="employee">ログインした従業員</param>
        public void SetLoginUser(Employee employee)
        {
            // ログイン情報を設定
            this.SetLoginInfomation(employee);

            // 操作できる画面を有効化
            this.MenuBar.SetEnabled(true);

            // 権限内の一番初めの画面に遷移
            this.MoveDisplay(this.MenuBar.GetEnableButtonFirst().Display);
        }

        /// <summary>
        /// ログアウト処理を実行します。
        /// </summary>
        public void SetLogout()
        {
            // 操作できる画面を無効化
            this.MenuBar.SetEnabled(false);

            // ログイン情報を破棄
            this.SetLoginInfomation(null);
        }

        #endregion
    }
}
