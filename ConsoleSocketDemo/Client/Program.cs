using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connecting...");
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(iep);
            Console.WriteLine("Connected.");
            string str = "";
            while (true)
            {
                if (str.Equals("exit"))
                {
                    client.Close();
                    break;
                }
                Console.WriteLine("Please enter a number");
                str = Console.ReadLine();
                byte[] bytes = Encoding.UTF8.GetBytes(str);
                client.Send(bytes, bytes.Length, SocketFlags.None);
                byte[] receivedBytes = new byte[1024];
                int bytesCount = client.Receive(receivedBytes, receivedBytes.Length, SocketFlags.None);
                string receivedStrs = Encoding.UTF8.GetString(receivedBytes, 0, bytesCount);
                Console.WriteLine(receivedStrs);
                Console.WriteLine("please enter 'exit' to quit");   
            }


        }
    }
}

