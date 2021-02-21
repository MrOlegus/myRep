using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    internal class Square : Rectangle
    {
        public Square(Point pos, int width)
            : base(pos, width, width)
        { // вызов конструктора базового класса 
        }

        public Square(Point pos, int width, Color fill, Color outline, int depth)
            : base(pos, width, width, fill, outline, depth)
        { // вызов конструктора базового класса 
        }

        public Square(Point pos0, Point pos1)
            : base(pos0, new Point(pos1.X, pos0.Y + (pos1.X - pos0.X)))
        { // вызов конструктора базового класса 
        }

        public Square(Point pos0, Point pos1, Color fill, Color outline, int depth)
            : base(pos0, new Point(pos1.X, pos0.Y + (pos1.X - pos0.X)), fill, outline, depth)
        { // вызов конструктора базового класса 
        }

        public override void ChangeSize(Point pos)
        {
            this.width = pos.X - this.pos.X;
            this.height = pos.X - this.pos.X;
        }
    }
}
