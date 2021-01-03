using Dbflute.AllCommon;

namespace HotelManagement.CustomControls.ConstantComboBox
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
            this.SetMember(CDef.Rank.Values, "Alias", "Code");
        }
    }
}
