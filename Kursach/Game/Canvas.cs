﻿using System.Drawing;
using System.Windows.Forms;

namespace Kursach
{
    public class Canvas
    {
        public Graphics g;
        public Canvas(Graphics g)
        {
            this.g = g;
        }

        public void Clear()
        {
            g.Clear(Color.White);
        }
        
    }
}