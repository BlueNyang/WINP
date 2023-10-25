namespace WEEK07_01
{
    partial class Form2
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
            this.button_OK = new System.Windows.Forms.Button();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_PW = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_PW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(225, 70);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 0;
            this.button_OK.TabStop = false;
            this.button_OK.Text = "확인";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            this.button_OK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_OK_KeyDown);
            // 
            // textBox_ID
            // 
            this.textBox_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_ID.Location = new System.Drawing.Point(53, 10);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(251, 21);
            this.textBox_ID.TabIndex = 1;
            this.textBox_ID.TabStop = false;
            this.textBox_ID.Text = "아이디를 입력해주세요.";
            this.textBox_ID.Click += new System.EventHandler(this.textBox_ID_Click);
            this.textBox_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ID_KeyDown);
            this.textBox_ID.Leave += new System.EventHandler(this.textBox_ID_Leave);
            // 
            // textBox_PW
            // 
            this.textBox_PW.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_PW.Location = new System.Drawing.Point(53, 37);
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.Size = new System.Drawing.Size(251, 21);
            this.textBox_PW.TabIndex = 2;
            this.textBox_PW.TabStop = false;
            this.textBox_PW.Text = "비밀번호를 입력해주세요.";
            this.textBox_PW.Click += new System.EventHandler(this.textBox_PW_Click);
            this.textBox_PW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_PW_KeyDown);
            this.textBox_PW.Leave += new System.EventHandler(this.textBox_PW_Leave);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(13, 13);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(24, 12);
            this.label_ID.TabIndex = 3;
            this.label_ID.Text = "ID :";
            // 
            // label_PW
            // 
            this.label_PW.AutoSize = true;
            this.label_PW.Location = new System.Drawing.Point(13, 44);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(31, 12);
            this.label_PW.TabIndex = 4;
            this.label_PW.Text = "PW :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 105);
            this.Controls.Add(this.label_PW);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.textBox_PW);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.button_OK);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_PW;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_PW;
    }
}