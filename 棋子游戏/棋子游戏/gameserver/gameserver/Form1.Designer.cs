namespace gameserver
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxmaxusers = new System.Windows.Forms.TextBox();
            this.textBoxmaxtables = new System.Windows.Forms.TextBox();
            this.buttonstart = new System.Windows.Forms.Button();
            this.buttonstop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(502, 172);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "游戏室允许进入的最多人数（1-300):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "游戏室同时开出的游戏桌数（1-100):";
            // 
            // textBoxmaxusers
            // 
            this.textBoxmaxusers.Location = new System.Drawing.Point(233, 197);
            this.textBoxmaxusers.Name = "textBoxmaxusers";
            this.textBoxmaxusers.Size = new System.Drawing.Size(55, 21);
            this.textBoxmaxusers.TabIndex = 3;
            // 
            // textBoxmaxtables
            // 
            this.textBoxmaxtables.Location = new System.Drawing.Point(233, 224);
            this.textBoxmaxtables.Name = "textBoxmaxtables";
            this.textBoxmaxtables.Size = new System.Drawing.Size(55, 21);
            this.textBoxmaxtables.TabIndex = 4;
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(326, 215);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(75, 23);
            this.buttonstart.TabIndex = 5;
            this.buttonstart.Text = "启动服务";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // buttonstop
            // 
            this.buttonstop.Location = new System.Drawing.Point(431, 214);
            this.buttonstop.Name = "buttonstop";
            this.buttonstop.Size = new System.Drawing.Size(75, 23);
            this.buttonstop.TabIndex = 6;
            this.buttonstop.Text = "停止服务";
            this.buttonstop.UseVisualStyleBackColor = true;
            this.buttonstop.Click += new System.EventHandler(this.buttonstop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 262);
            this.Controls.Add(this.buttonstop);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.textBoxmaxtables);
            this.Controls.Add(this.textBoxmaxusers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "服务器端";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxmaxusers;
        private System.Windows.Forms.TextBox textBoxmaxtables;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Button buttonstop;
    }
}

