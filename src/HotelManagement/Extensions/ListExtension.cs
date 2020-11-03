using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagement.Extensions
{
    public static class ListExtension
    {
        public static void SetEnabled<T>(this List<T> list, bool value) where T : Control
        {
            foreach(Control control in list)
            {
                control.Enabled = value;
            }
        }
    }
}
