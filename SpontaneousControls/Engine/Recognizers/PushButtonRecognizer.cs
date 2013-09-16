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

namespace SpontaneousControls.Engine.Recognizers
{
    public class PushButtonRecognizer : DualEventRecognizer
    {
        private const float DEFAULT_SENISIVITY = 0.3f;
        private const int REPEAT_TIME = 500;
        private const string PEDAL_OUTPUT_ONE_FRIENDLY_NAME = "On pressed";
        private const string PEDAL_OUTPUT_TWO_FRIENDLY_NAME = "On released";
        private const double RECORDING_TIME = 2000.0;

        public delegate void PushButtonPressedHandler(object sender);
        public event PushButtonPressedHandler PushButtonPressed;

        public delegate void PushButtonReleasedHandler(object sender);
        public event PushButtonReleasedHandler PushButtonReleased;

        public float Sensitivity { get; set; }

        private enum State { NONE, DOWN, UP };
        private State state;
        private DateTime lastState;

        private bool pressed;
        private bool recording;
        private DateTime recordingStarted;
        private SlidingWindow window;
        private Vector3 direction;
        private bool trained;

        new public static string FreindlyName
        {
            get
            {
                return "Push button";
            }
        }

        public PushButtonRecognizer(float sensitivity = DEFAULT_SENISIVITY)
        {
            this.Sensitivity = sensitivity;

            OutputOneFriendlyName = PEDAL_OUTPUT_ONE_FRIENDLY_NAME;
            OutputTwoFriendlyName = PEDAL_OUTPUT_TWO_FRIENDLY_NAME;
            
            pressed = false;
            recording = false;
            trained = false;
            window = new SlidingWindow(1000);
            state = State.NONE;
            lastState = DateTime.UtcNow;
        }

        public void SavePress()
        {
            window.Reset();
            recordingStarted = DateTime.UtcNow;
            recording = true;
        }

        public void SaveRelease()
        {

        }

        public override void Update(MotionData data)
        {
            base.Update(data);

            if (recording)
            {
                TimeSpan elapsed = DateTime.UtcNow - recordingStarted;
                if (elapsed > TimeSpan.FromMilliseconds(RECORDING_TIME))
                {
                    recording = false;

                    Vector3 maximaIndices = new Vector3();
                    Vector3 maxima = window.GetMaxima(out maximaIndices);

                    Vector3 minimaIndices = new Vector3();
                    Vector3 minima = window.GetMinima(out minimaIndices);

                    Vector3 spike = new Vector3();
                    if (maximaIndices.X < minimaIndices.X)
                    {
                        spike.X = maxima.X;
                    }
                    else
                    {
                        spike.X = minima.X;
                    }

                    if (maximaIndices.Y < minimaIndices.Y)
                    {
                        spike.Y = maxima.Y;
                    }
                    else
                    {
                        spike.Y = minima.Y;
                    }

                    if (maximaIndices.Z < minimaIndices.Z)
                    {
                        spike.Z = maxima.Z;
                    }
                    else
                    {
                        spike.Z = minima.Z;
                    }

                    window.Reset();
                    spike.Normalize();

                    direction = spike;
                    trained = true;

                    Console.WriteLine("Trained: " + spike);
                }
                else
                {
                    window.Update(hpData);
                }
            }
            else if (direction != null)
            {
                float top = Vector3.Dot(hpData, direction);
                top = top / direction.Length();

#if PRESS_AND_RELEASE

                if (top > 0.2)
                {
                    if (state == State.UP)
                    {
                        if (PushButtonReleased != null)
                        {
                            PushButtonReleased(this);
                        }

                        if (IsOutputEnabled && OutputTwo != null)
                        {
                            OutputTwo.Trigger();
                        }

                        Console.WriteLine("Released");
                    }

                    state = State.DOWN;
                    lastState = DateTime.UtcNow;
                }
                else if (top < -0.2)
                {
                    if (state == State.DOWN)
                    {
                        if (PushButtonPressed != null)
                        {
                            PushButtonPressed(this);
                        }

                        if (IsOutputEnabled && OutputOne != null)
                        {
                            OutputOne.Trigger();
                        }

                        Console.WriteLine("Pressed");
                    }

                    state = State.UP;
                    lastState = DateTime.UtcNow;
                }
                else
                {
                    TimeSpan elapsed = DateTime.UtcNow - lastState;
                    if (elapsed > TimeSpan.FromMilliseconds(100))
                    {
                        state = State.NONE;
                    }
                }

                /*
                float x = hpData.X * direction.X;
                float y = hpData.Y * direction.Y;
                float z = hpData.Z * direction.Z;

                Vector3 result = new Vector3(x, y, z);
                float magnitude = result.Length();
                */
#else
                if (top > Sensitivity)
                {
                    DateTime now = DateTime.UtcNow;
                    TimeSpan elapsed = now - lastState;
                    if (elapsed > TimeSpan.FromMilliseconds(REPEAT_TIME))
                    {
                        Console.WriteLine("Bang");
                        lastState = now;
                    }

                    if (PushButtonPressed != null)
                    {
                        PushButtonPressed(this);
                    }

                    if (IsOutputEnabled && OutputOne != null)
                    {
                        OutputOne.Trigger();
                    }
                }
#endif
            }
        }
    }
}
