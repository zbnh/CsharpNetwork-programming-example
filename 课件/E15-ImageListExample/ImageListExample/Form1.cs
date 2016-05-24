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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Size = new Size(imageList1.ImageSize.Width, imageList1.ImageSize.Height + 50);
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.ImageList = imageList1;
            button1.ImageIndex = 0;
            button2.Size = new Size(imageList1.ImageSize.Width, imageList1.ImageSize.Height + 50);
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.ImageList = imageList1;
            button2.ImageIndex = 0;
            button3.Size = new Size(imageList1.ImageSize.Width, imageList1.ImageSize.Height + 50);
            button3.TextImageRelation = TextImageRelation.Overlay;
            button3.ImageList = imageList1;
            button3.ImageIndex = 0;
            button4.Size = new Size(imageList1.ImageSize.Width, imageList1.ImageSize.Height + 50);
            button4.TextImageRelation = TextImageRelation.TextAboveImage;
            button4.ImageList = imageList1;
            button4.ImageIndex = 0;
            button5.Size = new Size(imageList1.ImageSize.Width, imageList1.ImageSize.Height + 50);
            button5.TextImageRelation = TextImageRelation.TextBeforeImage;
            button5.ImageList = imageList1;
            button5.ImageIndex = 0;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ImageIndex = 1;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ImageIndex = 0;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ImageIndex = 1;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ImageIndex = 0;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ImageIndex = 1;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ImageIndex = 0;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ImageIndex = 1;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ImageIndex = 0;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.ImageIndex = 1;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ImageIndex = 0;
        }
    }
}
