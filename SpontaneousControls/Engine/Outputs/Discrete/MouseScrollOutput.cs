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
using System.Runtime.InteropServices;
using System.Text;

namespace SpontaneousControls.Engine.Outputs.Discrete
{
    public class MouseScrollOutput : DiscreteOutput
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public const int MOUSEEVENTF_WHEEL = 0x0800;

        public enum ScrollEventType { Up, Down }

        public ScrollEventType EventType { get; set; }

        new public static string FreindlyName
        {
            get
            {
                return "Mouse scroll wheel";
            }
        }

        public override void Trigger()
        {
            switch (EventType)
            {
                case ScrollEventType.Up:
                    Up();
                    break;
                case ScrollEventType.Down:
                    Down();
                    break;
            }
        }

        private void Up()
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, 120, 0);
        }

        private void Down()
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -120, 0);
        }
    }
}
