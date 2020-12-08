using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
namespace Kursach
{
    public class Game
    {
        private float _width;
        private float _height;
        private Graphics g;
        private int score = 0;
        private Label _label;

        public int Score => score;

        private List<Brick> _bricks;
        private Ball _ball;


        public Stand Stand { get; set; }

        public bool IsGameOver { get; internal set; }

        public bool IsWin { get; private set; }

        public Game(Graphics g, Label label)
        {
            _label = label;
            this.g = g;
            _width = 1024;
            _height = 720;
            _bricks = CreateBricks();
            _ball = new Ball(_width/2, 500, 5, new Random().Next(180));
            Stand = new Stand(_width/2, 575);
            IsGameOver = false;
            IsWin = false;
        }

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
            Canvas canvas = new Canvas(g);
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
            if (IsWin) result = "win : " + score;
            else result = "lose : " + score;
            var reader = new StreamReader(@"../../1.txt");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(result);
            while (!reader.EndOfStream)
            {
                sb.AppendLine(reader.ReadLine());
            }
            reader.Close();
            var writer = new StreamWriter(@"../../1.txt");
            writer.WriteLine(sb.ToString());
            writer.Close();
        }

        private void Draw(Canvas canvas)
        {
            foreach (var brick in _bricks)
            {
                 brick.Draw(canvas);
            }
            _ball.Draw(canvas);
            Stand.Draw(canvas);
        }
        private void CheckBricksBump()
        {
            Brick forDelete = null;
            foreach (var brick in _bricks.Where(brick => _ball.IsIntersec(brick)))
            {
                _ball.DirectionAngle= new Random().Next(360);
                forDelete = brick;
                score++;
            }

            _label.Text = "Score : " + score;
            if (forDelete != null) _bricks.Remove(forDelete);
            IsGameOver = _bricks.Count == 0;
        }

        private void CheckStandDump()
        {
            if (_ball.IsIntersec(Stand))
            {
                _ball.Dy *= -1;
                
            }
        }
        
        private void Move()
        {
            _ball.Move();
            Stand.Move();
        }

        private List<Brick> CreateBricks()
        {
            List<Brick> list= new List<Brick>();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    list.Add(new Brick(i*128 + 64, 32 * j + 64));
                }
            }

            return list;
        }
        
    }
}