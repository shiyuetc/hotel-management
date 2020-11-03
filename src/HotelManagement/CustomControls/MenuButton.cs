using HotelManagement.Common;
using HotelManagement.Enums;
using HotelManagement.Extensions;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.CustomControls
{
    public class MenuButton : Button
    {
        public Display Display { get; set; }

        public MenuButton(Display display, string text = "")
        {
            this.Display = display;
            this.Enabled = false;
            this.Size = new Size(74, 63);
            this.Image = ResourceUtil.GetMenuIcon(display);
            this.TextAlign = ContentAlignment.BottomCenter;
            this.TextImageRelation = TextImageRelation.ImageAboveText;
            this.Text = display.GetDisplayName() + text;
        }

    }
}
