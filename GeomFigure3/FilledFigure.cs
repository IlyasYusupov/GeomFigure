//Юсупов Ильяс 221 группа "Геометрические фигуры - 4"
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GeomFigure3
{
    class FilledFigure : Figure
    {
        public Brush Fill;
        public Pen Stroke;
        public int StrokeWidth;

        public FilledFigure(BasePoint point, Brush newBrush, Pen newStroke, int newStrokeWidth) : base(point)
        {
            Fill = newBrush;
            Stroke = newStroke;
            StrokeWidth = newStrokeWidth;
        }

        public FilledFigure(int x, int y, Brush newBrush, Pen newStroke, int newStrokeWidth) : base(x, y)
        {
            Fill = newBrush;
            Stroke = newStroke;
            StrokeWidth = newStrokeWidth;
        }
    }
}
