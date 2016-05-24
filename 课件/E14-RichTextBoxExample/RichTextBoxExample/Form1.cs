using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RichTextBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.EnableAutoDragDrop = true;
            richTextBox1.Font = new Font(this.Font.FontFamily, 20);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox1.DoDragDrop(pictureBox.Image,
                DragDropEffects.Copy | DragDropEffects.Move);
        }
    }
}
