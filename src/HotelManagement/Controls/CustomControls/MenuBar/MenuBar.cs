using Castle.Core;
using Dbflute.ExEntity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagement.Controls.CustomControls
{
    /// <summary>
    /// メニューバーを表すクラス
    /// </summary>
    public class MenuBar : Panel
    {
        #region メンバ変数

        /// <summary>
        /// メニュー押下時のメソッド
        /// </summary>
        private Action<MenuButton> ClickEventHandle = null;

        #endregion

        /// <summary>
        /// メニューボタンのクリックイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuButton_Click(object sender, EventArgs e)
        {
            // 選択したメニューページを取得
            var menuButton = (MenuButton)sender;

            // イベントを発生
            this.ClickEventHandle(menuButton);
        }

        /// <summary>
        /// メニュー押下時のイベントを設定します。
        /// </summary>
        /// <param name="clickEvent">メニュー押下時のイベント</param>
        public void InitEventHandler(Action<MenuButton> clickEventHandle)
        {
            this.ClickEventHandle = clickEventHandle;
        }

        /// <summary>
        /// メニューを設定します。
        /// </summary>
        /// <param name="画面マスタ">画面マスタ</param>
        public void SetMenu(Mst画面マスタ 画面マスタ)
        {
            var 画面マスタList = new List<Mst画面マスタ>() { 画面マスタ };
            this.SetMenu(画面マスタList);
        }

        /// <summary>
        /// メニューを設定します。
        /// </summary>
        /// <param name="画面マスタList">画面マスタのリスト</param>
        public void SetMenu(List<Mst画面マスタ> 画面マスタList)
        {
            // メニューをクリア
            this.Controls.Clear();

            // メニューを作成
            int cnt = 0;
            var menuButtonList = new List<MenuButton>();
            foreach (var メニュー区分 in 画面マスタList.Select(x => x.Kbnメニュー区分).Distinct().OrderBy(x => x.優先順位))
            {
                var menuButton = new MenuButton(メニュー区分, 画面マスタList.Where(x => x.Kbnメニュー区分.メニューコード == メニュー区分.メニューコード).ToList());
                menuButton.Location = new Point(2 + (menuButton.Width * cnt), 2);
                menuButton.Size = new Size(74, this.Height - 4);
                menuButton.Click += this.MenuButton_Click;

                menuButtonList.Add(menuButton);
                cnt++;
            }

            // メニューを表示
            if (menuButtonList.Any())
            {
                this.Controls.AddRange(menuButtonList.ToArray());
                menuButtonList[0].PerformClick();
            }
        }

        /// <summary>
        /// メニューボタンのアクティブを設定します。
        /// </summary>
        /// <param name="メニュー区分">メニュー区分</param>
        public void SetActivate(Kbnメニュー区分 メニュー区分)
        {
            // コントロールからメニューボタンのリストを取得
            var menuButtonList = new List<MenuButton>();
            foreach(var control in this.Controls)
            {
                if(control is MenuButton)
                {
                    menuButtonList.Add((MenuButton)control);
                }
            }

            // アクティブ・非アクティブを設定
            menuButtonList.Where(x => x.メニュー区分.メニューコード != メニュー区分.メニューコード).ForEach(x => x.Activate = false);
            menuButtonList.Where(x => x.メニュー区分.メニューコード == メニュー区分.メニューコード).ForEach(x => x.Activate = true);
        }
    }
}
