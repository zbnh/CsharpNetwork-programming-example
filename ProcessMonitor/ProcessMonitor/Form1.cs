using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcessMonitor
{
    public partial class Form1 : Form
    {
        Process[] myProcesses;
         int processID;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getAllProcesses();
        }

        private void getAllProcesses()
        {
            dataGridView1.Rows.Clear();
            myProcesses = Process.GetProcesses();
            foreach (Process p in myProcesses)
            {
                int newRowIndex=dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[newRowIndex];
                row.Cells[0].Value = p.Id;
                row.Cells[1].Value = p.ProcessName;
                row.Cells[2].Value = p.WorkingSet64;
                try
                {
                    row.Cells[3].Value = p.StartTime;
                    row.Cells[4].Value = p.MainModule.FileName;
                }
                catch
                {
                    row.Cells[3].Value = "";
                    row.Cells[4].Value = "";
                }
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo h = dataGridView1.HitTest(e.X, e.Y);
            if (h.Type == DataGridViewHitTestType.RowHeader || h.Type == DataGridViewHitTestType.Cell)
            {
                dataGridView1.Rows[h.RowIndex].Selected = true;
                processID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                showProcessInfo(processID);
            }
        }

        private void showProcessInfo(int processID)
        {
            Process p = Process.GetProcessById(processID);
            StringBuilder sb = new StringBuilder();
            sb.Append("进程名称：" + p.ProcessName + "， ID：" + p.Id);
            richTextBox1.Text = sb.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getAllProcesses();
        }

        private void killProcess_Click(object sender, EventArgs e)
        {
            Process.GetProcessById(processID).Kill();
            getAllProcesses();
        }

    }
}
