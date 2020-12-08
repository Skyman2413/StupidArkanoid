using System;
  
using System.Threading;
using System.Windows.Forms;

namespace Kursach
{
    public partial class MainGame : Form
    {
        private Game _game;
        private Thread t;
        public MainGame()
        {
            InitializeComponent();
            _game = new Game(this.CreateGraphics(), label1);
            t = new Thread(_game.Run);
            t.Start();

        }

        private void MainGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left)) _game.Stand.MoveLeft();
            if (e.KeyCode.Equals(Keys.Right)) _game.Stand.MoveRight();

        }

        private void MainGame_KeyUp(object sender, KeyEventArgs e)
        {

            _game.Stand.Direction = 0;
        }


        private void label2_Click(object sender, EventArgs e)
        {
            _game.IsGameOver = true;
            new ResultOfGame(_game.IsWin, _game.Score).Show();
            t.Join();
            t.Interrupt();
            Close();
        }
    }
}