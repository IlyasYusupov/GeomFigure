//Юсупов Ильяс 221 группа "Шеометрические фигурф - 2"
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;


namespace GeomFigure3
{
    class Circle : FilledFigure
    {
        public int Radius;
        
        public Circle(BasePoint point, int radius, Brush newBrush, Pen newPen, int strokeWidth) : base(point, newBrush, newPen, strokeWidth)
        {
            Radius = radius;
        }

        public override void Draw(Graphics graph)
        {
            
            graph.DrawEllipse(Stroke, basePoint.X, basePoint.Y, Radius, Radius);
            graph.FillEllipse(Fill, basePoint.X, basePoint.Y, Radius, Radius);
        }

        public override string ToString()
        {
            return $"Circle {basePoint} {Radius} {(int)(Fill as SolidBrush).Color.ToArgb()} {Stroke.Color.ToArgb()} {StrokeWidth}";
        }
    }
}
