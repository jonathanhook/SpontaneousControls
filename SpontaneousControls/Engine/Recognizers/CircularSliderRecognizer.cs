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
using WaxControls;

namespace SpontaneousControls.Engine.Recognizers
{
    public class CircularSliderRecognizer : ContinuousValueRecognizer
    {
        private const string SLIDER_OUTPUT_FRIENDLY_NAME = "On value changed";

        public delegate void ValueChangedHandler(object sender, float value);
        public event ValueChangedHandler ValueChanged;

        private Vector3 start;
        private Vector3 end;

        new public static string FreindlyName 
        {
            get
            {
                return "Slider (circular path)";
            }
        }

        public CircularSliderRecognizer()
        {
            OutputFriendlyName = SLIDER_OUTPUT_FRIENDLY_NAME;
        }

        public void SaveStart()
        {
            start = lpData;
        }

        public void SaveEnd()
        {
            end = lpData;
        }

        public override void Update(MotionData data)
        {
            base.Update(data);

            if (start != null && end != null)
            {
                float total = 1.0f - Vector3.Dot(start, end);
                float fromStart = (1.0f - Vector3.Dot(start, lpData)) / total;
                float fromEnd = (1.0f - Vector3.Dot(end, lpData)) / total;

                Value = MathHelper.Clamp((fromStart + (1.0f - fromEnd)) / 2.0f, 0.0f, 1.0f);

                if (IsOutputEnabled && Output != null)
                {
                    Output.Trigger(Value);
                }

                if (ValueChanged != null)
                {
                    ValueChanged(this, Value);
                }
            }
        }
    }
}
