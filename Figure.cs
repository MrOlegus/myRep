using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    abstract internal class Figure
    {
        public Color fill = Color.White;     // цвет заливки по умолчанию
        public Color outline = Color.Black;  // цвет контура по умолчанию
        public int depth = 5;                // толщина контура по умолчанию

        abstract public void Draw(Graphics graph);
    }
}
