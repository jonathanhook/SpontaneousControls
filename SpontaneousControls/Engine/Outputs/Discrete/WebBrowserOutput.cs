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
    public class WebBrowserOutput : DiscreteOutput
    {
        public enum WebBrowserEventType
        {
            BrowserBack = 166,
            BrowserForward = 167,
            BrowserRefresh = 168,
            BrowserStop = 169,
            BrowserSearch = 170,
            BrowserFavorites = 171,
            BrowserHome = 172
        }

        public WebBrowserEventType EventType { get; set; }

        new public static string FreindlyName
        {
            get
            {
                return "Web browser";
            }
        }

        public WebBrowserOutput(WebBrowserEventType eventType = WebBrowserEventType.BrowserRefresh)
        {
            this.EventType = eventType;
        }

        public override void Trigger()
        {
            Keyboard.GetInstance().Tap((Keys)EventType);
        }
    }
}
