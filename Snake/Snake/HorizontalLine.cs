using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xLeft, int xReight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xReight; x++)
            {
                Point p = new Point(x, y, sym); //создаем точки от крайней левой до крайней правой
                pList.Add(p); //добавляем в список точек
            }
        }

        public void DrawLine()
        {
            foreach (Point p in pList)
            {
                    p.DrawPoint();
            }
        }
    }
}
