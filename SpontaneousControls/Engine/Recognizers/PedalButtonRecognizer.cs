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
using Microsoft.Xna.Framework;

namespace SpontaneousControls.Engine.Recognizers
{
    public class PedalButtonRecognizer : DualEventRecognizer
    {
        private const float PRESSED_THRESHOLD = 0.5f;
        private const string PEDAL_OUTPUT_ONE_FRIENDLY_NAME = "On pedal pressed";
        private const string PEDAL_OUTPUT_TWO_FRIENDLY_NAME = "On pedal released";

        public delegate void PedalButtonPressedHandler(object sender);
        public event PedalButtonPressedHandler PedalButtonPressed;

        public delegate void PedalButtonReleasedHandler(object sender);
        public event PedalButtonReleasedHandler PedalButtonReleased;

        private Vector3 up;
        private Vector3 down;
        private bool pressed;

        new public static string FreindlyName
        {
            get
            {
                return "Pedal button";
            }
        }

        public PedalButtonRecognizer()
        {
            OutputOneFriendlyName = PEDAL_OUTPUT_ONE_FRIENDLY_NAME;
            OutputTwoFriendlyName = PEDAL_OUTPUT_TWO_FRIENDLY_NAME;
            pressed = false;
        }

        public void SaveUp()
        {
            up = lpData;
        }

        public void SaveDown()
        {
            down = lpData;
        }

        public override void Update(MotionData data)
        {
            base.Update(data);

            if (up != null && down != null)
            {
                float total = 1.0f - Vector3.Dot(up, down);
                float fromUp = (1.0f - Vector3.Dot(up, lpData)) / total;
                float fromDown = (1.0f - Vector3.Dot(down, lpData)) / total;

                float position = MathHelper.Clamp((fromUp + (1.0f - fromDown)) / 2.0f, 0.0f, 1.0f);
                if (!pressed && position > PRESSED_THRESHOLD)
                {
                    pressed = true;

                    if (IsOutputEnabled && OutputOne != null)
                    {
                        OutputOne.Trigger();
                    }
                    
                    if (PedalButtonPressed != null)
                    {
                        PedalButtonPressed(this);
                    }
                }
                else if (pressed && position <= PRESSED_THRESHOLD)
                {                  
                    pressed = false;

                    if (IsOutputEnabled && OutputTwo != null)
                    {
                        OutputTwo.Trigger();
                    }

                    if (PedalButtonReleased != null)
                    {
                        PedalButtonReleased(this);
                    }
                }
            }
        }
    }
}
