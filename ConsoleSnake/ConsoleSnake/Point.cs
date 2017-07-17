using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSnake
{
    class Point
    {
        // наш новый класс, который будет отвечать за рисование точки.
        // сейчас при создании в нем есть три пустых переменных двух различных типов
        // после создания мы передаем в него переменные из метода Маin

        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym) //пользовательский конструктор
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw() // метод берет переданные в этот класс переменные. Видимость полей и невидимость локальных переменных
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
