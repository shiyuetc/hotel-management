using System;
using System.Windows.Forms;

namespace HotelManagement.View.Dialog
{
    public partial class UcDialogBase : Form
    {
        public UcDialogBase()
        {
            InitializeComponent();
        }

        private void DialogBaseForm_Load(object sender, EventArgs e)
        {
            if(this.DesignMode)
            {
                return;
            } 
        }
    }
}
