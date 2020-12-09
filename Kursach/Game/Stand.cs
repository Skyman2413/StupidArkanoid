using System;
using System.Drawing;

namespace Kursach
{
    public class Stand : BaseObject
    {
        private readonly float _speed = 10;

        public Stand(float x, float y) : base(x, y, 128)
        {
            _color = Color.Blue;
        }

        public float Direction { get; set; }

        public override void Draw(Canvas canvas)
        {
            var r = new Random();
            canvas.g.FillRectangle(new SolidBrush(_color), x - radius / 2, y - radius / 4, radius, radius / 2);
        }

        public override void Move()
        {
            var dx = _speed * Direction;
            x += dx;
            CheckBorders(radius / 2, 760 - radius / 2 + 1,
                1, 720 - radius / 4 + 1);
        }

        public void MoveLeft()
        {
            Direction = -1;
        }

        public void MoveRight()
        {
            Direction = 1;
        }
    }
}