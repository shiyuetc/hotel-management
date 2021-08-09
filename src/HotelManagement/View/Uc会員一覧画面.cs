using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.Extensions;
using HotelManagement.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagement.View
{
    /// <summary>
    /// 会員一覧画面を表すフォームクラス
    /// </summary>
    public partial class Uc会員一覧画面 : UcBase
    {
        #region コンストラクタ

        /// <summary>
        /// Uc会員一覧画面クラスを初期化します。
        /// </summary>
        /// <param name="main"></param>
        public Uc会員一覧画面(FmMain main) : base(main)
        {
            InitializeComponent();
        }

        #endregion

        private void Uc会員一覧画面_Load(object sender, System.EventArgs e)
        {
            var vm = new ModelQuillInjector<会員マスタModel>();

            // 会員マスタリストを取得
            var 会員マスタLst = vm.Model.Get会員マスタList();

            // 取得した会員マスタリストで初期化
            this.Set会員List(会員マスタLst);
        }

        #region DataGridView操作イベント

        /// <summary>
        /// 会員リストを初期化します。
        /// </summary>
        /// <param name="会員マスタList">会員マスタList</param>
        private void Set会員List(List<Mst会員マスタ> 会員マスタList)
        {
            // データをクリア
            this.会員ListDataGridView.Rows.Clear();

            // 会員マスタリストからRowを生成
            var rows = Create会員ListDataGridViewRows(会員マスタList.ToArray());

            // データを一括で追加
            this.会員ListDataGridView.Rows.AddRange(rows);
        }

        /// <summary>
        /// 会員マスタからリストの行を生成します。
        /// </summary>
        /// <param name="会員マスタ">会員マスタ</param>
        /// <returns></returns>
        private DataGridViewRow Create会員ListDataGridViewRow(Mst会員マスタ 会員マスタ)
        {
            var row = new DataGridViewRow();
            row.CreateCells(this.会員ListDataGridView);
            row.Cells[0].Value = 会員マスタ.会員番号;
            row.Cells[1].Value = 会員マスタ.氏名;
            row.Cells[2].Value = 会員マスタ.メールアドレス;
            row.Cells[3].Value = 会員マスタ.電話番号;
            row.Cells[4].Value = 会員マスタ.入会年月日.Value.ToYYYYMMDD();
            return row;
        }

        /// <summary>
        /// 会員マスタからリストの行の配列を生成します。
        /// </summary>
        /// <param name="会員マスタList">会員マスタList</param>
        /// <returns></returns>
        private DataGridViewRow[] Create会員ListDataGridViewRows(Mst会員マスタ[] 会員マスタList)
        {
            var listViewItems = new DataGridViewRow[会員マスタList.Length];
            for (int i = 0; i < 会員マスタList.Length; i++)
            {
                listViewItems[i] = this.Create会員ListDataGridViewRow(会員マスタList[i]);
            }
            return listViewItems;
        }

        #endregion

    }
}
