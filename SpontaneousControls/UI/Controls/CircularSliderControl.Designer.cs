namespace SpontaneousControls.UI.Controls
{
    partial class CircularSliderControl
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
            this.sliderTrackBar = new System.Windows.Forms.TrackBar();
            this.trainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // sliderTrackBar
            // 
            this.sliderTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderTrackBar.Location = new System.Drawing.Point(3, 3);
            this.sliderTrackBar.Maximum = 25;
            this.sliderTrackBar.Name = "sliderTrackBar";
            this.sliderTrackBar.Size = new System.Drawing.Size(255, 45);
            this.sliderTrackBar.TabIndex = 0;
            // 
            // trainButton
            // 
            this.trainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trainButton.Location = new System.Drawing.Point(264, 3);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(65, 23);
            this.trainButton.TabIndex = 1;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // CircularSliderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.sliderTrackBar);
            this.Name = "CircularSliderControl";
            this.Size = new System.Drawing.Size(332, 42);
            ((System.ComponentModel.ISupportInitialize)(this.sliderTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar sliderTrackBar;
        private System.Windows.Forms.Button trainButton;
    }
}
