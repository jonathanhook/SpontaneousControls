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
        private const int PCA_SAMPLES = 100;

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

        private double[,] pcaData;
        private int count = 0;

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
            /*
            window.Reset();
            recordingStarted = DateTime.UtcNow;
            recording = true;
             */

            recording = true;
            pcaData = new double[PCA_SAMPLES, 3];
            count = 0;
        }

        public void SaveRelease()
        {

        }

        public override void Update(MotionData data)
        {
            /*************************************************************************
            Principal components analysis

            Subroutine  builds  orthogonal  basis  where  first  axis  corresponds  to
            direction with maximum variance, second axis maximizes variance in subspace
            orthogonal to first axis and so on.

            It should be noted that, unlike LDA, PCA does not use class labels.

            INPUT PARAMETERS:
            X           -   dataset, array[0..NPoints-1,0..NVars-1].
                            matrix contains ONLY INDEPENDENT VARIABLES.
            NPoints     -   dataset size, NPoints>=0
            NVars       -   number of independent variables, NVars>=1

            ÂÛÕÎÄÍÛÅ ÏÀÐÀÌÅÒÐÛ:
            Info        -   return code:
                            * -4, if SVD subroutine haven't converged
                            * -1, if wrong parameters has been passed (NPoints<0,
                                    NVars<1)
                            *  1, if task is solved
            S2          -   array[0..NVars-1]. variance values corresponding
                            to basis vectors.
            V           -   array[0..NVars-1,0..NVars-1]
                            matrix, whose columns store basis vectors.

            -- ALGLIB --
                Copyright 25.08.2008 by Bochkanov Sergey
            *************************************************************************/

            base.Update(data);

            if (recording)
            {
                pcaData[count, 0] = rawData.X;
                pcaData[count, 1] = rawData.Y;
                pcaData[count, 2] = rawData.Z;
                count++;

                if (count >= PCA_SAMPLES)
                {
                    double mx = 0;
                    double my = 0;
                    double mz = 0;
                    for (int i = 0; i < PCA_SAMPLES; i++)
                    {
                        mx += (pcaData[i, 0] / (double)PCA_SAMPLES);
                        my += (pcaData[i, 1] / (double)PCA_SAMPLES);
                        mz += (pcaData[i, 2] / (double)PCA_SAMPLES);
                    }

                    for (int i = 0; i < PCA_SAMPLES; i++)
                    {
                        pcaData[i, 0] -= mx;
                        pcaData[i, 0] -= my;
                        pcaData[i, 0] -= mz;
                    }

                    int info;
                    double[] s2;
                    double[,] v;
                    alglib.pcabuildbasis(pcaData, PCA_SAMPLES, 3, out info, out s2, out v);

                    if (info == 1)
                    {

                    }

                    recording = false;
                }
            }
            else
            {

            }


            /*
            if (recording)
            {
                Console.WriteLine(hpData.X + ", " + hpData.Y + ", " + hpData.Z);

                TimeSpan elapsed = DateTime.UtcNow - recordingStarted;
                if (elapsed > TimeSpan.FromMilliseconds(RECORDING_TIME))
                {
                    recording = false;


                    //alglib.pcabuildbasis(

                    
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
                    //window.Update(hpData);



                }
            }
            else if (direction != null)
            {
#if PRESS_AND_RELEASE
                float top = Vector3.Dot(hpData, direction);
                top = top / direction.Length();

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
                *//*
#else
                float projection = Vector3.Dot(hpData, direction);

                if (projection > Sensitivity)
                {
                    DateTime now = DateTime.UtcNow;
                    TimeSpan elapsed = now - lastState;
                    if (elapsed > TimeSpan.FromMilliseconds(REPEAT_TIME))
                    {
                        if (PushButtonPressed != null)
                        {
                            PushButtonPressed(this);
                        }

                        if (IsOutputEnabled && OutputOne != null)
                        {
                            OutputOne.Trigger();
                        }

                        lastState = now;
                    }
                }
#endif
            }*/
        }
    }
}
