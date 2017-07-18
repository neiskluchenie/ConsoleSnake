using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSnake
{
    class Figure // основной класс, который содержит общий функционал для классов вертикальной и горизонтальной линии. От него наследуются остальные
    {
        protected List<Point> plist;

        public void DrawLine()  // выводим список точек на экран
        {
            foreach (Point p in plist)
            {
                p.DrawPoint();
            }
        }  
    }
}
