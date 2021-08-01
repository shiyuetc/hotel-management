using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.Controls.UserContols
{
    /// <summary>
    /// カラーブロックラベルを表すクラス
    /// </summary>
    public partial class ColorBlockLabel : UserControl
    {
        #region プロパティ

        /// <summary>
        /// カラーブロックの色を設定
        /// </summary>
        [Browsable(true)]
        [Category("表示")]
        public Color BlockColor
        {
            get
            {
                return this.ColorBlockPictureBox.BackColor;
            }
            set
            {
                this.ColorBlockPictureBox.BackColor = value;
            }
        }

        /// <summary>
        /// ラベルのテキストを設定
        /// </summary>
        [Browsable(true)]
        [Category("表示")]
        public string LabelText
        {
            get
            {
                return this.TextLabel.Text;
            }
            set
            {
                this.TextLabel.Text = value;
            }
        }

        #endregion

        #region コンストラクタ

        /// <summary>
        /// ColorBlockLabelクラスを初期化します。
        /// </summary>
        public ColorBlockLabel()
        {
            InitializeComponent();
        }

        #endregion

    }
}
