using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.Models;

namespace HotelManagement.View.Dialog
{
    /// <summary>
    /// 従業員情報の編集を行うダイアログフォームクラス
    /// </summary>
    public partial class UcEmployeeDialog : UcDialogBase
    {
        /// <summary>
        /// 従業員情報の受け渡しに利用
        /// </summary>
        public Employee Employee { get; private set; }

        /// <summary>
        /// 登録を行ったかどうか判定するフラグ
        /// </summary>
        public bool UpdateFlag { get; private set; }

        /// <summary>
        /// UcEmployeeDialogクラスを初期化します。
        /// </summary>
        /// <param name="employee">従業員</param>
        public UcEmployeeDialog(Employee employee = null)
        {
            InitializeComponent();

            if (employee != null)
            {
                this.Employee = employee;
                this.Text = $"{employee.FullName}";
                this.EmployeeNoTextBox.Text = employee.EmployeeNo;
                this.LastNameTextBox.Text = employee.LastName;
                this.FirstNameTextBox.Text = employee.FirstName;
                this.RubyNameTextBox.Text = employee.RubyName;
                this.RankComboBox.Text = employee.Rank.JapaneseName;
                this.EmailTextBox.Text = employee.Email;
                this.EntryDateTimePicker.Value = employee.EntryDate.Value;
            }
        }

        /// <summary>
        /// 登録ボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, System.EventArgs e)
        {
            // 登録確認チェック
            if(!Messages.ShowConfirm("従業員を登録しますか？"))
            {
                return;
            }

            // データ登録処理
            this.Employee.LastName = this.LastNameTextBox.Text;
            this.Employee.FirstName = this.FirstNameTextBox.Text;
            this.Employee.RubyName = this.RubyNameTextBox.Text;
            this.Employee.Email = this.EmailTextBox.Text;
            this.Employee.EntryDate = this.EntryDateTimePicker.Value;

            var vm = new ModelQuillInjector<EmployeeModel>();
            vm.Model.UpdateEmployee(this.Employee);
            this.UpdateFlag = true;

            // ダイアログを閉じる
            this.Close();
        }
    }
}
