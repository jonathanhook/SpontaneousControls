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
using System.Windows.Forms;

namespace SpontaneousControls.Engine.Outputs.Discrete
{
    public class Keyboard
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        const uint KEYEVENTF_KEYUP = 0x0002;
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        public static Keyboard Instance = null;
        public static Keyboard GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Keyboard();
            }

            return Instance;
        }

        private System.Timers.Timer timer;
        private List<Keys> held;

        private Keyboard()
        {
            held = new List<Keys>();

            timer = new System.Timers.Timer();
            timer.Elapsed += timer_Elapsed;
            timer.Enabled = false;
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            foreach (Keys k in held)
            {
                Tap(k);
            }
        }

        public void Press(Keys k)
        {
            if (!held.Contains(k))
            {
                held.Add(k);
            }

            if (held.Count > 0 && timer.Enabled == false)
            {
                timer.Start();
            }
        }

        public void Release(Keys k)
        {
            if (held.Contains(k))
            {
                held.Remove(k);
            }

            if (held.Count <= 0 && timer.Enabled == true)
            {
                timer.Stop();
            }
        }

        public void Tap(Keys k)
        {
            keybd_event((byte)k, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
            keybd_event((byte)k, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }
    }
}
