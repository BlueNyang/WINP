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
    public partial class PhoneNumForm : Form
    {
        private Boolean m_blLoginCheck = false;

        public Boolean LoginCheck
        {
            get { return m_blLoginCheck; }
            set { m_blLoginCheck = value; }
        }
        public PhoneNumForm()
        {
            InitializeComponent();
        }

        private void phoneNumForm_Load(object sender, EventArgs e)
        {
            IdPwForm idPwForm = new IdPwForm(this);
            idPwForm.ShowDialog();
            if (!m_blLoginCheck) this.Close();
        }

        private void phoneNumMaskTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (phoneNumMaskTxt.MaskCompleted)
                phoneNumLabel.Text = "휴대전화 입력완료";
            else
                phoneNumLabel.Text = "번호형식이 맞지 않습니다.";
        }
    }
}
