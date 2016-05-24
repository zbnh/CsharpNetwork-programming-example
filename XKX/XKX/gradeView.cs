using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace XKX
{
    public partial class gradeView : Form
    {
        string strCon = "server=.;database=XKDB;user=sa;pwd=123";
        //默认，无参数
        public gradeView()
        {
            InitializeComponent();
        }
        //窗体传值，方法2，公共的成员变量
        public string userName { get; set; }

        public bool userType { get; set; }
        //窗体传值，方法1，构造函数
        //重载，含有参数
        public gradeView(bool isAdmin, string strName)
        {
            InitializeComponent();

            userName = strName;
            userType = isAdmin;
        }

        private void gradeView_Load(object sender, EventArgs e)
        {
            if (userType)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
            BindGrid();
        }

        void BindGrid()
        {
            SqlConnection con = new SqlConnection(strCon);
            string strSql = "";
            if (userType)
            {
                strSql = "select * from SC where stuID=@id";
            }
            else
            {
                strSql = "select * from SC";
            }
            SqlCommand cmd = new SqlCommand(strSql, con);
            if (userType)
            {
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = userName;
            }
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dst = new DataSet();
            try
            {
                sda.Fill(dst);
            }
            catch
            {
            }
            dataGridView1.DataSource = dst.Tables[0];
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strCon);
            string strSql = "select * from SC where stuName like '%'+ @stu +'%' and couName like '%'+ @course +'%'";
            SqlCommand cmd = new SqlCommand(strSql, con);
            cmd.Parameters.Add("@stu", SqlDbType.VarChar, 20).Value = txtName.Text;
            cmd.Parameters.Add("@course", SqlDbType.VarChar, 20).Value = txtCourse.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dst = new DataSet();
            try
            {
                sda.Fill(dst);
            }
            catch
            {
            }
            dataGridView1.DataSource = dst.Tables[0];
        }
    }
}
