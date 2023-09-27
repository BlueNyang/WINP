using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK06_01
{
    public partial class IdPwForm : Form
    {
        PhoneNumForm _pNForm;
        public IdPwForm(PhoneNumForm pnForm)
        {
            InitializeComponent();
            _pNForm = pnForm;
        }

        public IdPwForm()
        {
            InitializeComponent();
        }

        private void idPwForm_Load(object sender, EventArgs e)
        {
            ActiveControl = confirmButton;
        }

        private void idTextBox_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == "아이디를 입력해주세요.") idTextBox.Text = "";
        }

        private void idTextBox_Leave(object sender, EventArgs e)
        {
            if (idTextBox.Text == "") idTextBox.Text = "아이디를 입력해주세요";
        }

        private void pwTextBox_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == "비밀번호를 입력해주세요.") idTextBox.Text = "";
        }

        private void pwTextBox_Leave(object sender, EventArgs e)
        {
            if (idTextBox.Text == "") idTextBox.Text = "비밀번호를 입력해주세요";
        }
        private void button_OK()
        {
            if(idTextBox.Text.Equals("윈도우프로그래밍실습") && pwTextBox.Text.Equals("1234"))
            {
                _pNForm.LoginCheck = true;
                Close();
            }
            else
            {
                MessageBox.Show("아이디 또는 패스워드가 잘못되었습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                idTextBox.Text = "아이디를 입력해주세요.";
                pwTextBox.Text = "비밀번호를 입력해주세요.";
                pwTextBox.PasswordChar = '\0';
                confirmButton.Focus();
            }
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            button_OK();
        }

        private void wkuLinkLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(wkuLinkLabel.Text);
        }
    }
}
