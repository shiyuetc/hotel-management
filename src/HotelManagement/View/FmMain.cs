using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.Controls.CustomControls;
using HotelManagement.Models;
using System;
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
            // メニューボタンを初期化
            this.MenuBar.Init(MenuItems_Click);

            // ログイン画面に遷移
            this.メニュー画面遷移処理("ログイン画面");
        }

        /// <summary>
        /// メニューボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItems_Click(object sender, EventArgs e)
        {
            // 押下されたボタンを取得
            MenuButton menuButton = ((MenuButton)sender);
            Mst制御画面マスタ 制御画面マスタ = menuButton.制御画面マスタ;

            // ログアウトボタンが押下された
            if(制御画面マスタ.優先順位 == 9999)
            {
                if (!Messages.ShowConfirm("ログアウトしますか？"))
                {
                    return;
                }
                this.Setログアウト情報();
            }
            else
            {
                this.MenuBar.SetActivate(制御画面マスタ.画面名);
            }

            // 指定の画面に遷移
            this.メニュー画面遷移処理(制御画面マスタ.画面名);
        }

        #endregion

        #region メインイベント

        /// <summary>
        /// 画面を遷移します。
        /// </summary>
        /// <param name="display">Display列挙体</param>
        private void メニュー画面遷移処理(string 画面名)
        {
            this.UcPanel.Controls.Clear();
            UcBase uc = (UcBase)Activator.CreateInstance(Type.GetType($"{this.GetType().Namespace}.{画面名}"), this);
            this.UcPanel.Controls.Add(uc);
            this.DisplayNameLabel.Text = 画面名;
        }

        /// <summary>
        /// ログイン情報を設定します。
        /// </summary>
        /// <param name="従業員マスタ">ログインした従業員</param>
        public void Setログイン情報(Mst従業員マスタ 従業員マスタ)
        {
            // ログイン情報を設定
            AppState.ログイン従業員 = 従業員マスタ;
            this.LoginInfoLabel.Text = $"ユーザー情報：{従業員マスタ.氏名姓}｜職位：{従業員マスタ.Kbn職位区分.名称}({従業員マスタ.Kbn職位区分.名称英字})";

            // 権限を取得
            var vm = new ModelQuillInjector<ベース画面処理Model>();
            var 制御画面マスタList = vm.Model.Getメニュー権限マスタList(従業員マスタ.Kbn職位区分).Select(x => x.Mst制御画面マスタ).ToList();

            // 操作できるメニューボタンを設定
            this.MenuBar.SetPermission(制御画面マスタList);
        }

        /// <summary>
        /// ログイン情報を破棄します。
        /// </summary>
        public void Setログアウト情報()
        {
            // ログイン情報を破棄
            AppState.ログイン従業員 = null;
            this.LoginInfoLabel.Text = "ユーザー情報：ログインなし";

            this.MenuBar.SetPermission(null);
        }

        #endregion
    }
}
