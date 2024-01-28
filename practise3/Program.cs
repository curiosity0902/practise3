using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            while (true)
            {
                Console.WriteLine("Введите длины сторон треугольника:");

                if (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.WriteLine("Некорректное значение для стороны a");
                    continue;
                }

                if (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.WriteLine("Некорректное значение для стороны b");
                    continue;
                }

                if (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    Console.WriteLine("Некорректное значение для стороны c");
                    continue;
                }

                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    Console.WriteLine("Треугольник с такими сторонами не существует");
                    continue;
                }

                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    Console.WriteLine("Треугольник прямоугольный");
                }
                else if (a * a + b * b < c * c || a * a + c * c < b * b || b * b + c * c < a * a)
                {
                    Console.WriteLine("Треугольник тупоугольный");
                }
                else
                {
                    Console.WriteLine("Треугольник остроугольный");
                }

                break;
            }
            Console.ReadKey();
        }
    }
}
