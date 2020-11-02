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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MenuBarPanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.UcCustomerButton = new System.Windows.Forms.Button();
            this.UcEmployeeButton = new System.Windows.Forms.Button();
            this.UcSaleButton = new System.Windows.Forms.Button();
            this.UcHistoryButton = new System.Windows.Forms.Button();
            this.UcReserveButton = new System.Windows.Forms.Button();
            this.UcPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LoginInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DisplayNameLabel = new System.Windows.Forms.Label();
            this.tickDate1 = new HotelManagement.CustomControls.TickDate();
            this.MenuBarPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            // MenuBarPanel
            // 
            this.MenuBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MenuBarPanel.Controls.Add(this.LogoutButton);
            this.MenuBarPanel.Controls.Add(this.UcCustomerButton);
            this.MenuBarPanel.Controls.Add(this.UcEmployeeButton);
            this.MenuBarPanel.Controls.Add(this.UcSaleButton);
            this.MenuBarPanel.Controls.Add(this.UcHistoryButton);
            this.MenuBarPanel.Controls.Add(this.UcReserveButton);
            this.MenuBarPanel.Enabled = false;
            this.MenuBarPanel.Location = new System.Drawing.Point(207, 5);
            this.MenuBarPanel.Name = "MenuBarPanel";
            this.MenuBarPanel.Size = new System.Drawing.Size(549, 70);
            this.MenuBarPanel.TabIndex = 1;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutButton.Image")));
            this.LogoutButton.Location = new System.Drawing.Point(374, 5);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(74, 58);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "ログアウト\r\n";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // UcCustomerButton
            // 
            this.UcCustomerButton.Location = new System.Drawing.Point(300, 5);
            this.UcCustomerButton.Name = "UcCustomerButton";
            this.UcCustomerButton.Size = new System.Drawing.Size(74, 58);
            this.UcCustomerButton.TabIndex = 4;
            this.UcCustomerButton.Text = "顧客管理\r\n[開発中]";
            this.UcCustomerButton.UseVisualStyleBackColor = true;
            this.UcCustomerButton.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // UcEmployeeButton
            // 
            this.UcEmployeeButton.Location = new System.Drawing.Point(226, 5);
            this.UcEmployeeButton.Name = "UcEmployeeButton";
            this.UcEmployeeButton.Size = new System.Drawing.Size(74, 58);
            this.UcEmployeeButton.TabIndex = 3;
            this.UcEmployeeButton.Text = "従業員管理\r\n[開発中]";
            this.UcEmployeeButton.UseVisualStyleBackColor = true;
            this.UcEmployeeButton.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // UcSaleButton
            // 
            this.UcSaleButton.Location = new System.Drawing.Point(152, 5);
            this.UcSaleButton.Name = "UcSaleButton";
            this.UcSaleButton.Size = new System.Drawing.Size(74, 58);
            this.UcSaleButton.TabIndex = 2;
            this.UcSaleButton.Text = "売上確認\r\n[開発中]";
            this.UcSaleButton.UseVisualStyleBackColor = true;
            this.UcSaleButton.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // UcHistoryButton
            // 
            this.UcHistoryButton.Location = new System.Drawing.Point(78, 5);
            this.UcHistoryButton.Name = "UcHistoryButton";
            this.UcHistoryButton.Size = new System.Drawing.Size(74, 58);
            this.UcHistoryButton.TabIndex = 1;
            this.UcHistoryButton.Text = "宿泊履歴\r\n[開発中]";
            this.UcHistoryButton.UseVisualStyleBackColor = true;
            this.UcHistoryButton.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // UcReserveButton
            // 
            this.UcReserveButton.Location = new System.Drawing.Point(4, 5);
            this.UcReserveButton.Name = "UcReserveButton";
            this.UcReserveButton.Size = new System.Drawing.Size(74, 58);
            this.UcReserveButton.TabIndex = 0;
            this.UcReserveButton.Text = "予約管理\r\n[開発中]";
            this.UcReserveButton.UseVisualStyleBackColor = true;
            this.UcReserveButton.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // UcPanel
            // 
            this.UcPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UcPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UcPanel.Location = new System.Drawing.Point(6, 78);
            this.UcPanel.Name = "UcPanel";
            this.UcPanel.Size = new System.Drawing.Size(933, 538);
            this.UcPanel.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginInfoLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
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
            // tickDate1
            // 
            this.tickDate1.Location = new System.Drawing.Point(756, 2);
            this.tickDate1.Name = "tickDate1";
            this.tickDate1.Size = new System.Drawing.Size(185, 75);
            this.tickDate1.TabIndex = 4;
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 641);
            this.Controls.Add(this.tickDate1);
            this.Controls.Add(this.DisplayNameLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.UcPanel);
            this.Controls.Add(this.MenuBarPanel);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 680);
            this.MinimumSize = new System.Drawing.Size(960, 680);
            this.Name = "FmMain";
            this.Text = "ホテル宿泊管理システム";
            this.Load += new System.EventHandler(this.FmMain_Load);
            this.MenuBarPanel.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel MenuBarPanel;
        private System.Windows.Forms.Button UcHistoryButton;
        private System.Windows.Forms.Button UcReserveButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button UcCustomerButton;
        private System.Windows.Forms.Button UcEmployeeButton;
        private System.Windows.Forms.Button UcSaleButton;
        private System.Windows.Forms.Panel UcPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LoginInfoLabel;
        private System.Windows.Forms.Label DisplayNameLabel;
        private CustomControls.TickDate tickDate1;
    }
}

