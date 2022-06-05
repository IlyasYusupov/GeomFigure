//Юсупов Ильяс 221 группа "Шеометрические фигурф - 2"
using System;
using System.Collections.Generic;
using System.IO;

namespace GeomFigure3
{
    class Figure
    {
        protected BasePoint basePoint;

        public Figure(BasePoint point)
        {
            basePoint = point;
        }

        public Figure(int x = 0, int y = 0)
        {
            basePoint = new BasePoint(x, y);
        }

        public virtual void Draw(Graphics graph)
        { }
    }
}