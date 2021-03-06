﻿namespace SpontaneousControls.UI.Trainers
{
    partial class PushButtonTrainer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.sensitivityTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pressedButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityTrackBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Follow the instructions to train your push button:";
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(104, 232);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 7;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // sensitivityTrackBar
            // 
            this.sensitivityTrackBar.Location = new System.Drawing.Point(9, 57);
            this.sensitivityTrackBar.Name = "sensitivityTrackBar";
            this.sensitivityTrackBar.Size = new System.Drawing.Size(244, 45);
            this.sensitivityTrackBar.TabIndex = 1;
            this.sensitivityTrackBar.Value = 8;
            this.sensitivityTrackBar.Scroll += new System.EventHandler(this.sensitivityTrackBar_Scroll);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Use the slider to set how sensitive your push button will be.";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.sensitivityTrackBar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 106);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sensivity";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pressedButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 78);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Demonstrate";
            // 
            // pressedButton
            // 
            this.pressedButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pressedButton.Location = new System.Drawing.Point(183, 19);
            this.pressedButton.Name = "pressedButton";
            this.pressedButton.Size = new System.Drawing.Size(70, 47);
            this.pressedButton.TabIndex = 2;
            this.pressedButton.Text = "Press";
            this.pressedButton.UseVisualStyleBackColor = true;
            this.pressedButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pressedButton_MouseDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "Press the button on the right and then repeatedly press and release your push but" +
    "ton for 5 seconds.";
            // 
            // PushButtonTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.label1);
            this.Name = "PushButtonTrainer";
            this.Text = "PushButtonTrainer";
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityTrackBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TrackBar sensitivityTrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button pressedButton;
        private System.Windows.Forms.Label label3;
    }
}