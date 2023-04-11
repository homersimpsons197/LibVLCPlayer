namespace PlayerFF
{
    public partial class Form1 : Form
    {
        Player player;

        private bool dragging;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public static bool isNormalSize = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new Player(this);
            pnlPlayer.Controls.Add(player);
            player.Dock = DockStyle.Fill;
            player.Show();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            isNormalSize = !isNormalSize;
            if (!isNormalSize)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (isNormalSize)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}