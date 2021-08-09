namespace HotelManagement.View
{
    partial class Uc会員一覧画面
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
            this.会員ListDataGridView = new System.Windows.Forms.DataGridView();
            this.会員番号Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.氏名Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.メールアドレスColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電話番号Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入会年月日Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.会員ListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 会員ListDataGridView
            // 
            this.会員ListDataGridView.AllowUserToAddRows = false;
            this.会員ListDataGridView.AllowUserToDeleteRows = false;
            this.会員ListDataGridView.AllowUserToResizeColumns = false;
            this.会員ListDataGridView.AllowUserToResizeRows = false;
            this.会員ListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.会員ListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.会員ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.会員ListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.会員番号Column,
            this.氏名Column,
            this.メールアドレスColumn,
            this.電話番号Column,
            this.入会年月日Column});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.会員ListDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.会員ListDataGridView.Location = new System.Drawing.Point(3, 3);
            this.会員ListDataGridView.MultiSelect = false;
            this.会員ListDataGridView.Name = "会員ListDataGridView";
            this.会員ListDataGridView.ReadOnly = true;
            this.会員ListDataGridView.RowHeadersVisible = false;
            this.会員ListDataGridView.RowTemplate.Height = 30;
            this.会員ListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.会員ListDataGridView.Size = new System.Drawing.Size(923, 525);
            this.会員ListDataGridView.TabIndex = 5;
            // 
            // 会員番号Column
            // 
            this.会員番号Column.HeaderText = "会員番号";
            this.会員番号Column.Name = "会員番号Column";
            this.会員番号Column.ReadOnly = true;
            this.会員番号Column.Width = 120;
            // 
            // 氏名Column
            // 
            this.氏名Column.HeaderText = "氏名";
            this.氏名Column.Name = "氏名Column";
            this.氏名Column.ReadOnly = true;
            this.氏名Column.Width = 140;
            // 
            // メールアドレスColumn
            // 
            this.メールアドレスColumn.HeaderText = "Eメール";
            this.メールアドレスColumn.Name = "メールアドレスColumn";
            this.メールアドレスColumn.ReadOnly = true;
            this.メールアドレスColumn.Width = 200;
            // 
            // 電話番号Column
            // 
            this.電話番号Column.HeaderText = "電話番号";
            this.電話番号Column.Name = "電話番号Column";
            this.電話番号Column.ReadOnly = true;
            this.電話番号Column.Width = 120;
            // 
            // 入会年月日Column
            // 
            this.入会年月日Column.HeaderText = "入会年月日";
            this.入会年月日Column.Name = "入会年月日Column";
            this.入会年月日Column.ReadOnly = true;
            this.入会年月日Column.Width = 125;
            // 
            // Uc会員一覧画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.会員ListDataGridView);
            this.Name = "Uc会員一覧画面";
            this.Size = new System.Drawing.Size(929, 531);
            this.Load += new System.EventHandler(this.Uc会員一覧画面_Load);
            ((System.ComponentModel.ISupportInitialize)(this.会員ListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView 会員ListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 会員番号Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn 氏名Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn メールアドレスColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話番号Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入会年月日Column;
    }
}
