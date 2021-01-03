using HotelManagement.Common;
using HotelManagement.Const;
using HotelManagement.Controls.CustomControls;
using HotelManagement.Enums;
using HotelManagement.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.Controls.UserControls
{
    /// <summary>
    /// メニューバーを表すクラス
    /// </summary>
    public partial class MenuBar : UserControl
    {
        /// <summary>
        /// 表示するメニューボタンを保持する
        /// </summary>
        private readonly Dictionary<Display, MenuButton> MenuButtons = new Dictionary<Display, MenuButton>();

        /// <summary>
        /// MenuBarを初期化します。
        /// </summary>
        public MenuBar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// メニューボタンを初期化します。
        /// </summary>
        /// <param name="clickEvent">メニューボタンクリック時のイベント</param>
        public void InitMenuButtons(Action<object, EventArgs> clickEvent)
        {
            Display[] displays = (Display[])Enum.GetValues(typeof(Display));
            for (int i = 0; i < displays.Length; i++)
            {
                var menuButton = new MenuButton(displays[i]);
                menuButton.Location = new Point(2 + (menuButton.Width * i), 2);
                menuButton.Click += new EventHandler(clickEvent);
                this.MenuButtons.Add(displays[i], menuButton);
            }
            this.MenuBarPanel.Controls.AddRange(this.MenuButtons.GetValueArray());
        }
        
        /// <summary>
        /// メニューボタンの活性を変更します。
        /// </summary>
        /// <param name="enabled">有効/無効</param>
        public void SetEnabled(bool enabled)
        {
            var displays = Constants.Permissions[AppState.LoginEmployee.Rank.Code];
            foreach (Display display in displays)
            {
                this.MenuButtons[display].Enabled = enabled;
            }
            this.MenuButtons[Display.Login].Enabled = enabled;
        }

        /// <summary>
        /// 1つめの有効化されているボタンを取得します。
        /// </summary>
        /// <returns>1つめの有効化されているボタンを返す</returns>
        public MenuButton GetEnableButtonFirst()
        {
            foreach (Display display in Enum.GetValues(typeof(Display)))
            {
                if(this.MenuButtons[display].Enabled)
                {
                    return this.MenuButtons[display];
                }
            }
            return null;
        }
    }
}
