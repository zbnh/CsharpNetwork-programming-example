using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace ProcessDemoApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number;
        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(mutiThreadMethod);
            Thread thread2 = new Thread(mutiThreadMethod);
            Thread thread3 = new Thread(mutiThreadMethod);
            Thread thread4 = new Thread(mutiThreadMethod);
            thread1.Name = "Thread1";
            thread2.Name = "Thread2";
            thread3.Name = "Thread3";
            thread4.Name = "Thread4";
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();


        }
        public void mutiThreadMethod()
        {
            try
            {
                try
                {
                    number = Convert.ToInt32(textBox1.Text);
                }
                catch
                {

                }
                
                ProcessStartInfo ps = new ProcessStartInfo("Notepad.exe");
                ps.WindowStyle = ProcessWindowStyle.Normal;
                Process process = new Process();
                process.StartInfo = ps;
                if (!textBox1.Visible)
                {
                    process.Start();
                }
                for (int i = 1; i <= number / 4; i++)
                {
                    process.Start();
                }

                process.WaitForInputIdle();
            }
            catch
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Process[] processes;
            processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension("Notepad.exe"));
            foreach (Process p in processes)
            {
                p.CloseMainWindow();
                p.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(changWithinvoke);
            thread.Start();
        }
        public delegate void changVisible();
        public void hideTextbox()
        {
            if (textBox1.Visible)
            {
                textBox1.Visible = false;
            }
            else
            {
                textBox1.Visible = true;
            }
        }
        public void changWithinvoke() { 
            if(InvokeRequired){
                this.Invoke(new changVisible(hideTextbox));
            }
            
        
        }
    }
}
