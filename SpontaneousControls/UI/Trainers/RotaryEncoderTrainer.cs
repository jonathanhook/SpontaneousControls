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
using SpontaneousControls.Engine.Recognizers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpontaneousControls.UI.Trainers
{
    public partial class RotaryEncoderTrainer : Form
    {
        private RotaryEncoderRecognizer recognizer;

        public RotaryEncoderTrainer(RotaryEncoderRecognizer recognizer)
        {
            InitializeComponent();
            this.recognizer = recognizer;

            incrementsTrackBar.Value = recognizer.Increments;
        }

        private void quarterButton_Click(object sender, EventArgs e)
        {
            recognizer.SaveQuarter();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            recognizer.SaveStart();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void incrementsTrackBar_Scroll(object sender, EventArgs e)
        {
            recognizer.Increments = incrementsTrackBar.Value;
        }
    }
}
