using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace NetScannerDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getLocalHostInformation();
        }

        private void getLocalHostInformation()
        {
            string strLocalName = Dns.GetHostName();
            IPAddress[] IPAddresses = Dns.GetHostAddresses(strLocalName);
            NetworkInterface[] networkinterfaceInfo = NetworkInterface.GetAllNetworkInterfaces();
            localName.Text = strLocalName;
            int i = 0;
            foreach (IPAddress item in IPAddresses)
            {
                localIP.Text += IPAddresses[i].ToString() + " \n";
                i++;
            }

            localMAC.Text = BitConverter.ToString(networkinterfaceInfo[0].GetPhysicalAddress().GetAddressBytes());
        }
        List<HostInfo> hostinfolist = new List<HostInfo>();
        private void btnStart_Click(object sender, EventArgs e)
        {

            backgroundWorker1.RunWorkerAsync();
            btnStart.Enabled = false;
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                HostInfo hostinfo = new HostInfo();
                for (long i = IpToLong(textBox1.Text); i < IpToLong(textBox2.Text); i++)
                {
                    Ping ping = new Ping();
                    PingReply pingreply = ping.Send(LongToIp(i));

                    if (pingreply.Status == IPStatus.Success)
                    {

                        IPHostEntry iphostentry = Dns.GetHostEntry(LongToIp(i));
                        hostinfo.setIPAddress(pingreply.Address.ToString());
                        hostinfo.setHostName(iphostentry.HostName);
                        hostinfolist.Add(hostinfo);
                    }
                }
            }
            catch
            {
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStart.Enabled = true;
            HostInfo[] hostinfoarr = hostinfolist.ToArray();
            //for(int j=0;j<hostinfoarr.Count<HostInfo>();j++)
            //{
            //    dataGridView1.Rows[j].Cells[0].Value = hostinfoarr[j].getIPAddress();
            //    dataGridView1.Rows[j].Cells[1].Value = hostinfoarr[j].getHostName();
            //}
            int i = 0;
            foreach (HostInfo info in hostinfoarr)
            {
                int newIndex = dataGridView1.Rows.Add();
                DataGridViewRow dgv = dataGridView1.Rows[newIndex];
                dgv.Cells[0].Value = info.getIPAddress();
                dgv.Cells[1].Value = info.getHostName();
                //DataGridViewRow datagridviewrow = new DataGridViewRow();
                //datagridviewrow.Cells[0].Value = info.getIPAddress();
                //datagridviewrow.Cells[1].Value = info.getHostName();
                //dataGridView1.Rows.Add(datagridviewrow);
                ////dataGridView1.Rows[i].Cells["Ipaddress"].Value=info.getIPAddress();
                ////dataGridView1.Rows[i].Cells["HostName"].Value = info.getHostName();
                //i++;
            }
        }

        public long IpToLong(string ip)
        {
            //IPAddress ipaddress = IPAddress.Parse(ip);
            //return ipaddress.Address;
            try
            {
                char[] separator = new char[] { '.' };
                string[] items = ip.Split(separator);
                return long.Parse(items[0]) << 24 | long.Parse(items[1]) << 16 | long.Parse(items[2]) << 8 | long.Parse(items[3]);
            }
            catch (Exception e)
            {
                e.ToString();
                MessageBox.Show("输入的IP地址格式有误");
                return 0;
            }




        }
        public string LongToIp(long ipLong)
        {
            //IPAddress ipaddress = IPAddress.Parse(ipLong.ToString());
            //return ipaddress.ToString();
            try
            {
                StringBuilder stringbuilder = new StringBuilder();
                stringbuilder.Append((ipLong >> 24) & 0xFF).Append('.');
                stringbuilder.Append((ipLong >> 16) & 0xFF).Append('.');
                stringbuilder.Append((ipLong >> 8) & 0xFF).Append('.');
                stringbuilder.Append(ipLong & 0xFF);
                return stringbuilder.ToString();
            }
            catch (Exception e)
            {
                e.ToString();
                MessageBox.Show("输入的IP地址格式有误");
                return null;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
