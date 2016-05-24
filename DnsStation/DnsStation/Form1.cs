﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
namespace DnsStation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPHostEntry me = Dns.GetHostEntry(textBox1.Text);
            listBox1.Items.Clear();
            listBox1.Items.Add("您查询的域名是："+me.HostName);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IPHostEntry me = Dns.GetHostEntry(textBox1.Text);
            listBox1.Items.Clear();
            listBox1.Items.Add("您查询的域名对应的地址有：");
            foreach (IPAddress ip in me.AddressList)
            {
                listBox1.Items.Add(ip);
            }
        }
    }
}
