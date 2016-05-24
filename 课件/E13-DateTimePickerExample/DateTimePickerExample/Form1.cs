using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DateTimePickerExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置dateTimePicker1日期初值和选择范围
            dateTimePicker1.MinDate = new DateTime(2009, 4, 1);
            dateTimePicker1.MaxDate = new DateTime(2009, 4, 30);
            dateTimePicker1.Value = dateTimePicker1.MinDate;
            //设置dateTimePicker2为编辑时间
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
            //设置dateTimePicker3为自定义格式
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy年MM月dd日 HH时mm分";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            DateTime dt3 = dateTimePicker3.Value;
            string s = string.Format(
                "1--{0:yyyy-MM-dd}\n2--{1:HH:mm}\n3--{2:yyyy-MM-dd HH:mm}",
                dt1, dt2, dt3);
            MessageBox.Show("选择的时间分别为：\n"+s);
        }
    }
}
