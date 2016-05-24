using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckedListBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.MultiColumn = true;
            checkedListBox1.CheckOnClick = true;
            string[] items =
            {
                "C#高级编程","编译原理","操作系统","计算机体系结构",
                "计算机网络","计算机英语","软件工程","数据库技术",
                "通信原理","微机接口技术"
            };
            checkedListBox1.Items.AddRange(items);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int checkedNumber = checkedListBox1.CheckedItems.Count;
            if (checkedNumber == 0)
            {
                MessageBox.Show("您还没有选择任何课程！");
                return;
            }
            string s = "您所选择的课程是：";
            for (int i = 0; i < checkedNumber; i++)
            {
                s += checkedListBox1.CheckedItems[i] + "、";
            }
            MessageBox.Show(s.TrimEnd('、'),"提示");
        }

        private void buttonReference_Click(object sender, EventArgs e)
        {
            //取消已经选中的项
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            //添加建议选中的项
            checkedListBox1.SetItemChecked(0, true);
            checkedListBox1.SetItemChecked(3, true);
            checkedListBox1.SetItemChecked(7, true);
        }
    }
}
