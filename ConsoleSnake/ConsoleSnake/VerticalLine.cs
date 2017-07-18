using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSnake
{
    class VerticalLine
    {
        List<Point> plist;

        public VerticalLine(int yUp, int yDown, int x, char sym) //высшая точка, нижняя точка, позиция по х, символ
        { 
            plist = new List<Point>(); // добавляем в список экземпляры Point от первого до последнего координата
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x,y,sym);
                plist.Add(p);
            }  
        }

        public void DrawLine()  // выводим этот список на экран
        {
            foreach (Point p in plist)
            {
                p.DrawPoint();
            }
        }    
    }
}
