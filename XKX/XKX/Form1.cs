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
    public partial class Form1 : Form
    {
        string strCon = "server=.;database=XKDB;user=sa;pwd=123";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool bltype = false;
            SqlConnection con = new SqlConnection(strCon);
            string strSql = "";
            if (radioButton1.Checked)
            {
                strSql = "select * from stuInfo where stuID = @id and stuPwd = @pwd";
                bltype = true;
            }
            else if (radioButton2.Checked)
            {
                strSql = "select * from userInfo where userID = @id and userPwd = @pwd";
            }
            SqlCommand cmd = new SqlCommand(strSql, con);
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = txtName.Text;
            cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 20).Value = txtPwd.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dst = new DataSet();
            try
            {
                sda.Fill(dst);
            }
            catch
            {
            }
            if (dst != null)
            {
                if (dst.Tables.Count != 0 && dst.Tables[0].Rows.Count == 1)
                {
                    mainFrm frm = new mainFrm(bltype, txtName.Text);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("登陆失败！");
                }
            }
            else
            {
                MessageBox.Show("登陆失败！");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}
