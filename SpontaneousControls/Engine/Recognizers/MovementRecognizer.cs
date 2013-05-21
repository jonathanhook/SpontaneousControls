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
    public class MovementRecognizer : EventRecognizer
    {
        private const float DEFAULT_SENISIVITY = 0.3f;
        private const float DEFAULT_REPEAT = 0.5f;
        private const float MAX_REPEAT = 2000.0f;
        private const string MOVEMENT_OUTPUT_FRIENDLY_NAME = "On movement";

        public delegate void MovementOccurredHander(object sender);
        public event MovementOccurredHander MovementOccurred;

        public float Sensitivity { get; set; }
        public float Repeat { get; set; }

        private DateTime lastMovement;

        new public static string FreindlyName
        {
            get
            {
                return "Movement";
            }
        }

        private SlidingWindow window;

        public MovementRecognizer(float sensitivity = DEFAULT_SENISIVITY, float repeat = DEFAULT_REPEAT)
        {
            this.Sensitivity = sensitivity;
            this.Repeat = repeat;
            
            OutputFriendlyName = MOVEMENT_OUTPUT_FRIENDLY_NAME;
            window = new SlidingWindow(50);
            lastMovement = DateTime.UtcNow;
        }

        public override void Update(MotionData data)
        {
            base.Update(data);

            if (DateTime.UtcNow - lastMovement > TimeSpan.FromMilliseconds(MAX_REPEAT * Repeat))
            {
                float dx = Math.Abs(hpData.X);
                float dy = Math.Abs(hpData.Y);
                float dz = Math.Abs(hpData.Z);

                if (dx > Sensitivity || dy > Sensitivity || dz > Sensitivity)
                {
                    lastMovement = DateTime.UtcNow;

                    if (IsOutputEnabled && Output != null)
                    {
                        Output.Trigger();
                    }

                    if (MovementOccurred != null)
                    {
                        MovementOccurred(this);
                    }
                }
            }
        }
    }
}
