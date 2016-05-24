using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageListExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Size = new Size(imageList1.ImageSize.Width, imageList1.ImageSize.Height + 25);
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.ImageList = imageList1;
            button1.ImageIndex = 0;
            //button1.ImageKey = imageList1.Images.Keys[1];
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ImageIndex = 1;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ImageIndex = 0;
        }
    }
}
