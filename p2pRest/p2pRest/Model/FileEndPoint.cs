using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace p2pRest.Model
{
    public class FileEndPoint
    {

        public string Ipaddress { get; set; }
        public int Port { get; set; }
    }
}
