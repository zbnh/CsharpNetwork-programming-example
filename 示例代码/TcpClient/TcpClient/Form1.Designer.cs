namespace TcpClientDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.ListBox();
            this.lbUserName = new System.Windows.Forms.ListBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bSendFIle = new System.Windows.Forms.Button();
            this.bReceiveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(98, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 1;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(242, 32);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "登录";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.FormattingEnabled = true;
            this.lbMessage.ItemHeight = 12;
            this.lbMessage.Location = new System.Drawing.Point(56, 98);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(334, 208);
            this.lbMessage.TabIndex = 3;
            // 
            // lbUserName
            // 
            this.lbUserName.FormattingEnabled = true;
            this.lbUserName.ItemHeight = 12;
            this.lbUserName.Location = new System.Drawing.Point(485, 50);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(184, 292);
            this.lbUserName.TabIndex = 4;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(74, 351);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(288, 21);
            this.tbMessage.TabIndex = 5;
            // 
            // tbSend
            // 
            this.tbSend.Location = new System.Drawing.Point(385, 351);
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(75, 23);
            this.tbSend.TabIndex = 6;
            this.tbSend.Text = "发送消息";
            this.tbSend.UseVisualStyleBackColor = true;
            this.tbSend.Click += new System.EventHandler(this.tbSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "聊天信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "在线用户列表";
            // 
            // bSendFIle
            // 
            this.bSendFIle.Location = new System.Drawing.Point(242, 397);
            this.bSendFIle.Name = "bSendFIle";
            this.bSendFIle.Size = new System.Drawing.Size(75, 23);
            this.bSendFIle.TabIndex = 9;
            this.bSendFIle.Text = "发送文件";
            this.bSendFIle.UseVisualStyleBackColor = true;
            this.bSendFIle.Click += new System.EventHandler(this.bSendFIle_Click);
            // 
            // bReceiveFile
            // 
            this.bReceiveFile.Location = new System.Drawing.Point(360, 397);
            this.bReceiveFile.Name = "bReceiveFile";
            this.bReceiveFile.Size = new System.Drawing.Size(75, 23);
            this.bReceiveFile.TabIndex = 10;
            this.bReceiveFile.Text = "接收文件";
            this.bReceiveFile.UseVisualStyleBackColor = true;
            this.bReceiveFile.Click += new System.EventHandler(this.bReceiveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 441);
            this.Controls.Add(this.bReceiveFile);
            this.Controls.Add(this.bSendFIle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.ListBox lbMessage;
        private System.Windows.Forms.ListBox lbUserName;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button tbSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSendFIle;
        private System.Windows.Forms.Button bReceiveFile;
    }
}

