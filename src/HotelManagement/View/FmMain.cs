using Dbflute.AllCommon;
using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.Controls.CustomControls;
using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            // メニューバーを初期化
            this.MenuBar.InitEventHandler(MenuButton_Click);

            // メニュータブを初期化
            this.MenuTab.InitEventHandler(MenuPage_Select);

            // ログイン画面に遷移
            var vm = new ModelQuillInjector<ベース画面処理Model>();
            var 画面マスタ = vm.Model.Getログイン画面マスタ();
            
            this.MenuTab.SetMenu(画面マスタ);
        }

        #endregion

        #region メインイベント

        /// <summary>
        /// メニューボタンの押下時イベント
        /// </summary>
        /// <param name="menuButton">押下したメニューボタン</param>
        private void MenuButton_Click(MenuButton menuButton)
        {
            // ログアウトボタンが押下された
            if (menuButton.メニュー区分.メニューコード == CDef.メニュー区分.ログアウト.Code)
            {
                if (Messages.ShowConfirm("ログアウトしますか？"))
                {
                    this.Setログアウト情報();
                }
                else
                {
                    return;
                }
            }

            // 選択したボタンをアクティブに、他のボタンを非アクティブに設定
            this.MenuBar.SetActivate(menuButton.メニュー区分);

            // メニューバーを設定
            this.MenuTab.SetMenu(menuButton.画面マスタList);
        }

        /// <summary>
        /// メニューページの選択時イベント
        /// </summary>
        /// <param name="menuPage">選択したメニューページ</param>
        private void MenuPage_Select(MenuPage menuPage)
        {
            // 表示画面を破棄
            this.UcPanel.Controls.Clear();

            var uc = (UcBase)Activator.CreateInstance(Type.GetType($"{this.GetType().Namespace}.{menuPage.画面マスタ.表示名称}"), this);
            this.UcPanel.Controls.Add(uc);

            // 表示画面名を設定
            this.DisplayNameLabel.Text = $"{menuPage.画面マスタ.表示名称}";
        }

        /// <summary>
        /// ログイン情報を設定します。
        /// </summary>
        /// <param name="従業員マスタ">ログインした従業員</param>
        public void Setログイン情報(Mst従業員マスタ 従業員マスタ)
        {
            // ログイン情報を設定
            AppState.ログイン従業員 = 従業員マスタ;
            this.LoginInfoLabel.Text = $"ユーザー情報：{従業員マスタ.氏名}｜職位：{従業員マスタ.Kbn職位区分.職位名称}({従業員マスタ.Kbn職位区分.職位英字名称})";

            // 取得した権限を設定
            var vm = new ModelQuillInjector<ベース画面処理Model>();
            var 画面マスタList = vm.Model.Get画面マスタListt(従業員マスタ.Kbn職位区分).ToList();

            // メニューバーを設定
            this.MenuBar.SetMenu(画面マスタList);
        }

        /// <summary>
        /// ログイン情報を破棄します。
        /// </summary>
        public void Setログアウト情報()
        {
            // ログイン情報を破棄
            AppState.ログイン従業員 = null;
            this.LoginInfoLabel.Text = "ユーザー情報：ログインなし";

            // メニューバーを初期化
            this.MenuBar.SetMenu(new List<Mst画面マスタ>());
        }

        #endregion

    }
}
