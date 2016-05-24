using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            textBox2.Text = "您刚按下的是" + e.KeyCode;
            if (e.KeyCode == Keys.Up)
            {
                textBox2.Text += "，即向上箭头";
            }
            if (e.KeyCode == Keys.F1)
            {
                textBox2.Text += "，即功能键F1";
            }
            //判断是否同时按下了<Ctrl>键、<Alt>键和<Shift>键
            if (e.Modifiers == (Keys.Control | Keys.Alt | Keys.Shift))
            {
                textBox2.Text += "，即组合键Ctrl+Alt+Shift";
            }
            switch (e.KeyData)
            {
                case (Keys.Control | Keys.X):
                    textBox2.Text = "您刚按下的是组合键Ctrl+X";
                    break;
                case (Keys.Control | Keys.Y):
                    textBox2.Text = "您刚按下的是组合键Ctrl+Y";
                    break;
            }
        }

        private void buttonOK_MouseEnter(object sender, EventArgs e)
        {
            buttonOK.ForeColor = Color.Red;
        }

        private void buttonOK_MouseLeave(object sender, EventArgs e)
        {
            buttonOK.ForeColor = Color.Black;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }
    }
}
