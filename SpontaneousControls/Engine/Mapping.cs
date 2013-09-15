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
using System.Linq;
using System.Text;

using SpontaneousControls.Engine.Recognizers;

namespace SpontaneousControls.Engine
{
    public class Mapping
    {
        public delegate void DataReceivedHandler(object sender, MotionData data);
        public event DataReceivedHandler DataReceived;

        public Recognizer Recognizer { get; set; }
        public int SensorId { get; set; }

        public Mapping(int sensorId)
        {
            this.SensorId = sensorId;
        }

        public void SetRecognizerByName(string name)
        {
            if (name == CircularSliderRecognizer.FreindlyName)
            {
                Recognizer = new CircularSliderRecognizer();
            }
            else if (name == PedalButtonRecognizer.FreindlyName)
            {
                Recognizer = new PedalButtonRecognizer();
            }
            else if (name == DialRecognizer.FreindlyName)
            {
                Recognizer = new DialRecognizer();
            }
            else if (name == RotaryEncoderRecognizer.FreindlyName)
            {
                Recognizer = new RotaryEncoderRecognizer();
            }
            else if (name == MovementRecognizer.FreindlyName)
            {
                Recognizer = new MovementRecognizer();
            }
            else if (name == PushButtonRecognizer.FreindlyName)
            {
                Recognizer = new PushButtonRecognizer();
            }
        }

        public void Update(MotionData data)
        {
            if (Recognizer != null)
            {
                Recognizer.Update(data);
            }

            if (DataReceived != null)
            {
                DataReceived(this, data);
            }
        }
    }
}
