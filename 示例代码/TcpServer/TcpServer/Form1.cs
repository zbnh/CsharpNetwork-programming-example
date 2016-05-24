using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
namespace TcpServer
{
    public partial class Form1 : Form
    {
        IPAddress localAddress;
        int port = 8888;
        TcpListener listener;
        List<User> userList = new List<User>();
        bool isListenExit = false;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            localAddress = Dns.GetHostAddresses(Dns.GetHostName())[1];
            listBox1.Items.Add(localAddress.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listener = new TcpListener(localAddress, port);
            listener.Start();
            listBox1.Items.Add(String.Format("服务器已经开始在{0}:{1}监听客户连接 ", localAddress, port));
            Thread myThread = new Thread(listenClient);
            myThread.Start();
        }
        private void listenClient()
        {
            while (!isListenExit)
            {
                try
                {
                    TcpClient client = listener.AcceptTcpClient();
                    User user = new User(client);
                    userList.Add(user);
                    Thread t = new Thread(ReceiveMessage);
                    t.Start(user);
                }
                catch
                {
                    
                }
            }
        }
        private void ReceiveMessage(Object o)
        {
            User user = (User)o;
            bool isExit = false;
            while (!isExit)
            {
                String receiveString = null;
                try
                {
                    receiveString = user.br.ReadString();

                    String[] strs = receiveString.Split(',');

                    switch (strs[0])
                    {
                        case "login": user.userName = strs[1];
                            foreach (User remoteUser in userList)
                            {
                                remoteUser.bw.Write(receiveString);
                                remoteUser.bw.Flush();
                                user.bw.Write("login," + remoteUser.userName);
                                user.bw.Flush();
                            }
                            listBox1.Items.Add(receiveString);
                            break;
                        case "talk":
                            String receName = strs[2];
                            String message = receiveString.Substring(strs[0].Length + strs[1].Length + strs[2].Length + 3);
                            listBox1.Items.Add(String.Format("{0}对{1}说：{2}", strs[1], strs[2], message));

                            foreach (User remoteUse in userList)
                            {
                                if (remoteUse.userName.Equals(receName))
                                {
                                    remoteUse.bw.Write(receiveString);
                                    remoteUse.bw.Flush();
                                }
                            }//从用户列表中找到对应的接收者，并将消息转发过去
                            break;
                        case "logout":

                            foreach (User remoteUser in userList)
                            {
                                remoteUser.bw.Write(receiveString);
                                remoteUser.bw.Flush();
                            }
                            userList.Remove(user);
                            user.bw.Close();
                            user.br.Close();
                            user.client.Close();
                            isExit = true;
                            listBox1.Items.Add(receiveString);
                            break;
                        case "file":
                              String receName2 = strs[2];
                            String fileName = receiveString.Substring(strs[0].Length + strs[1].Length + strs[2].Length + 3);
                            foreach (User remoteUse in userList)
                            {
                                if (remoteUse.userName.Equals(receName2))
                                {
                                    remoteUse.bw.Write(receiveString);
                                    remoteUse.bw.Flush();
                                }
                            }
                            listBox1.Items.Add(receiveString);
                            break;
                        case "accept":
                               String sendName = strs[1];
                            String fileName3 = receiveString.Substring(strs[0].Length + strs[1].Length + strs[2].Length + 3);
                            String receip = user.client.Client.RemoteEndPoint.ToString().Split(':')[0];
                            foreach (User remoteUse in userList)
                            {
                                if (remoteUse.userName.Equals(sendName))
                                {
                                    remoteUse.bw.Write(receiveString+","+receip);
                                    remoteUse.bw.Flush();
                                }
                            }
                            listBox1.Items.Add(receiveString + "," + receip);
                            break;

                    }

                }
                catch
                {
                    listBox1.Items.Add("和客户端的网络连接出现问题");
                    break;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            listener.Stop();
            isListenExit = true;
        }
    }
}
