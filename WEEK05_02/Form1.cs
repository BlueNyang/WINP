using System;
using System.Drawing;
using System.Windows.Forms;

namespace WEEK05_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toComboBox_Click(object sender, EventArgs e)
        {
            if (itemListBox.SelectedIndex > -1)
            {
                rightCombo.Items.Add(itemListBox.SelectedItem);
                itemListBox.Items.Remove(itemListBox.SelectedItem);
            }
            else MessageBox.Show("콤보박스로 보낼 아이템을 선택해주세요", "항목미선택", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void toListBox_Click(object sender, EventArgs e)
        {
            if (rightCombo.SelectedIndex > -1)
            {
                itemListBox.Items.Add(rightCombo.SelectedItem);
                rightCombo.Items.Remove(rightCombo.SelectedItem);
                rightCombo.Text = "";
            }
            else MessageBox.Show("리스트박스로 보낼 아이템을 선택해주세요", "항목미선택", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(itemTextBox.Text != "" && itemTextBox.Text != "아이템을 입력해주세요.")
            {
                itemListBox.Items.Add(itemTextBox.Text);
                itemTextBox.Text = "아이템을 입력해주세요.";
                itemTextBox.ForeColor = SystemColors.WindowFrame;
            }
            else MessageBox.Show("추가할 아이템을 선택해주세요", "항목미선택", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (addButton.Text == "완료")
            {
                addButton.Text = "추가";
                delButton.Enabled = true;
                modifyButton.Enabled = true;
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (itemListBox.SelectedIndex > -1)
                itemListBox.Items.Remove(itemListBox.SelectedItem);
            else MessageBox.Show("삭제할 아이템을 선택해주세요.", "항목미선택", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void itemTextBox_Click(object sender, EventArgs e)
        {
            if (itemTextBox.Text == "아이템을 입력해주세요.")
            {
                itemTextBox.Text = "";
                itemTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void itemTextBox_Leave(object sender, EventArgs e)
        {
            if (itemTextBox.Text == "")
            {
                itemTextBox.Text = "아이템을 입력해주세요.";
                itemTextBox.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if(itemListBox.SelectedIndex > -1)
            {
                itemTextBox.Text = itemListBox.SelectedItem.ToString();
                itemTextBox.ForeColor = SystemColors.WindowText;
                itemListBox.Items.Remove(itemListBox.SelectedItem);
                addButton.Text = "완료";
                delButton.Enabled = false;
                modifyButton.Enabled = false;
            }
            else MessageBox.Show("수정할 아이템을 선택해주세요.", "항목미선택", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
