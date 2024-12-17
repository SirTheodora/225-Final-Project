using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_225___Final.Game_Setting
{
    public class Apple
    {
        public static Form mainForm;

        private const int gridSize = 24;
        private PictureBox apple;
        private Random rnd = new Random();
        private Color borderColor = Color.Black;

        public Apple()
        {
            apple = new PictureBox()
            {
                BackColor = Color.Red,
                Width = gridSize,
                Height = gridSize,
            };

            mainForm.Controls.Add(apple);
            SpawnApple();
        }
        private void Apple_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int borderThickness = 1;

            using (Pen borderPen = new Pen(borderColor, borderThickness))
                g.DrawRectangle(borderPen, 0, 0, apple.Width - borderThickness, apple.Height - borderThickness);
            
        }
        public void RemoveApple()
        {
            if (apple != null)
                mainForm.Controls.Remove(apple);
            
        }

        public void SpawnApple()
        {
            RemoveApple();

            apple = new PictureBox()
            {
                BackColor = Color.Red,
                Width = gridSize,
                Height = gridSize,
            };

            apple.Location = new Point
            (
                rnd.Next(mainForm.ClientSize.Width / gridSize) * gridSize,
                rnd.Next(mainForm.ClientSize.Height / gridSize) * gridSize
            );

            mainForm.Controls.Add(apple);

            apple.Paint += Apple_Paint;
        }

        public PictureBox GetApple()
        {
            return apple;
        }
    }
}
