using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    internal class Ellipse : Rectangular
    {
        public Ellipse(Point pos, int width, int height)
            : base(pos, width, height)
        { // по координате, ширине и высоте
        }

        public Ellipse(Point pos, int width, int height, Color fill, Color outline, int depth)
            : base(pos, width, height, fill, outline, depth)
        { // по координате, ширине и высоте
        }

        public Ellipse(Point pos0, Point pos1)
            : base(pos0, pos1)
        { // по двум координатам
        }

        public Ellipse(Point pos0, Point pos1, Color fill, Color outline, int depth)
            : base(pos0, pos1, fill, outline, depth)
        { // по двум координатам
        }

        public override void Draw(Graphics graph)
        {
            SolidBrush brush = new SolidBrush(fill);                 // кисть - цвет зливки
            Pen pen = new Pen(outline, depth);                       // перо - цвет контура
            graph.FillEllipse(brush, pos.X, pos.Y, width, height);   // заливка
            graph.DrawEllipse(pen, pos.X, pos.Y, width, height);     // рисование контура
        }

        public override void ChangeSize(Point pos)
        {
            this.width = pos.X - this.pos.X;
            this.height = pos.Y - this.pos.Y;
        }
    }
}
