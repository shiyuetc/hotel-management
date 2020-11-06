using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.Models;
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
            var employees = vm.Model.GetEmployeeList();

            this.SetEmployeeList(employees);
        }

        private void SetEmployeeList(Employee[] employees)
        {
            this.EmployeeListView.Items.Clear();
            ListViewItem[] listViewItems = new ListViewItem[employees.Length];
            for (int i = 0; i < employees.Length; i++)
            {
                listViewItems[i] = new ListViewItem(new string[] {
                    employees[i].EmployeeNo,
                    $"{employees[i].LastName} {employees[i].FirstName}",
                    employees[i].Rank.JapaneseName,
                    employees[i].EntryDate.Value.ToShortDateString(),
                    employees[i].IsLeave ? employees[i].LeaveDate.Value.ToShortDateString() : string.Empty
                });
            }
            this.EmployeeListView.Items.AddRange(listViewItems);
            this.EmployeeListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
