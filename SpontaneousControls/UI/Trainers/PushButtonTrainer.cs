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
        private const int TRAINING_TIME = 5000;

        private PushButtonRecognizer recognizer;
        private Timer t;
        private DateTime started;

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

        private void pressedButton_MouseDown(object sender, MouseEventArgs e)
        {
            recognizer.SavePress();
            started = DateTime.UtcNow;

            t = new Timer();
            t.Interval = 100;
            t.Tick += t_Tick;
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.UtcNow - started;
            int spanMs = (int)span.TotalMilliseconds;

            if (spanMs >= TRAINING_TIME)
            {
                t.Stop();
                pressedButton.Text = "Press";
            }
            else
            {
                int countDown = TRAINING_TIME - spanMs;
                pressedButton.Text = string.Format("{0}:{1}", countDown / 1000, countDown % 1000);
            }
        }
    }
}
