﻿/**
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

namespace SpontaneousControls.Engine
{
    public class SlidingWindow
    {
        public int Size { get; private set; }
        public Queue<Vector3> Window { get; private set; }

        public SlidingWindow(int size)
        {
            this.Size = size;
            Window = new Queue<Vector3>(size);
        }

        public void Update(Vector3 sample)
        {
            Window.Enqueue(sample);

            if (Window.Count > Size)
            {
                Window.Dequeue();
            }
        }

        public Vector3 GetMaxima()
        {
            float mx = -999.0f;
            float my = -999.0f;
            float mz = -999.0f;

            foreach (Vector3 v in Window)
            {
                if (v.X > mx)
                {
                    mx = v.X;
                }
                if (v.Y > my)
                {
                    my = v.Y;
                }
                if (v.Z > mz)
                {
                    mz = v.Z;
                }
            }

            return new Vector3(mx, my, mz);
        }

        public Vector3 GetMinima()
        {
            float mx = 999.0f;
            float my = 999.0f;
            float mz = 999.0f;

            foreach (Vector3 v in Window)
            {
                if (v.X < mx)
                {
                    mx = v.X;
                }
                if (v.Y < my)
                {
                    my = v.Y;
                }
                if (v.Z < mz)
                {
                    mz = v.Z;
                }
            }

            return new Vector3(mx, my, mz);
        }

        

    }
}
