using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    abstract internal class Rectangular : Figure
    { // фигуры, которым нужно две точки для их рисования
        public Point pos;  // положение фигуры
        public int width;  // ширина фигуры
        public int height; // высота фигуры

        protected void SetInf(Point pos, int width, int height)
        {
            this.pos = pos;
            this.width = width;
            this.height = height;
        }

        protected void SetInf(Point pos, int width, int height, Color fill, Color outline, int depth)
        {
            this.pos = pos;
            this.width = width;
            this.height = height;
            this.fill = fill;
            this.outline = outline;
            this.depth = depth;
        }

        public Rectangular(Point pos, int width, int height)
        { // по координате, ширине и высоте
            SetInf(pos, width, height);
        }

        public Rectangular(Point pos, int width, int height, Color fill, Color outline, int depth)
        { // по координате, ширине, высоте, заливке, цвету контура и толщине контура
            SetInf(pos, width, height, fill, outline, depth);
        }

        public Rectangular(Point pos0, Point pos1)
        { // по двум координатам
            SetInf(pos0, pos1.X - pos0.X, pos1.Y - pos0.Y);
        }

        public Rectangular(Point pos0, Point pos1, Color fill, Color outline, int depth)
        { // по двум координатам
            SetInf(pos0, pos1.X - pos0.X, pos1.Y - pos0.Y, fill, outline, depth);
        }

        abstract public void ChangeSize(Point pos);
    }
}
