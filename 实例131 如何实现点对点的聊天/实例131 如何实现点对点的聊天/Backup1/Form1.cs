using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Net.Sockets;
using System.IO;
namespace Network
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextBox2;
		    
		//���������̶߳���
		private Thread MyListenThread;
		//���������������
		private TcpListener MyTcpListener;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.Label label5;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "��������IP��ַ��";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(112, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(96, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(216, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "������";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.textBox2.Location = new System.Drawing.Point(264, 8);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(88, 21);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(272, 32);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "����";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "��Ҫ���͵����ݣ�";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(8, 56);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(344, 56);
			this.richTextBox1.TabIndex = 6;
			this.richTextBox1.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(176, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "�Ѿ��յ������ݣ�";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(176, 136);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(176, 136);
			this.richTextBox2.TabIndex = 8;
			this.richTextBox2.Text = "";
			// 
			// richTextBox3
			// 
			this.richTextBox3.Location = new System.Drawing.Point(8, 136);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(160, 136);
			this.richTextBox3.TabIndex = 10;
			this.richTextBox3.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "�Ѿ����͵����ݣ�";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(360, 278);
			this.Controls.Add(this.richTextBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "��ʾ��Ե������";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.Form1_Closed);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		private void StartListen()
		{
			MyTcpListener=new TcpListener(888);
			//��ʼ����
			MyTcpListener.Start();              
			while(true)
			{//��ȡTcpClient
				TcpClient MyTcpClient=MyTcpListener.AcceptTcpClient();
				NetworkStream MyStream=MyTcpClient.GetStream();
				byte[] MyBytes = new byte[1024];
				int MyBytesRead=MyStream.Read(MyBytes,0,MyBytes.Length);
				string MyMessage=System.Text.Encoding.Default.GetString(MyBytes,0,MyBytesRead);
				this.richTextBox2.Text+=MyMessage;					
			}			
		}
		private void button1_Click(object sender, System.EventArgs e)
		{//������������
			if(this.textBox1.Text.Length<1||this.textBox2.Text.Length<1||this.richTextBox1.Text.Length<1)
				return;
			try
			{
				string MyMessage= this.textBox2.Text+":"+this.richTextBox1.Text+"\n";
				//����Ŀ��������ַ��������
				TcpClient MyTcpClient = new TcpClient(this.textBox1.Text, 888);
				//�������������ʵ�������
				NetworkStream MyTcpStream =MyTcpClient.GetStream();
				StreamWriter MyStream = new StreamWriter(MyTcpStream);
				//���ַ���д����
				MyStream.Write(MyMessage);
				//����������д�������
				MyStream.Flush();
				//�ر�������
				MyStream.Close();
				MyTcpClient.Close(); 
				this.richTextBox3.AppendText(this.richTextBox1.Text+"\n");
				this.richTextBox1.Clear();
			}
			catch(Exception Err)
			{
			   MessageBox.Show(Err.Message,"��Ϣ��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Information);				
			}
		}
		private void Form1_Load(object sender, System.EventArgs e)
		{//��ʼ����
			//���������߳�
			this.MyListenThread= new Thread(new ThreadStart(StartListen));	
			//�����߳�
			this.MyListenThread.Start();
		}

		private void Form1_Closed(object sender, System.EventArgs e)
		{//�ر�SOCKET
			try
			{
				if (this.MyTcpListener!=null)
				{//�رռ�����
					this.MyTcpListener.Stop();
				}
				if (this.MyListenThread!=null)
				{	//����̻߳���������״̬�͹ر���
					if (this.MyListenThread.ThreadState==ThreadState.Running)
					{
						this.MyListenThread.Abort();
					}
				}
			}
			catch(Exception Err)
			{
				  MessageBox.Show(Err.Message,"��Ϣ��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
	}
}
