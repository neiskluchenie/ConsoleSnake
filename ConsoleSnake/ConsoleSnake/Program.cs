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
            
            int x1 = 1; //координаты первой точки
            int y1 = 3;
            char sym1 = '*';

            Draw(x1, y1, sym1);

            int x2 = 4; // координаты второй точки
            int y2 = 7;
            char sym2 = '#';

            Draw(x2, y2, sym2);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        // метод ничего не возвращает, принимает координаты и тип символа, выводит их на экран
                {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
                }
        
    }
}
