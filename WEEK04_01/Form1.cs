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
            NewLocationColor();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NewLocationColor();
        }

        internal void NewLocationColor()
        {
            Random rd = new Random();
            button1.Location = new Point(rd.Next(0, ClientSize.Width - button1.Width), rd.Next(0, ClientSize.Height - button1.Height));
            button1.BackColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
            button1.FlatAppearance.BorderColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
        }
    }
}
