using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.Const;
using HotelManagement.CustomControls;
using HotelManagement.Enums;
using HotelManagement.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.View
{
    /// <summary>
    /// メインフォームのクラス
    /// </summary>
    public partial class FmMain : Form
    {
        /// <summary>
        /// メニューバーに表示されるメニューボタン
        /// </summary>
        private readonly List<MenuButton> MenuButtons = new List<MenuButton>()
        {
            new MenuButton(Display.Reserve, "予約管理\r\n[開発中]"),
            new MenuButton(Display.History, "宿泊履歴\r\n[開発中]"),
            new MenuButton(Display.Sale, "売上管理\r\n[開発中]"),
            new MenuButton(Display.Employee, "従業員管理\r\n[開発中]"),
            new MenuButton(Display.Customer, "顧客管理\r\n[開発中]"),
            new MenuButton(Display.Room, "客室管理\r\n[開発中]"),
            new MenuButton(Display.Login, "ログアウト")
        };

        /// <summary>
        /// ログインした従業員の権限に対応した操作できるメニューボタン
        /// </summary>
        private List<MenuButton> EnableMenuButtons = new List<MenuButton>();

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
            this.MenuBar.SetMenuButtons(this.MenuButtons, MenuItems_Click);

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
            this.EnableMenuButtons.Clear();
            if (mstEmployee.KbnRank.Code.EqualsAny(Constants.Rank.SystemMaintenancer, Constants.Rank.AssistantManager))
            {
                this.EnableMenuButtons.AddRange(new MenuButton[] {
                    this.MenuBar.GetMenuButton(Display.Reserve),
                    this.MenuBar.GetMenuButton(Display.History),
                    this.MenuBar.GetMenuButton(Display.Sale),
                    this.MenuBar.GetMenuButton(Display.Employee),
                    this.MenuBar.GetMenuButton(Display.Customer),
                    this.MenuBar.GetMenuButton(Display.Room)
                });
            }
            else if (mstEmployee.KbnRank.Code.Equals(Constants.Rank.FinancialController))
            {
                this.EnableMenuButtons.AddRange(new MenuButton[] {
                    this.MenuBar.GetMenuButton(Display.History),
                    this.MenuBar.GetMenuButton(Display.Sale),
                    this.MenuBar.GetMenuButton(Display.Employee),
                    this.MenuBar.GetMenuButton(Display.Customer)
                });
            }
            else if (mstEmployee.KbnRank.Code.Equals(Constants.Rank.FrontClerk))
            {
                this.EnableMenuButtons.AddRange(new MenuButton[] {
                    this.MenuBar.GetMenuButton(Display.Reserve),
                    this.MenuBar.GetMenuButton(Display.History)
                });
            }
            this.EnableMenuButtons.Add(this.MenuBar.GetMenuButton(Display.Login));
            this.EnableMenuButtons.SetEnabled(true);

            // ログイン情報を設定
            this.SetLoginInfomation(mstEmployee);

            // 権限内の一番初めの画面に遷移
            this.MoveDisplay(this.EnableMenuButtons[0].Display);
        }

        /// <summary>
        /// ログアウト処理を実行します。
        /// </summary>
        public void SetLogout()
        {
            // 操作できる画面を無効化する
            this.EnableMenuButtons.SetEnabled(false);

            // ログイン情報を破棄
            this.SetLoginInfomation(null);
        }
    }
}
