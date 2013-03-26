namespace SpontaneousControls.UI.Outputs.Discrete
{
    partial class MouseScrollOutputControl
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
            this.directionCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direction";
            // 
            // directionCombo
            // 
            this.directionCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.directionCombo.FormattingEnabled = true;
            this.directionCombo.Location = new System.Drawing.Point(0, 21);
            this.directionCombo.Name = "directionCombo";
            this.directionCombo.Size = new System.Drawing.Size(150, 21);
            this.directionCombo.TabIndex = 1;
            this.directionCombo.SelectedIndexChanged += new System.EventHandler(this.directionCombo_SelectedIndexChanged);
            // 
            // MouseScrollOutputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.directionCombo);
            this.Controls.Add(this.label1);
            this.Name = "MouseScrollOutputControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox directionCombo;
    }
}
