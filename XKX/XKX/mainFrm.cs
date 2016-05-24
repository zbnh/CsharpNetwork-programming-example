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
    public partial class mainFrm : Form
    {
        bool arType { get; set; }//true学生，false管理员
        string strCon = "server=.;database=XKDB;user=sa;pwd=123";
        //string arUser { get; set; }

        public mainFrm()
        {
            InitializeComponent();
        }

        public mainFrm(bool blType, string userID)
        {
            InitializeComponent();
            arType = blType;
            txtName.Text = userID;
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            GetMenu();
        }

        void GetMenu()
        {
            ToolStripMenuItem xk = new ToolStripMenuItem("选课");

            ToolStripMenuItem xkSub = new ToolStripMenuItem("选课");
            xkSub.Click += new EventHandler(xkSub_Click);

            ToolStripMenuItem grade = new ToolStripMenuItem("成绩录入");
            ToolStripMenuItem gradeView = new ToolStripMenuItem("成绩查看");
            gradeView.Click += new EventHandler(gradeView_Click);

            xk.DropDownItems.Add(xkSub);
            xk.DropDownItems.Add(gradeView);
            if (!arType)
            {
                xk.DropDownItems.Add(grade);
            }
            menuStrip1.Items.Add(xk);

            if (!arType)
            {
                ToolStripMenuItem sys = new ToolStripMenuItem("系统设置");

                ToolStripMenuItem acad = new ToolStripMenuItem("学院设置");
                acad.Click += new EventHandler(acad_Click);
                ToolStripMenuItem pro = new ToolStripMenuItem("专业设置");
                ToolStripMenuItem cousre = new ToolStripMenuItem("课程设置");
                ToolStripMenuItem stu = new ToolStripMenuItem("学生信息");
                ToolStripMenuItem user = new ToolStripMenuItem("管理员信息");
                sys.DropDownItems.Add(acad);
                sys.DropDownItems.Add(pro);
                sys.DropDownItems.Add(cousre);
                sys.DropDownItems.Add(stu);
                sys.DropDownItems.Add(user);

                menuStrip1.Items.Add(sys);
            }
        }

        void xkSub_Click(object sender, EventArgs e)
        {
            SelFrm frm = new SelFrm(arType, txtName.Text);
            frm.Show();
        }

        void gradeView_Click(object sender, EventArgs e)
        {
            gradeView gv = new gradeView();
            gv.userName = txtName.Text;
            gv.userType = arType;
            //gradeView gv = new gradeView(arType, txtName.Text);
            gv.Show();
        }

        void acad_Click(object sender, EventArgs e)
        {
            acadFrm frm = new acadFrm();
            frm.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strCon);
            string strSql = "";
            if (arType)
            {
                strSql = "update stuInfo set stuPwd=@pwd where stuID = @id";
            }
            else
            {
                strSql = "update userInfo set userPwd=@pwd where userID=@id";
            }
            SqlCommand cmd = new SqlCommand(strSql, con);
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = txtName.Text;
            cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 20).Value = txtPwd.Text;
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
            finally
            {
                con.Close();
            }
        }
    }
}
