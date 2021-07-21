using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.Extensions;
using HotelManagement.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagement.View
{
    /// <summary>
    /// 従業員管理画面を表すフォームクラス
    /// </summary>
    public partial class 従業員管理画面 : UcBase
    {
        #region コンストラクタ

        /// <summary>
        /// UcEmployeeクラスを初期化します。
        /// </summary>
        /// <param name="main"></param>
        public 従業員管理画面(FmMain main) : base(main)
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
            var vm = new ModelQuillInjector<従業員マスタModel>();
            //this.SetEmployeeList(vm.Model.Get従業員マスタList());
        }

        /// <summary>
        /// RegisterButtonのClickイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            var vm = new ModelQuillInjector<従業員マスタModel>();

        }

        /// <summary>
        /// EmployeeListViewのMouseDoubleClickイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var vm = new ModelQuillInjector<従業員マスタModel>();
            var selectItem = this.EmployeeListView.SelectedItems[0];

        }

        #endregion

        #region ListView操作イベント

        /// <summary>
        /// 従業員リストを初期化します。
        /// </summary>
        /// <param name="employees">従業員のリスト</param>
        private void SetEmployeeList(List<Mst従業員マスタ> 従業員マスタ)
        {
            this.EmployeeListView.Init(this.CreateEmployeeListViewItems(従業員マスタ.ToArray()));
        }

        /// <summary>
        /// 従業員からリストビューのアイテムを生成します。
        /// </summary>
        /// <param name="employee">従業員</param>
        /// <returns></returns>
        private ListViewItem CreateEmployeeListViewItem(Mst従業員マスタ 従業員マスタ)
        {
            return new ListViewItem(new string[] {
                従業員マスタ.Id.ToString(),
                従業員マスタ.従業員番号,
                $"{従業員マスタ.氏名姓} {従業員マスタ.氏名名}",
                従業員マスタ.Kbn職位区分.名称,
                従業員マスタ.メールアドレス,
                従業員マスタ.入社年月日.Value.ToShortDateString(),
                //従業員マスタ.退社年月日 ? 従業員マスタ.退社年月日.Value.ToShortDateString() : string.Empty
            });
        }

        /// <summary>
        /// 従業員の配列からリストビューのアイテムの配列を生成します。
        /// </summary>
        /// <param name="employees">従業員の配列</param>
        /// <returns></returns>
        private ListViewItem[] CreateEmployeeListViewItems(Mst従業員マスタ[] 従業員マスタList)
        {
            var listViewItems = new ListViewItem[従業員マスタList.Length];
            for (int i = 0; i < 従業員マスタList.Length; i++)
            {
                listViewItems[i] = this.CreateEmployeeListViewItem(従業員マスタList[i]);
            }
            return listViewItems;
        }

        #endregion

    }
}
