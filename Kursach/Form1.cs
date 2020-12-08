using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            this.Hide();
        }

        private void last_Click(object sender, EventArgs e)
        {
            new LastGames().Show();
            this.Hide();
        }

        private void start_Click(object sender, EventArgs e)
        {
            new MainGame().Show();
            this.Hide();
        }
    }
}