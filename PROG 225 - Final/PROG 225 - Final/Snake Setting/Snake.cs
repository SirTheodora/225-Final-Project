using PROG_225___Final.Game_Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PROG_225___Final.Snake_Setting
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    public class Snake
    {
        #region Public And Static Fields
        public static WindowsMediaPlayer soundFX = new WindowsMediaPlayer();
        public static Direction direction = Direction.Right;
        public static System.Windows.Forms.Timer gameTimer;
        public static bool gameModeType;
        public static Form1 mainForm;
        public static int score;
        public string username;
        #endregion

        #region Private Fields
        private List<SnakeBodyBorder> body = new List<SnakeBodyBorder>();
        private Leaderboard scorelist = new Leaderboard();
        private const int gridSize = 24;        
        private int speedCounter;
        private Apple apple;
        #endregion

        #region Constructor
        public Snake()
        {
            direction = Direction.Right;
            SnakeBodyBorder head = new SnakeBodyBorder(Color.LightGreen, Color.Black);
            head.Location = new Point(mainForm.ClientSize.Width / 2, mainForm.ClientSize.Height / 2);

            body.Add(head);
            mainForm.Controls.Add(head);

            apple = new Apple();
            GameStart();
        }
        #endregion

        #region Private Methods
        private void Snake_Timer(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"{gameTimer.Interval}");
            SnakeMove();

            CheckCollisionSelf();
            CheckCollisionWall();

            if (body.Count > 0 )
            {
                if (body[0].Bounds.IntersectsWith(apple.GetApple().Bounds))
                {
                    Grow();
                    speedCounter++;
                    soundFX.URL = "BGM/SFX/apple.wav";
                    soundFX.controls.play();

                    apple.RemoveApple();
                    apple.SpawnApple();
                }
            }

            if (speedCounter >= 5)
            {
                gameTimer.Interval  -= 2;
                speedCounter = 0;
            }

            mainForm.lbScore.Text = $"Score : {score}";
        }
        private void GameStart()
        {
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 60;
            gameTimer.Tick += Snake_Timer;
        }
        private void SnakeMove()
        {
            // Moves snake body
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].Location = body[i - 1].Location;
            }

            // Moves snake head
            PictureBox head = body[0];

            switch (direction)
            {
                case Direction.Up:
                    head.Top -= gridSize;
                    break;
                case Direction.Down:
                    head.Top += gridSize;
                    break;
                case Direction.Left:
                    head.Left -= gridSize;
                    break;
                case Direction.Right:
                    head.Left += gridSize;
                    break;
            }
        }
        private void Grow()
        {
            score++;
            SnakeBodyBorder addBody = new SnakeBodyBorder(Color.DarkGreen, Color.DarkOliveGreen);
            addBody.Location = body[^1].Location;

            body.Add(addBody);
            mainForm.Controls.Add(addBody);
        }
        private void CheckCollisionWall()
        {
            if (gameModeType) // Wall Mode
            {
                PictureBox head = body[0];
                if (head.Left < 0 ||
                    head.Top < 0 ||
                    head.Right > mainForm.ClientSize.Width ||
                    head.Bottom > mainForm.ClientSize.Height)
                {
                    GameOver();
                }
            }
            else // Endless Mode
            {
                PictureBox head = body[0];
                if (head.Left < 0)
                    head.Location = new Point(mainForm.ClientSize.Width - head.Width, head.Location.Y);
                if (head.Right > mainForm.ClientSize.Width)
                    head.Location = new Point(0, head.Location.Y);
                if (head.Top < 0)
                    head.Location = new Point(head.Location.X, mainForm.ClientSize.Height - head.Height);
                if (head.Bottom > mainForm.ClientSize.Height)
                    head.Location = new Point(head.Location.X, 0);
            }
        }
        private void CheckCollisionSelf()
        {
            PictureBox head = body[0];
            for (int i = 1; i < body.Count; i++)
                if (head.Bounds.IntersectsWith(body[i].Bounds))
                {
                    GameOver();
                }
        }
        private void GameOver()
        {
            gameTimer.Stop();

            scorelist.AddScore(username, score);

            mainForm.btnPlay.Enabled = mainForm.btnMainMenu.Enabled = true;
            mainForm.btnPlay.Visible = mainForm.btnMainMenu.Visible = true;
        }
        #endregion

        #region Public Methods
        public void ResetSnakeClass()
        {
            foreach (PictureBox part in body)
            {
                mainForm.Controls.Remove(part);
            }
            apple.RemoveApple();
            body.Clear();
            score = 0;
        }

        public void ResetGame()
        {
            ResetSnakeClass();
            new Snake();
        }
        #endregion
    }
}
