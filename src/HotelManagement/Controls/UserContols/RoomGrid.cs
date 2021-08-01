using Dbflute.ExEntity;
using HotelManagement.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Controls.UserControls
{
    public partial class RoomGrid : UserControl
    {
        private const int MARGIN_WIDTH = 4;
        private const int MARGIN_HEIGHT = 4;
        private const int COL_COUNT = 8;

        public RoomGrid()
        {
            InitializeComponent();
        }

        public void Init(List<Mst客室マスタ> 客室マスタList)
        {
            this.Controls.Clear();

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

                var btn = new Button();
                btn.Text = $"{客室マスタ.客室番号}号室";
                btn.Font = new Font("MS UI Gothic", 15);
                btn.Size = new Size(100, 60);
                btn.Location = new Point(col * btn.Width + (col + 1) * MARGIN_WIDTH, row * btn.Height + (row + 1) * MARGIN_HEIGHT);
                btn.BackColor = Color.LightGray;
                this.Controls.Add(btn);
                col++;
            }
        }
    }
}
