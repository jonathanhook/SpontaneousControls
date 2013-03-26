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
    public partial class MouseScrollOutputControl : UserControl
    {
        private const string UP_DIRECTION_LABEL = "Up";
        private const string DOWN_DIRECTION_LABEL = "Down";

        private MouseScrollOutput output;

        public MouseScrollOutputControl(MouseScrollOutput output)
        {
            InitializeComponent();
            this.output = output;

            directionCombo.Items.Add(UP_DIRECTION_LABEL);
            directionCombo.Items.Add(DOWN_DIRECTION_LABEL);
            directionCombo.SelectedIndex = 0;
        }

        private void directionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (directionCombo.SelectedItem.ToString() == UP_DIRECTION_LABEL)
            {
                output.EventType = MouseScrollOutput.ScrollEventType.Up;
            }
            else if (directionCombo.SelectedItem.ToString() == DOWN_DIRECTION_LABEL)
            {
                output.EventType = MouseScrollOutput.ScrollEventType.Down;
            }
        }
    }
}
