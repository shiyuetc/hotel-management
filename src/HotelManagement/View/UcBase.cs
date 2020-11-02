using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class UcBase : UserControl
    {
        protected readonly FmMain Main = null;

        public UcBase()
        {

        }

        public UcBase(FmMain main = null)
        {
            InitializeComponent();
            this.Main = main;
        }
    }
}
