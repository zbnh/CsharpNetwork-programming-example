using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDIExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2 fm2 = new Form2();
            fm2.MdiParent = this;
            fm2.Show();
        }
    }
}
