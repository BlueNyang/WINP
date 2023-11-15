using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK10_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { MessageBox.Show(domainUpDown1.SelectedItem.ToString()); }
            catch (NullReferenceException) { MessageBox.Show("항목 미선택"); }
        }
    }
}
