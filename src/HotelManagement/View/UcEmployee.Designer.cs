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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // EmployeeListView
            // 
            this.EmployeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
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
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "従業員番号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "名前";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "職位";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "入社年月日";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "退社年月日";
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
