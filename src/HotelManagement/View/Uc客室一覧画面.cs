using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class Uc客室一覧画面 : UcBase
    {
        public Uc客室一覧画面(FmMain main) : base(main)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Uc客室一覧画面のLoadイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Uc客室一覧画面_Load(object sender, System.EventArgs e)
        {
            var vm = new ModelQuillInjector<客室マスタModel>();

            // 客室マスタリストを取得
            var 客室マスタLst = vm.Model.Get客室マスタList();

            // 取得した客室マスタリストで初期化
            this.Set客室List(客室マスタLst);
        }

        #region DataGridView操作イベント

        /// <summary>
        /// 客室リストを初期化します。
        /// </summary>
        /// <param name="客室マスタList">客室マスタList</param>
        private void Set客室List(List<Mst客室マスタ> 客室マスタList)
        {
            // データをクリア
            this.客室ListDataGridView.Rows.Clear();

            // 客室マスタリストからRowを生成
            var rows = Create客室ListDataGridViewRows(客室マスタList.ToArray());

            // データを一括で追加
            this.客室ListDataGridView.Rows.AddRange(rows);
        }

        /// <summary>
        /// 客室マスタからリストの行を生成します。
        /// </summary>
        /// <param name="客室マスタ">客室マスタ</param>
        /// <returns></returns>
        private DataGridViewRow Create客室ListDataGridViewRow(Mst客室マスタ 客室マスタ)
        {
            var row = new DataGridViewRow();
            row.CreateCells(this.客室ListDataGridView);
            row.Cells[0].Value = 客室マスタ.客室番号;
            row.Cells[1].Value = 客室マスタ.Mst客室タイプマスタ.客室タイプ名称;
            row.Cells[2].Value = 客室マスタ.喫煙;
            return row;
        }

        /// <summary>
        /// 客室マスタからリストの行の配列を生成します。
        /// </summary>
        /// <param name="客室マスタList">客室マスタList</param>
        /// <returns></returns>
        private DataGridViewRow[] Create客室ListDataGridViewRows(Mst客室マスタ[] 客室マスタList)
        {
            var listViewItems = new DataGridViewRow[客室マスタList.Length];
            for (int i = 0; i < 客室マスタList.Length; i++)
            {
                listViewItems[i] = this.Create客室ListDataGridViewRow(客室マスタList[i]);
            }
            return listViewItems;
        }

        #endregion

    }
}
