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
        #region コンストラクタ

        /// <summary>
        /// UcEmployeeクラスを初期化します。
        /// </summary>
        /// <param name="main"></param>
        public UcEmployee(FmMain main) : base(main)
        {
            InitializeComponent();
        }

        #endregion

        #region イベントハンドラ

        /// <summary>
        /// UcEmployeeのLoadイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcEmployee_Load(object sender, System.EventArgs e)
        {
            var vm = new ModelQuillInjector<EmployeeModel>();
            this.SetEmployeeList(vm.Model.GetEmployeeList());
        }

        /// <summary>
        /// EmployeeListViewのMouseDoubleClickイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        #endregion

        #region ListView操作イベント

        /// <summary>
        /// 従業員からリストビューのアイテムを生成します。
        /// </summary>
        /// <param name="employee">従業員</param>
        /// <returns></returns>
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

        /// <summary>
        /// 従業員の配列からリストビューのアイテムの配列を生成します。
        /// </summary>
        /// <param name="employees">従業員の配列</param>
        /// <returns></returns>
        private ListViewItem[] CreateEmployeeListViewItems(Employee[] employees)
        {
            ListViewItem[] listViewItems = new ListViewItem[employees.Length];
            for (int i = 0; i < employees.Length; i++)
            {
                listViewItems[i] = this.CreateEmployeeListViewItem(employees[i]);
            }
            return listViewItems;
        }

        /// <summary>
        /// 従業員リストを初期化します。
        /// </summary>
        /// <param name="employees">従業員のリスト</param>
        private void SetEmployeeList(List<Employee> employees)
        {
            this.EmployeeListView.Init(this.CreateEmployeeListViewItems(employees.ToArray()));
        }

        /// <summary>
        /// 指定した行の従業員を更新します。
        /// </summary>
        /// <param name="rowIndex">対象の行のインデックス</param>
        /// <param name="employee">従業員</param>
        private void UpdateEmployee(int rowIndex, Employee employee)
        {
            this.EmployeeListView.UpdateItem(rowIndex, this.CreateEmployeeListViewItem(employee));
        }

        #endregion
    }
}
