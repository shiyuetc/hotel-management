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
        /// 制御画面
        /// </summary>
        public Mst制御画面マスタ 制御画面マスタ { get; set; }

        #endregion

        #region コンストラクタ

        /// <summary>
        /// MenuPageクラスを初期化します。
        /// </summary>
        /// <param name="制御画面マスタ">制御画面マスタ</param>
        public MenuPage(Mst制御画面マスタ 制御画面マスタ) : base()
        {
            // 制御画面マスタがnullの場合は何も設定しない
            if (制御画面マスタ == null)
            {
                return;
            }

            this.制御画面マスタ = 制御画面マスタ;

            // プロパティを設定
            this.Text = this.制御画面マスタ.表示名;
        }

        #endregion

    }
}
