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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpontaneousControls.Engine;

namespace SpontaneousControls.UI
{
    public partial class SpontaneousControlsUI : Form
    {
        public SpontaneousControlsUI()
        {
            InitializeComponent();
            CreateNewTab();
        }

        private void CreateNewTab()
        {
            TabPage page = new TabPage();

            MappingControl mapping = new MappingControl();
            mapping.Width = page.Width;
            mapping.Height = page.Height;
            mapping.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            mapping.SensorIdChanged += mapping_SensorIdChanged;

            page.Text = mapping.Mapping.SensorId.ToString();
            page.Controls.Add(mapping);
            tabControl.Controls.Add(page);
        }

        private void mapping_SensorIdChanged(object sender, int id)
        {
            foreach (TabPage p in tabControl.Controls)
            {
                if (p.Controls.Contains((MappingControl)sender))
                {
                    p.Text = id.ToString();
                }
            }
        }

        private void SpontaneousControlsUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //mappingControl1.DisableOutput();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewTab();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MappingControl mc = (MappingControl)tabControl.SelectedTab.Controls[0];

            tabControl.Controls.Remove(tabControl.SelectedTab);

            ControlManager.GetInstance().UnRegisterMapping(mc.Mapping);
        }
    }
}
