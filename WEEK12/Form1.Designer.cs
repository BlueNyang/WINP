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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mp3_TrackBar = new System.Windows.Forms.TrackBar();
            this.lb_MusicTimer = new System.Windows.Forms.Label();
            this.bt_play = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_pause = new System.Windows.Forms.Button();
            this.bt_open = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.mp3Timer = new System.Windows.Forms.Timer(this.components);
            this.lb_musicTime = new System.Windows.Forms.Label();
            this.cb_loop = new System.Windows.Forms.CheckBox();
            this.tb_volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.volume_num = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.mp3_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_num)).BeginInit();
            this.SuspendLayout();
            // 
            // mp3_TrackBar
            // 
            this.mp3_TrackBar.AutoSize = false;
            this.mp3_TrackBar.Location = new System.Drawing.Point(10, 29);
            this.mp3_TrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.mp3_TrackBar.Name = "mp3_TrackBar";
            this.mp3_TrackBar.Size = new System.Drawing.Size(343, 33);
            this.mp3_TrackBar.TabIndex = 0;
            this.mp3_TrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mp3_TrackBar_MouseDown);
            this.mp3_TrackBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mp3_TrackBar_MouseMove);
            this.mp3_TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mp3_TrackBar_MouseUp);
            // 
            // lb_MusicTimer
            // 
            this.lb_MusicTimer.AutoSize = true;
            this.lb_MusicTimer.Font = new System.Drawing.Font("굴림", 9F);
            this.lb_MusicTimer.Location = new System.Drawing.Point(233, 16);
            this.lb_MusicTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MusicTimer.Name = "lb_MusicTimer";
            this.lb_MusicTimer.Size = new System.Drawing.Size(55, 12);
            this.lb_MusicTimer.TabIndex = 1;
            this.lb_MusicTimer.Text = "00:00:000";
            // 
            // bt_play
            // 
            this.bt_play.Location = new System.Drawing.Point(26, 67);
            this.bt_play.Margin = new System.Windows.Forms.Padding(2);
            this.bt_play.Name = "bt_play";
            this.bt_play.Size = new System.Drawing.Size(62, 56);
            this.bt_play.TabIndex = 2;
            this.bt_play.Text = "재생\r\n▶";
            this.bt_play.UseVisualStyleBackColor = true;
            this.bt_play.Click += new System.EventHandler(this.bt_play_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(104, 67);
            this.bt_stop.Margin = new System.Windows.Forms.Padding(2);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(62, 56);
            this.bt_stop.TabIndex = 2;
            this.bt_stop.Text = "정지\r\n■";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_pause
            // 
            this.bt_pause.Location = new System.Drawing.Point(179, 67);
            this.bt_pause.Margin = new System.Windows.Forms.Padding(2);
            this.bt_pause.Name = "bt_pause";
            this.bt_pause.Size = new System.Drawing.Size(62, 56);
            this.bt_pause.TabIndex = 2;
            this.bt_pause.Text = "일지정지\r\n||";
            this.bt_pause.UseVisualStyleBackColor = true;
            this.bt_pause.Click += new System.EventHandler(this.bt_pause_Click);
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(255, 67);
            this.bt_open.Margin = new System.Windows.Forms.Padding(2);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(88, 25);
            this.bt_open.TabIndex = 3;
            this.bt_open.Text = "파일 열기";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(255, 97);
            this.bt_close.Margin = new System.Windows.Forms.Padding(2);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(88, 27);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "종료";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // mp3Timer
            // 
            this.mp3Timer.Tick += new System.EventHandler(this.mp3Timer_Tick);
            // 
            // lb_musicTime
            // 
            this.lb_musicTime.AutoSize = true;
            this.lb_musicTime.Font = new System.Drawing.Font("굴림", 9F);
            this.lb_musicTime.Location = new System.Drawing.Point(288, 16);
            this.lb_musicTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_musicTime.Name = "lb_musicTime";
            this.lb_musicTime.Size = new System.Drawing.Size(65, 12);
            this.lb_musicTime.TabIndex = 1;
            this.lb_musicTime.Text = "/ 00:00:000";
            // 
            // cb_loop
            // 
            this.cb_loop.AutoSize = true;
            this.cb_loop.Location = new System.Drawing.Point(26, 128);
            this.cb_loop.Name = "cb_loop";
            this.cb_loop.Size = new System.Drawing.Size(72, 16);
            this.cb_loop.TabIndex = 4;
            this.cb_loop.Text = "반복재생";
            this.cb_loop.UseVisualStyleBackColor = true;
            this.cb_loop.CheckedChanged += new System.EventHandler(this.cb_loop_CheckedChanged);
            // 
            // tb_volume
            // 
            this.tb_volume.Location = new System.Drawing.Point(363, 6);
            this.tb_volume.Maximum = 100;
            this.tb_volume.Name = "tb_volume";
            this.tb_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb_volume.Size = new System.Drawing.Size(45, 125);
            this.tb_volume.TabIndex = 5;
            this.tb_volume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tb_volume.Scroll += new System.EventHandler(this.tb_volume_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "음량 :";
            // 
            // volume_num
            // 
            this.volume_num.Location = new System.Drawing.Point(363, 137);
            this.volume_num.Name = "volume_num";
            this.volume_num.Size = new System.Drawing.Size(45, 21);
            this.volume_num.TabIndex = 7;
            this.volume_num.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.volume_num.ValueChanged += new System.EventHandler(this.volume_num_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 162);
            this.Controls.Add(this.volume_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_volume);
            this.Controls.Add(this.cb_loop);
            this.Controls.Add(this.lb_MusicTimer);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.bt_pause);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_play);
            this.Controls.Add(this.lb_musicTime);
            this.Controls.Add(this.mp3_TrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MP3 Player";
            ((System.ComponentModel.ISupportInitialize)(this.mp3_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_num)).EndInit();
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
        private System.Windows.Forms.Label lb_musicTime;
        private System.Windows.Forms.CheckBox cb_loop;
        private System.Windows.Forms.TrackBar tb_volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown volume_num;
    }
}

