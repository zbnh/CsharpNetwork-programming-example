namespace XKX
{
    partial class SelFrm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listStu = new System.Windows.Forms.ListBox();
            this.cbAcadmey = new System.Windows.Forms.ComboBox();
            this.cbPro = new System.Windows.Forms.ComboBox();
            this.cbCourse = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(366, 218);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 27);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "提交";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "专业";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "学院";
            // 
            // listStu
            // 
            this.listStu.FormattingEnabled = true;
            this.listStu.ItemHeight = 12;
            this.listStu.Location = new System.Drawing.Point(171, 25);
            this.listStu.Name = "listStu";
            this.listStu.Size = new System.Drawing.Size(120, 220);
            this.listStu.TabIndex = 13;
            // 
            // cbAcadmey
            // 
            this.cbAcadmey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcadmey.FormattingEnabled = true;
            this.cbAcadmey.Location = new System.Drawing.Point(12, 52);
            this.cbAcadmey.Name = "cbAcadmey";
            this.cbAcadmey.Size = new System.Drawing.Size(121, 20);
            this.cbAcadmey.TabIndex = 12;
            this.cbAcadmey.SelectedIndexChanged += new System.EventHandler(this.cbAcadmey_SelectedIndexChanged);
            // 
            // cbPro
            // 
            this.cbPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPro.FormattingEnabled = true;
            this.cbPro.Location = new System.Drawing.Point(12, 120);
            this.cbPro.Name = "cbPro";
            this.cbPro.Size = new System.Drawing.Size(121, 20);
            this.cbPro.TabIndex = 11;
            this.cbPro.SelectedIndexChanged += new System.EventHandler(this.cbPro_SelectedIndexChanged);
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.ItemHeight = 12;
            this.cbCourse.Location = new System.Drawing.Point(315, 26);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.cbCourse.Size = new System.Drawing.Size(131, 160);
            this.cbCourse.TabIndex = 16;
            // 
            // SelFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 284);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listStu);
            this.Controls.Add(this.cbAcadmey);
            this.Controls.Add(this.cbPro);
            this.Controls.Add(this.btnOK);
            this.Name = "SelFrm";
            this.Text = "选课";
            this.Load += new System.EventHandler(this.SelFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listStu;
        private System.Windows.Forms.ComboBox cbAcadmey;
        private System.Windows.Forms.ComboBox cbPro;
        private System.Windows.Forms.ListBox cbCourse;
    }
}