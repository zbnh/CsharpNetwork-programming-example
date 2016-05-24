namespace TheRaceBetweenTortoiseAndRabbit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbRabbit = new System.Windows.Forms.PictureBox();
            this.pbTortoise = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRabbit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTortoise)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRabbit
            // 
            this.pbRabbit.Image = ((System.Drawing.Image)(resources.GetObject("pbRabbit.Image")));
            this.pbRabbit.Location = new System.Drawing.Point(38, 12);
            this.pbRabbit.Name = "pbRabbit";
            this.pbRabbit.Size = new System.Drawing.Size(192, 153);
            this.pbRabbit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbRabbit.TabIndex = 0;
            this.pbRabbit.TabStop = false;
            // 
            // pbTortoise
            // 
            this.pbTortoise.Image = ((System.Drawing.Image)(resources.GetObject("pbTortoise.Image")));
            this.pbTortoise.Location = new System.Drawing.Point(38, 183);
            this.pbTortoise.Name = "pbTortoise";
            this.pbTortoise.Size = new System.Drawing.Size(192, 104);
            this.pbTortoise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTortoise.TabIndex = 1;
            this.pbTortoise.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始赛跑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(310, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "龟兔赛跑";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbTortoise);
            this.Controls.Add(this.pbRabbit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbRabbit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTortoise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRabbit;
        private System.Windows.Forms.PictureBox pbTortoise;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

