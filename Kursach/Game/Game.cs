using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Kursach
{
    public class Game
    {
        private readonly Ball _ball;

        private readonly List<Brick> _bricks;
        private readonly float _height;
        private readonly Label _label;
        private readonly Graphics _g;

        public Game(Graphics g, Label label)
        {
            _label = label;
            this._g = g;
            float width = 1024;
            _height = 720;
            _bricks = CreateBricks();
            _ball = new Ball(width / 2, 500, 5, new Random().Next(180));
            Stand = new Stand(width / 2, 575);
            IsGameOver = false;
            IsWin = false;
        }

        public int Score { get; private set; }


        public Stand Stand { get; }

        public bool IsGameOver { get; internal set; }

        public bool IsWin { get; private set; }

        private void CheckEndGame()
        {
            if (_ball.Y > _height - 100 && _ball.Dy > 0)
                IsGameOver = true;
            if (_bricks.Count != 0) return;
            IsWin = true;
            IsGameOver = true;
        }

        public void Run()
        {
            var canvas = new Canvas(_g);
            _ball.Start();
            while (!IsGameOver)
            {
                Move();
                CheckBricksBump();
                CheckStandDump();
                CheckEndGame();

                canvas.Clear();
                Draw(canvas);
                Thread.Sleep(10);
            }

            string result;
            if (IsWin) result = "win : " + Score;
            else result = "lose : " + Score;
            var reader = new StreamReader(@"../../1.txt");
            var sb = new StringBuilder();
            sb.AppendLine(result);
            while (!reader.EndOfStream) sb.AppendLine(reader.ReadLine());
            reader.Close();
            var writer = new StreamWriter(@"../../1.txt");
            writer.WriteLine(sb.ToString());
            writer.Close();
        }

        private void Draw(Canvas canvas)
        {
            foreach (var brick in _bricks) brick.Draw(canvas);
            _ball.Draw(canvas);
            Stand.Draw(canvas);
        }

        private void CheckBricksBump()
        {
            Brick forDelete = null;
            foreach (var brick in _bricks.Where(brick => _ball.IsIntersec(brick)))
            {
                _ball.DirectionAngle = new Random().Next(360);
                forDelete = brick;
                Score++;
            }

            _label.Text = "Score : " + Score;
            if (forDelete != null) _bricks.Remove(forDelete);
            IsGameOver = _bricks.Count == 0;
        }

        private void CheckStandDump()
        {
            if (_ball.IsIntersec(Stand)) _ball.Dy *= -1;
        }

        private void Move()
        {
            _ball.Move();
            Stand.Move();
        }

        private List<Brick> CreateBricks()
        {
            var list = new List<Brick>();
            for (var i = 0; i < 8; i++)
            for (var j = 0; j < 6; j++)
                list.Add(new Brick(i * 128 + 64, 32 * j + 64));

            return list;
        }
    }
}