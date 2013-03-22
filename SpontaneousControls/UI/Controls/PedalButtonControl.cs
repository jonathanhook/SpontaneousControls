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

namespace SpontaneousControls.UI.Controls
{
    public partial class PedalButtonControl : UserControl
    {
        private PedalButtonRecognizer recognizer;

        public PedalButtonControl(PedalButtonRecognizer recognizer)
        {
            this.recognizer = recognizer;
            recognizer.PedalButtonPressed += recognizer_PedalButtonPressed;
            recognizer.PedalButtonReleased += recognizer_PedalButtonReleased;

            InitializeComponent();
        }

        private void recognizer_PedalButtonReleased(object sender)
        {
            this.Invoke(new Action(() =>
            {
                pedalToggleButton.CheckState = CheckState.Unchecked;
            }));
        }

        private void recognizer_PedalButtonPressed(object sender)
        {
            this.Invoke(new Action(() =>
            {
                pedalToggleButton.CheckState = CheckState.Checked;
            }));
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            PedalButtonTrainer trainer = new PedalButtonTrainer(recognizer);
            trainer.StartPosition = FormStartPosition.CenterParent;
            trainer.Show();
        }

        private void pedalToggleButton_MouseDown(object sender, MouseEventArgs e)
        {
            pedalToggleButton.CheckState = CheckState.Checked;

            if (recognizer.IsOutputEnabled && recognizer.OutputOne != null)
            {
                recognizer.OutputOne.Trigger();
            }
        }

        private void pedalToggleButton_MouseUp(object sender, MouseEventArgs e)
        {
            pedalToggleButton.CheckState = CheckState.Unchecked;

            if (recognizer.IsOutputEnabled && recognizer.OutputTwo != null)
            {
                recognizer.OutputTwo.Trigger();
            }
        }
    }
}
