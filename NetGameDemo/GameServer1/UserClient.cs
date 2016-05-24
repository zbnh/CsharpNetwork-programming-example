using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace GameServer
{
    class UserClient
    {
        public string userName { get; set; }
        BinaryReader binaryreader;
        BinaryWriter binarywriter;
        

        private UserClient(TcpClient client)
        {
            
            binaryreader = new BinaryReader(client.GetStream());
            binarywriter = new BinaryWriter(client.GetStream());
        }
    }
}
