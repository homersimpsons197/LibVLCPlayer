namespace PlayerFF
{
    partial class Player
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlDown = new CustomControls.Controls._Panel();
            tpnlDown = new TableLayoutPanel();
            lblLength = new Label();
            btnMenu = new Button();
            barTime = new ColorSlider.ColorSlider();
            barVol = new ColorSlider.ColorSlider();
            lblTime = new Label();
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            pnlMenu = new Panel();
            btnPause = new CustomControls.RJControls._Button();
            btnStop = new CustomControls.RJControls._Button();
            btnBack = new CustomControls.RJControls._Button();
            btnNext = new CustomControls.RJControls._Button();
            btnPlay = new CustomControls.RJControls._Button();
            mediaTimer = new System.Windows.Forms.Timer(components);
            _Button1 = new CustomControls.RJControls._Button();
            pnlDown.SuspendLayout();
            tpnlDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDown
            // 
            pnlDown.BackColor = Color.FromArgb(37, 37, 37);
            pnlDown.BorderColor = Color.White;
            pnlDown.BorderSize = 1;
            pnlDown.Controls.Add(tpnlDown);
            pnlDown.Dock = DockStyle.Bottom;
            pnlDown.EndColor = Color.Empty;
            pnlDown.GradientAngle = 0;
            pnlDown.Location = new Point(0, 448);
            pnlDown.Margin = new Padding(0);
            pnlDown.Name = "pnlDown";
            pnlDown.Padding = new Padding(1);
            pnlDown.Size = new Size(800, 35);
            pnlDown.StartColor = Color.Empty;
            pnlDown.TabIndex = 0;
            pnlDown.Transparent1 = 150;
            pnlDown.Transparent2 = 150;
            // 
            // tpnlDown
            // 
            tpnlDown.ColumnCount = 5;
            tpnlDown.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tpnlDown.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tpnlDown.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tpnlDown.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tpnlDown.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tpnlDown.Controls.Add(lblLength, 4, 0);
            tpnlDown.Controls.Add(btnMenu, 0, 0);
            tpnlDown.Controls.Add(barTime, 2, 0);
            tpnlDown.Controls.Add(barVol, 3, 0);
            tpnlDown.Controls.Add(lblTime, 1, 0);
            tpnlDown.Dock = DockStyle.Fill;
            tpnlDown.Location = new Point(2, 2);
            tpnlDown.Margin = new Padding(0);
            tpnlDown.Name = "tpnlDown";
            tpnlDown.RowCount = 1;
            tpnlDown.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tpnlDown.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tpnlDown.Size = new Size(796, 31);
            tpnlDown.TabIndex = 0;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLength.ForeColor = Color.Red;
            lblLength.Location = new Point(736, 6);
            lblLength.Margin = new Padding(15, 6, 0, 0);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(44, 17);
            lblLength.TabIndex = 4;
            lblLength.Text = "--:--:--";
            // 
            // btnMenu
            // 
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.Red;
            btnMenu.Location = new Point(3, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(69, 25);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // barTime
            // 
            barTime.BackColor = Color.Transparent;
            barTime.BarPenColorBottom = Color.FromArgb(87, 94, 110);
            barTime.BarPenColorTop = Color.FromArgb(55, 60, 74);
            barTime.BorderRoundRectSize = new Size(8, 8);
            barTime.Dock = DockStyle.Fill;
            barTime.ElapsedInnerColor = Color.FromArgb(192, 0, 0);
            barTime.ElapsedPenColorBottom = Color.Red;
            barTime.ElapsedPenColorTop = Color.FromArgb(255, 128, 128);
            barTime.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point);
            barTime.ForeColor = Color.White;
            barTime.LargeChange = new decimal(new int[] { 5, 0, 0, 0 });
            barTime.Location = new Point(150, 0);
            barTime.Margin = new Padding(0, 0, 20, 0);
            barTime.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            barTime.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            barTime.Name = "barTime";
            barTime.ScaleDivisions = new decimal(new int[] { 10, 0, 0, 0 });
            barTime.ScaleSubDivisions = new decimal(new int[] { 5, 0, 0, 0 });
            barTime.ShowDivisionsText = true;
            barTime.ShowSmallScale = false;
            barTime.Size = new Size(451, 31);
            barTime.SmallChange = new decimal(new int[] { 1, 0, 0, 0 });
            barTime.TabIndex = 1;
            barTime.Text = "colorSlider1";
            barTime.ThumbInnerColor = Color.FromArgb(192, 0, 0);
            barTime.ThumbPenColor = Color.Maroon;
            barTime.ThumbRoundRectSize = new Size(16, 16);
            barTime.ThumbSize = new Size(16, 16);
            barTime.TickAdd = 0F;
            barTime.TickColor = Color.White;
            barTime.TickDivide = 0F;
            barTime.TickStyle = TickStyle.None;
            barTime.Value = new decimal(new int[] { 0, 0, 0, 0 });
            barTime.ValueChanged += barTime_ValueChanged;
            barTime.MouseClick += barTime_MouseClick;
            barTime.MouseDown += barTime_MouseDown;
            barTime.MouseUp += barTime_MouseUp;
            // 
            // barVol
            // 
            barVol.BackColor = Color.Transparent;
            barVol.BarPenColorBottom = Color.FromArgb(87, 94, 110);
            barVol.BarPenColorTop = Color.FromArgb(55, 60, 74);
            barVol.BorderRoundRectSize = new Size(8, 8);
            barVol.Dock = DockStyle.Fill;
            barVol.ElapsedInnerColor = Color.Gray;
            barVol.ElapsedPenColorBottom = Color.Silver;
            barVol.ElapsedPenColorTop = Color.FromArgb(224, 224, 224);
            barVol.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point);
            barVol.ForeColor = Color.White;
            barVol.LargeChange = new decimal(new int[] { 5, 0, 0, 0 });
            barVol.Location = new Point(621, 0);
            barVol.Margin = new Padding(0);
            barVol.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            barVol.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            barVol.Name = "barVol";
            barVol.ScaleDivisions = new decimal(new int[] { 10, 0, 0, 0 });
            barVol.ScaleSubDivisions = new decimal(new int[] { 5, 0, 0, 0 });
            barVol.ShowDivisionsText = true;
            barVol.ShowSmallScale = false;
            barVol.Size = new Size(100, 31);
            barVol.SmallChange = new decimal(new int[] { 1, 0, 0, 0 });
            barVol.TabIndex = 2;
            barVol.Text = "bar2";
            barVol.ThumbInnerColor = Color.Gray;
            barVol.ThumbPenColor = Color.Black;
            barVol.ThumbRoundRectSize = new Size(4, 4);
            barVol.ThumbSize = new Size(8, 16);
            barVol.TickAdd = 0F;
            barVol.TickColor = Color.White;
            barVol.TickDivide = 0F;
            barVol.TickStyle = TickStyle.None;
            barVol.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.ForeColor = Color.Red;
            lblTime.Location = new Point(90, 6);
            lblTime.Margin = new Padding(15, 6, 0, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(44, 17);
            lblTime.TabIndex = 3;
            lblTime.Text = "--:--:--";
            // 
            // videoView1
            // 
            videoView1.AllowDrop = true;
            videoView1.BackColor = Color.Black;
            videoView1.Dock = DockStyle.Fill;
            videoView1.Location = new Point(0, 0);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(800, 448);
            videoView1.TabIndex = 2;
            videoView1.Text = "videoView1";
            videoView1.DragDrop += videoView1_DragDrop;
            videoView1.DragEnter += videoView1_DragEnter;
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlMenu.BackColor = Color.FromArgb(37, 37, 37);
            pnlMenu.Controls.Add(_Button1);
            pnlMenu.Controls.Add(btnPause);
            pnlMenu.Controls.Add(btnStop);
            pnlMenu.Controls.Add(btnBack);
            pnlMenu.Controls.Add(btnNext);
            pnlMenu.Controls.Add(btnPlay);
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(45, 448);
            pnlMenu.TabIndex = 3;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.Transparent;
            btnPause.BackgroundColor = Color.Transparent;
            btnPause.BackgroundImage = Properties.Resources.pause_48px;
            btnPause.BackgroundImageLayout = ImageLayout.Stretch;
            btnPause.BorderColor = Color.White;
            btnPause.BorderRadius = 7;
            btnPause.BorderSize = 1;
            btnPause.FlatAppearance.BorderSize = 0;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.ForeColor = Color.White;
            btnPause.Location = new Point(5, 45);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(35, 35);
            btnPause.TabIndex = 4;
            btnPause.TextColor = Color.White;
            btnPause.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Transparent;
            btnStop.BackgroundColor = Color.Transparent;
            btnStop.BackgroundImage = Properties.Resources.stop_48px;
            btnStop.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop.BorderColor = Color.White;
            btnStop.BorderRadius = 7;
            btnStop.BorderSize = 1;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(5, 85);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(35, 35);
            btnStop.TabIndex = 3;
            btnStop.TextColor = Color.White;
            btnStop.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundColor = Color.Transparent;
            btnBack.BackgroundImage = Properties.Resources.back_48px;
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.BorderColor = Color.White;
            btnBack.BorderRadius = 7;
            btnBack.BorderSize = 1;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(5, 125);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(35, 35);
            btnBack.TabIndex = 2;
            btnBack.TextColor = Color.White;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.BackgroundColor = Color.Transparent;
            btnNext.BackgroundImage = Properties.Resources.next_48px;
            btnNext.BackgroundImageLayout = ImageLayout.Stretch;
            btnNext.BorderColor = Color.White;
            btnNext.BorderRadius = 7;
            btnNext.BorderSize = 1;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(5, 165);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(35, 35);
            btnNext.TabIndex = 1;
            btnNext.TextColor = Color.White;
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Transparent;
            btnPlay.BackgroundColor = Color.Transparent;
            btnPlay.BackgroundImage = Properties.Resources.play_48px;
            btnPlay.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlay.BorderColor = Color.White;
            btnPlay.BorderRadius = 7;
            btnPlay.BorderSize = 1;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.ForeColor = SystemColors.ControlText;
            btnPlay.Location = new Point(5, 5);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(35, 35);
            btnPlay.TabIndex = 0;
            btnPlay.TextColor = SystemColors.ControlText;
            btnPlay.UseVisualStyleBackColor = false;
            // 
            // mediaTimer
            // 
            mediaTimer.Interval = 1000;
            mediaTimer.Tick += mediaTimer_Tick;
            // 
            // _Button1
            // 
            _Button1.BackColor = Color.Transparent;
            _Button1.BackgroundColor = Color.Transparent;
            _Button1.BackgroundImage = Properties.Resources.fx_48px;
            _Button1.BackgroundImageLayout = ImageLayout.Stretch;
            _Button1.BorderColor = Color.White;
            _Button1.BorderRadius = 7;
            _Button1.BorderSize = 1;
            _Button1.FlatAppearance.BorderSize = 0;
            _Button1.FlatStyle = FlatStyle.Flat;
            _Button1.ForeColor = Color.White;
            _Button1.Location = new Point(5, 207);
            _Button1.Name = "_Button1";
            _Button1.Size = new Size(35, 35);
            _Button1.TabIndex = 5;
            _Button1.TextColor = Color.White;
            _Button1.UseVisualStyleBackColor = false;
            // 
            // Player
            // 
            Controls.Add(pnlMenu);
            Controls.Add(videoView1);
            Controls.Add(pnlDown);
            Margin = new Padding(0);
            Name = "Player";
            Size = new Size(800, 483);
            Load += Player_Load;
            pnlDown.ResumeLayout(false);
            tpnlDown.ResumeLayout(false);
            tpnlDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.Controls._Panel pnlDown;
        private TableLayoutPanel tpnlDown;
        private Button btnMenu;
        private LibVLCSharp.WinForms.VideoView videoView1;
        private Panel pnlMenu;
        private ColorSlider.ColorSlider barTime;
        private ColorSlider.ColorSlider barVol;
        private Label lblLength;
        private Label lblTime;
        private CustomControls.RJControls._Button btnPause;
        private CustomControls.RJControls._Button btnStop;
        private CustomControls.RJControls._Button btnBack;
        private CustomControls.RJControls._Button btnNext;
        private CustomControls.RJControls._Button btnPlay;
        private System.Windows.Forms.Timer mediaTimer;
        private CustomControls.RJControls._Button _Button1;
    }
}
