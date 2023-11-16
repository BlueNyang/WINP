using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK10_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown1.Value;
            logLabel.Text = $"log {d} = ";
            logTextbox.Text = Math.Log10((double)d).ToString();
            timesLabel.Text = $"({d})² = ";
            timesTextbox.Text = Math.Pow((double)d, 2).ToString();
            rootLabel.Text = $"√ {d} = ";
            rootTextbox.Text = Math.Sqrt((double)d).ToString();
        }
    }
}
