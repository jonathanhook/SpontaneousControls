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

namespace SpontaneousControls.Engine
{
    public class SlidingWindow
    {
        public int Size { get; private set; }
        public int SamplesRecorded { get; private set; }
        public Queue<Vector3> Window { get; private set; }

        public SlidingWindow(int size)
        {
            this.Size = size;

            SamplesRecorded = 0;
            Window = new Queue<Vector3>(size);
        }

        public void Update(Vector3 sample)
        {
            Window.Enqueue(sample);
            SamplesRecorded++;

            if (Window.Count > Size)
            {
                Window.Dequeue();
                SamplesRecorded--;
            }
        }

        public Vector3 GetMaxima(out Vector3 indices)
        {
            float mx = -999.0f;
            float my = -999.0f;
            float mz = -999.0f;
            indices = new Vector3();

            for (int i = 0; i < SamplesRecorded; i++)
            {
                Vector3 v = Window.ElementAt(i);

                if (v.X > mx)
                {
                    mx = v.X;
                    indices.X = i;
                }
                if (v.Y > my)
                {
                    my = v.Y;
                    indices.Y = i;
                }
                if (v.Z > mz)
                {
                    mz = v.Z;
                    indices.Z = i;
                }
            }

            return new Vector3(mx, my, mz);
        }

        public Vector3 GetMinima(out Vector3 indices)
        {
            float mx = 999.0f;
            float my = 999.0f;
            float mz = 999.0f;
            indices = new Vector3();

            for (int i = 0; i < SamplesRecorded; i++)
            {
                Vector3 v = Window.ElementAt(i);

                if (v.X < mx)
                {
                    mx = v.X;
                    indices.X = i;
                }
                if (v.Y < my)
                {
                    my = v.Y;
                    indices.Y = i;
                }
                if (v.Z < mz)
                {
                    mz = v.Z;
                    indices.Z = i;
                }
            }

            return new Vector3(mx, my, mz);
        }

        public void Reset()
        {
            SamplesRecorded = 0;
            Window.Clear();
        }

        public void Print()
        {
            for (int i = 0; i < SamplesRecorded; i++)
            {
                Vector3 v = Window.ElementAt(i);
                Console.WriteLine(v.X + ", " + v.Y + ", " + v.Z);
            }
        }
    }
}
