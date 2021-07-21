namespace HotelManagement.View
{
    partial class 従業員管理画面
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
            this.EmployeeListView = new HotelManagement.Controls.CustomControls.ExListView();
            this.IdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeNoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RankColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EntryDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LeaveColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeListView
            // 
            this.EmployeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumnHeader,
            this.EmployeeNoColumnHeader,
            this.NameColumnHeader,
            this.RankColumnHeader,
            this.EmailColumnHeader,
            this.EntryDateColumnHeader,
            this.LeaveColumnHeader});
            this.EmployeeListView.FullRowSelect = true;
            this.EmployeeListView.GridLines = true;
            this.EmployeeListView.HideSelection = false;
            this.EmployeeListView.Location = new System.Drawing.Point(3, 32);
            this.EmployeeListView.MultiSelect = false;
            this.EmployeeListView.Name = "EmployeeListView";
            this.EmployeeListView.Size = new System.Drawing.Size(923, 499);
            this.EmployeeListView.TabIndex = 3;
            this.EmployeeListView.UseCompatibleStateImageBehavior = false;
            this.EmployeeListView.View = System.Windows.Forms.View.Details;
            this.EmployeeListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EmployeeListView_MouseDoubleClick);
            // 
            // IdColumnHeader
            // 
            this.IdColumnHeader.Text = "ID";
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
            // LeaveColumnHeader
            // 
            this.LeaveColumnHeader.Text = "退社年月日";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(851, 3);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "新規登録";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // UcEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.EmployeeListView);
            this.Name = "UcEmployee";
            this.Size = new System.Drawing.Size(929, 534);
            this.Load += new System.EventHandler(this.UcEmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CustomControls.ExListView EmployeeListView;
        private System.Windows.Forms.ColumnHeader IdColumnHeader;
        private System.Windows.Forms.ColumnHeader EmployeeNoColumnHeader;
        private System.Windows.Forms.ColumnHeader NameColumnHeader;
        private System.Windows.Forms.ColumnHeader RankColumnHeader;
        private System.Windows.Forms.ColumnHeader EmailColumnHeader;
        private System.Windows.Forms.ColumnHeader EntryDateColumnHeader;
        private System.Windows.Forms.ColumnHeader LeaveColumnHeader;
        private System.Windows.Forms.Button RegisterButton;
    }
}
