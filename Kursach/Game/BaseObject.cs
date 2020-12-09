using System;
using System.Drawing;

namespace Kursach
{
    public abstract class BaseObject
    {
        protected Color _color;
        protected float radius;
        protected float x, y;

        protected BaseObject(float x, float y, float radius)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }

        public float X
        {
            get => x;
            set => x = value;
        }

        public float Y
        {
            get => y;
            set => y = value;
        }

        public float Radius
        {
            get => radius;
            set => radius = value;
        }

        public abstract void Draw(Canvas canvas);
        public abstract void Move();

        public void CheckBorders(float minx, float maxx, float miny, float maxy)
        {
            if (x < minx) x = minx;
            if (x > maxx) x = maxx;
            if (y > maxy) y = maxy;
            if (y < miny) y = miny;
        }

        public bool IsIntersec(BaseObject o)
        {
            var dx = Math.Abs(x - o.x);
            var dy = Math.Abs(y - o.y);
            return dy < o.radius / 4 && dx < o.radius / 2;
        }
    }
}