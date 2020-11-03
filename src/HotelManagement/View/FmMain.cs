using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.Const;
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
        /// ログインした従業員の権限に対応した操作できる画面
        /// </summary>
        private List<Button> EnableButtons = new List<Button>();

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
            // ログイン情報を初期化
            this.SetLogout();
        }

        /// <summary>
        /// メニューボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItems_Click(object sender, EventArgs e)
        {
            // Tagから押下されたボタンを特定
            string tag = ((Button)sender).Tag?.ToString();

            // ログアウトボタンが押下された
            if(string.IsNullOrEmpty(tag))
            {
                if (Messages.ShowConfirm("ログアウトしますか？"))
                {
                    this.SetLogout();
                }
                return;
            }

            // 指定の画面に遷移
            Display targetDisplay = (Display)Enum.Parse(typeof(Display), tag);
            MoveDisplay(targetDisplay);
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
        /// <param name="mstEmployee"></param>
        private void SetLoginInfomation(MstEmployee mstEmployee)
        {
            AppState.LoginEmployee = mstEmployee;
            this.LoginInfoLabel.Text = "ユーザー情報：" +
                (mstEmployee == null ? "ログインなし" : $"{ mstEmployee.Name}｜" +
                $"職位：{mstEmployee.KbnRank.JapaneseName}({mstEmployee.KbnRank.EnglishName})");
        }

        /// <summary>
        /// ログイン処理を実行します。
        /// </summary>
        /// <param name="mstEmployee">ログインした従業員</param>
        public void SetLoginUser(MstEmployee mstEmployee)
        {
            // ログインした従業員の権限によって操作できる画面を分岐
            this.EnableButtons.Clear();
            if (mstEmployee.KbnRank.Code.EqualsAny(Constants.Rank.SystemMaintenancer, Constants.Rank.AssistantManager))
            {
                this.EnableButtons.Add(this.UcReserveButton);
                this.EnableButtons.Add(this.UcHistoryButton);
                this.EnableButtons.Add(this.UcSaleButton);
                this.EnableButtons.Add(this.UcEmployeeButton);
                this.EnableButtons.Add(this.UcCustomerButton);
            }
            else if (mstEmployee.KbnRank.Code.Equals(Constants.Rank.FinancialController))
            {
                this.EnableButtons.Add(this.UcSaleButton);
                this.EnableButtons.Add(this.UcEmployeeButton);
                this.EnableButtons.Add(this.UcCustomerButton);
            }
            else if (mstEmployee.KbnRank.Code.Equals(Constants.Rank.FrontClerk))
            {
                this.EnableButtons.Add(this.UcReserveButton);
                this.EnableButtons.Add(this.UcHistoryButton);
            }
            this.EnableButtons.Add(this.LogoutButton);
            this.EnableButtons.SetEnabled(true);

            // ログイン情報を設定
            this.SetLoginInfomation(mstEmployee);

            // 権限内の一番初めの画面に遷移
            Display targetDisplay = (Display)Enum.Parse(typeof(Display), this.EnableButtons[0].Tag.ToString());
            this.MoveDisplay(targetDisplay);
        }

        /// <summary>
        /// ログアウト処理を実行します。
        /// </summary>
        public void SetLogout()
        {
            // 操作できる画面を無効化する
            this.EnableButtons.SetEnabled(false);

            // ログイン情報を破棄
            this.SetLoginInfomation(null);

            // ログイン画面に遷移
            this.MoveDisplay(Display.Login);
        }
    }
}
