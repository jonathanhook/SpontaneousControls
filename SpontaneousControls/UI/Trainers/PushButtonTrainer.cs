using SpontaneousControls.Engine.Recognizers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpontaneousControls.UI.Trainers
{
    public partial class PushButtonTrainer : Form
    {
        private PushButtonRecognizer recognizer;

        public PushButtonTrainer(PushButtonRecognizer recognizer)
        {
            InitializeComponent();

            this.recognizer = recognizer;
            sensitivityTrackBar.Value = (int)((float)recognizer.Sensitivity * (float)sensitivityTrackBar.Maximum);
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sensitivityTrackBar_Scroll(object sender, EventArgs e)
        {
            recognizer.Sensitivity = (float)sensitivityTrackBar.Value / (float)sensitivityTrackBar.Maximum;
        }

        private void pressedButton_Click(object sender, EventArgs e)
        {
            
        }

        private void pressedButton_MouseDown(object sender, MouseEventArgs e)
        {
            recognizer.SavePress();
        }
    }
}
