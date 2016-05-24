using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DialogExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogForm dialogForm = new DialogForm();
            if (dialogForm.ShowDialog() == DialogResult.OK)
            {
                labelUserName.Text = dialogForm.UserName;
                labelUserAge.Text = dialogForm.UserAge.ToString();
            }
            dialogForm.Dispose();
        }
    }
}
