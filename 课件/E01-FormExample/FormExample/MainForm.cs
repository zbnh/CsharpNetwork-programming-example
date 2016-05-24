using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormExample
{
    public partial class MainForm : Form
    {
        SubForm subform=new SubForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (subform.Visible == false)
            {
                subform.Show();
            }
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            if (subform.Visible)
            {
                subform.Hide();
            }
        }
    }
}
