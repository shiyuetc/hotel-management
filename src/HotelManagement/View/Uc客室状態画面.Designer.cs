namespace HotelManagement.View
{
    partial class Uc客室状態画面
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
            this.roomGrid1 = new HotelManagement.Controls.UserControls.RoomGrid();
            this.colorBlockLabel7 = new HotelManagement.Controls.UserContols.ColorBlockLabel();
            this.colorBlockLabel1 = new HotelManagement.Controls.UserContols.ColorBlockLabel();
            this.colorBlockLabel5 = new HotelManagement.Controls.UserContols.ColorBlockLabel();
            this.colorBlockLabel2 = new HotelManagement.Controls.UserContols.ColorBlockLabel();
            this.colorBlockLabel3 = new HotelManagement.Controls.UserContols.ColorBlockLabel();
            this.SuspendLayout();
            // 
            // roomGrid1
            // 
            this.roomGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roomGrid1.Location = new System.Drawing.Point(3, 59);
            this.roomGrid1.Name = "roomGrid1";
            this.roomGrid1.Size = new System.Drawing.Size(923, 469);
            this.roomGrid1.TabIndex = 0;
            // 
            // colorBlockLabel7
            // 
            this.colorBlockLabel7.BlockColor = System.Drawing.Color.Yellow;
            this.colorBlockLabel7.LabelText = "ﾁｪｯｸｲﾝ待機中";
            this.colorBlockLabel7.Location = new System.Drawing.Point(15, 11);
            this.colorBlockLabel7.MinimumSize = new System.Drawing.Size(32, 16);
            this.colorBlockLabel7.Name = "colorBlockLabel7";
            this.colorBlockLabel7.Size = new System.Drawing.Size(120, 16);
            this.colorBlockLabel7.TabIndex = 13;
            // 
            // colorBlockLabel1
            // 
            this.colorBlockLabel1.BlockColor = System.Drawing.Color.Red;
            this.colorBlockLabel1.LabelText = "ﾁｪｯｸｱｳﾄ待機中";
            this.colorBlockLabel1.Location = new System.Drawing.Point(15, 33);
            this.colorBlockLabel1.MinimumSize = new System.Drawing.Size(32, 16);
            this.colorBlockLabel1.Name = "colorBlockLabel1";
            this.colorBlockLabel1.Size = new System.Drawing.Size(120, 16);
            this.colorBlockLabel1.TabIndex = 14;
            // 
            // colorBlockLabel5
            // 
            this.colorBlockLabel5.BlockColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorBlockLabel5.LabelText = "宿泊中";
            this.colorBlockLabel5.Location = new System.Drawing.Point(141, 11);
            this.colorBlockLabel5.MinimumSize = new System.Drawing.Size(32, 16);
            this.colorBlockLabel5.Name = "colorBlockLabel5";
            this.colorBlockLabel5.Size = new System.Drawing.Size(80, 16);
            this.colorBlockLabel5.TabIndex = 15;
            // 
            // colorBlockLabel2
            // 
            this.colorBlockLabel2.BlockColor = System.Drawing.Color.Aqua;
            this.colorBlockLabel2.LabelText = "清掃中";
            this.colorBlockLabel2.Location = new System.Drawing.Point(227, 33);
            this.colorBlockLabel2.MinimumSize = new System.Drawing.Size(32, 16);
            this.colorBlockLabel2.Name = "colorBlockLabel2";
            this.colorBlockLabel2.Size = new System.Drawing.Size(80, 16);
            this.colorBlockLabel2.TabIndex = 16;
            // 
            // colorBlockLabel3
            // 
            this.colorBlockLabel3.BlockColor = System.Drawing.Color.Fuchsia;
            this.colorBlockLabel3.LabelText = "工事中";
            this.colorBlockLabel3.Location = new System.Drawing.Point(227, 11);
            this.colorBlockLabel3.MinimumSize = new System.Drawing.Size(32, 16);
            this.colorBlockLabel3.Name = "colorBlockLabel3";
            this.colorBlockLabel3.Size = new System.Drawing.Size(80, 16);
            this.colorBlockLabel3.TabIndex = 17;
            // 
            // 客室状態画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorBlockLabel3);
            this.Controls.Add(this.colorBlockLabel2);
            this.Controls.Add(this.colorBlockLabel5);
            this.Controls.Add(this.colorBlockLabel1);
            this.Controls.Add(this.colorBlockLabel7);
            this.Controls.Add(this.roomGrid1);
            this.Name = "客室状態画面";
            this.Size = new System.Drawing.Size(929, 531);
            this.Load += new System.EventHandler(this.客室状態画面_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UserControls.RoomGrid roomGrid1;
        private Controls.UserContols.ColorBlockLabel colorBlockLabel7;
        private Controls.UserContols.ColorBlockLabel colorBlockLabel1;
        private Controls.UserContols.ColorBlockLabel colorBlockLabel5;
        private Controls.UserContols.ColorBlockLabel colorBlockLabel2;
        private Controls.UserContols.ColorBlockLabel colorBlockLabel3;
    }
}
