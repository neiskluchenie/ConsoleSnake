using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            //начало координат в левом верхнем углу, ось х идет слева направо, ось у идет сверху вниз
            // ctrl+e,c = закомментировать несколько строк сразу
            // ctrl+k+d = выровнять код

            Console.SetBufferSize(80, 25); // задает параметры окна (ширина, высота) и убирает возможность прокрутки

            // отрисовка рамочки

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.DrawLine();
            downLine.DrawLine();
            leftLine.DrawLine();
            rightLine.DrawLine();
            
            // ставим точку 
           
            Point p2 = new Point(4, 7, '#'); // второй объект из класса Point 
            p2.DrawPoint();


            //задержка
            Console.ReadLine();
        }
    }
}
