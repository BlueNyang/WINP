﻿namespace WEEK07_01
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
            this.button_OK.Location = new System.Drawing.Point(321, 105);
            this.button_OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(107, 34);
            this.button_OK.TabIndex = 0;
            this.button_OK.TabStop = false;
            this.button_OK.Text = "확인";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // textBox_ID
            // 
            this.textBox_ID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_ID.Location = new System.Drawing.Point(76, 15);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(357, 28);
            this.textBox_ID.TabIndex = 1;
            this.textBox_ID.TabStop = false;
            this.textBox_ID.Text = "아이디를 입력해주세요.";
            this.textBox_ID.Click += new System.EventHandler(this.textBox_ID_Click);
            this.textBox_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ID_KeyDown);
            this.textBox_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_ID_KeyUp);
            this.textBox_ID.Leave += new System.EventHandler(this.textBox_ID_Leave);
            // 
            // textBox_PW
            // 
            this.textBox_PW.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_PW.Location = new System.Drawing.Point(76, 56);
            this.textBox_PW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.Size = new System.Drawing.Size(357, 28);
            this.textBox_PW.TabIndex = 2;
            this.textBox_PW.TabStop = false;
            this.textBox_PW.Text = "비밀번호를 입력해주세요.";
            this.textBox_PW.Click += new System.EventHandler(this.textBox_PW_Click);
            this.textBox_PW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_PW_KeyDown);
            this.textBox_PW.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_PW_KeyUp);
            this.textBox_PW.Leave += new System.EventHandler(this.textBox_PW_Leave);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(19, 20);
            this.label_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(34, 18);
            this.label_ID.TabIndex = 3;
            this.label_ID.Text = "ID :";
            // 
            // label_PW
            // 
            this.label_PW.AutoSize = true;
            this.label_PW.Location = new System.Drawing.Point(19, 66);
            this.label_PW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(46, 18);
            this.label_PW.TabIndex = 4;
            this.label_PW.Text = "PW :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 158);
            this.Controls.Add(this.label_PW);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.textBox_PW);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.button_OK);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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