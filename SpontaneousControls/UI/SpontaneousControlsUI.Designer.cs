﻿namespace SpontaneousControls.UI
{
    partial class SpontaneousControlsUI
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
            this.mappingControl1 = new SpontaneousControls.UI.Controls.MappingControl();
            this.SuspendLayout();
            // 
            // mappingControl1
            // 
            this.mappingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mappingControl1.Location = new System.Drawing.Point(12, 12);
            this.mappingControl1.Name = "mappingControl1";
            this.mappingControl1.Size = new System.Drawing.Size(360, 388);
            this.mappingControl1.TabIndex = 0;
            // 
            // SpontaneousControlsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 412);
            this.Controls.Add(this.mappingControl1);
            this.Name = "SpontaneousControlsUI";
            this.Text = "Spontaneous Controls";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MappingControl mappingControl1;






    }
}