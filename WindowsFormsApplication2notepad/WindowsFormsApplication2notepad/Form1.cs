using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2notepad
{
    public partial class Form1 : Form
    {
        string filePath = "";
        string fileName = "";
        bool isNew = true;
        bool isChanged = false;
        bool isSaveas = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                fileName = ofd.SafeFileName;
                StreamReader sr = new StreamReader(filePath, false);
                ContextrichTextBox.Text = sr.ReadToEnd();
                sr.Close();
                isNew = false;
                isChanged = false;
            }

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isSaveas = false;
            saveFiles();

        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isSaveas = true;
            saveFiles();

        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextrichTextBox.Text = "";
            isNew = true;
            isChanged = false;
        }

        private void ContextrichTextBox_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        public void saveFiles()
        {
            try
            {
                if (!(isNew || isSaveas))
                {
                    StreamWriter sw = new StreamWriter(filePath, false);
                    sw.Write(ContextrichTextBox.Text);
                    sw.Close();
                    isChanged = false;
                }
                else
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    if (isSaveas)
                    {
                        sfd.Title = "另存为";
                    }
                    else
                    {
                        sfd.Title = "保存";
                    }

                    sfd.Filter = "文本文件（*.txt）|*.txt";
                    sfd.FilterIndex = 1;
                    sfd.AddExtension = true;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        filePath = sfd.FileName;
                        StreamWriter sw = new StreamWriter(filePath, false);
                        sw.Write(ContextrichTextBox.Text);
                        sw.Close();
                        isChanged = false;
                    }
                }

            }
            catch
            {
                MessageBox.Show("出现异常^_^||", "Error", MessageBoxButtons.OK);
            }
        }
        public void close()
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChanged )
            {
                switch (MessageBox.Show("你的修改还没有保存呦，是否保存？", "请确认", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        saveFiles();
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        e.Cancel = true;
                        break;
                }
            }


        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notepad Z-0.0.1\n@zb", "关于 Notepad Z", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
