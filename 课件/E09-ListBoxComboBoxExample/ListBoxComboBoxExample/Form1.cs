using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBoxComboBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //添加初始项
            string[] items =
            {
                "高等数学",
                "公共英语",
                "邓小平理论",
                "计算机基础",
                "大学物理"
            };
            comboBox1.Items.AddRange(items);
            //允许用Shift、Ctrl键辅助选择多项
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //删除选定的所有课程项
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
            }
        }
        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            //清空课程列表
            listBox1.Items.Clear();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //向课程列表中添加新课程
            string s = comboBox1.Text;
            if (s.Length == 0)
            {
                MessageBox.Show("请输入或选择所要添加的课程！");
                return;
            }
            else if (!comboBox1.Items.Contains(s))
            {
                //如果是新课程,则自动将其添加到下拉列表中
                comboBox1.Items.Add(s);
            }
            //检查当前所要添加的新课程是否已存在于课程列表中
            //若存在给出提示信息；否则添加新项
            if (listBox1.Items.Contains(s))
            {
                MessageBox.Show("课程<" + s + ">在列表中已存在！");
            }
            else
            {
                listBox1.Items.Add(s);
            }
        }

    }
}
