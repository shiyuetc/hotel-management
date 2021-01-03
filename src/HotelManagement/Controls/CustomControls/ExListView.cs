using System.Windows.Forms;

namespace HotelManagement.Controls.CustomControls
{
    public class ExListView : ListView
    {
        public void Init(ListViewItem[] listViewItems)
        {
            this.Visible = false;
            this.Items.Clear();
            this.Items.AddRange(listViewItems);
            this.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.Visible = true;
        }

        public void UpdateItem(int rowIndex, ListViewItem listViewItem)
        {
            this.Items[rowIndex] = listViewItem;
            this.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
