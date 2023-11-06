using System;
using System.Drawing;
using System.Windows.Forms;

namespace WEEK07_01
{
    public partial class Form2 : Form
    {
        private Form1 _Form1;
        private string ID = "윈도우프로그래밍";
        private string PW = "1234";

        public Form2(Form1 form1)
        {
            _Form1 = form1;
            InitializeComponent();
            ActiveControl = button_OK;
        }

        private void bt_OK()
        {
            if (textBox_ID.Text.Equals(ID) && textBox_PW.Text.Equals(PW))
            {
                _Form1.LoginCheck = true;
                Close();
            }
            else
            {
                MessageBox.Show("ID 또는 PW가 잘못 되었습니다.");

                textBox_ID.Text = "아이디를 입력해주세요.";
                textBox_PW.Text = "비밀번호를 입력해주세요.";
                textBox_PW.PasswordChar = '\0';
                textBox_ID.Focus();
                ID_Click();
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            bt_OK();
        }

        private void ID_Click()
        {
            if (textBox_ID.Text == "아이디를 입력해주세요.") textBox_ID.Text = "";
        }

        private void textBox_ID_Click(object sender, EventArgs e)
        {
            ID_Click();
        }

        private void textBox_ID_Leave(object sender, EventArgs e)
        {
            if(textBox_ID.Text == "") textBox_ID.Text = "아이디를 입력해주세요.";
        }
        private void textBox_ID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                textBox_PW.Focus();
                PW_Click();
            }

        }

        private void textBox_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                e.SuppressKeyPress = true;
        }

        private void PW_Click()
        {
            if (textBox_PW.Text == "비밀번호를 입력해주세요.")
            {
                textBox_PW.Text = "";
                textBox_PW.PasswordChar = '*';
            }
        }
        private void textBox_PW_Click(object sender, EventArgs e)
        {
            PW_Click();
        }

        private void textBox_PW_Leave(object sender, EventArgs e)
        {
            if(textBox_PW.Text == "")
            {
                textBox_PW.Text = "비밀번호를 입력해주세요.";
                textBox_PW.PasswordChar = '\0';
            }
        }
        private void textBox_PW_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) bt_OK();
            else if (e.KeyData == (Keys.Shift | Keys.Tab))
            {
                textBox_ID.Focus();
                ID_Click();
            }
        }

        private void textBox_PW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                e.SuppressKeyPress = true;
        }
    }
}
