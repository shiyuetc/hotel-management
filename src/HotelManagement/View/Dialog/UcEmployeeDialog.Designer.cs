namespace HotelManagement.View.Dialog
{
    partial class UcEmployeeDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.EntryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RankComboBox = new System.Windows.Forms.ComboBox();
            this.EmployeeNoTextBox = new System.Windows.Forms.TextBox();
            this.RubyNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.LeaveDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IsLeaveCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LeaveDateLabel = new HotelManagement.CustomControls.ExLabel();
            this.exLabel6 = new HotelManagement.CustomControls.ExLabel();
            this.exLabel5 = new HotelManagement.CustomControls.ExLabel();
            this.exLabel4 = new HotelManagement.CustomControls.ExLabel();
            this.exLabel3 = new HotelManagement.CustomControls.ExLabel();
            this.exLabel2 = new HotelManagement.CustomControls.ExLabel();
            this.exLabel1 = new HotelManagement.CustomControls.ExLabel();
            this.RePasswordTextBox = new System.Windows.Forms.TextBox();
            this.UpdatePasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new HotelManagement.CustomControls.ExLabel();
            this.RePasswordLabel = new HotelManagement.CustomControls.ExLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(132, 55);
            this.LastNameTextBox.MaxLength = 20;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(97, 19);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(235, 55);
            this.FirstNameTextBox.MaxLength = 20;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(97, 19);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // EntryDateTimePicker
            // 
            this.EntryDateTimePicker.Location = new System.Drawing.Point(132, 156);
            this.EntryDateTimePicker.Name = "EntryDateTimePicker";
            this.EntryDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.EntryDateTimePicker.TabIndex = 6;
            // 
            // RankComboBox
            // 
            this.RankComboBox.Enabled = false;
            this.RankComboBox.FormattingEnabled = true;
            this.RankComboBox.Location = new System.Drawing.Point(132, 105);
            this.RankComboBox.Name = "RankComboBox";
            this.RankComboBox.Size = new System.Drawing.Size(200, 20);
            this.RankComboBox.TabIndex = 4;
            this.RankComboBox.TabStop = false;
            // 
            // EmployeeNoTextBox
            // 
            this.EmployeeNoTextBox.Location = new System.Drawing.Point(132, 30);
            this.EmployeeNoTextBox.MaxLength = 10;
            this.EmployeeNoTextBox.Name = "EmployeeNoTextBox";
            this.EmployeeNoTextBox.Size = new System.Drawing.Size(200, 19);
            this.EmployeeNoTextBox.TabIndex = 0;
            this.EmployeeNoTextBox.TabStop = false;
            // 
            // RubyNameTextBox
            // 
            this.RubyNameTextBox.Location = new System.Drawing.Point(132, 80);
            this.RubyNameTextBox.MaxLength = 50;
            this.RubyNameTextBox.Name = "RubyNameTextBox";
            this.RubyNameTextBox.Size = new System.Drawing.Size(200, 19);
            this.RubyNameTextBox.TabIndex = 3;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(132, 131);
            this.EmailTextBox.MaxLength = 255;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(200, 19);
            this.EmailTextBox.TabIndex = 5;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Location = new System.Drawing.Point(216, 336);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "登録";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // LeaveDateTimePicker
            // 
            this.LeaveDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.LeaveDateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLight;
            this.LeaveDateTimePicker.CustomFormat = "";
            this.LeaveDateTimePicker.Location = new System.Drawing.Point(132, 203);
            this.LeaveDateTimePicker.Name = "LeaveDateTimePicker";
            this.LeaveDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.LeaveDateTimePicker.TabIndex = 11;
            // 
            // IsLeaveCheckBox
            // 
            this.IsLeaveCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.IsLeaveCheckBox.ForeColor = System.Drawing.Color.Black;
            this.IsLeaveCheckBox.Location = new System.Drawing.Point(132, 182);
            this.IsLeaveCheckBox.Name = "IsLeaveCheckBox";
            this.IsLeaveCheckBox.Size = new System.Drawing.Size(200, 16);
            this.IsLeaveCheckBox.TabIndex = 15;
            this.IsLeaveCheckBox.Text = "退職";
            this.IsLeaveCheckBox.UseVisualStyleBackColor = false;
            this.IsLeaveCheckBox.CheckedChanged += new System.EventHandler(this.IsLeaveCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RePasswordLabel);
            this.groupBox1.Controls.Add(this.PasswordLabel);
            this.groupBox1.Controls.Add(this.LeaveDateLabel);
            this.groupBox1.Controls.Add(this.exLabel6);
            this.groupBox1.Controls.Add(this.exLabel5);
            this.groupBox1.Controls.Add(this.exLabel4);
            this.groupBox1.Controls.Add(this.exLabel3);
            this.groupBox1.Controls.Add(this.exLabel2);
            this.groupBox1.Controls.Add(this.exLabel1);
            this.groupBox1.Controls.Add(this.RePasswordTextBox);
            this.groupBox1.Controls.Add(this.UpdatePasswordCheckBox);
            this.groupBox1.Controls.Add(this.PasswordTextBox);
            this.groupBox1.Controls.Add(this.EmployeeNoTextBox);
            this.groupBox1.Controls.Add(this.IsLeaveCheckBox);
            this.groupBox1.Controls.Add(this.FirstNameTextBox);
            this.groupBox1.Controls.Add(this.RankComboBox);
            this.groupBox1.Controls.Add(this.EntryDateTimePicker);
            this.groupBox1.Controls.Add(this.LeaveDateTimePicker);
            this.groupBox1.Controls.Add(this.RubyNameTextBox);
            this.groupBox1.Controls.Add(this.EmailTextBox);
            this.groupBox1.Controls.Add(this.LastNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 318);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本情報";
            // 
            // LeaveDateLabel
            // 
            this.LeaveDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(111)))), ((int)(((byte)(225)))));
            this.LeaveDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LeaveDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeaveDateLabel.Location = new System.Drawing.Point(26, 203);
            this.LeaveDateLabel.Name = "LeaveDateLabel";
            this.LeaveDateLabel.Size = new System.Drawing.Size(100, 19);
            this.LeaveDateLabel.TabIndex = 25;
            this.LeaveDateLabel.Text = "退社年月日";
            this.LeaveDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exLabel6
            // 
            this.exLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(111)))), ((int)(((byte)(225)))));
            this.exLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exLabel6.Location = new System.Drawing.Point(26, 156);
            this.exLabel6.Name = "exLabel6";
            this.exLabel6.Size = new System.Drawing.Size(100, 19);
            this.exLabel6.TabIndex = 24;
            this.exLabel6.Text = "入社年月日";
            this.exLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exLabel5
            // 
            this.exLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(111)))), ((int)(((byte)(225)))));
            this.exLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exLabel5.Location = new System.Drawing.Point(26, 131);
            this.exLabel5.Name = "exLabel5";
            this.exLabel5.Size = new System.Drawing.Size(100, 19);
            this.exLabel5.TabIndex = 23;
            this.exLabel5.Text = "Eメール";
            this.exLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exLabel4
            // 
            this.exLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(111)))), ((int)(((byte)(225)))));
            this.exLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exLabel4.Location = new System.Drawing.Point(26, 106);
            this.exLabel4.Name = "exLabel4";
            this.exLabel4.Size = new System.Drawing.Size(100, 19);
            this.exLabel4.TabIndex = 22;
            this.exLabel4.Text = "職位";
            this.exLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exLabel3
            // 
            this.exLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(111)))), ((int)(((byte)(225)))));
            this.exLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exLabel3.Location = new System.Drawing.Point(26, 80);
            this.exLabel3.Name = "exLabel3";
            this.exLabel3.Size = new System.Drawing.Size(100, 19);
            this.exLabel3.TabIndex = 21;
            this.exLabel3.Text = "氏名（ｶﾅ）";
            this.exLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exLabel2
            // 
            this.exLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(111)))), ((int)(((byte)(225)))));
            this.exLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exLabel2.Location = new System.Drawing.Point(26, 55);
            this.exLabel2.Name = "exLabel2";
            this.exLabel2.Size = new System.Drawing.Size(100, 19);
            this.exLabel2.TabIndex = 20;
            this.exLabel2.Text = "氏名";
            this.exLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exLabel1
            // 
            this.exLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(111)))), ((int)(((byte)(225)))));
            this.exLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exLabel1.Location = new System.Drawing.Point(26, 30);
            this.exLabel1.Name = "exLabel1";
            this.exLabel1.Size = new System.Drawing.Size(100, 19);
            this.exLabel1.TabIndex = 19;
            this.exLabel1.Text = "従業員番号";
            this.exLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RePasswordTextBox
            // 
            this.RePasswordTextBox.Location = new System.Drawing.Point(132, 275);
            this.RePasswordTextBox.MaxLength = 50;
            this.RePasswordTextBox.Name = "RePasswordTextBox";
            this.RePasswordTextBox.PasswordChar = '●';
            this.RePasswordTextBox.Size = new System.Drawing.Size(200, 19);
            this.RePasswordTextBox.TabIndex = 17;
            // 
            // UpdatePasswordCheckBox
            // 
            this.UpdatePasswordCheckBox.Location = new System.Drawing.Point(132, 228);
            this.UpdatePasswordCheckBox.Name = "UpdatePasswordCheckBox";
            this.UpdatePasswordCheckBox.Size = new System.Drawing.Size(200, 16);
            this.UpdatePasswordCheckBox.TabIndex = 16;
            this.UpdatePasswordCheckBox.Text = "パスワード変更";
            this.UpdatePasswordCheckBox.UseVisualStyleBackColor = true;
            this.UpdatePasswordCheckBox.CheckedChanged += new System.EventHandler(this.UpdatePasswordCheckBox_CheckedChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(132, 250);
            this.PasswordTextBox.MaxLength = 50;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.Size = new System.Drawing.Size(200, 19);
            this.PasswordTextBox.TabIndex = 9;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(297, 336);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 17;
            this.CloseButton.Text = "キャンセル";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(111)))), ((int)(((byte)(225)))));
            this.PasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PasswordLabel.Location = new System.Drawing.Point(26, 250);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(100, 19);
            this.PasswordLabel.TabIndex = 26;
            this.PasswordLabel.Text = "新しいパスワード";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RePasswordLabel
            // 
            this.RePasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(111)))), ((int)(((byte)(225)))));
            this.RePasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RePasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RePasswordLabel.Location = new System.Drawing.Point(26, 275);
            this.RePasswordLabel.Name = "RePasswordLabel";
            this.RePasswordLabel.Size = new System.Drawing.Size(100, 19);
            this.RePasswordLabel.TabIndex = 27;
            this.RePasswordLabel.Text = "パスワード再入力";
            this.RePasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UcEmployeeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 371);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpdateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UcEmployeeDialog";
            this.Text = "EmployeeDialogForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UcEmployeeDialog_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.DateTimePicker EntryDateTimePicker;
        private System.Windows.Forms.ComboBox RankComboBox;
        private System.Windows.Forms.TextBox EmployeeNoTextBox;
        private System.Windows.Forms.TextBox RubyNameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DateTimePicker LeaveDateTimePicker;
        private System.Windows.Forms.CheckBox IsLeaveCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RePasswordTextBox;
        private System.Windows.Forms.CheckBox UpdatePasswordCheckBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button CloseButton;
        private CustomControls.ExLabel exLabel1;
        private CustomControls.ExLabel exLabel6;
        private CustomControls.ExLabel exLabel5;
        private CustomControls.ExLabel exLabel4;
        private CustomControls.ExLabel exLabel3;
        private CustomControls.ExLabel exLabel2;
        private CustomControls.ExLabel LeaveDateLabel;
        private CustomControls.ExLabel RePasswordLabel;
        private CustomControls.ExLabel PasswordLabel;
    }
}