namespace HotelManagement.View
{
    partial class FmMain
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LoginInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DisplayNameLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.UcPanel = new System.Windows.Forms.Panel();
            this.MenuBar = new HotelManagement.Controls.CustomControls.MenuBar();
            this.MenuTab = new HotelManagement.Controls.CustomControls.MenuTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tickDate1 = new HotelManagement.Controls.UserControls.TickDate();
            this.statusStrip1.SuspendLayout();
            this.MenuTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TitleLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.TitleLabel.Location = new System.Drawing.Point(6, 5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(198, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "ホテル宿泊管理";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginInfoLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(944, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LoginInfoLabel
            // 
            this.LoginInfoLabel.Name = "LoginInfoLabel";
            this.LoginInfoLabel.Size = new System.Drawing.Size(133, 17);
            this.LoginInfoLabel.Text = "ユーザー情報：ログインなし";
            // 
            // DisplayNameLabel
            // 
            this.DisplayNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.DisplayNameLabel.Location = new System.Drawing.Point(6, 54);
            this.DisplayNameLabel.Name = "DisplayNameLabel";
            this.DisplayNameLabel.Size = new System.Drawing.Size(198, 21);
            this.DisplayNameLabel.TabIndex = 1;
            this.DisplayNameLabel.Text = "表示画面名";
            this.DisplayNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.TabIndex = 0;
            // 
            // UcPanel
            // 
            this.UcPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UcPanel.Location = new System.Drawing.Point(6, 98);
            this.UcPanel.Name = "UcPanel";
            this.UcPanel.Size = new System.Drawing.Size(933, 534);
            this.UcPanel.TabIndex = 6;
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.Transparent;
            this.MenuBar.Location = new System.Drawing.Point(207, 5);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(549, 70);
            this.MenuBar.TabIndex = 7;
            // 
            // MenuTab
            // 
            this.MenuTab.Controls.Add(this.tabPage1);
            this.MenuTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MenuTab.ItemSize = new System.Drawing.Size(60, 18);
            this.MenuTab.Location = new System.Drawing.Point(6, 78);
            this.MenuTab.Name = "MenuTab";
            this.MenuTab.SelectedIndex = 0;
            this.MenuTab.Size = new System.Drawing.Size(933, 23);
            this.MenuTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(925, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tickDate1
            // 
            this.tickDate1.Location = new System.Drawing.Point(759, 5);
            this.tickDate1.Name = "tickDate1";
            this.tickDate1.Size = new System.Drawing.Size(180, 70);
            this.tickDate1.TabIndex = 4;
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 661);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.UcPanel);
            this.Controls.Add(this.MenuTab);
            this.Controls.Add(this.tickDate1);
            this.Controls.Add(this.DisplayNameLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 700);
            this.MinimumSize = new System.Drawing.Size(960, 680);
            this.Name = "FmMain";
            this.Text = "ホテル宿泊管理システム";
            this.Load += new System.EventHandler(this.FmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MenuTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LoginInfoLabel;
        private System.Windows.Forms.Label DisplayNameLabel;
        private Controls.UserControls.TickDate tickDate1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Controls.CustomControls.MenuTab MenuTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel UcPanel;
        private Controls.CustomControls.MenuBar MenuBar;
    }
}

