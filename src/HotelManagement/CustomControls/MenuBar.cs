using HotelManagement.Enums;
using HotelManagement.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.CustomControls
{
    public partial class MenuBar : UserControl
    {
        private readonly Dictionary<Display, MenuButton> MenuButtons = new Dictionary<Display, MenuButton>();

        public MenuBar()
        {
            InitializeComponent();
        }

        public void InitMenuButtons(Action<object, EventArgs> clickEvent)
        {
            Display[] displays = (Display[])Enum.GetValues(typeof(Display));
            for (int i = 0; i < displays.Length; i++)
            {
                var menuButton = new MenuButton(displays[i]);
                menuButton.Location = new Point(2 + (menuButton.Width * i), 2);
                menuButton.Click += new EventHandler(clickEvent);
                this.MenuButtons.Add(displays[i], menuButton);
            }
            this.MenuBarPanel.Controls.AddRange(this.MenuButtons.GetValueArray());
        }

        public void SetEnabled(bool enabled, Display[] displays)
        {
            foreach(Display display in displays)
            {
                this.MenuButtons[display].Enabled = enabled;
            }
            this.MenuButtons[Display.Login].Enabled = enabled;
        }

        public MenuButton GetEnableButtonFirst()
        {
            foreach (Display display in Enum.GetValues(typeof(Display)))
            {
                if(this.MenuButtons[display].Enabled)
                {
                    return this.MenuButtons[display];
                }
            }
            return null;
        }
    }
}
