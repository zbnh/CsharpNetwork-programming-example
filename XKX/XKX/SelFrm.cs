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
    public partial class SelFrm : Form
    {
        string strCon = "server=.;database=XKDB;user=sa;pwd=123";
        public SelFrm()
        {
            InitializeComponent();
        }

        public string userName { get; set; }

        public bool userType { get; set; }

        public SelFrm(bool isAdmin, string strName)
        {
            InitializeComponent();
            userName = strName;
            userType = isAdmin;
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
            SqlCommand cmd = new SqlCommand("select * from stuInfo where stuPro=@id", con);
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

            listStu.DataSource = dst.Tables[0];
            listStu.DisplayMember = "stuName";
            listStu.ValueMember = "stuID";
        }

        private void cbAcadmey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!userType)
            {
                BindPro();
                BindCourse();
                BindList();
            }
        }

        private void cbPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!userType)
            {
                BindCourse();
                BindList();
            }
        }

        void BindStu()
        {
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("select * from stuInfo where stuID=@id", con);
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = userName;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dst = new DataSet();
            try
            {
                sda.Fill(dst);
            }
            catch
            {
            }
            string strid = dst.Tables[0].Rows[0]["stuPro"].ToString();
            listStu.DataSource = dst.Tables[0];
            listStu.DisplayMember = "stuName";
            listStu.ValueMember = "stuID";
            //listStu.Items.Add(dst.Tables[0].Rows[0]["stuName"].ToString());

            cmd = new SqlCommand("select * from proInfo where proID=@id", con);
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = strid;
            sda = new SqlDataAdapter(cmd);
            DataSet dstPro = new DataSet();
            try
            {
                sda.Fill(dstPro);
            }
            catch
            {
            }
            cbPro.DataSource = dstPro.Tables[0];
            cbPro.DisplayMember = "proName";
            cbPro.ValueMember = "proID";
            //cbPro.Items.Add(dst.Tables[0].Rows[1]["proName"]);
            strid = dstPro.Tables[0].Rows[0]["acadID"].ToString();

            DataSet dstAcad = new DataSet();

            cmd = new SqlCommand("select * from academy where acadID=@id", con);
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = strid;
            sda = new SqlDataAdapter(cmd);
            try
            {
                sda.Fill(dstAcad);
            }
            catch
            {
            }
            cbAcadmey.DataSource = dstAcad.Tables[0];
            cbAcadmey.DisplayMember = "acadName";
            cbAcadmey.ValueMember = "acadID";
            //cbAcadmey.Items.Add(dst.Tables[0].Rows[2]["acadName"].ToString());
            BindCourse();
        }

        private void SelFrm_Load(object sender, EventArgs e)
        {
            if (userType)
            {
                BindStu();
                cbAcadmey.DropDownStyle = ComboBoxStyle.DropDown;
                cbPro.DropDownStyle = ComboBoxStyle.DropDown;
                cbAcadmey.Enabled = false;
                cbPro.Enabled = false;
            }
            else
            {
                BindAcademy();
                BindPro();
                BindCourse();
                BindList();
                cbAcadmey.DropDownStyle = ComboBoxStyle.DropDownList;
                cbPro.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //1、先删除信息，2、添加信息
            for (int i = 0; i < cbCourse.SelectedItems.Count; i++)
            {
                SqlConnection con = new SqlConnection(strCon);
                SqlCommand cmd = new SqlCommand("insert into SC(stuID,stuName,couID,couName) values(@stuID,@stuName,@couID,@couName)", con);
                
                cmd.Parameters.Add("@stuID", SqlDbType.VarChar, 20).Value = (((DataRowView)listStu.SelectedItem)["stuID"]).ToString();
                cmd.Parameters.Add("@stuName", SqlDbType.VarChar, 20).Value = (((DataRowView)listStu.SelectedItem)["stuName"]).ToString();
                cmd.Parameters.Add("@couID", SqlDbType.VarChar, 20).Value = (((DataRowView)cbCourse.SelectedItems[i])["couID"]).ToString();
                cmd.Parameters.Add("@couName", SqlDbType.VarChar, 20).Value = (((DataRowView)cbCourse.SelectedItems[i])["couName"]).ToString();
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}