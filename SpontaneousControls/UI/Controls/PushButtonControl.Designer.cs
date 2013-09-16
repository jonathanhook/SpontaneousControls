namespace SpontaneousControls.UI.Controls
{
    partial class PushButtonControl
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
            this.pushToggleButton = new System.Windows.Forms.CheckBox();
            this.trainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pushToggleButton
            // 
            this.pushToggleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pushToggleButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pushToggleButton.Location = new System.Drawing.Point(3, 0);
            this.pushToggleButton.Name = "pushToggleButton";
            this.pushToggleButton.Size = new System.Drawing.Size(251, 24);
            this.pushToggleButton.TabIndex = 6;
            this.pushToggleButton.Text = "Push Button";
            this.pushToggleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pushToggleButton.UseVisualStyleBackColor = true;
            this.pushToggleButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pushToggleButton_MouseUp);
            // 
            // trainButton
            // 
            this.trainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trainButton.Location = new System.Drawing.Point(260, 0);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(65, 24);
            this.trainButton.TabIndex = 5;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // PushButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pushToggleButton);
            this.Controls.Add(this.trainButton);
            this.Name = "PushButtonControl";
            this.Size = new System.Drawing.Size(328, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox pushToggleButton;
        private System.Windows.Forms.Button trainButton;


    }
}
