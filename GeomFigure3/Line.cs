//Юсупов Ильяс 221 группа "Шеометрические фигурф - 2"
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GeomFigure3
{
    class Line : Figure
    {
        public Pen Stroke;
        int StrokeWidth;
        public BasePoint A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public BasePoint B;

        public Line(BasePoint a, BasePoint b, Pen newPen, int newStrokeWidth) : base(a)
        {
            B = b;
            Stroke = newPen;
            StrokeWidth = newStrokeWidth;
        }

        public Line(int x1, int y1, int x2, int y2, Pen newPen, int newStrokeWidth) : base(x1, y1)
        {
            B = new BasePoint(x2, y2);
            Stroke = newPen;
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(Stroke, A.X, A.Y, B.X, B.Y);
        }

        public override string ToString()
        {
            return $"Line {A} {B} {Stroke.Color.ToArgb()} {StrokeWidth}";
        }
    }
}
