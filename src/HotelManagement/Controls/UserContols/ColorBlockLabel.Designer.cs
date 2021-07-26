
namespace HotelManagement.Controls.UserContols
{
    partial class ColorBlockLabel
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
            this.ColorBlockPictureBox = new System.Windows.Forms.PictureBox();
            this.TextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBlockPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorBlockPictureBox
            // 
            this.ColorBlockPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ColorBlockPictureBox.Location = new System.Drawing.Point(0, 2);
            this.ColorBlockPictureBox.Name = "ColorBlockPictureBox";
            this.ColorBlockPictureBox.Size = new System.Drawing.Size(12, 12);
            this.ColorBlockPictureBox.TabIndex = 0;
            this.ColorBlockPictureBox.TabStop = false;
            // 
            // TextLabel
            // 
            this.TextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextLabel.BackColor = System.Drawing.Color.Transparent;
            this.TextLabel.Location = new System.Drawing.Point(14, 0);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(106, 16);
            this.TextLabel.TabIndex = 1;
            this.TextLabel.Text = "label1";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ColorBlockLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.ColorBlockPictureBox);
            this.MinimumSize = new System.Drawing.Size(32, 16);
            this.Name = "ColorBlockLabel";
            this.Size = new System.Drawing.Size(120, 16);
            ((System.ComponentModel.ISupportInitialize)(this.ColorBlockPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ColorBlockPictureBox;
        private System.Windows.Forms.Label TextLabel;
    }
}
