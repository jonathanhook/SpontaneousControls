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
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpontaneousControls.Engine.Recognizers
{
    public class DialRecognizer : ContinuousValueRecognizer
    {
        private const string SLIDER_OUTPUT_FRIENDLY_NAME = "On value changed";

        public delegate void ValueChangedHandler(object sender, float value);
        public event ValueChangedHandler ValueChanged;

        private Vector3 start;
        private Vector3 end;
        private Vector3 quarter;

        new public static string FreindlyName
        {
            get
            {
                return "Dial";
            }
        }

        public DialRecognizer()
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

        public void SaveQuarter()
        {
            quarter = lpData;
        }

        public override void Update(MotionData data)
        {
            base.Update(data);

            if (start != null && 
                start.Length() != 0.0f &&
                quarter != null &&
                quarter.Length() != 0.0f &&
                end != null &&
                end.Length() != 0.0f)
            {
                Vector3 lpDataN, startN, quarterN, endN;
                Vector3.Normalize(ref lpData, out lpDataN);
                Vector3.Normalize(ref start, out startN);
                Vector3.Normalize(ref quarter, out quarterN);
                Vector3.Normalize(ref end, out endN);

                float total = Vector3.Dot(startN, endN);
                float fromStart = Vector3.Dot(lpDataN, startN);
                float fromEnd = Vector3.Dot(lpDataN, endN);

                float aTotal = (float)Math.Acos((double)total);
                float aFromStart = (float)Math.Acos((double)fromStart) / aTotal;
                float aFromEnd = (float)Math.Acos((double)fromEnd) / aTotal;

                float v = MathHelper.Clamp((aFromStart + (1.0f - aFromEnd)) / 2.0f, 0.0f, 1.0f);
                
                Vector3 vn = Vector3.Cross(start, quarter);
                Vector3 v3 = Vector3.Cross(vn, lpData);
                float sign = Vector3.Dot(v3, start);

                if (sign <= 0.0f)
                {
                    Value = v / 2.0f;
                }
                else
                {
                    Value = 1.0f - (v / 2.0f);
                }

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
