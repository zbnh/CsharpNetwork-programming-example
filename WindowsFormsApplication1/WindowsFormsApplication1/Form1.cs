using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            try
            {
                string msymbol = symbol.Text;
                double mnumber1 = Convert.ToDouble(number1.Text);
                double mnumber2 = Convert.ToDouble(number2.Text);
                switch (msymbol)
                {
                    case "+":
                        result.Text = (mnumber1 + mnumber2).ToString();
                        break;
                    case "-":
                        result.Text = (mnumber1 - mnumber2).ToString();
                        break;
                    case "*":
                        result.Text = (mnumber1 * mnumber2).ToString();
                        break;
                    case "/":
                        if (mnumber2 == 0)
                        {
                            goto err;
                        }
                        result.Text = (mnumber1 / mnumber2).ToString();
                        break;
                    default:
                        err:
                        DialogResult dr = new DialogResult();
                        dr = MessageBox.Show("输入非法！", "Error", MessageBoxButtons.OK);
                        break;
                }
            }
            catch
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("输入非法或出现未知错误！", "Error", MessageBoxButtons.OK);
            }

        }
    }
}
