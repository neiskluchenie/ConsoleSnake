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

            Point p1 = new Point(1, 3, '*'); // создаем новый экземпляр класса Point (объект) и инициализируем его переменные нашими значениями
            p1.DrawPoint();

            Point p2 = new Point(4, 7, '#'); // второй объект из класса Point 
            p2.DrawPoint();

            HorizontalLine line = new HorizontalLine(1,10,8,'+');
            line.DrawLine();
                       
            //задержка
            Console.ReadLine();
        }
    }
}
