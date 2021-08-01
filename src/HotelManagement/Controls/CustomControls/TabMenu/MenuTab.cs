using Dbflute.ExEntity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagement.Controls.CustomControls
{
    /// <summary>
    /// メニュータブを表すクラス
    /// </summary>
    public class MenuTab : TabControl
    {
        #region メンバ変数

        /// <summary>
        /// メニュー選択時のメソッド
        /// </summary>
        private Action<MenuPage> SelectEventHandle = null;

        #endregion

        #region コンストラクタ

        /// <summary>
        /// TabMenuクラスを初期化します。
        /// </summary>
        public MenuTab() : base()
        {
            this.SelectedIndexChanged += new EventHandler(MenuTab_SelectedIndexChanged);
            this.DrawItem += new DrawItemEventHandler(MenuTab_DrawItem);
        }

        #endregion

        #region イベントハンドラ

        /// <summary>
        /// タブメニューの選択タブ変更イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択したメニューページを取得
            var menuTab = (MenuPage)this.SelectedTab;

            // メニューページか選択イベントメソッドがnullなら何もしない
            if(menuTab == null || this.SelectEventHandle == null)
            {
                return;
            }

            // イベントを発生
            this.SelectEventHandle(menuTab);
        }

        /// <summary>
        /// タブメニューのドローアイテムイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            // タブページのテキストを取得
            string txt = this.TabPages[e.Index].Text;

            // 中央に表示する
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            // 描画処理
            e.Graphics.DrawString(txt, e.Font, Brushes.Black, e.Bounds, sf);
        }

        #endregion

        #region メソッド

        /// <summary>
        /// メニュー選択時のイベントを設定します。
        /// </summary>
        /// <param name="selectEventHandle">メニュー選択時のイベント</param>
        public void InitEventHandler(Action<MenuPage> selectEventHandle)
        {
            this.SelectEventHandle = selectEventHandle;
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
            this.TabPages.Clear();

            // メニューを作成
            var menuTabList = new List<MenuPage>() { new MenuPage(null) };
            foreach (var 画面マスタ in 画面マスタList.OrderBy(x => x.優先順位))
            {
                var menuTab = new MenuPage(画面マスタ);
                menuTabList.Add(menuTab);
            }

            // メニューを表示
            if (menuTabList.Any())
            {
                this.TabPages.AddRange(menuTabList.ToArray());
            }

            // ダミーのメニューページを削除(イベントが発生する)
            this.TabPages.RemoveAt(0);
        }

        #endregion

    }
}
