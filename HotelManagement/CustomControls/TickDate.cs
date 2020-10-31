using HotelManagement.Const;
using System;
using System.Windows.Forms;

namespace HotelManagement.CustomControls
{
    public partial class TickDate : UserControl
    {
        public TickDate()
        {
            InitializeComponent();
            this.UpdateDateTime(DateTime.Now);
        }

        private void TickTimer_Tick(object sender, EventArgs e)
        {
            this.UpdateDateTime(DateTime.Now);
        }

        private void UpdateDateTime(DateTime nowDateTime)
        {
            this.DateLabel.Text = nowDateTime.ToString("yyyy年MM月dd日");
            this.DayOfWeekLabel.Text = $"({Constants.WeekNames[(int)nowDateTime.DayOfWeek]})";
            this.TimeLabel.Text = nowDateTime.ToString("HH時mm分");
        }
    }
}
