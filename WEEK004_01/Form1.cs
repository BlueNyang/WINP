using System;
using System.Drawing;
using System.Windows.Forms;

namespace WEEK04_01_1
{
    public partial class Form1 : Form
    {
        RandomValue rv = new RandomValue();
        public Form1()
        {
            InitializeComponent();
            rv.NewValue(this, button1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            rv.NewValue(this, button1);
        }
    }
}
