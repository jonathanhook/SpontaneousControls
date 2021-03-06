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
using System.Diagnostics;
using Bespoke.Common.Osc;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Microsoft.Xna.Framework;

namespace SpontaneousControls.Engine
{
    class WaxReceiver
    {
        private const uint MIN_OSC_PORT = 4000;
        private const uint MAX_OSC_PORT = 5000;

        public delegate void DataReceivedHandler(object sender, MotionData data); 
        public event DataReceivedHandler DataReceived;

        public bool Connected { get; private set; }

        private string comPort;
        private OscServer osc;
        private Process waxRec;

        public WaxReceiver()
        {
            Connected = false;
        }

        public void Connect()
        {
            if (!Connected)
            {
                comPort = null;

                Process findCom = new Process();
                findCom.StartInfo.FileName = Properties.Settings.Default.FindComPath;
                findCom.StartInfo.CreateNoWindow = true;
                findCom.StartInfo.RedirectStandardOutput = true;
                findCom.StartInfo.UseShellExecute = false;
                findCom.OutputDataReceived += new DataReceivedEventHandler(findCom_OutputDataReceived);
                findCom.Start();
                findCom.BeginOutputReadLine();
                findCom.WaitForExit();

                uint oscPort = MIN_OSC_PORT;
                bool oscConnected = false;
                while (!oscConnected && oscPort < MAX_OSC_PORT)
                {
                    osc = new OscServer(TransportType.Udp, IPAddress.Loopback, (int)oscPort);
                    osc.FilterRegisteredMethods = false;
                    osc.MessageReceived += new EventHandler<OscMessageReceivedEventArgs>(osc_MessageReceived);
                    osc.ReceiveErrored += new EventHandler<Bespoke.Common.ExceptionEventArgs>(osc_ReceiveErrored);
                    osc.BundleReceived += new EventHandler<OscBundleReceivedEventArgs>(osc_BundleReceived);

                    try
                    {
                        osc.Start();
                        oscConnected = true;
                    }
                    catch (Exception e)
                    {
                        oscPort++;
                    }
                }

                if (!oscConnected)
                {
                    throw new Exception("Could not connect to any UDP port in the specified range");
                }
                else if(comPort != null)
                {
                    waxRec = new Process();
                    waxRec.StartInfo.FileName = Properties.Settings.Default.WaxRecPath;
                    waxRec.StartInfo.Arguments = string.Format("\\\\.\\{0} -osc localhost:{1} -init \"MODE=1\\r\\n", comPort, oscPort);
                    waxRec.StartInfo.CreateNoWindow = true;
                    waxRec.StartInfo.UseShellExecute = false;
                    waxRec.Start();

                    if (!waxRec.HasExited)
                    {
                        Connected = true;
                    }
                }
            }
        }

        public void Disconnect()
        {
            if (Connected)
            {
                if (waxRec != null && !waxRec.HasExited)
                {
                    waxRec.Kill();
                }

                if (osc != null && osc.IsRunning)
                {
                    osc.Stop();
                }

                Connected = false;
            }
        }

        private void findCom_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            string data = e.Data;
            if (data != null && data.Contains("COM"))
            {
                comPort = data.Split(new string[1] { @"\\.\" }, StringSplitOptions.RemoveEmptyEntries)[0];
            }


            comPort = Properties.Settings.Default.HardCodedCOM;
        }

        private void osc_BundleReceived(object sender, OscBundleReceivedEventArgs e)
        {
        }

        private void osc_ReceiveErrored(object sender, Bespoke.Common.ExceptionEventArgs e)
        {
        }

        private void osc_MessageReceived(object sender, OscMessageReceivedEventArgs e)
        {
            int id = int.Parse(e.Message.Address.Split(new string[1] { "/" }, StringSplitOptions.RemoveEmptyEntries)[1]);
            float x = (float)e.Message.Data[0];
            float y = (float)e.Message.Data[1];
            float z = (float)e.Message.Data[2];

            MotionData md = new MotionData(id, new Vector3(x, y, z));
            if (DataReceived != null)
            {
                DataReceived(this, md);
            }
        }
    }
}
