namespace WindowsFormsApplication1
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
            this.number1 = new System.Windows.Forms.TextBox();
            this.symbol = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.btnres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(12, 23);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 21);
            this.number1.TabIndex = 0;
            // 
            // symbol
            // 
            this.symbol.Location = new System.Drawing.Point(129, 22);
            this.symbol.Name = "symbol";
            this.symbol.Size = new System.Drawing.Size(36, 21);
            this.symbol.TabIndex = 1;
            this.symbol.Text = "+";
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(191, 22);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 21);
            this.number2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(317, 26);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(41, 12);
            this.result.TabIndex = 4;
            this.result.Text = "label2";
            // 
            // btnres
            // 
            this.btnres.Location = new System.Drawing.Point(67, 61);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(224, 23);
            this.btnres.TabIndex = 5;
            this.btnres.Text = "计算";
            this.btnres.UseVisualStyleBackColor = true;
            this.btnres.Click += new System.EventHandler(this.btnres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 105);
            this.Controls.Add(this.btnres);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.symbol);
            this.Controls.Add(this.number1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox symbol;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button btnres;
    }
}

