using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    abstract internal class Multipoint : Figure
    {
        protected List<Point> points; // массив точек ломаной

        protected void SetInf(List<Point> points)
        {
            this.points = new List<Point>(points);
        }

        protected void SetInf(List<Point> points, Color fill, Color outline, int depth)
        {
            this.points = new List<Point>(points);
            this.fill = fill;
            this.outline = outline;
            this.depth = depth;
        }

        public Multipoint(List<Point> points)
        { // по списку точек
            SetInf(points);
        }

        public Multipoint(List<Point> points, Color fill, Color outline, int depth)
        { // по списку точек
            SetInf(points, fill, outline, depth);
        }

        public Multipoint()
        { // если изначально нету звеньев
            SetInf(new List<Point>());
        }

        public Multipoint(Color fill, Color outline, int depth)
        { // если изначально нету звеньев
            SetInf(new List<Point>(), fill, outline, depth);
        }

        public void AddPoint(Point pos)
        {
            points.Add(pos);
        }

        abstract public void ChangePoint(Point pos);
    }
}
