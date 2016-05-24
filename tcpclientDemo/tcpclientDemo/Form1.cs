using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace tcpServerDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        TcpListener tcplistener;
        TcpClient tcpclientlistener;
        bool isStartListener = true;
        Thread myThread;
        private void btnStartListener_Click(object sender, EventArgs e)
        {
            if (isStartListener)
            {
                string IPaddress;
                int port;
                btnStartListener.Text = "停止监听";
                isStartListener = false;

                try
                {
                    IPaddress = textBox1.Text;
                    port = Int32.Parse(textBox2.Text);
                    IPAddress ipaddr = IPAddress.Parse(IPaddress);
                    tcplistener = new TcpListener(ipaddr, port);
                    tcplistener.Start();
                    richTextBoxReceive.AppendText(string.Format("[Server is listening at {0}:{1}]\n", IPaddress, port.ToString()));
                    myThread = new Thread(ListenClientConnect);
                    myThread.Start();
                }
                catch
                {
                    MessageBox.Show("IP地址格式不对", "Error", MessageBoxButtons.OK);
                    btnStartListener.Text = "开始监听";
                    isStartListener = true;
                    serverStop();
                }
            }
            else
            {
                btnStartListener.Text = "开始监听";
                isStartListener = true;
                serverStop();
            }
        }
        private void serverStop()
        {
            richTextBoxReceive.AppendText("[Server stoped]\n");
            //Thread.CurrentThread.Abort();
        }
        private void ListenClientConnect()
        {
            while (true)
            {
                tcpclientlistener = tcplistener.AcceptTcpClient();
                NetworkStream networkstream = tcpclientlistener.GetStream();
                BinaryReader binaryreader = new BinaryReader(networkstream, Encoding.UTF8);
                string receiveStr = binaryreader.ReadString();
                if (richTextBoxReceive.InvokeRequired)
                {
                    setrichboxtext setrichtext = new setrichboxtext(setrichTextBoxReceiveText);
                    this.Invoke(setrichtext, receiveStr);
                }
                else
                {
                    richTextBoxReceive.Text = receiveStr;
                }
            }



        }
        private delegate void setrichboxtext(string receiveStr);
        private void setrichTextBoxReceiveText(string receiveStr)
        {

            richTextBoxReceive.AppendText(receiveStr);
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            NetworkStream networkstream = tcpclientlistener.GetStream();
            BinaryWriter binarywriter = new BinaryWriter(networkstream, Encoding.UTF8);
            binarywriter.Write("[server say to client]:" + textBoxSendMessage.Text + "\n");
            binarywriter.Flush();
        }
    }
}
