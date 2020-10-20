using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace p2pRest.Model
{
    public class FileEndPoint
    {
        private string _ipaddress;
        private int _port;

        public FileEndPoint(string ipaddress, int port)
        {
            _ipaddress = ipaddress;
            _port = port;
        }

        public string Ipaddress
        {
            get => _ipaddress;
            set => _ipaddress = value;
        }

        public int Port
        {
            get => _port;
            set => _port = value;
        }
    }
}
