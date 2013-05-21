using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpontaneousControls.Engine.Recognizers;
using SpontaneousControls.Engine.Outputs.Discrete;

namespace SpontaneousControls.UI.Outputs.Discrete
{
    public partial class EventRecognizerOutputControl : UserControl
    {
        private const string NONE_ITEM = "Do nothing";

        private EventRecognizer recognizer;

        public EventRecognizerOutputControl(EventRecognizer recognizer)
        {
            InitializeComponent();

            this.recognizer = recognizer;
            eventNameLabel.Text = recognizer.OutputFriendlyName;

            outputTypeCombo.Items.Add(NONE_ITEM);
            outputTypeCombo.Items.Add(MouseButtonOutput.FreindlyName);
            outputTypeCombo.Items.Add(MouseScrollOutput.FreindlyName);
            outputTypeCombo.Items.Add(KeyboardOutput.FreindlyName);
            outputTypeCombo.Items.Add(MediaPlayerOutput.FreindlyName);
            outputTypeCombo.Items.Add(WebBrowserOutput.FreindlyName);
            outputTypeCombo.SelectedIndex = 0;
        }

        private void outputTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel controlPanel = null;
            DiscreteOutput output = null;

            recognizer.SetOutputByName(outputTypeCombo.SelectedItem.ToString());
            output = recognizer.Output;
            controlPanel = outputControlPanel;

            Control control = null;
            if (output is MouseButtonOutput)
            {
                control = new MouseButtonOutputControl((MouseButtonOutput)output);
            }
            else if (output is KeyboardOutput)
            {
                control = new KeyboardOutputControl((KeyboardOutput)output);
            }
            else if (output is MediaPlayerOutput)
            {
                control = new MediaPlayerOutputControl((MediaPlayerOutput)output);
            }
            else if (output is WebBrowserOutput)
            {
                control = new WebBrowserOutputControl((WebBrowserOutput)output);
            }
            else if (output is MouseScrollOutput)
            {
                control = new MouseScrollOutputControl((MouseScrollOutput)output);
            }
            else
            {
                controlPanel.Controls.Clear();
            }

            if (control != null)
            {
                control.Width = controlPanel.Width;
                control.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                controlPanel.Controls.Clear();
                controlPanel.Controls.Add(control);
            }
        }
    }
}
