using System;
using System.Drawing;

namespace Kursach
{
    public class Brick : BaseObject
    {
        private static readonly Random r = new Random();

        public Brick(float x, float y) : base(x, y, 128)
        {
            _color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
        }

        public override void Draw(Canvas canvas)
        {
            canvas.g.FillRectangle(new SolidBrush(_color), x - radius / 2, y - radius / 8, radius, radius / 4);
        }

        public override void Move()
        {
        }
    }
}