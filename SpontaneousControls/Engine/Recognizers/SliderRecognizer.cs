/**
 * This file is part of Spontaneous Controls.
 *
 * Created by Jonathan Hook (jonathan.hook@ncl.ac.uk)
 * Copyright (c) 2013 Jonathan Hook. All rights reserved.
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
using WaxControls;

namespace SpontaneousControls.Engine.Recognizers
{
    public class SliderRecognizer : ContinuousValueRecognizer
    {
        public delegate void ValueChangedHandler(object sender, float value);
        public event ValueChangedHandler ValueChanged;

        new public static string FreindlyName 
        {
            get
            {
                return "Slider";
            }
        }

        private MotionData start;
        private MotionData end;
        private MedianFilter xm;
        private MedianFilter ym;
        private MedianFilter zm;

        public SliderRecognizer()
        {
            xm = new MedianFilter(10);
            ym = new MedianFilter(10);
            zm = new MedianFilter(10);
        }

        public void SaveStart()
        {
            start = new MotionData(0, xm.GetValue(), ym.GetValue(), zm.GetValue());
            ps = roll;
        }

        public void SaveEnd()
        {
            end = new MotionData(0, xm.GetValue(), ym.GetValue(), zm.GetValue());
            pe = roll;
        }

        float fXg = 0.0f;
        float fYg = 0.0f;
        float fZg = 0.0f;
        float alpha = 0.9f;
        float roll = 0.0f;
        float pitch = 0.0f;
        float ps = 0.0f;
        float pe = 0.0f;

        public override void Update(MotionData data)
        {
            fXg = data.X * alpha + (fXg * (1.0f - alpha));
            fYg = data.Y * alpha + (fYg * (1.0f - alpha));
            fZg = data.Z * alpha + (fZg * (1.0f - alpha));

            /*roll = ((float)Math.Atan2(-fYg, fZg) * 180.0f) / (float)Math.PI;
            pitch = ((float)Math.Atan2(fXg, (float)Math.Sqrt(fYg * fYg + fZg * fZg)) * 180.0f) / (float)Math.PI;
            */

            double roll = (Math.Atan2(-fYg, fZg) * 180.0) / Math.PI;
            double pitch = (Math.Atan2(fXg, Math.Sqrt(fYg * fYg + fZg * fZg)) * 180.0) / Math.PI;

            Console.WriteLine(fXg + " " + fYg + " " + fZg);

            /*
            xm.Update(data.X);
            ym.Update(data.Y);
            zm.Update(data.Z);
            
            if (start != null && end != null)
            {
                float x = xm.GetValue();
                float y = ym.GetValue();
                float z = zm.GetValue();

                float dx = Math.Abs(start.X - end.X);
                float dy = Math.Abs(start.Y - end.Y);
                float dz = Math.Abs(start.Z - end.Z);

                float val = 0.0f;
                if (dx > dy && dx > dz)
                {
                    val = (x - start.X) / (end.X - start.X);
                }
                else if (dy > dx && dy > dz)
                {
                    val = (y - start.Y) / (end.Y - start.Y);
                }
                else if (dz > dx && dz > dy)
                {
                    val = (z - start.Z) / (end.Z - start.Z);
                }

                if (val > 1.0f)
                {
                    val = 1.0f;
                }
                else if (val < 0.0f)
                {
                    val = 0.0f;
                }
             

                Value = val;
                if (ValueChanged != null)
                {
                    ValueChanged(this, Value);
                }
            }*/
        }
    }
}
