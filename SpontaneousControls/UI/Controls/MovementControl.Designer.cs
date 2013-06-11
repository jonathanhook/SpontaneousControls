namespace SpontaneousControls.UI.Controls
{
    partial class MovementControl
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
            this.movementToggleButton = new System.Windows.Forms.CheckBox();
            this.trainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movementToggleButton
            // 
            this.movementToggleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movementToggleButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.movementToggleButton.Location = new System.Drawing.Point(3, 3);
            this.movementToggleButton.Name = "movementToggleButton";
            this.movementToggleButton.Size = new System.Drawing.Size(253, 24);
            this.movementToggleButton.TabIndex = 6;
            this.movementToggleButton.Text = "Movement";
            this.movementToggleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.movementToggleButton.UseVisualStyleBackColor = true;
            this.movementToggleButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movementToggleButton_MouseDown);
            this.movementToggleButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.movementToggleButton_MouseUp);
            // 
            // trainButton
            // 
            this.trainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trainButton.Location = new System.Drawing.Point(262, 3);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(65, 24);
            this.trainButton.TabIndex = 5;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // MovementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.movementToggleButton);
            this.Controls.Add(this.trainButton);
            this.Name = "MovementControl";
            this.Size = new System.Drawing.Size(330, 34);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox movementToggleButton;
        private System.Windows.Forms.Button trainButton;

    }
}
