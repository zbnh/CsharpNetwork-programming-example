using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuStripToolStripExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 显示图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image==null)
            {
                this.pictureBox1.Image = Properties.Resources.校园风光;
            }
        }

        private void 旋转图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            旋转图像ToolStripMenuItem.PerformClick();
        }

        private void 添加文字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("文字" + listBox1.Items.Count);
        }

        private void 删除文字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("请先选择要删除的行");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            删除文字ToolStripMenuItem.PerformClick();
        }

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "您正在对菜单进行操作";
        }

        private void toolStrip1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "您正在对工具栏进行操作";
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("帮助信息：无");
        }
    }
}
