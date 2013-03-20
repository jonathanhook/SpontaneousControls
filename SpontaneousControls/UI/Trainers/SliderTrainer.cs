using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpontaneousControls.Engine.Recognizers;

namespace SpontaneousControls.UI.Trainers
{
    public partial class SliderTrainer : Form
    {
        private SliderRecognizer recognizer;

        public SliderTrainer(SliderRecognizer recognizer)
        {
            this.recognizer = recognizer;
            InitializeComponent();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            recognizer.SaveStart();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            recognizer.SaveEnd();
        }
    }
}
