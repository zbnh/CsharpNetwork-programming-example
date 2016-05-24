using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetScannerDemo
{
    class HostInfo
    {
        string IPAddress;
        string HostName;
        public void setIPAddress(string ipaddress)
        {
            IPAddress = ipaddress;
        }

        public void setHostName(string hostname)
        {
            HostName = hostname;
        }

        public string getIPAddress()
        {
            return IPAddress;
        }

        public string getHostName()
        {
            return HostName;
        }
    }
}
