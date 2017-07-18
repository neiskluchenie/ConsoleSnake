using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSnake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)// левая точка, правая, позиция по у, символ
        {
            plist = new List<Point>(); // добавляем в список экземпляры Point от первого до последнего координата
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x,y,sym);
                plist.Add(p);
            }
            
        }
      
    }
}
