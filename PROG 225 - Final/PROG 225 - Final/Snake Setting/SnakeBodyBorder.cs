using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_225___Final.Snake_Setting
{
    public class SnakeBodyBorder : PictureBox
    {
        private Color borderColor = Color.DarkOliveGreen;

        public SnakeBodyBorder(Color body, Color border)
        {
            BackColor = body;
            borderColor = border;
            Width = 24;
            Height = 24;
            Padding = new Padding(2);
            SizeMode = PictureBoxSizeMode.StretchImage;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            int borderThickness = 1;

            using (Pen pen = new Pen(borderColor, borderThickness))
                g.DrawRectangle(pen, 0, 0, Width - borderThickness, Height - 1);
        }
    }
}
