using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void checkBoxGroup_CheckedChanged(object sender, EventArgs e)
        {
            bool isCheckall = true;
            bool isUncheckAll = true;
            //检查GroupBox中的所有控件状态
            foreach (Control control in groupBox1.Controls)
            {
                CheckBox checkbox = control as CheckBox;
                if (checkbox.Checked)
                {
                    isUncheckAll = false;
                }
                else
                {
                    isCheckall = false;
                }
            }
            if (isCheckall)
            {
                checkBoxAll.CheckState = CheckState.Checked;
            }
            else if (isUncheckAll)
            {
                checkBoxAll.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkBoxAll.CheckState = CheckState.Indeterminate;
            }
        }

private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
{
    if (checkBoxAll.CheckState == CheckState.Checked)
    {
        foreach (Control control in groupBox1.Controls)
        {
            CheckBox checkbox = control as CheckBox;
            checkbox.Checked = true;
        }
    }
    else if (checkBoxAll.CheckState == CheckState.Unchecked)
    {
        foreach (Control control in groupBox1.Controls)
        {
            CheckBox checkbox = control as CheckBox;
            checkbox.Checked = false;
        }
    }
}
    }
}
