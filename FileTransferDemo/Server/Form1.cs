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

namespace Server
{
    public partial class Form1 : Form
    {
        TcpListener tcplistener;
        TcpClient tcpclient;
        NetworkStream networkftream;
        StreamReader streamreader;
        StreamWriter streamwriter;
        FileStream filestream;

        public Form1()
        {
            InitializeComponent();
            startServer();
        }

        private void startServer()
        {
            tcplistener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8888);
            tcpclient = tcplistener.AcceptTcpClient();
            statusLabel.Text = "服务器已在127.0.0.1：8888上启动";
        }

        private void receiveBtn_Click(object sender, EventArgs e)
        {
            //streamreader = new StreamReader(networkftream);
            
            networkftream = tcpclient.GetStream();
            SaveFileDialog savefileldialog = new SaveFileDialog();
            if (savefileldialog.ShowDialog() == DialogResult.OK)
            {
                filestream = new FileStream();
                
            }
        }
    }
}
