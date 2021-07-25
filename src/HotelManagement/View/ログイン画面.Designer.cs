namespace HotelManagement.View
{
    partial class ログイン画面
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
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ログインButton = new System.Windows.Forms.Button();
            this.タイトルLabel = new System.Windows.Forms.Label();
            this.終了Button = new System.Windows.Forms.Button();
            this.バージョンLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(310, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "従業員ID：";
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(314, 232);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(300, 31);
            this.EmployeeIDTextBox.TabIndex = 1;
            this.EmployeeIDTextBox.Text = "system";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PasswordTextBox.Location = new System.Drawing.Point(314, 303);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(300, 31);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(310, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "パスワード：";
            // 
            // ログインButton
            // 
            this.ログインButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ログインButton.Location = new System.Drawing.Point(428, 340);
            this.ログインButton.Name = "ログインButton";
            this.ログインButton.Size = new System.Drawing.Size(90, 31);
            this.ログインButton.TabIndex = 4;
            this.ログインButton.Text = "ログイン";
            this.ログインButton.UseVisualStyleBackColor = true;
            this.ログインButton.Click += new System.EventHandler(this.ログインButton_Click);
            // 
            // タイトルLabel
            // 
            this.タイトルLabel.Font = new System.Drawing.Font("ＭＳ 明朝", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.タイトルLabel.Location = new System.Drawing.Point(3, 71);
            this.タイトルLabel.Name = "タイトルLabel";
            this.タイトルLabel.Size = new System.Drawing.Size(923, 46);
            this.タイトルLabel.TabIndex = 5;
            this.タイトルLabel.Text = "ホテル宿泊管理システム";
            this.タイトルLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 終了Button
            // 
            this.終了Button.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.終了Button.Location = new System.Drawing.Point(524, 340);
            this.終了Button.Name = "終了Button";
            this.終了Button.Size = new System.Drawing.Size(90, 31);
            this.終了Button.TabIndex = 6;
            this.終了Button.Text = "終了";
            this.終了Button.UseVisualStyleBackColor = true;
            this.終了Button.Click += new System.EventHandler(this.終了Button_Click);
            // 
            // バージョンLabel
            // 
            this.バージョンLabel.Font = new System.Drawing.Font("ＭＳ 明朝", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.バージョンLabel.Location = new System.Drawing.Point(3, 120);
            this.バージョンLabel.Name = "バージョンLabel";
            this.バージョンLabel.Size = new System.Drawing.Size(923, 20);
            this.バージョンLabel.TabIndex = 7;
            this.バージョンLabel.Text = "VER 1.0.0";
            this.バージョンLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ログイン画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.バージョンLabel);
            this.Controls.Add(this.終了Button);
            this.Controls.Add(this.タイトルLabel);
            this.Controls.Add(this.ログインButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("ＭＳ 明朝", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "ログイン画面";
            this.Size = new System.Drawing.Size(929, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ログインButton;
        private System.Windows.Forms.Label タイトルLabel;
        private System.Windows.Forms.Button 終了Button;
        private System.Windows.Forms.Label バージョンLabel;
    }
}
