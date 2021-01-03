namespace HotelManagement.Controls.UserControls
{
    partial class TickDate
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
            this.components = new System.ComponentModel.Container();
            this.DayOfWeekLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TickTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DayOfWeekLabel
            // 
            this.DayOfWeekLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DayOfWeekLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayOfWeekLabel.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.DayOfWeekLabel.Location = new System.Drawing.Point(0, 43);
            this.DayOfWeekLabel.Name = "DayOfWeekLabel";
            this.DayOfWeekLabel.Size = new System.Drawing.Size(64, 27);
            this.DayOfWeekLabel.TabIndex = 9;
            this.DayOfWeekLabel.Text = "(木)";
            this.DayOfWeekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeLabel.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.TimeLabel.Location = new System.Drawing.Point(67, 43);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(113, 27);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "20時22分";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DateLabel
            // 
            this.DateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateLabel.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.DateLabel.Location = new System.Drawing.Point(0, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(180, 40);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "2020年10月29日";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TickTimer
            // 
            this.TickTimer.Enabled = true;
            this.TickTimer.Interval = 1000;
            this.TickTimer.Tick += new System.EventHandler(this.TickTimer_Tick);
            // 
            // TickDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DayOfWeekLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DateLabel);
            this.Name = "TickDate";
            this.Size = new System.Drawing.Size(180, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DayOfWeekLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Timer TickTimer;
    }
}
