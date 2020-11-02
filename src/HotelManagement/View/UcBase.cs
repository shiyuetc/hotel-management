using Seasar.Quill;
using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class UcBase : UserControl
    {
        protected readonly FmMain Main = null;

        public UcBase(FmMain main = null)
        {
            InitializeComponent();

            this.Main = main;
        }
    }
}
