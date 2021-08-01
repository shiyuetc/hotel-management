using Dbflute.ExEntity;
using HotelManagement.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.Controls.CustomControls
{
    /// <summary>
    /// メニューボタンを表すクラス
    /// </summary>
    [DesignTimeVisible(false)]
    public class MenuButton : Button
    {
        #region メンバ変数

        /// <summary>
        /// アクティブ時の背景色
        /// </summary>
        protected Color ActiveColor { get; set; } = Color.LightSkyBlue;

        /// <summary>
        /// 非アクティブ時の背景色
        /// </summary>
        protected Color InactiveColor { get; set; } = Color.LightGray;

        /// <summary>
        /// メニュー区分
        /// </summary>
        public Kbnメニュー区分 メニュー区分 { get; private set; }

        /// <summary>
        /// 画面マスタのリスト
        /// </summary>
        public List<Mst画面マスタ> 画面マスタList { get; private set; }

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
                this.BackColor = value ? this.ActiveColor : this.InactiveColor;
                this._activate = value;
            }
        }

        #endregion

        #region コンストラクタ

        /// <summary>
        /// MenuButtonクラスを初期化します。
        /// </summary>
        /// <param name="メニュー区分">メニュー区分</param>
        /// <param name="画面マスタリスト">画面マスタリスト</param>
        public MenuButton(Kbnメニュー区分 メニュー区分, List<Mst画面マスタ> 画面マスタList)
        {
            this.メニュー区分 = メニュー区分;
            this.画面マスタList = 画面マスタList;

            // プロパティを設定
            this.Image = ResourceUtil.GetMenuIcon(メニュー区分.メニュー名称);
            this.TextAlign = ContentAlignment.BottomCenter;
            this.TextImageRelation = TextImageRelation.ImageAboveText;
            this.Text = メニュー区分.メニュー名称;

            this.BackColor = this.InactiveColor;
        }

        #endregion

    }
}
