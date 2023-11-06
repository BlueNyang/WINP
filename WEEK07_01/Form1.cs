﻿using System;
using System.Windows.Forms;

namespace WEEK07_01
{
    public partial class Form1 : Form
    {
        private bool m_blLoginCheck = false;

        public bool LoginCheck
        {
            get { return m_blLoginCheck; }
            set { m_blLoginCheck = value; }
        }

        private void MouseWheelEvent(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
                MessageBox.Show("MouseWheel 아래로 이동");
            else
                MessageBox.Show("MouseWheel 위로 이돌");
        }

        public Form1()
        {
            InitializeComponent();
            MouseWheel += new MouseEventHandler(MouseWheelEvent);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 _Form = new Form2(this);
            _Form.ShowDialog();

            if (!m_blLoginCheck) Close();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MessageBox.Show("X : " + e.X + "Y : " + e.Y);
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(MousePosition);
        }

        private void 새파일NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(새파일NToolStripMenuItem.Text);
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(열기OToolStripMenuItem.Text);
        }

        private void 닫기CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(닫기CToolStripMenuItem.Text);
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(저장SToolStripMenuItem.Text);
        }

        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(다른이름으로저장AToolStripMenuItem.Text);
        }

        private void 인쇄PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(인쇄PToolStripMenuItem.Text);
        }

        private void 미리보기VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(미리보기VToolStripMenuItem.Text);
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 잘라내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(잘라내기TToolStripMenuItem.Text);
        }

        private void 복사CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(복사CToolStripMenuItem.Text);
        }

        private void 붙여넣기PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(붙여넣기PToolStripMenuItem.Text);
        }

        private void 프로그램정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(프로그램정보AToolStripMenuItem.Text);
        }

        private void 실행취소UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(실행취소UToolStripMenuItem.Text);
        }

        private void 삭제DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(삭제DToolStripMenuItem.Text);
        }

        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(모두선택AToolStripMenuItem.Text);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool baseResult = base.ProcessCmdKey(ref msg, keyData);

            if(keyData == Keys.F1)
                MessageBox.Show("F1키 누름.");
            else if(keyData == (Keys.Control | Keys.F1))
                MessageBox.Show("Ctrl + F1키 누름");

            return baseResult;
        }

    }
}
