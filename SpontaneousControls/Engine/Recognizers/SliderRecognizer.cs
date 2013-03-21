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
using Microsoft.Xna.Framework;
using WaxControls;

namespace SpontaneousControls.Engine.Recognizers
{
    public class SliderRecognizer : ContinuousValueRecognizer
    {
        public delegate void ValueChangedHandler(object sender, float value);
        public event ValueChangedHandler ValueChanged;

        private Vector3 start;
        private Vector3 end;

        new public static string FreindlyName 
        {
            get
            {
                return "Slider";
            }
        }

        public SliderRecognizer()
        {
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

            float total = Vector3.Dot(start, end);
            float fromStart = Vector3.Dot(lpData, start);
            float fromEnd = Vector3.Dot(lpData, end);

            Console.WriteLine(total + " " + fromStart + " " + fromEnd);


            if (ValueChanged != null)
            {
                ValueChanged(this, Value);
            }
        }
    }
}
