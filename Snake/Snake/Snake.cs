using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);//создаем копии точек хвоста
                p.Move(i, direction);//сдвигаем на i по направлению direction
                pList.Add(p);//добавляем точки в список
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();//затираем точку, которая была хвостом
            head.DrawPoint();//рисуем новую голову
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();//текущая позиция головы
            Point nextPoint = new Point(head);//создаем ее копию
            nextPoint.Move(1, direction);//сдвинем по направлению
            return nextPoint;
        }
    }
}
