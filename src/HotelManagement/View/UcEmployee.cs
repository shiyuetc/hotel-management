using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.Extensions;
using HotelManagement.Models;
using HotelManagement.View.Dialog;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagement.View
{
    /// <summary>
    /// 従業員管理画面を表すフォームクラス
    /// </summary>
    public partial class UcEmployee : UcBase
    {
        /// <summary>
        /// UcEmployeeクラスを初期化します。
        /// </summary>
        /// <param name="main"></param>
        public UcEmployee(FmMain main) : base(main)
        {
            InitializeComponent();
        }

        private void UcEmployee_Load(object sender, System.EventArgs e)
        {
            var vm = new ModelQuillInjector<EmployeeModel>();
            this.SetEmployeeList(vm.Model.GetEmployeeList());
        }

        private ListViewItem CreateEmployeeListViewItem(Employee employee)
        {
            return new ListViewItem(new string[] {
                employee.Id.ToString(),
                employee.EmployeeNo,
                $"{employee.LastName} {employee.FirstName}",
                employee.Rank.JapaneseName,
                employee.Email,
                employee.EntryDate.Value.ToShortDateString(),
                employee.IsLeave ? employee.LeaveDate.Value.ToShortDateString() : string.Empty
            });
        }

        private ListViewItem[] CreateEmployeeListViewItems(Employee[] employees)
        {
            ListViewItem[] listViewItems = new ListViewItem[employees.Length];
            for (int i = 0; i < employees.Length; i++)
            {
                listViewItems[i] = this.CreateEmployeeListViewItem(employees[i]);
            }
            return listViewItems;
        }

        private void SetEmployeeList(List<Employee> employees)
        {
            this.EmployeeListView.Visible = false;
            this.EmployeeListView.Items.Clear();
            this.EmployeeListView.Items.AddRange(this.CreateEmployeeListViewItems(employees.ToArray()));
            this.EmployeeListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.EmployeeListView.Visible = true;
        }

        private void UpdateEmployee(int rowIndex, Employee employee)
        {
            this.EmployeeListView.Items[rowIndex] = this.CreateEmployeeListViewItem(employee);
            this.EmployeeListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void EmployeeListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var vm = new ModelQuillInjector<EmployeeModel>();
            var selectItem = this.EmployeeListView.SelectedItems[0];

            var dialog = new UcEmployeeDialog(vm.Model.GetEmployee(selectItem.Text.ToLong()));
            dialog.Left = this.TopLevelControl.Left + (this.TopLevelControl.Width - dialog.Width) / 2;
            dialog.Top = this.TopLevelControl.Top + (this.TopLevelControl.Height - dialog.Height) / 2;
            dialog.ShowDialog();

            if (dialog.UpdateFlag)
            {
                this.UpdateEmployee(selectItem.Index, dialog.Employee);
            }
        }
    }
}
