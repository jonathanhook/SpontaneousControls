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
    public partial class DualEventRecognizerOutputControl : UserControl
    {
        private const string NONE_ITEM = "Do nothing";

        private DualEventRecognizer recognizer;

        public DualEventRecognizerOutputControl(DualEventRecognizer recognizer)
        {
            InitializeComponent();

            this.recognizer = recognizer;
            eventOneNameLabel.Text = recognizer.OutputOneFriendlyName;
            eventTwoNameLabel.Text = recognizer.OutputTwoFriendlyName;

            PopulateOutputTypes(outputOneTypeCombo, 0);
            PopulateOutputTypes(outputTwoTypeCombo, 2);
        }

        private void PopulateOutputTypes(ComboBox combo, int initalSelection)
        {
            combo.Items.Add(MouseButtonOutput.FreindlyName);
            combo.Items.Add(KeyboardOutput.FreindlyName);
            combo.Items.Add(NONE_ITEM);
            combo.SelectedIndex = initalSelection;
        }

        private void outputTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel controlPanel = null;
            DiscreteOutput output = null;

            if (sender == outputOneTypeCombo)
            {
                recognizer.SetOutputOneByName(outputOneTypeCombo.SelectedItem.ToString());
                output = recognizer.OutputOne;
                controlPanel = outputOneControlPanel;
            }
            else
            {
                recognizer.SetOutputTwoByName(outputTwoTypeCombo.SelectedItem.ToString());
                output = recognizer.OutputTwo;
                controlPanel = outputTwoControlPanel;
            }
            
            Control control = null;
            if (output is MouseButtonOutput)
            {
                control = new MouseButtonOutputControl((MouseButtonOutput)output);
            }
            else if (output is KeyboardOutput)
            {
                control = new KeyboardOutputControl((KeyboardOutput)output);
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
