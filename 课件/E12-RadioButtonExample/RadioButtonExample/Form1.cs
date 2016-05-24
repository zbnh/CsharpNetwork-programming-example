using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadioButtonExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelMessage.Text = GetText();
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            labelMessage.Text = GetText();
        }
        private string GetText()
        {
            string s = "选项为：";
            s += GetSelectedItem(groupBox1);
            s += GetSelectedItem(groupBox2);
            return s.TrimEnd('，');
        }
        private string GetSelectedItem(GroupBox groupbox)
        {
            string s = "";
            foreach (Control c in groupbox.Controls)
            {
                //判断是否为RadioButton控件
                if (c.GetType() == typeof(RadioButton))
                {
                    RadioButton r = c as RadioButton;
                    if(r.Checked) s += r.Text + "，";
                }
            }
            return s;
        }
    }
}
