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
using SpontaneousControls.Engine.Outputs.Continuous;

namespace SpontaneousControls.UI.Outputs.Continuous
{
    public partial class AbsoluteMousePositionOutputControl : UserControl
    {
        private const string X_AXIS_LABEL = "Horizontal (left to right)";
        private const string Y_AXIS_LABEL = "Vertical (top to bottom)";

        private AbsoluteMousePositionOutput output;

        public AbsoluteMousePositionOutputControl(AbsoluteMousePositionOutput output)
        {
            InitializeComponent();

            this.output = output;

            axisCombo.Items.Add(X_AXIS_LABEL);
            axisCombo.Items.Add(Y_AXIS_LABEL);
            axisCombo.SelectedIndex = 0;
        }

        private void axisCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (axisCombo.SelectedItem.ToString() == X_AXIS_LABEL)
            {
                output.Axis = AbsoluteMousePositionOutput.MouseAxis.X;
            }
            else if (axisCombo.SelectedItem.ToString() == Y_AXIS_LABEL)
            {
                output.Axis = AbsoluteMousePositionOutput.MouseAxis.Y;
            }
        }
    }
}
