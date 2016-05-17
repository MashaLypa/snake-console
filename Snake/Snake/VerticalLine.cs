using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int yUp, int yDown, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym); //создаем точки от нижней до верхней
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
