﻿/**
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
using SpontaneousControls.Engine;
using SpontaneousControls.Engine.Recognizers;
using SpontaneousControls.UI.Controls;
using SpontaneousControls.UI.Outputs.Continuous;
using SpontaneousControls.UI.Outputs.Discrete;

namespace SpontaneousControls.UI
{
    public partial class MappingControl : UserControl
    {

        private Mapping mapping;

        public MappingControl()
        {
            InitializeComponent();

            mapping = new Mapping((int)sensorIdBox.Value);
            mapping.DataReceived += mapping_DataReceived;

            ControlManager.GetInstance().RegisterMapping(mapping);

            PopulateControlTypes();
        }

        public void DisableOutput()
        {
            outputEnabled.CheckState = CheckState.Unchecked;
        }

        private void mapping_DataReceived(object sender, MotionData data)
        {
            this.Invoke(new Action(() =>
            {
                xAccelerationBox.Text = data.Data.X.ToString();
                yAccelerationBox.Text = data.Data.Y.ToString();
                zAccelerationBox.Text = data.Data.Z.ToString();
            }));
        }

        private void PopulateControlTypes()
        {
            selectControlTypeCombo.Items.Add(CircularSliderRecognizer.FreindlyName);
            selectControlTypeCombo.Items.Add(PedalButtonRecognizer.FreindlyName);
            selectControlTypeCombo.Items.Add(DialRecognizer.FreindlyName);
            selectControlTypeCombo.Items.Add(RotaryEncoderRecognizer.FreindlyName);
            selectControlTypeCombo.SelectedIndex = 0;
        }



        private void sensorIdBox_ValueChanged(object sender, EventArgs e)
        {
            mapping.SensorId = (int)sensorIdBox.Value;
        }

        private void selectControlTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.SetRecognizerByName(selectControlTypeCombo.SelectedItem.ToString());

            Control control = null;
            if (mapping.Recognizer is CircularSliderRecognizer)
            {
                control = new CircularSliderControl((CircularSliderRecognizer)mapping.Recognizer);
            }
            else if (mapping.Recognizer is PedalButtonRecognizer)
            {
                control = new PedalButtonControl((PedalButtonRecognizer)mapping.Recognizer);
            }
            else if (mapping.Recognizer is DialRecognizer)
            {
                control = new DialRecognizerControl((DialRecognizer)mapping.Recognizer);
            }
            else if (mapping.Recognizer is RotaryEncoderRecognizer)
            {
                control = new RotaryEncoderRecognizerControl((RotaryEncoderRecognizer)mapping.Recognizer);
            }

            if (control != null)
            {
                control.Width = controlPanel.Width;
                control.Anchor = (AnchorStyles.Top | AnchorStyles.Left |AnchorStyles.Right);
                controlPanel.Controls.Clear();
                controlPanel.Controls.Add(control);
            }

            Control output = null;
            if(mapping.Recognizer is ContinuousValueRecognizer)
            {
                output = new ContinuousValueRecognizerOutputControl((ContinuousValueRecognizer)mapping.Recognizer);
            }
            else if (mapping.Recognizer is EventRecognizer)
            {
                output = new EventRecognizerOutputControl((EventRecognizer)mapping.Recognizer);
            }
            else if (mapping.Recognizer is DualEventRecognizer)
            {
                output = new DualEventRecognizerOutputControl((DualEventRecognizer)mapping.Recognizer);
            }

            if (output != null)
            {
                output.Width = outputPanel.Width;
                output.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                outputPanel.Controls.Clear();
                outputPanel.Controls.Add(output);
            }
        }

        private void outputEnabled_CheckedChanged(object sender, EventArgs e)
        {
            mapping.Recognizer.IsOutputEnabled = outputEnabled.CheckState == CheckState.Checked ? true : false;
        }
    }
}
