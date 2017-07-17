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
            //p1.x = 1;
            //p1.y = 3;
            //p1.sym = '*';

            p1.Draw();

            Point p2 = new Point(4, 7, '#'); // второй объект из класса Point 
            //p2.x = 4;
            //p2.y = 7;
            //p2.sym = '#';

            p2.Draw();


            // экспериментируем с созданием списка, присвоением элементам списка значений и выводом этих значений на экран
            //List<char> charList = new List<char>();
            //charList.Add('&');
            //charList.Add('$');
            //charList.Add('@');

            //foreach (char i in charList)
            //{
            //    Console.WriteLine(i);
            //}

            // создаем список из точек и выводим его на экран
            //Point p3 = new Point(10, 10, '%');
            //Point p4 = new Point(10, 11, '&');
            //Point p5 = new Point(10, 12, '$');
            //Point p6 = new Point(10, 13, '^');

            //List<Point> pointList = new List<Point>();
            //pointList.Add(p3);
            //pointList.Add(p4);
            //pointList.Add(p5);
            //pointList.Add(p6);

            //foreach (Point i in pointList)
            //{
            //    i.Draw();
            //}

            //задержка
            Console.ReadLine();
        }
    }
}
