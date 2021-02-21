using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    internal class Polygon : Polyline
    {
        public void Close()
        { // замыкание ломаной
            points[points.Count - 1] = points[0];
        }

        public static List<Point> Closed(List<Point> points)
        { // замыкание ломаной для конструктора
            points.Add(points[0]);
            return points;
        }

        public Polygon(List<Point> points) : base(Closed(points))
        { // создание многоугольника по точкам
        }

        public Polygon(List<Point> points, Color fill, Color outline, int depth)
            : base(Closed(points), fill, outline, depth)
        { // создание многоугольника по точкам
        }

        public Polygon() : base()
        { // создание "пустого" многоугольника
        }

        public Polygon(Color fill, Color outline, int depth)
            : base(fill, outline, depth)
        { // создание "пустого" многоугольника
        }

        public Polygon(Point pos0)
             : base()
        { // с одной стартовой точкой
            this.AddPoint(pos0);
        }

        public Polygon(Point pos0, Color fill, Color outline, int depth)
             : base(fill, outline, depth)
        { // с одной стартовой точкой
            this.AddPoint(pos0);
        }

        public override void Draw(Graphics graph)
        {
            if (points[0] == points[points.Count - 1])
            { // если уже замкнут, то заливаем
                SolidBrush brush = new SolidBrush(fill);  // кисть - цвет зливки
                Pen pen = new Pen(outline, depth);        // перо - цвет контура
                if (points.Count > 2) graph.FillPolygon(brush, points.ToArray());
            }
            base.Draw(graph);
        }
    }
}
