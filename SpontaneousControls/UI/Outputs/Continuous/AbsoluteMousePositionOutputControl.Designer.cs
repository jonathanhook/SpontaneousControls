﻿namespace SpontaneousControls.UI.Outputs.Continuous
{
    partial class AbsoluteMousePositionOutputControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.axisCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Axis";
            // 
            // axisCombo
            // 
            this.axisCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axisCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.axisCombo.FormattingEnabled = true;
            this.axisCombo.Location = new System.Drawing.Point(0, 17);
            this.axisCombo.Name = "axisCombo";
            this.axisCombo.Size = new System.Drawing.Size(150, 21);
            this.axisCombo.TabIndex = 1;
            this.axisCombo.SelectedIndexChanged += new System.EventHandler(this.axisCombo_SelectedIndexChanged);
            // 
            // AbsoluteMousePositionOutputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axisCombo);
            this.Controls.Add(this.label1);
            this.Name = "AbsoluteMousePositionOutputControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox axisCombo;
    }
}
