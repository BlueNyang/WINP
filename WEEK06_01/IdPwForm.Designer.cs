namespace WEEK06_01
{
    partial class IdPwForm
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.pwLabel = new System.Windows.Forms.Label();
            this.wkuLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("굴림", 9F);
            this.confirmButton.Location = new System.Drawing.Point(184, 95);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "확인";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("굴림", 9F);
            this.idTextBox.Location = new System.Drawing.Point(15, 29);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(244, 21);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.Text = "아이디를 입력해주세요.";
            this.idTextBox.Click += new System.EventHandler(this.idTextBox_Click);
            this.idTextBox.Leave += new System.EventHandler(this.idTextBox_Leave);
            // 
            // pwTextBox
            // 
            this.pwTextBox.Font = new System.Drawing.Font("굴림", 9F);
            this.pwTextBox.Location = new System.Drawing.Point(15, 68);
            this.pwTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.Size = new System.Drawing.Size(244, 21);
            this.pwTextBox.TabIndex = 2;
            this.pwTextBox.Text = "비밀번호를 입력해주세요.";
            this.pwTextBox.Click += new System.EventHandler(this.pwTextBox_Click);
            this.pwTextBox.Leave += new System.EventHandler(this.pwTextBox_Leave);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("굴림", 9F);
            this.idLabel.Location = new System.Drawing.Point(13, 13);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(16, 12);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Font = new System.Drawing.Font("굴림", 9F);
            this.pwLabel.Location = new System.Drawing.Point(13, 53);
            this.pwLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(23, 12);
            this.pwLabel.TabIndex = 4;
            this.pwLabel.Text = "PW";
            // 
            // wkuLinkLabel
            // 
            this.wkuLinkLabel.AutoSize = true;
            this.wkuLinkLabel.Font = new System.Drawing.Font("굴림", 9F);
            this.wkuLinkLabel.Location = new System.Drawing.Point(12, 128);
            this.wkuLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wkuLinkLabel.Name = "wkuLinkLabel";
            this.wkuLinkLabel.Size = new System.Drawing.Size(143, 12);
            this.wkuLinkLabel.TabIndex = 5;
            this.wkuLinkLabel.TabStop = true;
            this.wkuLinkLabel.Text = "https://www.wku.ac.kr/";
            this.wkuLinkLabel.Click += new System.EventHandler(this.wkuLinkLabel_Click);
            // 
            // IdPwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 149);
            this.Controls.Add(this.wkuLinkLabel);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.pwTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.confirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IdPwForm";
            this.Text = "WEEK05_01";
            this.Load += new System.EventHandler(this.idPwForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox pwTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.LinkLabel wkuLinkLabel;
    }
}

