namespace WEEK12
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
            this.components = new System.ComponentModel.Container();
            this.mp3_TrackBar = new System.Windows.Forms.TrackBar();
            this.lb_MusicTimer = new System.Windows.Forms.Label();
            this.bt_play = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_pause = new System.Windows.Forms.Button();
            this.bt_open = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.mp3Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mp3_TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mp3_TrackBar
            // 
            this.mp3_TrackBar.AutoSize = false;
            this.mp3_TrackBar.Location = new System.Drawing.Point(15, 44);
            this.mp3_TrackBar.Name = "mp3_TrackBar";
            this.mp3_TrackBar.Size = new System.Drawing.Size(490, 50);
            this.mp3_TrackBar.TabIndex = 0;
            this.mp3_TrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mp3_TrackBar_MouseDown);
            this.mp3_TrackBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mp3_TrackBar_MouseMove);
            this.mp3_TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mp3_TrackBar_MouseUp);
            // 
            // lb_MusicTimer
            // 
            this.lb_MusicTimer.AutoSize = true;
            this.lb_MusicTimer.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_MusicTimer.Location = new System.Drawing.Point(373, 17);
            this.lb_MusicTimer.Name = "lb_MusicTimer";
            this.lb_MusicTimer.Size = new System.Drawing.Size(117, 24);
            this.lb_MusicTimer.TabIndex = 1;
            this.lb_MusicTimer.Text = "00:00:000";
            // 
            // bt_play
            // 
            this.bt_play.Location = new System.Drawing.Point(37, 101);
            this.bt_play.Name = "bt_play";
            this.bt_play.Size = new System.Drawing.Size(88, 84);
            this.bt_play.TabIndex = 2;
            this.bt_play.Text = "재생\r\n▶";
            this.bt_play.UseVisualStyleBackColor = true;
            this.bt_play.Click += new System.EventHandler(this.bt_play_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(149, 101);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(88, 84);
            this.bt_stop.TabIndex = 2;
            this.bt_stop.Text = "정지\r\n■";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_pause
            // 
            this.bt_pause.Location = new System.Drawing.Point(256, 101);
            this.bt_pause.Name = "bt_pause";
            this.bt_pause.Size = new System.Drawing.Size(88, 84);
            this.bt_pause.TabIndex = 2;
            this.bt_pause.Text = "일지정지\r\n||";
            this.bt_pause.UseVisualStyleBackColor = true;
            this.bt_pause.Click += new System.EventHandler(this.bt_pause_Click);
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(364, 101);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(126, 38);
            this.bt_open.TabIndex = 3;
            this.bt_open.Text = "파일 열기";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(364, 145);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(126, 40);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "종료";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // mp3Timer
            // 
            this.mp3Timer.Tick += new System.EventHandler(this.mp3Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 211);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.bt_pause);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_play);
            this.Controls.Add(this.lb_MusicTimer);
            this.Controls.Add(this.mp3_TrackBar);
            this.Name = "Form1";
            this.Text = "MP3 Player";
            ((System.ComponentModel.ISupportInitialize)(this.mp3_TrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar mp3_TrackBar;
        private System.Windows.Forms.Label lb_MusicTimer;
        private System.Windows.Forms.Button bt_play;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_pause;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Timer mp3Timer;
    }
}

