using Dbflute.ExEntity;
using HotelManagement.Common;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.Controls.CustomControls
{
    /// <summary>
    /// メニューボタンを表すクラス
    /// </summary>
    public class MenuButton : Button
    {
        #region メンバ変数

        /// <summary>
        /// 制御画面
        /// </summary>
        public Mst制御画面マスタ 制御画面マスタ { get; set; }

        /// <summary>
        /// ボタンのアクティブ/非アクティブ
        /// </summary>
        private bool _activate;

        public bool Activate
        {
            get
            {
                return this._activate;
            }
            set
            {
                if(value)
                {
                    this.BackColor = Color.LightGray;
                }
                else
                {
                    this.BackColor = Color.WhiteSmoke;
                }
                this._activate = value;
            }
        }

        #endregion

        #region コンストラクタ

        /// <summary>
        /// MenuButtonクラスを初期化します。
        /// </summary>
        /// <param name="制御画面マスタ">制御画面マスタ</param>
        public MenuButton(Mst制御画面マスタ 制御画面マスタ)
        {
            this.制御画面マスタ = 制御画面マスタ;

            // プロパティを設定
            this.Size = new Size(74, 63);
            this.BackColor = Color.WhiteSmoke;
            this.FlatAppearance.BorderColor = Color.LightGray;
            this.FlatStyle = FlatStyle.Flat;
            this.Image = ResourceUtil.GetMenuIcon(制御画面マスタ.画面名);
            this.TextAlign = ContentAlignment.BottomCenter;
            this.TextImageRelation = TextImageRelation.ImageAboveText;
            this.Text = 制御画面マスタ.表示名;
        }

        #endregion

    }
}
