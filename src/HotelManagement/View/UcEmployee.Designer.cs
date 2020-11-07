namespace HotelManagement.View
{
    partial class UcEmployee
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeeListView = new System.Windows.Forms.ListView();
            this.EmployeeNoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RankColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EntryDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LeaveDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // EmployeeListView
            // 
            this.EmployeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeId,
            this.EmployeeNoColumnHeader,
            this.NameColumnHeader,
            this.RankColumnHeader,
            this.EmailColumnHeader,
            this.EntryDateColumnHeader,
            this.LeaveDateColumnHeader});
            this.EmployeeListView.FullRowSelect = true;
            this.EmployeeListView.GridLines = true;
            this.EmployeeListView.HideSelection = false;
            this.EmployeeListView.Location = new System.Drawing.Point(3, 3);
            this.EmployeeListView.MultiSelect = false;
            this.EmployeeListView.Name = "EmployeeListView";
            this.EmployeeListView.Size = new System.Drawing.Size(923, 528);
            this.EmployeeListView.TabIndex = 2;
            this.EmployeeListView.UseCompatibleStateImageBehavior = false;
            this.EmployeeListView.View = System.Windows.Forms.View.Details;
            this.EmployeeListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EmployeeListView_MouseDoubleClick);
            // 
            // EmployeeNoColumnHeader
            // 
            this.EmployeeNoColumnHeader.Text = "従業員番号";
            // 
            // NameColumnHeader
            // 
            this.NameColumnHeader.Text = "名前";
            // 
            // RankColumnHeader
            // 
            this.RankColumnHeader.Text = "職位";
            // 
            // EmailColumnHeader
            // 
            this.EmailColumnHeader.Text = "Eメール";
            // 
            // EntryDateColumnHeader
            // 
            this.EntryDateColumnHeader.Text = "入社年月日";
            // 
            // LeaveDateColumnHeader
            // 
            this.LeaveDateColumnHeader.Text = "退社年月日";
            this.LeaveDateColumnHeader.Width = 78;
            // 
            // EmployeeId
            // 
            this.EmployeeId.Text = "ID";
            // 
            // UcEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmployeeListView);
            this.Name = "UcEmployee";
            this.Size = new System.Drawing.Size(929, 534);
            this.Load += new System.EventHandler(this.UcEmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView EmployeeListView;
        private System.Windows.Forms.ColumnHeader EmployeeNoColumnHeader;
        private System.Windows.Forms.ColumnHeader NameColumnHeader;
        private System.Windows.Forms.ColumnHeader RankColumnHeader;
        private System.Windows.Forms.ColumnHeader EntryDateColumnHeader;
        private System.Windows.Forms.ColumnHeader LeaveDateColumnHeader;
        private System.Windows.Forms.ColumnHeader EmailColumnHeader;
        private System.Windows.Forms.ColumnHeader EmployeeId;
    }
}
