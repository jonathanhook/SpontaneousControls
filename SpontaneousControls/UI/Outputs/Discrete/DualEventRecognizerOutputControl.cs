using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpontaneousControls.Engine.Recognizers;

namespace SpontaneousControls.UI.Outputs.Discrete
{
    public partial class DualEventRecognizerOutputControl : UserControl
    {
        private DualEventRecognizer recognizer;

        public DualEventRecognizerOutputControl(DualEventRecognizer recognizer)
        {
            InitializeComponent();

            this.recognizer = recognizer;
            eventOneNameLabel.Text = recognizer.OutputOneFriendlyName;
            eventTwoNameLabel.Text = recognizer.OutputTwoFriendlyName;
        }

        private void outputOneTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void outputTwoTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
