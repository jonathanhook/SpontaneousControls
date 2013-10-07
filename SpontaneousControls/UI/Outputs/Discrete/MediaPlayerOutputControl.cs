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
    public partial class MediaPlayerOutputControl : UserControl
    {
        private const string VOLUME_MUTE = "Mute";
        private const string VOLUME_DOWN = "Volume down";
        private const string VOLUME_UP = "Volume up";
        private const string NEXT_TRACK = "Next track";
        private const string PREVIOUS_TRACK = "Previous track";
        private const string STOP = "Stop";
        private const string PLAY_PAUSE = "Play/pause";
        private const string OPEN = "Open";
        private const string CLOSE = "Close";

        private MediaPlayerOutput output;

        public MediaPlayerOutputControl(MediaPlayerOutput output)
        {
            InitializeComponent();
            this.output = output;

            PopulateActionList();
        }

        private void PopulateActionList()
        {
            actionCombo.Items.Add(VOLUME_MUTE);
            actionCombo.Items.Add(VOLUME_DOWN);
            actionCombo.Items.Add(VOLUME_UP);
            actionCombo.Items.Add(NEXT_TRACK);
            actionCombo.Items.Add(PREVIOUS_TRACK);
            actionCombo.Items.Add(STOP);
            actionCombo.Items.Add(PLAY_PAUSE);
            actionCombo.Items.Add(OPEN);
            actionCombo.Items.Add(CLOSE);
            actionCombo.SelectedIndex = 0;
        }

        private void actionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = actionCombo.SelectedItem.ToString();
            if (selection == VOLUME_MUTE)
            {
                output.EventType = MediaPlayerOutput.MediaPlayerEventType.VolumeMute;
            }
            else if(selection == VOLUME_DOWN)
            {
                output.EventType = MediaPlayerOutput.MediaPlayerEventType.VolumeDown;
            }
            else if(selection == VOLUME_UP)
            {
                output.EventType = MediaPlayerOutput.MediaPlayerEventType.VolumeUp;
            }
            else if(selection == NEXT_TRACK)
            {
                output.EventType = MediaPlayerOutput.MediaPlayerEventType.MediaNextTrack;
            }
            else if(selection == PREVIOUS_TRACK)
            {
                output.EventType = MediaPlayerOutput.MediaPlayerEventType.MediaPreviousTrack;
            }
            else if (selection == STOP)
            {
                output.EventType = MediaPlayerOutput.MediaPlayerEventType.MediaStop;
            }
            else if (selection == PLAY_PAUSE)
            {
                output.EventType = MediaPlayerOutput.MediaPlayerEventType.MediaPlayPause;
            }
            else if (selection == OPEN)
            {
                output.EventType = MediaPlayerOutput.MediaPlayerEventType.Open;
            }
            else if (selection == CLOSE)
            {
                output.EventType = MediaPlayerOutput.MediaPlayerEventType.Close;
            }
        }
    }
}
