using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormPositionExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCustomPosition_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            int.TryParse(textBox1.Text, out x);
            int.TryParse(textBox2.Text, out y);
            Form2 fm = new Form2(x,y);
            fm.ShowDialog();
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.ShowDialog();
        }

        private void buttonCustomShape_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2(true);
            fm.ShowDialog();
        }
    }
}
