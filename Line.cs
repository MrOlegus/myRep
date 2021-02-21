using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    internal class Line : Rectangular
    {
        public Line(Point pos0, Point pos1) : base(pos0, pos1)
        { // конструктор по двум точкам
        }

        public Line(Point pos0, Point pos1, Color fill, Color outline, int depth)
            : base(pos0, pos1, fill, outline, depth)
        { // конструктор по двум точкам
        }

        public override void Draw(Graphics graph)
        {
            SolidBrush brush = new SolidBrush(fill);  // кисть - цвет зливки
            Pen pen = new Pen(outline, depth);        // перо - цвет контура

            graph.DrawLine(pen, pos, new Point(pos.X + width, pos.Y + height));
        }

        public override void ChangeSize(Point pos)
        {
            this.width = pos.X - this.pos.X;
            this.height = pos.Y - this.pos.Y;
        }
    }
}
