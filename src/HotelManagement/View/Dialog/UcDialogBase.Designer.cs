﻿namespace HotelManagement.View.Dialog
{
    partial class UcDialogBase
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
            this.SuspendLayout();
            // 
            // UcDialogBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UcDialogBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DialogBaseForm";
            this.Load += new System.EventHandler(this.DialogBaseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}