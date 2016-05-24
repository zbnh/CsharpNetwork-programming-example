using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace NetInformationDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            string hostAddresses = "";
            foreach (IPAddress item in Dns.GetHostAddresses(""))
            {
                hostAddresses += item.ToString() + "\n";
            }
            richTextBox1.Text = "本地主机名:" + Dns.GetHostName() + "\n本机IP:\n" + hostAddresses + "\n本机IPv4回环地址:\n" + IPAddress.Loopback;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            string remoteAddresses = "";
            foreach (IPAddress item in Dns.GetHostAddresses(textBox1.Text))
            {
                remoteAddresses += item.ToString() + "\n";
            }
            try
            {
                IPHostEntry remoteHost = Dns.GetHostEntry(textBox1.Text);
                richTextBox2.Text = "远程主机名: " + remoteHost.HostName + "\n远程IP地址: " + remoteAddresses;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                richTextBox2.Text =  "\n远程IP地址: " + remoteAddresses;
            }


        }
    }
}
