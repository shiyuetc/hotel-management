using Castle.Core;
using Dbflute.ExEntity;
using HotelManagement.Controls.CustomControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagement.Controls.UserControls
{
    /// <summary>
    /// メニューバーを表すクラス
    /// </summary>
    public partial class MenuBar : UserControl
    {
        #region メンバ変数

        /// <summary>
        /// メニューボタンクリック時のイベント
        /// </summary>
        private Action<object, EventArgs> ClickEvent;

        /// <summary>
        /// 表示するメニューボタンを保持する
        /// </summary>
        private readonly List<MenuButton> MenuButtonList = new List<MenuButton>();

        #endregion

        #region コンストラクタ

        /// <summary>
        /// MenuBarを初期化します。
        /// </summary>
        public MenuBar()
        {
            InitializeComponent();
        }

        #endregion

        #region メソッド

        /// <summary>
        /// MenuBarクラスを初期化します。
        /// </summary>
        /// <param name="clickEvent">メニューボタンクリック時のイベント</param>
        public void Init(Action<object, EventArgs> clickEvent)
        {
            this.ClickEvent = clickEvent;
        }

        /// <summary>
        /// メニューボタンを設定します。
        /// </summary>
        /// <param name="Mst制御画面マスタList">制御画面マスタのリスト</param>
        public void SetPermission(List<Mst制御画面マスタ> Mst制御画面マスタList)
        {
            // メニューボタンをクリア
            this.MenuButtonList.Clear();

            // 制御画面マスタリストからメニューボタンを作成
            for (int i = 0; i < Mst制御画面マスタList?.Count; i++)
            {
                var menuButton = new MenuButton(Mst制御画面マスタList[i]);
                menuButton.Location = new Point(2 + (menuButton.Width * i + (i * 2)), 2);
                menuButton.Click += new EventHandler(this.ClickEvent);
                this.MenuButtonList.Add(menuButton);
            }

            // メニューバーパネルのコントロールを初期化
            this.MenuBarPanel.Controls.Clear();
            if(this.MenuButtonList.Count > 0)
            {
                this.MenuBarPanel.Controls.AddRange(this.MenuButtonList.ToArray());
                this.MenuButtonList[0].PerformClick();
            }
        }

        /// <summary>
        /// メニューボタンのアクティブを設定します。
        /// </summary>
        /// <param name="画面名">画面名</param>
        public void SetActivate(string 画面名)
        {
            // 画面名とは異なるボタンをすべて非アクティブに設定
            this.MenuButtonList.Where(x => x.制御画面マスタ.画面名 != 画面名)
                .ForEach(x => x.Activate = false);

            // 画面名と等しいボタンをアクティブに設定
            this.MenuButtonList.Where(x => x.制御画面マスタ.画面名 == 画面名)
                .First().Activate = true;
        }

        #endregion

    }
}
