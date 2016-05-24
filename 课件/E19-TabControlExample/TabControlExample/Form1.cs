using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TabControlExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //禁用groupBox2
            groupBox2.Enabled = false;
            //注册tabControl1中所有RadioButton按钮的CheckedChanged事件
            foreach(Control c in tabControl1.Controls)
            {
                TabPage tabpage = c as TabPage;
                if (c != null)
                {
                    foreach (Control c1 in tabpage.Controls)
                    {
                        if (c1.GetType() == typeof(RadioButton))
                        {
                            RadioButton r = c1 as RadioButton;
                            r.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
                        }
                    }
                }
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            switch (r.Text.Replace(" ", ""))
            {
                case "红色":
                    label1.ForeColor = Color.Red;
                    break;
                case "绿色":
                    label1.ForeColor = Color.Green;
                    break;
                case "蓝色":
                    label1.ForeColor = Color.Blue;
                    break;
                case "较小":
                    label1.Font = new Font(label1.Font.FontFamily, 9);
                    break;
                case "适中":
                    label1.Font = new Font(label1.Font.FontFamily, 12);
                    break;
                case "较大":
                    label1.Font = new Font(label1.Font.FontFamily, 15);
                    break;
                case "隶书":
                    label1.Font = new Font("隶书", label1.Font.Size);
                    break;
                case "楷体":
                    label1.Font = new Font("楷体", label1.Font.Size);
                    break;
                case "黑体":
                    label1.Font = new Font("黑体", label1.Font.Size);
                    break;
            }
        }
    }
}
