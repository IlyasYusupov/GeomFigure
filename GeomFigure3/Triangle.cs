//Юсупов Ильяс 221 группа "Шеометрические фигурф - 2"
using System;
using System.Collections.Generic;
using System.IO;

namespace GeomFigure3
{
    class Triangle : FilledFigure
    {
        PointF[] points;
        public BasePoint A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public BasePoint B;
        public BasePoint C;
        

        public Triangle(BasePoint a, BasePoint b, BasePoint c, Brush newBrush, Pen newPen, int strokeWidth) : base(a, newBrush, newPen, strokeWidth)
        {
            B = b;
            C = c;
            points = new PointF[3];
            points[0] = new PointF(a.X, a.Y);
            points[1] = new PointF(b.X, b.Y);
            points[2] = new PointF(c.X, c.Y);
        }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3, Brush newBrush, Pen newPen, int strokeWidth) : base(x1, y1, newBrush, newPen, strokeWidth)
        {
            B = new BasePoint(x2, y2);
            C = new BasePoint(x3, y3);
            points = new PointF[3];
            points[0] = new PointF(x1, y1);
            points[1] = new PointF(x2, y2);
            points[2] = new PointF(x3, y3);
        }

        public override void Draw(Graphics graph)
        {
            graph.DrawPolygon(Stroke, points);
            graph.FillPolygon(Fill, points);

        }

        public override string ToString()
        {
            return $"Triangle {A} {B} {C} {(int)(Fill as SolidBrush).Color.ToArgb()} {Stroke.Color.ToArgb()} {StrokeWidth}";
        }
    }
}
