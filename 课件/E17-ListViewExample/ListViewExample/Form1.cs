using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;
            //初始化listView1中的列
            listView1.View = View.Details;
            listView1.Columns.Add("学号", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("姓名", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("成绩", 80, HorizontalAlignment.Left);
            //添加数据项
            AddlistViewItem("20080101", "张三", 80);
            AddlistViewItem("20080102", "李四", 90);
            AddlistViewItem("20080103", "王五", 70);
            //注册在“详细列表”显示方式下单击列标题的排序事件
            listView1.ColumnClick += new ColumnClickEventHandler(listView1_ColumnClick);
            //注册GroupBox中所有RadioButton的CheckedChanged事件
            foreach (Control c in groupBox1.Controls)
            {
                RadioButton r = (RadioButton)c;
                r.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            }
        }

        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            switch (r.Text)
            {
                case "大图标":
                    listView1.View = View.LargeIcon;
                    break;
                case "小图标":
                    listView1.View = View.SmallIcon;
                    break;
                case "列表":
                    listView1.View = View.List;
                    break;
                case "详细信息":
                    listView1.View = View.Details;
                    break;
            }
        }

        private void AddlistViewItem(string id, string name, int grade)
        {
            int imageIndex = 0;
            ListViewItem item = new ListViewItem(
                new string[] {id,name,grade.ToString()}, imageIndex);
            listView1.Items.Add(item);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listView1.Sorting == SortOrder.Descending)
            {
                listView1.Sorting = SortOrder.Ascending;
            }
            else
            {
                listView1.Sorting = SortOrder.Descending;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddlistViewItem(textBoxID.Text, textBoxName.Text, int.Parse(textBoxGrade.Text));
            }
            catch
            {
                MessageBox.Show("成绩必须为数字");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem item = listView1.SelectedItems[i];
                listView1.Items.Remove(item);
            }
        }

    }
}
