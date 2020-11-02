using HotelManagement.Enums;
using HotelManagement.Extensions;
using HotelManagement.Functions;
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
            this.MoveDisplay(Display.Login);
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
                        this.MoveDisplay(Display.Login);
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
            UcBase uc = (UcBase)Activator.CreateInstance(Type.GetType($"{this.GetType().Namespace}.Uc{display}"));
            uc.Dock = DockStyle.Fill;
            this.UcPanel.Controls.Clear();
            this.UcPanel.Controls.Add(uc);
            this.DisplayNameLabel.Text = display.GetDisplayName();
        }
    }
}
