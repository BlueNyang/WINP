namespace WEEK04_02
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
            this.mainButton = new System.Windows.Forms.Button();
            this.backColorGroup = new System.Windows.Forms.GroupBox();
            this.backBlue = new System.Windows.Forms.RadioButton();
            this.backGreen = new System.Windows.Forms.RadioButton();
            this.backRed = new System.Windows.Forms.RadioButton();
            this.textAlignGroup = new System.Windows.Forms.GroupBox();
            this.textRight = new System.Windows.Forms.RadioButton();
            this.textCenter = new System.Windows.Forms.RadioButton();
            this.textLeft = new System.Windows.Forms.RadioButton();
            this.banButton = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.backColorGroup.SuspendLayout();
            this.textAlignGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainButton
            // 
            this.mainButton.Font = new System.Drawing.Font("굴림", 18F);
            this.mainButton.Location = new System.Drawing.Point(40, 12);
            this.mainButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(220, 50);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "버튼";
            this.mainButton.UseVisualStyleBackColor = true;
            // 
            // backColorGroup
            // 
            this.backColorGroup.Controls.Add(this.backBlue);
            this.backColorGroup.Controls.Add(this.backGreen);
            this.backColorGroup.Controls.Add(this.backRed);
            this.backColorGroup.Location = new System.Drawing.Point(12, 75);
            this.backColorGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backColorGroup.Name = "backColorGroup";
            this.backColorGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backColorGroup.Size = new System.Drawing.Size(135, 95);
            this.backColorGroup.TabIndex = 1;
            this.backColorGroup.TabStop = false;
            this.backColorGroup.Text = "배경색";
            // 
            // backBlue
            // 
            this.backBlue.AutoSize = true;
            this.backBlue.Location = new System.Drawing.Point(7, 67);
            this.backBlue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBlue.Name = "backBlue";
            this.backBlue.Size = new System.Drawing.Size(47, 16);
            this.backBlue.TabIndex = 2;
            this.backBlue.TabStop = true;
            this.backBlue.Text = "파랑";
            this.backBlue.UseVisualStyleBackColor = true;
            // 
            // backGreen
            // 
            this.backGreen.AutoSize = true;
            this.backGreen.Location = new System.Drawing.Point(7, 44);
            this.backGreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backGreen.Name = "backGreen";
            this.backGreen.Size = new System.Drawing.Size(47, 16);
            this.backGreen.TabIndex = 1;
            this.backGreen.TabStop = true;
            this.backGreen.Text = "초록";
            this.backGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backGreen.UseVisualStyleBackColor = true;
            // 
            // backRed
            // 
            this.backRed.AutoSize = true;
            this.backRed.Location = new System.Drawing.Point(7, 21);
            this.backRed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backRed.Name = "backRed";
            this.backRed.Size = new System.Drawing.Size(47, 16);
            this.backRed.TabIndex = 0;
            this.backRed.TabStop = true;
            this.backRed.Text = "빨강";
            this.backRed.UseVisualStyleBackColor = true;
            // 
            // textAlignGroup
            // 
            this.textAlignGroup.Controls.Add(this.textRight);
            this.textAlignGroup.Controls.Add(this.textCenter);
            this.textAlignGroup.Controls.Add(this.textLeft);
            this.textAlignGroup.Location = new System.Drawing.Point(157, 75);
            this.textAlignGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textAlignGroup.Name = "textAlignGroup";
            this.textAlignGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textAlignGroup.Size = new System.Drawing.Size(135, 95);
            this.textAlignGroup.TabIndex = 2;
            this.textAlignGroup.TabStop = false;
            this.textAlignGroup.Text = "텍스트 정렬";
            // 
            // textRight
            // 
            this.textRight.AutoSize = true;
            this.textRight.Location = new System.Drawing.Point(7, 67);
            this.textRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textRight.Name = "textRight";
            this.textRight.Size = new System.Drawing.Size(59, 16);
            this.textRight.TabIndex = 2;
            this.textRight.TabStop = true;
            this.textRight.Text = "오른쪽";
            this.textRight.UseVisualStyleBackColor = true;
            // 
            // textCenter
            // 
            this.textCenter.AutoSize = true;
            this.textCenter.Location = new System.Drawing.Point(7, 44);
            this.textCenter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCenter.Name = "textCenter";
            this.textCenter.Size = new System.Drawing.Size(47, 16);
            this.textCenter.TabIndex = 1;
            this.textCenter.TabStop = true;
            this.textCenter.Text = "중앙";
            this.textCenter.UseVisualStyleBackColor = true;
            // 
            // textLeft
            // 
            this.textLeft.AutoSize = true;
            this.textLeft.Location = new System.Drawing.Point(7, 21);
            this.textLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textLeft.Name = "textLeft";
            this.textLeft.Size = new System.Drawing.Size(47, 16);
            this.textLeft.TabIndex = 0;
            this.textLeft.TabStop = true;
            this.textLeft.Text = "왼쪽";
            this.textLeft.UseVisualStyleBackColor = true;
            // 
            // banButton
            // 
            this.banButton.AutoSize = true;
            this.banButton.Location = new System.Drawing.Point(12, 185);
            this.banButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(104, 16);
            this.banButton.TabIndex = 3;
            this.banButton.Text = "버튼 사용 금지";
            this.banButton.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 218);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "버튼 숨기기";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 246);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.textAlignGroup);
            this.Controls.Add(this.backColorGroup);
            this.Controls.Add(this.mainButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "WEEK04_02";
            this.backColorGroup.ResumeLayout(false);
            this.backColorGroup.PerformLayout();
            this.textAlignGroup.ResumeLayout(false);
            this.textAlignGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.GroupBox backColorGroup;
        private System.Windows.Forms.RadioButton backRed;
        private System.Windows.Forms.GroupBox textAlignGroup;
        private System.Windows.Forms.RadioButton backBlue;
        private System.Windows.Forms.RadioButton backGreen;
        private System.Windows.Forms.RadioButton textLeft;
        private System.Windows.Forms.RadioButton textRight;
        private System.Windows.Forms.RadioButton textCenter;
        private System.Windows.Forms.CheckBox banButton;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

