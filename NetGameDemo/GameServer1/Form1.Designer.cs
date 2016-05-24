namespace GameServer
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
            this.servStart = new System.Windows.Forms.Button();
            this.servTips = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // servStart
            // 
            this.servStart.Location = new System.Drawing.Point(333, 206);
            this.servStart.Name = "servStart";
            this.servStart.Size = new System.Drawing.Size(75, 23);
            this.servStart.TabIndex = 0;
            this.servStart.Text = "启动服务器";
            this.servStart.UseVisualStyleBackColor = true;
            this.servStart.Click += new System.EventHandler(this.servStart_Click);
            // 
            // servTips
            // 
            this.servTips.FormattingEnabled = true;
            this.servTips.ItemHeight = 12;
            this.servTips.Location = new System.Drawing.Point(12, 12);
            this.servTips.Name = "servTips";
            this.servTips.Size = new System.Drawing.Size(417, 136);
            this.servTips.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 279);
            this.Controls.Add(this.servTips);
            this.Controls.Add(this.servStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button servStart;
        private System.Windows.Forms.ListBox servTips;
    }
}

