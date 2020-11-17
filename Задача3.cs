using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    //Фамилия - Крупский
    //Задача:
    //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
    //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
    //б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
    class Program
    {
        static double Rast(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Последовательно введите координаты первой точки x и y");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Последовательно введите координаты второй точки x и y");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Расстояние между точками: " + "{0:f2}", Rast(x1, y1, x2, y2));

            Console.ReadLine();
        }
    }
}
