using System;
using System.Windows.Forms;

namespace Kursach
{
    public partial class ResultOfGame : Form
    {
        public ResultOfGame(bool isWin, int score)
        {
            
            InitializeComponent();
            label1.Text = isWin ? "WIN!" : "LOSE!";
            label2.Text += score;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }
    }
}