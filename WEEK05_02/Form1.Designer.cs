namespace WEEK05_02
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.toComboBox = new System.Windows.Forms.Button();
            this.toListBox = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.rightCombo = new System.Windows.Forms.ComboBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toComboBox
            // 
            this.toComboBox.Location = new System.Drawing.Point(141, 13);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(75, 23);
            this.toComboBox.TabIndex = 0;
            this.toComboBox.Text = ">>";
            this.toComboBox.UseVisualStyleBackColor = true;
            this.toComboBox.Click += new System.EventHandler(this.toComboBox_Click);
            // 
            // toListBox
            // 
            this.toListBox.Location = new System.Drawing.Point(141, 53);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(75, 23);
            this.toListBox.TabIndex = 0;
            this.toListBox.Text = "<<";
            this.toListBox.UseVisualStyleBackColor = true;
            this.toListBox.Click += new System.EventHandler(this.toListBox_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 82);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(38, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "추가";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(96, 82);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(38, 23);
            this.delButton.TabIndex = 1;
            this.delButton.Text = "삭제";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // itemTextBox
            // 
            this.itemTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.itemTextBox.Location = new System.Drawing.Point(145, 82);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(203, 21);
            this.itemTextBox.TabIndex = 2;
            this.itemTextBox.Text = "아이템을 입력해주세요.";
            this.itemTextBox.Click += new System.EventHandler(this.itemTextBox_Click);
            this.itemTextBox.Leave += new System.EventHandler(this.itemTextBox_Leave);
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 12;
            this.itemListBox.Location = new System.Drawing.Point(12, 12);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.ScrollAlwaysVisible = true;
            this.itemListBox.Size = new System.Drawing.Size(122, 64);
            this.itemListBox.TabIndex = 3;
            // 
            // rightCombo
            // 
            this.rightCombo.FormattingEnabled = true;
            this.rightCombo.Location = new System.Drawing.Point(223, 13);
            this.rightCombo.Name = "rightCombo";
            this.rightCombo.Size = new System.Drawing.Size(121, 20);
            this.rightCombo.TabIndex = 4;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(54, 82);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(38, 23);
            this.modifyButton.TabIndex = 1;
            this.modifyButton.Text = "수정";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 111);
            this.Controls.Add(this.rightCombo);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.toListBox);
            this.Controls.Add(this.toComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "WEEK05_02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toComboBox;
        private System.Windows.Forms.Button toListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.ComboBox rightCombo;
        private System.Windows.Forms.Button modifyButton;
    }
}

