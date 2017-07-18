﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSnake
{
    class HorizontalLine
    {
        List<Point> plist;

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        { 
            plist = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x,y,sym);
                plist.Add(p);
            }
            
        }
        public void DrawLine()// переименовать в дроулайн
        {
            foreach (Point p in plist)
            {
                p.DrawPoint();
            }
        }
    }
}
