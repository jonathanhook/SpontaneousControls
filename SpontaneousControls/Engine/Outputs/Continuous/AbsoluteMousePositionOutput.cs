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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpontaneousControls.Engine.Outputs.Continuous
{
    public class AbsoluteMousePositionOutput : ContinuousOuput
    {
        public enum MouseAxis { X, Y };

        public MouseAxis Axis { get; set; }

        new public static string FreindlyName
        {
            get
            {
                return "Mouse position";
            }
        }

        public AbsoluteMousePositionOutput(MouseAxis axis = MouseAxis.X)
        {
            this.Axis = axis;
        }

        public override void Trigger(float value)
        {
            int cx = Cursor.Position.X;
            int cy = Cursor.Position.Y;

            if (Axis == MouseAxis.X)
            {
                int sx = Screen.PrimaryScreen.Bounds.Width;
                cx = (int)((float)sx * value);    
            }
            else
            {
                int sy = Screen.PrimaryScreen.Bounds.Height;
                cy = (int)((float)sy * value);
            }

            Cursor.Position = new Point(cx, cy);
        }
    }
}
