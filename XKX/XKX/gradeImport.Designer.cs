namespace XKX
{
    partial class gradeImport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.cbPro = new System.Windows.Forms.ComboBox();
            this.cbAcadmey = new System.Windows.Forms.ComboBox();
            this.listStu = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCourse
            // 
            this.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(12, 191);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(121, 20);
            this.cbCourse.TabIndex = 0;
            this.cbCourse.SelectedIndexChanged += new System.EventHandler(this.cbCourse_SelectedIndexChanged);
            // 
            // cbPro
            // 
            this.cbPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPro.FormattingEnabled = true;
            this.cbPro.Location = new System.Drawing.Point(12, 109);
            this.cbPro.Name = "cbPro";
            this.cbPro.Size = new System.Drawing.Size(121, 20);
            this.cbPro.TabIndex = 1;
            this.cbPro.SelectedIndexChanged += new System.EventHandler(this.cbPro_SelectedIndexChanged);
            // 
            // cbAcadmey
            // 
            this.cbAcadmey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcadmey.FormattingEnabled = true;
            this.cbAcadmey.Location = new System.Drawing.Point(12, 41);
            this.cbAcadmey.Name = "cbAcadmey";
            this.cbAcadmey.Size = new System.Drawing.Size(121, 20);
            this.cbAcadmey.TabIndex = 2;
            this.cbAcadmey.SelectedIndexChanged += new System.EventHandler(this.cbAcadmey_SelectedIndexChanged);
            // 
            // listStu
            // 
            this.listStu.FormattingEnabled = true;
            this.listStu.ItemHeight = 12;
            this.listStu.Location = new System.Drawing.Point(171, 12);
            this.listStu.Name = "listStu";
            this.listStu.Size = new System.Drawing.Size(120, 220);
            this.listStu.TabIndex = 3;
            this.listStu.SelectedIndexChanged += new System.EventHandler(this.listStu_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(53, 108);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(307, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 220);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分数录入";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "学院";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "专业";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "课程";
            // 
            // gradeImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 251);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listStu);
            this.Controls.Add(this.cbAcadmey);
            this.Controls.Add(this.cbPro);
            this.Controls.Add(this.cbCourse);
            this.Name = "gradeImport";
            this.Text = "成绩录入";
            this.Load += new System.EventHandler(this.gradeImport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.ComboBox cbPro;
        private System.Windows.Forms.ComboBox cbAcadmey;
        private System.Windows.Forms.ListBox listStu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}