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
    public class RotaryEncoderRecognizer : DualEventRecognizer
    {
        private const string ROTARY_ENCODER_OUTPUT_ONE_FRIENDLY_NAME = "On rotate clockwise";
        private const string ROTARY_ENCODER_OUTPUT_TWO_FRIENDLY_NAME = "On rotate anti-clockwise";
        private const int DEFAULT_INCREMENTS = 10;

        public delegate void RotaryEncoderClockwiseHandler(object sender);
        public event RotaryEncoderClockwiseHandler RotaryEncoderClockwise;

        public delegate void RotaryEncoderAntiClockwiseHandler(object sender);
        public event RotaryEncoderAntiClockwiseHandler RotaryEncoderAntiClockwise;

        new public static string FreindlyName
        {
            get
            {
                return "Rotary encoder";
            }
        }

        public int Increments { get; set; }

        private Vector3 start;
        private Vector3 quarter;
        private Vector3 end;
        private int last;

        public RotaryEncoderRecognizer(int increments = DEFAULT_INCREMENTS)
        {
            this.Increments = increments;

            OutputOneFriendlyName = ROTARY_ENCODER_OUTPUT_ONE_FRIENDLY_NAME;
            OutputTwoFriendlyName = ROTARY_ENCODER_OUTPUT_TWO_FRIENDLY_NAME;
        }

        public void SaveStart()
        {
            start = lpData;
        }

        public void SaveQuarter()
        {
            quarter = lpData;
        }

        public void SaveEnd()
        {
            end = lpData;
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

                float value = 0.0f;
                if (sign <= 0.0f)
                {
                    value = v / 2.0f;
                }
                else
                {
                    value = 1.0f - (v / 2.0f);
                }

                float incrementF = 1.0f / (float)Increments;
                int position = (int)(value / incrementF);
                int diff = Math.Abs(position - last);

                if (diff != 0)
                {
                    if ((position > last && diff == 1) || (position < last && diff > 1))
                    {
                        if (RotaryEncoderAntiClockwise != null)
                        {
                            RotaryEncoderAntiClockwise(this);
                        }

                        if (IsOutputEnabled && OutputTwo != null)
                        {
                            OutputTwo.Trigger();
                        }
                    }
                    else if((position < last && diff == 1) || (position > last && diff > 1))
                    {
                        if (RotaryEncoderClockwise != null)
                        {
                            RotaryEncoderClockwise(this);
                        }

                        if (IsOutputEnabled && OutputOne != null)
                        {
                            OutputOne.Trigger();
                        }
                    }

                    last = position;
                }
            }
        }
    }
}
