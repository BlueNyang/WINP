namespace WEEK06_01
{
    partial class PhoneNumForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.phoneNumMaskTxt = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phoneNumMaskTxt
            // 
            this.phoneNumMaskTxt.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phoneNumMaskTxt.Location = new System.Drawing.Point(12, 12);
            this.phoneNumMaskTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneNumMaskTxt.Mask = "(999)9000-0000";
            this.phoneNumMaskTxt.Name = "phoneNumMaskTxt";
            this.phoneNumMaskTxt.Size = new System.Drawing.Size(289, 35);
            this.phoneNumMaskTxt.TabIndex = 0;
            this.phoneNumMaskTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneNumMaskTxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.phoneNumMaskTxt_MaskInputRejected);
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Font = new System.Drawing.Font("굴림", 9F);
            this.phoneNumLabel.Location = new System.Drawing.Point(12, 55);
            this.phoneNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(157, 12);
            this.phoneNumLabel.TabIndex = 1;
            this.phoneNumLabel.Text = "휴대전화번호를 입력하시오.";
            // 
            // PhoneNumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 76);
            this.Controls.Add(this.phoneNumLabel);
            this.Controls.Add(this.phoneNumMaskTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PhoneNumForm";
            this.Text = "전화번호 확인";
            this.Load += new System.EventHandler(this.phoneNumForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox phoneNumMaskTxt;
        private System.Windows.Forms.Label phoneNumLabel;
    }
}