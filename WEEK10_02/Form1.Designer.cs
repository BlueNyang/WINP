namespace WEEK10_02
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.logLabel = new System.Windows.Forms.Label();
            this.timesLabel = new System.Windows.Forms.Label();
            this.rootLabel = new System.Windows.Forms.Label();
            this.logTextbox = new System.Windows.Forms.TextBox();
            this.timesTextbox = new System.Windows.Forms.TextBox();
            this.rootTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Font = new System.Drawing.Font("굴림", 13.5F);
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(42, 45);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(468, 39);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("굴림", 13.5F);
            this.logLabel.Location = new System.Drawing.Point(37, 215);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(75, 27);
            this.logLabel.TabIndex = 1;
            this.logLabel.Text = "log 0";
            // 
            // timesLabel
            // 
            this.timesLabel.AutoSize = true;
            this.timesLabel.Font = new System.Drawing.Font("굴림", 13.5F);
            this.timesLabel.Location = new System.Drawing.Point(37, 350);
            this.timesLabel.Name = "timesLabel";
            this.timesLabel.Size = new System.Drawing.Size(38, 27);
            this.timesLabel.TabIndex = 2;
            this.timesLabel.Text = "0²";
            // 
            // rootLabel
            // 
            this.rootLabel.AutoSize = true;
            this.rootLabel.Font = new System.Drawing.Font("굴림", 13.5F);
            this.rootLabel.Location = new System.Drawing.Point(37, 486);
            this.rootLabel.Name = "rootLabel";
            this.rootLabel.Size = new System.Drawing.Size(43, 27);
            this.rootLabel.TabIndex = 3;
            this.rootLabel.Text = "√0";
            // 
            // logTextbox
            // 
            this.logTextbox.Font = new System.Drawing.Font("굴림", 13.5F);
            this.logTextbox.Location = new System.Drawing.Point(148, 212);
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.ReadOnly = true;
            this.logTextbox.Size = new System.Drawing.Size(362, 39);
            this.logTextbox.TabIndex = 4;
            this.logTextbox.TabStop = false;
            this.logTextbox.Text = "0";
            // 
            // timesTextbox
            // 
            this.timesTextbox.Font = new System.Drawing.Font("굴림", 13.5F);
            this.timesTextbox.Location = new System.Drawing.Point(148, 338);
            this.timesTextbox.Name = "timesTextbox";
            this.timesTextbox.ReadOnly = true;
            this.timesTextbox.Size = new System.Drawing.Size(362, 39);
            this.timesTextbox.TabIndex = 4;
            this.timesTextbox.TabStop = false;
            this.timesTextbox.Text = "0";
            // 
            // rootTextbox
            // 
            this.rootTextbox.Font = new System.Drawing.Font("굴림", 13.5F);
            this.rootTextbox.Location = new System.Drawing.Point(148, 483);
            this.rootTextbox.Name = "rootTextbox";
            this.rootTextbox.ReadOnly = true;
            this.rootTextbox.Size = new System.Drawing.Size(362, 39);
            this.rootTextbox.TabIndex = 4;
            this.rootTextbox.TabStop = false;
            this.rootTextbox.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 620);
            this.Controls.Add(this.rootTextbox);
            this.Controls.Add(this.timesTextbox);
            this.Controls.Add(this.logTextbox);
            this.Controls.Add(this.rootLabel);
            this.Controls.Add(this.timesLabel);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "WEEK10_02";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Label timesLabel;
        private System.Windows.Forms.Label rootLabel;
        private System.Windows.Forms.TextBox logTextbox;
        private System.Windows.Forms.TextBox timesTextbox;
        private System.Windows.Forms.TextBox rootTextbox;
    }
}

