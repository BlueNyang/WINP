using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace WEEK06_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String m_strInfo = "";

        public String strInfo
        {
            get { return m_strInfo; }
            set
            {
                m_strInfo = value;
                label1.Text = m_strInfo + "종료";
            }
        }

        private void openModal_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.strText = "모달";
            form2.ShowDialog();
        }

        private void openModeless_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.strText = "모델리스";
            form2.Show();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "텍스트파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    mainTextbox.Text = File.ReadAllText(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Filter = "텍스트파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog1.FileName, mainTextbox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void changeFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            mainTextbox.Font = fontDialog1.Font;
            mainTextbox.ForeColor = fontDialog1.Color;
        }

        private void tbColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            mainTextbox.BackColor = colorDialog1.Color;
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            string text = mainTextbox.Text;
            Font printFont = mainTextbox.Font;
            e.Graphics.DrawString(text, printFont, Brushes.Black, 10, 10);
        }

        private void tbPrint_Click(object sender, EventArgs e)
        {
            PrinterSettings printer = new PrinterSettings();
            PrintDocument pd = new PrintDocument();
            printDialog1.PrinterSettings = printer;
            printDialog1.Document = pd;

            pd.PrintPage += new PrintPageEventHandler(PrintPage);
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
                pd.Print();
        }


    }
}
