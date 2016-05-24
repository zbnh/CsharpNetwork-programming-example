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
    public partial class DialogForm : Form
    {
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public DialogForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            UserName = textBoxName.Text;
            try
            {
                UserAge = int.Parse(textBoxAge.Text);
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("年龄不正确");
                this.DialogResult = DialogResult.None;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
