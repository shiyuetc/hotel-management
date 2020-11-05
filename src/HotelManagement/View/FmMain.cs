using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.Const;
using HotelManagement.CustomControls;
using HotelManagement.Enums;
using HotelManagement.Extensions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagement.View
{
    /// <summary>
    /// メインフォームのクラス
    /// </summary>
    public partial class FmMain : Form
    {
        /// <summary>
        /// FmMainを初期化します。
        /// </summary>
        public FmMain()
        {
            InitializeComponent();
        }

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
        /// <param name="mstEmployee">設定する従業員</param>
        private void SetLoginInfomation(MstEmployee mstEmployee)
        {
            AppState.LoginEmployee = mstEmployee;
            this.LoginInfoLabel.Text = "ユーザー情報：" +
                (mstEmployee == null ? "ログインなし" : $"{mstEmployee.LastName} {mstEmployee.FirstName}｜" +
                $"職位：{mstEmployee.KbnRank.JapaneseName}({mstEmployee.KbnRank.EnglishName})");
        }

        /// <summary>
        /// ログイン処理を実行します。
        /// </summary>
        /// <param name="mstEmployee">ログインした従業員</param>
        public void SetLoginUser(MstEmployee mstEmployee)
        {
            // 操作できる画面を有効化
            this.MenuBar.SetEnabled(true, Constants.Permissions[mstEmployee.KbnRank.Code]);

            // ログイン情報を設定
            this.SetLoginInfomation(mstEmployee);

            // 権限内の一番初めの画面に遷移
            this.MoveDisplay(this.MenuBar.GetEnableButtonFirst().Display);
        }

        /// <summary>
        /// ログアウト処理を実行します。
        /// </summary>
        public void SetLogout()
        {
            // 操作できる画面を無効化
            this.MenuBar.SetEnabled(false, Constants.Permissions[AppState.LoginEmployee.KbnRank.Code]);

            // ログイン情報を破棄
            this.SetLoginInfomation(null);
        }
    }
}
