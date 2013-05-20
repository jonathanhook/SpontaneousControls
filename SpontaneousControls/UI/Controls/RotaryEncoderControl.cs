using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpontaneousControls.Engine.Recognizers;
using SpontaneousControls.UI.Trainers;
using System.Threading;

namespace SpontaneousControls.UI.Controls
{
    public partial class RotaryEncoderControl : UserControl
    {
        private RotaryEncoderRecognizer recognizer;

        public RotaryEncoderControl(RotaryEncoderRecognizer recognizer)
        {
            InitializeComponent();

            this.recognizer = recognizer;
            recognizer.RotaryEncoderClockwise += recognizer_RotaryEncoderClockwise;
            recognizer.RotaryEncoderAntiClockwise += recognizer_RotaryEncoderAntiClockwise;
        }

        private void recognizer_RotaryEncoderAntiClockwise(object sender)
        {
            this.BeginInvoke(new Action(() =>
            {
                antiClockwiseToggleButton.CheckState = CheckState.Checked;
                Thread.Sleep(50);
                antiClockwiseToggleButton.CheckState = CheckState.Unchecked;
            }));
        }

        private void recognizer_RotaryEncoderClockwise(object sender)
        {
            this.BeginInvoke(new Action(() =>
            {
                clockwiseToggleButton.CheckState = CheckState.Checked;
                Thread.Sleep(50);
                clockwiseToggleButton.CheckState = CheckState.Unchecked;
            }));
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            RotaryEncoderTrainer trainer = new RotaryEncoderTrainer(recognizer);
            trainer.StartPosition = FormStartPosition.CenterParent;
            trainer.Show();
        }

        private void toggleButton_MouseUp(object sender, MouseEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            cb.CheckState = CheckState.Unchecked;

            if (cb.Name == "clockwiseToggleButton" &&
                recognizer.IsOutputEnabled && 
                recognizer.OutputOne != null)
            {
                recognizer.OutputOne.Trigger();
            }
            else if (cb.Name == "antiClockwiseToggleButton" &&
                     recognizer.IsOutputEnabled && 
                     recognizer.OutputTwo != null)
            {
                recognizer.OutputTwo.Trigger();
            }
        }

        private void toggleButton_MouseDown(object sender, MouseEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            cb.CheckState = CheckState.Checked;
        }
    }
}
