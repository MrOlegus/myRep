using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    internal class Polyline : Multipoint
    {
        public Polyline(List<Point> points)
            : base(points)
        { // по списку точек
        }

        public Polyline(List<Point> points, Color fill, Color outline, int depth)
            : base(points, fill, outline, depth)
        { // по списку точек
        }

        public Polyline()
            : base()
        { // если изначально нету звеньев
        }

        public Polyline(Color fill, Color outline, int depth)
            : base(fill, outline, depth)
        { // если изначально нету звеньев
        }

        public Polyline(Point pos0)
             : base()
        { // с одной стартовой точкой
            this.AddPoint(pos0);
        }

        public Polyline(Point pos0, Color fill, Color outline, int depth)
             : base(fill, outline, depth)
        { // с одной стартовой точкой
            this.AddPoint(pos0);
        }

        public override void Draw(Graphics graph)
        {
            //SolidBrush brush = new SolidBrush(fill);  // кисть - цвет зливки
            Pen pen = new Pen(outline, depth);        // перо - цвет контура

            Point predPos = new Point(points[0].X, points[0].Y);
            for (int i = 1; i < points.Count; i++)
            {
                graph.DrawLine(pen, predPos, points[i]);
                predPos = points[i];
            }
        }

        public override void ChangePoint(Point pos)
        {
            this.points[points.Count - 1] = pos;
        }
    }
}
