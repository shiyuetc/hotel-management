using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.Models;

namespace HotelManagement.View.Dialog
{
    public partial class UcEmployeeDialog : UcDialogBase
    {
        public Employee Employee { get; private set; }

        public bool UpdateFlag { get; private set; }

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

        private void UpdateButton_Click(object sender, System.EventArgs e)
        {
            if(!Messages.ShowConfirm("従業員を登録しますか？"))
            {
                return;
            }

            this.Employee.LastName = this.LastNameTextBox.Text;
            this.Employee.FirstName = this.FirstNameTextBox.Text;
            this.Employee.RubyName = this.RubyNameTextBox.Text;
            this.Employee.Email = this.EmailTextBox.Text;
            this.Employee.EntryDate = this.EntryDateTimePicker.Value;

            var vm = new ModelQuillInjector<EmployeeModel>();
            vm.Model.UpdateEmployee(this.Employee);
            this.UpdateFlag = true;

            this.Close();
        }
    }
}
