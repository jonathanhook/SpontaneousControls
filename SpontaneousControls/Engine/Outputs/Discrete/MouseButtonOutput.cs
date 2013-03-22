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
    public class MouseButtonOutput : DiscreteOutput
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }

        public enum MouseButton { Left, Right }
        public enum MouseEventType { Press, Release, Click, DoubleClick }

        public MouseButton Button { get; set; }
        public MouseEventType EventType { get; set; }

        new public static string FreindlyName
        {
            get
            {
                return "Mouse button";
            }
        }

        public MouseButtonOutput(MouseButton button = MouseButton.Left, MouseEventType eventType = MouseEventType.Click)
        {
            this.Button = button;
            this.EventType = eventType;
        }

        public override void Trigger()
        {
            switch (EventType)
            {
                case MouseEventType.Press:
                    Press();
                    break;
                case MouseEventType.Release:
                    Release();
                    break;
                case MouseEventType.Click:
                    Click();
                    break;
                case MouseEventType.DoubleClick:
                    DoubleClick();
                    break;
            }
        }

        private void Press()
        {
            int e = (int)(Button == MouseButton.Left ? MouseEventFlags.LEFTDOWN : MouseEventFlags.RIGHTDOWN);
            mouse_event(e, 0, 0, 0, 0);
        }

        private void Release()
        {
            int e = (int)(Button == MouseButton.Left ? MouseEventFlags.LEFTUP : MouseEventFlags.RIGHTUP);
            mouse_event(e, 0, 0, 0, 0);
        }

        private void Click()
        {
            Press();
            Release();
        }

        private void DoubleClick()
        {
            Click();
            Click();
        }
    }
}
