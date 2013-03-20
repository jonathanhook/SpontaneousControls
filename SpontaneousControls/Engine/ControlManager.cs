﻿/**
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

namespace SpontaneousControls.Engine
{
    class ControlManager
    {
        private static ControlManager instance = null;
        public static ControlManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ControlManager();
            }

            return instance;
        }

        private List<Mapping> mappings;
        private WaxReceiver waxReceiver;

        private ControlManager()
        {
            waxReceiver = new WaxReceiver();
            waxReceiver.Connect();
            waxReceiver.DataReceived += new WaxReceiver.DataReceivedHandler(waxReceiver_DataReceived);

            mappings = new List<Mapping>();
        }

        public void RegisterMapping(Mapping mapping)
        {
            mappings.Add(mapping);
        }

        public void UnRegisterMapping(Mapping mapping)
        {
            mappings.Remove(mapping);
        }

        private void waxReceiver_DataReceived(object sender, MotionData data)
        {
            foreach (Mapping m in mappings)
            {
                if (m.SensorId == data.Id)
                {
                    m.Update(data);
                }
            }
        }
    }
}
