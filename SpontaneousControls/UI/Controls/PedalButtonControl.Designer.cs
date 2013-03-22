namespace SpontaneousControls.UI.Controls
{
    partial class PedalButtonControl
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
            this.trainButton = new System.Windows.Forms.Button();
            this.pedalToggleButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // trainButton
            // 
            this.trainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trainButton.Location = new System.Drawing.Point(260, 3);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(65, 23);
            this.trainButton.TabIndex = 2;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // pedalToggleButton
            // 
            this.pedalToggleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pedalToggleButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pedalToggleButton.Location = new System.Drawing.Point(3, 3);
            this.pedalToggleButton.Name = "pedalToggleButton";
            this.pedalToggleButton.Size = new System.Drawing.Size(251, 24);
            this.pedalToggleButton.TabIndex = 4;
            this.pedalToggleButton.Text = "Pedal Button";
            this.pedalToggleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pedalToggleButton.UseVisualStyleBackColor = true;
            this.pedalToggleButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pedalToggleButton_MouseDown);
            this.pedalToggleButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pedalToggleButton_MouseUp);
            // 
            // PedalButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pedalToggleButton);
            this.Controls.Add(this.trainButton);
            this.Name = "PedalButtonControl";
            this.Size = new System.Drawing.Size(328, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.CheckBox pedalToggleButton;
    }
}
