using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK04_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random rd = new Random();
            button1.Location = new System.Drawing.Point(rd.Next(0, this.ClientSize.Width-button1.Size.Width), rd.Next(0, this.ClientSize.Height-button1.Size.Height));
            button1.BackColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            button1.Location = new System.Drawing.Point(rd.Next(0, this.ClientSize.Width - button1.Size.Width), rd.Next(0, this.ClientSize.Height - button1.Size.Height));
            button1.BackColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
        }
    }
}
