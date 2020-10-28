using HotelManagement.Enums;
using HotelManagement.Extensions;
using System;
using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class FmBase : Form
    {
        public FmBase()
        {
            InitializeComponent();
        }

        private void FmBase_Load(object sender, EventArgs e)
        {
            this.MoveDisplay(Display.Login);
        }

        private void MenuItems_Click(object sender, EventArgs e)
        {
            switch(((Button)sender).Name)
            {
                case "UcReserveButton":
                    this.MoveDisplay(Display.Reserve);
                    break;
                case "UcHistoryButton":
                    this.MoveDisplay(Display.History);
                    break;
                case "UcSaleButton":
                    this.MoveDisplay(Display.Sale);
                    break;
                case "UcEmployeeButton":
                    this.MoveDisplay(Display.Employee);
                    break;
                case "UcCustomerButton":
                    this.MoveDisplay(Display.Customer);
                    break;
                case "LogoutButton":

                    break;
            }
        }

        private void MoveDisplay(Display sc)
        {
            UcBase uc = (UcBase)Activator.CreateInstance(Type.GetType($"HotelManagement.View.Uc{sc}"));
            uc.Dock = DockStyle.Fill;
            this.UcPanel.Controls.Clear();
            this.UcPanel.Controls.Add(uc);
            this.DisplayNameLabel.Text = sc.GetDisplayName();
        }
    }
}
