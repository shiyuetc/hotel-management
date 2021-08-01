using Dbflute.ExEntity;
using System.Windows.Forms;

namespace HotelManagement.Controls.CustomControls
{
    /// <summary>
    /// メニューページを表すクラス
    /// </summary>
    public class MenuPage : TabPage
    {
        #region メンバ変数

        /// <summary>
        /// 画面
        /// </summary>
        public Mst画面マスタ 画面マスタ { get; set; }

        #endregion

        #region コンストラクタ

        /// <summary>
        /// MenuPageクラスを初期化します。
        /// </summary>
        /// <param name="画面マスタ">画面マスタ</param>
        public MenuPage(Mst画面マスタ 画面マスタ) : base()
        {
            // 画面マスタがnullの場合は何も設定しない
            if (画面マスタ == null)
            {
                return;
            }

            this.画面マスタ = 画面マスタ;

            // プロパティを設定
            this.Text = this.画面マスタ.画面名称;
        }

        #endregion

    }
}
