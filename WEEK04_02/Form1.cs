using System;
using System.Drawing;
using System.Windows.Forms;

namespace WEEK04_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backRed_CheckedChanged(object sender, EventArgs e)
        {
            mainButton.BackColor = Color.Red;
        }
        private void backGreen_CheckedChanged(object sender, EventArgs args)
        {
            mainButton.BackColor= Color.Green;
        }
        private void backBlue_CheckedChanged(object sender, EventArgs args)
        {
            mainButton.BackColor = Color.Blue;
        }

        private void textLeft_CheckedChanged(object sender, EventArgs e)
        {
            mainButton.TextAlign = ContentAlignment.MiddleLeft;
        }
        private void textCenter_CheckedChanged(Object sender, EventArgs e)
        {
            mainButton.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void textRight_CheckedChanged(Object sender, EventArgs e)
        {
            mainButton.TextAlign = ContentAlignment.MiddleRight;
        }

        private void banButton_CheckedChanged(Object sender, EventArgs args)
        {
            if (((CheckBox)sender).Checked) mainButton.Enabled = false;
            else mainButton.Enabled = true;
        }
        private void hideButton_CheckedChanged(Object sender,EventArgs args)
        {
            if (((CheckBox)sender).Checked) mainButton.Visible = false;
            else mainButton.Visible = true;
        }

        private void resetButton_Click(Object sender, EventArgs args)
        {
            if (backRed.Checked) backRed.Checked = false;
            else if (backGreen.Checked) backGreen.Checked = false;
            else if (backBlue.Checked) backBlue.Checked = false;

            if (textLeft.Checked) textLeft.Checked = false;
            else if (textRight.Checked) textRight.Checked = false;
            else if (textCenter.Checked) textCenter.Checked = false;

            mainButton.BackColor = SystemColors.Control;
            mainButton.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void exitForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
