namespace SplitContainerExample
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("XXXXXX");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("自然科学", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("YYYYYY");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("生命科学", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("计算机网络");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("C#网络应用编程基础");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("C#网络应用高级编程");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("C#网络应用编程试验指导与开发实例");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("ASP.NET网页设计与网页开发");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("计算机科学", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("科技类", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("XX传奇");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("人物传记", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("书籍", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode13});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(469, 222);
            this.splitContainer1.SplitterDistance = 178;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "区域1";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点12";
            treeNode1.Text = "XXXXXX";
            treeNode2.Name = "节点2";
            treeNode2.Text = "自然科学";
            treeNode3.Name = "节点13";
            treeNode3.Text = "YYYYYY";
            treeNode4.Name = "节点4";
            treeNode4.Text = "生命科学";
            treeNode5.Name = "节点6";
            treeNode5.Text = "计算机网络";
            treeNode6.Name = "节点7";
            treeNode6.Text = "C#网络应用编程基础";
            treeNode7.Name = "节点8";
            treeNode7.Text = "C#网络应用高级编程";
            treeNode8.Name = "节点9";
            treeNode8.Text = "C#网络应用编程试验指导与开发实例";
            treeNode9.Name = "节点10";
            treeNode9.Text = "ASP.NET网页设计与网页开发";
            treeNode10.Name = "节点5";
            treeNode10.Text = "计算机科学";
            treeNode11.Name = "节点1";
            treeNode11.Text = "科技类";
            treeNode12.Name = "节点11";
            treeNode12.Text = "XX传奇";
            treeNode13.Name = "节点3";
            treeNode13.Text = "人物传记";
            treeNode14.Name = "节点0";
            treeNode14.Text = "书籍";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(174, 218);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 218);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 222);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "SplitContainer用法举例";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

