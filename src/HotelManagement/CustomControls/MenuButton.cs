using HotelManagement.Common;
using HotelManagement.Enums;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.CustomControls
{
    public class MenuButton : Button
    {
        public Display Display { get; set; }

        public MenuButton(Display display, string text, bool displayIcon = true)
        {
            this.Display = display;
            this.Enabled = false;
            this.Size = new Size(74, 63);
            this.Text = text;
            if (displayIcon)
            {
                this.Image = ResourceUtil.GetMenuIcon(display);
                this.TextAlign = ContentAlignment.BottomCenter;
                this.TextImageRelation = TextImageRelation.ImageAboveText;
            }
        }

    }
}
