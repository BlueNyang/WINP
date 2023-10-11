namespace WEEK06_01
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
            this.mainTextbox = new System.Windows.Forms.TextBox();
            this.openModal = new System.Windows.Forms.Button();
            this.openModeless = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.changeFont = new System.Windows.Forms.Button();
            this.tbColor = new System.Windows.Forms.Button();
            this.tbPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // mainTextbox
            // 
            this.mainTextbox.Location = new System.Drawing.Point(15, 13);
            this.mainTextbox.Multiline = true;
            this.mainTextbox.Name = "mainTextbox";
            this.mainTextbox.Size = new System.Drawing.Size(310, 135);
            this.mainTextbox.TabIndex = 0;
            // 
            // openModal
            // 
            this.openModal.Location = new System.Drawing.Point(15, 154);
            this.openModal.Name = "openModal";
            this.openModal.Size = new System.Drawing.Size(143, 59);
            this.openModal.TabIndex = 1;
            this.openModal.Text = "모달(Modal)\r\n대화상자 열기";
            this.openModal.UseVisualStyleBackColor = true;
            this.openModal.Click += new System.EventHandler(this.openModal_Click);
            // 
            // openModeless
            // 
            this.openModeless.Location = new System.Drawing.Point(182, 154);
            this.openModeless.Name = "openModeless";
            this.openModeless.Size = new System.Drawing.Size(143, 59);
            this.openModeless.TabIndex = 1;
            this.openModeless.Text = "모델리스(Modeless)\r\n대화상자 열기";
            this.openModeless.UseVisualStyleBackColor = true;
            this.openModeless.Click += new System.EventHandler(this.openModeless_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(15, 220);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(310, 42);
            this.openFile.TabIndex = 2;
            this.openFile.Text = ".txt 파일 열기";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(15, 268);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(310, 42);
            this.saveFile.TabIndex = 2;
            this.saveFile.Text = "파일 저장하기";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // changeFont
            // 
            this.changeFont.Location = new System.Drawing.Point(15, 316);
            this.changeFont.Name = "changeFont";
            this.changeFont.Size = new System.Drawing.Size(310, 42);
            this.changeFont.TabIndex = 2;
            this.changeFont.Text = "글꼴 변경하기";
            this.changeFont.UseVisualStyleBackColor = true;
            this.changeFont.Click += new System.EventHandler(this.changeFont_Click);
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(15, 364);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(310, 42);
            this.tbColor.TabIndex = 2;
            this.tbColor.Text = "텍스트 박스 색상 변경";
            this.tbColor.UseVisualStyleBackColor = true;
            this.tbColor.Click += new System.EventHandler(this.tbColor_Click);
            // 
            // tbPrint
            // 
            this.tbPrint.Location = new System.Drawing.Point(15, 412);
            this.tbPrint.Name = "tbPrint";
            this.tbPrint.Size = new System.Drawing.Size(310, 42);
            this.tbPrint.TabIndex = 2;
            this.tbPrint.Text = "텍스트 박스 내용 출력";
            this.tbPrint.UseVisualStyleBackColor = true;
            this.tbPrint.Click += new System.EventHandler(this.tbPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrint);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.changeFont);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.openModeless);
            this.Controls.Add(this.openModal);
            this.Controls.Add(this.mainTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "WEEK06_01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainTextbox;
        private System.Windows.Forms.Button openModal;
        private System.Windows.Forms.Button openModeless;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button changeFont;
        private System.Windows.Forms.Button tbColor;
        private System.Windows.Forms.Button tbPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

