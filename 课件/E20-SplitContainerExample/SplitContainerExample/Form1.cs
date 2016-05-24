using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SplitContainerExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string doubleNewLine = Environment.NewLine + Environment.NewLine;
            if (treeView1.SelectedNode.GetNodeCount(false) == 0)
            {
                textBox1.Text = doubleNewLine + doubleNewLine +
                    "书名：" + treeView1.SelectedNode.Text + doubleNewLine +
                    "作者：不详" + doubleNewLine +
                    "出版社：不详" + doubleNewLine +
                    "更多信息：无";
            }
            else
            {
                textBox1.Text = doubleNewLine + doubleNewLine +
                    "分类:" + treeView1.SelectedNode.Text
                     + doubleNewLine + "更多信息：无";
            }
        }
    }
}
