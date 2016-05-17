using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.DrawPoint();

            Point p2 = new Point(4, 5, '#');            
            p2.DrawPoint();

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+'); //крайняя левая 5, правая 10, в 8-й строке
            line.DrawLine();

            VerticalLine line2 = new VerticalLine(5, 9, 12, '0');
            line2.DrawLine();


            Console.ReadLine();
        }
    }
}
