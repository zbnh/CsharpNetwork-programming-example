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
using System.IO;
using System.Threading;

namespace tcpClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpClient tcpclient;
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string ipaddress = textBox1.Text;
            int port = Int32.Parse(textBox2.Text);
            IPAddress ipaddr = IPAddress.Parse(ipaddress);
            tcpclient = new TcpClient(ipaddress, port);
            NetworkStream clientstream = tcpclient.GetStream();
            Thread thread = new Thread(waitingForMessage);
            thread.Start();
            BinaryWriter binarywriter = new BinaryWriter(clientstream, Encoding.UTF8);
            binarywriter.Write("[client say to server]:" + textBoxSendMessage.Text+"\n");
            richTextBoxReceive.AppendText("[client say to server]:" + textBoxSendMessage.Text + "\n");
            binarywriter.Flush();
        }

        public void waitingForMessage()
        {
            while (true)
            {
                NetworkStream networkstream = tcpclient.GetStream();
                BinaryReader binaryreader = new BinaryReader(networkstream, Encoding.UTF8);
                string receiveStr = binaryreader.ReadString();
                if (richTextBoxReceive.InvokeRequired)
                {
                    setrichtext setrichtext = new setrichtext(updateRichText);
                    this.Invoke(setrichtext, receiveStr);
                }
            }

        }
        private delegate void setrichtext(string str);
        public void updateRichText(string str)
        {
            richTextBoxReceive.AppendText(str);
        }
    }
}
