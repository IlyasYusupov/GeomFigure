//Юсупов Ильяс 221 группа "Геометрические фигуры - 4"
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;

namespace GeomFigure3
{
    class Figures
    {
        public List<Figure> page;
        Figure fig;

        public Figures()
        {
            page = new List<Figure>();
            fig = new Figure();
        }

        public void Add(Figure f)
        {
            page.Add(f);
        }

        public void Draw(Graphics graph)
        {
            foreach (var item in page)
            {
                item.Draw(graph);
            }
        }
        public void Save(string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (var item in page)
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }

        public void Load(string path)
        {
            using (StreamReader reader = new StreamReader(path, false))
            {
                while (reader.Peek() != -1)
                {
                    Convert(reader.ReadLine());
                }
            }
        }

        public void Convert(string str)
        {
            string[] ss = str.Split(' ');
            int[] num = new int[ss.Length];
            try
            {
                switch (ss[0])
                {
                    case "Line":
                        GetNum(ss, ref num);
                        fig = new Line((num[0]), num[1], num[2], num[3], new Pen(Color.FromArgb(num[4]), num[5]), num[5]);
                        page.Add(fig);
                        break;

                    case "Triangle":
                        GetNum(ss, ref num);
                        fig = new Triangle((num[0]), num[1], num[2], num[3], (num[4]), num[5], new SolidBrush(Color.FromArgb(num[6])),
                                            new Pen(Color.FromArgb(num[7]), num[8]), num[8]);
                        page.Add(fig);
                        break;

                    case "Circle":
                        GetNum(ss, ref num);
                        fig = new Circle(new BasePoint(num[0], num[1]), num[2], new SolidBrush(Color.FromArgb(num[3])), 
                                         new Pen(Color.FromArgb(num[4]), num[5]), num[5]);
                        page.Add(fig);
                        break;

                    case "Rectangle":
                        GetNum(ss, ref num);
                        fig = new Rectangle(new BasePoint(num[0], num[1]), num[2], num[3], new SolidBrush(Color.FromArgb(num[4])), 
                                            new Pen(Color.FromArgb(num[6]), num[7]),num[7]);
                        page.Add(fig);
                        break;

                    default:
                        throw new Exception("unknown Figure");
                }
            }
            catch 
            { }
        }
        public int[] GetNum(string[] str, ref int[] num)
        {
            for (int i = 1; i < str.Length; ++i)
            {
                int temp = Int32.Parse(str[i]);
                num[i - 1] = temp;
            }
            return num;
        }
    }
}
