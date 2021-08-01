using HotelManagement.Common;
using HotelManagement.Models;
using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class 客室状態画面 : UcBase
    {
        public 客室状態画面(FmMain main) : base(main)
        {
            InitializeComponent();
        }

        private void 客室状態画面_Load(object sender, System.EventArgs e)
        {
            var vm = new ModelQuillInjector<客室状態画面処理Model>();
            var 客室マスタList = vm.Model.Get客室マスタList();

            this.roomGrid1.Init(客室マスタList);
        }
    }
}
