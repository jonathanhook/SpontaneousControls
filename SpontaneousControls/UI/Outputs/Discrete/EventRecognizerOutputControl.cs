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
    public partial class EventRecognizerOutputControl : UserControl
    {
        private EventRecognizer recognizer;

        public EventRecognizerOutputControl(EventRecognizer recognizer)
        {
            InitializeComponent();

            this.recognizer = recognizer;
            eventNameLabel.Text = recognizer.OutputFriendlyName;
        }

        private void outputTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
