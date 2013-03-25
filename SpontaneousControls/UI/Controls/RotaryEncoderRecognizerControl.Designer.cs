namespace SpontaneousControls.UI.Controls
{
    partial class RotaryEncoderRecognizerControl
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
            this.antiClockwiseToggleButton = new System.Windows.Forms.CheckBox();
            this.clockwiseToggleButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // trainButton
            // 
            this.trainButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trainButton.Location = new System.Drawing.Point(313, 3);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(65, 24);
            this.trainButton.TabIndex = 4;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // antiClockwiseToggleButton
            // 
            this.antiClockwiseToggleButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.antiClockwiseToggleButton.Location = new System.Drawing.Point(158, 3);
            this.antiClockwiseToggleButton.Name = "antiClockwiseToggleButton";
            this.antiClockwiseToggleButton.Size = new System.Drawing.Size(149, 24);
            this.antiClockwiseToggleButton.TabIndex = 5;
            this.antiClockwiseToggleButton.Text = "Anti-clockwise";
            this.antiClockwiseToggleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.antiClockwiseToggleButton.UseVisualStyleBackColor = true;
            this.antiClockwiseToggleButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toggleButton_MouseDown);
            this.antiClockwiseToggleButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toggleButton_MouseUp);
            // 
            // clockwiseToggleButton
            // 
            this.clockwiseToggleButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.clockwiseToggleButton.Location = new System.Drawing.Point(3, 3);
            this.clockwiseToggleButton.Name = "clockwiseToggleButton";
            this.clockwiseToggleButton.Size = new System.Drawing.Size(149, 24);
            this.clockwiseToggleButton.TabIndex = 6;
            this.clockwiseToggleButton.Text = "Clockwise";
            this.clockwiseToggleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clockwiseToggleButton.UseVisualStyleBackColor = true;
            this.clockwiseToggleButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toggleButton_MouseDown);
            this.clockwiseToggleButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toggleButton_MouseUp);
            // 
            // RotaryEncoderRecognizerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clockwiseToggleButton);
            this.Controls.Add(this.antiClockwiseToggleButton);
            this.Controls.Add(this.trainButton);
            this.Name = "RotaryEncoderRecognizerControl";
            this.Size = new System.Drawing.Size(384, 41);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.CheckBox antiClockwiseToggleButton;
        private System.Windows.Forms.CheckBox clockwiseToggleButton;

    }
}
