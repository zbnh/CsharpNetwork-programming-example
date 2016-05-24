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
    public partial class gradeImport : Form
    {
        string strCon = "server=.;database=XKDB;user=sa;pwd=123";
        public gradeImport()
        {
            InitializeComponent();
        }

        void BindAcademy()
        {
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("select * from academy", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dst = new DataSet();
            try
            {
                sda.Fill(dst);
            }
            catch
            {
            }

            cbAcadmey.DataSource = dst.Tables[0];
            cbAcadmey.DisplayMember = "acadName";
            cbAcadmey.ValueMember = "acadID";
        }

        void BindPro()
        {
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("select * from proInfo where acadID=@id", con);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(((DataRowView)cbAcadmey.SelectedItem)["acadID"]);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dst = new DataSet();
            try
            {
                sda.Fill(dst);
            }
            catch
            {
            }

            cbPro.DataSource = dst.Tables[0];
            cbPro.DisplayMember = "proName";
            cbPro.ValueMember = "proID";
        }

        void BindCourse()
        {
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("select * from courseInfo where proID=@id", con);
            string str = "";
            try
            {
                str = ((DataRowView)cbPro.SelectedItem)["proID"].ToString();
            }
            catch
            {
            }
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = str;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dst = new DataSet();
            try
            {
                sda.Fill(dst);
            }
            catch
            {
            }

            cbCourse.DataSource = dst.Tables[0];
            cbCourse.DisplayMember = "couName";
            cbCourse.ValueMember = "couID";
        }

        void BindList()
        {
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("select * from SC where couID=@id", con);
            string str = "";
            try
            {
                str = ((DataRowView)cbCourse.SelectedItem)["couID"].ToString();
            }
            catch
            {
            }
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = str;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dst = new DataSet();
            try
            {
                sda.Fill(dst);
            }
            catch
            {
            }

            listStu.DataSource = dst.Tables[0];
            listStu.DisplayMember = "stuName";
            listStu.ValueMember = "stuID";
        }

        private void gradeImport_Load(object sender, EventArgs e)
        {
            BindAcademy();
            BindPro();
            BindCourse();
            BindList();
        }

        private void cbAcadmey_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindPro();
            BindCourse();
            BindList();
        }

        private void cbPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCourse();
            BindList();
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindList();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand("update SC set grade=@grade where stuID=@stuID and couID=@couID", con);
                cmd.Parameters.Add("@grade", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                cmd.Parameters.Add("@stuID", SqlDbType.VarChar, 20).Value = (((DataRowView)listStu.SelectedItem)["stuID"]).ToString();
                cmd.Parameters.Add("@couID", SqlDbType.VarChar, 20).Value = (((DataRowView)cbCourse.SelectedItem)["couID"]).ToString();
                try
                {
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("操作成功！");
                    else
                    {
                        MessageBox.Show("操作失败！");
                    }
                }
                catch
                {
                    MessageBox.Show("操作失败！");
                }
            }
        }

        private void listStu_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("select * from SC where stuID=@stuID and couID=@couID", con);
            cmd.Parameters.Add("@stuID", SqlDbType.VarChar, 20).Value = (((DataRowView)listStu.SelectedItem)["stuID"]).ToString();
            cmd.Parameters.Add("@couID", SqlDbType.VarChar, 20).Value = (((DataRowView)cbCourse.SelectedItem)["couID"]).ToString();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dst = new DataSet();
            try
            {
                sda.Fill(dst);
            }
            catch
            {
            }
            textBox1.Text = dst.Tables[0].Rows[0]["grade"].ToString();
        }
    }
}
