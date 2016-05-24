using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextBoxToolTipExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBoxUserName.MaxLength = 10;
            textBoxPassword.PasswordChar = '*';
            textBoxPwdMessage.ReadOnly = true;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            toolTip1.SetToolTip(textBoxUserName, "用户名不能超过10个字符，而且只能用汉字、字母和数字");
            toolTip1.SetToolTip(textBoxPassword, "密码不能少于5个字符，而且只能用字母和数字");
            toolTip1.SetToolTip(buttonOK, "单击显示用户输入的姓名和密码");
            //出现错误时，让错误图标一直闪烁
            errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPwdMessage.Text = textBoxPassword.Text;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("用户名：" + textBoxUserName.Text +
                "，密码：" + textBoxPassword.Text, "提示",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxUserName_Validating(object sender, CancelEventArgs e)
        {
            ValidatingText(textBoxUserName, "用户名包含了非汉字、字母和数字的字符");
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            //验证第1个条件
            bool isValid = ValidatingText(textBoxPassword, "密码包含了非汉字、字母和数字的字符");
            //当第1个条件验证成功后，再验证第2个条件
            if (isValid)
            {
                if (textBoxPassword.Text.Length < 5)
                {
                    errorProvider1.SetError(textBoxPassword, "密码长度小于5");
                }
                else
                {
                    errorProvider1.SetError(textBoxPassword, string.Empty);
                }
            }
        }

        /// <summary>
        /// 验证指定的控件，并返回验证是否成功
        /// </summary>
        /// <param name="textbox">控件名</param>
        /// <param name="errorMessage">验证失败时的错误信息</param>
        /// <returns>验证成功为true，否则为false</returns>
        private bool ValidatingText(TextBox textbox, string errorMessage)
        {
            string s = textbox.Text;
            bool isValid = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i]) == false)
                {
                    errorProvider1.SetError(textbox, errorMessage);
                    isValid = false;
                    break;
                }
            }
            if (isValid) errorProvider1.SetError(textbox, string.Empty);
            return isValid;
        }
    }
}
