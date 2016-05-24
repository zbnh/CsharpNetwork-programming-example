using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotifyIconExample
{
public partial class Form1 : Form
{
    private bool isExit = false;
    public Form1()
    {
        InitializeComponent();

        notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
        notifyIcon1.Text = "NotifyIcon用法举例";
        notifyIcon1.Visible = true;
        notifyIcon1.BalloonTipText = "aaaaaaaa";
        notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
        //不在任务栏显示窗体
        this.ShowInTaskbar = false;
        this.WindowState = FormWindowState.Minimized;
        this.StartPosition = FormStartPosition.Manual;
        this.SetDesktopLocation(
            Screen.PrimaryScreen.WorkingArea.Width - this.Width - 20,
            Screen.PrimaryScreen.WorkingArea.Height - this.Height - 50);

    }
    private void notifyIcon1_DoubleClick(object Sender, EventArgs e)
    {
        if (this.WindowState == FormWindowState.Minimized)
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
        else
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

    private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        isExit = true;
        this.Close();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (isExit == false)
        {
            this.WindowState = FormWindowState.Minimized;
            e.Cancel = true;  //不关闭窗体
        }
    }
}
}
