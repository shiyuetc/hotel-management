using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.Controls.CustomControls
{
    public class ExLabel : Label
    {
        private readonly Color EnableForeColor = Color.FromArgb(255, 255, 255);

        private readonly Color EnableBackColor = Color.FromArgb(73, 111, 225);

        private readonly Color DisableForeColor = Color.FromArgb(255, 255, 255);

        private readonly Color DisableBackColor = Color.FromArgb(120, 120, 120);

        public ExLabel()
        {
            this.Size = new Size(100, 19);
            this.BorderStyle = BorderStyle.Fixed3D;
            this.TextAlign = ContentAlignment.MiddleRight;
            this.SetEnable(true);
        }

        public void SetEnable(bool value)
        {
            if(value)
            {
                this.ForeColor = this.EnableForeColor;
                this.BackColor = this.EnableBackColor;
            }
            else
            {
                this.ForeColor = this.DisableForeColor;
                this.BackColor = this.DisableBackColor;
            }
        }
    }
}
