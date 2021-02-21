using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class MyPainter : Form
    {
        public MyPainter()
        {
            InitializeComponent();
        }

        private enum FigureTypes // тип для хранения последней нажатой кнопки
        {
            line, circle, ellipse, square, rectangle, polyline, polygon
        }
        private FigureTypes figureType = FigureTypes.rectangle; // по умолчанию - прямоугольник

        private List<Figure> figureList = new List<Figure>(); // список для хранения фигур
        private bool isCompleted = true; // дорисована ли фигура

        private Color fill = Color.White;   // текущая заливка
        private Color outline = Color.Black; // текущий цвет контура
        private int depth = 5;    // текущая толщина

        private void DefineFigure(object sender, EventArgs e)
        { // определение последней нажатой кнопки
            switch (((Button)sender).Name)
            {
                case "btnLine": figureType = FigureTypes.line; break;
                case "btnCircle": figureType = FigureTypes.circle; break;
                case "btnEllipse": figureType = FigureTypes.ellipse; break;
                case "btnSquare": figureType = FigureTypes.square; break;
                case "btnRectangle": figureType = FigureTypes.rectangle; break;
                case "btnPolyline": figureType = FigureTypes.polyline; break;
                case "btnPolygon": figureType = FigureTypes.polygon; break;
            }
            isCompleted = true;
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        { // запоминание начальной координаты
            Point pos0 = new Point(); // начальное положение мыши 
            pos0.X = Cursor.Position.X - (this.Location.X + ((PictureBox)sender).Location.X) - 9;
            pos0.Y = Cursor.Position.Y - (this.Location.Y + ((PictureBox)sender).Location.Y) - 31;

            if (isCompleted)
            {
                switch (figureType)
                {
                    case FigureTypes.line: figureList.Add(new Line(pos0, pos0, fill, outline, depth)); break;
                    case FigureTypes.circle: figureList.Add(new Circle(pos0, pos0, fill, outline, depth)); break;
                    case FigureTypes.ellipse: figureList.Add(new Ellipse(pos0, pos0, fill, outline, depth)); break;
                    case FigureTypes.square: figureList.Add(new Square(pos0, pos0, fill, outline, depth)); break;
                    case FigureTypes.rectangle: figureList.Add(new Rectangle(pos0, pos0, fill, outline, depth)); break;
                    case FigureTypes.polyline: figureList.Add(new Polyline(pos0, fill, outline, depth)); break;
                    case FigureTypes.polygon: figureList.Add(new Polygon(pos0, fill, outline, depth)); break;
                }
                isCompleted = false;
            };

            if (figureList[figureList.Count - 1] is Rectangular)
            {
            }
            else
            if (figureList[figureList.Count - 1] is Multipoint)
            {
                ((Multipoint)figureList[figureList.Count - 1]).AddPoint(pos0);
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        { // добавление новой фигуры и отрисовка
            if (figureList[figureList.Count - 1] is Rectangular)
            {
                if ((((Rectangular)figureList[figureList.Count - 1]).width != 0) ||
                    (((Rectangular)figureList[figureList.Count - 1]).height != 0)) isCompleted = true;
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isCompleted)
            {
                Point pos = new Point();
                pos.X = Cursor.Position.X - (this.Location.X + Canvas.Location.X) - 9;
                pos.Y = Cursor.Position.Y - (this.Location.Y + Canvas.Location.Y) - 31;

                if (figureList.Count != 0)
                    if (figureList[figureList.Count - 1] is Rectangular)
                    {
                        ((Rectangular)figureList[figureList.Count - 1]).ChangeSize(pos);
                    }
                    else
                    if (figureList[figureList.Count - 1] is Multipoint)
                    {
                        ((Multipoint)figureList[figureList.Count - 1]).ChangePoint(pos);
                    }
            }
        }

        private void Canvas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (figureList[figureList.Count - 1] is Rectangular)
            {
            }
            else
            if (figureList[figureList.Count - 1] is Multipoint)
            {
                isCompleted = true;
                if (figureList[figureList.Count - 1] is Polygon)
                    ((Polygon)figureList[figureList.Count - 1]).Close();
            }
        }

        private void BtnFill_Click(object sender, EventArgs e)
        {
            if (colorDialogFill.ShowDialog() == DialogResult.Cancel)
                return;
            fill = colorDialogFill.Color; // установка цвета заливки
            panelColorFill.BackColor = fill;
        }

        private void BtnOutline_Click(object sender, EventArgs e)
        {
            if (colorDialogFill.ShowDialog() == DialogResult.Cancel)
                return;
            outline = colorDialogFill.Color; // установка цвета контура
            panelColorOutline.BackColor = outline;
        }

        private void SpinDepth_ValueChanged(object sender, EventArgs e)
        {
            depth = (int)spinDepth.Value;
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < figureList.Count; i++)
            {
                figureList[i].Draw(e.Graphics);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Canvas.Invalidate();
        }
    }
}
