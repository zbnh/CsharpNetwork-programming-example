using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(iep);
            serverSocket.Listen(10);
            Socket clientSocket = serverSocket.Accept();
            Console.WriteLine("Server is started...");
            
            while (true)
            {
                
                
                byte[] bytes = new byte[1024];
                int bytesCount = clientSocket.Receive(bytes, bytes.Length, SocketFlags.None);
                string receiveStr = Encoding.UTF8.GetString(bytes, 0, bytesCount);
                string tips = "";
                try
                {
                    if (receiveStr.Equals("exit"))
                    {
                        tips = "bye";
                        clientSocket.Close();
                        serverSocket.Close();
                        break;
                    }
                    if (isPrimeNumber(Convert.ToInt32(receiveStr)))
                    {
                        tips = receiveStr + " 是质数";
                    }
                    else
                    {
                        tips = receiveStr + " 不是质数";
                    }
                    
                }
                catch
                {

                }
                byte[] returnStrs = Encoding.UTF8.GetBytes(tips);
                clientSocket.Send(returnStrs, returnStrs.Length, SocketFlags.None);
                Console.WriteLine("receive from client:" + receiveStr);
                Console.WriteLine(tips);
                
            }

        }
        public static bool isPrimeNumber(int num)
        {
            for (int i = num - 1; i > 1; i--)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
