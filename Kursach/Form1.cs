using System;
using System.IO;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new StreamWriter(@"../../1.txt", true).Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void help_Click(object sender, EventArgs e)
        {
            new Help().Show();
            Hide();
        }

        private void last_Click(object sender, EventArgs e)
        {
            new LastGames().Show();
            Hide();
        }

        private void start_Click(object sender, EventArgs e)
        {
            new MainGame().Show();
            Hide();
        }
    }
}