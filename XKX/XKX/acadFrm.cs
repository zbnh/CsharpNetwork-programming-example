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
    public partial class acadFrm : Form
    {
        string strCon = "server=.;database=XKDB;user=sa;pwd=123";
        public acadFrm()
        {
            InitializeComponent();
        }

        private void acadFrm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        void BindGrid()
        {
            SqlConnection con = new SqlConnection(strCon);
            string strSql = "select * from academy";            
            SqlCommand cmd = new SqlCommand(strSql, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dst = new DataSet();
            try
            {
                sda.Fill(dst);
            }
            catch
            {
            }
            bindingSource1.DataSource = dst.Tables[0];
            bindingNavigator1.BindingSource = bindingSource1;
            
            dataGridView1.DataSource = bindingSource1;
            //dataGridView1.DataSource = dst.Tables[0];
            //dataGridView1.Columns[0].HeaderText = "编号";
            //dataGridView1.Columns[1].HeaderText = "学院名称";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (blState)
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    string strSql = "update academy set acadName = @name where acadID=@id";
                    SqlCommand cmd = new SqlCommand(strSql, con);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 20).Value = txtName.Text;
                    try
                    {
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("修改成功！");
                            blState = false;
                            BindGrid();
                        }
                        else
                        {
                            MessageBox.Show("修改失败！");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
            }
            else
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    string strSql = "insert into academy(acadName) values(@name)";
                    SqlCommand cmd = new SqlCommand(strSql, con);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 20).Value = txtName.Text;
                    try
                    {
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("添加成功！");
                            BindGrid();
                        }
                        else
                        {
                            MessageBox.Show("添加失败！");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("添加失败！");
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count;i++ )
                {
                    using (SqlConnection con = new SqlConnection(strCon))
                    {
                        string strSql = "delete academy where acadID=@id";
                        SqlCommand cmd = new SqlCommand(strSql, con);
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value);
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            //MessageBox.Show("添加失败！");
                        }
                    }
                }
                BindGrid();
            }
        }

        bool blState = false;

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strSql = "update academy set acadName = @name where acadID=@id";
                SqlCommand cmd = new SqlCommand(strSql, con);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                cmd.Parameters.Add("@name", SqlDbType.VarChar, 20).Value = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                try
                {
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("修改成功！");
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
                catch
                {
                    MessageBox.Show("修改失败！");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            blState = true;
            
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            txtName.Text = "";
            blState = false;
        }
    }
}
