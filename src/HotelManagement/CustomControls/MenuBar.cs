using HotelManagement.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.CustomControls
{
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        public void SetMenuButtons(List<MenuButton> menuButtons, Action<object, EventArgs> clickEvent)
        {
            this.MenuBarPanel.Controls.Clear();
            for (int i = 0; i < menuButtons.Count; i++)
            {
                menuButtons[i].Location = new Point(2 + (menuButtons[i].Width * i), 2);
                menuButtons[i].Click += new EventHandler(clickEvent);
            }
            this.MenuBarPanel.Controls.AddRange(menuButtons.ToArray());
        }

        public MenuButton GetMenuButton(Display display)
        {
            foreach(Control control in this.MenuBarPanel.Controls)
            {
                if(control is MenuButton && ((MenuButton)control).Display == display)
                {
                    return (MenuButton)control;
                }
            }
            return null;
        }
    }
}
