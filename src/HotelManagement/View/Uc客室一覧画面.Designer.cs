namespace HotelManagement.View
{
    partial class Uc客室一覧画面
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.客室ListDataGridView = new System.Windows.Forms.DataGridView();
            this.客室番号Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客室タイプ名称Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.喫煙Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.客室ListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 客室ListDataGridView
            // 
            this.客室ListDataGridView.AllowUserToAddRows = false;
            this.客室ListDataGridView.AllowUserToDeleteRows = false;
            this.客室ListDataGridView.AllowUserToResizeColumns = false;
            this.客室ListDataGridView.AllowUserToResizeRows = false;
            this.客室ListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.客室ListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.客室ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.客室ListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.客室番号Column,
            this.客室タイプ名称Column,
            this.喫煙Column});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.客室ListDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.客室ListDataGridView.Location = new System.Drawing.Point(3, 3);
            this.客室ListDataGridView.MultiSelect = false;
            this.客室ListDataGridView.Name = "客室ListDataGridView";
            this.客室ListDataGridView.ReadOnly = true;
            this.客室ListDataGridView.RowHeadersVisible = false;
            this.客室ListDataGridView.RowTemplate.Height = 30;
            this.客室ListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.客室ListDataGridView.Size = new System.Drawing.Size(923, 525);
            this.客室ListDataGridView.TabIndex = 6;
            // 
            // 客室番号Column
            // 
            this.客室番号Column.HeaderText = "客室番号";
            this.客室番号Column.Name = "客室番号Column";
            this.客室番号Column.ReadOnly = true;
            // 
            // 客室タイプ名称Column
            // 
            this.客室タイプ名称Column.HeaderText = "客室タイプ名称";
            this.客室タイプ名称Column.Name = "客室タイプ名称Column";
            this.客室タイプ名称Column.ReadOnly = true;
            this.客室タイプ名称Column.Width = 140;
            // 
            // 喫煙Column
            // 
            this.喫煙Column.HeaderText = "喫煙";
            this.喫煙Column.Name = "喫煙Column";
            this.喫煙Column.ReadOnly = true;
            this.喫煙Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.喫煙Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.喫煙Column.Width = 65;
            // 
            // Uc客室一覧画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.客室ListDataGridView);
            this.Name = "Uc客室一覧画面";
            this.Size = new System.Drawing.Size(929, 531);
            this.Load += new System.EventHandler(this.Uc客室一覧画面_Load);
            ((System.ComponentModel.ISupportInitialize)(this.客室ListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView 客室ListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客室番号Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客室タイプ名称Column;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 喫煙Column;
    }
}
