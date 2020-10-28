using HotelManagement.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class FmBase : Form
    {
        Dictionary<string, Display> ScreenDictionary = new Dictionary<string, Display>()
        {
            { "ログイン", Display.Login }
        };

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

        }

        private void MoveDisplay(Display sc)
        {
            UcBase uc = (UcBase)Activator.CreateInstance(Type.GetType($"HotelManagement.View.Uc{sc}"));
            uc.Dock = DockStyle.Fill;
            this.UcPanel.Controls.Clear();
            this.UcPanel.Controls.Add(uc);
        }
    }
}
