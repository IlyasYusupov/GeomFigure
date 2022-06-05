//Юсупов Ильяс 221 группа "Геометрические фигуры - 4"

namespace GeomFigure3
{
    public struct BasePoint
    {
        public int X;
        public int Y;

        public BasePoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X} {Y}";
        }
    }
}
