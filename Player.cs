using LibVLCSharp.Shared;
using PlayerFF.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PlayerFF
{
    public partial class Player : UserControl
    {
        Form1 f;
        PlayerController pc;

        LibVLC vlc;
        MediaPlayer mp;

        public static bool menuOpen = true;
        public static bool isPlaying;
        public static bool wasPaused;
        public static bool isDown;
        public static int fcount;

        public static List<string>? fList;

        TimeSpan time;
        long pausedTime;
        TimeSpan length;

        public Player(Form1 f)
        {
            if (!DesignMode)
            {
                Core.Initialize();
            }
            InitializeComponent();
            this.f = f;
            InitPlayer();
        }

        private void InitPlayer()
        {
            vlc = new LibVLC();
            mp = new MediaPlayer(vlc);
            videoView1.MediaPlayer = mp;
            pc = new PlayerController(vlc, mp);
        }

        private void Player_Load(object sender, EventArgs e)
        {
            btnPlay.Click += OnClick;
            btnPause.Click += OnClick;
            btnStop.Click += OnClick;
            btnBack.Click += OnClick;
            btnNext.Click += OnClick;
            PlayerControlsState(false);
        }
        #region Player state
        private void PlayerControlsState(bool state)
        {
            foreach (Button c in pnlMenu.Controls)
            {
                c.Enabled = state;
            }
            barTime.Enabled = state;
            barVol.Enabled = state;
        }

        public void SetState(bool state)
        {
            isPlaying = state;
            if (isPlaying)
            {
                btnPlay.Enabled = false;
                btnPause.Enabled = true;
            }
            else if (!isPlaying)
            {
                pausedTime = mp.Time;
                wasPaused = true;
                btnPlay.Enabled = true;
                btnPause.Enabled = false;
            }
        }
        #endregion
        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuOpen = !menuOpen;
            if (menuOpen)
            {
                pnlMenu.Visible = true;
                btnMenu.ForeColor = Color.Red;
            }
            else if (!menuOpen)
            {
                pnlMenu.Visible = false;
                btnMenu.ForeColor = Color.White;
            }
        }
        #region Drag and drop files
        private void videoView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void videoView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileArr = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (fileArr != null && fileArr.Length != 0)
            {
                fList = fileArr.ToList();
                Array.Clear(fileArr);
                PlayerControlsState(true);
            }
        }
        #endregion
        #region Player Button event
        private void OnClick(object sender, EventArgs e)
        {
            var name = ((sender as Button)?.Name);
            if (name == "btnPlay")
            {
                SetState(true);
                pc.Play(fList[fcount]);
                mediaTimer.Start();
            }
            else if (name == "btnPause")
            {
                SetState(false);
                pc.Pause();
                mediaTimer.Stop();
            }
            else if (name == "btnStop")
            {
                pc.Stop();
                PlayerControlsState(false);
                fcount = 0;
                fList.Clear();
                isPlaying = false;
                wasPaused = false;
                lblTime.Text = "--:--:--";
                lblLength.Text = "--:--:--";
            }
            else if (name == "btnBack")
            {
                if (fcount == 0)
                {
                    fcount = (fList.Count - 1);
                    pc.Play(fList[fcount]);
                    mediaTimer.Start();
                }
                else
                {
                    fcount--;
                    pc.Play(fList[fcount]);
                    mediaTimer.Start();
                }
            }
            else if (name == "btnNext")
            {
                if (fcount == (fList.Count - 1))
                {
                    fcount = 0;
                    pc.Play(fList[fcount]);
                    mediaTimer.Start();
                }
                else
                {
                    fcount++;
                    pc.Play(fList[fcount]);
                    mediaTimer.Start();
                }
            }
        }
        #endregion
        #region Time trackbar event
        private void mediaTimer_Tick(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                if (wasPaused)
                {
                    mp.Time = pausedTime;
                    wasPaused = false;
                }
                time = TimeSpan.FromMilliseconds(mp.Time);
                lblTime.Text = time.ToString(@"hh\:mm\:ss");

                length = TimeSpan.FromMilliseconds(mp.Length);
                lblLength.Text = length.ToString(@"hh\:mm\:ss");

                barTime.Maximum = mp.Length / 1000;
                barTime.Value = mp.Time / 1000;
            }
        }

        private void barTime_MouseClick(object sender, MouseEventArgs e)
        {
            mp.Time = (long)barTime.Value * 1000;
            int b = (int)mp.Time / 1000;
            int d = b / 60;
            b = b - d * 60;
        }

        private void barTime_ValueChanged(object sender, EventArgs e)
        {
            if (isDown)
            {
                mp.Time = (long)barTime.Value * 1000;
                int b = (int)mp.Time / 1000;
                int d = b / 60;
                b = b - d * 60;
            }
        }

        private void barTime_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void barTime_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }
        #endregion
    }
}
