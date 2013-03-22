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
using SpontaneousControls.Engine.Outputs.Discrete;

namespace SpontaneousControls.Engine.Recognizers
{
    public abstract class DualEventRecognizer : Recognizer
    {
        public DiscreteOutput OutputOne { get; set; }
        public DiscreteOutput OutputTwo { get; set; }
        public string OutputOneFriendlyName { get; protected set; }
        public string OutputTwoFriendlyName { get; protected set; }
    }
}

