using System;
using System.Windows.Forms;

namespace WEEK12
{
    public partial class Form1 : Form
    {
        MP3Player mp3Player;

        bool isScrolled = false;
        int trackBarBlankSize = 15;
        int trackBarLenth = 0;
        int trackBarMouseX = 0;

        public Form1()
        {
            InitializeComponent();

            mp3Player = new MP3Player();
            trackBarLenth = mp3_TrackBar.Size.Width - (trackBarBlankSize * 2);
        }

        private void mp3Timer_Tick(object sender, EventArgs e)
        {
            if (!mp3Player.isOpened) return;
            if (isScrolled == false)
                mp3_TrackBar.Value = mp3Player.GetPosition();   
            if (!mp3Player.loop && mp3Player.GetPosition() == mp3Player.GetLength())
                mp3Player.Stop();
            SetMusicTimer();
        }

        private void SetMusicTimer()
        {
            if (mp3Player.isOpened)
            {
                TimeSpan t = TimeSpan.FromMilliseconds(mp3Player.GetPosition());
                lb_MusicTimer.Text = $@"{t.Minutes:00} : {t.Seconds:00} : {t.Milliseconds:000}";
            }
        }

        private void bt_play_Click(object sender, EventArgs e)
        {
            mp3Player.Play();
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            mp3Player.Stop();
        }

        private void bt_pause_Click(object sender, EventArgs e)
        {
            mp3Player.Pause();
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Mp3 File|*.mp3";

                open.InitialDirectory = Environment.CurrentDirectory;

                if(open.ShowDialog() == DialogResult.OK)
                {
                    string filename = open.FileName;

                    mp3Player.Open(filename);
                    mp3_TrackBar.Maximum = mp3Player.GetLength();
                    mp3Timer.Enabled = true;
                }
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            mp3Timer.Enabled = false;
            mp3_TrackBar.Value = 0;
            mp3Player.Close();
        }

        private void SetPositionByMouse(int position)
        {
            if (position < 0 || position > trackBarLenth)
                return;

            float rate = (float)position / trackBarLenth;
            mp3_TrackBar.Value = (int)(rate * (mp3_TrackBar.Maximum - mp3_TrackBar.Minimum));

        }

        private void mp3_TrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            isScrolled = true;
            trackBarMouseX = e.X - trackBarBlankSize;
            SetPositionByMouse(trackBarMouseX);
        }

        private void mp3_TrackBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isScrolled)
            {
                trackBarMouseX = e.X - trackBarBlankSize;
                SetPositionByMouse(trackBarMouseX);
            }
        }

        private void mp3_TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (mp3Player.isOpened)
            {
                string status = mp3Player.GetStatus();

                mp3Player.Seek(mp3_TrackBar.Value);

                if (status == "playing") mp3Player.Play();
                else mp3Player.Pause();
            }
            isScrolled = false;
        }
    }
}
