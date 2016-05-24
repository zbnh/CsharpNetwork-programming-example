using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
namespace TcpServer
{
    class User
    {
        public TcpClient client { get; set; }
        public String userName { get; set; }
        public  BinaryReader br{get;private set;}
        public BinaryWriter bw { get; private set; }

        public User(TcpClient client)
        {
            this.client = client;
            br = new BinaryReader(client.GetStream());
            bw = new BinaryWriter(client.GetStream());
        }
    }
}
