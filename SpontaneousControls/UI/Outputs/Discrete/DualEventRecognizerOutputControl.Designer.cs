namespace SpontaneousControls.UI.Outputs.Discrete
{
    partial class DualEventRecognizerOutputControl
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
            this.outputOneTypeCombo = new System.Windows.Forms.ComboBox();
            this.eventOneNameLabel = new System.Windows.Forms.Label();
            this.outputOneControlPanel = new System.Windows.Forms.Panel();
            this.outputTwoTypeCombo = new System.Windows.Forms.ComboBox();
            this.eventTwoNameLabel = new System.Windows.Forms.Label();
            this.outputTwoControlPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // outputOneTypeCombo
            // 
            this.outputOneTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputOneTypeCombo.FormattingEnabled = true;
            this.outputOneTypeCombo.Location = new System.Drawing.Point(3, 25);
            this.outputOneTypeCombo.Name = "outputOneTypeCombo";
            this.outputOneTypeCombo.Size = new System.Drawing.Size(166, 21);
            this.outputOneTypeCombo.TabIndex = 6;
            this.outputOneTypeCombo.SelectedIndexChanged += new System.EventHandler(this.outputTypeCombo_SelectedIndexChanged);
            // 
            // eventOneNameLabel
            // 
            this.eventOneNameLabel.AutoSize = true;
            this.eventOneNameLabel.Location = new System.Drawing.Point(0, 9);
            this.eventOneNameLabel.Name = "eventOneNameLabel";
            this.eventOneNameLabel.Size = new System.Drawing.Size(72, 13);
            this.eventOneNameLabel.TabIndex = 8;
            this.eventOneNameLabel.Text = "dummy_value";
            // 
            // outputOneControlPanel
            // 
            this.outputOneControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.outputOneControlPanel.Location = new System.Drawing.Point(3, 52);
            this.outputOneControlPanel.Name = "outputOneControlPanel";
            this.outputOneControlPanel.Size = new System.Drawing.Size(166, 95);
            this.outputOneControlPanel.TabIndex = 7;
            // 
            // outputTwoTypeCombo
            // 
            this.outputTwoTypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTwoTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputTwoTypeCombo.FormattingEnabled = true;
            this.outputTwoTypeCombo.Location = new System.Drawing.Point(183, 25);
            this.outputTwoTypeCombo.Name = "outputTwoTypeCombo";
            this.outputTwoTypeCombo.Size = new System.Drawing.Size(180, 21);
            this.outputTwoTypeCombo.TabIndex = 9;
            this.outputTwoTypeCombo.SelectedIndexChanged += new System.EventHandler(this.outputTypeCombo_SelectedIndexChanged);
            // 
            // eventTwoNameLabel
            // 
            this.eventTwoNameLabel.AutoSize = true;
            this.eventTwoNameLabel.Location = new System.Drawing.Point(183, 9);
            this.eventTwoNameLabel.Name = "eventTwoNameLabel";
            this.eventTwoNameLabel.Size = new System.Drawing.Size(72, 13);
            this.eventTwoNameLabel.TabIndex = 11;
            this.eventTwoNameLabel.Text = "dummy_value";
            // 
            // outputTwoControlPanel
            // 
            this.outputTwoControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTwoControlPanel.Location = new System.Drawing.Point(183, 52);
            this.outputTwoControlPanel.Name = "outputTwoControlPanel";
            this.outputTwoControlPanel.Size = new System.Drawing.Size(180, 95);
            this.outputTwoControlPanel.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(175, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2, 147);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // DualEventRecognizerOutputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outputTwoTypeCombo);
            this.Controls.Add(this.eventTwoNameLabel);
            this.Controls.Add(this.outputTwoControlPanel);
            this.Controls.Add(this.outputOneTypeCombo);
            this.Controls.Add(this.eventOneNameLabel);
            this.Controls.Add(this.outputOneControlPanel);
            this.Name = "DualEventRecognizerOutputControl";
            this.Size = new System.Drawing.Size(366, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox outputOneTypeCombo;
        private System.Windows.Forms.Label eventOneNameLabel;
        private System.Windows.Forms.Panel outputOneControlPanel;
        private System.Windows.Forms.ComboBox outputTwoTypeCombo;
        private System.Windows.Forms.Label eventTwoNameLabel;
        private System.Windows.Forms.Panel outputTwoControlPanel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
