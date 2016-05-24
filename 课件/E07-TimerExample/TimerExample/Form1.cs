using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimerExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "动画设计：张三\n\n美  工：李四\n\n代码设计：王五";
            label1.Height = 100;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Red;
            timer1.Interval = 30;
            timer1.Enabled = true;
            timer2.Interval = 500;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(0, label1.Location.Y - 1);
            if (label1.Top <= -label1.Height)
            {
                label1.Top = panel1.ClientRectangle.Height + 10;
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
