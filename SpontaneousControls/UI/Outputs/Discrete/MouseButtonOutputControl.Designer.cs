namespace SpontaneousControls.UI.Outputs.Discrete
{
    partial class MouseButtonOutputControl
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
            this.buttonCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eventTypeCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Button";
            // 
            // buttonCombo
            // 
            this.buttonCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buttonCombo.FormattingEnabled = true;
            this.buttonCombo.Location = new System.Drawing.Point(0, 22);
            this.buttonCombo.Name = "buttonCombo";
            this.buttonCombo.Size = new System.Drawing.Size(150, 21);
            this.buttonCombo.TabIndex = 1;
            this.buttonCombo.SelectedIndexChanged += new System.EventHandler(this.buttonCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Action";
            // 
            // eventTypeCombo
            // 
            this.eventTypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventTypeCombo.FormattingEnabled = true;
            this.eventTypeCombo.Location = new System.Drawing.Point(0, 63);
            this.eventTypeCombo.Name = "eventTypeCombo";
            this.eventTypeCombo.Size = new System.Drawing.Size(150, 21);
            this.eventTypeCombo.TabIndex = 3;
            this.eventTypeCombo.SelectedIndexChanged += new System.EventHandler(this.eventTypeCombo_SelectedIndexChanged);
            // 
            // MouseButtonOutputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eventTypeCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCombo);
            this.Controls.Add(this.label1);
            this.Name = "MouseButtonOutputControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox buttonCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox eventTypeCombo;
    }
}
