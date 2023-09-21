namespace WEEK04_03_01
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
            this.mainButton = new System.Windows.Forms.Button();
            this.backColorGroup = new System.Windows.Forms.GroupBox();
            this.blueValue = new System.Windows.Forms.TextBox();
            this.greenValue = new System.Windows.Forms.TextBox();
            this.redValue = new System.Windows.Forms.TextBox();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.applyBtn = new System.Windows.Forms.Button();
            this.boolApply = new System.Windows.Forms.CheckBox();
            this.textAlignGroup.SuspendLayout();
            this.backColorGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // exitForm
            // 
            this.exitForm.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.exitForm.Location = new System.Drawing.Point(452, 421);
            this.exitForm.Name = "exitForm";
            this.exitForm.Size = new System.Drawing.Size(132, 46);
            this.exitForm.TabIndex = 20;
            this.exitForm.Text = "Exit";
            this.exitForm.UseVisualStyleBackColor = true;
            this.exitForm.Click += new System.EventHandler(this.exitForm_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.resetButton.Location = new System.Drawing.Point(314, 421);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(132, 46);
            this.resetButton.TabIndex = 21;
            this.resetButton.Text = "Reset All";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.AutoSize = true;
            this.hideButton.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.hideButton.Location = new System.Drawing.Point(38, 403);
            this.hideButton.Margin = new System.Windows.Forms.Padding(2);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(161, 34);
            this.hideButton.TabIndex = 19;
            this.hideButton.Text = "Hide Button";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.CheckedChanged += new System.EventHandler(this.hideButton_CheckedChanged);
            // 
            // banButton
            // 
            this.banButton.AutoSize = true;
            this.banButton.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.banButton.Location = new System.Drawing.Point(38, 373);
            this.banButton.Margin = new System.Windows.Forms.Padding(2);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(187, 34);
            this.banButton.TabIndex = 18;
            this.banButton.Text = "Disalbe Button";
            this.banButton.UseVisualStyleBackColor = true;
            this.banButton.CheckedChanged += new System.EventHandler(this.banButton_CheckedChanged);
            // 
            // textAlignGroup
            // 
            this.textAlignGroup.Controls.Add(this.textRight);
            this.textAlignGroup.Controls.Add(this.textCenter);
            this.textAlignGroup.Controls.Add(this.textLeft);
            this.textAlignGroup.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.textAlignGroup.Location = new System.Drawing.Point(314, 130);
            this.textAlignGroup.Margin = new System.Windows.Forms.Padding(2);
            this.textAlignGroup.Name = "textAlignGroup";
            this.textAlignGroup.Padding = new System.Windows.Forms.Padding(2);
            this.textAlignGroup.Size = new System.Drawing.Size(270, 222);
            this.textAlignGroup.TabIndex = 17;
            this.textAlignGroup.TabStop = false;
            this.textAlignGroup.Text = "텍스트 정렬";
            // 
            // textRight
            // 
            this.textRight.AutoSize = true;
            this.textRight.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.textRight.Location = new System.Drawing.Point(14, 156);
            this.textRight.Margin = new System.Windows.Forms.Padding(2);
            this.textRight.Name = "textRight";
            this.textRight.Size = new System.Drawing.Size(104, 34);
            this.textRight.TabIndex = 2;
            this.textRight.TabStop = true;
            this.textRight.Text = "오른쪽";
            this.textRight.UseVisualStyleBackColor = true;
            this.textRight.CheckedChanged += new System.EventHandler(this.AlignChanged);
            // 
            // textCenter
            // 
            this.textCenter.AutoSize = true;
            this.textCenter.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.textCenter.Location = new System.Drawing.Point(14, 99);
            this.textCenter.Margin = new System.Windows.Forms.Padding(2);
            this.textCenter.Name = "textCenter";
            this.textCenter.Size = new System.Drawing.Size(82, 34);
            this.textCenter.TabIndex = 1;
            this.textCenter.TabStop = true;
            this.textCenter.Text = "중앙";
            this.textCenter.UseVisualStyleBackColor = true;
            this.textCenter.CheckedChanged += new System.EventHandler(this.AlignChanged);
            // 
            // textLeft
            // 
            this.textLeft.AutoSize = true;
            this.textLeft.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.textLeft.Location = new System.Drawing.Point(14, 42);
            this.textLeft.Margin = new System.Windows.Forms.Padding(2);
            this.textLeft.Name = "textLeft";
            this.textLeft.Size = new System.Drawing.Size(82, 34);
            this.textLeft.TabIndex = 0;
            this.textLeft.TabStop = true;
            this.textLeft.Text = "왼쪽";
            this.textLeft.UseVisualStyleBackColor = true;
            this.textLeft.CheckedChanged += new System.EventHandler(this.AlignChanged);
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.SystemColors.Control;
            this.mainButton.Font = new System.Drawing.Font("맑은 고딕", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainButton.Location = new System.Drawing.Point(80, 16);
            this.mainButton.Margin = new System.Windows.Forms.Padding(2);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(440, 100);
            this.mainButton.TabIndex = 15;
            this.mainButton.Text = "버   튼";
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // backColorGroup
            // 
            this.backColorGroup.Controls.Add(this.blueValue);
            this.backColorGroup.Controls.Add(this.greenValue);
            this.backColorGroup.Controls.Add(this.redValue);
            this.backColorGroup.Controls.Add(this.blueTrackBar);
            this.backColorGroup.Controls.Add(this.greenTrackBar);
            this.backColorGroup.Controls.Add(this.redTrackBar);
            this.backColorGroup.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.backColorGroup.Location = new System.Drawing.Point(24, 130);
            this.backColorGroup.Margin = new System.Windows.Forms.Padding(2);
            this.backColorGroup.Name = "backColorGroup";
            this.backColorGroup.Padding = new System.Windows.Forms.Padding(2);
            this.backColorGroup.Size = new System.Drawing.Size(270, 222);
            this.backColorGroup.TabIndex = 16;
            this.backColorGroup.TabStop = false;
            this.backColorGroup.Text = "배경색";
            // 
            // blueValue
            // 
            this.blueValue.Location = new System.Drawing.Point(203, 148);
            this.blueValue.Name = "blueValue";
            this.blueValue.Size = new System.Drawing.Size(62, 31);
            this.blueValue.TabIndex = 5;
            this.blueValue.Text = "0";
            this.blueValue.TextChanged += new System.EventHandler(this.valueTextBox_Changed);
            // 
            // greenValue
            // 
            this.greenValue.Location = new System.Drawing.Point(203, 88);
            this.greenValue.Name = "greenValue";
            this.greenValue.Size = new System.Drawing.Size(62, 31);
            this.greenValue.TabIndex = 4;
            this.greenValue.Text = "0";
            this.greenValue.TextChanged += new System.EventHandler(this.valueTextBox_Changed);
            // 
            // redValue
            // 
            this.redValue.Location = new System.Drawing.Point(203, 27);
            this.redValue.Name = "redValue";
            this.redValue.Size = new System.Drawing.Size(62, 31);
            this.redValue.TabIndex = 3;
            this.redValue.Text = "0";
            this.redValue.TextChanged += new System.EventHandler(this.valueTextBox_Changed);
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.Location = new System.Drawing.Point(14, 148);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(194, 69);
            this.blueTrackBar.TabIndex = 2;
            this.blueTrackBar.Scroll += new System.EventHandler(this.colorTrackBar_Scroll);
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Location = new System.Drawing.Point(14, 88);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(194, 69);
            this.greenTrackBar.TabIndex = 1;
            this.greenTrackBar.Scroll += new System.EventHandler(this.colorTrackBar_Scroll);
            // 
            // redTrackBar
            // 
            this.redTrackBar.Location = new System.Drawing.Point(14, 27);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(194, 69);
            this.redTrackBar.TabIndex = 0;
            this.redTrackBar.Scroll += new System.EventHandler(this.colorTrackBar_Scroll);
            // 
            // applyBtn
            // 
            this.applyBtn.Enabled = false;
            this.applyBtn.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.applyBtn.Location = new System.Drawing.Point(314, 373);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(270, 43);
            this.applyBtn.TabIndex = 23;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // boolApply
            // 
            this.boolApply.AutoSize = true;
            this.boolApply.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.boolApply.Location = new System.Drawing.Point(38, 434);
            this.boolApply.Name = "boolApply";
            this.boolApply.Size = new System.Drawing.Size(244, 34);
            this.boolApply.TabIndex = 22;
            this.boolApply.Text = "Enable Apply Button";
            this.boolApply.UseVisualStyleBackColor = true;
            this.boolApply.CheckedChanged += new System.EventHandler(this.boolApply_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 480);
            this.Controls.Add(this.exitForm);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.textAlignGroup);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.backColorGroup);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.boolApply);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.textAlignGroup.ResumeLayout(false);
            this.textAlignGroup.PerformLayout();
            this.backColorGroup.ResumeLayout(false);
            this.backColorGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
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
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.GroupBox backColorGroup;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.CheckBox boolApply;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.TextBox blueValue;
        private System.Windows.Forms.TextBox greenValue;
        private System.Windows.Forms.TextBox redValue;
    }
}

