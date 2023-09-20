namespace WEEK04_03
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
            this.exitForm = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.CheckBox();
            this.banButton = new System.Windows.Forms.CheckBox();
            this.textAlignGroup = new System.Windows.Forms.GroupBox();
            this.textRight = new System.Windows.Forms.RadioButton();
            this.textCenter = new System.Windows.Forms.RadioButton();
            this.textLeft = new System.Windows.Forms.RadioButton();
            this.backColorGroup = new System.Windows.Forms.GroupBox();
            this.backBlue = new System.Windows.Forms.RadioButton();
            this.backGreen = new System.Windows.Forms.RadioButton();
            this.backRed = new System.Windows.Forms.RadioButton();
            this.mainButton = new System.Windows.Forms.Button();
            this.boolApply = new System.Windows.Forms.CheckBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.textAlignGroup.SuspendLayout();
            this.backColorGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitForm
            // 
            this.exitForm.Location = new System.Drawing.Point(226, 216);
            this.exitForm.Name = "exitForm";
            this.exitForm.Size = new System.Drawing.Size(66, 23);
            this.exitForm.TabIndex = 11;
            this.exitForm.Text = "종료";
            this.exitForm.UseVisualStyleBackColor = true;
            this.exitForm.Click += new System.EventHandler(this.exitForm_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(157, 216);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(66, 23);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "초기화";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.AutoSize = true;
            this.hideButton.Location = new System.Drawing.Point(12, 200);
            this.hideButton.Margin = new System.Windows.Forms.Padding(2);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(88, 16);
            this.hideButton.TabIndex = 10;
            this.hideButton.Text = "버튼 숨기기";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.CheckedChanged += new System.EventHandler(this.hideButton_CheckedChanged);
            // 
            // banButton
            // 
            this.banButton.AutoSize = true;
            this.banButton.Location = new System.Drawing.Point(12, 180);
            this.banButton.Margin = new System.Windows.Forms.Padding(2);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(104, 16);
            this.banButton.TabIndex = 9;
            this.banButton.Text = "버튼 사용 금지";
            this.banButton.UseVisualStyleBackColor = true;
            this.banButton.CheckedChanged += new System.EventHandler(this.banButton_CheckedChanged);
            // 
            // textAlignGroup
            // 
            this.textAlignGroup.Controls.Add(this.textRight);
            this.textAlignGroup.Controls.Add(this.textCenter);
            this.textAlignGroup.Controls.Add(this.textLeft);
            this.textAlignGroup.Location = new System.Drawing.Point(157, 74);
            this.textAlignGroup.Margin = new System.Windows.Forms.Padding(2);
            this.textAlignGroup.Name = "textAlignGroup";
            this.textAlignGroup.Padding = new System.Windows.Forms.Padding(2);
            this.textAlignGroup.Size = new System.Drawing.Size(135, 95);
            this.textAlignGroup.TabIndex = 8;
            this.textAlignGroup.TabStop = false;
            this.textAlignGroup.Text = "텍스트 정렬";
            // 
            // textRight
            // 
            this.textRight.AutoSize = true;
            this.textRight.Location = new System.Drawing.Point(7, 67);
            this.textRight.Margin = new System.Windows.Forms.Padding(2);
            this.textRight.Name = "textRight";
            this.textRight.Size = new System.Drawing.Size(59, 16);
            this.textRight.TabIndex = 2;
            this.textRight.TabStop = true;
            this.textRight.Text = "오른쪽";
            this.textRight.UseVisualStyleBackColor = true;
            this.textRight.CheckedChanged += new System.EventHandler(this.AlignChanged);
            // 
            // textCenter
            // 
            this.textCenter.AutoSize = true;
            this.textCenter.Location = new System.Drawing.Point(7, 44);
            this.textCenter.Margin = new System.Windows.Forms.Padding(2);
            this.textCenter.Name = "textCenter";
            this.textCenter.Size = new System.Drawing.Size(47, 16);
            this.textCenter.TabIndex = 1;
            this.textCenter.TabStop = true;
            this.textCenter.Text = "중앙";
            this.textCenter.UseVisualStyleBackColor = true;
            this.textCenter.CheckedChanged += new System.EventHandler(this.AlignChanged);
            // 
            // textLeft
            // 
            this.textLeft.AutoSize = true;
            this.textLeft.Location = new System.Drawing.Point(7, 21);
            this.textLeft.Margin = new System.Windows.Forms.Padding(2);
            this.textLeft.Name = "textLeft";
            this.textLeft.Size = new System.Drawing.Size(47, 16);
            this.textLeft.TabIndex = 0;
            this.textLeft.TabStop = true;
            this.textLeft.Text = "왼쪽";
            this.textLeft.UseVisualStyleBackColor = true;
            this.textLeft.CheckedChanged += new System.EventHandler(this.AlignChanged);
            // 
            // backColorGroup
            // 
            this.backColorGroup.Controls.Add(this.backBlue);
            this.backColorGroup.Controls.Add(this.backGreen);
            this.backColorGroup.Controls.Add(this.backRed);
            this.backColorGroup.Location = new System.Drawing.Point(12, 74);
            this.backColorGroup.Margin = new System.Windows.Forms.Padding(2);
            this.backColorGroup.Name = "backColorGroup";
            this.backColorGroup.Padding = new System.Windows.Forms.Padding(2);
            this.backColorGroup.Size = new System.Drawing.Size(135, 95);
            this.backColorGroup.TabIndex = 7;
            this.backColorGroup.TabStop = false;
            this.backColorGroup.Text = "배경색";
            // 
            // backBlue
            // 
            this.backBlue.AutoSize = true;
            this.backBlue.Location = new System.Drawing.Point(7, 67);
            this.backBlue.Margin = new System.Windows.Forms.Padding(2);
            this.backBlue.Name = "backBlue";
            this.backBlue.Size = new System.Drawing.Size(47, 16);
            this.backBlue.TabIndex = 2;
            this.backBlue.TabStop = true;
            this.backBlue.Text = "파랑";
            this.backBlue.UseVisualStyleBackColor = true;
            this.backBlue.CheckedChanged += new System.EventHandler(this.ColorChanged);
            // 
            // backGreen
            // 
            this.backGreen.AutoSize = true;
            this.backGreen.Location = new System.Drawing.Point(7, 44);
            this.backGreen.Margin = new System.Windows.Forms.Padding(2);
            this.backGreen.Name = "backGreen";
            this.backGreen.Size = new System.Drawing.Size(47, 16);
            this.backGreen.TabIndex = 1;
            this.backGreen.TabStop = true;
            this.backGreen.Text = "초록";
            this.backGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backGreen.UseVisualStyleBackColor = true;
            this.backGreen.CheckedChanged += new System.EventHandler(this.ColorChanged);
            // 
            // backRed
            // 
            this.backRed.AutoSize = true;
            this.backRed.Location = new System.Drawing.Point(7, 21);
            this.backRed.Margin = new System.Windows.Forms.Padding(2);
            this.backRed.Name = "backRed";
            this.backRed.Size = new System.Drawing.Size(47, 16);
            this.backRed.TabIndex = 0;
            this.backRed.TabStop = true;
            this.backRed.Text = "빨강";
            this.backRed.UseVisualStyleBackColor = true;
            this.backRed.CheckedChanged += new System.EventHandler(this.ColorChanged);
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.SystemColors.Control;
            this.mainButton.Font = new System.Drawing.Font("굴림", 18F);
            this.mainButton.Location = new System.Drawing.Point(40, 11);
            this.mainButton.Margin = new System.Windows.Forms.Padding(2);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(220, 50);
            this.mainButton.TabIndex = 6;
            this.mainButton.Text = "버튼";
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // boolApply
            // 
            this.boolApply.AutoSize = true;
            this.boolApply.Location = new System.Drawing.Point(12, 220);
            this.boolApply.Name = "boolApply";
            this.boolApply.Size = new System.Drawing.Size(96, 16);
            this.boolApply.TabIndex = 13;
            this.boolApply.Text = "적용버튼사용";
            this.boolApply.UseVisualStyleBackColor = true;
            this.boolApply.CheckedChanged += new System.EventHandler(this.boolApply_CheckedChanged);
            // 
            // applyBtn
            // 
            this.applyBtn.Enabled = false;
            this.applyBtn.Location = new System.Drawing.Point(157, 180);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(135, 30);
            this.applyBtn.TabIndex = 14;
            this.applyBtn.Text = "적용";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(304, 246);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.boolApply);
            this.Controls.Add(this.exitForm);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.textAlignGroup);
            this.Controls.Add(this.backColorGroup);
            this.Controls.Add(this.mainButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.textAlignGroup.ResumeLayout(false);
            this.textAlignGroup.PerformLayout();
            this.backColorGroup.ResumeLayout(false);
            this.backColorGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitForm;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.CheckBox hideButton;
        private System.Windows.Forms.CheckBox banButton;
        private System.Windows.Forms.GroupBox textAlignGroup;
        private System.Windows.Forms.RadioButton textRight;
        private System.Windows.Forms.RadioButton textCenter;
        private System.Windows.Forms.RadioButton textLeft;
        private System.Windows.Forms.GroupBox backColorGroup;
        private System.Windows.Forms.RadioButton backBlue;
        private System.Windows.Forms.RadioButton backGreen;
        private System.Windows.Forms.RadioButton backRed;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.CheckBox boolApply;
        private System.Windows.Forms.Button applyBtn;
    }
}

