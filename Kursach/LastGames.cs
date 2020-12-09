using System;
using System.IO;
using System.Windows.Forms;

namespace Kursach
{
    public partial class LastGames : Form
    {
        public LastGames()
        {
            InitializeComponent();
            ReadFile();
        }

        private void ReadFile()
        {
            var reader = new StreamReader(@"../../1.txt");
            for (var i = 0; i < 5 && !reader.EndOfStream; i++) label1.Text += reader.ReadLine() + "\n";
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }
    }
}