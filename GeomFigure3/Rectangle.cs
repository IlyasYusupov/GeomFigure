//Юсупов Ильяс 221 группа "Геометрические фигуры - 4"
using System;
using System.Collections.Generic;
using System.IO;

namespace GeomFigure3
{
    class Rectangle : FilledFigure
    {
        public int Height;
        public int Width;

        public Rectangle(BasePoint point, int height, int width, Brush newBrush, Pen newPen, int strokeWidth) : base(point, newBrush, newPen, strokeWidth)
        {
            Height = height;
            Width = width;
        }

        public override void Draw(Graphics graph)
        {
            graph.DrawRectangle(Stroke, basePoint.X, basePoint.Y, Width, Height);
            graph.FillRectangle(Fill, basePoint.X, basePoint.Y, Width, Height);    
        }

        public override string ToString()
        {
            return $"Rectangle {basePoint} {Height} {Width} {(int)(Fill as SolidBrush).Color.ToArgb()} {Stroke.Color.ToArgb()} {StrokeWidth}";
        }
    }
}
