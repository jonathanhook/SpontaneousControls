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
using SpontaneousControls.Engine.Recognizers;
using System.Threading;
using SpontaneousControls.UI.Trainers;

namespace SpontaneousControls.UI.Controls
{
    public partial class MovementControl : UserControl
    {
        private MovementRecognizer recognizer;

        public MovementControl(MovementRecognizer recognizer)
        {
            this.recognizer = recognizer;
            recognizer.MovementOccurred += recognizer_MovementOccurred;

            InitializeComponent();
        }

        private void recognizer_MovementOccurred(object sender)
        {
            this.BeginInvoke(new Action(() =>
            {
                movementToggleButton.CheckState = CheckState.Checked;
                Thread.Sleep(50);
                movementToggleButton.CheckState = CheckState.Unchecked;
            }));
        }

        private void movementToggleButton_MouseDown(object sender, MouseEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            cb.CheckState = CheckState.Checked;
        }

        private void movementToggleButton_MouseUp(object sender, MouseEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            cb.CheckState = CheckState.Unchecked;

            if (recognizer.IsOutputEnabled && recognizer.Output != null)
            {
                recognizer.Output.Trigger();
            }
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            MovementTrainer trainer = new MovementTrainer(recognizer);
            trainer.StartPosition = FormStartPosition.CenterParent;
            trainer.Show();
        }
    }
}
