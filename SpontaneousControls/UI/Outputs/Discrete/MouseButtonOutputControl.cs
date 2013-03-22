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
using SpontaneousControls.Engine.Outputs.Discrete;

namespace SpontaneousControls.UI.Outputs.Discrete
{
    public partial class MouseButtonOutputControl : UserControl
    {
        private const string LEFT_BUTTON_LABEL = "Left";
        private const string RIGHT_BUTTON_LABEL = "Right";
        private const string CLICKED_ACTION_LABEL = "Click";
        private const string DOUBLE_CLICKED_ACTION_LABEL = "Double click";
        private const string PRESSED_ACTION_LABEL = "Press";
        private const string RELEASED_ACTION_LABEL = "Release";

        private MouseButtonOutput output;

        public MouseButtonOutputControl(MouseButtonOutput output)
        {
            InitializeComponent();
            this.output = output;

            buttonCombo.Items.Add(LEFT_BUTTON_LABEL);
            buttonCombo.Items.Add(RIGHT_BUTTON_LABEL);
            buttonCombo.SelectedIndex = 0;

            eventTypeCombo.Items.Add(CLICKED_ACTION_LABEL);
            eventTypeCombo.Items.Add(DOUBLE_CLICKED_ACTION_LABEL);
            eventTypeCombo.Items.Add(PRESSED_ACTION_LABEL);
            eventTypeCombo.Items.Add(RELEASED_ACTION_LABEL);
            eventTypeCombo.SelectedIndex = 0;
        }

        private void buttonCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buttonCombo.SelectedItem.ToString() == LEFT_BUTTON_LABEL)
            {
                output.Button = MouseButtonOutput.MouseButton.Left;
            }
            else
            {
                output.Button = MouseButtonOutput.MouseButton.Right;
            }
        }

        private void eventTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventTypeCombo.SelectedItem.ToString() == PRESSED_ACTION_LABEL)
            {
                output.EventType = MouseButtonOutput.MouseEventType.Press;
            }
            else if (eventTypeCombo.SelectedItem.ToString() == RELEASED_ACTION_LABEL)
            {
                output.EventType = MouseButtonOutput.MouseEventType.Release;
            }
            else if (eventTypeCombo.SelectedItem.ToString() == CLICKED_ACTION_LABEL)
            {
                output.EventType = MouseButtonOutput.MouseEventType.Click;
            }
            else if (eventTypeCombo.SelectedItem.ToString() == DOUBLE_CLICKED_ACTION_LABEL)
            {
                output.EventType = MouseButtonOutput.MouseEventType.DoubleClick;
            }
        }
    }
}
