namespace PlayerFF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTop = new CustomControls.Controls._Panel();
            btnMax = new Button();
            btnX = new Button();
            pnlPlayer = new Panel();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(37, 37, 37);
            pnlTop.BorderColor = Color.White;
            pnlTop.BorderSize = 1;
            pnlTop.Controls.Add(btnMax);
            pnlTop.Controls.Add(btnX);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.EndColor = Color.Empty;
            pnlTop.GradientAngle = 0;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(800, 35);
            pnlTop.StartColor = Color.Empty;
            pnlTop.TabIndex = 1;
            pnlTop.Transparent1 = 0;
            pnlTop.Transparent2 = 0;
            pnlTop.MouseDown += pnlTop_MouseDown;
            pnlTop.MouseMove += pnlTop_MouseMove;
            pnlTop.MouseUp += pnlTop_MouseUp;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Right;
            btnMax.BackgroundImage = Properties.Resources.maximize_;
            btnMax.BackgroundImageLayout = ImageLayout.Stretch;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Location = new Point(735, 5);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(25, 25);
            btnMax.TabIndex = 3;
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnX
            // 
            btnX.Anchor = AnchorStyles.Right;
            btnX.BackgroundImage = Properties.Resources.x;
            btnX.BackgroundImageLayout = ImageLayout.Stretch;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Location = new Point(770, 5);
            btnX.Name = "btnX";
            btnX.Size = new Size(25, 25);
            btnX.TabIndex = 2;
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // pnlPlayer
            // 
            pnlPlayer.Dock = DockStyle.Fill;
            pnlPlayer.Location = new Point(0, 35);
            pnlPlayer.Name = "pnlPlayer";
            pnlPlayer.Size = new Size(800, 415);
            pnlPlayer.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlPlayer);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.Controls._Panel pnlTop;
        private Button btnX;
        private Button btnMax;
        private Panel pnlPlayer;
    }
}