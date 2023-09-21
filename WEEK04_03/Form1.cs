using System;
using System.Drawing;
using System.Windows.Forms;

namespace WEEK04_03
{
    public partial class Form1 : Form
    {
        //bool useApply = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void ColorChanged(object sender, EventArgs e)
        {
            //if (useApply == false)
            {
                RadioButton R = sender as RadioButton;
                if (R == backRed) mainButton.BackColor = Color.Red;
                if (R == backGreen) mainButton.BackColor = Color.Green;
                if (R == backBlue) mainButton.BackColor = Color.Blue;
            }
        }
        private void AlignChanged(object sender, EventArgs e)
        {
            //if (useApply == false)
            {
                RadioButton R = sender as RadioButton;
                if (R == textLeft) mainButton.TextAlign = ContentAlignment.MiddleLeft;
                if (R == textCenter) mainButton.TextAlign = ContentAlignment.MiddleCenter;
                if (R == textRight) mainButton.TextAlign = ContentAlignment.MiddleRight;
            }
        }

        private void banButton_CheckedChanged(object sender, EventArgs e)
        {
            //if (useApply == false)
            {
                if (((CheckBox)sender).Checked) mainButton.Enabled = false;
                else mainButton.Enabled = true;
            }
        }

        private void hideButton_CheckedChanged(object sender, EventArgs e)
        {
            //if (useApply == false)
            {
                if (((CheckBox)sender).Checked) mainButton.Visible = false;
                else mainButton.Visible = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
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

        private void boolApply_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                applyBtn.Enabled = true;
                //useApply = true;
                this.backRed.CheckedChanged -= new EventHandler(this.ColorChanged);
                this.backGreen.CheckedChanged -= new EventHandler(this.ColorChanged);
                this.backBlue.CheckedChanged -= new EventHandler(this.ColorChanged);
                this.textLeft.CheckedChanged -= new EventHandler(this.AlignChanged);
                this.textRight.CheckedChanged -= new EventHandler(this.AlignChanged);
                this.textCenter.CheckedChanged -= new EventHandler(this.AlignChanged);
                Refresh();
            }
            else
            {
                applyBtn.Enabled = false;
                //useApply = false;
                this.backRed.CheckedChanged += new EventHandler(this.ColorChanged);
                this.backGreen.CheckedChanged += new EventHandler(this.ColorChanged);
                this.backBlue.CheckedChanged += new EventHandler(this.ColorChanged);
                this.textLeft.CheckedChanged += new EventHandler(this.AlignChanged);
                this.textRight.CheckedChanged += new EventHandler(this.AlignChanged);
                this.textCenter.CheckedChanged += new EventHandler(this.AlignChanged);
                Refresh();
            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            //useApply = false;
            object obj = backRed.Checked ? backRed : backGreen.Checked ? backGreen : backBlue;
            ColorChanged(obj, e);
            obj = textLeft.Checked ? textLeft : textCenter.Checked ? textCenter : textRight;
            AlignChanged(obj, e);
            //useApply = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("종료하시겠습니까?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            string btnColor = mainButton.BackColor == SystemColors.Control ? "기본" : mainButton.BackColor == Color.Red ? "빨간" : mainButton.BackColor == Color.Green ? "초록" : "파란";
            string btnAlign = mainButton.TextAlign == ContentAlignment.MiddleLeft ? "왼쪽" : mainButton.TextAlign == ContentAlignment.MiddleCenter ? "가운데" : "오른쪽";
            MessageBox.Show("현재 버튼은 " + btnColor + "색, " + btnAlign + "정렬입니다\n", "버튼", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
