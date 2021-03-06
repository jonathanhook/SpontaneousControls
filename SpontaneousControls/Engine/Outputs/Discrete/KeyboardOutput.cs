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
using System.Windows.Forms;

namespace SpontaneousControls.Engine.Outputs.Discrete
{
    public class KeyboardOutput : DiscreteOutput
    {
        public enum KeyEventType { Press, Release, Tap }

        public KeyEventType EventType { get; set; }
        public Keys Key { get; set; }

        new public static string FreindlyName
        {
            get
            {
                return "Keyboard";
            }
        }

        public KeyboardOutput(Keys key = Keys.A, KeyEventType eventType = KeyEventType.Tap)
        {
            this.Key = key;
            this.EventType = eventType;
        }

        public override void Trigger()
        {
            switch (EventType)
            {
                case KeyEventType.Press:
                    Press();
                    break;
                case KeyEventType.Release:
                    Release();
                    break;
                case KeyEventType.Tap:
                    Tap();
                    break;
            }
        }

        public void Press()
        {
            Keyboard.GetInstance().Press(Key);
        }

        public void Release()
        {
            Keyboard.GetInstance().Release(Key);
        }

        public void Tap()
        {
            Keyboard.GetInstance().Tap(Key);
        }
    }
}
