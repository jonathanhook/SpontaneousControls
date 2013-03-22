namespace SpontaneousControls.UI.Outputs.Discrete
{
    partial class KeyboardOutputControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.keyValueCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.actionCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keyFilterCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Key value";
            // 
            // keyValueCombo
            // 
            this.keyValueCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyValueCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyValueCombo.FormattingEnabled = true;
            this.keyValueCombo.Location = new System.Drawing.Point(0, 56);
            this.keyValueCombo.Name = "keyValueCombo";
            this.keyValueCombo.Size = new System.Drawing.Size(194, 21);
            this.keyValueCombo.TabIndex = 15;
            this.keyValueCombo.SelectedIndexChanged += new System.EventHandler(this.keyValueCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Action";
            // 
            // actionCombo
            // 
            this.actionCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionCombo.FormattingEnabled = true;
            this.actionCombo.Location = new System.Drawing.Point(0, 96);
            this.actionCombo.Name = "actionCombo";
            this.actionCombo.Size = new System.Drawing.Size(194, 21);
            this.actionCombo.TabIndex = 17;
            this.actionCombo.SelectedIndexChanged += new System.EventHandler(this.actionCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Key type";
            // 
            // keyFilterCombo
            // 
            this.keyFilterCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyFilterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyFilterCombo.FormattingEnabled = true;
            this.keyFilterCombo.Location = new System.Drawing.Point(0, 16);
            this.keyFilterCombo.Name = "keyFilterCombo";
            this.keyFilterCombo.Size = new System.Drawing.Size(194, 21);
            this.keyFilterCombo.TabIndex = 12;
            this.keyFilterCombo.SelectedIndexChanged += new System.EventHandler(this.keyFilterCombo_SelectedIndexChanged);
            // 
            // KeyboardOutputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.actionCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keyValueCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyFilterCombo);
            this.Controls.Add(this.label1);
            this.Name = "KeyboardOutputControl";
            this.Size = new System.Drawing.Size(194, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox keyValueCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox actionCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox keyFilterCombo;
    }
}
