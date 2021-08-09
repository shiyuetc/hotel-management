using Dbflute.AllCommon;
using Dbflute.ExEntity;
using HotelManagement.Controls.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagement.Controls.UserControls
{
    public partial class RoomGrid : UserControl
    {
        #region 定数

        /// <summary>
        /// 横の客室ボタン間隔
        /// </summary>
        private const int MARGIN_WIDTH = 4;

        /// <summary>
        /// 縦の客室ボタン間隔
        /// </summary>
        private const int MARGIN_HEIGHT = 4;

        /// <summary>
        /// 1列に表示できるボタン数
        /// </summary>
        private const int COL_COUNT = 8;

        #endregion

        #region コンストラクタ

        /// <summary>
        /// RoomGridクラスを初期化します。
        /// </summary>
        public RoomGrid()
        {
            InitializeComponent();
        }

        #endregion

        public void Init(List<Mst客室マスタ> 客室マスタList, List<Dch客室利用台帳> 客室利用台帳List)
        {
            // コントロールを初期化
            this.Controls.Clear();

            // 客室マスタがない場合は終了
            if(!客室マスタList.Any())
            {
                return;
            }

            int current階層 = 客室マスタList[0].階層;
            int col = 0, row = 0;
            foreach(var 客室マスタ in 客室マスタList)
            {
                // 階層が異なる、または最大列数を超えた場合は次の行へ
                if (current階層 != 客室マスタ.階層 || col >= COL_COUNT)
                {
                    current階層 = 客室マスタ.階層;
                    col = 0;
                    row++;
                }

                // 客室の利用情況を取得
                var 対象客室利用台帳List = 客室利用台帳List.Where(x => x.客室コード == 客室マスタ.客室コード).FirstOrDefault();

                // 客室ボタンを作成
                var 客室btn = new 客室Button(客室マスタ.客室番号, 対象客室利用台帳List);
                客室btn.Location = new Point(col * 客室btn.Width + (col + 1) * MARGIN_WIDTH, row * 客室btn.Height + (row + 1) * MARGIN_HEIGHT);
                
                // コントロールを追加
                this.Controls.Add(客室btn);
                col++;
            }

        }
    }
}
