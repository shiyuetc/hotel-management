using Dbflute.AllCommon;

namespace HotelManagement.Controls.CustomControls.ConstantComboBox
{
    /// <summary>
    /// 職位区分のコンボボックスを表すクラス
    /// </summary>
    public class RankComboBox : ConstantComboBox
    {
        /// <summary>
        /// RankComboBoxクラスを初期化します。
        /// </summary>
        public RankComboBox()
        {
            this.SetMember(CDef.職位区分.Values, "Alias", "Code");
        }
    }
}
