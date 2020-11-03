using Dbflute.ExEntity;
using HotelManagement.Common;
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
            this.SetLogout();
        }

        /// <summary>
        /// メニューボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItems_Click(object sender, EventArgs e)
        {
            switch(((Button)sender).Name)
            {
                case "UcReserveButton":
                    this.MoveDisplay(Display.Reserve);
                    break;
                case "UcHistoryButton":
                    this.MoveDisplay(Display.History);
                    break;
                case "UcSaleButton":
                    this.MoveDisplay(Display.Sale);
                    break;
                case "UcEmployeeButton":
                    this.MoveDisplay(Display.Employee);
                    break;
                case "UcCustomerButton":
                    this.MoveDisplay(Display.Customer);
                    break;
                case "LogoutButton":
                    if(Messages.ShowConfirm("ログアウトしますか？"))
                    {
                        this.SetLogout();
                    }
                    break;
            }
        }

        /// <summary>
        /// 画面を遷移します。
        /// </summary>
        /// <param name="display">Display列挙体</param>
        private void MoveDisplay(Display display)
        {
            this.UcPanel.Controls.Clear();
            UcBase uc = (UcBase)Activator.CreateInstance(
                Type.GetType($"{this.GetType().Namespace}.Uc{display}"), this);
            uc.Dock = DockStyle.Fill;
            this.UcPanel.Controls.Add(uc);
            this.DisplayNameLabel.Text = display.GetDisplayName();
        }

        public void SetLoginUser(MstEmployee mstEmployee)
        {
            this.MenuBarPanel.Enabled = true;
            this.LoginInfoLabel.Text = $"ユーザー情報：{mstEmployee.Name}";
            this.MoveDisplay(Display.Reserve);
        }

        public void SetLogout()
        {
            this.MenuBarPanel.Enabled = false;
            this.LoginInfoLabel.Text = "ユーザー情報：ログインなし";
            this.MoveDisplay(Display.Login);
        }
    }
}
