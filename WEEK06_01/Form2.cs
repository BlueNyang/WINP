using System;
using System.Windows.Forms;

namespace WEEK06_01
{
    public partial class Form2 : Form
    {
        private String _strText = "";
        private Form1 form1 = null;
        public String strText
        {
            get { return _strText; }
            set { _strText = value + "대화상자"; }
        }

        public Form2(Form1 _form1)
        {
            form1 = _form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Text = _strText;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            form1.strInfo = _strText;
            Close();
        }
    }
}
