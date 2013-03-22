namespace SpontaneousControls.UI.Outputs.Discrete
{
    partial class EventRecognizerOutputControl
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
            this.outputTypeCombo = new System.Windows.Forms.ComboBox();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.outputControlPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // outputTypeCombo
            // 
            this.outputTypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputTypeCombo.FormattingEnabled = true;
            this.outputTypeCombo.Location = new System.Drawing.Point(3, 22);
            this.outputTypeCombo.Name = "outputTypeCombo";
            this.outputTypeCombo.Size = new System.Drawing.Size(144, 21);
            this.outputTypeCombo.TabIndex = 3;
            this.outputTypeCombo.SelectedIndexChanged += new System.EventHandler(this.outputTypeCombo_SelectedIndexChanged);
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Location = new System.Drawing.Point(3, 6);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(72, 13);
            this.eventNameLabel.TabIndex = 5;
            this.eventNameLabel.Text = "dummy_value";
            // 
            // outputControlPanel
            // 
            this.outputControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputControlPanel.Location = new System.Drawing.Point(3, 49);
            this.outputControlPanel.Name = "outputControlPanel";
            this.outputControlPanel.Size = new System.Drawing.Size(144, 95);
            this.outputControlPanel.TabIndex = 4;
            // 
            // EventRecognizerOutputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outputTypeCombo);
            this.Controls.Add(this.eventNameLabel);
            this.Controls.Add(this.outputControlPanel);
            this.Name = "EventRecognizerOutputControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox outputTypeCombo;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Panel outputControlPanel;
    }
}
