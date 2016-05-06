using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {

        public Snake(Point tail, int lenght, Direction direction)
        {
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);//создаем копии точек хвоста
                p.Move(i, direction);//сдвигаем на i по направлению direction
                pList.Add(p);//добавляем точки в список
            }
        }
    }
}
