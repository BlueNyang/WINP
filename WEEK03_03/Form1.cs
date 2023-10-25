using System;
using System.Windows.Forms;

namespace WEEK03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 _Form = new Form2();

            _Form.Show();
        }
    }
}
