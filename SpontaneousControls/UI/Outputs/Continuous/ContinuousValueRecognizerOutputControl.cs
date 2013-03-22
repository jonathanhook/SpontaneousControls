/**
 * This file is part of Spontaneous Controls.
 *
 * Created by Jonathan Hook (jonathan.hook@ncl.ac.uk)
 * Copyright (c) 2013 Newcastle University. All rights reserved.
 *
 * PhysicsSynth is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * PhysicsSynth is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with Spontaneous Controls.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpontaneousControls.Engine.Recognizers;
using SpontaneousControls.Engine.Outputs.Continuous;

namespace SpontaneousControls.UI.Outputs.Continuous
{
    public partial class ContinuousValueRecognizerOutputControl : UserControl
    {
        private ContinuousValueRecognizer recognizer;

        public ContinuousValueRecognizerOutputControl(ContinuousValueRecognizer recognizer)
        {
            InitializeComponent();

            this.recognizer = recognizer;
            eventNameLabel.Text = recognizer.OutputFriendlyName;

            PopulateOutputTypes();
        }

        private void PopulateOutputTypes()
        {
            outputTypeCombo.Items.Add(AbsoluteMousePositionOutput.FreindlyName);
            outputTypeCombo.SelectedIndex = 0;
        }

        private void outputTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            recognizer.SetOutputByName(outputTypeCombo.SelectedItem.ToString());

            Control control = null;
            if (recognizer.Output is AbsoluteMousePositionOutput)
            {
                control = new AbsoluteMousePositionOutputControl((AbsoluteMousePositionOutput)recognizer.Output);
            }

            if (control != null)
            {
                control.Width = outputControlPanel.Width;
                control.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                outputControlPanel.Controls.Clear();
                outputControlPanel.Controls.Add(control);
            }
        }
    }
}
