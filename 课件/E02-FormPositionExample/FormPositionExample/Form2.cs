using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormPositionExample
{
    public partial class Form2 : Form
    {
        bool isCustomStyle = false;
        /// <summary>
        /// 在屏幕中心显示的窗体
        /// </summary>
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// 在指定的屏幕坐标位置显示窗体
        /// </summary>
        /// <param name="screenX">屏幕x坐标</param>
        /// <param name="screenY">屏幕y坐标</param>
        public Form2(int screenX,int screenY)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            Point p = new Point(screenX, screenY);
            label1.Text ="当前窗体的屏幕坐标位置：" + p.ToString();
            this.Location = p;
        }
        /// <summary>
        /// 椭圆形窗体
        /// </summary>
        /// <param name="isCustomStyle">是否显示椭圆形窗体</param>
        public Form2(bool isCustomStyle)
        {
            this.isCustomStyle = isCustomStyle;
            InitializeComponent();
            if (isCustomStyle)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.BackColor = Color.AliceBlue;
            }
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            if (isCustomStyle)
            {
                System.Drawing.Drawing2D.GraphicsPath formShape =
                    new System.Drawing.Drawing2D.GraphicsPath();
                formShape.AddEllipse(0, 0, this.Width, this.Height);
                this.Region = new System.Drawing.Region(formShape);
            }
        }

        private void Form2_Activated(object sender, EventArgs e)
        {

        }
    }
}
