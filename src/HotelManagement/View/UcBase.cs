using System.ComponentModel;
using System.Windows.Forms;

namespace HotelManagement.View
{
    /// <summary>
    /// ベースフォームクラス
    /// </summary>
    [DesignTimeVisible(false)]
    public partial class UcBase : UserControl
    {
        #region メンバ変数

        /// <summary>
        /// FmMain
        /// </summary>
        protected readonly FmMain Main = null;

        #endregion

        #region コンストラクタ

        /// <summary>
        /// UcBaseクラスを初期化します。
        /// </summary>
        public UcBase()
        {

        }

        /// <summary>
        /// UcBaseクラスを初期化します。
        /// </summary>
        /// <param name="main">FmMain</param>
        public UcBase(FmMain main = null)
        {
            InitializeComponent();
            this.Main = main;
        }

        #endregion
    }
}
