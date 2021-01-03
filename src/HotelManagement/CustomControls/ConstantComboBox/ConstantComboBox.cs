using System;
using System.Windows.Forms;

namespace HotelManagement.CustomControls.ConstantComboBox
{
    /// <summary>
    /// 区分値用のコンボボックスを表すクラス
    /// </summary>
    public abstract class ConstantComboBox : ComboBox
    {
        /// <summary>
        /// ValueMemberの値を参照するための配列
        /// </summary>
        protected string[] Values { get; private set; }

        /// <summary>
        /// ConstantComboBoxクラスを初期化します。
        /// </summary>
        public ConstantComboBox()
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// DataSourceとMemberを設定します。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">DataSource</param>
        /// <param name="displayMember">DisplayMember</param>
        /// <param name="valueMember">ValueMember</param>
        protected void SetMember<T>(T[] array, string displayMember, string valueMember)
        {
            this.DisplayMember = displayMember;
            this.ValueMember = valueMember;
            this.DataSource = array;

            // ValueMemberの値を変数に記憶
            var valueMemberProperty = typeof(T).GetProperty(valueMember);
            this.Values = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                this.Values[i] = valueMemberProperty.GetValue(array[i]).ToString();
            }
        }

        /// <summary>
        /// ValueMemberの値を指定して対象の項目を選択します。
        /// </summary>
        /// <param name="value">ValueMemberの値</param>
        public void SelectFromValue(string value)
        {
            this.SelectedIndex = Array.IndexOf(this.Values, value);
        }

    }
}
