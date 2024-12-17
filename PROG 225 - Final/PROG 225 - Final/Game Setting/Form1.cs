using PROG_225___Final.Game_Setting;
using PROG_225___Final.Snake_Setting;


namespace PROG_225___Final
{
    public partial class Form1 : Form
    {
        public Snake snake;
        private MainMenu mainMenu;
        public string name;

        public Form1()
        {
            InitializeComponent();
            Snake.mainForm = this;
            Apple.mainForm = this;

            DoubleBuffered = true; // Prevents flickering while drawing

            btnPlay.Enabled = btnMainMenu.Enabled = false;
            btnPlay.Visible = btnMainMenu.Visible = false;
            btnMainMenu.Location = new Point((ClientSize.Width + btnMainMenu.Width) / 2, (ClientSize.Height - btnMainMenu.Height) / 2);
            btnPlay.Location = new Point(btnMainMenu.Left - (btnPlay.Width * 2), (ClientSize.Height - btnPlay.Height) / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            snake = new Snake();
            snake.username = name;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            using (Pen gridPen = new Pen(Color.LightGray))
            {
                // Draw vertical lines
                for (int x = 0; x < this.ClientSize.Width; x += 24)
                {
                    g.DrawLine(gridPen, x, 0, x, this.ClientSize.Height);
                }

                // Draw horizontal lines
                for (int y = 0; y < this.ClientSize.Height; y += 24)
                {
                    g.DrawLine(gridPen, 0, y, this.ClientSize.Width, y);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up when Snake.direction != Direction.Down:
                    Snake.direction = Direction.Up;
                    break;
                case Keys.Down when Snake.direction != Direction.Up:
                    Snake.direction = Direction.Down;
                    break;
                case Keys.Left when Snake.direction != Direction.Right:
                    Snake.direction = Direction.Left;
                    break;
                case Keys.Right when Snake.direction != Direction.Left:
                    Snake.direction = Direction.Right;
                    break;
                case Keys.Space when Snake.gameTimer.Enabled == true:
                    Snake.gameTimer.Stop();
                    break;
                case Keys.Space when Snake.gameTimer.Enabled != true:
                    Snake.gameTimer.Start();
                    break;
                case Keys.Enter when btnPlay.Enabled == true:
                    btnPlay.PerformClick();
                    break;
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Option.menuForm.Show();
            snake.ResetSnakeClass();
            Snake.gameModeType = false;
            Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = btnMainMenu.Enabled = false;
            btnPlay.Visible = btnMainMenu.Visible = false;
            snake.ResetGame();
        }
    }
}
