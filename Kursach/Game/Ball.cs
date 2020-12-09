using System;
using System.Drawing;

namespace Kursach
{
    public class Ball : BaseObject
    {
        private double directionAngle;

        private bool isFrozen;

        public Ball(float x, float y, double speed, double directionAngle) : base(x, y, 3)
        {
            Speed = speed;
            this.directionAngle = directionAngle;
            _color = Color.Red;
            isFrozen = true;
        }

        public double Speed { get; set; }

        public float Dx { get; set; }

        public float Dy { get; set; }

        public double DirectionAngle
        {
            get => directionAngle;
            internal set
            {
                directionAngle = value;
                Dx = (float) (Math.Cos(directionAngle) * Speed);
                Dy = (float) (Math.Sin(directionAngle) * Speed);
            }
        }


        public override void Draw(Canvas canvas)
        {
            var r = new Random();
            canvas.g.FillEllipse(new SolidBrush(_color), x - radius, y - radius, radius * 2, radius * 2);
        }


        public override void Move()
        {
            if (isFrozen) return;
            x += Dx;
            y += Dy;
            CheckRebound(2, 750, 64, 550);
        }

        private void CheckRebound(int minx, int maxx, int miny, int maxy)
        {
            if (x < minx)
            {
                x = 2 * minx - x;
                Dx *= -1;
            }

            if (x > maxx)
            {
                x = 2 * maxx - x;
                Dx *= -1;
            }

            if (y < miny)
            {
                y = 2 * miny - y;
                Dy *= -1;
            }

            if (y > maxx)
            {
                y = 2 * maxy - y;
                Dy *= -1;
            }
        }

        public void Start()
        {
            DirectionAngle = directionAngle;
            isFrozen = false;
        }
    }
}