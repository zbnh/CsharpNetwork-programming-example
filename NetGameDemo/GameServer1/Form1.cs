using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

namespace GameServer
{
    public partial class Form1 : Form
    {
        TcpListener tcplistener;
        TcpClient tcpclient;
        StreamReader streamreader;
        StreamWriter streamwriter;

        delegate void servTipsDelegate(ListBox listbox,string str) ;
        servTipsDelegate servTipsdelegate;

        public Form1()
        {
            InitializeComponent();
            servTips.Items.Add("[Tips]:本机IP地址");
            int i = 1;
            foreach (IPAddress ipaddr in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                servTips.Items.Add(ipaddr.ToString());
                i++;
            }

        }

        private void servStart_Click(object sender, EventArgs e)
        {
            try
            {
                string IPAddr = servTips.SelectedItem.ToString();
                tcplistener = new TcpListener(IPAddress.Parse(IPAddr), 8888);
                tcplistener.Start();
                servTips.Items.Add("服务已启动!");
                Thread newClientThread = new Thread(newClientThreadMethod);
                newClientThread.Start();
            }
            catch
            {
                MessageBox.Show("选择一个IP地址!", "Error", MessageBoxButtons.OK);
            }

        }

        public void newClientThreadMethod()
        {
            tcpclient = tcplistener.AcceptTcpClient();
            streamreader = new StreamReader(tcpclient.GetStream(), Encoding.UTF8);
            streamwriter = new StreamWriter(tcpclient.GetStream(), Encoding.UTF8);
            string recvStr = streamreader.ReadLine();
            servTipsdelegate = new servTipsDelegate(setServTips);
        }
        public void setServTips(ListBox listbox,string str)
        {
            if (servTips.InvokeRequired)
            {
                this.Invoke(servTipsdelegate, listbox, str);
            }
            else
            {
                listbox.Items.Add(str);
            }
        }
    }
}
