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
                if (textBox_ID.Text.Equals("아이디를 입력해주세요.") || textBox_ID.Text.Equals(""))
                {
                    MessageBox.Show("ID를 입력하세요.");
                    textBox_ID.Focus();
                    ID_Click();
                }
                else if (textBox_PW.Text.Equals("비밀번호를 입력해주세요.") || textBox_PW.Text.Equals(""))
                {
                    MessageBox.Show("PW를 입력하세요.");
                    textBox_PW.Focus();
                    PW_Click();
                }
                else
                {
                    MessageBox.Show("ID 또는 PW가 잘못 되었습니다.");

                    textBox_ID.Text = "아이디를 입력해주세요.";
                    textBox_ID.ForeColor = SystemColors.WindowFrame;
                    textBox_PW.Text = "비밀번호를 입력해주세요.";
                    textBox_PW.PasswordChar = '\0';
                    textBox_PW.ForeColor = SystemColors.WindowFrame;
                    textBox_ID.Focus();
                    ID_Click();
                }
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            bt_OK();
        }

        private void ID_Click()
        {
            if (textBox_ID.Text == "아이디를 입력해주세요.")
            {
                textBox_ID.Text = "";
                textBox_ID.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox_ID_Click(object sender, EventArgs e)
        {
            ID_Click();
        }

        private void textBox_ID_Leave(object sender, EventArgs e)
        {
            if(textBox_ID.Text == "")
            {
                textBox_ID.Text = "아이디를 입력해주세요.";
                textBox_ID.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void textBox_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Enter) bt_OK();
            else if (e.KeyData == (Keys.Shift | Keys.Tab)) ActiveControl = button_OK;
            else if (e.KeyCode == Keys.Tab)
            {
                PW_Click();
                textBox_PW.Focus();
            }
        }

        private void PW_Click()
        {
            if (textBox_PW.Text == "비밀번호를 입력해주세요.")
            {
                textBox_PW.Text = "";
                textBox_PW.PasswordChar = '●';
                textBox_PW.ForeColor = SystemColors.WindowText;
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
                textBox_PW.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void textBox_PW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Enter) bt_OK();
            else if (e.KeyData == (Keys.Shift | Keys.Tab))
            {
                ID_Click();
                textBox_ID.Focus();
            }
            else if (e.KeyCode == Keys.Tab) ActiveControl = button_OK;
        }

        private void button_OK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Enter) bt_OK();
            else if (e.KeyData == (Keys.Shift | Keys.Tab))
            {
                PW_Click();
                textBox_PW.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                ID_Click();
                textBox_ID.Focus();
            }
        }

    }
}
