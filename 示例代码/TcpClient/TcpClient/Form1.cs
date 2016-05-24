using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
namespace TcpClientDemo
{
    public partial class Form1 : Form
    {
        TcpClient client = null;
        BinaryReader br = null;
        BinaryWriter bw = null;
        bool isExit = false;
        int fileport = 60002;
        String username;
        List<FileRece> recelist = new List<FileRece>();
        List<FileSend> sendlist = new List<FileSend>();
        public Form1()
        {
            InitializeComponent();
            this.bReceiveFile.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请先输入用户名");
                return;
            }
            try
            {
                client = new TcpClient(Dns.GetHostName(), 8888);
                br = new BinaryReader(client.GetStream());
                bw = new BinaryWriter(client.GetStream());
                lbMessage.Items.Add("连接到服务器");
                bw.Write("login," + tbName.Text.Trim());
                bw.Flush();
                username = tbName.Text.Trim();
                lbMessage.Items.Add("用户名已发送");
                Thread t = new Thread(receMessage);
                t.Start();
            }
            catch (Exception ex)
            {
                client = null;
                MessageBox.Show(ex.Message);
            }


        }
        private void receMessage()
        {

            while (!isExit)
            {
                try
                {
                    String receString = br.ReadString();
                    String[] strs = receString.Split(',');
                    switch (strs[0])
                    {
                        case "login":
                            if (!strs[1].Equals(tbName.Text.Trim()))
                                lbUserName.Items.Add(strs[1]);
                            break;
                        case "talk":
                            String receName = strs[2];
                            String message = receString.Substring(strs[0].Length + strs[1].Length + strs[2].Length + 3);
                            lbMessage.Items.Add(String.Format("{0}对{1}说：{2}", strs[1], strs[2], message));
                            break;
                        case "logout":
                            lbUserName.Items.Remove(strs[1]);
                            break;
                        case "file":
                            String sendName = strs[1];
                            String receName2 = strs[2];
                            FileRece fr = new FileRece();

                            String fileName = receString.Substring(strs[0].Length + strs[1].Length + strs[2].Length + 3);
                            fr.filename = fileName;
                            fr.sender = sendName;
                            recelist.Add(fr);
                            lbMessage.Items.Add("用户" + sendName + "向您发送文件" + fileName + "请点击接受按钮接受");
                            bReceiveFile.Enabled = true;
                            break;

                        case "accept":
                            String sendName3 = strs[1];
                            String receName3 = strs[2];
                            String receip = strs[4];
                            String fileName3 = strs[3];
                            TcpClient sendClient = new TcpClient(receip, fileport);
                            FileSend fs = null;
                            foreach (FileSend s in sendlist)
                            {
                                if (s.receName.Equals(receName3) && s.fileName.Equals(fileName3))
                                    fs = s;
                            }
                            long fileLength = fs.fs.Length;
                            BinaryWriter fw = new BinaryWriter(sendClient.GetStream());
                            fw.Write(fileLength);
                            //int transNum = 0;
                            byte[] buffer = new byte[1024];
                            int num = fs.fs.Read(buffer, 0, 1024);
                            while (num > 0)
                            {
                                fw.Write(buffer, 0, num);
                                fw.Flush();
                                num = fs.fs.Read(buffer, 0, 1024);
                            }
                            fs.fs.Close();
                            sendlist.Remove(fs);
                            sendClient.Close();
                            break;
                    }
                }
                catch
                {
                    if (isExit) break;
                    else
                    {
                        lbMessage.Items.Add("服务器连接出现故障");
                        return;
                    }
                }
            }
        }

        private void tbSend_Click(object sender, EventArgs e)
        {
            if (lbUserName.SelectedIndex < 0)
            {
                MessageBox.Show("尚未选择信息的接受方");
                return;
            }
            String message = "talk," + tbName.Text.Trim() + "," + lbUserName.SelectedItem.ToString() + "," + tbMessage.Text;
            bw.Write(message);
            bw.Flush();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                String message = "logout," + tbName.Text.Trim();
                bw.Write(message);
                bw.Flush();
                isExit = true;
                br.Close();
                bw.Close();
                client.Close();
            }
        }

        private void bSendFIle_Click(object sender, EventArgs e)
        {
            if (lbUserName.SelectedIndex < 0)
            {
                MessageBox.Show("请先选择发送文件的接收者");
                return;
            }
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                String receName = lbUserName.SelectedItem.ToString();
                String sendString = String.Format("file,{0},{1},{2}", username, receName, opf.FileName);
                bw.Write(sendString);
                bw.Flush();
                FileSend fs = new FileSend();
                fs.fs = (FileStream)opf.OpenFile();
                fs.fileName = opf.FileName;
                fs.receName = receName;
                sendlist.Add(fs);
            }

        }

        private void bReceiveFile_Click(object sender, EventArgs e)
        {
            FileRece fr = recelist[0];
            SaveFileDialog sfg = new SaveFileDialog();
            sfg.FileName = fr.filename;
            if (sfg.ShowDialog() == DialogResult.OK)
            {
                String sendString = String.Format("accept,{0},{1},{2}", fr.sender, username, fr.filename);
                bw.Write(sendString);
                bw.Flush();
                TcpListener filelistener = new TcpListener(Dns.GetHostAddresses(Dns.GetHostName())[1], fileport);
                filelistener.Start();
                TcpClient client = filelistener.AcceptTcpClient();
                BinaryReader fbr = new BinaryReader(client.GetStream());
                FileStream sfs = (FileStream)sfg.OpenFile();
                long fileLength = fbr.ReadInt64();
                byte[] buffer = new byte[1024];
                long transNum = 0;
                while (true)
                {
                    int num = fbr.Read(buffer, 0, 1024);
                    transNum += num;
                    sfs.Write(buffer, 0, num);
                    if (transNum >= fileLength) break;
                }
                sfs.Close();
                fbr.Close();
                client.Close();
                filelistener.Stop();

            }
        }
    }
}
