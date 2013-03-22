namespace SpontaneousControls.UI
{
    partial class MappingControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zAccelerationBox = new System.Windows.Forms.TextBox();
            this.yAccelerationBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xAccelerationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sensorIdBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.selectControlTypeCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.outputEnabled = new System.Windows.Forms.CheckBox();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensorIdBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.zAccelerationBox);
            this.groupBox1.Controls.Add(this.yAccelerationBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.xAccelerationBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sensorIdBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Z Acceleration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y Acceleration";
            // 
            // zAccelerationBox
            // 
            this.zAccelerationBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zAccelerationBox.Enabled = false;
            this.zAccelerationBox.Location = new System.Drawing.Point(272, 41);
            this.zAccelerationBox.Name = "zAccelerationBox";
            this.zAccelerationBox.Size = new System.Drawing.Size(106, 20);
            this.zAccelerationBox.TabIndex = 5;
            // 
            // yAccelerationBox
            // 
            this.yAccelerationBox.Enabled = false;
            this.yAccelerationBox.Location = new System.Drawing.Point(187, 41);
            this.yAccelerationBox.Name = "yAccelerationBox";
            this.yAccelerationBox.Size = new System.Drawing.Size(79, 20);
            this.yAccelerationBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X Acceleration";
            // 
            // xAccelerationBox
            // 
            this.xAccelerationBox.Enabled = false;
            this.xAccelerationBox.Location = new System.Drawing.Point(108, 41);
            this.xAccelerationBox.Name = "xAccelerationBox";
            this.xAccelerationBox.Size = new System.Drawing.Size(73, 20);
            this.xAccelerationBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sensor Id";
            // 
            // sensorIdBox
            // 
            this.sensorIdBox.Location = new System.Drawing.Point(10, 41);
            this.sensorIdBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.sensorIdBox.Name = "sensorIdBox";
            this.sensorIdBox.Size = new System.Drawing.Size(92, 20);
            this.sensorIdBox.TabIndex = 0;
            this.sensorIdBox.ValueChanged += new System.EventHandler(this.sensorIdBox_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.controlPanel);
            this.groupBox2.Controls.Add(this.selectControlTypeCombo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(4, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.controlPanel.Location = new System.Drawing.Point(6, 69);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(372, 38);
            this.controlPanel.TabIndex = 0;
            // 
            // selectControlTypeCombo
            // 
            this.selectControlTypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectControlTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectControlTypeCombo.FormattingEnabled = true;
            this.selectControlTypeCombo.Location = new System.Drawing.Point(10, 42);
            this.selectControlTypeCombo.Name = "selectControlTypeCombo";
            this.selectControlTypeCombo.Size = new System.Drawing.Size(368, 21);
            this.selectControlTypeCombo.TabIndex = 1;
            this.selectControlTypeCombo.SelectedIndexChanged += new System.EventHandler(this.selectControlTypeCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.outputEnabled);
            this.groupBox3.Controls.Add(this.outputPanel);
            this.groupBox3.Location = new System.Drawing.Point(4, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 201);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // outputEnabled
            // 
            this.outputEnabled.AutoSize = true;
            this.outputEnabled.Location = new System.Drawing.Point(10, 20);
            this.outputEnabled.Name = "outputEnabled";
            this.outputEnabled.Size = new System.Drawing.Size(253, 17);
            this.outputEnabled.TabIndex = 1;
            this.outputEnabled.Text = "Output enabled (press Escape to disable output)";
            this.outputEnabled.UseVisualStyleBackColor = true;
            this.outputEnabled.CheckedChanged += new System.EventHandler(this.outputEnabled_CheckedChanged);
            // 
            // outputPanel
            // 
            this.outputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputPanel.BackColor = System.Drawing.SystemColors.Control;
            this.outputPanel.Location = new System.Drawing.Point(6, 43);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(372, 152);
            this.outputPanel.TabIndex = 0;
            // 
            // MappingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MappingControl";
            this.Size = new System.Drawing.Size(391, 406);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensorIdBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sensorIdBox;
        private System.Windows.Forms.TextBox xAccelerationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectControlTypeCombo;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.TextBox zAccelerationBox;
        private System.Windows.Forms.TextBox yAccelerationBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.CheckBox outputEnabled;

    }
}
