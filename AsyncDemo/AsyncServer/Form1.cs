using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;




namespace AsyncServer
{
    public partial class Form1 : Form
    {
        TcpListener tcplistener;
        TcpClient tcpclient;



        public Form1()
        {
            InitializeComponent();
            listTips.Items.Add("本机IP地址:");
            foreach (IPAddress ipaddr in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                listTips.Items.Add(ipaddr.ToString());
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                tcplistener = new TcpListener(new IPEndPoint(IPAddress.Parse(listTips.SelectedItem.ToString()), 8888));
            }
            catch
            {
                tcplistener = null;
                MessageBox.Show("Error IP address!","Error",MessageBoxButtons.OK);
            }
            if (tcplistener != null)
            {

            }
        }
    }
}
