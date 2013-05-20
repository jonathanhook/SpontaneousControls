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

namespace SpontaneousControls.Engine.Recognizers
{
    public class MovementRecognizer : EventRecognizer
    {
        private const float DEFAULT_SENISIVITY = 0.3f;
        private const string MOVEMENT_OUTPUT_FRIENDLY_NAME = "On movement";

        public delegate void MovementOccurredHander(object sender);
        public event MovementOccurredHander MovementOccurred;

        public float Sensitivity { get; set; }

        new public static string FreindlyName
        {
            get
            {
                return "Movement";
            }
        }

        public MovementRecognizer(float sensitivity = DEFAULT_SENISIVITY)
        {
            this.Sensitivity = sensitivity;
            
            OutputFriendlyName = MOVEMENT_OUTPUT_FRIENDLY_NAME;
        }

        public override void Update(MotionData data)
        {
            base.Update(data);
            
            if(hpData.X > Sensitivity || hpData.Y > Sensitivity || hpData.Z > Sensitivity)
            {
                Console.WriteLine("moved");
            }


        }
    }
}
