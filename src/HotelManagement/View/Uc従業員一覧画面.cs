using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.Extensions;
using HotelManagement.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagement.View
{
    /// <summary>
    /// 従業員一覧画面を表すフォームクラス
    /// </summary>
    public partial class Uc従業員一覧画面 : UcBase
    {
        #region コンストラクタ

        /// <summary>
        /// Uc従業員一覧画面クラスを初期化します。
        /// </summary>
        /// <param name="main"></param>
        public Uc従業員一覧画面(FmMain main) : base(main)
        {
            InitializeComponent();
        }

        #endregion

        #region イベントハンドラ

        /// <summary>
        /// Uc従業員一覧画面のLoadイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Uc従業員一覧画面_Load(object sender, System.EventArgs e)
        {
            var vm = new ModelQuillInjector<従業員マスタModel>();

            // 従業員マスタリストを取得
            var 従業員マスタLst = vm.Model.Get従業員マスタList();

            // 取得した従業員マスタリストで初期化
            this.Set従業員List(従業員マスタLst);
        }

        /// <summary>
        /// EmployeeListViewのMouseDoubleClickイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var vm = new ModelQuillInjector<従業員マスタModel>();
            //var selectItem = this.EmployeeListView.SelectedItems[0];
        }

        #endregion

        #region DataGridView操作イベント

        /// <summary>
        /// 従業員リストを初期化します。
        /// </summary>
        /// <param name="従業員マスタList">従業員マスタList</param>
        private void Set従業員List(List<Mst従業員マスタ> 従業員マスタList)
        {
            // データをクリア
            this.従業員ListDataGridView.Rows.Clear();

            // 従業員マスタリストからRowを生成
            var rows = Create従業員ListDataGridViewRows(従業員マスタList.ToArray());

            // データを一括で追加
            this.従業員ListDataGridView.Rows.AddRange(rows);
        }

        /// <summary>
        /// 従業員マスタからリストの行を生成します。
        /// </summary>
        /// <param name="従業員マスタ">従業員マスタ</param>
        /// <returns></returns>
        private DataGridViewRow Create従業員ListDataGridViewRow(Mst従業員マスタ 従業員マスタ)
        {
            var row = new DataGridViewRow();
            row.CreateCells(this.従業員ListDataGridView);
            row.Cells[0].Value = 従業員マスタ.従業員番号;
            row.Cells[1].Value = 従業員マスタ.氏名;
            row.Cells[2].Value = 従業員マスタ.Kbn職位区分.職位名称;
            row.Cells[3].Value = 従業員マスタ.メールアドレス;
            row.Cells[4].Value = 従業員マスタ.入社年月日.Value.ToYYYYMMDD();
            return row;
        }

        /// <summary>
        /// 従業員マスタからリストの行の配列を生成します。
        /// </summary>
        /// <param name="従業員マスタList">従業員マスタList</param>
        /// <returns></returns>
        private DataGridViewRow[] Create従業員ListDataGridViewRows(Mst従業員マスタ[] 従業員マスタList)
        {
            var listViewItems = new DataGridViewRow[従業員マスタList.Length];
            for (int i = 0; i < 従業員マスタList.Length; i++)
            {
                listViewItems[i] = this.Create従業員ListDataGridViewRow(従業員マスタList[i]);
            }
            return listViewItems;
        }

        #endregion

    }
}
