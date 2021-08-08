namespace HotelManagement.View
{
    partial class 従業員一覧画面
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
            this.従業員ListDataGridView = new System.Windows.Forms.DataGridView();
            this.従業員番号Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.氏名Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.職位名称Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.メールアドレスColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入社年月日Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.従業員ListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 従業員ListDataGridView
            // 
            this.従業員ListDataGridView.AllowUserToAddRows = false;
            this.従業員ListDataGridView.AllowUserToDeleteRows = false;
            this.従業員ListDataGridView.AllowUserToResizeColumns = false;
            this.従業員ListDataGridView.AllowUserToResizeRows = false;
            this.従業員ListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.従業員ListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.従業員ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.従業員ListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.従業員番号Column,
            this.氏名Column,
            this.職位名称Column,
            this.メールアドレスColumn,
            this.入社年月日Column});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.従業員ListDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.従業員ListDataGridView.Location = new System.Drawing.Point(3, 3);
            this.従業員ListDataGridView.MultiSelect = false;
            this.従業員ListDataGridView.Name = "従業員ListDataGridView";
            this.従業員ListDataGridView.ReadOnly = true;
            this.従業員ListDataGridView.RowHeadersVisible = false;
            this.従業員ListDataGridView.RowTemplate.Height = 30;
            this.従業員ListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.従業員ListDataGridView.Size = new System.Drawing.Size(923, 525);
            this.従業員ListDataGridView.TabIndex = 5;
            // 
            // 従業員番号Column
            // 
            this.従業員番号Column.HeaderText = "従業員番号";
            this.従業員番号Column.Name = "従業員番号Column";
            this.従業員番号Column.ReadOnly = true;
            this.従業員番号Column.Width = 120;
            // 
            // 氏名Column
            // 
            this.氏名Column.HeaderText = "氏名";
            this.氏名Column.Name = "氏名Column";
            this.氏名Column.ReadOnly = true;
            this.氏名Column.Width = 140;
            // 
            // 職位名称Column
            // 
            this.職位名称Column.HeaderText = "職位";
            this.職位名称Column.Name = "職位名称Column";
            this.職位名称Column.ReadOnly = true;
            this.職位名称Column.Width = 180;
            // 
            // メールアドレスColumn
            // 
            this.メールアドレスColumn.HeaderText = "Eメール";
            this.メールアドレスColumn.Name = "メールアドレスColumn";
            this.メールアドレスColumn.ReadOnly = true;
            this.メールアドレスColumn.Width = 200;
            // 
            // 入社年月日Column
            // 
            this.入社年月日Column.HeaderText = "入社年月日";
            this.入社年月日Column.Name = "入社年月日Column";
            this.入社年月日Column.ReadOnly = true;
            this.入社年月日Column.Width = 125;
            // 
            // 従業員一覧画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.従業員ListDataGridView);
            this.Name = "従業員一覧画面";
            this.Size = new System.Drawing.Size(929, 531);
            this.Load += new System.EventHandler(this.UcEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.従業員ListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView 従業員ListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 従業員番号Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn 氏名Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn 職位名称Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn メールアドレスColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入社年月日Column;
    }
}
