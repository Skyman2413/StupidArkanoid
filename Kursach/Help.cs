using System;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }
    }
}