﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;

namespace HES_Monitor
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Helper.portOpen("localhost", 9998)) return;

            TcpChannel tcpChannel = new TcpChannel(9998);
            ChannelServices.RegisterChannel(tcpChannel, false);
            Type commonInterfaceType = Type.GetType("HES_Monitor.Monitor");
            RemotingConfiguration.RegisterWellKnownServiceType(commonInterfaceType, "HES-Monitor", WellKnownObjectMode.SingleCall);

            Type requiredType = typeof(IMonitor);

            IMonitor m = (IMonitor)Activator.GetObject(requiredType, "tcp://localhost:9998/HES-Monitor");

            m.start();

            //Monitor m = new Monitor();
            //m.start();
        }
    }
}
