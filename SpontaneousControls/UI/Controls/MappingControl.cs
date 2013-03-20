/**
 * This file is part of Spontaneous Controls.
 *
 * Created by Jonathan Hook (jonathan.hook@ncl.ac.uk)
 * Copyright (c) 2013 Jonathan Hook. All rights reserved.
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

namespace SpontaneousControls.UI.Controls
{
    public partial class MappingControl : UserControl
    {
        private Mapping mapping;

        public MappingControl()
        {
            InitializeComponent();


        }

        public void Initialise()
        {
            ControlManager.GetInstance().RegisterMapping(new Mapping(0));


        }

        private void PopulateControlTypes()
        {
            selectControlTypeCombo.Items.Add
        }

        private void sensorIdBox_ValueChanged(object sender, EventArgs e)
        {
            mapping.SensorId = (int)sensorIdBox.Value;
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (mapping.LastDataReceived != null)
            {
                xAccelerationBox.Text = mapping.LastDataReceived.X.ToString();
                yAccelerationBox.Text = mapping.LastDataReceived.Y.ToString();
                zAccelerationBox.Text = mapping.LastDataReceived.Z.ToString();
            } 
        }

    }
}
