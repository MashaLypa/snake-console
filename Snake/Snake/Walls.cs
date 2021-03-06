﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            //Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(1, mapWidth - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(1, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, 1, mapHeight - 2, '+');
            VerticalLine rightLine = new VerticalLine(mapWidth - 1, 1, mapHeight - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
                if (wall.IsHit(figure))
                    return true;
            return false;
        }

        public void DrawLine()
        {
            foreach (var wall in wallList)
                wall.DrawLine();
        }
    }
}
